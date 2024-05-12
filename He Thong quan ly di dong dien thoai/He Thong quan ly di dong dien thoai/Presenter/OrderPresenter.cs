using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Presenter
{
    public class OrderPresenter
    {
        //Fields
        private iOrderView _view;
        private iOrderRepository _repository;
        private BindingSource orderBindingSource; // quản lí việc ràng buộc 
        private IEnumerable<OrderModel> orderList; // giữ danh sách 


        public OrderPresenter(iOrderView view, iOrderRepository repository)
        {
            this._view = view;
            this._repository = repository;

            // su kien 
            this._view.SearchOrderEvent += searchOrder;
            this._view.CreateOrder += addOrder;
            this._view.EditOrderEvent += editOrder;
            this._view.DeleteOrderEvent += removeOrder;
            this._view.SaveOrderEvent += saveOrder;
            this._view.CancelOrderEvent += cancelOrder;
            // set blinding for product 
            this.orderBindingSource = new BindingSource();
            this._view.SetOrderBindingSource(orderBindingSource);

            // load product

            LoadAllOrderList();
            // Show view 

            this._view.Show();
        }

        private void cancelOrder(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void saveOrder(object sender, EventArgs e)
        {
            var model = new OrderModel();
            model.IdOrder = _view.OrderIDView;
            model.NameOrder = _view.NameProductView;
            model.PriceOrder = _view.PriceView;
            model.AmountOrder = _view.AmountView;
            model.TongTien = _view.SumPriceView;
            model.OrderDate = _view.DateView;
            model.NameCustomer = _view.NameCustomerView;
            model.PhonenumberOrder = _view.PhoneNumberView;
            model.AddressOrder = _view.AddressView;
            model.Status = _view.StatusView;

            try
            {


                new Common.ModelDataValidation().Validate(model);

                if (_view.isEdit)
                {
                    _repository.EditOrder(model);
                    _view.Message = "Thay đổi thông tin đơn hàng thành công!";
                }
                else // Add new model
                {
                    _repository.AddOrder(model);
                    _view.Message = "Tạo đơn hàng thành công!";
                }

                _view.isSuccessful = true;

                LoadAllOrderList();

                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.isSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        public Form GetOrderViewForm()
        {
            return (Form)_view;
        }

        private void removeOrder(object sender, EventArgs e)
        {
            try
            {
                var order = (OrderModel)orderBindingSource.Current;
                _repository.RemoveOrder((int)order.IdOrder);
                _view.isSuccessful = true;
                _view.Message = "Đã xoá đơn hàng thành công!";
                LoadAllOrderList();
            }
            catch
            {
                _view.isSuccessful = false;
                _view.Message = "Đã xảy ra lỗi, không thể xoá đơn hàng";
            }
        }

        private void editOrder(object sender, EventArgs e)
        {
            try
            {
                var order = (OrderModel)orderBindingSource.Current;
                _view.OrderIDView = order.IdOrder;
                _view.NameProductView = order.NameOrder;
                _view.PriceView = (int)order.PriceOrder;
                _view.AmountView = order.AmountOrder;
                _view.SumPriceView = (int)order.TongTien;
                _view.DateView = order.OrderDate;
                _view.NameCustomerView = order.NameCustomer;
                _view.PhoneNumberView = order.PhonenumberOrder;
                _view.AddressView = order.AddressOrder;
                _view.StatusView = order.Status;

                _view.isEdit = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addOrder(object sender, EventArgs e)
        {
            _view.isEdit = false;
        }

        private void searchOrder(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.TimKiem);
            if (emptyValue == false)
                orderList = _repository.GetByValueOrder(this._view.TimKiem);
            else orderList = _repository.GetAllOrder();
            orderBindingSource.DataSource = orderList;
        }


        private void CleanViewFields()
        {
            _view.OrderIDView = 0;
            _view.NameProductView = "";
            _view.PriceView = 0;
            _view.AmountView = 0;
            _view.SumPriceView = 1;
            _view.DateView = DateTime.Now;
            _view.NameCustomerView = "";
            _view.PhoneNumberView = "";
            _view.AddressView = "";
        }


        private void LoadAllOrderList()
        {
            orderList = _repository.GetAllOrder();
            orderBindingSource.DataSource = orderList; // set data source
        }
    }
}
