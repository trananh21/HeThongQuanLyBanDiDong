using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace He_Thong_quan_ly_di_dong_dien_thoai._Repositories
{
    public class customerRepository : BaseRepository, iCustomerReponsitory
    {

        public customerRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public IEnumerable<CustomerModel> GetAllCustomer()
        {
            var customerList = new List<CustomerModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM KhachHang ORDER BY MaKhachHang DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.customerID = (int)reader[0];
                        customerModel.customerName = reader[1].ToString();
                        customerModel.customerEmail = reader[2].ToString();
                        customerModel.customerPhoneNumber = reader[3].ToString();
                        customerModel.customerAddress = reader[4].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        // tìm mã, tìm tên gần đúng
        public IEnumerable<CustomerModel> GetByValueCustomer(string value)
        {
            var customerList = new List<CustomerModel>();
            var cusID = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string cusName = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT * 
                            FROM KhachHang WHERE MaKhachHang = @id OR HoTen LIKE @name + '%'
                            ORDER BY MaKhachHang DESC";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = cusID;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cusName;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.customerID = (int)reader[0]; // Mã khách hàng
                        customerModel.customerName = reader[1].ToString(); // Tên khách hàng
                        customerModel.customerEmail = reader[2].ToString(); // Email khách hàng
                        customerModel.customerPhoneNumber = reader[3].ToString(); // SĐT
                        customerModel.customerAddress = reader[4].ToString(); // Địa chỉ
                        customerList.Add(customerModel); // Thêm đối tượng CustomerModel vào danh sách
                    }
                }
            }
            return customerList; // Trả về danh sách CustomerModel
        }
        public void AddCustomer(CustomerModel model)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                // Thêm truy vấn để lấy mã danh mục dựa trên tên danh mục được chọn từ combo box
                cmd.CommandText = @"INSERT INTO KhachHang (HoTen, Email, DienThoai, DiaChi) VALUES (@name,@email , @phonenumber, @address)";

                // Sử dụng parameters để tránh các vấn đề liên quan đến SQL injection
                cmd.Parameters.AddWithValue("@name", model.customerName);
                cmd.Parameters.AddWithValue("@email", model.customerEmail); // Sửa thành mã danh mục
                cmd.Parameters.AddWithValue("@phonenumber", model.customerPhoneNumber);
                cmd.Parameters.AddWithValue("@address", model.customerAddress);

                cmd.ExecuteNonQuery();
            }
        }

        public void EditCustomer(CustomerModel cusModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                                        UPDATE KhachHang
                                        SET HoTen = @name,
                                            Email = @email,
                                            DienThoai = @phonenumber,
                                            DiaChi = @address
                                        WHERE MaKhachHang = @idCustomer
                                      ";
                    cmd.Parameters.AddWithValue("@idCustomer", cusModel.customerID);
                    cmd.Parameters.AddWithValue("@name", cusModel.customerName);
                    cmd.Parameters.AddWithValue("@email", cusModel.CustomerEmail);
                    cmd.Parameters.AddWithValue("@phonenumber", cusModel.customerPhoneNumber);
                    cmd.Parameters.AddWithValue("@address", cusModel.customerAddress);

                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteReader(); 
                }
                catch (Exception ex)
                {
                    //throw new Exception(ex.Message);
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void RemoveCustomer(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"BEGIN TRANSACTION;
                                    DELETE FROM ChiTietDonHang WHERE MaDonHang IN (SELECT MaDonHang FROM DonHang WHERE MaKhachHang = @idCustomer);
                                    DELETE FROM DonHang WHERE MaKhachHang = @idCustomer;
                                    DELETE FROM KhachHang WHERE MaKhachHang = @idCustomer;
                                    COMMIT TRANSACTION;";
                cmd.Parameters.Add("@idCustomer", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
