using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class showDetailOrder : Form
    {
        public showDetailOrder()
        {
            InitializeComponent();
            RoundPanel(detailOrder, 20);
            detailOrder.AutoScroll = true;
            detailCustomer.AutoScroll = true;
            detailPayment.AutoScroll = true;
            RoundPanel(detailCustomer, 20);
            RoundPanel(detailPayment, 20);


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

        private void detailOrder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void detailPayment_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
