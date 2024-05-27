using He_Thong_quan_ly_di_dong_dien_thoai.Model;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace He_Thong_quan_ly_di_dong_dien_thoai.View
{
    public partial class orderView : Form, iOrderView
    {
        private string _message;
        private bool _isSuccessful;
        private iOrderView _view;
        private bool _isEdit;
        private int selectedOrderID;
        private SqlConnection conn = new SqlConnection(SQLConnections.KetnoiSQL());
        private string connectionString;

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
            this.Load += new System.EventHandler(this.orderView_Load);
            if (!cbStatus.Items.Contains("Trạng Thái"))
            {
                cbStatus.Items.Add("Trạng Thái");
            }
            cbStatus.SelectedItem = "Trạng Thái";
            paymentView = new paymentView();
            LoadOrderData();
            // Đăng ký sự kiện GoToPaymentClicked
            this.GoToPaymentClicked += PaymentViewForm_GoToPaymentClicked;

            // Đăng ký sự kiện Click cho nút goToPayment
            goToPayment.Click += new EventHandler(goToPayment_Click);
            InitializeConnectionString();

        }
        private void LoadOrderData()
        {
            InitializeConnectionString();
            string query = @"SELECT 
                                DH.MaDonHang,
                                SP.TenSanPham,
                                CTDH.Gia,
                                CTDH.SoLuong,
                                CTDH.TongTien,
                                DH.NgayDat,
                                KH.HoTen AS TenKhachHang,
                                KH.DienThoai AS SoDienThoai,
                                KH.DiaChi,
                                DH.TrangThai
                            FROM 
                                DonHang DH
                            JOIN 
                                ChiTietDonHang CTDH ON DH.MaDonHang = CTDH.MaDonHang
                            JOIN 
                                SanPham SP ON CTDH.MaSanPham = SP.MaSanPham
                            JOIN 
                                KhachHang KH ON DH.MaKhachHang = KH.MaKhachHang
                            ORDER BY 
                                DH.MaDonHang DESC
                            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvDonHang.DataSource = dataTable;
            }
        }
        public orderView(Dashboard dashboard)
        {
            InitializeConnectionString();
            InitializeComponent();
            LienKetVaNangCaoLuotXem();
            LoadDanhMuc();
            tabControlOrder.TabPages.Remove(tabCreateOrder);
            _view = this;
            this.Load += new System.EventHandler(this.orderView_Load);
            if (!cbStatus.Items.Contains("Trạng Thái"))
            {
                cbStatus.Items.Add("Trạng Thái");
            }
            cbStatus.SelectedItem = "Trạng Thái";
            paymentView = new paymentView();
            LoadOrderData();
            // Đăng ký sự kiện GoToPaymentClicked
            this.GoToPaymentClicked += PaymentViewForm_GoToPaymentClicked;

            // Đăng ký sự kiện Click cho nút goToPayment
            goToPayment.Click += new EventHandler(goToPayment_Click);
            this.dashboard = dashboard;
        }

        private paymentView paymentView;


        private bool show = true;
        private void PaymentViewForm_GoToPaymentClicked(object sender, EventArgs e)
        {
            paymentView.UpdateTabNotification(show);
        }

        private void orderView_Load(object sender, EventArgs e)
        {
            // Thêm các giá trị vào combobox cbStatus
            if (!cbStatus.Items.Contains("Trạng Thái"))
            {
                cbStatus.Items.Add("Trạng Thái");
            }
            if (!cbStatus.Items.Contains("Chưa thanh toán"))
            {
                cbStatus.Items.Add("Chưa thanh toán");
            }
            if (!cbStatus.Items.Contains("Đã thanh toán"))
            {
                cbStatus.Items.Add("Đã thanh toán");
            }
            if (!cbStatus.Items.Contains("Chờ xác nhận"))
            {
                cbStatus.Items.Add("Chờ xác nhận");
            }
            // Đặt giá trị mặc định là "Trạng Thái"
            cbStatus.SelectedItem = "Trạng Thái";

            // Gắn sự kiện SelectedIndexChanged
            cbStatus.SelectedIndexChanged += new EventHandler(guna2ComboBox1_SelectedIndexChanged);
        }

        //private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    string selectedStatus = cbStatus.SelectedItem.ToString();
        //    LoadOrdersByStatus(selectedStatus);
        //}
        
        private void LoadOrdersByStatus(string selectedStatus)
        {
            InitializeConnectionString();
            List<OrderModel> orders = new List<OrderModel>();

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open(); // Mở kết nối

                // Câu lệnh SQL để lấy các bản ghi với trạng thái tương ứng
                string query = @"SELECT 
                                    DH.MaDonHang,
                                    SP.TenSanPham,
                                    CTDH.Gia,
                                    CTDH.SoLuong,
                                    CTDH.TongTien,
                                    DH.NgayDat,
                                    KH.HoTen AS TenKhachHang,
                                    KH.DienThoai AS SoDienThoai,
                                    KH.DiaChi,
                                    DH.TrangThai,
                                    KH.MaKhachHang,
                                    SP.MaSanPham,
                                    DM.MaDanhMuc,
                                    DM.TenDanhMuc,
                                    SP.MoTa
                                FROM 
                                    DonHang DH
                                JOIN 
                                    ChiTietDonHang CTDH ON DH.MaDonHang = CTDH.MaDonHang
                                JOIN 
                                    SanPham SP ON CTDH.MaSanPham = SP.MaSanPham
                                JOIN 
                                    KhachHang KH ON DH.MaKhachHang = KH.MaKhachHang
                                JOIN 
                                    DanhMucSanPham DM ON SP.MaDanhMuc = DM.MaDanhMuc
                                WHERE TrangThai = @Status
                                ORDER BY 
                                    DH.MaDonHang";

                // Tạo đối tượng SqlCommand
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Thêm tham số cho câu lệnh SQL
                    cmd.Parameters.AddWithValue("@Status", selectedStatus);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderModel order = new OrderModel();

                            order.IdOrder = reader.GetInt32(reader.GetOrdinal("MaDonHang"));
                            order.NameOrder = reader.GetString(reader.GetOrdinal("TenSanPham"));
                            order.PriceOrder = reader.GetDecimal(reader.GetOrdinal("Gia"));
                            order.AmountOrder = reader.GetInt32(reader.GetOrdinal("SoLuong"));
                            order.TongTien = reader.GetDecimal(reader.GetOrdinal("TongTien"));
                            // Kiểm tra kiểu dữ liệu của cột NgayDat
                            order.OrderDate = reader.GetDateTime(reader.GetOrdinal("NgayDat"));
                            order.NameCustomer = reader.GetString(reader.GetOrdinal("TenKhachHang"));
                            order.PhonenumberOrder = reader.GetString(reader.GetOrdinal("SoDienThoai"));
                            order.AddressOrder = reader.GetString(reader.GetOrdinal("DiaChi"));
                            order.Status = reader.GetString(reader.GetOrdinal("TrangThai"));
                            orders.Add(order);
                        }
                    }
                }
            }

            dgvDonHang.DataSource = orders;
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
            InitializeConnectionString();
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
            InitializeConnectionString();
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
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];
                txtOrderID.Text = row.Cells[0].Value?.ToString();
                cbNameProduct.Text = row.Cells[1].Value?.ToString();
                txtPrice.Text = row.Cells[2].Value?.ToString();
                if (decimal.TryParse(row.Cells[3].Value?.ToString(), out decimal amount))
                {
                    nudAmount.Value = amount;
                }
                else
                {
                    nudAmount.Value = 0; 
                }
                sumPrice.Text = row.Cells[4].Value?.ToString();

                if (DateTime.TryParse(row.Cells[5].Value?.ToString(), out DateTime ngayMua))
                {
                    dtpNgayMua.Value = ngayMua;
                }
                else
                {
                    dtpNgayMua.Value = DateTime.Now; // Giá trị mặc định nếu không thể chuyển đổi
                }

                txtNameCustomer.Text = row.Cells[6].Value?.ToString();
                txtPhoneNumber.Text = row.Cells[7].Value?.ToString();
                txtAddress.Text = row.Cells[8].Value?.ToString();
                txtStatus.Text = row.Cells[9].Value?.ToString();

                if (int.TryParse(row.Cells[0].Value?.ToString(), out int orderID))
                {
                    selectedOrderID = orderID;
                }
                else
                {
                    selectedOrderID = 0;
                }
            }

        }


        private void dgvDonHang_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedStatus = cbStatus.SelectedItem.ToString();
            LoadOrdersByStatus(selectedStatus);
        }

        private void showDetailOrder_Click(object sender, EventArgs e)
        {
            InitializeConnectionString();
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                // Lấy các thông tin cơ bản từ DataGridView
                DataGridViewRow selectedRow = dgvDonHang.SelectedRows[0];
                int orderId = Convert.ToInt32(selectedRow.Cells[0].Value);
                string productName = selectedRow.Cells[1].Value.ToString();
                decimal price = Convert.ToDecimal(selectedRow.Cells[2].Value);
                int amount = Convert.ToInt32(selectedRow.Cells[3].Value);
                decimal totalPrice = Convert.ToDecimal(selectedRow.Cells[4].Value);
                DateTime orderDate = Convert.ToDateTime(selectedRow.Cells[5].Value);
                string customerName = selectedRow.Cells[6].Value.ToString();
                string phoneNumber = selectedRow.Cells[7].Value.ToString();
                string address = selectedRow.Cells[8].Value.ToString();
                string status = selectedRow.Cells[9].Value.ToString();

                // Thực hiện câu lệnh truy vấn để lấy các thông tin bổ sung từ cơ sở dữ liệu
                // Ví dụ:
                string query = "SELECT MaKhachHang, SP.MaSanPham, DM.MaDanhMuc, DM.TenDanhMuc, SP.MoTa FROM DonHang DH JOIN ChiTietDonHang CTDH ON DH.MaDonHang = CTDH.MaDonHang JOIN SanPham SP ON CTDH.MaSanPham = SP.MaSanPham JOIN DanhMucSanPham DM ON SP.MaDanhMuc = DM.MaDanhMuc WHERE DH.MaDonHang = @OrderID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", orderId);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            int customerID = Convert.ToInt32(reader["MaKhachHang"]);
                            int productID = Convert.ToInt32(reader["MaSanPham"]);
                            int categoryID = Convert.ToInt32(reader["MaDanhMuc"]);
                            string categoryName = reader["TenDanhMuc"].ToString();
                            string description = reader["MoTa"].ToString();
                            string imagePath = productImageMap.ContainsKey(productName) ? productImageMap[productName] : null;
                            showDetailOrder sdo = new showDetailOrder(orderId, productName, price, amount, totalPrice, orderDate, customerName, phoneNumber, address, status, customerID, productID, categoryID, categoryName, description, imagePath);
                            sdo.Show();
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin chi tiết cho đơn hàng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một đơn hàng để xem chi tiết.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }


        public event EventHandler GoToPaymentRequested;
        public event EventHandler GoToPaymentClicked;
        private Dashboard dashboard;

        // Một phương thức để lấy dữ liệu từ dgvDonHang
        public (int maDonHang, string tenKhachHang, decimal tongTien, int soLuong, string ngayMua) GetDataFromDataGridView()
        {
            DataGridViewRow selectedRow = dgvDonHang.SelectedRows[0];
            int maDonHang = Convert.ToInt32(selectedRow.Cells[0].Value);
            string tenKhachHang = selectedRow.Cells[6].Value?.ToString();
            decimal tongTien = Convert.ToDecimal(selectedRow.Cells[4].Value);
            int soLuong = Convert.ToInt32(selectedRow.Cells[3].Value);
            string ngayMua = selectedRow.Cells[5].Value?.ToString();
            return (maDonHang, tenKhachHang, tongTien, soLuong, ngayMua);
        }

        private void goToPayment_Click(object sender, EventArgs e)
        {
            if (ParentForm is Dashboard dashboard_t)
            {
                dashboard_t.OrderViewForm_GoToPaymentRequested(sender, e);
            }
            GoToPaymentClicked?.Invoke(this, EventArgs.Empty);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadOrderData();
        }

        private void btnRemoveOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
