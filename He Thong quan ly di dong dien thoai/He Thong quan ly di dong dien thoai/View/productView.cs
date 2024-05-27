using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using System.Security.Cryptography.X509Certificates;
using System.Web.UI.WebControls;
namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class productView : Form, iSPView
    {

        //Fields
        private string _message;
        private bool _isSuccessful;
        private bool _isEdit;
        private int selectIdProduct;
        // Constructor
        public productView()
        {
            InitializeComponent();
            LienKetVaNangCaoLuotXem(); 
            tabControl1.TabPages.Remove(tabPageProductDetail);
            LoadDanhMuc();
        }

        // Phương thức để load danh mục vào combo box
        private void LoadDanhMuc()
        {
            // Lấy danh sách danh mục từ cơ sở dữ liệu
            List<string> danhMucList = GetDanhMucListFromDatabase(); // Viết phương thức này để lấy danh sách danh mục từ cơ sở dữ liệu

            // Đổ danh sách danh mục vào combo box
            foreach (string danhMuc in danhMucList)
            {
                cbDanhMuc.Items.Add(danhMuc);
            }
        }
        private SqlConnection conn = new SqlConnection(SQLConnections.KetnoiSQL());
        private string connectionString;
        private List<string> GetDanhMucListFromDatabase()
        {
            connectionString = conn.ConnectionString;
            List<string> danhMucList = new List<string>();
            // Khởi tạo kết nối tới cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo câu lệnh SQL để lấy danh sách danh mục
                string query = "SELECT TenDanhMuc FROM DanhMucSanPham";

                // Khởi tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thực thi câu lệnh SQL và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Duyệt qua các dòng kết quả
                        while (reader.Read())
                        {
                            // Đọc giá trị của cột TenDanhMuc
                            string tenDanhMuc = reader["TenDanhMuc"].ToString();

                            // Thêm vào danh sách danh mục
                            danhMucList.Add(tenDanhMuc);
                        }
                    }
                }
            }

            // Trả về danh sách danh mục đã lấy được từ cơ sở dữ liệu
            return danhMucList;
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

        public int MaSanPham
        {
            get
            {
                // Kiểm tra xem ô nhập mã sản phẩm có được kích hoạt hay không
                if (txtMaSanPham.Enabled)
                {
                    // Convert string to long
                    int result;
                    if (int.TryParse(txtMaSanPham.Text, out result))
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
                else
                {
                    // Trả về giá trị mặc định khi không cần nhập mã sản phẩm
                    return selectIdProduct;
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
        public string CbDanhMuc
        {
            get
            {
                if (cbDanhMuc.SelectedItem != null)
                {
                    return cbDanhMuc.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Tên danh mục không được để trống!", "Warning");
                    return null; // Return null if no item is selected
                }
            }
            set { cbDanhMuc.SelectedItem = value; }
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
        public void SetProductBindingSource(BindingSource productList)
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


        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadDanhMuc();
        }

        private void tabPageProductDetail_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Chắc chắn rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                // Lấy giá trị của trường mã sản phẩm từ hàng được chọn và gán vào txtMaSanPham
                txtMaSanPham.Text = row.Cells[0].Value.ToString();
                selectIdProduct = int.Parse(row.Cells[0].Value.ToString());

                txtTenSanPham.Text = row.Cells[1].Value?.ToString();
                cbDanhMuc.SelectedItem = row.Cells[2].Value?.ToString();
                txtGiaTien.Text = row.Cells[3].Value?.ToString();
                txtMoTa.Text = row.Cells[4].Value?.ToString();
            }
        }

        private void txtMaSanPham_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
