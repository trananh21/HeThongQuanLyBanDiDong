using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class orderView : Form, iOrderView
    {
        private string _message;
        private bool _isSuccessful;
        private iOrderView _view;
        private bool _isEdit;
        private int selectedOrderID;
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public event EventHandler SearchOrderEvent;
        public event EventHandler CreateOrder;
        public event EventHandler EditOrderEvent;
        public event EventHandler DeleteOrderEvent;
        public event EventHandler SaveOrderEvent;
        public event EventHandler CancelOrderEvent;

        public int OrderIDView
        {
            get
            {
                // Kiểm tra xem ô nhập mã sản phẩm có được kích hoạt hay không
                if (txtOrderID.Enabled)
                {
                    // Convert string to long
                    int result;
                    if (int.TryParse(txtOrderID.Text, out result))
                    {
                        return result;
                    }
                    else
                    {
                        // Handle parsing error, maybe show an error message to the user
                        MessageBox.Show("ID Order không hợp lệ. Vui lòng nhập lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 0; // Return a default value or throw an exception
                    }
                }
                else
                {
                    // Trả về giá trị mặc định khi không cần nhập mã sản phẩm
                    return selectedOrderID;
                }
            }
            set
            {
                // Convert long to string
                txtOrderID.Text = value.ToString();
            }
        }
        public string NameProductView
        {
            get
            {
                if (cbNameProduct.SelectedItem != null)
                {
                    return cbNameProduct.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Warning");
                    return null; // Return null if no item is selected
                }
            }
            set { cbNameProduct.SelectedItem = value; }
        }
        public decimal PriceView
        {
            get { return decimal.Parse(txtPrice.Text); }
            set { txtPrice.Text = value.ToString(); }
        }

        public int AmountView
        {
            get => (int)nudAmount.Value;
            set => nudAmount.Value = value;
        }

        // tổng tiền
        public decimal SumPriceView { get => decimal.Parse(sumPrice.Text); set => sumPrice.Text = value.ToString(); }


        public DateTime DateView
        {
            get => dtpNgayMua.Value;
            set => dtpNgayMua.Value = value;
        }

        public string NameCustomerView
        {
            get => txtNameCustomer.Text; set => txtNameCustomer.Text = value;
        }
        public string PhoneNumberView
        {
            get => txtPhoneNumber.Text; set => txtPhoneNumber.Text = value;
        }
        public string AddressView
        {
            get => txtAddress.Text; set => txtAddress.Text = value;
        }
        public string StatusView
        {
            get => txtStatus.Text; set => txtStatus.Text = value;
        }
        public string TimKiem { get => txtSearchOrder.Text; set => txtSearchOrder.Text = value; }
        public bool isEdit { get => _isEdit; set => _isEdit = value; }
        public bool isSuccessful { get => _isSuccessful; set => _isSuccessful = value; }
        public string Message { get => _message; set => _message = value; }

        public orderView()
        {
            InitializeComponent();
            LienKetVaNangCaoLuotXem();
            LoadDanhMuc();
            tabControlOrder.TabPages.Remove(tabCreateOrder);
            _view = this;
        }

        private void LoadDanhMuc()
        {
            // Lấy danh sách danh mục từ cơ sở dữ liệu
            List<string> productList = GetDanhMucListFromDatabase(); // Viết phương thức này để lấy danh sách danh mục từ cơ sở dữ liệu

            // Đổ danh sách danh mục vào combo box
            foreach (string itemProduct in productList)
            {
                cbNameProduct.Items.Add(itemProduct);
            }
        }
        private List<string> GetDanhMucListFromDatabase()
        {
            List<string> productList = new List<string>();
            // Khởi tạo kết nối tới cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Mở kết nối
                conn.Open();

                // Khởi tạo câu lệnh SQL để lấy danh sách danh mục
                string query = "SELECT TenSanPham FROM SanPham";

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
                            string NameProduct = reader["TenSanPham"].ToString();

                            // Thêm vào danh sách danh mục
                            productList.Add(NameProduct);
                        }
                    }
                }
            }

            // Trả về danh sách danh mục đã lấy được từ cơ sở dữ liệu
            return productList;
        }

        private void LienKetVaNangCaoLuotXem()
        {
            //Search product
            btnSearchOrder.Click += delegate { SearchOrderEvent?.Invoke(this, EventArgs.Empty); };
            txtSearchOrder.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchOrderEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnCreateOrder.Click += delegate
            {
                CreateOrder?.Invoke(this, EventArgs.Empty);
                tabControlOrder.TabPages.Remove(tabOrderList);
                tabControlOrder.TabPages.Add(tabCreateOrder);
                tabCreateOrder.Text = "Tạo lập đơn hàng";
            };

            // Edit product
            btnEditOrder.Click += delegate
            {
                EditOrderEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrder.TabPages.Remove(tabOrderList);
                tabControlOrder.TabPages.Add(tabCreateOrder);
                tabControlOrder.SelectedTab = tabCreateOrder; // Chọn tabPageProductDetail để hiển thị
                tabCreateOrder.Text = "Sửa thông tin đơn hàng";
            };
            // Save changes product
            btnSaveOrder.Click += delegate
            {
                SaveOrderEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControlOrder.TabPages.Remove(tabCreateOrder);
                    tabControlOrder.TabPages.Add(tabOrderList);
                    tabControlOrder.SelectedTab = tabOrderList; // Chọn tabPageProductList để hiển thị
                }
                MessageBox.Show(Message);
            };

            // Cancel product
            btnCanceOrder.Click += delegate
            {
                CancelOrderEvent?.Invoke(this, EventArgs.Empty);
                tabControlOrder.TabPages.Remove(tabCreateOrder);
                tabControlOrder.TabPages.Add(tabOrderList);
                tabControlOrder.SelectedTab = tabOrderList; // Chọn tabPageProductList để hiển thị
            };

            // Delete product
            btnRemoveOrder.Click += delegate
            {
                var result = MessageBox.Show("Bạn chắc chắn muốn xoá đơn hàng này chứ ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteOrderEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        private void tabCreateOrder_Click(object sender, EventArgs e)
        {

        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabOrderList_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        public void SetOrderBindingSource(BindingSource orderList)
        {
            dgvDonHang.DataSource = orderList;
        }

        private static productView instance;
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

        private void cbNameProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductName = cbNameProduct.SelectedItem.ToString();
            // Gọi phương thức để lấy giá tiền tương ứng từ cơ sở dữ liệu
            decimal price = GetPriceForProduct(selectedProductName);
            // Gán giá tiền vào TextBox txtPrice
            txtPrice.Text = price.ToString();
            // Tính tổng giá tiền khi số lượng thay đổi
            CalculateTotalPrice();
                
            // Xác định hình ảnh tương ứng với tên sản phẩm được chọn từ ComboBox
            string selectedImageProduct = cbNameProduct.SelectedItem.ToString(); // giả sử tên sản phẩm là iPhone 15 Pro
            // => selectedImageProduct = iPhone 15 Pro
            string imagePath = GetImagePathForProduct(selectedImageProduct); // trả về đường dẫn hình ảnh từ tên sản phẩm
            // truyền vào hàm GetImagePathForProduct(iPhone 15 Pro)
            // Cập nhật hình ảnh trong PictureBox
            if (!string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    pbImage.Image = System.Drawing.Image.FromFile(imagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Xử lý khi không tìm thấy hình ảnh tương ứng
                MessageBox.Show("Không tìm thấy hình ảnh cho sản phẩm này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private Dictionary<string, string> productImageMap = new Dictionary<string, string>
        {
            {"OPPO Reno11 F 5G", @"images\OPPOReno11F5G.png"},
            {"Xiaomi Redmi Note 13", @"images\XiaomiRedmiNote13.png"},
            {"Samsung Galaxy A55 5G", @"images\SamsungGalaxyA555G.png"},
            {"Xiaomi Redmi Note 13 Pro", @"images\XiaomiRedmiNote13Pro.png"},
            {"OPPO A58", @"images\OPPOA58.png"},
            {"Samsung Galaxy S23 FE 5G", @"images\SamsungGalaxyS23FE5G.png"},
            {"iPhone 15 Pro", @"images\iphone15promax.png"},
            {"HuaWei X9", @"images\HuaWeiX9.png"},
            {"OPPO Find N3 Flip 5G Hồng", @"images\OPPOFindN3Flip5GPink.png"},
            {"iPhone 15 Plus 512GB", @"images\iPhone15Plus512GB.png"},
            {"Xiaomi Redmi Note 13 (8GB/128GB)", @"images\Xiaomi13-8GB-128GB.png"},
            {"Vivo Y36 128GB", @"images\VivoY36-128GB.png"},
            {"Samsung Galaxy S22 Ultra 5G 128GB", @"images\SamsungGalaxyS22Ultra5G128GB.png"},
            {"Samsung Galaxy Z Fold4 5G 256GB", @"images\SamsungGalaxyZFold45G256GB.png"},
            {"iPhone 13 Pro Max", @"images\iphone13promax.png"},
            {"ASUS ROG Phone 6", @"images\ASUSROGPhone6.png"},
            {"Samsung Galaxy A54", @"images\test.png"},
            {"iPhone 14 Pro Max", @"images\testIphone14.png"},
            {"Xiaomi POCO X6", @"images\XiaomiPOCOX6.png"},
            {"Samsung Galaxy S24 Ultra 12GB 256GB", @"images\Samsung-Galax-S24-Ultra-12GB-256GB.png"},

        };

        private string GetImagePathForProduct(string selectedImageProduct)
        {
            string imagePath = ""; // Đường dẫn hình ảnh mặc định

            // Kiểm tra xem danh sách hình ảnh sản phẩm có chứa tên sản phẩm được chọn hay không
            if (productImageMap.ContainsKey(selectedImageProduct))
            {
                // Lấy đường dẫn tương đối của thư mục ứng dụng
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                // Lấy đường dẫn tương đối của hình ảnh từ danh sách hình ảnh sản phẩm
                string relativeImagePath = productImageMap[selectedImageProduct];
                // Kết hợp đường dẫn tương đối của thư mục ứng dụng với đường dẫn tương đối của hình ảnh
                imagePath = Path.Combine(appDirectory, relativeImagePath);
            }

            return imagePath;
        }

        private decimal GetPriceForProduct(string selectedProductName)
        {
            decimal price = 0; // Giá tiền mặc định

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối

                // Câu lệnh SQL để lấy giá tiền cho sản phẩm được chọn
                string query = "SELECT Gia FROM SanPham WHERE TenSanPham = @ProductName";

                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@ProductName", selectedProductName);

                    // Thực thi câu lệnh SQL và đọc kết quả
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc giá tiền từ kết quả truy vấn
                            price = (decimal)reader.GetDecimal(0); // Giả sử giá tiền lấy từ cột đầu tiên

                        }
                    }
                }
            }

            return price; // Trả về giá tiền tương ứng
        }


        // thôi đổi giá trị của số lượng đồng thời giá tiền cũng sẽ thay đổi
        private void nudAmount_ValueChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            decimal price;
            if (decimal.TryParse(txtPrice.Text, out price))
            {
                price = decimal.Parse(txtPrice.Text);
            }
            else
            {
                // Xử lý khi không thể chuyển đổi giá tiền sang kiểu số
                MessageBox.Show("Giá không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int amount = (int)nudAmount.Value;
            decimal totalPrice = price * amount;
            string formattedPrice = totalPrice.ToString("#,##0") + " VNĐ";
            sumPrice.Text = formattedPrice;
            if (totalPrice < 0)
            {
                MessageBox.Show("Tổng tiền không được nhỏ hơn hoặc bằng 0", "Error", MessageBoxButtons.OK);
            }
            else
            {

                if (_view != null)
                {
                    _view.SumPriceView = totalPrice;
                }
                else
                {
                    MessageBox.Show("_view không được khởi tạo!");
                }
            }
        }

        private void dtpNgayMua_ValueChanged(object sender, EventArgs e)
        {

        }


        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) // Chắc chắn rằng người dùng đã chọn một hàng hợp lệ
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];

                // Lấy giá trị của trường mã sản phẩm từ hàng được chọn và gán vào txtMaSanPham
                txtOrderID.Text = row.Cells[0].Value.ToString();
                selectedOrderID = int.Parse(row.Cells[0].Value.ToString());
            }
        }
        

        private void dgvDonHang_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
