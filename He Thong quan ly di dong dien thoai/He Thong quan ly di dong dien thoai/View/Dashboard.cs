﻿using He_Thong_quan_ly_di_dong_dien_thoai.Properties;
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
using System.Windows.Controls;
using WinFormsPanel = System.Windows.Forms.Panel;
namespace He_Thong_quan_ly_di_dong_dien_thoai
{
    public partial class Dashboard : Form, iMainView
    {
        private ProductPresenter productPresenter;
        private CustomerPresenter customerPresenter;
        private OrderPresenter orderPresenter;
        private bool isCollapsed;
        private productView productForm;
        private customerView customerForm;
        private orderView orderForm;
        private orderView _orderForm;
        public Dashboard(string username, iSPRepository repository, iCustomerReponsitory cusRepo, iOrderRepository ordRepo)
        {
            InitializeComponent();
            pictureBoxIcon.Image = Resources.icon_admin;
            lblHelloAdmin.Text = " Xin chào! " + username;
            // Set this form as the MDI container
            this.IsMdiContainer = true;

            productPresenter = new ProductPresenter(new productView(), repository);
            customerPresenter = new CustomerPresenter(new customerView(), cusRepo);
            orderPresenter = new OrderPresenter(new orderView(), ordRepo);
            //home
            icbtu_Trangchu.Click += ShowDashboardV;
            //product
            btnSP.Click += ShowProductForm;
            //customer
            btnKH.Click += ShowCustomerForm;
            //order
            btnOrder.Click += ShowOrderViewForm;
            //payment
            btnThanhToan.Click += ShowPaymentViewForm;
            //showDashBoard
            ShowDashboard();
            // Tạo thể hiện của form orderView
            _orderForm = new orderView();
            // Gán sự kiện GoToPaymentRequested từ form orderView sang form Dashboard
            _orderForm.GoToPaymentRequested += OrderViewForm_GoToPaymentRequested;
        }

        public void OrderViewForm_GoToPaymentRequested(object sender, EventArgs e)
        {
            // Khi nhận được tín hiệu từ form con, tạo và hiển thị form thanh toán
            paymentView paymentForm = new paymentView();
            paymentForm.TopLevel = false;
            paymentForm.FormBorderStyle = FormBorderStyle.None;
            paymentForm.Dock = DockStyle.Fill;

            // Xóa các control cũ trong panel_body (nếu có)
            panel_Body.Controls.Clear();

            // Thêm form thanh toán vào panel_body
            panel_Body.Controls.Add(paymentForm);

            // Hiển thị form thanh toán
            paymentForm.Show();
        }
        // Khai báo sự kiện
        public event EventHandler GoToPaymentRequested;

        // Xử lý sự kiện khi nhấn vào nút "Đi đến thanh toán"
        private void GoToPaymentButton_Click(object sender, EventArgs e)
        {
            // Phát ra sự kiện GoToPaymentRequested
            GoToPaymentRequested?.Invoke(this, EventArgs.Empty);
        }

        private void ShowPaymentViewForm(object sender, EventArgs e)
        {
            paymentView paymentForm = new paymentView();

            OpenFormCon(paymentForm);
        }

        private void ShowDashboardV(object sender, EventArgs e)
        {
            WinFormsPanel dashboardPanel = new WinFormsPanel();
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.BackColor = Color.White;
            System.Windows.Forms.Label titleLabel = new System.Windows.Forms.Label();
            titleLabel.Text = "HỆ THỐNG QUẢN LÍ BÁN ĐIỆN THOẠI DI ĐỘNG";
            titleLabel.Font = new Font("Arial", 24, FontStyle.Bold); 
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = Color.Black; 
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            dashboardPanel.SizeChanged += (s, args) =>
            {
                titleLabel.Location = new Point((dashboardPanel.Width - titleLabel.Width) / 2, (dashboardPanel.Height - titleLabel.Height) / 2);
            };
            panel_Body.Controls.Clear();
            panel_Body.Controls.Add(dashboardPanel);
            dashboardPanel.Controls.Add(titleLabel);
            titleLabel.Location = new Point((dashboardPanel.Width - titleLabel.Width) / 2, (dashboardPanel.Height - titleLabel.Height) / 2);
        }
        private void ShowOrderViewForm(object sender, EventArgs e)
        {
            try
            {
                if (orderForm == null || orderForm.IsDisposed)
                {
                    orderForm = (orderView)orderPresenter.GetOrderViewForm();
                }

                orderForm.Visible = true;

                // Hiển thị form customerView
                OpenFormCon(orderForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test: " + ex.Message);
            }
        }

        private void ShowCustomerForm(object sender, EventArgs e)
        {
            try
            {
                if (customerForm == null || customerForm.IsDisposed)
                {
                    customerForm = (customerView)customerPresenter.GetCustomerViewForm();
                }

                customerForm.Visible = true;

                // Hiển thị form customerView
                OpenFormCon(customerForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Test: " + ex.Message);
            }
        }

        private void ShowDashboard()
        {
            // Ẩn form productView (nếu đã khởi tạo)
            if (productForm != null)
            {
                productForm.Visible = false;
            }
            // Ẩn form customerView (nếu đã khởi tạo)
            try
            {
                if (customerForm != null)
                {
                    customerForm.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ex: " + ex.Message);
            }
            if (orderForm != null)
            {
                orderForm.Visible = false;
            }

            // Hiển thị form Dashboard
            this.Show();
        }
        private void ShowProductForm(object sender, EventArgs e)
        {
            if (productForm == null || productForm.IsDisposed)
            {
                productForm = (productView)productPresenter.GetProductViewForm();
            }

            productForm.Visible = true;
            // Hiển thị form productView
            OpenFormCon(productForm);
        }

        private Dashboard formCon;

        //product
        public event EventHandler ShowSPView;
        public event EventHandler ShowOnwerView;
        public event EventHandler ShowVetsView;
        // customer
        public event EventHandler ShowCustomerView;
        public event EventHandler ShowAdminView;
        public event EventHandler ShowCustomersView;
        //order
        public event EventHandler ShowOrderView;
        public event EventHandler ShowAdminOrderView;
        public event EventHandler ShowOrdersView;

        //order
        //public event EventHandler ShowOrderView;
        //public event EventHandler ShowAdminOrderView;
        //public event EventHandler ShowOrdersView;

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

        // đăng xuất
        private void guna2Button18_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
            productView prdV = new productView();
            prdV.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnKH_Click(object sender, EventArgs e)
        {

        }

        private void btnSP_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void icbtu_Trangchu_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
