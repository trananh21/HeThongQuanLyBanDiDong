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
        /*
            private int MaSanPham;
            private string TenSanPham;
            private string TenDanhMuc;
            private int MaDanhMuc;
            private decimal Gia;
            private string MoTa;
        */
        // Thuoc tinh  - truong
        int SPID { get; set; }
        string TenSanPham { get; set; }
        //int MaDanhMuc { get; set; }
        decimal Gia { get; set; }
        string MoTa { get; set; }
        string TenDanhMuc { get; set; }
        string TimKiem { get; set; } // tim kiem san pham trong danh sách
        bool isEdit {  get; set; }
        bool isSuccessful {  get; set; }
        string Message { get; set; }
        /*
            ------
            Su kien - EventHandler: kết nối các phương thức xử lý với sự kiện cụ thể, dùng để xử lý click chuột,
            thay đổi giá trị, hoặc các sự kiện tương tác người dùng khác trong ứng dụng Windows 
            hoặc các framework khác.
            ------
            object sender: đối tượng gửi sự kiện.
            ------
            EventArgs e: Đối tượng chứa dữ liệu liên quan đến sự kiện.
            ------
        */

        event EventHandler SearchEvent; // Sự kiện tìm kiếm 
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductBlindingSource(BindingSource productList);
        void Show();



    }
}
