USE [qlbdtdd]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietDonHang](
	[MaChiTiet] [int] IDENTITY(1,1) NOT NULL,
	[MaDonHang] [int] NULL,
	[MaSanPham] [int] NULL,
	[SoLuong] [int] NULL,
	[Gia] [decimal](10, 2) NULL,
	[TongTien] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKhuyenMai](
	[MaChiTietKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[MaSanPham] [int] NULL,
	[GiamGia] [decimal](12, 2) NULL,
	[PhanTram] [int] NULL,
	[MaKhuyenMai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMucSanPham](
	[MaDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonHang]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonHang](
	[MaDonHang] [int] IDENTITY(1,1) NOT NULL,
	[MaKhachHang] [int] NULL,
	[NgayDat] [date] NULL,
	[TongTien] [decimal](10, 2) NULL,
	[TrangThai] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDonHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [int] IDENTITY(1,1) NOT NULL,
	[MaSanPham] [int] NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[TenKhuyenMai] [nvarchar](100) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
	[MaKhuyenMai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[quyen] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[NgayVaoLam] [datetime] NULL,
	[HinhAnh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [nvarchar](100) NOT NULL,
	[MaDanhMuc] [int] NULL,
	[Gia] [decimal](10, 2) NULL,
	[MoTa] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 21/5/2024 5:30:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhToan](
	[MaThanhToan] [int] IDENTITY(1,1) NOT NULL,
	[MaDonHang] [int] NULL,
	[PhuongThucThanhToan] [nvarchar](100) NULL,
	[SoTien] [decimal](10, 2) NULL,
	[NgayThanhToan] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaThanhToan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] ON 

INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (9, 12, 14, 1, CAST(31990000.00 AS Decimal(10, 2)), CAST(31990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (38, 41, 15, 1, CAST(5290000.00 AS Decimal(10, 2)), CAST(5290000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (40, 43, 23, 1, CAST(7090000.00 AS Decimal(10, 2)), CAST(7090000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (41, 44, 11, 1, CAST(15000000.00 AS Decimal(10, 2)), CAST(15000000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (47, 50, 22, 1, CAST(22290000.00 AS Decimal(10, 2)), CAST(22290000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (48, 51, 18, 1, CAST(22990000.00 AS Decimal(10, 2)), CAST(22990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (49, 52, 15, 1, CAST(5290000.00 AS Decimal(10, 2)), CAST(5290000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (55, 58, 15, 1, CAST(5290000.00 AS Decimal(10, 2)), CAST(5290000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (59, 62, 9, 1, CAST(12190000.00 AS Decimal(10, 2)), CAST(12190000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (60, 63, 11, 1, CAST(15000000.00 AS Decimal(10, 2)), CAST(15000000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (62, 65, 5, 1, CAST(13990000.00 AS Decimal(10, 2)), CAST(13990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (63, 66, 5, 1, CAST(31990000.00 AS Decimal(10, 2)), CAST(31990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (64, 67, 10, 1, CAST(7290000.00 AS Decimal(10, 2)), CAST(7290000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (65, 68, 14, 1, CAST(31990000.00 AS Decimal(10, 2)), CAST(31990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (66, 69, 14, 1, CAST(31990000.00 AS Decimal(10, 2)), CAST(31990000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietDonHang] ([MaChiTiet], [MaDonHang], [MaSanPham], [SoLuong], [Gia], [TongTien]) VALUES (72, 75, 5, 1, CAST(31990000.00 AS Decimal(10, 2)), CAST(31990000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[ChiTietDonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietKhuyenMai] ON 

INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (1, 3, NULL, 30, N'KM123ABC')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (2, 4, NULL, 5, N'KM135STU')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (3, 5, NULL, 6, N'KM246EFG')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (4, 7, NULL, 10, N'KM246VWX')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (5, 8, NULL, 20, N'KM321JKL')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (6, 9, NULL, 50, N'KM456DEF')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (7, 10, NULL, 5, N'KM654MNO')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (8, 11, NULL, 15, N'KM789GHI')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (9, 13, NULL, 10, N'KM789HIJ')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (10, 14, NULL, 7, N'KM789YZA')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (11, 15, NULL, 6, N'KM987PQR')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (12, 16, NULL, 35, N'1')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (13, 17, NULL, 30, N'2')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (14, 18, NULL, 5, N'3')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (15, 19, NULL, 6, N'4')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (16, 21, NULL, 10, N'5')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (17, 22, NULL, 20, N'6')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (18, 23, NULL, 50, N'7')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (19, 24, NULL, 5, N'8')
INSERT [dbo].[ChiTietKhuyenMai] ([MaChiTietKhuyenMai], [MaSanPham], [GiamGia], [PhanTram], [MaKhuyenMai]) VALUES (20, 25, NULL, 15, N'9')
SET IDENTITY_INSERT [dbo].[ChiTietKhuyenMai] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMucSanPham] ON 

INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (1, N'Danh mục 1')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (2, N'Danh mục 2')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (3, N'Danh mục 3')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (4, N'Danh mục 4')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (5, N'Danh mục 5')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (7, N'Danh mục 6')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (8, N'Danh mục 7')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (9, N'Danh mục 8')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (10, N'Danh mục 9')
INSERT [dbo].[DanhMucSanPham] ([MaDanhMuc], [TenDanhMuc]) VALUES (11, N'Danh mục 10')
SET IDENTITY_INSERT [dbo].[DanhMucSanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[DonHang] ON 

INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (4, 26, CAST(N'2003-02-24' AS Date), CAST(0.00 AS Decimal(10, 2)), N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (5, 27, CAST(N'2003-10-24' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (11, 33, CAST(N'2024-05-12' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (12, 34, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (15, 37, CAST(N'2024-05-10' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (18, 40, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (32, 54, CAST(N'2024-05-10' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (33, 55, CAST(N'2024-05-10' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (34, 56, CAST(N'2024-05-10' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (38, 60, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (41, 63, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (43, 65, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (44, 66, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (46, 68, CAST(N'2024-05-13' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (47, 69, CAST(N'2024-05-13' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (48, 70, CAST(N'2024-05-13' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (49, 71, CAST(N'2024-05-13' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (50, 72, CAST(N'2024-05-13' AS Date), NULL, N'Chưa Thanh Toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (51, 73, CAST(N'2024-05-13' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (52, 74, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (53, 75, CAST(N'2024-05-18' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (54, 76, CAST(N'2024-05-18' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (55, 77, CAST(N'2024-05-18' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (56, 78, CAST(N'2024-05-18' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (57, 79, CAST(N'2024-05-18' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (58, 80, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (62, 84, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (63, 85, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (65, 87, CAST(N'2024-05-19' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (66, 88, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (67, 89, CAST(N'2024-05-14' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (68, 90, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (69, 91, CAST(N'2024-05-20' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (74, 97, CAST(N'2024-05-21' AS Date), NULL, N'Ðã thanh toán')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (75, 98, CAST(N'2024-05-10' AS Date), NULL, N'Chờ xác nhận')
INSERT [dbo].[DonHang] ([MaDonHang], [MaKhachHang], [NgayDat], [TongTien], [TrangThai]) VALUES (77, 100, CAST(N'2024-05-10' AS Date), NULL, N'Ðã thanh toán')
SET IDENTITY_INSERT [dbo].[DonHang] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (1, N'Trần Văn Chiến', N'tranvanchien24022003@gmail.com', N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (2, N'Hoàng Văn Hùng', N'hoangvanhung@gmail.com', N'0862587229', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (3, N'Phạm Trần Anh', N'phamtrananh@gmail.com', N'0862587229', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (6, N'Nguyễn Đăng Khánh', N'nguyendangkhanh@gmail.com', N'0123456789', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (7, N'Phạm Hồng Hạnh', N'phamhonghanh@gmail.com', N'0123456789', N'Thái Nguyên')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (8, N'Phạm Tuấn Vũ', N'phamtuanvu@gmail.com', N'0123456789', N'Hải Dương')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (9, N'Lưu Quang Hùng', N'luuquanghung@gmail.com', N'0123456789', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (10, N'Nguyễn Duy Kiên', N'nguyenduykien@gmail.com', N'0123456789', N'Vĩnh Phúc')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (11, N'Mai Phi Hiếu', N'maiphihieu@gmail.com', N'0123456789', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (12, N'Đường Minh Long', N'duongminhlong@gmail.com', N'0123456789', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (13, N'Nguyễn Hữu Phúc Thịnh', N'nguyenhuuphucthinh@gmail.com', N'0123456789', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (14, N'Lê Thiện Nguyên', N'lethiennguyen@gmail.com', N'0123456789', N'Thái Bình')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (15, N'Tô Hoàng Vũ', N'tohoangvu@gmail.com', N'0123456789', N'Thái Nguyên')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (16, N'Nguyễn Thị Quỳnh Nga', N'ntqn@gmail.com', N'0123456789', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (17, N'Nguyễn Học Nam', N'nguyenhocnam@gmail.com', N'0123456789', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (18, N'Lê Thuỳ Linh', N'lethuylinh@gmail.com', N'0123456789', N'Phú Thọ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (19, N'Võ Quốc Việt', N'voquocviet@gmail.com', N'0123456789', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (20, N'Trần Tuấn Anh', N'trantuananh@gmail.com', N'0123456789', N'Thái Bình')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (21, N'Trần Anh Văn', N'trananhvan@gmail.com', N'0123456789', N'Thái Bình')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (22, N'Dương Hữu Nghĩa', N'duonghuunghia@gmail.com', N'0123456789', N'Ninh Bình')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (26, N'Phạm Trần Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (27, N'Phạm Anh Quốc', NULL, N'034564815', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (28, N'Trần Văn Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (29, N'Hoàng Đức Nam', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (30, N'Hoàng Đức Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (32, N'Trần Anh Văn', NULL, N'0862587229', N'Phú Thọ')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (33, N'Trần Văn Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (34, N'Trần Văn Anh', NULL, N'0862587229', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (35, N'Văn Chiến Trần ', NULL, N'0316515648', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (36, N'Văn Chiến Test', NULL, N'0862587229', N'Nam Định')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (37, N'Phạm Trần Anh', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (38, N'Phạm Trần Anh', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (39, N'Trần Văn Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (40, N'Phạm Quốc Việt', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (54, N'Võ Quốc Việt', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (55, N'Võ Quốc Việt', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (56, N'Võ Quốc Việt', NULL, N'0862587229', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (60, N'Anh Trần Phạm', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (63, N'Võ Quốc Việt', NULL, N'0123456789', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (65, N'Nguyễn Thị Quỳnh Nga', NULL, N'0123456789', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (66, N'Trần Văn Chiến', NULL, N'01672894373', N'Hà Tĩnh')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (67, N'Tô Hoàng Vũ', NULL, N'03772894376', N'Đà Lạt')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (68, N'Nguyễn Đăng Khánh', NULL, N'01593168456', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (69, N'Nguyễn Đăng Khánh', NULL, N'0159316845', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (70, N'Nguyễn Đăng Khánh', NULL, N'01672894373', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (71, N'Nguyễn Đăng Khánh', NULL, N'01672894373', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (72, N'Nguyễn Đình Minh', NULL, N'0377824228', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (73, N'Nguyễn Hữu Phúc Thịnh', NULL, N'0365946132', N'Hà Đông')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (74, N'Phạm Thị Hà Anh', NULL, N'0862587229', N'Thái Nguyên')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (75, N'Đường Minh Long', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (76, N'Đường Minh Long', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (77, N'Đường Minh Long', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (78, N'Võ Quốc Việt', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (79, N'Võ Quốc Việt', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (80, N'Đường Minh Long', NULL, N'0862587229', N'Thanh Hoá')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (84, N'Võ Quốc Việt', NULL, N'0862587229', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (85, N'Trần Văn Chiến', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (86, N'Đỗ Duy Thành', NULL, N'0862587229', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (87, N'Võ Quốc Việt', NULL, N'0862587229', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (88, N'Trần Văn Anh', NULL, N'0862587229', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (89, N'Trần Văn Chiến ', NULL, N'0123456789', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (90, N'Hoàng Văn Hùng', NULL, N'0123456789', N'Đông Anh')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (91, N'Trần Văn Chiến', NULL, N'0862582296', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (92, N'Võ Quốc Việt', NULL, N'0862587229', N'Nghệ An')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (93, N'Phạm Trần Anh', NULL, N'0123456789', N'Hà Đông')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (94, N'Nguyễn Đăng Khánh', NULL, N'01672894373', N'Hà Giang')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (95, N'Phạm Hồng Hạnh', NULL, N'03778423659', N'Thái Nguyên')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (97, N'Ti Trần Phạm', NULL, N'0862587229', N'Hà Nội')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (98, N'Nguyễn Thị Quỳnh Nga', NULL, N'0963246123', N'Đông Anh')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (99, N'Nguyễn Phúc Hữu Thịnh', NULL, N'0963246123', N'Hà Đông')
INSERT [dbo].[KhachHang] ([MaKhachHang], [HoTen], [Email], [DienThoai], [DiaChi]) VALUES (100, N'Lê Thuỳ Linh', NULL, N'0963246123', N'Hà Đông')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'Summer Sale', N'Giảm 30%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM123ABC')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'GIẢM GIÁ CỰC LỚN', N'Giảm 5%', CAST(N'2024-04-29' AS Date), CAST(N'2024-05-19' AS Date), N'KM135STU')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'"BÁCH CHIẾN, BÁCH THẮNG"', N'Giảm 6%', CAST(N'2024-04-29' AS Date), CAST(N'2024-05-19' AS Date), N'KM246EFG')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'KHUYẾN MÃI KHAI CHƯƠNG', N'Giảm 10%', CAST(N'2024-04-29' AS Date), CAST(N'2024-05-19' AS Date), N'KM246VWX')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'MUA 1 TẶNG 1', N'Giảm 20%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM321JKL')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'Winter Sale', N'Giảm 50%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM456DEF')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'CHƯƠNG TRÌNH MIỄN PHÍ VẬN CHUYỂN', N'Giảm 15%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM654MNO')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'Flash Sale', N'Giảm 10%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM789GHI')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'20TH ANNIVERSARY GIVE AWAY', N'Giảm 7%', CAST(N'2024-04-29' AS Date), CAST(N'2024-05-19' AS Date), N'KM789HIJ')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'SALE CUỐI NĂM', N'Giảm 6%', CAST(N'2024-04-29' AS Date), CAST(N'2024-05-19' AS Date), N'KM789YZA')
INSERT [dbo].[KhuyenMai] ([TenKhuyenMai], [MoTa], [NgayBatDau], [NgayKetThuc], [MaKhuyenMai]) VALUES (N'GIẢM GIÁ CHO ĐƠN HÀNG ĐẦU TIÊN', N'Giảm 35%', CAST(N'2024-04-29' AS Date), CAST(N'2024-07-20' AS Date), N'KM987PQR')
GO
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([ID], [username], [password], [quyen]) VALUES (1, N'admin', N'tranvanchien', NULL)
SET IDENTITY_INSERT [dbo].[login] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (1, N'Nguyễn Xuân Thưởng', N'Nhân viên', N'nxt@gmail.com', N'0862587229', N'Hà Nội', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (2, N'Trần Văn Chiến', N'Quản lý', N'tvc@gmail.com', N'0862587229', N'Hải Phòng', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (3, N'Phạm Trần Anh', N'Quản lý', N'pta@gmail.com', N'0862587229', N'Hà Nội', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (4, N'Hoàng Văn Hùng', N'Quản lý', N'hvh@gmail.com', N'0862587229', N'Hà Nội', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (5, N'Nguyễn Đăng Khánh', N'Quản Lý', N'ndk@gmail.com', N'0862587229', N'Hà Giang', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (6, N'Pham Hong Hanh', N'Nhân viên thu ngân', N'phh@gmail.com', N'0862587229', N'Thái Nguyên', N'Nữ', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (7, N'Nguyễn Thị Quỳnh Nga', N'Nhân viên kho', N'ntqn@gmail.com', N'0862587229', N'Hà Nội', N'Nữ', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (8, N'Lê Thiện Nguyên', N'Nhân viên kỹ thuật', N'ltn@gmail.com', N'0862587229', N'Thái Bình', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (9, N'Phạm Tuấn Vũ', N'Nhân viên marketing', N'ptv@gmail.com', N'0862587229', N'Hải Dương', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NhanVien] ([MaNhanVien], [HoTen], [ChucVu], [Email], [DienThoai], [DiaChi], [GioiTinh], [NgaySinh], [NgayVaoLam], [HinhAnh]) VALUES (10, N'Võ Quốc Việt', N'Nhân viên CSKH', N'vqv@gmail.com', N'0862587229', N'Nghệ An', N'Nam', CAST(N'2003-02-24T00:00:00.000' AS DateTime), CAST(N'2024-05-20T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (3, N'Vivo Y36 128GB', 3, CAST(8990000.00 AS Decimal(10, 2)), N'OPPO Reno11 F 5G is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (4, N'Xiaomi Redmi Note 13', 4, CAST(4990000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (5, N'iPhone 15 Plus 512GB', 5, CAST(31990000.00 AS Decimal(10, 2)), N'Samsung Galaxy A55 5G so beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (7, N'OPPO A58', 8, CAST(5990000.00 AS Decimal(10, 2)), N'OPPO A58 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (8, N'Samsung Galaxy S23 FE 5G', 9, CAST(12890000.00 AS Decimal(10, 2)), N'Samsung Galaxy S23 FE 5G')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (9, N'ASUS ROG Phone 6', 10, CAST(12190000.00 AS Decimal(10, 2)), N'iPhone 15 Pro is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (10, N'Xiaomi Redmi Note 13 Pro', 11, CAST(7290000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 Pro')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (11, N'HuaWei X9', 5, CAST(15000000.00 AS Decimal(10, 2)), N'HuaWei X9 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (13, N'OPPO Find N3 Flip 5G Hồng', 8, CAST(22990000.00 AS Decimal(10, 2)), N'OPPO Find N3 Flip 5G Hồng is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (14, N'iPhone 15 Plus 512GB', 7, CAST(31990000.00 AS Decimal(10, 2)), N'iPhone 15 Plus 512GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (15, N'Xiaomi Redmi Note 13 (8GB/128GB)', 7, CAST(5290000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 (8GB/128GB) is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (16, N'Xiaomi Redmi Note 13 Pro', 11, CAST(7290000.00 AS Decimal(10, 2)), N'Vivo Y36 128GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (17, N'Samsung Galaxy S22 Ultra 5G 128GB', 7, CAST(15990000.00 AS Decimal(10, 2)), N'Samsung Galaxy S22 Ultra 5G 128GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (18, N'Samsung Galaxy Z Fold4 5G 256GB', 8, CAST(22990000.00 AS Decimal(10, 2)), N'Samsung Galaxy Z Fold4 5G 256GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (19, N'iPhone 15 Plus 512GB', 3, CAST(31990000.00 AS Decimal(10, 2)), N'iPhone 13 Pro Max is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (21, N'Samsung Galaxy A54', 4, CAST(5990000.00 AS Decimal(10, 2)), N'Samsung Galaxy A54 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (22, N'iPhone 14 Pro Max', 3, CAST(22290000.00 AS Decimal(10, 2)), N'iPhone 14 Pro Max is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (23, N'Xiaomi POCO X6', 7, CAST(7090000.00 AS Decimal(10, 2)), N'Xiaomi POCO X6 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (24, N'Samsung Galaxy S24 Ultra 12GB 256GB', 5, CAST(5990000.00 AS Decimal(10, 2)), N'Samsung Galaxy S24 Ultra 12GB 256GB')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (25, N'Xiaomi Redmi Note 13 Pro', 11, CAST(72900000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 Pro')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET IDENTITY_INSERT [dbo].[ThanhToan] ON 

INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (126808, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T01:45:17.903' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (136984, 68, NULL, CAST(25592000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T16:33:22.957' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (143528, 5, NULL, CAST(5103000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T16:04:38.480' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (193356, 38, NULL, CAST(45980000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:37:23.367' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (194005, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-18T22:34:19.950' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (195043, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T01:43:27.340' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (203197, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:27:07.750' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (204868, 43, NULL, CAST(7090000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:30:04.733' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (239504, 5, NULL, CAST(2187000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T01:12:06.537' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (281341, 12, NULL, CAST(31990000.00 AS Decimal(10, 2)), CAST(N'2024-05-18T23:16:17.643' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (306071, 77, NULL, CAST(22393000.00 AS Decimal(10, 2)), CAST(N'2024-05-21T01:35:09.977' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (366664, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:07:24.530' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (412579, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-18T22:42:24.610' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (422682, 12, NULL, CAST(31990000.00 AS Decimal(10, 2)), CAST(N'2024-05-21T02:57:18.477' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (441987, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:24:16.270' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (462445, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-18T23:15:42.450' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (487861, 67, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T23:00:30.423' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (494449, 62, NULL, CAST(12190000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T22:05:22.283' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (497160, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-18T22:39:36.487' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (498963, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T23:52:29.467' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (515665, 74, NULL, CAST(10500000.00 AS Decimal(10, 2)), CAST(N'2024-05-21T00:47:33.493' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (526370, 18, NULL, CAST(10788000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T02:42:55.487' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (535905, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T21:13:24.490' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (574331, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:19:23.847' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (574719, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T01:05:08.597' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (601813, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:13:03.423' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (612161, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:23:42.330' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (643759, 58, NULL, CAST(5290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T22:01:17.840' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (665078, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T13:57:08.373' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (680339, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T23:59:52.307' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (695787, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T20:09:30.523' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (728062, 12, NULL, CAST(9597000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T01:18:21.537' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (765053, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:27:52.560' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (767730, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T13:53:53.783' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (786268, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T23:52:11.457' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (787432, 51, NULL, CAST(22990000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T17:42:27.050' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (789502, 41, NULL, CAST(5290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T13:55:05.870' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (821376, 69, NULL, CAST(31990000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T13:13:57.303' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (822189, 44, NULL, CAST(15000000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:33:59.283' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (858981, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T18:20:34.683' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (889015, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-21T00:45:23.570' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (891115, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:31:07.467' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (892544, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T00:19:08.597' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (901590, 5, NULL, CAST(7290000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T00:25:45.783' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (909089, 52, NULL, CAST(5290000.00 AS Decimal(10, 2)), CAST(N'2024-05-19T14:38:20.957' AS DateTime))
INSERT [dbo].[ThanhToan] ([MaThanhToan], [MaDonHang], [PhuongThucThanhToan], [SoTien], [NgayThanhToan]) VALUES (911421, 18, NULL, CAST(17980000.00 AS Decimal(10, 2)), CAST(N'2024-05-20T00:13:02.263' AS DateTime))
SET IDENTITY_INSERT [dbo].[ThanhToan] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__login__F3DBC572F91C571F]    Script Date: 21/5/2024 5:30:21 AM ******/
ALTER TABLE [dbo].[login] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
ALTER TABLE [dbo].[ChiTietDonHang]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[DonHang]  WITH CHECK ADD FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD FOREIGN KEY([MaDanhMuc])
REFERENCES [dbo].[DanhMucSanPham] ([MaDanhMuc])
GO
ALTER TABLE [dbo].[ThanhToan]  WITH CHECK ADD FOREIGN KEY([MaDonHang])
REFERENCES [dbo].[DonHang] ([MaDonHang])
GO
