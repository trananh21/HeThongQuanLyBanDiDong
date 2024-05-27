using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class OrderModel
    {
        private int idOrder; // mã đơn 
        private string nameOrder; // tên sản phẩm
        private decimal priceOrder;// giá tiền
        private int amountOrder; // số lượng
        private decimal tongtien; // tongtien = gia * soluong
        private DateTime setDateOrder;
        private string nameCustomer;
        private string phonenumberOrder;
        private string addressOrder;
        private string status;
        // mã đơn hàng
        [DisplayName("ID Order")]
        [Required(ErrorMessage = "Mã đơn hàng không được để trống!")]
        public int IdOrder { get => idOrder; set => idOrder = value; }

        //tên sản phẩm
        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sản phẩm không được nhỏ hơn 3 ký tự và quá 50 ký tự!")]
        public string NameOrder { get => nameOrder; set => nameOrder = value; }

        // giá tiền
        [DisplayName("Giá Tiền")]
        [Required(ErrorMessage = "Giá tiền không được để trống!")]
        public decimal PriceOrder { get => priceOrder; set => priceOrder = value; }

        // số lượng
        [DisplayName("Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống!")]
        [Range(1, int.MaxValue, ErrorMessage = "Số lượng phải lớn hơn 0!")]
        public int AmountOrder { get => amountOrder; set => amountOrder = value; }

        // tổng tiền
        [DisplayName("Tổng Tiền")]
        [Required(ErrorMessage = "Tổng tiền chưa được tính toán!")]
        [Range(0.01, float.MaxValue, ErrorMessage = "Tổng tiền phải lớn hơn 0!")]
        public decimal TongTien { get => tongtien; set => tongtien = value; }


        // ngày mua
        [DisplayName("Ngày Mua")]
        [Required(ErrorMessage = "Ngày mua hàng không được để trống!")]
        public DateTime OrderDate { get => setDateOrder; set => setDateOrder = value; }

        // tên khách hàng 
        [DisplayName("Tên Khách Hàng")]
        public string NameCustomer { get => nameCustomer; set => nameCustomer = value; }

        // số điện thoại
        [DisplayName("Điện Thoại")]
        public string PhonenumberOrder { get => phonenumberOrder; set => phonenumberOrder = value; }

        [DisplayName("Địa Chỉ")]
        public string AddressOrder { get => addressOrder; set => addressOrder = value; }

        [DisplayName("Trạng Thái")]
        [Required(ErrorMessage = "Trạng thái không được để trống!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Trạng thái không được nhỏ hơn 3 ký tự và quá 50 ký tự!")]
        public string Status { get => status; set => status = value; }
    }
}
