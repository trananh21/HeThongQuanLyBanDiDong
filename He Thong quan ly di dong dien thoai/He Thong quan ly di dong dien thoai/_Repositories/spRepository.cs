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
        public SpRepository(string connectionString) { 
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
                cmd.CommandText = "SELECT sp.MaSanPham, sp.TenSanPham, dm.TenDanhMuc, dm.MaDanhMuc, sp.Gia, sp.MoTa FROM SanPham sp INNER JOIN DanhMucSanPham dm ON sp.MaDanhMuc = dm.MaDanhMuc;";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spModel = new SPModel();
                        spModel.MaSanPham1 = (int)reader[0];
                        spModel.TenSanPham1 = reader[1].ToString();
                        spModel.TenDanhMuc1 = reader[2].ToString();
                        spModel.MaDanhMuc1 = (int)reader[3];
                        spModel.Gia1 = (decimal)reader[4];
                        spModel.MoTa1 = reader[5].ToString();
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
                cmd.CommandText = @"SELECT * FROM SanPham WHERE MaSanPham = @MaSanPham1 OR TenSanPham LIKE @TenSanPham1+'%' ORDER BY MaSanPham ASC";
                cmd.Parameters.Add(@"MaSanPham1", SqlDbType.Int).Value = spMaSanPham;
                cmd.Parameters.Add(@"TenSanPham1", SqlDbType.NVarChar).Value = spTenSanPham;
                //cmd.Parameters.Add(@"MaDanhMuc", SqlDbType.Int).Value = spMaDanhMuc1;
                //cmd.Parameters.Add(@"Gia", SqlDbType.Int).Value = spGia1;
                //cmd.Parameters.Add(@"MoTa", SqlDbType.Int).Value = spMoTa1;
                using (var reader = cmd.ExecuteReader()) // đọc dữ liệu 
                {
                    while (reader.Read())
                    {
                        var spModel = new SPModel();
                        spModel.MaSanPham1 = (int)reader[0];
                        spModel.TenSanPham1 = reader[1].ToString();
                        spModel.MaDanhMuc1 = (int)reader[2];
                        spModel.Gia1 = (decimal)reader[3]; 
                        spModel.MoTa1 = reader[4].ToString();
                        spList.Add(spModel);
                    }
                }
            }
            return spList;
        }

        public void SuaThongTin(SPModel spModel)
        {
            throw new NotImplementedException();
        }

        public void ThemThongTin(SPModel model)
        {
            throw new NotImplementedException();
        }

        public void XoaThongTin(int id)
        {
            throw new NotImplementedException();
        }
    }
}
