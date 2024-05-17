using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class paymentView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public paymentView()
        {
            InitializeComponent();
            RoundPanel(panelDetailOrder, 20);
            RoundPanel(panelThongtinThanhToan, 20);
            LoadPaymentData();
        }

        private void LoadPaymentData()
        {
            string query = @"SELECT 
                                ThanhToan.MaThanhToan, 
                                DonHang.MaDonHang, 
                                KhachHang.HoTen, 
                                SanPham.TenSanPham, 
                                ThanhToan.SoTien, 
                                ChiTietDonHang.SoLuong, 
                                ChiTietKhuyenMai.MaKhuyenMai, 
                                ThanhToan.NgayThanhToan, 
                                DonHang.TrangThai
                            FROM 
                                ThanhToan
                            INNER JOIN 
                                DonHang ON ThanhToan.MaDonHang = DonHang.MaDonHang
                            INNER JOIN 
                                KhachHang ON DonHang.MaKhachHang = KhachHang.MaKhachHang
                            INNER JOIN 
                                ChiTietDonHang ON DonHang.MaDonHang = ChiTietDonHang.MaDonHang
                            INNER JOIN 
                                SanPham ON ChiTietDonHang.MaSanPham = SanPham.MaSanPham
                            INNER JOIN 
                                ChiTietKhuyenMai ON ChiTietDonHang.MaSanPham = SanPham.MaSanPham
                            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvPayment.DataSource = dataTable;
            }
        }

        private void RoundPanel(Panel panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            panel.Region = new Region(path);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
