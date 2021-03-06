USE [kubraa]
GO
/****** Object:  Table [dbo].[anakart]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[anakart](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ramslotu] [nvarchar](50) NOT NULL,
	[chıpset] [nvarchar](50) NOT NULL,
	[anakartboy] [nvarchar](50) NOT NULL,
	[alındı] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_anakart] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[bilgisayarekle]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bilgisayarekle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kimeait] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
	[hangibolum] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_bilgisayarekle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ekrankartı]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ekrankartı](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[chipset] [nvarchar](50) NOT NULL,
	[bitd] [nvarchar](50) NOT NULL,
	[ekrankartıbellek] [nvarchar](50) NOT NULL,
	[alındı] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_ekrankartı] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[gırıs]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gırıs](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kullanıcı_adı] [nvarchar](50) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_gırıs] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[gonderılen]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[gonderılen](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hangıbolum] [nvarchar](50) NOT NULL,
	[adısoyad] [nvarchar](50) NOT NULL,
	[gonderilennedir] [nvarchar](50) NOT NULL,
	[markası] [nvarchar](50) NOT NULL,
	[gonderıldı] [date] NOT NULL,
	[siparis] [nvarchar](50) NOT NULL,
	[elimizde] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_gonderılen] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ıslemcı]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ıslemcı](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[hangıbılgısayardancıktı] [nvarchar](50) NOT NULL,
	[hangıtarıh] [date] NOT NULL,
	[nezamanınternetalındı] [date] NOT NULL,
	[ıslemcımarkası] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ıslemcı] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[kasa]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kasa](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nerdengeldi] [nvarchar](50) NOT NULL,
	[kasaıc] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_kasa] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[klavye]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[klavye](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[klavyeturu] [nvarchar](50) NOT NULL,
	[nerdenalındı] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_klavye] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ram]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ram](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ramkapasıte] [nvarchar](50) NOT NULL,
	[ramtipi] [nvarchar](50) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[alındı] [nvarchar](50) NOT NULL,
	[tarih] [date] NOT NULL,
 CONSTRAINT [PK_ram] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[sabit]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sabit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[marka] [nvarchar](50) NOT NULL,
	[kapasite] [nvarchar](50) NOT NULL,
	[arabirim] [nvarchar](50) NOT NULL,
	[tariih] [date] NOT NULL,
	[nerdenalindi] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_sabit] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[yazıcıekle]    Script Date: 16.5.2018 22:09:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[yazıcıekle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nerdengeldi] [nvarchar](50) NOT NULL,
	[hangitarihte] [date] NOT NULL,
	[markası] [nvarchar](50) NOT NULL,
	[ozelliği] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_yazıcıekle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[anakart] ON 

GO
INSERT [dbo].[anakart] ([id], [ramslotu], [chıpset], [anakartboy], [alındı], [tarih]) VALUES (1, N'4 ADET', N'Intel H270', N'ATX', N'iNTERNETTEN SİPARİŞ EDİLDİ', CAST(N'2018-04-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[anakart] OFF
GO
SET IDENTITY_INSERT [dbo].[bilgisayarekle] ON 

GO
INSERT [dbo].[bilgisayarekle] ([id], [kimeait], [sifre], [hangibolum], [tarih]) VALUES (2, N'ebru', N'123456', N'KEÇE HATTI', CAST(N'2018-03-30' AS Date))
GO
INSERT [dbo].[bilgisayarekle] ([id], [kimeait], [sifre], [hangibolum], [tarih]) VALUES (3, N'arda', N'123456', N'KEÇE HATTI', CAST(N'2018-03-30' AS Date))
GO
INSERT [dbo].[bilgisayarekle] ([id], [kimeait], [sifre], [hangibolum], [tarih]) VALUES (4, N'', N'', N'', CAST(N'2018-03-25' AS Date))
GO
SET IDENTITY_INSERT [dbo].[bilgisayarekle] OFF
GO
SET IDENTITY_INSERT [dbo].[gırıs] ON 

GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (1, N'kubra', N'123456')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (2, N'ebru', N'2526')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (3, N'', N'')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (4, N'arda', N'2325')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (5, N'', N'')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (6, N'', N'')
GO
INSERT [dbo].[gırıs] ([id], [kullanıcı_adı], [sifre]) VALUES (1005, N'', N'')
GO
SET IDENTITY_INSERT [dbo].[gırıs] OFF
GO
SET IDENTITY_INSERT [dbo].[gonderılen] ON 

GO
INSERT [dbo].[gonderılen] ([id], [hangıbolum], [adısoyad], [gonderilennedir], [markası], [gonderıldı], [siparis], [elimizde]) VALUES (1, N'KEÇE HATTI', N'tayfun kuzu', N'BİLGİSAYAR', N'hp', CAST(N'2018-05-16' AS Date), N'HAYIR', N'EVET')
GO
INSERT [dbo].[gonderılen] ([id], [hangıbolum], [adısoyad], [gonderilennedir], [markası], [gonderıldı], [siparis], [elimizde]) VALUES (2, N'KEÇE HATTI', N'tayfun kuzu', N'BİLGİSAYAR', N'hp', CAST(N'2018-05-16' AS Date), N'HAYIR', N'EVET')
GO
SET IDENTITY_INSERT [dbo].[gonderılen] OFF
GO
SET IDENTITY_INSERT [dbo].[ıslemcı] ON 

GO
INSERT [dbo].[ıslemcı] ([id], [hangıbılgısayardancıktı], [hangıtarıh], [nezamanınternetalındı], [ıslemcımarkası]) VALUES (2, N'muhasebe bilgisayarın içinden alındı', CAST(N'2018-03-25' AS Date), CAST(N'2018-03-25' AS Date), N'intel')
GO
SET IDENTITY_INSERT [dbo].[ıslemcı] OFF
GO
SET IDENTITY_INSERT [dbo].[kasa] ON 

GO
INSERT [dbo].[kasa] ([id], [nerdengeldi], [kasaıc], [tarih]) VALUES (1, N'İNTERNETTEN SİPARİŞ EDİLDİ', N'İÇİ BOŞ', CAST(N'2018-04-15' AS Date))
GO
INSERT [dbo].[kasa] ([id], [nerdengeldi], [kasaıc], [tarih]) VALUES (2, N'İŞYERİNİN KASASI', N'İÇİ DOLU', CAST(N'2018-04-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[kasa] OFF
GO
SET IDENTITY_INSERT [dbo].[klavye] ON 

GO
INSERT [dbo].[klavye] ([id], [klavyeturu], [nerdenalındı], [tarih]) VALUES (1, N'F TÜRÜ', N'İNTERNETTEN SİPARİŞ EDİLDİ', CAST(N'2018-04-12' AS Date))
GO
INSERT [dbo].[klavye] ([id], [klavyeturu], [nerdenalındı], [tarih]) VALUES (2, N'Q KLAVYE', N'İŞYERİNDEN GELDİ', CAST(N'2018-04-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[klavye] OFF
GO
SET IDENTITY_INSERT [dbo].[ram] ON 

GO
INSERT [dbo].[ram] ([id], [ramkapasıte], [ramtipi], [marka], [alındı], [tarih]) VALUES (1, N'1 GB', N'DDR3', N'İNTEL', N'Bilgisayarın İçinden Alındı', CAST(N'2018-04-15' AS Date))
GO
SET IDENTITY_INSERT [dbo].[ram] OFF
GO
SET IDENTITY_INSERT [dbo].[sabit] ON 

GO
INSERT [dbo].[sabit] ([id], [marka], [kapasite], [arabirim], [tariih], [nerdenalindi]) VALUES (5, N'SONİC', N'1 TB', N'SATA', CAST(N'2018-03-25' AS Date), N'SİPARİŞ EDİLEN')
GO
SET IDENTITY_INSERT [dbo].[sabit] OFF
GO
SET IDENTITY_INSERT [dbo].[yazıcıekle] ON 

GO
INSERT [dbo].[yazıcıekle] ([id], [nerdengeldi], [hangitarihte], [markası], [ozelliği]) VALUES (6, N'MUHASEBE YEDEK YAZICI', CAST(N'2018-03-25' AS Date), N'HP', N'TONERLİ')
GO
SET IDENTITY_INSERT [dbo].[yazıcıekle] OFF
GO
