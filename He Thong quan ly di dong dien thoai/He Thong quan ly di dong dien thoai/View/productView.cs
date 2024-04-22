using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class productView : Form, iSPView
    {

        //Fields
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;

        // Constructor
        public productView()
        {
            InitializeComponent();
            LienKetVaNangCaoLuotXem(); // Associate And Raise View Events
            tabControl1.TabPages.Remove(tabPageProductDetail);
        }

        private void LienKetVaNangCaoLuotXem()
        {

            // Search product
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Add new product
            btnThemSanPham.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabControl1.SelectedTab = tabPageProductDetail; // Chọn tabPageProductDetail để hiển thị
                tabPageProductDetail.Text = "Thêm sản phẩm mới";
            };
            // Edit product
            btnSuaSanPham.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabControl1.SelectedTab = tabPageProductDetail; // Chọn tabPageProductDetail để hiển thị
                tabPageProductDetail.Text = "Sửa thông tin sản phẩm";
            };
            // Save changes product
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);
                    tabControl1.SelectedTab = tabPageProductList; // Chọn tabPageProductList để hiển thị
                }
                MessageBox.Show(Message);
            };
            // Cancel product
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);
                tabControl1.SelectedTab = tabPageProductList; // Chọn tabPageProductList để hiển thị
            };
            // Delete product
            btnXoaSanPham.Click += delegate
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xoá sản phẩm này chứ ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public long SPID
        {
            get
            {
                // Convert string to long
                long result;
                if (long.TryParse(txtMaSanPham.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle parsing error, maybe show an error message to the user
                    MessageBox.Show("ID không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; // Return a default value or throw an exception
                }
            }
            set
            {
                // Convert long to string
                txtMaSanPham.Text = value.ToString();
            }
        }


        public string TenSanPham
        {
            get { return txtTenSanPham.Text; }
            set { txtTenSanPham.Text = value; }
        }

        //public int MaDanhMuc
        //{
        //    get
        //    {
        //        // Convert string to int
        //        int result;
        //        if (int.TryParse(txtMaDanhMuc.Text, out result))
        //        {
        //            return result;
        //        }
        //        else
        //        {
        //            // Handle parsing error, maybe throw an exception or return a default value
        //            throw new InvalidOperationException("Invalid input for MaDanhMuc.");
        //        }
        //    }
        //    set
        //    {
        //        // Convert int to string
        //        txtMaDanhMuc.Text = value.ToString();
        //    }
        //}

        public decimal Gia
        {
            get
            {
                // Convert string to decimal
                decimal result;
                if (decimal.TryParse(txtGiaTien.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle parsing error, maybe show an error message to the user
                    MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0; // Return a default value or throw an exception
                }
            }
            set
            {
                // Convert decimal to string
                txtGiaTien.Text = value.ToString();
            }
        }

        public string MoTa
        {
            get { return txtMoTa.Text; }
            set { txtMoTa.Text = value; }
        }
        public string TenDanhMuc
        {
            get { return txtTenDanhMuc.Text; }
            set { txtTenDanhMuc.Text = value; }
        }
        public string TimKiem
        {
            get { return searchProduct.Text; }

            set { searchProduct.Text = value; }
        }
        public bool isEdit
        {
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        // Kiem tra xem co thanh cong khong 
        public bool isSuccessful
        {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }

        // Thong báo he thong 
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }



        // Events
        public event EventHandler SearchEvent; // sự kiện tìm kiếm
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void productView_Load(object sender, EventArgs e)
        {
           
        }
        // Methods SetProductBlindingSource()
        public void SetProductBlindingSource(BindingSource productList)
        {
            dgvSanPham.DataSource = productList;
        }


        // duy nhat 1 form san pham khi nhan vao nut san pham | truyền Dashboard vào
        private static productView instance; //               V
        public static productView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new productView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemSanPham_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
