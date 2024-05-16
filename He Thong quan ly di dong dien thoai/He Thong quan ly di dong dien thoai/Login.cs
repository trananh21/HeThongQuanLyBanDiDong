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
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public Login()
        {
            InitializeComponent();
            txtUsername.KeyPress += TextBox_KeyPressEnter;
            txtPassword.KeyPress += TextBox_KeyPressEnter;
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
        private void PerformLogin()
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            iSPRepository repository = new SpRepository(connectionString); // truy 
            iCustomerReponsitory cusRepo = new customerRepository(connectionString);
            iOrderRepository ordRepo =  new orderRepository(connectionString);
            if (AuthenticateUser(username, password))
            {
                // Hiển thị form Dashboard nếu chưa hiển thị
                if (Application.OpenForms.OfType<Dashboard>().Count() == 0)
                {
                    Dashboard dboard = new Dashboard(username, repository, cusRepo, ordRepo);
                    dboard.Show();
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
    }
}
