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
    public class CustomerPresenter
    {
        //Fields
        private iCustomerView _view;
        private iCustomerReponsitory _repository;
        private BindingSource cusBindingSource; // quản lí việc ràng buộc 
        private IEnumerable<CustomerModel> cusList; // giữ danh sách 
        private customerView customerView;
        private iCustomerReponsitory cusRepo;


        // constructor có tham số truyền vào 
        public CustomerPresenter(iCustomerView view, iCustomerReponsitory repository)
        {
            this._view = view;
            this._repository = repository;

            // su kien 
            this._view.SearchCustomerEvent += SearchCustomer;
            this._view.AddCustomerEvent += addNewCusTomer;
            this._view.EditCustomerEvent += changeCustomer;
            this._view.DeleteCustomerEvent += removeCustomer;
            this._view.SaveCustomerEvent += saveCustomer;
            this._view.CancelCustomerEvent += cancelTab;
            // set blinding for product 
            this.cusBindingSource = new BindingSource();
            this._view.SetProductBindingSource(cusBindingSource);

            // load product

            LoadAllCustomerList();
            // Show view 

            this._view.Show();
        }

        public CustomerPresenter(customerView customerView, iCustomerReponsitory cusRepo)
        {
            this.customerView = customerView;
            this.cusRepo = cusRepo;
        }

        private void LoadAllCustomerList()
        {
            cusList = _repository.GetAllCustomer();
            cusBindingSource.DataSource = cusList; // set data source
        }

        private void cancelTab(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void saveCustomer(object sender, EventArgs e)
        {
            var model = new CustomerModel();
            model.customerID = _view.idView;
            model.customerName = _view.NameCustomer;
            model.customerEmail = _view.EmailCustomer;
            model.customerPhoneNumber = _view.PhoneCustomer;
            model.customerAddress = _view.AddressCustomer;
            try
            {


                new Common.ModelDataValidation().Validate(model);

                if (_view.isEdit)
                {
                    _repository.EditCustomer(model);
                    _view.Message = "Thay đổi khách hàng thành công!";
                }
                else // Add new model
                {
                    _repository.AddCustomer(model);
                    _view.Message = "Thêm khách hàng thành công!";
                }

                _view.isSuccessful = true;

                LoadAllCustomerList();

                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.isSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void removeCustomer(object sender, EventArgs e)
        {
            try
            {
                var cus = (CustomerModel)cusBindingSource.Current;
                _repository.RemoveCustomer((int)cus.customerID);
                _view.isSuccessful = true;
                _view.Message = "Đã xoá khách hàng thành công!";
                LoadAllCustomerList();
            }
            catch
            {
                _view.isSuccessful = false;
                _view.Message = "Đã xảy ra lỗi, không thể xoá khách hàng này!";
            }
        }

        private void changeCustomer(object sender, EventArgs e)
        {
            try
            {
                var product = (CustomerModel)cusBindingSource.Current;
                _view.idView = product.customerID;
                _view.NameCustomer = product.customerName;// ispview & spmodel
                _view.EmailCustomer = product.CustomerEmail;// ispview & spmodel
                _view.PhoneCustomer = product.customerPhoneNumber;// ispview & spmodel
                _view.AddressCustomer = product.customerAddress;// ispview & spmodel
                _view.isEdit = true;// ispview & spmodel
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewCusTomer(object sender, EventArgs e)
        {
            _view.isEdit = false;
        }

        private void SearchCustomer(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.TimKiem);
            if (emptyValue == false)
                cusList = _repository.GetByValueCustomer(this._view.TimKiem);
            else cusList = _repository.GetAllCustomer();
            cusBindingSource.DataSource = cusList;
        }

        public Form GetCustomerViewForm()
        {
            return (Form)_view;
        }

        private void LoadAllProductList()
        {
            cusList = _repository.GetAllCustomer();
            cusBindingSource.DataSource = cusList; // set data source
        }
        
        private void CleanViewFields()
        {
            _view.idView = 0;
            _view.NameCustomer = "";
            _view.EmailCustomer = "";
            _view.PhoneCustomer = "";
            _view.AddressCustomer = "";
        }

        private void huySanPham(object sender, EventArgs e)
        {
            CleanViewFields();
        }
    }
}
