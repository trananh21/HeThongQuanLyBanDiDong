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
    MaSanPham INT PRIMARY KEY IDENTITY,
    TenSanPham NVARCHAR(100) NOT NULL,
    MaDanhMuc INT,
    Gia DECIMAL(10, 2),
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMucSanPham(MaDanhMuc)
);
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
	(N'Danh mục 8');

-- Thêm dữ liệu vào bảng SanPham và sử dụng các giá trị MaDanhMuc hợp lệ
INSERT INTO SanPham (TenSanPham, MaDanhMuc, Gia, MoTa)
VALUES 
    (N'Iphone 15 Pro Max 1TB', 1, 44990000, N'Compact, sleek smartphone with versatility.'),
    (N'SamSungGalaxy A54 256GB', 2, 8190000, N'Compact, sleek smartphone with versatility.'),
    (N'Xiao Redmi Note 13 Pro 40G', 3, 6290000, N'Compact, sleek smartphone with versatility.'),
	(N'Samsung Galaxy S24 Ultra 12GB 256GB',4, 28000000, N'Compact, sleek smartphone with versatility.'),
	(N'OPPO Find N3 16GB 512GB', 5, 41990000, N'Compact, sleek smartphone with versatility.'),
	(N'iPhone 11 64GB', 6, 7890000, N'Compact, sleek smartphone with versatility.'),
	(N'Xiaomi 14 (12GB 256GB)', 7, 14000000, N'Compact, sleek smartphone with versatility.'),
	(N'Ihone 14 128GB', 8, 17390000, N'Compact, sleek smartphone with versatility.');
-- chèn  từ 1 đến 8 mã danh mục vào bảng DANHMUCSANPHAM và chỉ có 3 tên danh mục vì vậy sẽ chạy từ 1 đến 8 và lặp lại 3 danh mục
-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY, -- IDENTITY là giá trị tự tăng dần
    Ho NVARCHAR(50),
    Ten NVARCHAR(50),
    Email NVARCHAR(100),
    DienThoai NVARCHAR(20),
    DiaChi NVARCHAR(255)
);

-- Bảng đơn hàng
CREATE TABLE DonHang (
    MaDonHang INT PRIMARY KEY IDENTITY,
    MaKhachHang INT,
    NgayDat DATE,
    TongTien DECIMAL(10, 2),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang)
);

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



