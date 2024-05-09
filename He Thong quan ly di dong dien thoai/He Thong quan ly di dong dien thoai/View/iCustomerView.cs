using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public interface iCustomerView
    {
        int idView { get; set; }
        string NameCustomer { get; set; }

        string EmailCustomer { get; set; }
        string PhoneCustomer { get; set; }
        string AddressCustomer { get; set; }
        string TimKiem { get; set; } // tim kiem san pham trong danh sách
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchCustomerEvent; // Sự kiện tìm kiếm 
        event EventHandler AddCustomerEvent;
        event EventHandler EditCustomerEvent;
        event EventHandler DeleteCustomerEvent;
        event EventHandler SaveCustomerEvent;
        event EventHandler CancelCustomerEvent;

        void SetProductBindingSource(BindingSource customerList);
        void Show();
    }
}
