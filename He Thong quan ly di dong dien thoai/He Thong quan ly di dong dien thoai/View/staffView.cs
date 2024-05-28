using Guna.UI2.WinForms;
using iTextSharp.text.pdf.codec;
using Org.BouncyCastle.Asn1.X500;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{

    public partial class staffView : Form
    {
        private enum StaffMode
        {
            Add,
            Edit,
            Remove
        }

        private StaffMode currentMode;
        private SqlConnection conn = new SqlConnection(SQLConnections.KetnoiSQL());
        private string connectionString;
        public staffView()
        {
            InitializeComponent();
            LoadStaffData();
            LoadAccountStaff();
            RoundPanel(panelStaffInfo, 20);
            RoundPanel(panel4, 20);
            RoundPicture(imageStaff, 20);
            List<string> chucVuList = GetAllChucVuStaff();
            List<string> hotenStaff = GetAllHoTenStaff();
            cbChucVu.DataSource = chucVuList;
            cbNameStaff.DataSource = hotenStaff;
            currentMode = StaffMode.Add;
        }

        private List<string> GetAllHoTenStaff()
        {
            List<string> hotenStaff = new List<string>();
            string query = "SELECT HoTen FROM NhanVien ORDER BY HoTen DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        hotenStaff.Add(reader["HoTen"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fix: " + ex.Message);
                }
            }

            return hotenStaff;
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

        private void RoundPicture(Guna2PictureBox panel, int radius)
        {
            Rectangle bounds = new Rectangle(0, 0, panel.Width, panel.Height);
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            panel.Region = new Region(path);
        }

        public void LoadAccountStaff()
        {
            connectionString = conn.ConnectionString;
            string query = @"SELECT HoTen as 'Họ tên', Username as 'Tài khoản', Password as 'Mật khẩu' FROM nhanvien ORDER BY MaNhanVien DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvAccount.DataSource = dataTable;
            }
        }
        private void LoadStaffData()
        {
            connectionString = conn.ConnectionString;
            string query = @"SELECT MaNhanVien as 'ID Staff', HoTen as 'Họ tên', ChucVu as 'Chức vụ', Email, DienThoai as 'Điện thoại', DiaChi as 'Địa chỉ', GioiTinh as 'Giới tính', NgaySinh as 'Ngày sinh', NgayVaoLam as 'Ngày vào làm' FROM nhanvien ORDER BY MaNhanVien DESC";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvStaff.DataSource = dataTable;
            }
        }

        private void btnChooseImageStaff_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                imageStaff.Image = Image.FromFile(filePath);
                imageStaff.SizeMode = PictureBoxSizeMode.Zoom;
                imageStaff.Text = filePath;
            }
        }
        private List<string> GetAllChucVuStaff()
        {
            List<string> chucVuList = new List<string>();
            string query = "SELECT DISTINCT ChucVu FROM NhanVien ORDER BY ChucVu DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        chucVuList.Add(reader["ChucVu"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error fetching data: " + ex.Message);
                }
            }

            return chucVuList;
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = tabSetStaff;
            updateInfoStaff.Text = "Thêm thông tin nhân viên";
            currentMode = StaffMode.Add;
        }

        private void updateInfoStaff_Click(object sender, EventArgs e)
        {
            if (currentMode == StaffMode.Add)
            {
                string name = txtNameStaff.Text;
                string chucvu = cbChucVu.SelectedItem?.ToString();
                string email = txtEmailStaff.Text;
                string phone = txtPhoneStaff.Text;
                string diachi = txtAddressStaff.Text;
                string gioitinh = gtNam.Checked ? "Nam" : gtNu.Checked ? "Nữ" : "";
                string ngaysinh = txtNgaySinh.Text;
                DateTime ngayvaolam = NgayVaoLam.Value;
                string hinhanhPath = imageStaff.Text;
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(chucvu) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(ngaysinh) ||
                    string.IsNullOrEmpty(hinhanhPath))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                byte[] imageData = File.ReadAllBytes(hinhanhPath);
                InsertStaffIntoDatabase(name, chucvu, email, phone, diachi, gioitinh, ngaysinh, ngayvaolam, imageData);
                tabControlStaff.SelectedTab = tabListStaff;

            } else if(currentMode == StaffMode.Edit)
            {
                string id = txtMaNhanVien.Text; // ID của nhân viên cần sửa
                string name = txtNameStaff.Text;
                string chucvu = cbChucVu.SelectedItem?.ToString();
                string email = txtEmailStaff.Text;
                string phone = txtPhoneStaff.Text;
                string diachi = txtAddressStaff.Text;
                string gioitinh = gtNam.Checked ? "Nam" : gtNu.Checked ? "Nữ" : "";
                string ngaysinh = txtNgaySinh.Text;
                DateTime ngayvaolam = NgayVaoLam.Value;
                string hinhanhPath = imageStaff.Text;
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(chucvu) || string.IsNullOrEmpty(email) ||
                    string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(ngaysinh) ||
                    string.IsNullOrEmpty(hinhanhPath))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }
                byte[] imageData = File.ReadAllBytes(hinhanhPath);
                UpdateStaffInDatabase(id, name, chucvu, email, phone, diachi, gioitinh, ngaysinh, ngayvaolam, imageData);
                tabControlStaff.SelectedTab = tabListStaff;
            } 
        }
        private void UpdateStaffInDatabase(string id, string name, string chucvu, string email, string phone, string diachi, string gioitinh, string ngaysinh, DateTime ngayvaolam, byte[] hinhanhData)
        {
            try
            {
                string query = "UPDATE NhanVien SET HoTen = @TenNhanVien, ChucVu = @ChucVu, Email = @Email, DienThoai = @SoDienThoai, DiaChi = @DiaChi, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, NgayVaoLam = @NgayVaoLam, HinhAnh = @HinhAnh WHERE MaNhanVien = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        command.Parameters.AddWithValue("@TenNhanVien", name);
                        command.Parameters.AddWithValue("@ChucVu", chucvu);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@SoDienThoai", phone);
                        command.Parameters.AddWithValue("@DiaChi", diachi);
                        command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        command.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        command.Parameters.AddWithValue("@NgayVaoLam", ngayvaolam);
                        command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = hinhanhData;
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên thành công!");
                            LoadStaffData();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin nhân viên không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void InsertStaffIntoDatabase(string name, string chucvu, string email, string phone, string diachi, string gioitinh, string ngaysinh, DateTime ngayvaolam, byte[] hinhanhData)
        {
            try
            {
                string query = "INSERT INTO NhanVien (HoTen, ChucVu, Email, DienThoai, DiaChi, GioiTinh, NgaySinh, NgayVaoLam, HinhAnh) " +
                               "VALUES (@TenNhanVien, @ChucVu, @Email, @SoDienThoai, @DiaChi, @GioiTinh, @NgaySinh, @NgayVaoLam, @HinhAnh)";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenNhanVien", name);
                        command.Parameters.AddWithValue("@ChucVu", chucvu);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@SoDienThoai", phone);
                        command.Parameters.AddWithValue("@DiaChi", diachi);
                        command.Parameters.AddWithValue("@GioiTinh", gioitinh);
                        command.Parameters.AddWithValue("@NgaySinh", ngaysinh);
                        command.Parameters.AddWithValue("@NgayVaoLam", ngayvaolam);
                        command.Parameters.Add("@HinhAnh", SqlDbType.Image).Value = hinhanhData;
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm nhân viên mới thành công!");
                            LoadStaffData();
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên mới không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void DeleteStaffFromDatabase(string id)
        {
            try
            {
                string query = "DELETE FROM NhanVien WHERE MaNhanVien = @ID";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ID", id);
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Xoá nhân viên thành công!");
                            // Sau khi xoá thành công, gọi lại phương thức LoadStaffData() để cập nhật DataGridView
                            LoadStaffData();
                        }
                        else
                        {
                            MessageBox.Show("Xoá nhân viên không thành công!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            tabControlStaff.SelectedTab = tabSetStaff;
            updateInfoStaff.Text = "Cập nhật thông tin nhân viên";
            currentMode = StaffMode.Edit;
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải sự kiện click vào nút sửa không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStaff.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                txtNameStaff.Text = row.Cells[1].Value.ToString();
                cbChucVu.SelectedItem = row.Cells[2].Value.ToString();
                txtEmailStaff.Text = row.Cells[3].Value.ToString();
                txtPhoneStaff.Text = row.Cells[4].Value.ToString();
                txtAddressStaff.Text = row.Cells[5].Value.ToString();
                string gioiTinh = row.Cells[6].Value.ToString();
                gtNam.Checked = gioiTinh == "Nam";
                gtNu.Checked = gioiTinh == "Nữ";
                txtNgaySinh.Text = row.Cells[7].Value.ToString();
                NgayVaoLam.Value = Convert.ToDateTime(row.Cells[8].Value);
                // Thiết lập chế độ sửa
                currentMode = StaffMode.Edit;
                updateInfoStaff.Text = "Cập nhật thông tin nhân viên";
            }
        }

        private void btnRemoveStaff_Click(object sender, EventArgs e)
        {
            if (dgvStaff.SelectedRows.Count > 0)
            {
                string id = dgvStaff.SelectedRows[0].Cells[0].Value.ToString();
                DeleteStaffFromDatabase(id);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xoá!");
            }
        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchStaff.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                string query = @"SELECT MaNhanVien as 'ID Staff', HoTen as 'Họ tên', ChucVu as 'Chức vụ', Email, DienThoai as 'Điện thoại', DiaChi as 'Địa chỉ', GioiTinh as 'Giới tính', NgaySinh as 'Ngày sinh', NgayVaoLam as 'Ngày vào làm' FROM nhanvien " +
                               "WHERE HoTen LIKE @SearchText OR MaNhanVien LIKE @SearchText";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvStaff.DataSource = dataTable;
                }
            }
            else
            {
                LoadStaffData();
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string hoTen = cbNameStaff.SelectedItem.ToString();
            string userName = txtUStaff.Text;
            string password = txtPStaff.Text;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE nhanvien SET Username = @userName, Password = @password WHERE HoTen = @hoTen";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userName", userName);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@hoTen", hoTen);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật tài khoản thành công!");
                            LoadAccountStaff();
                        }
                        else
                        {
                            MessageBox.Show("Không có tài khoản nào được cập nhật!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem sự kiện có xảy ra trên một hàng không
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = dgvAccount.Rows[e.RowIndex];
                cbNameStaff.SelectedItem = row.Cells[0].Value.ToString();
                txtUStaff.Text = row.Cells[1].Value.ToString();
                txtPStaff.Text = row.Cells[2].Value.ToString();
            }
        }
    }


}
