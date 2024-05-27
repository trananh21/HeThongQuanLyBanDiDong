using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
using System.Configuration;
using He_Thong_quan_ly_di_dong_dien_thoai._Repositories;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using Guna.UI2.WinForms;
using System.Diagnostics;
using System.IO;
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Login : Form
    {
        //string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        private SqlConnection conn;
        private string connectionString;
        public Login()
        {
            InitializeComponent();
            txtUsername.KeyPress += TextBox_KeyPressEnter;
            txtPassword.KeyPress += TextBox_KeyPressEnter;
            //this.Resize += Login_Resize;
            conn = new SqlConnection(SQLConnections.KetnoiSQL());
            connectionString = conn.ConnectionString;
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TextBox_KeyPressEnter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin();
            }
        }
        Dashboard dboard;
        private void PerformLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            iSPRepository repository = new SpRepository(connectionString); // truy 
            iCustomerReponsitory cusRepo = new customerRepository(connectionString);
            iOrderRepository ordRepo =  new orderRepository(connectionString);
            iVoucherReponsitory vouRepo = new voucherRepository(connectionString);
            if (AuthenticateUser(username, password))
            {
                // Hiển thị form Dashboard nếu chưa hiển thị
                if (Application.OpenForms.OfType<Dashboard>().Count() == 0)
                {
                    dboard = new Dashboard(username, repository, cusRepo, ordRepo, vouRepo);
                    dboard.HideChildForms();
                    dboard.Show();
                } else
                {
                    dboard = Application.OpenForms.OfType<Dashboard>().FirstOrDefault();
                    dboard?.HideChildForms();
                }

                // Ẩn form LoginForm
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }
        private bool AuthenticateUser(string username, string password)
        {
            int result = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        string queryString = "SELECT COUNT(*) FROM login WHERE username = @Username AND password = @Password";
                        SqlCommand command = new SqlCommand(queryString, connection);
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        connection.Open();

                        result = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fix: " + ex.Message);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("connection: " + ex.Message);
            }
            return result > 0; // Trả về true nếu result > 0, ngược lại trả về false
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Resize(object sender, EventArgs e)
        {
            int newWidth = panel7.Width;
            int newHeight = panel7.Height;

            // Truy cập hình ảnh từ tài nguyên
            Bitmap backgroundImage = Properties.Resources.background_login; // Thay "YourImageName" bằng tên hình ảnh trong tài nguyên của bạn

            // Cập nhật kích thước hình ảnh
            Bitmap resizedImage = new Bitmap(backgroundImage, new Size(newWidth, newHeight));

            // Đặt hình ảnh làm nền cho Panel
            panel7.BackgroundImage = resizedImage;
            panel7.BackgroundImageLayout = ImageLayout.Stretch; // Cài đặt kiểu căn chỉnh hình ảnh

        }

        private static void RunAsAdministrator(string filePath)
        {
            try
            {
                // Tạo đối tượng ProcessStartInfo để cấu hình quyền và đường dẫn của quy trình
                ProcessStartInfo processInfo = new ProcessStartInfo();
                processInfo.FileName = filePath; // Đường dẫn đến tệp batch
                processInfo.Verb = "runas"; // Yêu cầu chạy với quyền admin
                processInfo.UseShellExecute = true; // Sử dụng Shell để thực thi
                processInfo.WindowStyle = ProcessWindowStyle.Normal; // Cài đặt kiểu cửa sổ

                // Tạo một đối tượng Process để thực thi tệp batch
                Process process = new Process();
                process.StartInfo = processInfo;
                process.Start();
                process.WaitForExit(); // Tùy chọn: Đợi quá trình thực thi hoàn tất
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi thực thi tệp batch: " + ex.Message);
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string batchFilePath = @"C:\Program Files (x86)\CellPhone App\CellPhone App\AppSellPhone\Data\CreateDatabase.bat";
            RunAsAdministrator(batchFilePath);
        }
    }
}
