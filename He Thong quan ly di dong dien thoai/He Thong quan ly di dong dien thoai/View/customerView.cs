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
    public partial class customerView : Form, iCustomerView
    {
        private int selectedCustomerID;
        public customerView()
        {
            InitializeComponent();
            LienKetVaNangCaoLuotXem();
            tabControlCustomer.TabPages.Remove(tabCustomerDetail);
            
        }

        private void LienKetVaNangCaoLuotXem()
        {

            // Search product
            btnSearchCustomer.Click += delegate { SearchCustomerEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchCustomer.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchCustomerEvent?.Invoke(this, EventArgs.Empty);
                }
            };

            // Add new product
            btnAddCustomer.Click += delegate
            {
                AddCustomerEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabCustomerList);
                tabControlCustomer.TabPages.Add(tabCustomerDetail);
                tabControlCustomer.SelectedTab = tabCustomerDetail; // Chọn tabPageProductDetail để hiển thị
                tabCustomerDetail.Text = "Thêm Khách Hàng Mới";
            };

            // Edit product
            btnEditCustomer.Click += delegate
            {
                EditCustomerEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabCustomerList);
                tabControlCustomer.TabPages.Add(tabCustomerDetail);
                tabControlCustomer.SelectedTab = tabCustomerDetail; // Chọn tabPageProductDetail để hiển thị
                tabCustomerDetail.Text = "Thay đổi thông tin khách hàng";
            };
            // Save changes product
            btnSaveCustomer.Click += delegate
            {
                SaveCustomerEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlCustomer.TabPages.Remove(tabCustomerDetail);
                    tabControlCustomer.TabPages.Add(tabCustomerList);
                    tabControlCustomer.SelectedTab = tabCustomerList; // Chọn tabPageProductList để hiển thị
                }
                MessageBox.Show(Message);
            };

            // Cancel product
            btnCancelCustomer.Click += delegate
            {
                CancelCustomerEvent?.Invoke(this, EventArgs.Empty);
                tabControlCustomer.TabPages.Remove(tabCustomerDetail);
                tabControlCustomer.TabPages.Add(tabCustomerList);
                tabControlCustomer.SelectedTab = tabCustomerList; // Chọn tabPageProductList để hiển thị
            };
            // Delete product
            btnRemoveCustomer.Click += delegate
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xoá sản phẩm này chứ ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteCustomerEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }


        public int idView 
        {
            get
            {
                // Kiểm tra xem ô nhập mã sản phẩm có được kích hoạt hay không
                if (txtCustomerID.Enabled)
                {
                    // Convert string to long
                    int result;
                    if (int.TryParse(txtCustomerID.Text, out result))
                    {
                        return result;
                    }
                    else
                    {
                        // Handle parsing error, maybe show an error message to the user
                        MessageBox.Show("ID Customer không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0; // Return a default value or throw an exception
                    }
                }
                else
                {
                    // Trả về giá trị mặc định khi không cần nhập mã sản phẩm
                    return selectedCustomerID;
                }
            }
            set
            {
                // Convert long to string
                txtCustomerID.Text = value.ToString();
            }
        }
        public string NameCustomer { get => txtNameCustomer.Text; set => txtNameCustomer.Text = value; }
        public string EmailCustomer { get => txtEmailCustomer.Text; set => txtEmailCustomer.Text = value; }
        public string PhoneCustomer { get => txtPhoneCustomer.Text; set => txtPhoneCustomer.Text = value; }
        public string AddressCustomer { get => txtAddressCustomer.Text; set => txtAddressCustomer.Text = value; }
        public string TimKiem { get => txtSearchCustomer.Text; set => txtSearchCustomer.Text = value; }


        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;
        public bool isEdit { get => _isEdit; set => _isEdit = value; }
        public bool isSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        public event EventHandler SearchCustomerEvent;
        public event EventHandler AddCustomerEvent;
        public event EventHandler EditCustomerEvent;
        public event EventHandler DeleteCustomerEvent;
        public event EventHandler SaveCustomerEvent;
        public event EventHandler CancelCustomerEvent;

        public void SetProductBindingSource(BindingSource customerList)
        {
            dgvKhachHang.DataSource = customerList;
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

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Chắc chắn rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];

                // Lấy giá trị của trường mã sản phẩm từ hàng được chọn và gán vào txtMaSanPham
                txtCustomerID.Text = row.Cells[0].Value.ToString();
                selectedCustomerID = int.Parse(row.Cells[0].Value.ToString());
            }
        }

        private void tabCustomerList_Click(object sender, EventArgs e)
        {

        }
    }
}
