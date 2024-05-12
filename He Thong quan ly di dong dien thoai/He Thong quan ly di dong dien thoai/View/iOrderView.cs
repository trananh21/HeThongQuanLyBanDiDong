using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public interface iOrderView
    {
        int OrderIDView { get; set; } // mã đơn hàng
        string NameProductView {  get; set; } // tên sản phẩm
        decimal PriceView { get; set; } // giá tiền
        int AmountView { get; set; } // số lượng
        decimal SumPriceView { get; set; } // tongtien = gia * soLuong
        DateTime DateView { get; set; } // ngày mua 
        string NameCustomerView { get; set; } // tên khách hàng
        string PhoneNumberView { get; set; } // số điện thoại 
        string AddressView { get; set; }
        string StatusView { get; set; } // trạng thái
        
        string TimKiem { get; set; }
        // check error
        bool isEdit { get; set; }
        bool isSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchOrderEvent; // tìm kiếm theo mã đơn hàng
        event EventHandler CreateOrder; // tạo lập đơn hàng
        event EventHandler EditOrderEvent;
        event EventHandler DeleteOrderEvent;
        event EventHandler SaveOrderEvent;
        event EventHandler CancelOrderEvent;

        void SetOrderBindingSource(BindingSource orderList);
        void Show();
    }
}
