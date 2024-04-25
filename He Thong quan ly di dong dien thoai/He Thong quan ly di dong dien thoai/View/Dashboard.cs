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
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using He_Thong_quan_ly_di_dong_dien_thoai._Repositories;
using He_Thong_quan_ly_di_dong_dien_thoai.Presenter;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Dashboard : Form, iMainView
    {
        private ProductPresenter productPresenter;
        private bool isCollapsed;
        private Form productForm;
        public Dashboard(string username, iSPRepository repository)
        {
            InitializeComponent();
            pictureBoxIcon.Image = Resources.icon_admin;
            lblHelloAdmin.Text = " Xin chào! " + username;
            productPresenter = new ProductPresenter(new productView(), repository);
            btnSP.Click += delegate { ShowProductForm(); }; // khi nhấn vào nút sản phẩm 
                                                            // Kiểm tra và chỉ hiển thị form Dashboard khi ứng dụng chạy
            if (productForm == null || productForm.IsDisposed)
            {
                ShowDashboard();
            }
        }
        private void ShowDashboard()
        {
            // Hiển thị form Dashboard
            this.Show();
        }
        private void ShowProductForm()
        {
            if (productForm == null || productForm.IsDisposed) // Kiểm tra xem form đã được khởi tạo chưa
            {
                productForm = productPresenter.GetProductViewForm(); // Lấy form productView từ presenter
            }

            // Hiển thị form productView
            OpenFormCon(productForm);
        }


        private Dashboard formCon;


        public event EventHandler ShowSPView;
        public event EventHandler ShowOnwerView;
        public event EventHandler ShowVetsView;

        private void OpenFormCon(Form childForm)
        {
            if (formCon != null)
            {
                formCon.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

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

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                Bt_QuanLy.Image = Resources.IconExpand;
                panel_ddQuanLy.Height -= 10;
                if (panel_ddQuanLy.Size == panel_ddQuanLy.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
            else
            {
                Bt_QuanLy.Image = Resources.icondropDown;
                panel_ddQuanLy.Height += 10;
                if (panel_ddQuanLy.Size == panel_ddQuanLy.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
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

        private void label10_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form productForm = productPresenter.GetProductViewForm(); // Lấy form productView từ presenter
            OpenFormCon(productForm);
        }

        private void panelLogout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                //Bt_QuanLy.Image = Resources.icondropDown;
                panelLogout.Height += 10;
                if (panelLogout.Size == panelLogout.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                //Bt_QuanLy.Image = Resources.IconExpand;
                panelLogout.Height -= 10;
                if (panelLogout.Size == panelLogout.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btu_danhmuc_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Bt_QuanLy_Click_1(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
