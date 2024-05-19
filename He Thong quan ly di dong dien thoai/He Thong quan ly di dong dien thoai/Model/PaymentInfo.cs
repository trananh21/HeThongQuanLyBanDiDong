using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class PaymentInfo
    {
        public int MaHoaDon { get; set; }
        public int MaDonHang { get; set; }
        public string TenKhachHang { get; set; }
        public string TenSanPham { get; set; }
        public decimal SoTien { get; set; }
        public int SoLuong { get; set; }
        public string MaKhuyenMai { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public string TrangThai { get; set; }
    }
}
