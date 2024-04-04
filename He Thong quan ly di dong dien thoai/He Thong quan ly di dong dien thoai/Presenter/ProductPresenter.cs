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

            this.spBindlingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            this._view.SearchEvent += searchProduct;
            this._view.AddNewEvent += themSanPhamMoi;
            this._view.EditEvent += suaSanPham;
            this._view.DeleteEvent += xoaSanPham;
            this._view.SaveEvent += luuSanPham;
            this._view.CancelEvent += huySanPham;
            // set blinding for product 

            this._view.SetProductBlindingSource(spBindlingSource);

            // load product

            LoadAllProductList();
            // Show view 

            this._view.Show();
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

        private void huySanPham(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void luuSanPham(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void xoaSanPham(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void suaSanPham(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void themSanPhamMoi(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}
