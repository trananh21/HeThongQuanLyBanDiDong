CREATE DATABASE qlbdtdd
GO

USE qlbdtdd
GO


-- Bảng danh mục sản phẩm
CREATE TABLE DanhMucSanPham (
    MaDanhMuc INT PRIMARY KEY IDENTITY,
    TenDanhMuc NVARCHAR(100) NOT NULL
);
TRUNCATE TABLE DanhMucSanPham; --dùng TRUNCATE thay vì DELETE
TRUNCATE TABLE SanPham;
DELETE FROM DanhMucSanPham;
DELETE FROM SanPham;
SELECT * FROM DanhMucSanPham
SELECT * FROM SanPham
TRUNCATE TABLE DanhMucSanPham;  -- hoặc DELETE FROM DanhMucSanPham;
DBCC CHECKIDENT ('DanhMucSanPham', RESEED, 0);
TRUNCATE TABLE SanPham;  -- hoặc DELETE FROM SanPham;
DBCC CHECKIDENT ('SanPham', RESEED, 0);
-- Bảng sản phẩm
CREATE TABLE SanPham (
    MaSanPham BIGINT PRIMARY KEY IDENTITY,
    TenSanPham NVARCHAR(100) NOT NULL,
    MaDanhMuc INT,
    Gia DECIMAL(38, 2),
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMucSanPham(MaDanhMuc)
);

UPDATE SanPham
SET TenSanPham = 'Iphone 15 Max Pro',
    MaDanhMuc = DMSP.MaDanhMuc, 
    Gia = 1531623,
    MoTa = 'Iphone 15 Max Pro is beauty'
FROM SanPham SP
INNER JOIN DanhMucSanPham DMSP ON SP.MaDanhMuc = DMSP.MaDanhMuc
WHERE SP.MaSanPham = 33;

UPDATE SanPham
SET TenSanPham = 'Iphone 15 Max Pro',
    MaDanhMuc = (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = @TenDanhMuc), 
    Gia = 1531623,
    MoTa = 'Iphone 15 Max Pro is beauty'
WHERE MaSanPham = 33;




delete from SanPham where MaSanPham = 35
select * from sanpham
-- Thêm dữ liệu vào bảng DanhMucSanPham
INSERT INTO DanhMucSanPham (TenDanhMuc)
VALUES 
	(N'Danh mục 1'), 
	(N'Danh mục 2'), 
	(N'Danh mục 3'), 
	(N'Danh mục 4'), 
	(N'Danh mục 5'), 
	(N'Danh mục 6'), 
	(N'Danh mục 7'), 
	(N'Danh mục 8'),
	(N'Danh mục 9'),
	(N'Danh mục 10');

-- Thêm dữ liệu vào bảng SanPham và sử dụng các giá trị MaDanhMuc hợp lệ
-- thêm sản phẩm
INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa)
VALUES 
    (N'Iphone 15 Pro Max 1TB', 1, 44990000, N'Compact, sleek smartphone with versatility.'),
    (N'SamSungGalaxy A54 256GB', 2, 8190000, N'Compact, sleek smartphone with versatility.'),
    (N'Xiao Redmi Note 13 Pro 40G', 3, 6290000, N'Compact, sleek smartphone with versatility.'),
	(N'Samsung Galaxy S24 Ultra 12GB 256GB',4, 28000000, N'Compact, sleek smartphone with versatility.'),
	(N'OPPO Find N3 16GB 512GB', 5, 41990000, N'Compact, sleek smartphone with versatility.'),
	(N'iPhone 11 64GB', 6, 7890000, N'Compact, sleek smartphone with versatility.'),
	(N'Xiaomi 14 (12GB 256GB)', 7, 14000000, N'Compact, sleek smartphone with versatility.'),
	(N'Iphone 14 128GB', 8, 17390000, N'Compact, sleek smartphone with versatility.'),
	(N'Iphone 15 256GB', 9, 17390000, N'Compact, sleek smartphone with versatility.'),
	(N'Iphone 6 128GB', 10, 17390000, N'Compact, sleek smartphone with versatility.');
