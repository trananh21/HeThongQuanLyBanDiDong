using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class SPModel
    {
        // ánh xạ vào các trường trong bảng Sản phẩm SQL
        private int MaSanPham; 
        private string TenSanPham;
        private string TenDanhMuc;
        private int MaDanhMuc;
        private decimal Gia;
        private string MoTa;
        // Mọi thứ được code trong Models sẽ luôn phải Data Validates

        // Các thuộc tính có thể truy cập vào
        // get để lấy dữ liệu,
        // set để thiết lập dữ liệu
        [DisplayName("ID")]
        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }

        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sản phẩm không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }


        [DisplayName("Tên Danh Mục")]

        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên danh mục không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string TenDanhMuc1 { get => TenDanhMuc; set => TenDanhMuc = value; }

        // có thể có hoặc không tại vì Mã Danh Mục theo SQL thì sẽ luôn tăng tự động nếu sửa mã danh mục => nguy cơ trùng mã
        // nên không cần Validate ô nhập txtMaDanhMuc => bỏ phần nhập liệu mã danh mục
        //[DisplayName("Mã Danh Mục")]
        //public int MaDanhMuc1 { get => MaDanhMuc; set => MaDanhMuc = value; }

        [DisplayName("Giá")]
        [Required(ErrorMessage = "Giá tiền không được để trống")]
        public decimal Gia1 { get => Gia; set => Gia = value; }

        [DisplayName("Mô Tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string MoTa1 { get => MoTa; set => MoTa = value; }
    }
}
