namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    partial class paymentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paymentView));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlPayment = new MetroFramework.Controls.MetroTabControl();
            this.tatcaPayment = new MetroFramework.Controls.MetroTabPage();
            this.dgvPayment = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchPayment = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NgayKetThuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.NgayBatDau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.xacthuchoadon = new MetroFramework.Controls.MetroTabPage();
            this.btnSearchKhuyenMai = new Guna.UI2.WinForms.Guna2Button();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmPayment = new Guna.UI2.WinForms.Guna2Button();
            this.txtKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelThongtinThanhToan = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNgayMua = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblVoucher = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAmountPayment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSumPricePayment = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCustomerNamePayment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblOrderIDPayment = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelDetailOrder = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.tabControlPayment.SuspendLayout();
            this.tatcaPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.xacthuchoadon.SuspendLayout();
            this.panelThongtinThanhToan.SuspendLayout();
            this.panelDetailOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Thanh Toán";
            // 
            // tabControlPayment
            // 
            this.tabControlPayment.Controls.Add(this.tatcaPayment);
            this.tabControlPayment.Controls.Add(this.xacthuchoadon);
            this.tabControlPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPayment.Location = new System.Drawing.Point(0, 63);
            this.tabControlPayment.Name = "tabControlPayment";
            this.tabControlPayment.SelectedIndex = 0;
            this.tabControlPayment.Size = new System.Drawing.Size(887, 566);
            this.tabControlPayment.TabIndex = 4;
            this.tabControlPayment.UseSelectable = true;
            // 
            // tatcaPayment
            // 
            this.tatcaPayment.Controls.Add(this.panel1);
            this.tatcaPayment.Controls.Add(this.dgvPayment);
            this.tatcaPayment.Controls.Add(this.panel2);
            this.tatcaPayment.HorizontalScrollbarBarColor = true;
            this.tatcaPayment.HorizontalScrollbarHighlightOnWheel = false;
            this.tatcaPayment.HorizontalScrollbarSize = 10;
            this.tatcaPayment.Location = new System.Drawing.Point(4, 38);
            this.tatcaPayment.Name = "tatcaPayment";
            this.tatcaPayment.Size = new System.Drawing.Size(879, 524);
            this.tatcaPayment.TabIndex = 0;
            this.tatcaPayment.Text = "Tất Cả";
            this.tatcaPayment.VerticalScrollbarBarColor = true;
            this.tatcaPayment.VerticalScrollbarHighlightOnWheel = false;
            this.tatcaPayment.VerticalScrollbarSize = 10;
            // 
            // dgvPayment
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvPayment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayment.ColumnHeadersHeight = 60;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayment.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvPayment.Location = new System.Drawing.Point(0, 90);
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPayment.RowHeadersVisible = false;
            this.dgvPayment.RowTemplate.Height = 41;
            this.dgvPayment.Size = new System.Drawing.Size(879, 434);
            this.dgvPayment.TabIndex = 4;
            this.dgvPayment.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPayment.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvPayment.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPayment.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPayment.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPayment.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvPayment.ThemeStyle.ReadOnly = true;
            this.dgvPayment.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvPayment.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPayment.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPayment.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPayment.ThemeStyle.RowsStyle.Height = 41;
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvPayment.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvPayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPayment_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchPayment);
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 43);
            this.panel2.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(61)))), ((int)(((byte)(90)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(537, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 36);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "IN HOÁ ĐƠN";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 17;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.icon_remove_order_ver5;
            this.btnXoa.Location = new System.Drawing.Point(495, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(36, 36);
            this.btnXoa.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoRoundedCorners = true;
            this.btnSearch.BorderRadius = 17;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.icon_search_ver1;
            this.btnSearch.Location = new System.Drawing.Point(453, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.TabIndex = 1;
            // 
            // txtSearchPayment
            // 
            this.txtSearchPayment.AutoRoundedCorners = true;
            this.txtSearchPayment.BorderRadius = 17;
            this.txtSearchPayment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchPayment.DefaultText = "";
            this.txtSearchPayment.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPayment.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchPayment.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchPayment.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchPayment.Location = new System.Drawing.Point(14, 3);
            this.txtSearchPayment.Name = "txtSearchPayment";
            this.txtSearchPayment.PasswordChar = '\0';
            this.txtSearchPayment.PlaceholderText = "Tìm kiếm theo tên khách hàng, mã hoá đơn...";
            this.txtSearchPayment.SelectedText = "";
            this.txtSearchPayment.Size = new System.Drawing.Size(433, 36);
            this.txtSearchPayment.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NgayBatDau);
            this.panel1.Controls.Add(this.NgayKetThuc);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 47);
            this.panel1.TabIndex = 2;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.AutoRoundedCorners = true;
            this.NgayKetThuc.BorderRadius = 17;
            this.NgayKetThuc.Checked = true;
            this.NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.NgayKetThuc.Location = new System.Drawing.Point(270, 5);
            this.NgayKetThuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NgayKetThuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Size = new System.Drawing.Size(175, 36);
            this.NgayKetThuc.TabIndex = 2;
            this.NgayKetThuc.Value = new System.DateTime(2024, 5, 17, 21, 4, 41, 105);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(225, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Đến";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Từ";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.AutoRoundedCorners = true;
            this.NgayBatDau.BorderRadius = 17;
            this.NgayBatDau.Checked = true;
            this.NgayBatDau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.NgayBatDau.Location = new System.Drawing.Point(43, 5);
            this.NgayBatDau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.NgayBatDau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Size = new System.Drawing.Size(175, 36);
            this.NgayBatDau.TabIndex = 0;
            this.NgayBatDau.Value = new System.DateTime(2024, 5, 17, 21, 3, 34, 381);
            // 
            // xacthuchoadon
            // 
            this.xacthuchoadon.Controls.Add(this.btnSearchKhuyenMai);
            this.xacthuchoadon.Controls.Add(this.lblKhuyenMai);
            this.xacthuchoadon.Controls.Add(this.btnHuy);
            this.xacthuchoadon.Controls.Add(this.btnConfirmPayment);
            this.xacthuchoadon.Controls.Add(this.txtKhuyenMai);
            this.xacthuchoadon.Controls.Add(this.panelThongtinThanhToan);
            this.xacthuchoadon.Controls.Add(this.panelDetailOrder);
            this.xacthuchoadon.HorizontalScrollbarBarColor = true;
            this.xacthuchoadon.HorizontalScrollbarHighlightOnWheel = false;
            this.xacthuchoadon.HorizontalScrollbarSize = 10;
            this.xacthuchoadon.Location = new System.Drawing.Point(4, 38);
            this.xacthuchoadon.Name = "xacthuchoadon";
            this.xacthuchoadon.Size = new System.Drawing.Size(879, 524);
            this.xacthuchoadon.TabIndex = 1;
            this.xacthuchoadon.Text = "Xác thực hoá đơn";
            this.xacthuchoadon.VerticalScrollbarBarColor = true;
            this.xacthuchoadon.VerticalScrollbarHighlightOnWheel = false;
            this.xacthuchoadon.VerticalScrollbarSize = 10;
            // 
            // btnSearchKhuyenMai
            // 
            this.btnSearchKhuyenMai.AutoRoundedCorners = true;
            this.btnSearchKhuyenMai.BackColor = System.Drawing.Color.White;
            this.btnSearchKhuyenMai.BorderRadius = 17;
            this.btnSearchKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchKhuyenMai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchKhuyenMai.FillColor = System.Drawing.Color.White;
            this.btnSearchKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchKhuyenMai.ForeColor = System.Drawing.Color.White;
            this.btnSearchKhuyenMai.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.icon_search_ver1;
            this.btnSearchKhuyenMai.Location = new System.Drawing.Point(810, 378);
            this.btnSearchKhuyenMai.Name = "btnSearchKhuyenMai";
            this.btnSearchKhuyenMai.Size = new System.Drawing.Size(36, 36);
            this.btnSearchKhuyenMai.TabIndex = 6;
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.BackColor = System.Drawing.Color.White;
            this.lblKhuyenMai.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhuyenMai.ForeColor = System.Drawing.Color.Red;
            this.lblKhuyenMai.Location = new System.Drawing.Point(467, 427);
            this.lblKhuyenMai.MaximumSize = new System.Drawing.Size(335, 0);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(268, 16);
            this.lblKhuyenMai.TabIndex = 5;
            this.lblKhuyenMai.Text = "hiển thị ra mã khuyến mãi tồn tại hay không ?";
            // 
            // btnHuy
            // 
            this.btnHuy.AutoRoundedCorners = true;
            this.btnHuy.BackColor = System.Drawing.Color.White;
            this.btnHuy.BorderRadius = 21;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(34)))), ((int)(((byte)(84)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(718, 461);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(128, 45);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Cancel";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.AutoRoundedCorners = true;
            this.btnConfirmPayment.BackColor = System.Drawing.Color.White;
            this.btnConfirmPayment.BorderRadius = 21;
            this.btnConfirmPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(65)))), ((int)(((byte)(118)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(470, 461);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(242, 45);
            this.btnConfirmPayment.TabIndex = 4;
            this.btnConfirmPayment.Text = "Xác nhận thanh toán";
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Animated = true;
            this.txtKhuyenMai.AutoRoundedCorners = true;
            this.txtKhuyenMai.BackColor = System.Drawing.Color.White;
            this.txtKhuyenMai.BorderRadius = 17;
            this.txtKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKhuyenMai.DefaultText = "";
            this.txtKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKhuyenMai.Location = new System.Drawing.Point(470, 378);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.PasswordChar = '\0';
            this.txtKhuyenMai.PlaceholderText = "Nhập mã khuyến mãi...";
            this.txtKhuyenMai.SelectedText = "";
            this.txtKhuyenMai.Size = new System.Drawing.Size(334, 36);
            this.txtKhuyenMai.TabIndex = 3;
            // 
            // panelThongtinThanhToan
            // 
            this.panelThongtinThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.panelThongtinThanhToan.Controls.Add(this.label2);
            this.panelThongtinThanhToan.Controls.Add(this.lblNgayMua);
            this.panelThongtinThanhToan.Controls.Add(this.label4);
            this.panelThongtinThanhToan.Controls.Add(this.lblVoucher);
            this.panelThongtinThanhToan.Controls.Add(this.label5);
            this.panelThongtinThanhToan.Controls.Add(this.lblAmountPayment);
            this.panelThongtinThanhToan.Controls.Add(this.label6);
            this.panelThongtinThanhToan.Controls.Add(this.lblSumPricePayment);
            this.panelThongtinThanhToan.Controls.Add(this.label7);
            this.panelThongtinThanhToan.Controls.Add(this.lblCustomerNamePayment);
            this.panelThongtinThanhToan.Controls.Add(this.label8);
            this.panelThongtinThanhToan.Controls.Add(this.lblOrderIDPayment);
            this.panelThongtinThanhToan.Controls.Add(this.label9);
            this.panelThongtinThanhToan.Location = new System.Drawing.Point(470, 21);
            this.panelThongtinThanhToan.Name = "panelThongtinThanhToan";
            this.panelThongtinThanhToan.Size = new System.Drawing.Size(376, 340);
            this.panelThongtinThanhToan.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(80, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "CHI TIẾT HOÁ ĐƠN ";
            // 
            // lblNgayMua
            // 
            this.lblNgayMua.AutoSize = true;
            this.lblNgayMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayMua.ForeColor = System.Drawing.Color.White;
            this.lblNgayMua.Location = new System.Drawing.Point(172, 262);
            this.lblNgayMua.Name = "lblNgayMua";
            this.lblNgayMua.Size = new System.Drawing.Size(0, 20);
            this.lblNgayMua.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mã hoá đơn: ";
            // 
            // lblVoucher
            // 
            this.lblVoucher.AutoSize = true;
            this.lblVoucher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoucher.ForeColor = System.Drawing.Color.White;
            this.lblVoucher.Location = new System.Drawing.Point(172, 225);
            this.lblVoucher.Name = "lblVoucher";
            this.lblVoucher.Size = new System.Drawing.Size(0, 20);
            this.lblVoucher.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên khách hàng:";
            // 
            // lblAmountPayment
            // 
            this.lblAmountPayment.AutoSize = true;
            this.lblAmountPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountPayment.ForeColor = System.Drawing.Color.White;
            this.lblAmountPayment.Location = new System.Drawing.Point(172, 189);
            this.lblAmountPayment.Name = "lblAmountPayment";
            this.lblAmountPayment.Size = new System.Drawing.Size(0, 20);
            this.lblAmountPayment.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(14, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền:";
            // 
            // lblSumPricePayment
            // 
            this.lblSumPricePayment.AutoSize = true;
            this.lblSumPricePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumPricePayment.ForeColor = System.Drawing.Color.White;
            this.lblSumPricePayment.Location = new System.Drawing.Point(172, 154);
            this.lblSumPricePayment.Name = "lblSumPricePayment";
            this.lblSumPricePayment.Size = new System.Drawing.Size(0, 20);
            this.lblSumPricePayment.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Số lượng:";
            // 
            // lblCustomerNamePayment
            // 
            this.lblCustomerNamePayment.AutoSize = true;
            this.lblCustomerNamePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNamePayment.ForeColor = System.Drawing.Color.White;
            this.lblCustomerNamePayment.Location = new System.Drawing.Point(172, 118);
            this.lblCustomerNamePayment.Name = "lblCustomerNamePayment";
            this.lblCustomerNamePayment.Size = new System.Drawing.Size(0, 20);
            this.lblCustomerNamePayment.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(14, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mã khuyến mãi:";
            // 
            // lblOrderIDPayment
            // 
            this.lblOrderIDPayment.AutoSize = true;
            this.lblOrderIDPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderIDPayment.ForeColor = System.Drawing.Color.White;
            this.lblOrderIDPayment.Location = new System.Drawing.Point(172, 77);
            this.lblOrderIDPayment.Name = "lblOrderIDPayment";
            this.lblOrderIDPayment.Size = new System.Drawing.Size(0, 20);
            this.lblOrderIDPayment.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(14, 262);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Ngày mua:";
            // 
            // panelDetailOrder
            // 
            this.panelDetailOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(99)))), ((int)(((byte)(155)))));
            this.panelDetailOrder.Controls.Add(this.pictureBox1);
            this.panelDetailOrder.Controls.Add(this.label13);
            this.panelDetailOrder.Controls.Add(this.label12);
            this.panelDetailOrder.Controls.Add(this.label11);
            this.panelDetailOrder.Controls.Add(this.label10);
            this.panelDetailOrder.Controls.Add(this.label3);
            this.panelDetailOrder.Location = new System.Drawing.Point(28, 21);
            this.panelDetailOrder.Name = "panelDetailOrder";
            this.panelDetailOrder.Size = new System.Drawing.Size(422, 485);
            this.panelDetailOrder.TabIndex = 2;
            this.panelDetailOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.QR_payment_ver2;
            this.pictureBox1.Location = new System.Drawing.Point(45, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(65, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(295, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Chi nhánh: Ngân Hàng CAKE BANK, HN";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(65, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "STK: 0862587229";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(65, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Chủ TK: TRAN VAN CHIEN";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(65, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ngân hàng: CAKE BANK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(64, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "THÔNG TIN THANH TOÁN";
            // 
            // paymentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 629);
            this.Controls.Add(this.tabControlPayment);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "paymentView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "paymentView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControlPayment.ResumeLayout(false);
            this.tatcaPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.xacthuchoadon.ResumeLayout(false);
            this.xacthuchoadon.PerformLayout();
            this.panelThongtinThanhToan.ResumeLayout(false);
            this.panelThongtinThanhToan.PerformLayout();
            this.panelDetailOrder.ResumeLayout(false);
            this.panelDetailOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlPayment;
        private MetroFramework.Controls.MetroTabPage tatcaPayment;
        private MetroFramework.Controls.MetroTabPage xacthuchoadon;
        private Guna.UI2.WinForms.Guna2TextBox txtKhuyenMai;
        private System.Windows.Forms.Panel panelDetailOrder;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnConfirmPayment;
        private System.Windows.Forms.Label lblKhuyenMai;
        private Guna.UI2.WinForms.Guna2Button btnSearchKhuyenMai;
        private System.Windows.Forms.Panel panelThongtinThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNgayMua;
        private System.Windows.Forms.Label lblVoucher;
        private System.Windows.Forms.Label lblAmountPayment;
        private System.Windows.Forms.Label lblSumPricePayment;
        private System.Windows.Forms.Label lblCustomerNamePayment;
        private System.Windows.Forms.Label lblOrderIDPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2DateTimePicker NgayBatDau;
        private Guna.UI2.WinForms.Guna2DateTimePicker NgayKetThuc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchPayment;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPayment;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}