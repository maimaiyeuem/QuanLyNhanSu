USE [QuanLiNhanSu_TT]
GO
/****** Object:  Table [dbo].[chucvu]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chucvu](
	[ma] [int] NOT NULL,
	[ten] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chucvu] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[chuyenmon]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chuyenmon](
	[ma] [int] NOT NULL,
	[tenchuyenmon] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_chuyenmon] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[congtac]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[congtac](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[nhanvienma] [int] NOT NULL,
	[chucvuma] [int] NOT NULL,
	[ngaynhanchuc] [date] NULL,
	[ngaythoichuc] [date] NULL,
 CONSTRAINT [PK_congtac] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[nhanvien]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanvien](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](20) NOT NULL,
	[anh] [nvarchar](200) NULL,
	[dantoc] [nvarchar](10) NOT NULL,
	[gioitinh] [bit] NOT NULL,
	[tongiao] [nvarchar](20) NOT NULL,
	[quequan] [nvarchar](50) NOT NULL,
	[ngaysinh] [date] NOT NULL,
	[diachi] [nvarchar](50) NOT NULL,
	[phongbanma] [int] NOT NULL,
	[chuyenmonma] [int] NOT NULL,
	[trinhdoma] [int] NOT NULL,
	[hesoluong] [float] NOT NULL,
 CONSTRAINT [PK_nhanvien] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[phongban]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[phongban](
	[ma] [int] IDENTITY(1,1) NOT NULL,
	[ten] [nvarchar](50) NULL,
	[diachi] [nvarchar](50) NULL,
 CONSTRAINT [PK_phongban] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[trinhdo]    Script Date: 3/6/2017 10:50:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trinhdo](
	[ma] [int] NOT NULL,
	[tentrinhdo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_trinhdo] PRIMARY KEY CLUSTERED 
(
	[ma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (1, N'Tổng giám đốc')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (2, N'Phó Tổng giám đốc')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (3, N'Trưởng ban')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (4, N'Phó Trưởng ban')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (5, N'Trưởng phòng')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (6, N'Phó phòng')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (7, N'Nhân viên')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (8, N'Bảo vệ')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (9, N'Lao công')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (10, N'Chủ tịch hội đồng Quản trị')
INSERT [dbo].[chucvu] ([ma], [ten]) VALUES (11, N'Phó Chủ tịch hội đồng Quản trị')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (1, N'Công nghệ thông tin')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (2, N'Kế toán')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (3, N'Thiết kế')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (4, N'Bán hàng')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (5, N'Quảng cáo')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (6, N'Kế hoạch')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (7, N'Quản lý')
INSERT [dbo].[chuyenmon] ([ma], [tenchuyenmon]) VALUES (8, N'Pháp chế')
SET IDENTITY_INSERT [dbo].[phongban] ON 

INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (1, N'Phát triển kinh doanh', N'405 - T4 - HQ')
INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (2, N'Quảng cáo', N'406 - T4 - HQ')
INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (3, N'Công nghệ thông tin', N'302 - T2 - HQ')
INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (4, N'Kế toán', N'506 - T1 - HQ')
INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (5, N'Quản lý dự án', N'508 - T2 - HQ')
INSERT [dbo].[phongban] ([ma], [ten], [diachi]) VALUES (6, N'Hành chính', N'502 -T2 - HQ')
SET IDENTITY_INSERT [dbo].[phongban] OFF
INSERT [dbo].[trinhdo] ([ma], [tentrinhdo]) VALUES (1, N'12/12')
INSERT [dbo].[trinhdo] ([ma], [tentrinhdo]) VALUES (2, N'Cao đẳng')
INSERT [dbo].[trinhdo] ([ma], [tentrinhdo]) VALUES (3, N'Trung cấp')
INSERT [dbo].[trinhdo] ([ma], [tentrinhdo]) VALUES (4, N'Đại học')
INSERT [dbo].[trinhdo] ([ma], [tentrinhdo]) VALUES (5, N'Cao học')
ALTER TABLE [dbo].[congtac]  WITH CHECK ADD  CONSTRAINT [FK_congtac_chucvu] FOREIGN KEY([chucvuma])
REFERENCES [dbo].[chucvu] ([ma])
GO
ALTER TABLE [dbo].[congtac] CHECK CONSTRAINT [FK_congtac_chucvu]
GO
ALTER TABLE [dbo].[congtac]  WITH CHECK ADD  CONSTRAINT [FK_congtac_nhanvien] FOREIGN KEY([nhanvienma])
REFERENCES [dbo].[nhanvien] ([ma])
GO
ALTER TABLE [dbo].[congtac] CHECK CONSTRAINT [FK_congtac_nhanvien]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_chuyenmon] FOREIGN KEY([chuyenmonma])
REFERENCES [dbo].[chuyenmon] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_chuyenmon]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_phongban] FOREIGN KEY([phongbanma])
REFERENCES [dbo].[phongban] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_phongban]
GO
ALTER TABLE [dbo].[nhanvien]  WITH CHECK ADD  CONSTRAINT [FK_nhanvien_trinhdo] FOREIGN KEY([trinhdoma])
REFERENCES [dbo].[trinhdo] ([ma])
GO
ALTER TABLE [dbo].[nhanvien] CHECK CONSTRAINT [FK_nhanvien_trinhdo]
GO
