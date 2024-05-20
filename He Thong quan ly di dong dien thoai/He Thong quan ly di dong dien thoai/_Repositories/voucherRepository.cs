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
    public class voucherRepository : BaseRepository, iVoucherReponsitory
    {

        //Constructor
        public voucherRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IEnumerable<VoucherModel> GetAllVoucher()
        {
            var vouList = new List<VoucherModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM KhuyenMai ORDER BY MaKhuyenMai DESC";
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var vouModel = new VoucherModel();
                        vouModel.VoucherName = reader[0].ToString();
                        vouModel.VoucherDescription = reader[1].ToString();
                        vouModel.VoucherDateStart = DateTime.Parse(reader[2].ToString());
                        vouModel.VoucherDateEnd = DateTime.Parse(reader[3].ToString());
                        vouModel.VoucherID = reader[4].ToString();
                        vouList.Add(vouModel);
                    }
                }
            }
            return vouList;
        }

        public IEnumerable<VoucherModel> GetByValueVoucher(string value)
        {
            var vouList = new List<VoucherModel>();
            string voucherid = value;
            string vouchername = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"SELECT * FROM KhuyenMai WHERE MaKhuyenMai = @idVoucher + '%' OR TenKhuyenMai LIKE @nameVoucher + '%' ORDER BY MaKhuyenMai DESC";
                cmd.Parameters.Add("@idVoucher", SqlDbType.NVarChar).Value = voucherid;
                cmd.Parameters.Add("@nameVoucher", SqlDbType.NVarChar).Value = vouchername;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var voucherModel = new VoucherModel();
                        voucherModel.VoucherName = reader[0].ToString(); 
                        voucherModel.VoucherDescription = reader[1].ToString(); 
                        voucherModel.VoucherDateStart = DateTime.Parse(reader[2].ToString());
                        voucherModel.VoucherDateEnd = DateTime.Parse(reader[3].ToString());
                        voucherModel.VoucherID = reader[4].ToString();
                        vouList.Add(voucherModel); 
                    }
                }
            }
            return vouList; // Trả về danh sách SPModel
        }

        public void ChangeVoucher(VoucherModel vModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = @"UPDATE KhuyenMai 
                                        SET TenKhuyenMai = @nameVoucher,
                                            MoTa = @descVoucher,
                                            NgayBatDau = @dateStart,
                                            NgayKetThuc = @dateEnd
                                        WHERE MaKhuyenMai = @idVoucher
                                      ";
                    cmd.Parameters.AddWithValue("@nameVoucher", vModel.VoucherName);
                    cmd.Parameters.AddWithValue("@descVoucher", vModel.VoucherDescription);
                    cmd.Parameters.AddWithValue("@dateStart", vModel.VoucherDateStart);
                    cmd.Parameters.AddWithValue("@dateEnd", vModel.VoucherDateEnd);
                    cmd.Parameters.AddWithValue("@idVoucher", vModel.VoucherID);

                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteReader(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fix lỗi change voucher: " + ex.Message);
                }
            }
        }

        public void CreateVoucherNew(VoucherModel model)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;

                // Thêm truy vấn để lấy mã danh mục dựa trên tên danh mục được chọn từ combo box
                cmd.CommandText = @"DECLARE @idVoucher NVARCHAR(50);
                                    SET @idVoucher = (
                                        SELECT SUBSTRING(
                                            REPLACE(NEWID(), '-', ''),
                                            ABS(CHECKSUM(NEWID())) % 15 + 1, 
                                            8
                                        )
                                    );
                                    INSERT INTO KhuyenMai(MaKhuyenMai, TenKhuyenMai, MoTa, NgayBatDau, NgayKetThuc)
                                    VALUES(@idVoucher, @nameVoucher, @descVoucher, @dateStart, @dateEnd); 
                                    ";

                // Sử dụng parameters để tránh các vấn đề liên quan đến SQL injection
                cmd.Parameters.AddWithValue("@nameVoucher", model.VoucherName);
                cmd.Parameters.AddWithValue("@descVoucher", model.VoucherDescription); // Sửa thành mã danh mục
                cmd.Parameters.AddWithValue("@dateStart", model.VoucherDateStart);
                cmd.Parameters.AddWithValue("@dateEnd", model.VoucherDateEnd);

                cmd.ExecuteNonQuery();
            }
        }


        public void RemoveVoucher(string id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = new SqlCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM KhuyenMai WHERE MaKhuyenMai = @idVoucher";
                cmd.Parameters.Add("@idVoucher", SqlDbType.NVarChar).Value = id;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
