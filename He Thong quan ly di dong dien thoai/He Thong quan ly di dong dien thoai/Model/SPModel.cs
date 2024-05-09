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
        // Mọi thứ được code trong Models sẽ luôn phải Data Validates
        // ánh xạ vào các trường trong bảng Sản phẩm SQL
        private int MaSanPham; 
        private string TenSanPham;
        //private int MaDanhMuc;
        public string cbDanhMuc;
        private int _maDanhMuc;
        private decimal Gia;
        private string MoTa;

        // mã sản phẩm
        [DisplayName("ID")]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống")]
        public int MaSanPham1 { get => MaSanPham; set => MaSanPham = value; }


        // tên sản phẩm 
        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên sản phẩm không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string TenSanPham1 { get => TenSanPham; set => TenSanPham = value; }


        // Tên danh mục
        // Khai báo DanhMucList và khởi tạo nó trong hàm tạo của lớp SPModel
        public List<string> DanhMucList { get; set; }

        public SPModel()
        {
            // Khởi tạo DanhMucList khi khởi tạo một đối tượng SPModel mới
            DanhMucList = new List<string>();
        }

        // Các thuộc tính khác như bạn đã định nghĩa

        [DisplayName("Tên Danh Mục")]
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Tên danh mục không được nhỏ hơn 3 ký tự và quá 50 ký tự")]
        public string CbDanhMuc
        {
            get => cbDanhMuc; set => cbDanhMuc = value;
        }




        // Giá tiền 
        [DisplayName("Giá")]
        [Required(ErrorMessage = "Giá tiền không được để trống")]
        public decimal Gia1 { get => Gia; set => Gia = value; }


        // mô tả
        [DisplayName("Mô Tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string MoTa1 { get => MoTa; set => MoTa = value; }
    }
}
