using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;
using Rectangle = System.Drawing.Rectangle;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class paymentView : Form
    {
        private SqlConnection conn = new SqlConnection(SQLConnections.KetnoiSQL());
        public string connectionString;
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
        public string tenkhuyenmai { get => txtMaKhuyenMai.Text; set => txtMaKhuyenMai.Text = value; }
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
            connectionString = conn.ConnectionString;
            string query = @"SELECT 
                tt.MaThanhToan AS MaHoaDon,
                dh.MaDonHang,
                kh.HoTen AS TenKhachHang,
                sp.TenSanPham,
                sp.Gia, 
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
                KhuyenMai km ON ctkm.MaKhuyenMai = km.MaKhuyenMai";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvPayment.DataSource = dataTable;
            }
        }

        private void UpdateKhuyenMaiToNull(string maDonHang)
        {
            string query = "UPDATE DonHang SET TenKhuyenMai = NULL WHERE MaDonHang = @MaDonHang";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaDonHang", maDonHang);

                connection.Open();
                command.ExecuteNonQuery();
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


        private List<ChiTietKhuyenMai> GetChiTietKhuyenMaisByMaKhuyenMai(int maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            List<ChiTietKhuyenMai> chiTietKhuyenMais = new List<ChiTietKhuyenMai>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT MaSanPham, PhanTram FROM ChiTietKhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai", conn);
                command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ChiTietKhuyenMai chiTiet = new ChiTietKhuyenMai
                        {
                            MaSanPham = reader.GetInt32(reader.GetOrdinal("MaSanPham")),
                            PhanTram = reader.GetInt32(reader.GetOrdinal("PhanTram"))
                        };
                        chiTietKhuyenMais.Add(chiTiet);
                    }
                }
            }
            return chiTietKhuyenMais;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            connectionString = conn.ConnectionString;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Cập nhật trạng thái đơn hàng
                    SqlCommand updateCommand = new SqlCommand(
                        "UPDATE DonHang SET TrangThai = 'Đã thanh toán' WHERE MaDonHang = @MaDonHang", conn, transaction);
                    updateCommand.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    updateCommand.ExecuteNonQuery();

                    // Enable IDENTITY_INSERT for the ThanhToan table
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

                    // Disable IDENTITY_INSERT for the ThanhToan table
                    SqlCommand disableIdentityInsertCommand = new SqlCommand(
                        "SET IDENTITY_INSERT ThanhToan OFF", conn, transaction);
                    disableIdentityInsertCommand.ExecuteNonQuery();

                    // Kiểm tra mã khuyến mãi
                    string tenKhuyenMai = lblVoucher.Text; // giả sử USKM300
                    if (!string.IsNullOrEmpty(tenKhuyenMai))
                    {
                        string maKhuyenMai = LayMaKhuyenMaiTuCSDL(tenKhuyenMai);

                        if (!string.IsNullOrEmpty(maKhuyenMai))
                        {
                            KhuyenMai khuyenMai = GetKhuyenMaiByTen(maKhuyenMai);

                            if (khuyenMai != null && DateTime.Now >= khuyenMai.NgayBatDau && DateTime.Now <= khuyenMai.NgayKetThuc)
                            {
                                // Mã khuyến mãi hợp lệ và chưa hết hạn
                                foreach (var chiTiet in khuyenMai.ChiTietKhuyenMais)
                                {
                                    // Tiến hành tính toán và thêm vào CSDL
                                    decimal giamGia = tongtien * (chiTiet.PhanTram / 100.0m);
                                    dgvPayment.Rows[0].Cells["Giảm Giá"].Value = giamGia;
                                    decimal soTienSauGiamGia = tongtien - giamGia;
                                    dgvPayment.Rows[0].Cells["SoTien"].Value = soTienSauGiamGia;
                                    SqlCommand insertChiTietCommand = new SqlCommand(
                                        "INSERT INTO ChiTietKhuyenMai (MaKhuyenMai, MaSanPham, GiamGia, PhanTram) VALUES (@MaKhuyenMai, @MaSanPham, @GiamGia, @PhanTram)", conn, transaction);
                                    insertChiTietCommand.Parameters.AddWithValue("@MaKhuyenMai", khuyenMai.MaKhuyenMai);
                                    insertChiTietCommand.Parameters.AddWithValue("@MaSanPham", chiTiet.MaSanPham);
                                    insertChiTietCommand.Parameters.AddWithValue("@GiamGia", giamGia);
                                    insertChiTietCommand.Parameters.AddWithValue("@PhanTram", chiTiet.PhanTram);
                                    insertChiTietCommand.ExecuteNonQuery();
                                }
                            }
                        }
                        else
                        {
                            // Mã khuyến mãi không tồn tại hoặc đã hết hạn
                            MessageBox.Show("Mã khuyến mãi không hợp lệ hoặc đã hết hạn!");
                        }
                    }


                    // Commit transaction
                    transaction.Commit();

                    // Hiển thị thông tin thanh toán sau khi xác nhận
                    //LoadPaymentData();
                    ShowOrderDetails(mahoadon);
                    MessageBox.Show("Hoá đơn đã được xác nhận!");
                    tabControlPayment.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
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
        public string LayMaKhuyenMaiTuCSDL(string maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            string tenKhuyenMai = "";

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT MaKhuyenMai, NgayKetThuc FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    // Thực thi câu truy vấn và đọc dữ liệu từ SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc giá trị của cột MaKhuyenMai
                            tenKhuyenMai = reader["MaKhuyenMai"].ToString();

                            // Kiểm tra ngày kết thúc
                            DateTime ngayKetThuc = (DateTime)reader["NgayKetThuc"];
                            if (ngayKetThuc < DateTime.Now)
                            {
                                // Mã khuyến mãi đã hết hạn
                                tenKhuyenMai = "";
                            }
                        }
                    }
                }
            }

            return tenKhuyenMai;
        }
        private bool khuyenMaiDaApDung = false;

        private void txtMaKhuyenMai_TextChanged(object sender, EventArgs e)
        {
            string maKhuyenMai = txtMaKhuyenMai.Text;

            if (!string.IsNullOrEmpty(maKhuyenMai))
            {
                if (!khuyenMaiDaApDung)
                {
                    // Kiểm tra xem mã khuyến mãi có tồn tại hay không
                    string tenKhuyenMai = LayTenKhuyenMaiTuCSDL(maKhuyenMai);

                    if (!string.IsNullOrEmpty(tenKhuyenMai))
                    {
                        lblCheckMaKhuyenMai.Text = $"Mã hợp lệ: {tenKhuyenMai}";
                        DateTime ngayBatDau = LayNgayBatDauKhuyenMaiTuCSDL(maKhuyenMai);
                        DateTime ngayKetThuc = LayNgayKetThucKhuyenMaiTuCSDL(maKhuyenMai);

                        if (DateTime.Now >= ngayBatDau && DateTime.Now <= ngayKetThuc)
                        {
                            // Mã khuyến mãi còn hiệu lực
                            double phanTram = LayPhanTramKhuyenMaiTuCSDL(maKhuyenMai);
                            double tongTien = double.Parse(lblTongTien.Text);
                            double soTienGiam = tongTien * (phanTram / 100);
                            lblTongTien.Text = (tongTien - soTienGiam).ToString();

                            // Đánh dấu rằng mã khuyến mãi đã được áp dụng cho hóa đơn này
                            khuyenMaiDaApDung = true;
                        }
                        else
                        {
                            // Mã khuyến mãi đã hết hạn
                            lblCheckMaKhuyenMai.Text = "Mã khuyến mãi đã hết hạn";
                            lblCheckMaKhuyenMai.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblCheckMaKhuyenMai.Text = "Mã khuyến mãi không tồn tại";
                        lblCheckMaKhuyenMai.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblCheckMaKhuyenMai.Text = "Chỉ áp dụng một mã khuyến mãi cho mỗi hóa đơn";
                    lblCheckMaKhuyenMai.ForeColor = Color.Red;
                    lblCheckMaKhuyenMai.Font = new Font(lblCheckMaKhuyenMai.Font.FontFamily, 10);
                }
            }
            else
            {
                // Nếu không nhập mã khuyến mãi, không cập nhật gì cả
                lblCheckMaKhuyenMai.Text = "";
            }
        }

        private DateTime LayNgayKetThucKhuyenMaiTuCSDL(string maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            DateTime ngayKetThuc = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NgayKetThuc FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ngayKetThuc = (DateTime)result;
                    }
                }
            }

            return ngayKetThuc;
        }

        private DateTime LayNgayBatDauKhuyenMaiTuCSDL(string maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            DateTime ngayBatDau = DateTime.MinValue;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT NgayBatDau FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        ngayBatDau = (DateTime)result;
                    }
                }
            }

            return ngayBatDau;
        }

        private string LayTenKhuyenMaiTuCSDL(string maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            string tenKhuyenMai = null;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT TenKhuyenMai FROM KhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn
                        command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                        // Thực thi câu truy vấn và đọc dữ liệu từ SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc giá trị của cột TenKhuyenMai
                                tenKhuyenMai = reader["TenKhuyenMai"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (nếu có)
                    MessageBox.Show("lỗi: " + ex.Message);
                }
            }

            return tenKhuyenMai;
        }

        private void XulyMuaSanPham(string maSanPham, string maKhuyenMai)
        {
            // Kiểm tra xem mã khuyến mãi có tồn tại hay không
            if (!string.IsNullOrEmpty(maKhuyenMai))
            {
                // Nếu có mã khuyến mãi, bạn có thể áp dụng giảm giá
                double phanTramGiamGia = LayPhanTramGiamGiaTuCSDL(maSanPham, maKhuyenMai);

                // Xử lý áp dụng giảm giá cho đơn hàng ở đây
                double tongTien = TinhTongTienDonHang(maSanPham);
                double soTienGiam = tongTien * (phanTramGiamGia / 100);
                double tongTienSauGiamGia = tongTien - soTienGiam;

                // Hiển thị tổng tiền sau khi đã giảm giá cho khách hàng
                lblTongTien.Text = tongTienSauGiamGia.ToString();
            }
            else
            {
                // Nếu không có mã khuyến mãi, không áp dụng giảm giá
                double tongTien = TinhTongTienDonHang(maSanPham);
                lblTongTien.Text = tongTien.ToString();
            }
        }

        private double LayPhanTramGiamGiaTuCSDL(string maSanPham, string maKhuyenMai)
        {
            connectionString = conn.ConnectionString;
            double phanTramGiamGia = 0;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT PhanTram FROM ChiTietKhuyenMai WHERE MaSanPham = @MaSanPham AND MaKhuyenMai = @MaKhuyenMai";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@MaSanPham", maSanPham);
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    // Thực thi câu truy vấn và đọc dữ liệu từ SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc giá trị của cột PhanTram
                            phanTramGiamGia = Convert.ToDouble(reader["PhanTram"]);
                        }
                    }
                }
            }

            return phanTramGiamGia;
        }

        private double TinhTongTienDonHang(string maSanPham)
        {
            connectionString = conn.ConnectionString;
            double tongTien = 0;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo câu truy vấn SQL
                    string query = "SELECT Gia FROM SanPham WHERE MaSanPham = @MaSanPham";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho câu truy vấn
                        command.Parameters.AddWithValue("@MaSanPham", maSanPham);

                        // Thực thi câu truy vấn và đọc dữ liệu từ SqlDataReader
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Đọc giá trị của cột Gia
                                double giaSanPham = Convert.ToDouble(reader["Gia"]);

                                // Tính tổng tiền đơn hàng
                                tongTien += giaSanPham;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (nếu có)
                    Console.WriteLine("Lỗi: " + ex.Message);
                }
            }

            return tongTien;
        }

        private double LayPhanTramKhuyenMaiTuCSDL(string maKhuyenMai)
        {
            double phanTram = 0;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SQL
                string query = "SELECT PhanTram FROM ChiTietKhuyenMai WHERE MaKhuyenMai = @MaKhuyenMai";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@MaKhuyenMai", maKhuyenMai);

                    // Thực thi câu truy vấn và đọc dữ liệu từ SqlDataReader
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc giá trị của cột PhanTram
                            phanTram = Convert.ToDouble(reader["PhanTram"]);
                        }
                    }
                }
            }

            return phanTram;
        }

        private void ShowOrderDetails(int maHoaDon)
        {
            string query = @"SELECT 
                tt.MaThanhToan AS MaHoaDon,
                dh.MaDonHang,
                kh.HoTen AS TenKhachHang,
                sp.TenSanPham,
                sp.Gia,
                tt.SoTien,
                ctdh.SoLuong,
                km.TenKhuyenMai,
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
            WHERE MaThanhToan = @MaThanhToan";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaThanhToan", maHoaDon);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    dgvPayment.DataSource = dt;
                }
                else
                {
                    // Không tìm thấy thông tin chi tiết của đơn hàng
                    // Xử lý tùy thuộc vào yêu cầu của bạn
                }

                reader.Close();
            }
        }

        private double GetTongTienByMaDonHang(int maDonHang)
        {
            double tongTien = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT SUM(SoLuong * Gia) AS TongTien FROM ChiTietDonHang WHERE MaDonHang = @MaDonHang";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaDonHang", maDonHang);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        tongTien = Convert.ToDouble(result);
                    }
                }
            }

            return tongTien;
        }
        // USKM300
        private KhuyenMai GetKhuyenMaiByTen(string tenKhuyenMai)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(
                    "SELECT MaKhuyenMai, NgayBatDau, NgayKetThuc FROM KhuyenMai WHERE TenKhuyenMai = @TenKhuyenMai", conn);
                command.Parameters.AddWithValue("@TenKhuyenMai", tenKhuyenMai);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.Read())
                        {
                            KhuyenMai khuyenMai = new KhuyenMai
                            {
                                MaKhuyenMai = reader.GetInt32(reader.GetOrdinal("MaKhuyenMai")).ToString(), 
                                NgayBatDau = reader.GetDateTime(reader.GetOrdinal("NgayBatDau")),
                                NgayKetThuc = reader.GetDateTime(reader.GetOrdinal("NgayKetThuc")),
                                ChiTietKhuyenMais = GetChiTietKhuyenMaisByMaKhuyenMai(reader.GetInt32(reader.GetOrdinal("MaKhuyenMai")))
                            };
                            return khuyenMai;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ex: " + ex.Message);
                    }

                }
            }
            return null;
        }


        private void btnSearchKhuyenMai_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            tabControlPayment.SelectedIndex = 0;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPayment.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvPayment.SelectedRows)
                {
                    int maHoaDon = Convert.ToInt32(row.Cells["MaHoaDon"].Value);

                    string deleteQuery = "DELETE FROM ThanhToan WHERE MaThanhToan = @MaThanhToan";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                        {
                            // Thêm tham số MaThanhToan vào câu lệnh DELETE
                            command.Parameters.AddWithValue("@MaThanhToan", maHoaDon);

                            // Mở kết nối
                            connection.Open();

                            // Thực thi câu lệnh DELETE
                            command.ExecuteNonQuery();
                        }
                    }

                    // Sau khi xóa dữ liệu từ cơ sở dữ liệu, cũng cần xóa hàng khỏi DataGridView
                    dgvPayment.Rows.Remove(row);
                }
            }
            else
            {
                // Nếu không có hàng nào được chọn, hiển thị thông báo cho người dùng
                MessageBox.Show("Vui lòng chọn ít nhất một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearchPayment_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchPayment.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string searchQuery = @"SELECT 
                                        tt.MaThanhToan AS MaHoaDon,
                                        dh.MaDonHang,
                                        kh.HoTen AS TenKhachHang,
                                        sp.TenSanPham,
                                        sp.Gia,
                                        tt.SoTien,
                                        ctdh.SoLuong,
                                        km.TenKhuyenMai,
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
                                        tt.MaThanhToan LIKE @SearchText OR
                                        kh.HoTen LIKE @SearchText";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(searchQuery, connection))
                    {
                        command.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvPayment.DataSource = dataTable;
                    }
                }
            }
            else
            {
                LoadPaymentData();
            }
        }
        private string GetCashierName()
        {
            string cashierName = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HoTen FROM NhanVien WHERE ChucVu =  @ChucVu";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ChucVu", "Nhân viên thu ngân");

                    connection.Open();
                    cashierName = (string)command.ExecuteScalar();
                    connection.Close();
                }
            }

            return cashierName;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Tạo một tài liệu PDF mới
            iTextSharp.text.Document doc = new iTextSharp.text.Document();

            try
            {
                // Hiển thị hộp thoại để chọn vị trí lưu trữ và tên tệp
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
                saveFileDialog1.Title = "Lưu hóa đơn dưới dạng";
                saveFileDialog1.InitialDirectory = @"C:\";
                saveFileDialog1.FileName = "inhoadon.pdf";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Mở tài liệu PDF và tạo một đối tượng PdfWriter để ghi vào nó
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog1.FileName, FileMode.Create));

                    // Mở tài liệu để viết vào nó
                    doc.Open();

                    // Thêm nội dung vào tài liệu

                    // Chữ "UNETI SMARTPHONE" ở giữa size chữ 20px
                    iTextSharp.text.Paragraph companyName = new iTextSharp.text.Paragraph("UNETI SMARTPHONE", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                    companyName.Alignment = Element.ALIGN_CENTER;
                    doc.Add(companyName);

                    // Địa chỉ và Số điện thoại ở giữa size chữ 16px
                    iTextSharp.text.Paragraph address = new iTextSharp.text.Paragraph("DC: 218 Linh Nam, Hoàng Mai", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.NORMAL));
                    address.Alignment = Element.ALIGN_CENTER;
                    doc.Add(address);

                    iTextSharp.text.Paragraph phoneNumber = new iTextSharp.text.Paragraph("DT: 0862587229 - 1800 8098", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 16, iTextSharp.text.Font.NORMAL));
                    phoneNumber.Alignment = Element.ALIGN_CENTER;
                    doc.Add(phoneNumber);

                    // Phần "HOÁ ĐƠN BÁN HÀNG" ở giữa size 20px
                    iTextSharp.text.Paragraph invoiceHeader = new iTextSharp.text.Paragraph("HOÁ DON BÁN HÀNG", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                    invoiceHeader.Alignment = Element.ALIGN_CENTER;
                    doc.Add(invoiceHeader);

                    // Phần thông tin hóa đơn
                    iTextSharp.text.Paragraph invoiceInfo = new iTextSharp.text.Paragraph();
                    invoiceInfo.Alignment = Element.ALIGN_LEFT;

                    // Lấy thông tin từ DataGridView và thêm vào hóa đơn PDF
                    DataGridViewRow selectedRow = dgvPayment.SelectedRows[0];
                    string productName = selectedRow.Cells["TenSanPham"].Value.ToString();
                    string quantity = selectedRow.Cells["SoLuong"].Value.ToString();
                    string price = selectedRow.Cells["Gia"].Value.ToString();
                    string total = selectedRow.Cells["SoTien"].Value.ToString();

                    // Thêm thông tin sản phẩm vào hóa đơn
                    invoiceInfo.Add($"Tên san pham: {productName}\n");
                    invoiceInfo.Add($"So luong: {quantity}\n");
                    invoiceInfo.Add($"Gia: {price}\n");
                    invoiceInfo.Add($"Tong tien: {total}\n\n");

                    // Ngày mua, Mã hoá đơn, và Thu ngân
                    invoiceInfo.Add($"Ngày mua: {DateTime.Now.ToString("dd/MM/yyyy")}\n");
                    invoiceInfo.Add($"Mã hoá don: {selectedRow.Cells["MaHoaDon"].Value.ToString()}\n");
                    string cashier = GetCashierName(); 
                    invoiceInfo.Add($"Thu ngân: {cashier}\n\n");

                    doc.Add(invoiceInfo);

                    // Tạo bảng cho danh sách sản phẩm
                    PdfPTable table = new PdfPTable(4);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 4, 1, 2, 2 });

                    // Tiêu đề cho bảng
                    table.AddCell("Mat Hàng");
                    table.AddCell("SL");
                    table.AddCell("Giá");
                    table.AddCell("Tong tien");

                    // Thêm dữ liệu cho bảng (Dữ liệu này cần lấy từ SQL)
                    // Đối với Mặt hàng, Số lượng, và Giá tiền, bạn cần lấy dữ liệu từ SQL và thêm vào bảng
                    table.AddCell(productName);
                    table.AddCell(quantity);
                    table.AddCell(price);
                    table.AddCell(total);

                    doc.Add(table);

                    // Phần Thành tiền
                    // Thành tiền sẽ được tính tự động dựa trên dữ liệu đã thêm vào bảng
                    // Bạn cần tính tổng tiền từ dữ liệu của cột Tổng tiền trong bảng và thêm vào biến totalAmount
                    decimal totalAmount = Convert.ToDecimal(total);
                    iTextSharp.text.Paragraph totalAmountFooter = new iTextSharp.text.Paragraph($"Thành tien: {totalAmount}", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
                    doc.Add(totalAmountFooter);

                    iTextSharp.text.Paragraph thankYou = new iTextSharp.text.Paragraph("Cam on Quý Khách. Hen gap lai!", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.ITALIC));
                    thankYou.Alignment = Element.ALIGN_CENTER;
                    doc.Add(thankYou);
                    string relativePath = Path.Combine(Application.StartupPath, "images", "qr_code_image.png");
                    iTextSharp.text.Image qrCodeImage = iTextSharp.text.Image.GetInstance(relativePath); // Thay đổi đường dẫn đến hình ảnh mã QR của bạn
                    qrCodeImage.Alignment = Element.ALIGN_CENTER;
                    qrCodeImage.ScaleAbsoluteWidth(100); 
                    qrCodeImage.ScaleAbsoluteHeight(120);
                    BaseFont bf = BaseFont.CreateFont("c:\\windows\\fonts\\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font vietnameseFont = new iTextSharp.text.Font(bf, 12);

                    doc.Add(qrCodeImage);
                    // Đóng tài liệu
                    doc.Close();

                    MessageBox.Show("Đã lưu hóa đơn thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
