using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
using System.Windows;
namespace He_Thong_quan_ly_di_dong_dien_thoai._Repositories
{
    public class SpRepository : BaseRepository, iSPRepository
    {
        //Constructor
        public SpRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<SPModel> GetAll()
        {
            var spList = new List<SPModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, sp.Gia, sp.MoTa FROM SanPham sp INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spModel = new SPModel();
                        spModel.MaSanPham1 = (int)reader[0];
                        spModel.TenSanPham1 = reader[1].ToString();
                        spModel.cbDanhMuc = reader[2].ToString();
                        spModel.Gia1 = (decimal)reader[3];
                        spModel.MoTa1 = reader[4].ToString();
                        spList.Add(spModel);
                    }
                }
            }
            return spList;
        }


        public IEnumerable<SPModel> GetByValue(string value)
        {
            var spList = new List<SPModel>();
            var spMaSanPham = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string spTenSanPham = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, sp.Gia, sp.MoTa 
                            FROM SanPham sp
                            INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc
                            WHERE sp.MaSanPham = @MaSanPham1 OR sp.TenSanPham LIKE @TenSanPham1 + '%'
                            ORDER BY sp.MaSanPham ASC";
                cmd.Parameters.Add("@MaSanPham1", SqlDbType.Int).Value = spMaSanPham;
                cmd.Parameters.Add("@TenSanPham1", SqlDbType.NVarChar).Value = spTenSanPham;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spModel = new SPModel();
                        spModel.MaSanPham1 = (int)reader[0]; // Mã sản phẩm
                        spModel.TenSanPham1 = reader[1].ToString(); // Tên sản phẩm
                        spModel.cbDanhMuc = reader[2].ToString(); // Tên danh mục
                        spModel.Gia1 = (decimal)reader[3]; // Giá
                        spModel.MoTa1 = reader[4].ToString(); // Mô tả
                        spList.Add(spModel); // Thêm đối tượng SPModel vào danh sách
                    }
                }
            }
            return spList; // Trả về danh sách SPModel
        }
        // Hàm để lấy danh sách các danh mục từ cơ sở dữ liệu
        public IEnumerable<string> GetCategories()
        {
            var categories = new List<string>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT TenDanhMuc FROM DanhMucSanPham;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string categoryName = reader["TenDanhMuc"].ToString();
                        categories.Add(categoryName);
                    }
                }
            }
            return categories;
        }
        // không cần nhập mã danh mục
        public void ThemThongTin(SPModel spModel)
        {
            if (string.IsNullOrEmpty(spModel.cbDanhMuc))
            {
                // Hiển thị thông báo lỗi nếu tên danh mục rỗng hoặc null
                throw new ArgumentException("Tên danh mục không được để trống.");
            }

            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                // Thêm truy vấn để lấy mã danh mục dựa trên tên danh mục được chọn từ combo box
                cmd.CommandText = @"INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa) VALUES (@TenSanPham1, (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = @TenDanhMuc1), @Gia1, @MoTa1)";

                // Sử dụng parameters để tránh các vấn đề liên quan đến SQL injection
                cmd.Parameters.AddWithValue("@TenSanPham1", spModel.TenSanPham1);
                cmd.Parameters.AddWithValue("@TenDanhMuc1", spModel.cbDanhMuc); // Sửa thành mã danh mục
                cmd.Parameters.AddWithValue("@Gia1", spModel.Gia1);
                cmd.Parameters.AddWithValue("@MoTa1", spModel.MoTa1);

                cmd.ExecuteNonQuery();
            }
        }


        public void XoaThongTin(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM SanPham WHERE MaSanPham = @MaSanPham1";
                cmd.Parameters.Add("@MaSanPham1", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }


        // Không cần update Mã Sản Phẩm và Mã Danh Mục
        public void SuaThongTin(SPModel spModel)
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
                                        SET TenSanPham = @TenSanPham1,
                                            MaDanhMuc = (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = @TenDanhMuc1),
                                            Gia = @Gia1,
                                            MoTa = @MoTa1
                                        WHERE MaSanPham = @MaSanPham1
                                      ";
                    cmd.Parameters.AddWithValue("@TenSanPham1", spModel.TenSanPham1);
                    cmd.Parameters.AddWithValue("@TenDanhMuc1", spModel.CbDanhMuc);
                    cmd.Parameters.AddWithValue("@Gia1", spModel.Gia1);
                    cmd.Parameters.AddWithValue("@MoTa1", spModel.MoTa1);
                    cmd.Parameters.AddWithValue("@MaSanPham1", spModel.MaSanPham1);

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

    }
}
