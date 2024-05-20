using Guna.UI2.WinForms;
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
    public partial class staffView : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
        public staffView()
        {
            InitializeComponent();
            LoadStaffData();
            RoundPanel(panelStaffInfo, 20);
            RoundPicture(imageStaff, 20);
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
        private void LoadStaffData()
        {
            string query = @"SELECT * FROM NhanVien";

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
            // Tạo một OpenFileDialog để chọn file ảnh
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Chỉ cho phép chọn các file ảnh
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            // Hiển thị hộp thoại OpenFileDialog và kiểm tra xem người dùng đã chọn một file chưa
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn file mà người dùng đã chọn
                string filePath = openFileDialog.FileName;

                // Hiển thị hình ảnh trong PictureBox
                imageStaff.Image = System.Drawing.Image.FromFile(filePath);

                // Thiết lập chế độ hiển thị của PictureBox để phù hợp với kích thước của PictureBox
                imageStaff.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }

    
}
