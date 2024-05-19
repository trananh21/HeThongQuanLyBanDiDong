using He_Thong_quan_ly_di_dong_dien_thoai.Model;
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
                                tt.MaThanhToan AS MaHoaDon,
                                dh.MaDonHang,
                                kh.HoTen AS TenKhachHang,
                                sp.TenSanPham,
                                tt.SoTien,
                                ctdh.SoLuong,
                                km.MaKhuyenMai,
                                tt.NgayThanhToan,
                                dh.TrangThai
                            FROM 
                                ThanhToan tt
                            JOIN 
                                DonHang dh ON tt.MaDonHang = dh.MaDonHang
                            JOIN 
                                ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
                            JOIN 
                                SanPham sp ON ctdh.MaSanPham = sp.MaSanPham
                            JOIN 
                                KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
                            LEFT JOIN 
                                ChiTietKhuyenMai ctkm ON sp.MaSanPham = ctkm.MaSanPham
                            LEFT JOIN 
                                KhuyenMai km ON ctkm.MaKhuyenMai = km.MaKhuyenMai
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
        BindingList<PaymentInfo> paymentInfoList = new BindingList<PaymentInfo>();
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                try
                {
                    SqlTransaction transaction = conn.BeginTransaction();

                    // Cập nhật trạng thái đơn hàng
                    SqlCommand updateCommand = new SqlCommand(
                        "UPDATE DonHang SET TrangThai = 'Đã thanh toán' WHERE MaDonHang = @MaDonHang", conn, transaction);
                    updateCommand.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    updateCommand.ExecuteNonQuery();

                    // Bật IDENTITY_INSERT cho bảng ThanhToan
                    SqlCommand enableIdentityInsertCommand = new SqlCommand(
                        "SET IDENTITY_INSERT ThanhToan ON", conn, transaction);
                    enableIdentityInsertCommand.ExecuteNonQuery();

                    // Thêm bản ghi mới vào bảng ThanhToan
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO ThanhToan (MaThanhToan, MaDonHang, SoTien, NgayThanhToan) VALUES (@MaThanhToan, @MaDonHang, @SoTien, @NgayThanhToan)", conn, transaction);
                    insertCommand.Parameters.AddWithValue("@MaThanhToan", mahoadon);
                    insertCommand.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    insertCommand.Parameters.AddWithValue("@SoTien", tongtien);
                    insertCommand.Parameters.AddWithValue("@NgayThanhToan", DateTime.Now);
                    insertCommand.ExecuteNonQuery();

                    // Tắt IDENTITY_INSERT cho bảng ThanhToan
                    SqlCommand disableIdentityInsertCommand = new SqlCommand(
                        "SET IDENTITY_INSERT ThanhToan OFF", conn, transaction);
                    disableIdentityInsertCommand.ExecuteNonQuery();

                    // Commit giao dịch
                    transaction.Commit();

                    // Lấy dữ liệu để hiển thị lên DataGridView
                    SqlCommand selectCommand = new SqlCommand(
                        @"SELECT 
                    tt.MaThanhToan AS MaHoaDon,
                    dh.MaDonHang,
                    kh.HoTen AS TenKhachHang,
                    sp.TenSanPham,
                    tt.SoTien,
                    ctdh.SoLuong,
                    km.MaKhuyenMai,
                    tt.NgayThanhToan,
                    dh.TrangThai
                    FROM 
                        ThanhToan tt
                    JOIN 
                        DonHang dh ON tt.MaDonHang = dh.MaDonHang
                    JOIN 
                        ChiTietDonHang ctdh ON dh.MaDonHang = ctdh.MaDonHang
                    JOIN 
                        SanPham sp ON ctdh.MaSanPham = sp.MaSanPham
                    JOIN 
                        KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
                    LEFT JOIN 
                        ChiTietKhuyenMai ctkm ON sp.MaSanPham = ctkm.MaSanPham
                    LEFT JOIN 
                        KhuyenMai km ON ctkm.MaKhuyenMai = km.MaKhuyenMai
                    WHERE 
                        tt.MaThanhToan = @MaThanhToan", conn);
                    selectCommand.Parameters.AddWithValue("@MaThanhToan", mahoadon);

                    // Đọc dữ liệu
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PaymentInfo paymentInfo = new PaymentInfo();
                            paymentInfo.MaHoaDon = reader.IsDBNull(reader.GetOrdinal("MaHoaDon")) ? 0 : reader.GetInt32(reader.GetOrdinal("MaHoaDon"));
                            paymentInfo.MaDonHang = reader.IsDBNull(reader.GetOrdinal("MaDonHang")) ? 0 : reader.GetInt32(reader.GetOrdinal("MaDonHang"));
                            paymentInfo.TenKhachHang = reader.IsDBNull(reader.GetOrdinal("TenKhachHang")) ? string.Empty : reader.GetString(reader.GetOrdinal("TenKhachHang"));
                            paymentInfo.TenSanPham = reader.IsDBNull(reader.GetOrdinal("TenSanPham")) ? string.Empty : reader.GetString(reader.GetOrdinal("TenSanPham"));
                            paymentInfo.SoTien = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? 0 : reader.GetDecimal(reader.GetOrdinal("SoTien"));
                            paymentInfo.SoLuong = reader.IsDBNull(reader.GetOrdinal("SoLuong")) ? 0 : reader.GetInt32(reader.GetOrdinal("SoLuong"));
                            paymentInfo.MaKhuyenMai = reader.IsDBNull(reader.GetOrdinal("MaKhuyenMai")) ? 0 : reader.GetInt32(reader.GetOrdinal("MaKhuyenMai"));
                            paymentInfo.NgayThanhToan = reader.IsDBNull(reader.GetOrdinal("NgayThanhToan")) ? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("NgayThanhToan"));
                            paymentInfo.TrangThai = reader.IsDBNull(reader.GetOrdinal("TrangThai")) ? string.Empty : reader.GetString(reader.GetOrdinal("TrangThai"));

                            paymentInfoList.Add(paymentInfo);
                        }
                        dgvPayment.DataSource = paymentInfoList;
                    }
                    // Hiển thị thông báo xác nhận
                    MessageBox.Show("Hoá đơn đã được xác nhận!");
                    tabControlPayment.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
                }
            }
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
