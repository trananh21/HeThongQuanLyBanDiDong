using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public interface iSPView
    {

        int MaSanPham { get; set; }
        string TenSanPham { get; set; }

        decimal Gia { get; set; }
        string MoTa { get; set; }
        string CbDanhMuc { get; set; }
        string TimKiem { get; set; } // tim kiem san pham trong danh sách
        bool isEdit {  get; set; }
        bool isSuccessful {  get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent; // Sự kiện tìm kiếm 
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductBindingSource(BindingSource productList);
        void Show();




    }
}
