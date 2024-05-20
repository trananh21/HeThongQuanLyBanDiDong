using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public interface iVoucherView
    {
        string idVoucherView { get; set; } 
        string nameVoucherView { get; set; }
        string descriptionVoucherView { get; set; }
        DateTime dateStartView { get ; set; }
        DateTime dateEndView { get ; set; }
        string TimKiem { get; set; } // tim kiem san pham trong danh sách
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchVoucher; // Sự kiện tìm kiếm 
        event EventHandler AddNewVoucher;
        event EventHandler EditVoucher;
        event EventHandler DeletetVoucher;
        event EventHandler SaveVoucher;
        event EventHandler CancelVoucher;

        void SetVoucherBindingSource(BindingSource voucherList);
        void Show();
    }
}
