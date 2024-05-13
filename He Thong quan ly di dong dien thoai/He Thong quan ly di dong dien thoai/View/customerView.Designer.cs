namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    partial class customerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerView));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCustomer = new MetroFramework.Controls.MetroTabControl();
            this.tabCustomerDetail = new MetroFramework.Controls.MetroTabPage();
            this.btnCancelCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaveCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtAddressCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhoneCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCustomerList = new MetroFramework.Controls.MetroTabPage();
            this.dgvKhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRemoveCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearchCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchCustomer = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1.SuspendLayout();
            this.tabControlCustomer.SuspendLayout();
            this.tabCustomerDetail.SuspendLayout();
            this.tabCustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
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
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Mục Khách Hàng";
            // 
            // tabControlCustomer
            // 
            this.tabControlCustomer.Controls.Add(this.tabCustomerDetail);
            this.tabControlCustomer.Controls.Add(this.tabCustomerList);
            this.tabControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCustomer.Location = new System.Drawing.Point(0, 63);
            this.tabControlCustomer.Name = "tabControlCustomer";
            this.tabControlCustomer.SelectedIndex = 1;
            this.tabControlCustomer.Size = new System.Drawing.Size(887, 566);
            this.tabControlCustomer.TabIndex = 3;
            this.tabControlCustomer.UseSelectable = true;
            // 
            // tabCustomerDetail
            // 
            this.tabCustomerDetail.Controls.Add(this.btnCancelCustomer);
            this.tabCustomerDetail.Controls.Add(this.btnSaveCustomer);
            this.tabCustomerDetail.Controls.Add(this.txtAddressCustomer);
            this.tabCustomerDetail.Controls.Add(this.label6);
            this.tabCustomerDetail.Controls.Add(this.label5);
            this.tabCustomerDetail.Controls.Add(this.txtPhoneCustomer);
            this.tabCustomerDetail.Controls.Add(this.txtEmailCustomer);
            this.tabCustomerDetail.Controls.Add(this.label4);
            this.tabCustomerDetail.Controls.Add(this.txtCustomerID);
            this.tabCustomerDetail.Controls.Add(this.label3);
            this.tabCustomerDetail.Controls.Add(this.txtNameCustomer);
            this.tabCustomerDetail.Controls.Add(this.label2);
            this.tabCustomerDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomerDetail.HorizontalScrollbarBarColor = true;
            this.tabCustomerDetail.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCustomerDetail.HorizontalScrollbarSize = 10;
            this.tabCustomerDetail.Location = new System.Drawing.Point(4, 38);
            this.tabCustomerDetail.Name = "tabCustomerDetail";
            this.tabCustomerDetail.Size = new System.Drawing.Size(879, 524);
            this.tabCustomerDetail.TabIndex = 1;
            this.tabCustomerDetail.Text = "Thông Tin Chi Tiết";
            this.tabCustomerDetail.VerticalScrollbarBarColor = true;
            this.tabCustomerDetail.VerticalScrollbarHighlightOnWheel = false;
            this.tabCustomerDetail.VerticalScrollbarSize = 10;
            // 
            // btnCancelCustomer
            // 
            this.btnCancelCustomer.AutoRoundedCorners = true;
            this.btnCancelCustomer.BackColor = System.Drawing.Color.White;
            this.btnCancelCustomer.BorderRadius = 21;
            this.btnCancelCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelCustomer.FillColor = System.Drawing.Color.Red;
            this.btnCancelCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCancelCustomer.Location = new System.Drawing.Point(448, 343);
            this.btnCancelCustomer.Name = "btnCancelCustomer";
            this.btnCancelCustomer.Size = new System.Drawing.Size(180, 45);
            this.btnCancelCustomer.TabIndex = 13;
            this.btnCancelCustomer.Text = "Cancel";
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.AutoRoundedCorners = true;
            this.btnSaveCustomer.BackColor = System.Drawing.Color.White;
            this.btnSaveCustomer.BorderRadius = 21;
            this.btnSaveCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSaveCustomer.Location = new System.Drawing.Point(248, 343);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(180, 45);
            this.btnSaveCustomer.TabIndex = 12;
            this.btnSaveCustomer.Text = "Save";
            // 
            // txtAddressCustomer
            // 
            this.txtAddressCustomer.AutoRoundedCorners = true;
            this.txtAddressCustomer.BackColor = System.Drawing.Color.White;
            this.txtAddressCustomer.BorderRadius = 17;
            this.txtAddressCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddressCustomer.DefaultText = "";
            this.txtAddressCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddressCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddressCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddressCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddressCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddressCustomer.Location = new System.Drawing.Point(216, 279);
            this.txtAddressCustomer.Name = "txtAddressCustomer";
            this.txtAddressCustomer.PasswordChar = '\0';
            this.txtAddressCustomer.PlaceholderText = "";
            this.txtAddressCustomer.SelectedText = "";
            this.txtAddressCustomer.Size = new System.Drawing.Size(444, 36);
            this.txtAddressCustomer.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(216, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số Điện Thoại";
            // 
            // txtPhoneCustomer
            // 
            this.txtPhoneCustomer.AutoRoundedCorners = true;
            this.txtPhoneCustomer.BackColor = System.Drawing.Color.White;
            this.txtPhoneCustomer.BorderRadius = 17;
            this.txtPhoneCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneCustomer.DefaultText = "";
            this.txtPhoneCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhoneCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhoneCustomer.Location = new System.Drawing.Point(460, 198);
            this.txtPhoneCustomer.Name = "txtPhoneCustomer";
            this.txtPhoneCustomer.PasswordChar = '\0';
            this.txtPhoneCustomer.PlaceholderText = "";
            this.txtPhoneCustomer.SelectedText = "";
            this.txtPhoneCustomer.Size = new System.Drawing.Size(200, 36);
            this.txtPhoneCustomer.TabIndex = 8;
            // 
            // txtEmailCustomer
            // 
            this.txtEmailCustomer.AutoRoundedCorners = true;
            this.txtEmailCustomer.BackColor = System.Drawing.Color.White;
            this.txtEmailCustomer.BorderRadius = 17;
            this.txtEmailCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailCustomer.DefaultText = "";
            this.txtEmailCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmailCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailCustomer.Location = new System.Drawing.Point(216, 198);
            this.txtEmailCustomer.Name = "txtEmailCustomer";
            this.txtEmailCustomer.PasswordChar = '\0';
            this.txtEmailCustomer.PlaceholderText = "";
            this.txtEmailCustomer.SelectedText = "";
            this.txtEmailCustomer.Size = new System.Drawing.Size(200, 36);
            this.txtEmailCustomer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(216, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.AutoRoundedCorners = true;
            this.txtCustomerID.BackColor = System.Drawing.Color.White;
            this.txtCustomerID.BorderRadius = 17;
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Location = new System.Drawing.Point(460, 115);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(200, 36);
            this.txtCustomerID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(456, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.AutoRoundedCorners = true;
            this.txtNameCustomer.BackColor = System.Drawing.Color.White;
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
            this.txtNameCustomer.Location = new System.Drawing.Point(216, 115);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.PlaceholderText = "";
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.Size = new System.Drawing.Size(200, 36);
            this.txtNameCustomer.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // tabCustomerList
            // 
            this.tabCustomerList.BackColor = System.Drawing.Color.Transparent;
            this.tabCustomerList.Controls.Add(this.dgvKhachHang);
            this.tabCustomerList.Controls.Add(this.btnRemoveCustomer);
            this.tabCustomerList.Controls.Add(this.btnEditCustomer);
            this.tabCustomerList.Controls.Add(this.btnAddCustomer);
            this.tabCustomerList.Controls.Add(this.btnSearchCustomer);
            this.tabCustomerList.Controls.Add(this.txtSearchCustomer);
            this.tabCustomerList.Controls.Add(this.panel1);
            this.tabCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCustomerList.ForeColor = System.Drawing.Color.Black;
            this.tabCustomerList.HorizontalScrollbarBarColor = true;
            this.tabCustomerList.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCustomerList.HorizontalScrollbarSize = 10;
            this.tabCustomerList.Location = new System.Drawing.Point(4, 38);
            this.tabCustomerList.Name = "tabCustomerList";
            this.tabCustomerList.Size = new System.Drawing.Size(879, 524);
            this.tabCustomerList.TabIndex = 0;
            this.tabCustomerList.Text = "Danh Sách Khách Hàng";
            this.tabCustomerList.VerticalScrollbarBarColor = true;
            this.tabCustomerList.VerticalScrollbarHighlightOnWheel = false;
            this.tabCustomerList.VerticalScrollbarSize = 10;
            this.tabCustomerList.Click += new System.EventHandler(this.tabCustomerList_Click);
            // 
            // dgvKhachHang
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvKhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(56)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachHang.ColumnHeadersHeight = 60;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvKhachHang.Location = new System.Drawing.Point(0, 49);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.RowTemplate.Height = 41;
            this.dgvKhachHang.RowTemplate.ReadOnly = true;
            this.dgvKhachHang.Size = new System.Drawing.Size(879, 475);
            this.dgvKhachHang.TabIndex = 8;
            this.dgvKhachHang.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvKhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvKhachHang.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvKhachHang.ThemeStyle.ReadOnly = true;
            this.dgvKhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvKhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.ThemeStyle.RowsStyle.Height = 41;
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dgvKhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvKhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKhachHang_CellClick);
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.AutoRoundedCorners = true;
            this.btnRemoveCustomer.BackColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.BorderRadius = 16;
            this.btnRemoveCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemoveCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemoveCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemoveCustomer.FillColor = System.Drawing.Color.Red;
            this.btnRemoveCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveCustomer.ForeColor = System.Drawing.Color.White;
            this.btnRemoveCustomer.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.remove_customer;
            this.btnRemoveCustomer.Location = new System.Drawing.Point(764, 4);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnRemoveCustomer.TabIndex = 7;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.AutoRoundedCorners = true;
            this.btnEditCustomer.BackColor = System.Drawing.Color.White;
            this.btnEditCustomer.BorderRadius = 16;
            this.btnEditCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btnEditCustomer.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.edit_customer;
            this.btnEditCustomer.Location = new System.Drawing.Point(726, 5);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnEditCustomer.TabIndex = 6;
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.AutoRoundedCorners = true;
            this.btnAddCustomer.BackColor = System.Drawing.Color.White;
            this.btnAddCustomer.BorderRadius = 16;
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.add_customer;
            this.btnAddCustomer.Location = new System.Drawing.Point(688, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnAddCustomer.TabIndex = 5;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.AutoRoundedCorners = true;
            this.btnSearchCustomer.BackColor = System.Drawing.Color.White;
            this.btnSearchCustomer.BorderRadius = 16;
            this.btnSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearchCustomer.FillColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSearchCustomer.ForeColor = System.Drawing.Color.White;
            this.btnSearchCustomer.Image = global::He_Thong_quan_ly_di_dong_dien_thoai.Properties.Resources.search;
            this.btnSearchCustomer.Location = new System.Drawing.Point(647, 4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(35, 35);
            this.btnSearchCustomer.TabIndex = 3;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.AutoRoundedCorners = true;
            this.txtSearchCustomer.BackColor = System.Drawing.Color.White;
            this.txtSearchCustomer.BorderRadius = 17;
            this.txtSearchCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCustomer.DefaultText = "";
            this.txtSearchCustomer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchCustomer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCustomer.Location = new System.Drawing.Point(14, 7);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.PasswordChar = '\0';
            this.txtSearchCustomer.PlaceholderText = "Tìm kiếm khách hàng...";
            this.txtSearchCustomer.SelectedText = "";
            this.txtSearchCustomer.Size = new System.Drawing.Size(630, 36);
            this.txtSearchCustomer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(879, 49);
            this.panel1.TabIndex = 4;
            // 
            // customerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 629);
            this.Controls.Add(this.tabControlCustomer);
            this.Controls.Add(this.guna2Panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerView";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.tabControlCustomer.ResumeLayout(false);
            this.tabCustomerDetail.ResumeLayout(false);
            this.tabCustomerDetail.PerformLayout();
            this.tabCustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTabControl tabControlCustomer;
        private MetroFramework.Controls.MetroTabPage tabCustomerList;
        private MetroFramework.Controls.MetroTabPage tabCustomerDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSearchCustomer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private Guna.UI2.WinForms.Guna2Button btnEditCustomer;
        private Guna.UI2.WinForms.Guna2Button btnRemoveCustomer;
        private Guna.UI2.WinForms.Guna2DataGridView dgvKhachHang;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtNameCustomer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailCustomer;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneCustomer;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtAddressCustomer;
        private Guna.UI2.WinForms.Guna2Button btnSaveCustomer;
        private Guna.UI2.WinForms.Guna2Button btnCancelCustomer;
    }
}