/*
INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa) 
VALUES ('Tên Sản Phẩm Mới', (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = 'Tên Danh Mục'), 100000, 'Mô tả cho sản phẩm mới')
*/
select *, TenDanhMuc from sanpham sp INNER JOIN DanhMucSanPham dm ON sp.MaSanPham = dm.MaDanhMuc;
-- chèn  từ 1 đến 8 mã danh mục vào bảng DANHMUCSANPHAM và chỉ có 3 tên danh mục vì vậy sẽ chạy từ 1 đến 8 và lặp lại 3 danh mục
/*
INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa)
SELECT 
    N'Iphone 15 Pro Max 1TB',
    CASE WHEN EXISTS (SELECT 1 FROM DanhMucSanPham WHERE MaDanhMuc = 1) THEN 1 ELSE NULL END,
    44990000,
    N'Compact, sleek smartphone with versatility.'
WHERE EXISTS (SELECT 1 FROM DanhMucSanPham WHERE MaDanhMuc = 1);
*/
select * from DanhMucSanPham
select * from sanpham
UPDATE sanpham 
SET TenSanPham = 'tran van chien', 
    MaDanhMuc = (SELECT MaDanhMuc FROM DanhMucSanPham WHERE TenDanhMuc = N'Danh mục 2'), 
    Gia = '123456', 
    MoTa = 'testaaaa' 
WHERE MaSanPham = 36;


-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY, -- IDENTITY là giá trị tự tăng dần
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    Email NVARCHAR(100),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

INSERT INTO KhachHang (Ho, Ten, Email, DienThoai, DiaChi)
VALUES 
    (N'Phạm', N'Trần Anh', N'phamtrananh16@gmail.com', N'0346016810', N'Hà Nội'),
    (N'Trần', N'Văn Chiến', N'tranvanchien24022003@gmail.com', N'0862587229', N'Hải Phòng'),
    (N'Hoàng', N'Văn Hùng', N'hoangvanhung03768@gmail.com', N'0376806872', N'Tuần Lề - Đông Anh'),
	(N'Nguyễn', N'Đăng Khánh', N'nguyendangkhanh@gmail.com', N'0963076253', N'Hà Giang'),
	(N'Lưu', N'Quang Hùng', N'luuquanghung16@gmail.com', N'0369337753', N'Thanh Hóa'),
	(N'Mai', N'Phi Hiếu', N'maiphihieu@gmail.com', N'0982363100', N'Thanh Hóa'),
	(N'Phạm', N'Hồng Hạnh', N'phamhonghanh@gmail.com', N'0346016810', N'Thái Nguyên'),
	(N'Nguyễn', N'Duy Kiên', N'nguyenduykien@gmail.com', N'0346016810', N'Vĩnh Phúc'),
	(N'Võ', N'Quốc Việt', N'vietviet23@gmail.com', N'0367020403', N'Nghệ An'),
	(N'Lê', N'Thiện Nguyên', N'lethiennguyen@gmail.com', N'0347018588', N'Thái Bình');
/*
UPDATE KhachHang SET Ho = @Ho, Ten = @Ten, Email = @Email, DienThoai = @DienThoai, DiaChi = @DiaChi WHERE MaKhachHang = @id
*/
-- sửa sản phẩm
UPDATE KhachHang 
SET Ho = 'Tran', Ten = 'Van Chien', Email = 'tranvnachine@gmail.com', DienThoai = '123456789', DiaChi = 'HP' 
WHERE MaKhachHang = 1;
-- xoá sản phẩm
DELETE FROM SanPham WHERE MaSanPham = 1
select * from KhachHang

-- Bảng đơn hàng
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY IDENTITY,
    MaKhachHang INT,
    NgayDat DATE,
    TongTien DECIMAL(10, 2),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);
DELETE FROM DonHang

