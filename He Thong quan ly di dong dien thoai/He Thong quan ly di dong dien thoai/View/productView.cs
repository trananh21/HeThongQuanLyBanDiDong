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
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            searchProduct.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Khac
        }

        public int SPID
        {
            get
            {
                // Convert string to int
                int result;
                if (int.TryParse(txtMaSanPham.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle parsing error, maybe throw an exception or return a default value
                    throw new InvalidOperationException("Invalid input for MaDanhMuc.");
                }
            }
            set
            {
                // Convert int to string
                txtMaSanPham.Text = value.ToString();
            }
        }
        public string TenSanPham {
            get { return txtTenSanPham.Text; }
            set { txtTenSanPham.Text = value; }
        }
        public int MaDanhMuc
        {
            get
            {
                // Convert string to int
                int result;
                if (int.TryParse(txtMaDanhMuc.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle parsing error, maybe throw an exception or return a default value
                    throw new InvalidOperationException("Invalid input for MaDanhMuc.");
                }
            }
            set
            {
                // Convert int to string
                txtMaDanhMuc.Text = value.ToString();
            }
        }

        public decimal Gia {
            get
            {
                // Convert string to int
                int result;
                if (int.TryParse(txtGiaTien.Text, out result))
                {
                    return result;
                }
                else
                {
                    // Handle parsing error, maybe throw an exception or return a default value
                    throw new InvalidOperationException("Invalid input for MaDanhMuc.");
                }
            }
            set
            {
                // Convert int to string
                txtGiaTien.Text = value.ToString();
            }
        }
        public string MoTa { 
            get { return txtMoTa.Text; }
            set { txtMoTa.Text = value; }
        }
        public string TenDanhMuc {
            get { return txtTenDanhMuc.Text; }
            set { txtTenDanhMuc.Text = value; }
        }
        public string TimKiem
        {
            get{ return searchProduct.Text; }

            set { searchProduct.Text = value; }
        }
        public bool isEdit { 
            get { return _isEdit; }
            set { _isEdit = value; }
        }
        // Kiem tra xem co thanh cong khong 
        public bool isSuccessful {
            get { return _isSuccessful; }
            set { _isSuccessful = value; }
        }

        // Thong báo he thong 
        public string Message {
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

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
