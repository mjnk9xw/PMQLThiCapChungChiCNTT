USE [ThucTap_CSDL]
GO
/****** Object:  UserDefinedFunction [dbo].[CheckDataThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[CheckDataThiSinh](@hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int)
returns bit
as
begin
	declare @existedNhuCau int = 0;
	declare @existedDoiTuong int = 0;
	declare @existedTrinhDo int = 0;

	if  dbo.VailidDataIsNull(@hoTen) = 0 or dbo.VailidEmail(@email) = 0 or dbo.VailidDataIsNull(@cmt) = 0 or dbo.VailidDataIsNull(@dienThoai) = 0 
	or dbo.VailidNgaySinh(@ngaySinh) = 0 or dbo.VailidGioiTinh(@gioiTinh) = 0
		return 0
	
	select @existedNhuCau=NhuCauID from NhuCau where NhuCauID = @nhuCauID
	select @existedDoiTuong=DoiTuongID from DoiTuong where DoiTuongID = @doiTuongID
	select @existedTrinhDo=TrinhDoID from TrinhDo where TrinhDoID = @trinhDoID
	
	if @existedNhuCau = 0 or @existedDoiTuong = 0 or @existedTrinhDo =0
		return 0
	return 1
end
GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataCanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataCanBo](@input1 nvarchar(100),@input2 nvarchar(50),@input3 nvarchar(50),@input4 nvarchar(100))
returns bit
as
begin
	if @input1 like '' or @input2 like '' or @input3 like '' or @input4 like ''
		return 0
	return 1
end
GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataDanhSachDangKy]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[VailidDataDanhSachDangKy](@input1 int,@input2 nvarchar(100))
returns bit
as
begin
	if @input1 < 0 or @input2 is null
		return 0
	return 1
end

GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataDotThi](@input1 nvarchar(100))
returns bit
as
begin
	if @input1 is null 
		return 0
	return 1
end

GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataIsNull]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataIsNull](@input varchar(100))
returns bit
as
begin
	if @input like ''
		return 0
	return 1
end
GO
/****** Object:  UserDefinedFunction [dbo].[VailidDataScore]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[VailidDataScore](@input int)
returns bit
as
begin
	if @input < 0 or @input > 10
		return 0
	return 1
end
GO
/****** Object:  UserDefinedFunction [dbo].[VailidEmail]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[VailidEmail](@Input varchar(200))
RETURNS bit
AS
BEGIN
  RETURN CASE
    WHEN @Input LIKE '%_@__%.__%' THEN 1
    ELSE 0
  END
END
GO
/****** Object:  UserDefinedFunction [dbo].[VailidGioiTinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE function [dbo].[VailidGioiTinh](@input nvarchar(10))
returns bit
as
begin
	if @input like N'Nữ' or @input like N'nữ' or @input like N'nam' or @input like N'Nam'
		return 1
	return 0
end
GO
/****** Object:  UserDefinedFunction [dbo].[VailidNgaySinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[VailidNgaySinh](@input date)
returns bit
as
begin
	if YEAR(@input) is null
		return 0
	if YEAR(@input) > 1900 and YEAR(@input) < 2019
		return 1
	return 0
end
GO
/****** Object:  Table [dbo].[CanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CanBo](
	[CanBoID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](200) NULL,
	[DonVi] [nvarchar](50) NULL,
	[CapBac] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_HoiDong] PRIMARY KEY CLUSTERED 
(
	[CanBoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChungChi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChungChi](
	[ChungChiID] [int] IDENTITY(1,1) NOT NULL,
	[SoVanBang] [varchar](20) NULL,
	[SoVaoSo] [int] NULL,
	[ThiSinhID] [int] NULL,
 CONSTRAINT [PK_ChungChi] PRIMARY KEY CLUSTERED 
(
	[ChungChiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DanhSachDangKy]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachDangKy](
	[MaDanhSach] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhSach] [nvarchar](100) NULL,
	[DotThiID] [int] NULL,
 CONSTRAINT [PK_DanhSachDangKy] PRIMARY KEY CLUSTERED 
(
	[MaDanhSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DanhSachThi](
	[SBD] [varchar](10) NOT NULL,
	[ThiSinhID] [int] NOT NULL,
 CONSTRAINT [PK_DanhSachThi_1] PRIMARY KEY CLUSTERED 
(
	[SBD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DoiTuong]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiTuong](
	[DoiTuongID] [int] IDENTITY(1,1) NOT NULL,
	[TenDoiTuong] [nvarchar](200) NULL,
 CONSTRAINT [PK_DoiTuong] PRIMARY KEY CLUSTERED 
(
	[DoiTuongID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DotThi](
	[DotThiID] [int] IDENTITY(1,1) NOT NULL,
	[TenDotThi] [nvarchar](50) NULL,
	[Ngay] [date] NULL,
 CONSTRAINT [PK_DotThi] PRIMARY KEY CLUSTERED 
(
	[DotThiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoiDongThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoiDongThi](
	[DotThiID] [int] NOT NULL,
	[CanBoID] [int] NOT NULL,
	[NhiemVuID] [int] NULL,
 CONSTRAINT [PK_HoiDongThi] PRIMARY KEY CLUSTERED 
(
	[DotThiID] ASC,
	[CanBoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KetQuaChiTiet]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KetQuaChiTiet](
	[KetQuaChiTietID] [int] IDENTITY(1,1) NOT NULL,
	[SBD] [varchar](10) NULL,
	[DiemTracNghiem] [int] NULL,
	[Word] [int] NULL,
	[Excel] [int] NULL,
	[PPT] [int] NULL,
 CONSTRAINT [PK_KetQuaChiTiet] PRIMARY KEY CLUSTERED 
(
	[KetQuaChiTietID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NhiemVu]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhiemVu](
	[NhiemVuID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhiemVu] [nvarchar](200) NULL,
 CONSTRAINT [PK_NhiemVu] PRIMARY KEY CLUSTERED 
(
	[NhiemVuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhuCau]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhuCau](
	[NhuCauID] [int] IDENTITY(1,1) NOT NULL,
	[TenNhuCau] [nvarchar](200) NULL,
 CONSTRAINT [PK_NhuCau] PRIMARY KEY CLUSTERED 
(
	[NhuCauID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThanhTien]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhTien](
	[ThanhTienID] [int] IDENTITY(1,1) NOT NULL,
	[NhuCauID] [int] NULL,
	[TrinhDoID] [int] NULL,
	[DoiTuongID] [int] NULL,
	[LePhi] [int] NULL,
 CONSTRAINT [PK_ThanhTien] PRIMARY KEY CLUSTERED 
(
	[ThanhTienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThiSinh](
	[ThiSinhID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[Email] [varchar](100) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](10) NULL,
	[CMT] [nchar](12) NULL,
	[DienThoai] [nchar](10) NULL,
	[NhuCauID] [int] NULL,
	[DoiTuongID] [int] NULL,
	[TrinhDoID] [int] NULL,
	[MaDanhSach] [int] NULL,
 CONSTRAINT [PK_Thisinh] PRIMARY KEY CLUSTERED 
(
	[ThiSinhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TrinhDo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDo](
	[TrinhDoID] [int] IDENTITY(1,1) NOT NULL,
	[TenTrinhDo] [nvarchar](200) NULL,
 CONSTRAINT [PK_TrinhDo] PRIMARY KEY CLUSTERED 
(
	[TrinhDoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CanBo] ON 

INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1, N'Nguyễn Văn Huy', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (2, N'Nguyễn Thị Hiền', N'K12', N'Tiến Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (3, N'Trần Văn Cán', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (4, N'Phùng Thị Dung', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (5, N'Nguyễn Thị Thu Hằng', N'K12', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (6, N'Trần Công', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (7, N'Trần Đình Nam', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (8, N'Đỗ Đăng Khải', N'K12', N'Tiến Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (9, N'Nguyễn Văn Tiến', N'K12', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (10, N'Hoàng Thị Hồng', N'K12', N'Tiến Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (11, N'Nguyễn Văn Tam', N'K11', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (12, N'Nguyễn Văn Nghĩa', N'K10', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (13, N'Nguyễn Văn Thuận', N'K13', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (14, N'Trần Đình Sang', N'K10', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (15, N'Nguyễn Thị Thu Hiền', N'K11', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (16, N'Nguyễn Hồng Hạnh', N'K11', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (17, N'Trần Lập', N'K13', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (18, N'Trần Đình Hoàng', N'K11', N'Tiến Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (19, N'Nguyễn Thị Hạnh', N'K3', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1012, N'Phạm Khắc Tư', N'K10', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1013, N'Trịnh Kim Anh', N'K7', N'Thạc Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1014, N'Phạm Thị Hồng', N'K8', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1015, N'Quang Anh', N'K9', N'Tiến Sĩ', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1016, N'Lê Quý Dương', N'K8', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1017, N'Hoàng Duy Tường', N'K10', N'Giáo Viên', NULL)
INSERT [dbo].[CanBo] ([CanBoID], [HoTen], [DonVi], [CapBac], [GhiChu]) VALUES (1018, N'Phạm Đức Thắng', N'K13', N'Thạc Sĩ', NULL)
SET IDENTITY_INSERT [dbo].[CanBo] OFF
SET IDENTITY_INSERT [dbo].[ChungChi] ON 

INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1009, N'MTA_2018', 1, 1)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1010, N'MTA_2018', 2, 3)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1011, N'MTA_2018', 3, 4)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1012, N'MTA_2018', 4, 5)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1013, N'MTA_2018', 5, 6)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1015, N'MTA_2018', 10, 7)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1016, N'MTA_2018', 11, 11)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1017, N'MTA_2018', 18, 20)
INSERT [dbo].[ChungChi] ([ChungChiID], [SoVanBang], [SoVaoSo], [ThiSinhID]) VALUES (1018, N'MTA_2018', 7, 16)
SET IDENTITY_INSERT [dbo].[ChungChi] OFF
SET IDENTITY_INSERT [dbo].[DanhSachDangKy] ON 

INSERT [dbo].[DanhSachDangKy] ([MaDanhSach], [TenDanhSach], [DotThiID]) VALUES (1, N'Danh sách đăng kí chưa thuộc đợt thi', NULL)
INSERT [dbo].[DanhSachDangKy] ([MaDanhSach], [TenDanhSach], [DotThiID]) VALUES (2, N'Danh sách đăng kí thi cấp chứng chỉ CNTT cơ bản', 1)
INSERT [dbo].[DanhSachDangKy] ([MaDanhSach], [TenDanhSach], [DotThiID]) VALUES (3, N'Danh sách đăng kí thi cấp chứng chỉ CNTT nâng cao', 2)
INSERT [dbo].[DanhSachDangKy] ([MaDanhSach], [TenDanhSach], [DotThiID]) VALUES (1003, N'Danh sách đăng kí của Đợt thi thử thêm danh sách đăng kí', 10)
SET IDENTITY_INSERT [dbo].[DanhSachDangKy] OFF
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161500', 1)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161501', 3)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161502', 4)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161503', 5)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161504', 6)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161505', 7)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161506', 10)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161507', 11)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161508', 12)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161509', 14)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161510', 15)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161511', 16)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161512', 17)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161513', 19)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161514', 22)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161515', 20)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'DST_161516', 21)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_151400', 31)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161300', 36)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161301', 1)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161302', 3)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161303', 10)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161500', 49)
INSERT [dbo].[DanhSachThi] ([SBD], [ThiSinhID]) VALUES (N'MTA_161521', 50)
SET IDENTITY_INSERT [dbo].[DoiTuong] ON 

INSERT [dbo].[DoiTuong] ([DoiTuongID], [TenDoiTuong]) VALUES (1, N'Thí sinh tự do')
INSERT [dbo].[DoiTuong] ([DoiTuongID], [TenDoiTuong]) VALUES (2, N'Thí sinh thuộc học viện')
SET IDENTITY_INSERT [dbo].[DoiTuong] OFF
SET IDENTITY_INSERT [dbo].[DotThi] ON 

INSERT [dbo].[DotThi] ([DotThiID], [TenDotThi], [Ngay]) VALUES (1, N'Thi cấp chứng chỉ ứng dụng CNTT cơ bản', CAST(N'2018-08-01' AS Date))
INSERT [dbo].[DotThi] ([DotThiID], [TenDotThi], [Ngay]) VALUES (2, N'Thi cấp chứng chỉ ứng dụng CNTT nâng cao', CAST(N'2018-08-05' AS Date))
INSERT [dbo].[DotThi] ([DotThiID], [TenDotThi], [Ngay]) VALUES (10, N'Đợt thi thử thêm danh sách đăng kí', CAST(N'2019-04-25' AS Date))
SET IDENTITY_INSERT [dbo].[DotThi] OFF
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 1, 1)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 2, 2)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 3, 3)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 5, 4)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 6, 7)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 11, 6)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (1, 12, 5)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 1, 1)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 2, 6)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 3, 3)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 4, 7)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 8, 5)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 13, 2)
INSERT [dbo].[HoiDongThi] ([DotThiID], [CanBoID], [NhiemVuID]) VALUES (2, 18, 4)
SET IDENTITY_INSERT [dbo].[KetQuaChiTiet] ON 

INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (1, N'DST_161500', 10, 10, 10, 10)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (3, N'DST_161502', 8, 10, 8, 9)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (4, N'DST_161503', 9, 9, 10, 9)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (5, N'DST_161504', 10, 10, 8, 7)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (6, N'DST_161505', 7, 7, 10, 8)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (7, N'DST_161506', 5, 8, 8, 7)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (8, N'DST_161507', 6, 9, 7, 9)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (10, N'DST_161515', 10, 10, 10, 10)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (11, N'DST_161508', 10, 10, 10, 10)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (12, N'DST_161509', NULL, NULL, NULL, NULL)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (15, N'DST_161510', NULL, NULL, NULL, NULL)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (16, N'DST_161511', 8, 9, 7, 6)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (17, N'DST_161512', NULL, NULL, NULL, NULL)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (18, N'DST_161513', 6, 5, 10, 8)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (21, N'DST_161516', 2, 1, 2, 5)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (22, N'DST_161514', 10, 1, 1, 1)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (24, N'MTA_151400', 10, 8, 8, 8)
INSERT [dbo].[KetQuaChiTiet] ([KetQuaChiTietID], [SBD], [DiemTracNghiem], [Word], [Excel], [PPT]) VALUES (26, N'MTA_161302', 7, 7, 7, 7)
SET IDENTITY_INSERT [dbo].[KetQuaChiTiet] OFF
SET IDENTITY_INSERT [dbo].[NhiemVu] ON 

INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (1, N'Chủ tịch HĐ')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (2, N'Thư kí')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (3, N'Ra đề')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (4, N'Coi thi 1')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (5, N'Coi thi 2')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (6, N'Trưởng ban chấm thi')
INSERT [dbo].[NhiemVu] ([NhiemVuID], [TenNhiemVu]) VALUES (7, N'Chấm thi')
SET IDENTITY_INSERT [dbo].[NhiemVu] OFF
SET IDENTITY_INSERT [dbo].[NhuCau] ON 

INSERT [dbo].[NhuCau] ([NhuCauID], [TenNhuCau]) VALUES (1, N'Ôn luyện và Thi')
INSERT [dbo].[NhuCau] ([NhuCauID], [TenNhuCau]) VALUES (2, N'Chỉ tham gia thi')
SET IDENTITY_INSERT [dbo].[NhuCau] OFF
SET IDENTITY_INSERT [dbo].[ThanhTien] ON 

INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (1, 1, 1, 1, 1500000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (2, 2, 1, 1, 500000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (3, 1, 2, 1, 1300000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (4, 2, 2, 1, 400000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (5, 1, 1, 2, 1300000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (6, 2, 1, 2, 400000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (7, 1, 2, 2, 1100000)
INSERT [dbo].[ThanhTien] ([ThanhTienID], [NhuCauID], [TrinhDoID], [DoiTuongID], [LePhi]) VALUES (8, 2, 2, 2, 300000)
SET IDENTITY_INSERT [dbo].[ThanhTien] OFF
SET IDENTITY_INSERT [dbo].[ThiSinh] ON 

INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (1, N'Nguyễn Văn Minh', N'minhnguyen998vp@gmail.com                                                                           ', CAST(N'1998-04-29' AS Date), N'Nam', N'135758710   ', N'0325942121', 1, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (2, N'Ngô Bá Huy', N'huyht@gmail.com                                                                                     ', CAST(N'1998-02-10' AS Date), N'Nam', N'172626126   ', N'0122956372', 1, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (3, N'Nguyễn Thị Thu', N'thunt@gmail.com                                                                                     ', CAST(N'1998-09-11' AS Date), N'Nữ', N'121288121   ', N'0212712771', 2, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (4, N'Trần Văn Cường', N'tranvancuong@gmail.com                                                                              ', CAST(N'1999-10-02' AS Date), N'Nam', N'172726262   ', N'0982827272', 1, 2, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (5, N'Lê Chí', N'lechi99@gmail.com                                                                                   ', CAST(N'1999-01-04' AS Date), N'Nam', N'190202928   ', N'0974855040', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (6, N'Nguyễn Công Hải', N'nchai@gmail.com                                                                                     ', CAST(N'1998-02-02' AS Date), N'Nam', N'127812877   ', N'0325942121', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (7, N'Doãn Thị Liên', N'liendt@gmail.com                                                                                    ', CAST(N'1998-10-03' AS Date), N'Nữ', N'172626262   ', N'0325942322', 1, 2, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (8, N'Phan Công Nam', N'nampc22@gmail.com                                                                                   ', CAST(N'1997-01-22' AS Date), N'Nam', N'171712911   ', N'0678566521', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (9, N'Nguyễn Văn Thuận', N'nvthuan@yahoo.com                                                                                   ', CAST(N'1999-02-12' AS Date), N'Nam', N'156725111   ', N'0868887986', 2, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (10, N'Nguyễn Thị Hiền', N'nguyentthien@gmail.com                                                                              ', CAST(N'1999-10-03' AS Date), N'Nữ', N'178272111   ', N'0987567898', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (11, N'Trần Quốc', N'tquoc@yahoo.com                                                                                     ', CAST(N'1996-08-08' AS Date), N'Nam', N'982725222   ', N'0876216111', 2, 1, 2, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (12, N'Nguyễn Vũ Minh Tùng', N'tungbeo@gmail.com                                                                                   ', CAST(N'1995-10-10' AS Date), N'Nam', N'902711112   ', N'0852423000', 1, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (14, N'Ngô Thị Tươi', N'tuoi1998@gmail.com                                                                                  ', CAST(N'1998-06-09' AS Date), N'Nữ', N'137167177   ', N'0527987101', 1, 1, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (15, N'Nguyễn Thuận', N'thuannguyen@gmail.com                                                                               ', CAST(N'1995-03-10' AS Date), N'Nữ', N'182171271   ', N'0685942121', 1, 2, 1, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (16, N'Nguyễn Văn Nghĩa', N'nghia998vp@gmail.com                                                                                ', CAST(N'1996-05-08' AS Date), N'Nam', N'198272002   ', N'0975899327', 2, 2, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (17, N'Danh Hiếu ', N'danhhieu98@gmail.com                                                                                ', CAST(N'1998-02-02' AS Date), N'Nam', N'198272717   ', N'0325942221', 1, 1, 2, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (18, N'Ngô Minh Hồng', N'ngominhhong22@gmail.com                                                                             ', CAST(N'1995-06-11' AS Date), N'Nữ', N'3213129813  ', N'0712612612', 1, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (19, N'Ngô Danh Hiệp', N'ngodanhhiepkk@gmail.com                                                                             ', CAST(N'1998-05-22' AS Date), N'Nam', N'1398193219  ', N'0811396325', 2, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (20, N'Nguyễn Kim Hiền', N'nguyenkimhien11@gmail.com                                                                           ', CAST(N'1995-05-25' AS Date), N'Nam', N'3211322191  ', N'0384747311', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (21, N'Lê Danh Hiếu', N'ledanhhieu22@gmail.com                                                                              ', CAST(N'1999-05-27' AS Date), N'Nam', N'2812881212  ', N'0827451111', 2, 2, 1, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (22, N'Quảng Thị Trường', N'quangthitruong22@gmail.com                                                                          ', CAST(N'1998-06-07' AS Date), N'Nam', N'1291290290  ', N'0811396325', 1, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (23, N'Quảng Danh Huy', N'quangdanhhuykk@gmail.com                                                                            ', CAST(N'1997-05-17' AS Date), N'Nam', N'3388919281  ', N'0984326363', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (24, N'Ngô Kim Hồng', N'ngokimhong11@gmail.com                                                                              ', CAST(N'1998-06-14' AS Date), N'Nam', N'0321013283  ', N'0921378123', 1, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (25, N'Trần Khắc Anh', N'trankhacanh22@gmail.com                                                                             ', CAST(N'1999-05-16' AS Date), N'Nữ', N'3283200347  ', N'0811396325', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (26, N'Lê Khắc Hiệp', N'lekhachiepkk@gmail.com                                                                              ', CAST(N'1997-05-27' AS Date), N'Nữ', N'2178127812  ', N'0893883711', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (27, N'Quảng Khắc Chản', N'quangkhacchan9x@gmail.com                                                                           ', CAST(N'1995-05-17' AS Date), N'Nữ', N'1277128781  ', N'0811396325', 1, 2, 1, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (28, N'Phạm Khắc Hiền', N'phamkhachien9x@gmail.com                                                                            ', CAST(N'1995-06-04' AS Date), N'Nam', N'7812891289  ', N'0938127121', 2, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (29, N'Nguyễn Thị Tiến', N'nguyenthitienkk@gmail.com                                                                           ', CAST(N'1999-05-27' AS Date), N'Nữ', N'2781843891  ', N'0939218812', 1, 2, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (30, N'Lê Văn Hiệp', N'levanhiepkk@gmail.com                                                                               ', CAST(N'1998-05-26' AS Date), N'Nam', N'7128781211  ', N'0883217211', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (31, N'Nguyễn Kim Dương', N'nguyenkimduongkk@gmail.com                                                                          ', CAST(N'1997-06-10' AS Date), N'Nam', N'8913289128  ', N'0132712731', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (32, N'Trần Danh Minh', N'trandanhminhkk@gmail.com                                                                            ', CAST(N'1996-05-26' AS Date), N'Nam', N'2187127271  ', N'0348774371', 2, 2, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (33, N'Quảng Danh Minh', N'quangdanhminh11@gmail.com                                                                           ', CAST(N'1993-05-20' AS Date), N'Nữ', N'0913202119  ', N'0132732732', 1, 2, 1, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (34, N'Nguyễn Chi Oanh', N'nguyenchioanh11@gmail.com                                                                           ', CAST(N'1994-05-25' AS Date), N'Nữ', N'9832891292  ', N'0488481211', 1, 2, 2, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (35, N'Ngô Văn Trường', N'ngovantruong9x@gmail.com                                                                            ', CAST(N'1998-06-02' AS Date), N'Nữ', N'2312378127  ', N'0848484321', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (36, N'Ngô Khắc Hiếu', N'ngokhachieukk@gmail.com                                                                             ', CAST(N'1999-05-27' AS Date), N'Nam', N'3211238128  ', N'0348848541', 1, 1, 1, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (37, N'Phạm Thị Hiệp', N'phamthihiep22@gmail.com                                                                             ', CAST(N'1994-06-04' AS Date), N'Nữ', N'2731278123  ', N'0747437113', 1, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (38, N'Ngô Danh Minh', N'ngodanhminhkk@gmail.com                                                                             ', CAST(N'1994-05-23' AS Date), N'Nữ', N'7003962251  ', N'0948477444', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (39, N'Phạm Danh Minh', N'phamdanhminh22@gmail.com                                                                            ', CAST(N'1996-06-03' AS Date), N'Nữ', N'1371327812  ', N'0948377333', 1, 2, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (40, N'Quảng Kim Tiến', N'quangkimtien11@gmail.com                                                                            ', CAST(N'1998-06-01' AS Date), N'Nữ', N'7003962251  ', N'0937347374', 1, 2, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (41, N'Ngô Khắc Hoàng', N'ngokhachoangkk@gmail.com                                                                            ', CAST(N'1995-06-10' AS Date), N'Nữ', N'1209901098  ', N'0811396325', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (42, N'Phạm Minh Huy', N'phamminhhuy11@gmail.com                                                                             ', CAST(N'1999-06-07' AS Date), N'Nam', N'3782783211  ', N'0121289181', 2, 1, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (43, N'Ngô Danh Hiếu', N'ngodanhhieukk@gmail.com                                                                             ', CAST(N'1993-05-27' AS Date), N'Nữ', N'9120120893  ', N'0123744584', 1, 1, 1, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (44, N'Phạm Thị Hồng', N'phamthihong9x@gmail.com                                                                             ', CAST(N'1992-05-26' AS Date), N'Nam', N'2172178781  ', N'0121787121', 2, 1, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (45, N'Nguyễn Bá Trường', N'nguyenbatruong22@gmail.com                                                                          ', CAST(N'1996-05-21' AS Date), N'Nữ', N'7003962251  ', N'0123378734', 1, 1, 1, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (46, N'Quảng Kim Minh', N'quangkimminh22@gmail.com                                                                            ', CAST(N'1998-05-15' AS Date), N'Nữ', N'2178127812  ', N'0834634523', 2, 1, 1, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (47, N'Phạm Danh Tiến', N'phamdanhtienkk@gmail.com                                                                            ', CAST(N'1995-05-24' AS Date), N'Nam', N'7003962251  ', N'0913213278', 1, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (48, N'Lê Bá Hiền', N'lebahien9x@gmail.com                                                                                ', CAST(N'1995-05-27' AS Date), N'Nam', N'1627164250  ', N'0273726435', 2, 2, 2, 3)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (49, N'Lê Thị Trang', N'lethitrangkk@gmail.com                                                                              ', CAST(N'1997-06-04' AS Date), N'Nữ', N'1278127811  ', N'0932123732', 2, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (50, N'Quảng Minh Trang', N'quangminhtrang9x@gmail.com                                                                          ', CAST(N'1995-06-04' AS Date), N'Nữ', N'2171278111  ', N'0921381287', 2, 1, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (51, N'Phạm Chi Trường', N'phamchitruong11@gmail.com                                                                           ', CAST(N'1993-05-30' AS Date), N'Nam', N'1271287121  ', N'0821632613', 1, 2, 2, 2)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (52, N'Phạm Văn Oanh', N'phamvanoanhkk@gmail.com                                                                             ', CAST(N'1996-06-06' AS Date), N'Nữ', N'1271212882  ', N'0131212123', 2, 1, 1, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (55, N'Nguyễn Văn Minh', N'minhabc123vp@gmail.com', CAST(N'1998-02-11' AS Date), N'Nam', N'1129182181  ', N'1192912818', 2, 2, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (1056, N'Phạm Khắc Tư', N'tupham@gmail.com', CAST(N'1996-02-02' AS Date), N'Nam', N'1281288121  ', N'1299101291', 2, 1, 1, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (1057, N'Kyo Anh', N'kyoanh123@yahoo.com', CAST(N'1998-09-08' AS Date), N'Nam', N'1298128723  ', N'0914001481', 2, 1, 2, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (1058, N'Lê Chí Minh Hoàng', N'lechiminhhoang@yahoo.com', CAST(N'1998-08-12' AS Date), N'Nam', N'8217811111  ', N'0328171139', 1, 2, 1, 1)
INSERT [dbo].[ThiSinh] ([ThiSinhID], [HoTen], [Email], [NgaySinh], [GioiTinh], [CMT], [DienThoai], [NhuCauID], [DoiTuongID], [TrinhDoID], [MaDanhSach]) VALUES (1059, N'Nguyễn Thị Hồng Diễn', N'hongdien1772@gmail.com', CAST(N'1996-07-25' AS Date), N'Nữ', N'1298128721  ', N'0391838112', 2, 2, 2, 1)
SET IDENTITY_INSERT [dbo].[ThiSinh] OFF
SET IDENTITY_INSERT [dbo].[TrinhDo] ON 

INSERT [dbo].[TrinhDo] ([TrinhDoID], [TenTrinhDo]) VALUES (1, N'Chứng chỉ chuẩn ứng dụng CNTT cơ bản')
INSERT [dbo].[TrinhDo] ([TrinhDoID], [TenTrinhDo]) VALUES (2, N'Chứng chỉ chuẩn ứng dụng CNTT nâng cao')
SET IDENTITY_INSERT [dbo].[TrinhDo] OFF
ALTER TABLE [dbo].[ChungChi]  WITH CHECK ADD  CONSTRAINT [FK_ChungChi_ThiSinh1] FOREIGN KEY([ThiSinhID])
REFERENCES [dbo].[ThiSinh] ([ThiSinhID])
GO
ALTER TABLE [dbo].[ChungChi] CHECK CONSTRAINT [FK_ChungChi_ThiSinh1]
GO
ALTER TABLE [dbo].[DanhSachDangKy]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachDangKy_DotThi] FOREIGN KEY([DotThiID])
REFERENCES [dbo].[DotThi] ([DotThiID])
GO
ALTER TABLE [dbo].[DanhSachDangKy] CHECK CONSTRAINT [FK_DanhSachDangKy_DotThi]
GO
ALTER TABLE [dbo].[DanhSachThi]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachThi_ThiSinh1] FOREIGN KEY([ThiSinhID])
REFERENCES [dbo].[ThiSinh] ([ThiSinhID])
GO
ALTER TABLE [dbo].[DanhSachThi] CHECK CONSTRAINT [FK_DanhSachThi_ThiSinh1]
GO
ALTER TABLE [dbo].[HoiDongThi]  WITH CHECK ADD  CONSTRAINT [FK_HoiDongThi_CanBo] FOREIGN KEY([CanBoID])
REFERENCES [dbo].[CanBo] ([CanBoID])
GO
ALTER TABLE [dbo].[HoiDongThi] CHECK CONSTRAINT [FK_HoiDongThi_CanBo]
GO
ALTER TABLE [dbo].[HoiDongThi]  WITH CHECK ADD  CONSTRAINT [FK_HoiDongThi_DotThi] FOREIGN KEY([DotThiID])
REFERENCES [dbo].[DotThi] ([DotThiID])
GO
ALTER TABLE [dbo].[HoiDongThi] CHECK CONSTRAINT [FK_HoiDongThi_DotThi]
GO
ALTER TABLE [dbo].[HoiDongThi]  WITH CHECK ADD  CONSTRAINT [FK_HoiDongThi_NhiemVu] FOREIGN KEY([NhiemVuID])
REFERENCES [dbo].[NhiemVu] ([NhiemVuID])
GO
ALTER TABLE [dbo].[HoiDongThi] CHECK CONSTRAINT [FK_HoiDongThi_NhiemVu]
GO
ALTER TABLE [dbo].[KetQuaChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_KetQuaChiTiet_DanhSachThi] FOREIGN KEY([SBD])
REFERENCES [dbo].[DanhSachThi] ([SBD])
GO
ALTER TABLE [dbo].[KetQuaChiTiet] CHECK CONSTRAINT [FK_KetQuaChiTiet_DanhSachThi]
GO
ALTER TABLE [dbo].[ThanhTien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhTien_DoiTuong] FOREIGN KEY([DoiTuongID])
REFERENCES [dbo].[DoiTuong] ([DoiTuongID])
GO
ALTER TABLE [dbo].[ThanhTien] CHECK CONSTRAINT [FK_ThanhTien_DoiTuong]
GO
ALTER TABLE [dbo].[ThanhTien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhTien_NhuCau] FOREIGN KEY([NhuCauID])
REFERENCES [dbo].[NhuCau] ([NhuCauID])
GO
ALTER TABLE [dbo].[ThanhTien] CHECK CONSTRAINT [FK_ThanhTien_NhuCau]
GO
ALTER TABLE [dbo].[ThanhTien]  WITH CHECK ADD  CONSTRAINT [FK_ThanhTien_TrinhDo] FOREIGN KEY([TrinhDoID])
REFERENCES [dbo].[TrinhDo] ([TrinhDoID])
GO
ALTER TABLE [dbo].[ThanhTien] CHECK CONSTRAINT [FK_ThanhTien_TrinhDo]
GO
ALTER TABLE [dbo].[ThiSinh]  WITH CHECK ADD  CONSTRAINT [FK_ThiSinh_DanhSachDangKy] FOREIGN KEY([MaDanhSach])
REFERENCES [dbo].[DanhSachDangKy] ([MaDanhSach])
GO
ALTER TABLE [dbo].[ThiSinh] CHECK CONSTRAINT [FK_ThiSinh_DanhSachDangKy]
GO
ALTER TABLE [dbo].[ThiSinh]  WITH CHECK ADD  CONSTRAINT [FK_ThiSinh_DoiTuong] FOREIGN KEY([DoiTuongID])
REFERENCES [dbo].[DoiTuong] ([DoiTuongID])
GO
ALTER TABLE [dbo].[ThiSinh] CHECK CONSTRAINT [FK_ThiSinh_DoiTuong]
GO
ALTER TABLE [dbo].[ThiSinh]  WITH CHECK ADD  CONSTRAINT [FK_ThiSinh_NhuCau] FOREIGN KEY([NhuCauID])
REFERENCES [dbo].[NhuCau] ([NhuCauID])
GO
ALTER TABLE [dbo].[ThiSinh] CHECK CONSTRAINT [FK_ThiSinh_NhuCau]
GO
ALTER TABLE [dbo].[ThiSinh]  WITH CHECK ADD  CONSTRAINT [FK_ThiSinh_TrinhDo1] FOREIGN KEY([TrinhDoID])
REFERENCES [dbo].[TrinhDo] ([TrinhDoID])
GO
ALTER TABLE [dbo].[ThiSinh] CHECK CONSTRAINT [FK_ThiSinh_TrinhDo1]
GO
/****** Object:  StoredProcedure [dbo].[DeleteCanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create Procedure [dbo].[DeleteCanBo](@canBoID int)
as
	DELETE FROM CanBo
	WHERE CanBoID = @canBoID;
GO
/****** Object:  StoredProcedure [dbo].[DeleteCanBoInHoiDongThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteCanBoInHoiDongThi](@canBoID int , @dotThiID int)
as
begin
	Declare @existed int = 0;
	select @existed = NhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed > 0 
	DELETE FROM HoiDongThi
	WHERE CanBoID = @canBoID and DotThiID = @dotThiID
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteChungChi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteChungChi](@chungChiID int)
as
begin 
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where ChungChiID = @chungChiID

	if @existed > 0
	delete from ChungChi
	where ChungChiID = @chungChiID
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteDoiTuon]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteDoiTuon](@doiTuongID int)
as
	delete from DoiTuong
	where DoiTuongID = @doiTuongID
GO
/****** Object:  StoredProcedure [dbo].[DeleteDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteDotThi](@dotThiID int)
as
begin
	declare @existed int = 0;
	declare @existedDotThiInDanhSachDangKy int = 0;
	declare @existedDotThiInHoiDongThi int = 0;

	-- check
	select @existed = DotThiID from DotThi
	where DotThiID = @dotThiID

	select @existedDotThiInDanhSachDangKy = MaDanhSach from DanhSachDangKy
	where DotThiID = @dotThiID

	select @existedDotThiInHoiDongThi = CanBoID from HoiDongThi
	where DotThiID = @dotThiID

	-- to do
	if @existed > 0 and @existedDotThiInDanhSachDangKy = 0 and @existedDotThiInHoiDongThi = 0
	delete from DotThi
	where DotThiID = @dotThiID
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteKetQuaThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteKetQuaThi](@SBD varchar(10))
as
begin 
	Declare @existed  int = 0;
	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD
	
	if @existed > 0
	Delete from KetQuaChiTiet
	where SBD = @SBD
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteNhuCau]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteNhuCau](@nhuCauID int)
as
	delete from NhuCau
	where NhuCauID = @nhuCauID
GO
/****** Object:  StoredProcedure [dbo].[DeleteThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteThiSinh](@thiSinhID int)
as 
begin
	Declare @existed int = 0;
	select @existed = ThiSinhID from ThiSinh
	where ThiSinhID = @thiSinhID

	if @existed > 0
	delete from ThiSinh
	where ThiSinhID = @thiSinhID
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteThiSinhInDanhSachThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[DeleteThiSinhInDanhSachThi](@SBD varchar(10))
as
	delete from DanhSachThi
	where DanhSachThi.SBD = @SBD
GO
/****** Object:  StoredProcedure [dbo].[DeleteTrinhDo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteTrinhDo](@trinhDoID int)
as
	delete from TrinhDo
	where TrinhDoID = @trinhDoID
GO
/****** Object:  StoredProcedure [dbo].[GetAllCanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllCanBo]
as 
	select CanBoID,Hoten,DonVi,CapBac,GhiChu from CanBo
GO
/****** Object:  StoredProcedure [dbo].[GetAllDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetAllDotThi]
as
	select DotThiID,TenDotThi, Ngay from DotThi
GO
/****** Object:  StoredProcedure [dbo].[GetAllNhiemVu]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetAllNhiemVu]
as
	select NhiemVuID, TenNhiemVu from NhiemVu
GO
/****** Object:  StoredProcedure [dbo].[GetCanBoByDotThiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetCanBoByDotThiID](@maDotThi int)
as
	select HoiDongThi.CanBoID,Hoten,DonVi,CapBac,NhiemVu.TenNhiemVu,GhiChu from HoiDongThi
	inner join NhiemVu on NhiemVu.NhiemVuID = HoiDongThi.NhiemVuID
	inner join CanBo on CanBo.CanBoID = HoiDongThi.CanBoID	
	where HoiDongThi.DotThiID = @maDotThi
GO
/****** Object:  StoredProcedure [dbo].[GetCanBoByID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetCanBoByID]( @MaCB int)
as
	select Hoten,DonVi,CapBac,GhiChu from CanBo
	where CanBo.CanBoID = @MaCB
GO
/****** Object:  StoredProcedure [dbo].[GetChungChiAll]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetChungChiAll]
as
	select Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetChungChiByChungChiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetChungChiByChungChiID](@chungChiID int)
as
	select Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID
	where ChungChiID = @chungChiID

GO
/****** Object:  StoredProcedure [dbo].[GetChungChiByDotThiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetChungChiByDotThiID](@dotThiID int)
as 
	select ChungChiID,Hoten, NgaySinh, CMT, DoiTuong.TenDoiTuong, ChungChi.SoVanBang, ChungChi.SoVaoSo from ThiSinh
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join ChungChi on ChungChi.ThiSinhID = ThiSinh.ThiSinhID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	where DanhSachDangKy.DotThiID = @dotThiID
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachThiByDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDanhSachThiByDotThi](@dotThiID int)
as
	select SBD,HoTen,NgaySinh,CMT from DanhSachThi,ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachThiByThiSinhID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDanhSachThiByThiSinhID](@thiSinhID int)
as
	select SBD,HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from DanhSachThi,ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where DanhSachThi.ThiSinhID = @thiSinhID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetDanhSachThiSinhByHoiDongThiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetDanhSachThiSinhByHoiDongThiID](@hoiDongThiID int)
as
	select SBD,HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from DanhSachThi,ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where DanhSachThi.HoiDongThiID = @hoiDongThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetDoiTuong]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDoiTuong]
as
	select DoiTuongID,TenDoiTuong from DoiTuong
GO
/****** Object:  StoredProcedure [dbo].[GetDotThiByID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDotThiByID](@dotThiID int)
as
begin
	select TenDotThi, Ngay from DotThi
	where DotThiID = @dotThiID
end
GO
/****** Object:  StoredProcedure [dbo].[GetDotThiIDMax]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetDotThiIDMax]
as
begin
	select Max(DotThiID) as DotThiIDMax from DotThi
end
GO
/****** Object:  StoredProcedure [dbo].[GetKetQuaThiByDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetKetQuaThiByDotThi](@dotThiID int)
as
	select DanhSachThi.SBD,HoTen,NgaySinh,CMT,DiemTracNghiem,Word,Excel,PPT from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	inner join KetQuaChiTiet on KetQuaChiTiet.SBD like DanhSachThi.SBD
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetKetQuaThiCapChungChiByDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetKetQuaThiCapChungChiByDotThi](@dotThiID int)
as
	select DanhSachThi.SBD,HoTen,NgaySinh,CMT,DiemTracNghiem,(Word+Excel+PPT)/3 as DiemThucHanh from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	inner join KetQuaChiTiet on KetQuaChiTiet.SBD like DanhSachThi.SBD
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID

GO
/****** Object:  StoredProcedure [dbo].[GetNhuCau]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetNhuCau]
as
	select NhuCauID,TenNhuCau from NhuCau
GO
/****** Object:  StoredProcedure [dbo].[GetOnlyKetQuaThiBySBD]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetOnlyKetQuaThiBySBD](@SBD varchar(10))
as
	select SBD,DiemTracNghiem,Word,Excel,PPT from KetQuaChiTiet
	where  KetQuaChiTiet.SBD = @SBD
GO
/****** Object:  StoredProcedure [dbo].[GetSBDbyChungChiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetSBDbyChungChiID](@chungChiID int)
as
begin
	select DanhSachThi.SBD  from ChungChi
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ChungChi.ThiSinhID
	where ChungChiID = @chungChiID
end
GO
/****** Object:  StoredProcedure [dbo].[GetSBDCanGetChungChi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetSBDCanGetChungChi]
as
	select DanhSachThi.SBD from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = KetQuaChiTiet.SBD
	where DiemTracNghiem > 5
	and Word > 5
	and Excel > 5
	and PPT > 5
	and (select ChungChiID from ChungChi where ChungChi.ThiSinhID = DanhSachThi.ThiSinhID) is null
GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByDotThiID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetThiSinhByDotThiID](@dotThiID int)
as
	select HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi,DotThi.TenDotThi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	inner join DotThi on DotThi.DotThiID = DanhSachDangKy.DotThiID
	where DanhSachDangKy.DotThiID = @dotThiID
GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByDotThiNull]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetThiSinhByDotThiNull]
as
	select ThiSinhID,HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where DanhSachDangKy.MaDanhSach = 1
GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhByID]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetThiSinhByID](@thiSinhID int)
as
	select HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCau.TenNhuCau,TrinhDo.TenTrinhDo,DoiTuong.TenDoiTuong,DanhSachDangKy.TenDanhSach,ThanhTien.LePhi from ThiSinh
	inner join NhuCau on NhuCau.NhuCauID= ThiSinh.NhuCauID
	inner join TrinhDo on TrinhDo.TrinhDoID = ThiSinh.TrinhDoID
	inner join DoiTuong on DoiTuong.DoiTuongID = ThiSinh.DoiTuongID
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join ThanhTien on ThanhTien.DoiTuongID = ThiSinh.DoiTuongID and ThanhTien.NhuCauID = ThiSinh.NhuCauID and ThanhTien.TrinhDoID=ThiSinh.TrinhDoID
	where ThiSinh.ThiSinhID = @thiSinhID
GO
/****** Object:  StoredProcedure [dbo].[GetThiSinhNotYetKQ]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetThiSinhNotYetKQ](@dotThiID int)
as
begin 
	select DanhSachThi.SBD from ThiSinh
	inner join DanhSachDangKy on DanhSachDangKy.MaDanhSach = ThiSinh.MaDanhSach
	inner join DanhSachThi on DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	where  DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID and 
	(
		select KetQuaChiTietID from KetQuaChiTiet
		where KetQuaChiTiet.SBD = DanhSachThi.SBD and DanhSachDangKy.DotThiID = @dotThiID and DanhSachThi.ThiSinhID = ThiSinh.ThiSinhID
	) is null
end

GO
/****** Object:  StoredProcedure [dbo].[GetTrinhDo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetTrinhDo]
as
	select TrinhDoID,TenTrinhDo from TrinhDo
GO
/****** Object:  StoredProcedure [dbo].[InsertCanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[InsertCanBo]( @hoTen nvarchar(200),@donVi nvarchar(50),@capBac nvarchar(50), @ghiChu nvarchar(100))
as
	insert into CanBo(HoTen,DonVi,CapBac,GhiChu)
	values(@hoTen, @donVi,@capBac,@ghiChu)
GO
/****** Object:  StoredProcedure [dbo].[InsertCanBoToHoiDongThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertCanBoToHoiDongThi](@dotThiID int, @canBoID int, @nhiemVuID int)
as
begin
	Declare @existed int = 0;
	--check
	select @existed = @nhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed = 0
	insert into HoiDongThi(DotThiID,CanBoID,NhiemVuID)
	values(@dotThiID,@canBoID,@nhiemVuID)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertChungChi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertChungChi](@soVaoSo int,@thiSinhID int)
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.ThiSinhID = @thiSinhID
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	-- check soVaoSo or thiSinhID existed
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where SoVaoSo = @soVaoSo or ThiSinhID = @thiSinhID

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @existed = 0
	insert into ChungChi(SoVanBang, SoVaoSo, ThiSinhID)
	values('MTA_2018',@soVaoSo,@thiSinhID)

end
GO
/****** Object:  StoredProcedure [dbo].[InsertChungChiBySBD]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertChungChiBySBD](@soVaoSo int,@sbd varchar(10))
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	-- check soVaoSo or thiSinhID existed
	Declare @existed int = 0;
	Declare @thiSinhID int = 0;
	select @existed=ChungChiID from ChungChi
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where SoVaoSo = @soVaoSo or ChungChi.ThiSinhID = DanhSachThi.ThiSinhID

	select @thiSinhID = ThiSinhID from DanhSachThi
	where SBD = @sbd

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @existed = 0
	insert into ChungChi(SoVanBang, SoVaoSo, ThiSinhID)
	values('MTA_2018',@soVaoSo,@thiSinhID)

end
GO
/****** Object:  StoredProcedure [dbo].[InsertDanhSachDangKy]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertDanhSachDangKy](@dotThiID int, @tenDanhSachDK nvarchar(100))
as
begin
	if dbo.VailidDataDanhSachDangKy(@dotThiID,@tenDanhSachDK) = 1
		insert into DanhSachDangKy(DotThiID,TenDanhSach)
		values(@dotThiID,@tenDanhSachDK)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertDoiTuong]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertDoiTuong](@tenDoiTuong nvarchar(100))
as
	insert into DoiTuong(TenDoiTuong)
	values(@tenDoiTuong)
GO
/****** Object:  StoredProcedure [dbo].[InsertDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertDotThi](@tenDotThi nvarchar(100),@ngay date)
as
begin
	if dbo.VailidDataDotThi(@tenDotThi) = 1
		insert into DotThi(TenDotThi,Ngay)
		values(@tenDotThi, @ngay)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertKetQuaThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertKetQuaThi](@SBD varchar(10),@diemTracNghiem int, @word int, @excel int, @ppt int)
as
begin
	Declare @existedSBD int = 0;
	Declare @existed  int = 0;
	Declare @checkCore bit = 1;
	-- check score insert
	if dbo.VailidDataScore(@diemTracNghiem) = 0 or dbo.VailidDataScore(@word) = 0 or dbo.VailidDataScore(@excel) = 0 or dbo.VailidDataScore(@ppt) = 0
		set @checkCore = 0
	
	-- check existed sbd
	select @existedSBD = ThiSinhID from DanhSachThi
	where SBD = @SBD

	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD

	if @existedSBD > 0 and @existed = 0 and @checkCore = 1
	insert into KetQuaChiTiet(SBD,DiemTracNghiem,Word,Excel,PPT)
	values(@SBD,@diemTracNghiem,@word,@excel,@ppt)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertNhuCau]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertNhuCau](@tenNhuCau nvarchar(100))
as
	insert into NhuCau(TenNhuCau)
	values(@tenNhuCau)
GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinh](@hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int, @maDanhSach int)
as
begin
	DECLARE @existed int = 0;
	DECLARE @validData bit = 0;
	-- check data
	select @validData = dbo.CheckDataThiSinh(@hoTen, @email, @ngaySinh, @gioiTinh, @cmt, @dienThoai,@nhuCauID, @doiTuongID, @trinhDoID)

	--- check existed
	select @existed = ThiSinhID from ThiSinh
	where Email = @email or CMT = @cmt or DienThoai = @dienThoai

	if @existed = 0 and @validData = 1
	insert into ThiSinh(HoTen,Email,NgaySinh,GioiTinh,CMT,DienThoai,NhuCauID,DoiTuongID,TrinhDoID,MaDanhSach)
	values(@hoTen,@email,@ngaySinh,@gioiTinh,@cmt,@dienThoai,@nhuCauID,@doiTuongID,@trinhDoID,@maDanhSach)
end

GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinhToDanhSachThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinhToDanhSachThi](@SBD varchar(10),@thiSinhID int)
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where ThiSinhID = @thiSinhID or SBD = @SBD

	if @existed = 0
	insert into DanhSachThi(SBD,ThiSinhID)
	values(@SBD,@thiSinhID)
end
GO
/****** Object:  StoredProcedure [dbo].[InsertThiSinhToDSThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertThiSinhToDSThi](@thiSinhID int, @dotThiID int, @SBD varchar(10))
as 
begin
	Declare @mads int = 0;
	select @mads=MaDanhSach from DanhSachDangKy
	where DanhSachDangKy.DotThiID = @dotThiID

	if @mads > 1 
	begin
		update ThiSinh
		set MaDanhSach = @mads
		where ThiSinhID = @thiSinhID

		insert DanhSachThi(ThiSinhID,SBD)
		values(@thiSinhID,@SBD)
	end

end
GO
/****** Object:  StoredProcedure [dbo].[InsertTrinhDo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertTrinhDo](@tenTrinhDo nvarchar(100))
as
	insert into TrinhDo(TenTrinhDo)
	values(@tenTrinhDo)
GO
/****** Object:  StoredProcedure [dbo].[UpdateCanBo]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[UpdateCanBo]( @canBoID int , @hoTen nvarchar(200),@donVi nvarchar(50),@capBac nvarchar(50), @ghiChu nvarchar(100))
as
	update CanBo
	set HoTen=@hoTen,DonVi=@donVi,CapBac=@capBac, GhiChu=@ghiChu
	where CanBoID = @canBoID
GO
/****** Object:  StoredProcedure [dbo].[UpdateCanBoInHoiDongThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateCanBoInHoiDongThi](@dotThiID int, @canBoID int, @nhiemVuID int)
as
begin
	Declare @existed int = 0;
	--check
	select @existed = @nhiemVuID from HoiDongThi
	where CanBoID = @canBoID and DotThiID = @dotThiID

	if @existed > 0
	 update HoiDongThi
	 set NhiemVuID = @nhiemVuID
	 where DotThiID = @dotThiID and CanBoID = @canBoID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateChungChi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateChungChi](@chungChiID int, @soVaoSo int , @thiSinhID int)
as
begin 
	Declare @existed int = 0;
	select @existed=ChungChiID from ChungChi
	where SoVaoSo = @soVaoSo or ThiSinhID = @thiSinhID

	if @existed > 0
	update ChungChi
	set SoVaoSo = @soVaoSo , ThiSinhID = @thiSinhID
	where ChungChiID = @chungChiID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateChungChiBySBD]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateChungChiBySBD](@soVaoSo int,@sbd varchar(10))
as
begin
	-- check ket qua thi, 
	-- diem trac nghiem , diem thuc hanh >= 5
	Declare @diemTracNghiem int  = 0;
	Declare @diemThucHanh int = 0;
	Declare @chungchiID int = 0;
	select @diemTracNghiem=DiemTracNghiem,@diemThucHanh= (Word+Excel+PPT)/3 from KetQuaChiTiet
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where KetQuaChiTiet.SBD like DanhSachThi.SBD

	select @chungchiID=ChungChiID from ChungChi
	inner join DanhSachThi on DanhSachThi.SBD = @sbd
	where DanhSachThi.ThiSinhID = ChungChi.ThiSinhID

	if @diemTracNghiem >=5 and @diemThucHanh >=5 and @chungchiID > 0
		update ChungChi
		set SoVaoSo = @soVaoSo
		where ChungChi.ChungChiID = @chungchiID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateDoiTuong]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateDoiTuong](@doiTuongID int , @tenDoiTuong nvarchar(100))
as
	update DoiTuong
	set TenDoiTuong = @tenDoiTuong
	where DoiTuongID = @doiTuongID
GO
/****** Object:  StoredProcedure [dbo].[UpdateDotThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateDotThi](@dotThiID int,@tenDotThi nvarchar(100),@ngay date)
as
begin
	declare @existed int = 0;
	select @existed = DotThiID from DotThi
	where DotThiID = @dotThiID

	if @existed > 0
	update DotThi
	set TenDotThi = @tenDotThi , Ngay = @ngay
	where DotThiID = @dotThiID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateKetQuaThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateKetQuaThi](@SBD varchar(10),@diemTracNghiem int, @word int, @excel int, @ppt int)
as
begin
	Declare @existed  int = 0;
	select @existed = KetQuaChiTietID from KetQuaChiTiet
	where SBD= @SBD

	Declare @checkCore bit = 1;
	-- check score insert
	if dbo.VailidDataScore(@diemTracNghiem) = 0 or dbo.VailidDataScore(@word) = 0 or dbo.VailidDataScore(@excel) = 0 or dbo.VailidDataScore(@ppt) = 0
		set @checkCore = 0
	
	if @existed > 0 and @checkCore = 1
	update KetQuaChiTiet
	set SBD = @SBD, DiemTracNghiem = @diemTracNghiem, Word = @word, Excel = @excel, PPT = @ppt
	where SBD = @SBD
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateNhuCau]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateNhuCau](@nhuCauID int , @tenNhuCau nvarchar(100))
as
	update NhuCau
	set TenNhuCau = @tenNhuCau
	where NhuCauID = @nhuCauID
GO
/****** Object:  StoredProcedure [dbo].[UpdateSBDForThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateSBDForThiSinh](@SBDold varchar(10),@SBDnew varchar(10))
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where SBD = @SBDold

	if @existed > 0
	begin
		delete from DanhSachThi
		where SBD=@SBDold

		insert into DanhSachThi(SBD,ThiSinhID)
		values(@SBDnew,@existed)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateThiSinh]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateThiSinh](@thiSinhID int, @hoTen nvarchar(200),@email varchar(100) , @ngaySinh date , @gioiTinh nvarchar(10), @cmt nchar(12), @dienThoai nchar(10),
@nhuCauID int ,@doiTuongID int, @trinhDoID int, @maDanhSach int)
as
begin 
	Declare @existed int = 0;
	DECLARE @validData bit = 0;
	-- check data
	select @validData = dbo.CheckDataThiSinh(@hoTen, @email, @ngaySinh, @gioiTinh, @cmt, @dienThoai,@nhuCauID, @doiTuongID, @trinhDoID)

	select @existed = ThiSinhID from ThiSinh
	where ThiSinhID = @thiSinhID

	if @existed > 0 and @validData = 1
	update ThiSinh
	set HoTen=@hoTen,Email=@email,NgaySinh=@ngaySinh, GioiTinh=@gioiTinh,CMT=@cmt,DienThoai=@dienThoai, NhuCauID=@nhuCauID, DoiTuongID=@doiTuongID,TrinhDoID=@trinhDoID,MaDanhSach=@maDanhSach
	where ThiSinhID = @thiSinhID
end
GO
/****** Object:  StoredProcedure [dbo].[UpdateThiSinhInDanhSachThi]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateThiSinhInDanhSachThi](@SBD varchar(10),@thiSinhID int)
as
begin
	Declare @existed int = 0;

	---- check existed
	select @existed = ThiSinhID from DanhSachThi
	where ThiSinhID = @thiSinhID or SBD = @SBD

	if @existed > 0
	update DanhSachThi
	set SBD=@SBD
	where ThiSinhID = @thiSinhID
end

GO
/****** Object:  StoredProcedure [dbo].[UpdateTrinhDO]    Script Date: 5/16/2019 1:45:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateTrinhDO](@trinhDoID int , @tenTrinhDo nvarchar(100))
as
	update TrinhDo
	set TenTrinhDo = @tenTrinhDo
	where TrinhDoID = @trinhDoID
GO
