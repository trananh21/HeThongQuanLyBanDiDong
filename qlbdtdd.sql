CREATE DATABASE qlbdtdd
GO

use qlbdtdd
go

-- Bảng danh mục sản phẩm
CREATE TABLE DanhMucSanPham (
    MaDanhMuc INT PRIMARY KEY IDENTITY,
    TenDanhMuc NVARCHAR(100) NOT NULL
);

-- Bảng sản phẩm
CREATE TABLE SanPham (
    MaSanPham INT PRIMARY KEY IDENTITY,
    TenSanPham NVARCHAR(100) NOT NULL,
    MaDanhMuc INT,
    Gia DECIMAL(10, 2),
    MoTa NVARCHAR(MAX),
    FOREIGN KEY (MaDanhMuc) REFERENCES DanhMucSanPham(MaDanhMuc)
);

-- Bảng khách hàng
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY IDENTITY,
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