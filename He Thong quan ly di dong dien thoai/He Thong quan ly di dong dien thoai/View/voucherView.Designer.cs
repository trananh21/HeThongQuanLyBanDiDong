namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    partial class voucherView
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
            this.tabControlVoucher = new MetroFramework.Controls.MetroTabControl();
            this.tabAllVoucher = new MetroFramework.Controls.MetroTabPage();
            this.tabVoucher = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMoTaVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.DateEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnSaveVoucher = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancelVoucher = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchVoucher = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelVoucher = new Guna.UI2.WinForms.Guna2Button();
            this.dgvVoucher = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel1.SuspendLayout();
            this.tabControlVoucher.SuspendLayout();
            this.tabAllVoucher.SuspendLayout();
            this.tabVoucher.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
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
            this.guna2Panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Khuyến Mãi";
            // 
            // tabControlVoucher
            // 
            this.tabControlVoucher.Controls.Add(this.tabAllVoucher);
            this.tabControlVoucher.Controls.Add(this.tabVoucher);
            this.tabControlVoucher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlVoucher.Location = new System.Drawing.Point(0, 63);
            this.tabControlVoucher.Name = "tabControlVoucher";
            this.tabControlVoucher.SelectedIndex = 0;
            this.tabControlVoucher.Size = new System.Drawing.Size(887, 566);
            this.tabControlVoucher.TabIndex = 5;
            this.tabControlVoucher.UseSelectable = true;
            // 
            // tabAllVoucher
            // 
            this.tabAllVoucher.Controls.Add(this.panel1);
            this.tabAllVoucher.Controls.Add(this.dgvVoucher);
            this.tabAllVoucher.HorizontalScrollbarBarColor = true;
            this.tabAllVoucher.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAllVoucher.HorizontalScrollbarSize = 10;
            this.tabAllVoucher.Location = new System.Drawing.Point(4, 38);
            this.tabAllVoucher.Name = "tabAllVoucher";
            this.tabAllVoucher.Size = new System.Drawing.Size(879, 524);
            this.tabAllVoucher.TabIndex = 0;
            this.tabAllVoucher.Text = "Tất cả";
            this.tabAllVoucher.VerticalScrollbarBarColor = true;
            this.tabAllVoucher.VerticalScrollbarHighlightOnWheel = false;
            this.tabAllVoucher.VerticalScrollbarSize = 10;
            // 
            // tabVoucher
            // 
            this.tabVoucher.Controls.Add(this.btnCancelVoucher);
            this.tabVoucher.Controls.Add(this.btnSaveVoucher);
            this.tabVoucher.Controls.Add(this.DateEnd);
            this.tabVoucher.Controls.Add(this.DateStart);
            this.tabVoucher.Controls.Add(this.txtMoTaVoucher);
            this.tabVoucher.Controls.Add(this.txtTenKhuyenMai);
            this.tabVoucher.Controls.Add(this.txtMaKhuyenMai);
            this.tabVoucher.Controls.Add(this.label6);
            this.tabVoucher.Controls.Add(this.label5);
            this.tabVoucher.Controls.Add(this.label4);
            this.tabVoucher.Controls.Add(this.label3);
            this.tabVoucher.Controls.Add(this.label2);
            this.tabVoucher.HorizontalScrollbarBarColor = true;
            this.tabVoucher.HorizontalScrollbarHighlightOnWheel = false;
            this.tabVoucher.HorizontalScrollbarSize = 10;
            this.tabVoucher.Location = new System.Drawing.Point(4, 38);
            this.tabVoucher.Name = "tabVoucher";
            this.tabVoucher.Size = new System.Drawing.Size(879, 524);
            this.tabVoucher.TabIndex = 1;
            this.tabVoucher.Text = "Tạo lập khuyến mãi";
            this.tabVoucher.VerticalScrollbarBarColor = true;
            this.tabVoucher.VerticalScrollbarHighlightOnWheel = false;
            this.tabVoucher.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Khuyến Mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Khuyến Mãi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mô Tả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(219, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ngày Bắt Đầu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày Kết Thúc";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.AutoRoundedCorners = true;
            this.txtMaKhuyenMai.BackColor = System.Drawing.Color.White;
            this.txtMaKhuyenMai.BorderRadius = 17;
            this.txtMaKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhuyenMai.DefaultText = "";
            this.txtMaKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhuyenMai.Enabled = false;
            this.txtMaKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(223, 252);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.PasswordChar = '\0';
            this.txtMaKhuyenMai.PlaceholderText = "";
            this.txtMaKhuyenMai.SelectedText = "";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(200, 36);
            this.txtMaKhuyenMai.TabIndex = 4;
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.AutoRoundedCorners = true;
            this.txtTenKhuyenMai.BackColor = System.Drawing.Color.White;
            this.txtTenKhuyenMai.BorderRadius = 17;
            this.txtTenKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhuyenMai.DefaultText = "";
            this.txtTenKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(461, 252);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.PasswordChar = '\0';
            this.txtTenKhuyenMai.PlaceholderText = "";
            this.txtTenKhuyenMai.SelectedText = "";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(200, 36);
            this.txtTenKhuyenMai.TabIndex = 4;
            // 
            // txtMoTaVoucher
            // 
            this.txtMoTaVoucher.AutoRoundedCorners = true;
            this.txtMoTaVoucher.BackColor = System.Drawing.Color.White;
            this.txtMoTaVoucher.BorderRadius = 17;
            this.txtMoTaVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTaVoucher.DefaultText = "";
            this.txtMoTaVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTaVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTaVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTaVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTaVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTaVoucher.Location = new System.Drawing.Point(223, 330);
            this.txtMoTaVoucher.Name = "txtMoTaVoucher";
            this.txtMoTaVoucher.PasswordChar = '\0';
            this.txtMoTaVoucher.PlaceholderText = "";
            this.txtMoTaVoucher.SelectedText = "";
            this.txtMoTaVoucher.Size = new System.Drawing.Size(438, 36);
            this.txtMoTaVoucher.TabIndex = 4;
            // 
            // DateStart
            // 
            this.DateStart.AutoRoundedCorners = true;
            this.DateStart.BackColor = System.Drawing.Color.White;
            this.DateStart.BorderRadius = 17;
            this.DateStart.Checked = true;
            this.DateStart.FillColor = System.Drawing.Color.Cyan;
            this.DateStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateStart.Location = new System.Drawing.Point(223, 93);
            this.DateStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(438, 36);
            this.DateStart.TabIndex = 5;
            this.DateStart.Value = new System.DateTime(2024, 5, 20, 21, 50, 57, 40);
            // 
            // DateEnd
            // 
            this.DateEnd.AutoRoundedCorners = true;
            this.DateEnd.BackColor = System.Drawing.Color.White;
            this.DateEnd.BorderRadius = 17;
            this.DateEnd.Checked = true;
            this.DateEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateEnd.Location = new System.Drawing.Point(223, 170);
            this.DateEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(438, 36);
            this.DateEnd.TabIndex = 6;
            this.DateEnd.Value = new System.DateTime(2024, 5, 20, 21, 51, 23, 87);
            // 
            // btnSaveVoucher
            // 
            this.btnSaveVoucher.AutoRoundedCorners = true;
            this.btnSaveVoucher.BackColor = System.Drawing.Color.White;
            this.btnSaveVoucher.BorderRadius = 21;
            this.btnSaveVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveVoucher.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveVoucher.ForeColor = System.Drawing.Color.White;
            this.btnSaveVoucher.Location = new System.Drawing.Point(223, 391);
            this.btnSaveVoucher.Name = "btnSaveVoucher";
            this.btnSaveVoucher.Size = new System.Drawing.Size(200, 45);
            this.btnSaveVoucher.TabIndex = 7;
            this.btnSaveVoucher.Text = "Save";
            // 
            // btnCancelVoucher
            // 
            this.btnCancelVoucher.AutoRoundedCorners = true;
            this.btnCancelVoucher.BackColor = System.Drawing.Color.White;
            this.btnCancelVoucher.BorderRadius = 21;
            this.btnCancelVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelVoucher.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelVoucher.ForeColor = System.Drawing.Color.White;
            this.btnCancelVoucher.Location = new System.Drawing.Point(461, 391);
            this.btnCancelVoucher.Name = "btnCancelVoucher";
            this.btnCancelVoucher.Size = new System.Drawing.Size(200, 45);
            this.btnCancelVoucher.TabIndex = 7;
            this.btnCancelVoucher.Text = "Cancel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtSearchVoucher);
            this.panel1.Controls.Add(this.btnDelVoucher);
            this.panel1.Controls.Add(this.btnEditVoucher);
            this.panel1.Controls.Add(this.btnCreateVoucher);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 49);
            this.panel1.TabIndex = 2;
            // 
            // txtSearchVoucher
            // 
            this.txtSearchVoucher.AutoRoundedCorners = true;
            this.txtSearchVoucher.BorderRadius = 17;
            this.txtSearchVoucher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchVoucher.DefaultText = "";
            this.txtSearchVoucher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchVoucher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchVoucher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchVoucher.Location = new System.Drawing.Point(14, 7);
            this.txtSearchVoucher.Name = "txtSearchVoucher";
            this.txtSearchVoucher.PasswordChar = '\0';
            this.txtSearchVoucher.PlaceholderText = "Tìm kiếm theo mã khuyến mãi...";
            this.txtSearchVoucher.SelectedText = "";
            this.txtSearchVoucher.Size = new System.Drawing.Size(630, 36);
            this.txtSearchVoucher.TabIndex = 0;
            // 
            // btnEditVoucher
            // 
            this.btnEditVoucher.AutoRoundedCorners = true;
            this.btnEditVoucher.BorderRadius = 16;
            this.btnEditVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditVoucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEditVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditVoucher.ForeColor = System.Drawing.Color.Teal;
            this.btnEditVoucher.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.edit_voucher_ver2;
            this.btnEditVoucher.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEditVoucher.Location = new System.Drawing.Point(732, 8);
            this.btnEditVoucher.Name = "btnEditVoucher";
            this.btnEditVoucher.Size = new System.Drawing.Size(35, 35);
            this.btnEditVoucher.TabIndex = 3;
            // 
            // btnCreateVoucher
            // 
            this.btnCreateVoucher.AutoRoundedCorners = true;
            this.btnCreateVoucher.BorderRadius = 16;
            this.btnCreateVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateVoucher.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCreateVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCreateVoucher.ForeColor = System.Drawing.Color.White;
            this.btnCreateVoucher.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.add_voucher;
            this.btnCreateVoucher.Location = new System.Drawing.Point(691, 8);
            this.btnCreateVoucher.Name = "btnCreateVoucher";
            this.btnCreateVoucher.Size = new System.Drawing.Size(35, 35);
            this.btnCreateVoucher.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.White;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.icon_search_ver1;
            this.btnSearch.Location = new System.Drawing.Point(650, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 35);
            this.btnSearch.TabIndex = 1;
            // 
            // btnDelVoucher
            // 
            this.btnDelVoucher.AutoRoundedCorners = true;
            this.btnDelVoucher.BorderRadius = 16;
            this.btnDelVoucher.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelVoucher.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelVoucher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelVoucher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelVoucher.FillColor = System.Drawing.Color.Red;
            this.btnDelVoucher.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelVoucher.ForeColor = System.Drawing.Color.White;
            this.btnDelVoucher.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.icon_remove;
            this.btnDelVoucher.Location = new System.Drawing.Point(773, 8);
            this.btnDelVoucher.Name = "btnDelVoucher";
            this.btnDelVoucher.Size = new System.Drawing.Size(35, 35);
            this.btnDelVoucher.TabIndex = 3;
            // 
            // dgvVoucher
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVoucher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVoucher.ColumnHeadersHeight = 60;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVoucher.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVoucher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvVoucher.Location = new System.Drawing.Point(0, 49);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVoucher.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVoucher.RowHeadersVisible = false;
            this.dgvVoucher.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVoucher.RowTemplate.Height = 41;
            this.dgvVoucher.Size = new System.Drawing.Size(879, 475);
            this.dgvVoucher.TabIndex = 3;
            this.dgvVoucher.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVoucher.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvVoucher.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvVoucher.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVoucher.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVoucher.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVoucher.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvVoucher.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvVoucher.ThemeStyle.ReadOnly = true;
            this.dgvVoucher.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvVoucher.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVoucher.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvVoucher.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvVoucher.ThemeStyle.RowsStyle.Height = 41;
            this.dgvVoucher.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvVoucher.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvVoucher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVoucher_CellClick);
            // 
            // voucherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 629);
            this.Controls.Add(this.tabControlVoucher);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "voucherView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "voucherView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControlVoucher.ResumeLayout(false);
            this.tabAllVoucher.ResumeLayout(false);
            this.tabVoucher.ResumeLayout(false);
            this.tabVoucher.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlVoucher;
        private MetroFramework.Controls.MetroTabPage tabAllVoucher;
        private MetroFramework.Controls.MetroTabPage tabVoucher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtMaKhuyenMai;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTaVoucher;
        private Guna.UI2.WinForms.Guna2TextBox txtTenKhuyenMai;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateStart;
        private Guna.UI2.WinForms.Guna2GradientButton btnSaveVoucher;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancelVoucher;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchVoucher;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnCreateVoucher;
        private Guna.UI2.WinForms.Guna2Button btnEditVoucher;
        private Guna.UI2.WinForms.Guna2Button btnDelVoucher;
        private Guna.UI2.WinForms.Guna2DataGridView dgvVoucher;
    }
}