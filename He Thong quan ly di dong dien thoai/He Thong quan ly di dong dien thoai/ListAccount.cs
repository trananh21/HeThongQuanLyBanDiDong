using Guna.UI2.WinForms;
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
    public partial class ListAccount : Form
    {
        private Timer fadeInTimer;
        private double opacityIncrement = 0.05;
        public ListAccount()
        {
            InitializeComponent();
            this.Opacity = 0;
            fadeInTimer = new Timer();
            fadeInTimer.Interval = 10;
            fadeInTimer.Tick += new EventHandler(FadeInTimer_Tick);
            RoundPanel(panel1, 20);
            RoundPanel(panel3, 20);
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

        private void guna2GradientTileButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
