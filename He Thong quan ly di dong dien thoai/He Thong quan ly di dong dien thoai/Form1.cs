
using Guna.UI2.WinForms;
using He_Thong_quan_ly_di_dong_dien_thoai.Properties;
using He_Thong_quan_ly_di_dong_dien_thoai.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class form1 : Form, iMainView
    {
        
        private float radius;
        private bool isCollapsed;

        public event EventHandler ShowSPView;
        public event EventHandler ShowOnwerView;
        public event EventHandler ShowVetsView;

        public form1()
        {
            InitializeComponent();
            RoundPanel(panel, 20);
            panel.AutoScroll = true;
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void guna2Panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
            RoundPanel(panel, 20);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void btu_danhmuc_Click(object sender, EventArgs e)
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

        private void Bt_QuanLy_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login dashboard = new Login();
            dashboard.Show();   
        }
        

        private void form1_Load(object sender, EventArgs e)
        {
           
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }
    }
}
