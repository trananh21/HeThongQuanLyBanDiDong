using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
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
        private Timer fadeInTimer;
        private double opacityIncrement = 0.05;

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
        public showDetailOrder(int id, string productName, decimal price, int amount, decimal totalPrice, DateTime orderDate, string customerName, string phoneNumber, string address, string status, int customerID, int productID, int categoryID, string categoryName, string description)
        {
            InitializeComponent();
            lblOrderID.Text = id.ToString();
            lblProductName.Text = productName;
            lblPrice.Text = price.ToString();
            lblPriceSP.Text = price.ToString();
            lblAmount.Text = amount.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
            lblOrderDate.Text = orderDate.ToString("dd/MM/yyyy");
            lblCustomerName.Text = customerName;
            lblPhoneNumber.Text = phoneNumber;
            lblAddress.Text = address;
            lblStatus.Text = status;

            lblCustomerID.Text = customerID.ToString();
            lblProductID.Text = productID.ToString();
            lblCategoryID.Text = categoryID.ToString();
            lblCategoryName.Text = categoryName;
            lblMoTa.Text = description;
            RoundPanel(detailOrder, 20);
            detailOrder.AutoScroll = true;
            detailCustomer.AutoScroll = true;
            detailPayment.AutoScroll = true;
            RoundPanel(detailCustomer, 20);
            RoundPanel(detailPayment, 20);
            RoundPicture(pbImageProduct, 20);
            this.Opacity = 0;
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 10; 
            fadeInTimer.Tick += new EventHandler(FadeInTimer_Tick);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            fadeInTimer.Start();
        }

        private void FadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += opacityIncrement;
            }
            else
            {
                fadeInTimer.Stop();
            }
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
