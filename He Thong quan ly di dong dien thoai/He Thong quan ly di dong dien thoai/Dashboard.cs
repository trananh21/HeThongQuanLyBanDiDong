using He_Thong_quan_ly_di_dong_dien_thoai.Properties;
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
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Dashboard : Form
    {
        private bool isCollapsed;
        public Dashboard(string username)
        {
            InitializeComponent();
            pictureBoxIcon.Image = Resources.icon_admin;
            lblHelloAdmin.Text = " Xin chào! " + username;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btu_danhmuc_Click(object sender, EventArgs e)
        {

        }

        private void btu_danhmuc_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Bt_QuanLy.Image = Resources.icondropDown;
                panel_ddQuanLy.Height += 10;
                if (panel_ddQuanLy.Size == panel_ddQuanLy.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                Bt_QuanLy.Image = Resources.IconExpand;
                panel_ddQuanLy.Height -= 10;
                if (panel_ddQuanLy.Size == panel_ddQuanLy.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btu_danhmuc.Image = Resources.icondropDown;
                paneldropdown.Height += 10;
                if (paneldropdown.Size == paneldropdown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                btu_danhmuc.Image = Resources.IconExpand;
                paneldropdown.Height -= 10;
                if (paneldropdown.Size == paneldropdown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Bt_QuanLy_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SanPham sanphamForm = new SanPham();
            sanphamForm.Show();
            this.Hide(); // Ẩn form Dashboard nếu bạn muốn
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            // Hiển thị form Sản phẩm
            SanPham formSanPham = new SanPham();
            formSanPham.ShowDialog();

            // Hiển thị lại form Dashboard sau khi đóng form Sản phẩm
            this.Show();
        }
    }
}
