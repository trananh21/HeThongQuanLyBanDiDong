﻿using System;
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
            var product = (SPModel)spBindlingSource.Current;
            // do methods SPID để là int => không cần phải product.MaSanPham1.ToString()
            // khoong canaf phair them ma danh muc 
            _view.SPID = product.MaSanPham1; // ispview & spmodel
            _view.TenSanPham = product.TenSanPham1;// ispview & spmodel
            _view.TenDanhMuc = product.cbDanhMuc;// ispview & spmodel
            _view.Gia = product.Gia1;// ispview & spmodel
            _view.MoTa = product.MoTa1;// ispview & spmodel
            _view.isEdit = true;// ispview & spmodel

        }
        private void luuSanPham(object sender, EventArgs e)
        {
            var model = new SPModel();
            // không cần phải convert từ string về int đối với SPID
            // khoong canaf phair them ma danh muc 
            model.MaSanPham1 = (int)_view.SPID;
            model.TenSanPham1 = _view.TenSanPham;
            model.cbDanhMuc = _view.TenDanhMuc;
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
            _view.SPID = 0;
            _view.TenSanPham = "";
            _view.TenDanhMuc = "";
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
