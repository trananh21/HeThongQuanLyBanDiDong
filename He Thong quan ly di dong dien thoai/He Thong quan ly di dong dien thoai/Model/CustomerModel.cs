using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class CustomerModel
    {
        // Mọi thứ được code trong Models sẽ luôn phải Data Validates
        // ánh xạ vào các trường trong bảng Sản phẩm SQL
        private int CustomerID;
        private string CustomerName;
        public string CustomerEmail;
        private string CustomerPhoneNumber;
        private string CustomerAddress;

        // mã khách hàng
        [DisplayName("ID")]
        [Required(ErrorMessage = "Mã khách hàng không được để trống")]
        public int customerID { get => CustomerID; set => CustomerID = value; }


        // tên khách hàng
        [DisplayName("Họ Tên")]
        [Required(ErrorMessage = "Họ tên không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sản phẩm không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string customerName { get => CustomerName; set => CustomerName = value; }

        // email
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Email không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string customerEmail
        {
            get => CustomerEmail; set => CustomerEmail = value;
        }


        // điện thoại
        [DisplayName("Điện Thoại")]
        [Required(ErrorMessage = "Điện thoại không được để trống")]
        public string customerPhoneNumber { get => CustomerPhoneNumber; set => CustomerPhoneNumber = value; }


        // địa chỉ
        [DisplayName("Địa Chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        public string customerAddress { get => CustomerAddress; set => CustomerAddress = value; }
    }
}
