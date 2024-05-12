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
    public class orderRepository : BaseRepository, iOrderRepository
    {
        //Constructor
        public orderRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<OrderModel> GetAllOrder()
        {
            var orderList = new List<OrderModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT 
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
                                DH.MaDonHang;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderModel = new OrderModel();
                        orderModel.IdOrder = (int)reader[0]; // mã 
                        orderModel.NameOrder = (string)reader[1]; // tên sp

                        // Kiểm tra nếu giá trị không phải là NULL trước khi chuyển đổi kiểu dữ liệu
                        if (!reader.IsDBNull(2))
                            orderModel.PriceOrder = (decimal)reader[2]; // giá

                        // Kiểm tra nếu giá trị không phải là NULL trước khi chuyển đổi kiểu dữ liệu
                        if (!reader.IsDBNull(3))
                            orderModel.AmountOrder = (int)reader[3]; // số lượng

                        // Kiểm tra nếu giá trị không phải là NULL trước khi chuyển đổi kiểu dữ liệu
                        if (!reader.IsDBNull(4))
                            orderModel.TongTien = (decimal)reader[4]; // tổng tiền

                        orderModel.OrderDate = (DateTime)reader[5]; // ngày mua
                        orderModel.NameCustomer = (string)reader[6]; // tên kh
                        orderModel.PhonenumberOrder = (string)reader[7]; // số điện thoại
                        orderModel.AddressOrder = (string)reader[8]; // địa chỉ
                        orderModel.Status = (string)reader[9]; // trạng thái

                        orderList.Add(orderModel);
                    }
                }
            }
            return orderList;
        }

        public IEnumerable<OrderModel> GetByValueOrder(string value)
        {
            var orderList = new List<OrderModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT 
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
                            WHERE 
                                DH.MaDonHang LIKE @value OR KH.HoTen LIKE @value
                            ORDER BY 
                                DH.MaDonHang;";
                cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var orderModel = new OrderModel();
                        orderModel.IdOrder = (int)reader[0]; // mã 
                        orderModel.NameOrder = (string)reader[1]; // tên sản phẩm
                        orderModel.PriceOrder = (decimal)reader[2]; // giá 
                        orderModel.AmountOrder = (int)reader[3]; // số lượng
                        orderModel.TongTien = (decimal)reader[4]; // tổng tiền
                        orderModel.OrderDate = (DateTime)reader[5]; // ngày mua
                        orderModel.NameCustomer = (string)reader[6]; // tên khách hàng
                        orderModel.PhonenumberOrder = (string)reader[7]; // số điện thoại
                        orderModel.AddressOrder = (string)reader[8]; // địa chỉ
                        orderModel.Status = (string)reader[9]; // trạng thái
                        orderList.Add(orderModel);
                    }
                }
            }
            return orderList;
        }


        public void AddOrder(OrderModel model)
        {
            if (string.IsNullOrEmpty(model.NameOrder))
            {
                // Hiển thị thông báo lỗi nếu tên danh mục rỗng hoặc null
                throw new ArgumentException("Tên sản phẩm không được để trống.");
            }

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                // Thêm truy vấn để lấy mã danh mục dựa trên tên danh mục được chọn từ combo box
                cmd.CommandText = @"BEGIN TRANSACTION;
                                    INSERT INTO KhachHang(HoTen, DienThoai, DiaChi)
                                    VALUES(@nameCustomer, @phoneCustomer, @addressCustomer);
                                    DECLARE @customerId INT;
                                    SET @customerId = SCOPE_IDENTITY();
                                    INSERT INTO DonHang(MaKhachHang, NgayDat, TrangThai)
                                    VALUES(@customerId, @dateset, @status);

                                    DECLARE @orderId INT;
                                    SET @orderId = SCOPE_IDENTITY();
                                    INSERT INTO ChiTietDonHang(MaDonHang, MaSanPham, SoLuong, Gia, TongTien)
                                    VALUES(@orderId, (SELECT DISTINCT MaSanPham FROM SanPham WHERE TenSanPham = @nameProduct), @amount, (SELECT Gia FROM SanPham WHERE TenSanPham = @nameProduct), @amount * (SELECT Gia FROM SanPham WHERE TenSanPham = @nameProduct));
                                    COMMIT TRANSACTION;";

                // Sử dụng parameters để tránh các vấn đề liên quan đến SQL injection
                cmd.Parameters.AddWithValue("@nameProduct", model.NameOrder);
                cmd.Parameters.AddWithValue("@price", model.PriceOrder); // Sửa thành mã danh mục
                cmd.Parameters.AddWithValue("@amount", model.AmountOrder);
                cmd.Parameters.AddWithValue("@sumPrice", model.TongTien);
                cmd.Parameters.AddWithValue("@dateset", model.OrderDate);
                cmd.Parameters.AddWithValue("@nameCustomer", model.NameCustomer);
                cmd.Parameters.AddWithValue("@phoneCustomer", model.PhonenumberOrder);
                cmd.Parameters.AddWithValue("@addressCustomer", model.AddressOrder);
                cmd.Parameters.AddWithValue("@status", model.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void EditOrder(OrderModel orderModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                                        UPDATE SanPham
                                        SET TenSanPham = @nameProduct,
                                            Gia = @price, 
                                            SoLuong = @amount,  
                                            TongTien = @sumPrice, 
                                            NgayDat = @dateset, 
                                            HoTen = @nameCustomer,
                                            DienThoai = @phoneCustomer
                                            DiaChi = @addressCustomer
                                            TrangThai = @status
                                        WHERE MaDonHang = @idOrder
                                      ";
                    cmd.Parameters.AddWithValue("@nameProduct", orderModel.NameOrder);
                    cmd.Parameters.AddWithValue("@price", orderModel.PriceOrder); // Sửa thành mã danh mục
                    cmd.Parameters.AddWithValue("@amount", orderModel.AmountOrder);
                    cmd.Parameters.AddWithValue("@sumPrice", orderModel.TongTien);
                    cmd.Parameters.AddWithValue("@dateset", orderModel.OrderDate);
                    cmd.Parameters.AddWithValue("@nameCustomer", orderModel.NameCustomer);
                    cmd.Parameters.AddWithValue("@phoneCustomer", orderModel.PhonenumberOrder);
                    cmd.Parameters.AddWithValue("@addressCustomer", orderModel.AddressOrder);
                    cmd.Parameters.AddWithValue("@status", orderModel.Status);
                    cmd.Parameters.AddWithValue("@idOrder", orderModel.IdOrder);

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


        public void RemoveOrder(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"DECLARE @MaDonHang INT;
                                    SET @MaDonHang = @idOrder;
                                    DELETE FROM ChiTietDonHang WHERE MaDonHang = @MaDonHang;
                                    DELETE FROM DonHang WHERE MaDonHang = @MaDonHang;";
                cmd.Parameters.Add("@idOrder", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