----
-- Giả sử nhân viên nhập một mã đơn hàng sẽ hiển thị ra thông tin của khách hàng và đơn hàng đó
-- se hiển thị ra các trường dưới đây
SELECT dh.MaDonHang, dh.MaKhachHang, kh.Ho, kh.Ten, kh.Email, kh.DienThoai, kh.DiaChi, dh.NgayDat, dh.TongTien, dh.TrangThai
FROM DonHang dh
JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
ORDER BY dh.MaDonHang DESC;
/*

string query = @"
	SELECT dh.MaDonHang, dh.MaKhachHang, kh.Ho, kh.Ten, kh.Email, kh.DienThoai, kh.DiaChi, dh.NgayDat, dh.TongTien, dh.TrangThai
	FROM DonHang dh
	JOIN KhachHang kh ON dh.MaKhachHang = kh.MaKhachHang
	ORDER BY dh.MaDonHang DESC
";
string conn = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

using (SqlConnection connection = new SqlConnection(conn))
{
    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
    DataTable dt = new DataTable();
    sda.Fill(dt);
    
    // Kiểm tra dữ liệu đã được lấy thành công hay không
    if (dt.Rows.Count > 0)
    {
        // Dữ liệu đã được lấy thành công, sử dụng DataTable dt trong đây 
        // ...
    }
    else
    {
        // Không có dữ liệu được trả về từ câu truy vấn
        // ...
    }
}

*/

----

INSERT INTO DonHang(MaKhachHang, NgayDat, TongTien, TrangThai)
VALUES 
    (1, '2023-04-01', 44990000, N'Đã bán'),
    (2, '2024-04-16', 6290000, N'Đã bán'),
    (3, '2021-02-21', 28000000, N'Đã bán'),
    (4, '2022-11-01', 17390000, N'Đã bán'),
    (5, '2019-09-17', 8190000, N'Đã bán'),
    (6, '2023-08-01', 14000000, N'Đã bán'),
	(7, '2023-08-01', 14000000, N'Đã bán'),
	(8, '2023-08-01', 14000000, N'Đã bán'),
	(9, '2023-08-01', 14000000, N'Đã bán'),
	(10, '2023-08-01', 14000000, N'Đã bán');

-- Bảng chi tiết đơn hàng
CREATE TABLE ChiTietDonHang (
    MaChiTiet INT PRIMARY KEY IDENTITY,
    MaDonHang INT,
    MaSanPham INT,
    SoLuong INT,
    Gia DECIMAL(10, 2),
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- Bảng nhân viên
CREATE TABLE NhanVien (
    MaNhanVien INT PRIMARY KEY IDENTITY,
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    ChucVu NVARCHAR(100),
    Email NVARCHAR(100),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

-- Bảng khuyến mãi
CREATE TABLE KhuyenMai (
    MaKhuyenMai INT PRIMARY KEY IDENTITY,
    TenKhuyenMai NVARCHAR(100),
    MoTa NVARCHAR(MAX),
    NgayBatDau DATE,
    NgayKetThuc DATE
);

-- Bảng chi tiết khuyến mãi
CREATE TABLE ChiTietKhuyenMai (
    MaChiTietKhuyenMai INT PRIMARY KEY IDENTITY,
    MaKhuyenMai INT,
    MaSanPham INT,
    GiamGia DECIMAL(5, 2),
    FOREIGN KEY (MaKhuyenMai) REFERENCES KhuyenMai(MaKhuyenMai),
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- Bảng kho
CREATE TABLE Kho (
    MaKho INT PRIMARY KEY IDENTITY,
    MaSanPham INT,
    SoLuong INT,
    FOREIGN KEY (MaSanPham) REFERENCES SanPham(MaSanPham)
);

-- Bảng thanh toán
CREATE TABLE ThanhToan (
    MaThanhToan INT PRIMARY KEY IDENTITY,
    MaDonHang INT,
    PhuongThucThanhToan NVARCHAR(100),
    SoTien DECIMAL(10, 2),
    NgayThanhToan DATETIME,
    FOREIGN KEY (MaDonHang) REFERENCES DonHang(MaDonHang)
);
CREATE TABLE login (
    ID INT PRIMARY KEY IDENTITY,
    username NVARCHAR(50) UNIQUE,
    password NVARCHAR(50)
);

INSERT INTO login(username, password) VALUES('admin', 'tranvanchien')
INSERT INTO login(username, password) VALUES('admin1', 'phamtrananh')
INSERT INTO login(username, password) VALUES('admin2', 'hoangvanhung')
INSERT INTO login(username, password) VALUES('admin3', 'nguyendangkhanh')



