using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class VoucherModel
    {
        private string voucherID;
        private string voucherName;
        private string voucherDescription;
        private DateTime voucherDateStart;
        private DateTime voucherDateEnd;



        [DisplayName("ID Voucher")]
        public string VoucherID { get => voucherID; set => voucherID = value; }


        [DisplayName("Tên Khuyến Mãi")]
        [Required(ErrorMessage = "Tên khuyến mãi không được để trống!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên khuyến mãi không được nhỏ hơn 3 ký tự và quá 100 ký tự!")]
        public string VoucherName { get => voucherName; set => voucherName = value; }


        [DisplayName("Mô Tả Khuyến Mãi")]
        [Required(ErrorMessage = "Mô tả khuyến mãi không được để trống!")]
        public string VoucherDescription { get => voucherDescription; set => voucherDescription = value; }

        [DisplayName("Ngày Bắt Đầu")]
        [Required(ErrorMessage = "Ngày bắt đầu không được để trống!")]
        public DateTime VoucherDateStart { get => voucherDateStart; set => voucherDateStart = value; }

        [DisplayName("Ngày Kết Thúc")]
        [Required(ErrorMessage = "Ngày kết thúc không được để trống!")]
        public DateTime VoucherDateEnd { get => voucherDateEnd; set => voucherDateEnd = value; }
    }
}
