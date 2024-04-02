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
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=qlbdtdd;Integrated Security=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void btn_login_Click(object sender, EventArgs e)
        {
          
        }

        private void guna2ControlBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (AuthenticateUser(username, password))
            {
                this.Hide();
                Dashboard dboard = new Dashboard(username);
                dboard.Show();
                this.Hide();
                // Thực hiện các hành động sau khi đăng nhập thành công
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại tên đăng nhập và mật khẩu.");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            int result = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryString = "SELECT COUNT(*) FROM login WHERE username = '" + txtUsername.Text + "' AND password = '" + txtPassword.Text + "'";
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                result = (int)command.ExecuteScalar();
            }

            return result > 0;
        }
    }
}
