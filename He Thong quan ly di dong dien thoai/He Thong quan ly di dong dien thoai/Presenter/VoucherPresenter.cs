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
    public class VoucherPresenter
    {
        private iVoucherView _view;
        private iVoucherReponsitory _repository;
        private BindingSource voucherBindingSource; // quản lí việc ràng buộc 
        private IEnumerable<VoucherModel> vouList; // giữ danh sách 

        public VoucherPresenter(iVoucherView view, iVoucherReponsitory repository)
        {
            this._view = view;
            this._repository = repository;

            // su kien 
            this._view.SearchVoucher += searchVouchers;
            this._view.AddNewVoucher += addVouchers;
            this._view.EditVoucher += editVouchers;
            this._view.DeletetVoucher += deleteVouchers;
            this._view.SaveVoucher += saveVouchers;
            this._view.CancelVoucher += cancelVouchers;
            // set blinding for product 
            this.voucherBindingSource = new BindingSource();
            this._view.SetVoucherBindingSource(voucherBindingSource);

            // load product

            LoadAllVoucherList();
            // Show view 

            this._view.Show();
        }

        public Form GetVoucherViewForm()
        {
            return (Form)_view;
        }

        private void LoadAllVoucherList()
        {
            vouList = _repository.GetAllVoucher();
            voucherBindingSource.DataSource = vouList; // set data source
        }
        private void CleanViewFields()
        {
            _view.idVoucherView = "";
            _view.nameVoucherView = "";
            _view.descriptionVoucherView = "";
            _view.dateStartView = DateTime.Now;
            _view.dateEndView = DateTime.Now;
        }
        private void cancelVouchers(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void saveVouchers(object sender, EventArgs e)
        {
            var model = new VoucherModel();
            model.VoucherID = _view.idVoucherView;
            model.VoucherName = _view.nameVoucherView;
            model.VoucherDescription = _view.descriptionVoucherView;
            model.VoucherDateStart = _view.dateStartView;
            model.VoucherDateEnd = _view.dateEndView;
            try
            {


                new Common.ModelDataValidation().Validate(model);

                if (_view.isEdit)
                {
                    _repository.ChangeVoucher(model);
                    _view.Message = "Thay đổi thông tin sản phẩm thành công!";
                }
                else // Add new model
                {
                    _repository.CreateVoucherNew(model);
                    _view.Message = "Thêm sản phẩm thành công!";
                }

                _view.isSuccessful = true;

                LoadAllVoucherList();

                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.isSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void deleteVouchers(object sender, EventArgs e)
        {
            try
            {
                var vou = (VoucherModel)voucherBindingSource.Current;
                _repository.RemoveVoucher(vou.VoucherID);
                _view.isSuccessful = true;
                _view.Message = "Đã xoá sản phẩm thành công!";
                LoadAllVoucherList();
            }
            catch
            {
                _view.isSuccessful = false;
                _view.Message = "Đã xảy ra lỗi, không thể xoá sản phẩm";
            }
        }

        private void editVouchers(object sender, EventArgs e)
        {

            try
            {
                var voucher = (VoucherModel)voucherBindingSource.Current;
                _view.idVoucherView = voucher.VoucherID;
                _view.nameVoucherView = voucher.VoucherName;// ispview & spmodel
                _view.descriptionVoucherView = voucher.VoucherDescription;// ispview & spmodel
                _view.dateStartView = voucher.VoucherDateStart;// ispview & spmodel
                _view.dateEndView = voucher.VoucherDateEnd;// ispview & spmodel
                _view.isEdit = true;// ispview & spmodel
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addVouchers(object sender, EventArgs e)
        {
            _view.isEdit = false;
        }

        private void searchVouchers(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.TimKiem);
            if (emptyValue == false)
                vouList = _repository.GetByValueVoucher(this._view.TimKiem);
            else vouList = _repository.GetAllVoucher();
            voucherBindingSource.DataSource = vouList;
        }
    }
}
