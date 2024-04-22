using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using He_Thong_quan_ly_di_dong_dien_thoai.Model;
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
                        spModel.TenDanhMuc1 = reader[2].ToString();
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
                cmd.CommandText = @"SELECT sp.MaSanPham, sp.TenSanPham, sp.Gia, sp.MoTa, dm.TenDanhMuc 
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
                        spModel.MaSanPham1 = (int)reader[0];
                        spModel.TenSanPham1 = reader[1].ToString();
                        // Cột thứ 3 là Gia
                        spModel.Gia1 = (decimal)reader[2];
                        // Cột thứ 4 là MoTa
                        spModel.MoTa1 = reader[3].ToString();
                        // Cột thứ 5 là TenDanhMuc
                        spModel.TenDanhMuc1 = reader[4].ToString();
                        spList.Add(spModel);
                    }
                }
            }
            return spList;
        }

        // không cần nhập mã danh mục
        public void ThemThongTin(SPModel spModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                cmd.CommandText = @"INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa) VALUES (@TenSanPham1, (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = @TenDanhMuc1), @Gia1, @MoTa1)";

                cmd.Parameters.AddWithValue("@TenSanPham1", spModel.TenSanPham1);
                cmd.Parameters.AddWithValue("@TenDanhMuc1", spModel.TenDanhMuc1);
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


        // khong can update ma san pham va ma danh muc
        public void SuaThongTin(SPModel spModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "UPDATE SanPham " +
                                  "SET TenSanPham = @TenSanPham1, " +
                                  "    Gia = @Gia1, " +
                                  "    MoTa = @MoTa1 " +
                                  "WHERE MaSanPham = @MaSanPham1";

                cmd.Parameters.AddWithValue("@TenSanPham1", spModel.TenSanPham1);
                cmd.Parameters.AddWithValue("@Gia1", spModel.Gia1);
                cmd.Parameters.AddWithValue("@MoTa1", spModel.MoTa1);
                cmd.Parameters.AddWithValue("@MaSanPham1", spModel.MaSanPham1);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
