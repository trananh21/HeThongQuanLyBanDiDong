using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace He_Thong_quan_ly_di_dong_dien_thoai.Model
{
    public class KhuyenMai
    {
        public KhuyenMai()
        {
            // Initialize ChiTietKhuyenMais to an empty list to avoid NullReferenceException
            ChiTietKhuyenMais = new List<ChiTietKhuyenMai>();
        }

        public string MaKhuyenMai { get; set; }
        public string TenKhuyenMai { get; set; }
        public string MoTa { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        // Initialize ChiTietKhuyenMais as a list
        public List<ChiTietKhuyenMai> ChiTietKhuyenMais { get; set; }
    }

    public class ChiTietKhuyenMai
    {
        public int MaChiTietKhuyenMai { get; set; }
        public string MaKhuyenMai { get; set; }
        public int MaSanPham { get; set; }
        public double GiamGia { get; set; }
        public int PhanTram { get; set; }
    }

}
