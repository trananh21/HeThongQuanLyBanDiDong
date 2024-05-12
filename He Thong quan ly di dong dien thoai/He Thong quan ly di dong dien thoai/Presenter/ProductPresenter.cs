using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
namespace He_Thong_quan_ly_di_dong_dien_thoai.Presenter
{
    public class ProductPresenter
    {
        //Fields
        private iSPView _view;
        private iSPRepository _repository;
        private BindingSource spBindlingSource; // quản lí việc ràng buộc 
        private IEnumerable<SPModel> spList; // giữ danh sách 


        // constructor có tham số truyền vào 
        public ProductPresenter(iSPView view, iSPRepository repository)
        {
            this._view = view;
            this._repository = repository;

            // su kien 
            this._view.SearchEvent += searchProduct;
            this._view.AddNewEvent += themSanPhamMoi;
            this._view.EditEvent += suaSanPham;
            this._view.DeleteEvent += xoaSanPham;
            this._view.SaveEvent += luuSanPham;
            this._view.CancelEvent += huySanPham;
            // set blinding for product 
            this.spBindlingSource = new BindingSource();
            this._view.SetProductBindingSource(spBindlingSource);

            // load product

            LoadAllProductList();
            // Show view 

            this._view.Show();
        }

        public Form GetProductViewForm()
        {
            return (Form)_view;
        }

        private void LoadAllProductList()
        {
            spList = _repository.GetAll();
            spBindlingSource.DataSource = spList; // set data source
        }
        private void searchProduct(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.TimKiem);
            if (emptyValue == false)
                spList = _repository.GetByValue(this._view.TimKiem);
            else spList = _repository.GetAll();
            spBindlingSource.DataSource = spList;
        }
        // Tải toàn bộ danh sách sản phẩm từ repository và đặt làm nguồn dữ liệu cho 
        private void themSanPhamMoi(object sender, EventArgs e)
        {
            _view.isEdit = false;
        }
        private void suaSanPham(object sender, EventArgs e)
        {
            try
            {
                var product = (SPModel)spBindlingSource.Current;
                _view.MaSanPham = product.MaSanPham1;
                _view.TenSanPham = product.TenSanPham1;// ispview & spmodel
                _view.CbDanhMuc = product.cbDanhMuc;// ispview & spmodel
                _view.Gia = product.Gia1;// ispview & spmodel
                _view.MoTa = product.MoTa1;// ispview & spmodel
                _view.isEdit = true;// ispview & spmodel
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void luuSanPham(object sender, EventArgs e)
        {
            var model = new SPModel();
            model.MaSanPham1 = _view.MaSanPham;
            model.TenSanPham1 = _view.TenSanPham;
            model.CbDanhMuc = _view.CbDanhMuc;
            model.Gia1 = _view.Gia;
            model.MoTa1 = _view.MoTa;
            try
            {


                new Common.ModelDataValidation().Validate(model);

                if (_view.isEdit)
                {
                    _repository.SuaThongTin(model);
                    _view.Message = "Thay đổi thông tin sản phẩm thành công!";
                }
                else // Add new model
                {
                    _repository.ThemThongTin(model);
                    _view.Message = "Thêm sản phẩm thành công!";
                }

                _view.isSuccessful = true;

                LoadAllProductList();

                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.isSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            _view.MaSanPham = 0;
            _view.TenSanPham = "";
            _view.CbDanhMuc = "";
            _view.Gia = 0;
            _view.MoTa = "";
        }

        private void huySanPham(object sender, EventArgs e)
        {
            CleanViewFields();
        }


        private void xoaSanPham(object sender, EventArgs e)
        {
            try
            {
                var sp = (SPModel)spBindlingSource.Current;
                _repository.XoaThongTin((int)sp.MaSanPham1);
                _view.isSuccessful = true;
                _view.Message = "Đã xoá sản phẩm thành công!";
                LoadAllProductList();
            }
            catch
            {
                _view.isSuccessful = false;
                _view.Message = "Đã xảy ra lỗi, không thể xoá sản phẩm";
            }
        }



    }
}
