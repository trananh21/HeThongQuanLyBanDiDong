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
        private bool showNotification = false;
        public paymentView()
        {
            InitializeComponent();
            RoundPanel(panelDetailOrder, 20);
            RoundPanel(panelThongtinThanhToan, 20);
            LoadPaymentData();
            this.tabControlPayment.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControlPayment.DrawItem += new DrawItemEventHandler(this.tabControlPayment_DrawItem);
            this.tabControlPayment.SelectedIndexChanged += new EventHandler(this.tabControlPayment_SelectedIndexChanged);
            lblMaHoaDon.Text = GenerateNewInvoiceID().ToString();
        }

        public int mahoadon { get => int.Parse(lblMaHoaDon.Text); set => lblMaHoaDon.Text = value.ToString(); }
        public int maDonHang { get => int.Parse(lblMaDonHang.Text); set => lblMaDonHang.Text = value.ToString(); }
        public string tenkhachhang { get => lblTenKhachHang.Text; set => lblTenKhachHang.Text = value; }
        public decimal tongtien { get => decimal.Parse(lblTongTien.Text); set => lblTongTien.Text = value.ToString(); }
        public int soluong { get => int.Parse(lblSoLuong.Text); set => lblSoLuong.Text = value.ToString(); }
        public string ngaymua { get => lblNgayMua.Text; set => lblNgayMua.Text = value; }

        private int GenerateNewInvoiceID()
        {
            Random random = new Random();
            int newInvoiceID = random.Next(100000, 999999); // Tạo số ngẫu nhiên trong khoảng từ 100000 đến 999999
            return newInvoiceID; // Chuyển đổi số ngẫu nhiên thành chuỗi
        }

        public void UpdateTabNotification(bool show)
        {
            showNotification = show; // Hiển thị thông báo trên tab "Xác thực hoá đơn"
            tabControlPayment.Invalidate(); // Vẽ lại TabControl để hiển thị thông báo
        }

        private void LoadPaymentData()
        {
            string query = @"SELECT 
                            tt.MaThanhToan AS 'ID', 
                            dh.MaDonHang AS 'ID Order', 
                            kh.HoTen AS N'Tên Khách Hàng', 
                            SanPham.TenSanPham AS N'Tên Sản Phẩm', 
                            tt.SoTien AS N'Số Tiền', 
                            ctdh.SoLuong AS N'Số Lượng', 
                            km.MaKhuyenMai AS N'ID Voucher', 
                            tt.NgayThanhToan AS N'Ngày Thanh Toán', 
                            dh.TrangThai AS N'Trạng Thái'
                        FROM 
                            ThanhToan tt
                        INNER JOIN 
                            DonHang dh ON tt.MaDonHang = dh.MaDonHang
                        INNER JOIN 
                            KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
                        INNER JOIN 
                            ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
                        INNER JOIN 
                            SanPham ON ctdh.MaSanPham = SanPham.MaSanPham
                        INNER JOIN 
                            KhuyenMai km ON ctdh.MaSanPham = SanPham.MaSanPham
                            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvPayment.DataSource = dataTable;
            }
        }

        public void SelectTabXacThucHoaDon()
        {
            // Chuyển sang tab "Xác thực hoá đơn"
            tabControlPayment.SelectedIndex = 1;
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

        private void tabControlPayment_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), tabRect);
            TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font, tabRect, tabPage.ForeColor);
            if (e.Index == 1 && showNotification) 
            {
                string labelText = "1";
                int diameter = 20;
                Rectangle circleRect = new Rectangle(tabRect.Right - diameter - 5, tabRect.Top + (tabRect.Height - diameter) / 2, diameter, diameter);
                e.Graphics.FillEllipse(Brushes.Red, circleRect);
                TextRenderer.DrawText(e.Graphics, labelText, tabPage.Font, circleRect, Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }

        private void tabControlPayment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlPayment.SelectedIndex == 1) // "Xác thực hoá đơn"
            {
                showNotification = false; // Xóa thông báo khi nhấn vào tab "Xác thực hoá đơn"
                tabControlPayment.Invalidate(); // Force the control to repaint
            }
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvPayment_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dgvPayment.Columns.Count; i++)
            {
                dgvPayment.Columns[i].DisplayIndex = i;
            }
        }
    }

}
