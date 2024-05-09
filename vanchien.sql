USE [qlbdtdd]
GO
/****** Object:  Table [dbo].[ChiTietDonHang]    Script Date: 9/5/2024 9:34:48 PM ******/
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
PRIMARY KEY CLUSTERED 
(
	[MaChiTiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietKhuyenMai]    Script Date: 9/5/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietKhuyenMai](
	[MaChiTietKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[MaKhuyenMai] [int] NULL,
	[MaSanPham] [int] NULL,
	[GiamGia] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChiTietKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMucSanPham]    Script Date: 9/5/2024 9:34:48 PM ******/
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
/****** Object:  Table [dbo].[DonHang]    Script Date: 9/5/2024 9:34:48 PM ******/
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
/****** Object:  Table [dbo].[KhachHang]    Script Date: 9/5/2024 9:34:48 PM ******/
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
/****** Object:  Table [dbo].[Kho]    Script Date: 9/5/2024 9:34:48 PM ******/
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
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 9/5/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaKhuyenMai] [int] IDENTITY(1,1) NOT NULL,
	[TenKhuyenMai] [nvarchar](100) NULL,
	[MoTa] [nvarchar](max) NULL,
	[NgayBatDau] [date] NULL,
	[NgayKetThuc] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[login]    Script Date: 9/5/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 9/5/2024 9:34:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[Ho] [nvarchar](50) NULL,
	[Ten] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](20) NULL,
	[DiaChi] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 9/5/2024 9:34:48 PM ******/
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
/****** Object:  Table [dbo].[ThanhToan]    Script Date: 9/5/2024 9:34:48 PM ******/
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
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
SET IDENTITY_INSERT [dbo].[login] ON 

INSERT [dbo].[login] ([ID], [username], [password]) VALUES (1, N'admin', N'tranvanchien')
SET IDENTITY_INSERT [dbo].[login] OFF
GO
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (3, N'OPPO Reno11 F 5G', 3, CAST(8990000.00 AS Decimal(10, 2)), N'OPPO Reno11 F 5G is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (4, N'Xiaomi Redmi Note 13', 4, CAST(4990000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (5, N'Samsung Galaxy A55 5G', 5, CAST(13990000.00 AS Decimal(10, 2)), N'Samsung Galaxy A55 5G so beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (6, N'Xiaomi Redmi 12', 7, CAST(3490000.00 AS Decimal(10, 2)), N'Xiaomi Redmi 12')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (7, N'OPPO A58', 8, CAST(5990000.00 AS Decimal(10, 2)), N'OPPO A58 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (8, N'Samsung Galaxy S23 FE 5G', 9, CAST(12890000.00 AS Decimal(10, 2)), N'Samsung Galaxy S23 FE 5G')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (9, N'iPhone 15 Pro', 10, CAST(25490000.00 AS Decimal(10, 2)), N'iPhone 15 Pro is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (10, N'Xiaomi Redmi Note 13 Pro', 11, CAST(7290000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 Pro')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (11, N'HuaWei X9', 5, CAST(15000000.00 AS Decimal(10, 2)), N'HuaWei X9 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (13, N'OPPO Find N3 Flip 5G Hồng', 8, CAST(22990000.00 AS Decimal(10, 2)), N'OPPO Find N3 Flip 5G Hồng is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (14, N'iPhone 15 Plus 512GB', 7, CAST(31990000.00 AS Decimal(10, 2)), N'iPhone 15 Plus 512GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (15, N'Xiaomi Redmi Note 13 (8GB/128GB)', 7, CAST(5290000.00 AS Decimal(10, 2)), N'Xiaomi Redmi Note 13 (8GB/128GB) is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (16, N'Vivo Y36 128GB', 11, CAST(5190000.00 AS Decimal(10, 2)), N'Vivo Y36 128GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (17, N'Samsung Galaxy S22 Ultra 5G 128GB', 7, CAST(15990000.00 AS Decimal(10, 2)), N'Samsung Galaxy S22 Ultra 5G 128GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (18, N'Samsung Galaxy Z Fold4 5G 256GB', 8, CAST(22990000.00 AS Decimal(10, 2)), N'Samsung Galaxy Z Fold4 5G 256GB is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (19, N'iPhone 13 Pro Max', 3, CAST(17090000.00 AS Decimal(10, 2)), N'iPhone 13 Pro Max is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (20, N'ASUS ROG Phone 6', 7, CAST(12190000.00 AS Decimal(10, 2)), N'ASUS ROG Phone 6 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (21, N'Samsung Galaxy A54 ', 4, CAST(5990000.00 AS Decimal(10, 2)), N'Samsung Galaxy A54 is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (22, N'iPhone 14 Pro Max ', 3, CAST(22290000.00 AS Decimal(10, 2)), N'iPhone 14 Pro Max is beauty')
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MaDanhMuc], [Gia], [MoTa]) VALUES (23, N'Xiaomi POCO X6', 7, CAST(7090000.00 AS Decimal(10, 2)), N'Xiaomi POCO X6 is beauty')
SET IDENTITY_INSERT [dbo].[SanPham] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__login__F3DBC5726617741C]    Script Date: 9/5/2024 9:34:48 PM ******/
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
ALTER TABLE [dbo].[ChiTietKhuyenMai]  WITH CHECK ADD FOREIGN KEY([MaKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([MaKhuyenMai])
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
