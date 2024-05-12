namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    partial class orderView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlOrder = new MetroFramework.Controls.MetroTabControl();
            this.tabOrderList = new MetroFramework.Controls.MetroTabPage();
            this.dgvDonHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnSearchOrder = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchOrder = new Guna.UI2.WinForms.Guna2TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRemoveOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnEditOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCreateOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tabCreateOrder = new MetroFramework.Controls.MetroTabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.sumPrice = new System.Windows.Forms.Label();
            this.btnCanceOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pbImage = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayMua = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.nudAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNameProduct = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ttt = new System.Windows.Forms.Label();
            this.txtOrderID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.tabControlOrder.SuspendLayout();
            this.tabOrderList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabCreateOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(887, 63);
            this.guna2Panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Đơn Hàng";
            // 
            // tabControlOrder
            // 
            this.tabControlOrder.Controls.Add(this.tabOrderList);
            this.tabControlOrder.Controls.Add(this.tabCreateOrder);
            this.tabControlOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlOrder.Location = new System.Drawing.Point(0, 63);
            this.tabControlOrder.Name = "tabControlOrder";
            this.tabControlOrder.SelectedIndex = 0;
            this.tabControlOrder.Size = new System.Drawing.Size(887, 566);
            this.tabControlOrder.TabIndex = 4;
            this.tabControlOrder.UseSelectable = true;
            // 
            // tabOrderList
            // 
            this.tabOrderList.Controls.Add(this.dgvDonHang);
            this.tabOrderList.Controls.Add(this.btnSearchOrder);
            this.tabOrderList.Controls.Add(this.txtSearchOrder);
            this.tabOrderList.Controls.Add(this.metroPanel1);
            this.tabOrderList.Controls.Add(this.panel1);
            this.tabOrderList.ForeColor = System.Drawing.Color.White;
            this.tabOrderList.HorizontalScrollbarBarColor = true;
            this.tabOrderList.HorizontalScrollbarHighlightOnWheel = false;
            this.tabOrderList.HorizontalScrollbarSize = 10;
            this.tabOrderList.Location = new System.Drawing.Point(4, 38);
            this.tabOrderList.Name = "tabOrderList";
            this.tabOrderList.Size = new System.Drawing.Size(879, 524);
            this.tabOrderList.TabIndex = 0;
            this.tabOrderList.Text = "Tất Cả";
            this.tabOrderList.VerticalScrollbarBarColor = true;
            this.tabOrderList.VerticalScrollbarHighlightOnWheel = false;
            this.tabOrderList.VerticalScrollbarSize = 10;
            this.tabOrderList.Click += new System.EventHandler(this.tabOrderList_Click);
            // 
            // dgvDonHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvDonHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDonHang.ColumnHeadersHeight = 60;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDonHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDonHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvDonHang.Location = new System.Drawing.Point(0, 49);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDonHang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDonHang.RowHeadersVisible = false;
            this.dgvDonHang.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.RowTemplate.Height = 41;
            this.dgvDonHang.RowTemplate.ReadOnly = true;
            this.dgvDonHang.Size = new System.Drawing.Size(753, 475);
            this.dgvDonHang.TabIndex = 6;
            this.dgvDonHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDonHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvDonHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDonHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDonHang.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvDonHang.ThemeStyle.ReadOnly = true;
            this.dgvDonHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDonHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDonHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDonHang.ThemeStyle.RowsStyle.Height = 41;
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvDonHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDonHang_CellClick);
            // 
            // btnSearchOrder
            // 
            this.btnSearchOrder.AutoRoundedCorners = true;
            this.btnSearchOrder.BackColor = System.Drawing.Color.White;
            this.btnSearchOrder.BorderRadius = 16;
            this.btnSearchOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchOrder.FillColor = System.Drawing.Color.White;
            this.btnSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchOrder.ForeColor = System.Drawing.Color.White;
            this.btnSearchOrder.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.search;
            this.btnSearchOrder.Location = new System.Drawing.Point(650, 8);
            this.btnSearchOrder.Name = "btnSearchOrder";
            this.btnSearchOrder.Size = new System.Drawing.Size(35, 35);
            this.btnSearchOrder.TabIndex = 3;
            // 
            // txtSearchOrder
            // 
            this.txtSearchOrder.AutoRoundedCorners = true;
            this.txtSearchOrder.BackColor = System.Drawing.Color.White;
            this.txtSearchOrder.BorderRadius = 17;
            this.txtSearchOrder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchOrder.DefaultText = "";
            this.txtSearchOrder.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchOrder.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchOrder.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchOrder.Location = new System.Drawing.Point(14, 7);
            this.txtSearchOrder.Name = "txtSearchOrder";
            this.txtSearchOrder.PasswordChar = '\0';
            this.txtSearchOrder.PlaceholderText = "Tìm kiếm mã đơn hàng...";
            this.txtSearchOrder.SelectedText = "";
            this.txtSearchOrder.Size = new System.Drawing.Size(630, 36);
            this.txtSearchOrder.TabIndex = 2;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(753, 49);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRemoveOrder);
            this.panel1.Controls.Add(this.btnEditOrder);
            this.panel1.Controls.Add(this.btnCreateOrder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(753, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 524);
            this.panel1.TabIndex = 7;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.AutoRoundedCorners = true;
            this.btnRemoveOrder.BorderRadius = 16;
            this.btnRemoveOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveOrder.FillColor = System.Drawing.Color.Red;
            this.btnRemoveOrder.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOrder.ForeColor = System.Drawing.Color.White;
            this.btnRemoveOrder.Location = new System.Drawing.Point(0, 155);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(126, 35);
            this.btnRemoveOrder.TabIndex = 4;
            this.btnRemoveOrder.Text = "Xoá Đơn Hàng";
            // 
            // btnEditOrder
            // 
            this.btnEditOrder.AutoRoundedCorners = true;
            this.btnEditOrder.BorderRadius = 16;
            this.btnEditOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditOrder.FillColor = System.Drawing.Color.Blue;
            this.btnEditOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditOrder.ForeColor = System.Drawing.Color.White;
            this.btnEditOrder.Location = new System.Drawing.Point(0, 114);
            this.btnEditOrder.Name = "btnEditOrder";
            this.btnEditOrder.Size = new System.Drawing.Size(126, 35);
            this.btnEditOrder.TabIndex = 3;
            this.btnEditOrder.Text = "Sửa Đơn Hàng";
            this.btnEditOrder.Click += new System.EventHandler(this.btnEditOrder_Click);
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.AutoRoundedCorners = true;
            this.btnCreateOrder.BackColor = System.Drawing.Color.White;
            this.btnCreateOrder.BorderColor = System.Drawing.Color.White;
            this.btnCreateOrder.BorderRadius = 16;
            this.btnCreateOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateOrder.FillColor = System.Drawing.Color.Red;
            this.btnCreateOrder.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCreateOrder.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateOrder.Location = new System.Drawing.Point(0, 73);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(126, 35);
            this.btnCreateOrder.TabIndex = 2;
            this.btnCreateOrder.Text = "Tạo Đơn Hàng";
            this.btnCreateOrder.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // tabCreateOrder
            // 
            this.tabCreateOrder.BackColor = System.Drawing.Color.White;
            this.tabCreateOrder.Controls.Add(this.label10);
            this.tabCreateOrder.Controls.Add(this.sumPrice);
            this.tabCreateOrder.Controls.Add(this.btnCanceOrder);
            this.tabCreateOrder.Controls.Add(this.pbImage);
            this.tabCreateOrder.Controls.Add(this.label9);
            this.tabCreateOrder.Controls.Add(this.txtStatus);
            this.tabCreateOrder.Controls.Add(this.label5);
            this.tabCreateOrder.Controls.Add(this.btnSaveOrder);
            this.tabCreateOrder.Controls.Add(this.txtAddress);
            this.tabCreateOrder.Controls.Add(this.label8);
            this.tabCreateOrder.Controls.Add(this.txtPhoneNumber);
            this.tabCreateOrder.Controls.Add(this.label7);
            this.tabCreateOrder.Controls.Add(this.txtNameCustomer);
            this.tabCreateOrder.Controls.Add(this.label6);
            this.tabCreateOrder.Controls.Add(this.dtpNgayMua);
            this.tabCreateOrder.Controls.Add(this.nudAmount);
            this.tabCreateOrder.Controls.Add(this.label4);
            this.tabCreateOrder.Controls.Add(this.txtPrice);
            this.tabCreateOrder.Controls.Add(this.label3);
            this.tabCreateOrder.Controls.Add(this.cbNameProduct);
            this.tabCreateOrder.Controls.Add(this.ttt);
            this.tabCreateOrder.Controls.Add(this.txtOrderID);
            this.tabCreateOrder.Controls.Add(this.label2);
            this.tabCreateOrder.HorizontalScrollbarBarColor = true;
            this.tabCreateOrder.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCreateOrder.HorizontalScrollbarSize = 10;
            this.tabCreateOrder.Location = new System.Drawing.Point(4, 38);
            this.tabCreateOrder.Name = "tabCreateOrder";
            this.tabCreateOrder.Size = new System.Drawing.Size(879, 524);
            this.tabCreateOrder.TabIndex = 1;
            this.tabCreateOrder.Text = "Tạo Đơn Hàng";
            this.tabCreateOrder.VerticalScrollbarBarColor = true;
            this.tabCreateOrder.VerticalScrollbarHighlightOnWheel = false;
            this.tabCreateOrder.VerticalScrollbarSize = 10;
            this.tabCreateOrder.Click += new System.EventHandler(this.tabCreateOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 438);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tổng tiền: ";
            // 
            // sumPrice
            // 
            this.sumPrice.AutoSize = true;
            this.sumPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumPrice.Location = new System.Drawing.Point(123, 438);
            this.sumPrice.Name = "sumPrice";
            this.sumPrice.Size = new System.Drawing.Size(0, 20);
            this.sumPrice.TabIndex = 24;
            // 
            // btnCanceOrder
            // 
            this.btnCanceOrder.AutoRoundedCorners = true;
            this.btnCanceOrder.BorderRadius = 21;
            this.btnCanceOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanceOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanceOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCanceOrder.ForeColor = System.Drawing.Color.White;
            this.btnCanceOrder.Location = new System.Drawing.Point(615, 425);
            this.btnCanceOrder.Name = "btnCanceOrder";
            this.btnCanceOrder.Size = new System.Drawing.Size(200, 45);
            this.btnCanceOrder.TabIndex = 10;
            this.btnCanceOrder.Text = "Cancel";
            // 
            // pbImage
            // 
            this.pbImage.ImageRotate = 0F;
            this.pbImage.Location = new System.Drawing.Point(38, 57);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(300, 349);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 23;
            this.pbImage.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hình Ảnh";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoRoundedCorners = true;
            this.txtStatus.BorderRadius = 17;
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.DefaultText = "Chưa Thanh Toán";
            this.txtStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Location = new System.Drawing.Point(615, 370);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.PasswordChar = '\0';
            this.txtStatus.PlaceholderText = "";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.SelectedText = "";
            this.txtStatus.Size = new System.Drawing.Size(200, 36);
            this.txtStatus.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Trạng Thái";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.AutoRoundedCorners = true;
            this.btnSaveOrder.BorderRadius = 21;
            this.btnSaveOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrder.Location = new System.Drawing.Point(371, 425);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(204, 45);
            this.btnSaveOrder.TabIndex = 9;
            this.btnSaveOrder.Text = "Save";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoRoundedCorners = true;
            this.txtAddress.BorderRadius = 17;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress.Location = new System.Drawing.Point(615, 294);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(200, 36);
            this.txtAddress.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(611, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Địa Chỉ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AutoRoundedCorners = true;
            this.txtPhoneNumber.BorderRadius = 17;
            this.txtPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNumber.DefaultText = "";
            this.txtPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneNumber.Location = new System.Drawing.Point(615, 216);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 36);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(611, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Số Điện Thoại";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.AutoRoundedCorners = true;
            this.txtNameCustomer.BorderRadius = 17;
            this.txtNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCustomer.DefaultText = "";
            this.txtNameCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCustomer.Location = new System.Drawing.Point(615, 132);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.PlaceholderText = "";
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.Size = new System.Drawing.Size(200, 36);
            this.txtNameCustomer.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Khách Hàng";
            // 
            // dtpNgayMua
            // 
            this.dtpNgayMua.AutoRoundedCorners = true;
            this.dtpNgayMua.BorderRadius = 17;
            this.dtpNgayMua.Checked = true;
            this.dtpNgayMua.FillColor = System.Drawing.Color.Aqua;
            this.dtpNgayMua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMua.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayMua.Location = new System.Drawing.Point(371, 57);
            this.dtpNgayMua.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayMua.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayMua.Name = "dtpNgayMua";
            this.dtpNgayMua.Size = new System.Drawing.Size(444, 36);
            this.dtpNgayMua.TabIndex = 0;
            this.dtpNgayMua.Value = new System.DateTime(2024, 5, 10, 0, 23, 3, 938);
            this.dtpNgayMua.ValueChanged += new System.EventHandler(this.dtpNgayMua_ValueChanged);
            // 
            // nudAmount
            // 
            this.nudAmount.AutoRoundedCorners = true;
            this.nudAmount.BackColor = System.Drawing.Color.Transparent;
            this.nudAmount.BorderRadius = 17;
            this.nudAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudAmount.Location = new System.Drawing.Point(371, 370);
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(204, 36);
            this.nudAmount.TabIndex = 4;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Số lượng";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoRoundedCorners = true;
            this.txtPrice.BorderRadius = 17;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(375, 291);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(200, 36);
            this.txtPrice.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá Tiền";
            // 
            // cbNameProduct
            // 
            this.cbNameProduct.AutoRoundedCorners = true;
            this.cbNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.cbNameProduct.BorderRadius = 17;
            this.cbNameProduct.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbNameProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameProduct.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNameProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbNameProduct.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbNameProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbNameProduct.ItemHeight = 30;
            this.cbNameProduct.Location = new System.Drawing.Point(371, 210);
            this.cbNameProduct.Name = "cbNameProduct";
            this.cbNameProduct.Size = new System.Drawing.Size(196, 36);
            this.cbNameProduct.TabIndex = 2;
            this.cbNameProduct.SelectedIndexChanged += new System.EventHandler(this.cbNameProduct_SelectedIndexChanged);
            // 
            // ttt
            // 
            this.ttt.AutoSize = true;
            this.ttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttt.Location = new System.Drawing.Point(371, 187);
            this.ttt.Name = "ttt";
            this.ttt.Size = new System.Drawing.Size(114, 20);
            this.ttt.TabIndex = 4;
            this.ttt.Text = "Tên Sản Phẩm";
            // 
            // txtOrderID
            // 
            this.txtOrderID.AutoRoundedCorners = true;
            this.txtOrderID.BorderRadius = 17;
            this.txtOrderID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOrderID.DefaultText = "";
            this.txtOrderID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOrderID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOrderID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOrderID.Enabled = false;
            this.txtOrderID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOrderID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOrderID.Location = new System.Drawing.Point(371, 132);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.PasswordChar = '\0';
            this.txtOrderID.PlaceholderText = "";
            this.txtOrderID.SelectedText = "";
            this.txtOrderID.Size = new System.Drawing.Size(200, 36);
            this.txtOrderID.TabIndex = 1;
            this.txtOrderID.TextChanged += new System.EventHandler(this.txtOrderID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đơn Hàng";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // orderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 629);
            this.Controls.Add(this.tabControlOrder);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "orderView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orderView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControlOrder.ResumeLayout(false);
            this.tabOrderList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabCreateOrder.ResumeLayout(false);
            this.tabCreateOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlOrder;
        private MetroFramework.Controls.MetroTabPage tabOrderList;
        private MetroFramework.Controls.MetroTabPage tabCreateOrder;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchOrder;
        private Guna.UI2.WinForms.Guna2Button btnSearchOrder;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtOrderID;
        private System.Windows.Forms.Label ttt;
        private Guna.UI2.WinForms.Guna2ComboBox cbNameProduct;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudAmount;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayMua;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtNameCustomer;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaveOrder;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtStatus;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDonHang;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2PictureBox pbImage;
        private Guna.UI2.WinForms.Guna2GradientButton btnCanceOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btnCreateOrder;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnEditOrder;
        private Guna.UI2.WinForms.Guna2GradientButton btnRemoveOrder;
        private System.Windows.Forms.Label sumPrice;
        private System.Windows.Forms.Label label10;
    }
}