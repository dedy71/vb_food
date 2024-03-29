USE [master]
GO
/****** Object:  Database [DbPenjualanObat]    Script Date: 10/01/2024 20:00:09 ******/
CREATE DATABASE [DbPenjualanObat]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DbPenjualanObat', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbPenjualanObat.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DbPenjualanObat_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DbPenjualanObat_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DbPenjualanObat] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DbPenjualanObat].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DbPenjualanObat] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET ARITHABORT OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DbPenjualanObat] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DbPenjualanObat] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DbPenjualanObat] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DbPenjualanObat] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET RECOVERY FULL 
GO
ALTER DATABASE [DbPenjualanObat] SET  MULTI_USER 
GO
ALTER DATABASE [DbPenjualanObat] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DbPenjualanObat] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DbPenjualanObat] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DbPenjualanObat] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DbPenjualanObat] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DbPenjualanObat] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DbPenjualanObat', N'ON'
GO
ALTER DATABASE [DbPenjualanObat] SET QUERY_STORE = OFF
GO
USE [DbPenjualanObat]
GO
/****** Object:  Table [dbo].[TblObat]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblObat](
	[Kode_Obat] [varchar](50) NOT NULL,
	[Nama_Obat] [varchar](50) NULL,
	[Jenis] [varchar](50) NULL,
	[Satuan] [varchar](50) NULL,
	[Tgl_Expired] [date] NULL,
	[Harga_Beli] [numeric](18, 2) NULL,
	[Harga_Jual] [numeric](18, 2) NULL,
	[Stock] [numeric](18, 2) NULL,
 CONSTRAINT [PK_TblObat] PRIMARY KEY CLUSTERED 
(
	[Kode_Obat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblJenis_Obat]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblJenis_Obat](
	[No] [varchar](50) NOT NULL,
	[Jenis] [varchar](35) NULL,
 CONSTRAINT [PK_TblJenis_Obat] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSatuan]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSatuan](
	[No] [varchar](50) NOT NULL,
	[Satuan] [varchar](35) NULL,
 CONSTRAINT [PK_TblSatuan] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwObat]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwObat]
AS
SELECT        dbo.TblObat.Kode_Obat, dbo.TblObat.Nama_Obat, dbo.TblJenis_Obat.Jenis, dbo.TblSatuan.Satuan, dbo.TblObat.Tgl_Expired, dbo.TblObat.Harga_Beli, dbo.TblObat.Harga_Jual, dbo.TblObat.Stock
FROM            dbo.TblJenis_Obat INNER JOIN
                         dbo.TblObat ON dbo.TblJenis_Obat.No = dbo.TblObat.Jenis INNER JOIN
                         dbo.TblSatuan ON dbo.TblObat.Satuan = dbo.TblSatuan.No
GO
/****** Object:  Table [dbo].[TblJenis_Kelamin]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblJenis_Kelamin](
	[Id_JenKel] [varchar](1) NOT NULL,
	[Jenis_Kelamin] [varchar](50) NULL,
 CONSTRAINT [PK_Jenis_Kelamin] PRIMARY KEY CLUSTERED 
(
	[Id_JenKel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPelanggan]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPelanggan](
	[Kode_Pelanggan] [varchar](20) NOT NULL,
	[Nama_Pelanggan] [varchar](35) NULL,
	[Jenis_Kelamin] [varchar](1) NULL,
	[Alamat] [varchar](50) NULL,
	[Telepon] [varchar](20) NULL,
 CONSTRAINT [PK_TblPelanggan] PRIMARY KEY CLUSTERED 
(
	[Kode_Pelanggan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwPelanggan]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwPelanggan]
AS
SELECT        dbo.TblPelanggan.Kode_Pelanggan, dbo.TblPelanggan.Nama_Pelanggan, dbo.TblPelanggan.Alamat, dbo.TblPelanggan.Telepon, dbo.TblJenis_Kelamin.Jenis_Kelamin
FROM            dbo.TblJenis_Kelamin INNER JOIN
                         dbo.TblPelanggan ON dbo.TblJenis_Kelamin.Id_JenKel = dbo.TblPelanggan.Jenis_Kelamin
GO
/****** Object:  Table [dbo].[TblSupplier]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSupplier](
	[Kode_Supplier] [varchar](20) NOT NULL,
	[Nama_Supplier] [varchar](35) NULL,
	[Alamat] [varchar](50) NULL,
	[Telepon] [varchar](20) NULL,
	[Kontak] [varchar](35) NULL,
 CONSTRAINT [PK_TblSupplier] PRIMARY KEY CLUSTERED 
(
	[Kode_Supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPembelian]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPembelian](
	[Faktur_Pembelian] [varchar](25) NOT NULL,
	[Tgl_Pembelian] [date] NULL,
	[Kode_Supplier] [varchar](20) NULL,
	[Disc] [float] NULL,
	[Total] [numeric](18, 2) NULL,
 CONSTRAINT [PK_TblPembelian] PRIMARY KEY CLUSTERED 
(
	[Faktur_Pembelian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPembelian_Rinci]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPembelian_Rinci](
	[Faktur_Pembelian] [varchar](25) NOT NULL,
	[No] [numeric](18, 0) NOT NULL,
	[Kode_Obat] [varchar](50) NULL,
	[Harga_Beli] [numeric](18, 2) NULL,
	[Jumlah] [numeric](18, 2) NULL,
	[Sub_Total] [numeric](18, 2) NULL,
 CONSTRAINT [PK_TblPembelian_Rinci] PRIMARY KEY CLUSTERED 
(
	[Faktur_Pembelian] ASC,
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwPembelian]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwPembelian]
AS
SELECT        dbo.TblPembelian.Faktur_Pembelian, dbo.TblPembelian.Tgl_Pembelian, dbo.TblSupplier.Nama_Supplier, dbo.TblObat.Nama_Obat, dbo.TblJenis_Obat.Jenis, dbo.TblSatuan.Satuan, dbo.TblPembelian_Rinci.Harga_Beli, 
                         dbo.TblPembelian_Rinci.Jumlah, dbo.TblPembelian_Rinci.Sub_Total, dbo.TblPembelian.Disc, dbo.TblPembelian.Total
FROM            dbo.TblJenis_Obat INNER JOIN
                         dbo.TblObat ON dbo.TblJenis_Obat.No = dbo.TblObat.Jenis INNER JOIN
                         dbo.TblPembelian_Rinci ON dbo.TblObat.Kode_Obat = dbo.TblPembelian_Rinci.Kode_Obat INNER JOIN
                         dbo.TblPembelian ON dbo.TblPembelian_Rinci.Faktur_Pembelian = dbo.TblPembelian.Faktur_Pembelian INNER JOIN
                         dbo.TblSatuan ON dbo.TblObat.Satuan = dbo.TblSatuan.No INNER JOIN
                         dbo.TblSupplier ON dbo.TblPembelian.Kode_Supplier = dbo.TblSupplier.Kode_Supplier
GO
/****** Object:  Table [dbo].[TblPenjualan]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPenjualan](
	[Faktur_Penjualan] [varchar](25) NOT NULL,
	[Tgl_Penjualan] [date] NULL,
	[Kode_Pelanggan] [varchar](20) NULL,
	[Disc] [float] NULL,
	[Total] [numeric](18, 2) NULL,
 CONSTRAINT [PK_TblPenjualan] PRIMARY KEY CLUSTERED 
(
	[Faktur_Penjualan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPenjualan_Rinci]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPenjualan_Rinci](
	[Faktur_Penjualan] [varchar](25) NOT NULL,
	[No] [numeric](18, 0) NOT NULL,
	[Kode_Obat] [varchar](50) NULL,
	[Harga_Jual] [numeric](18, 2) NULL,
	[Jumlah] [numeric](18, 2) NULL,
	[Sub_Total] [numeric](18, 2) NULL,
 CONSTRAINT [PK_TblPenjualan_Rinci] PRIMARY KEY CLUSTERED 
(
	[Faktur_Penjualan] ASC,
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwPenjualan]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VwPenjualan]
AS
SELECT        dbo.TblPenjualan.Faktur_Penjualan, dbo.TblPenjualan.Tgl_Penjualan, dbo.TblPelanggan.Nama_Pelanggan, dbo.TblObat.Nama_Obat, dbo.TblJenis_Obat.Jenis, dbo.TblSatuan.Satuan, dbo.TblObat.Harga_Jual, 
                         dbo.TblPenjualan_Rinci.Jumlah, dbo.TblPenjualan_Rinci.Sub_Total, dbo.TblPenjualan.Disc, dbo.TblPenjualan.Total
FROM            dbo.TblPenjualan INNER JOIN
                         dbo.TblPelanggan ON dbo.TblPenjualan.Kode_Pelanggan = dbo.TblPelanggan.Kode_Pelanggan INNER JOIN
                         dbo.TblPenjualan_Rinci ON dbo.TblPenjualan.Faktur_Penjualan = dbo.TblPenjualan_Rinci.Faktur_Penjualan INNER JOIN
                         dbo.TblJenis_Obat INNER JOIN
                         dbo.TblObat ON dbo.TblJenis_Obat.No = dbo.TblObat.Jenis ON dbo.TblPenjualan_Rinci.Kode_Obat = dbo.TblObat.Kode_Obat INNER JOIN
                         dbo.TblSatuan ON dbo.TblObat.Satuan = dbo.TblSatuan.No
GO
/****** Object:  Table [dbo].[TblHakAkses]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblHakAkses](
	[Level] [varchar](25) NOT NULL,
	[Pengguna] [bit] NULL,
	[Jenis_Obat] [bit] NULL,
	[Satuan] [bit] NULL,
	[Obat] [bit] NULL,
	[Supplier] [bit] NULL,
	[Pelanggan] [bit] NULL,
	[Pembelian] [bit] NULL,
	[Penjualan] [bit] NULL,
	[LprSupplier] [bit] NULL,
	[LprPelanggan] [bit] NULL,
	[LprObat] [bit] NULL,
	[LprPembelian] [bit] NULL,
	[LprPenjualan] [bit] NULL,
	[HakAkses] [bit] NULL,
 CONSTRAINT [PK_TblHakAkses] PRIMARY KEY CLUSTERED 
(
	[Level] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblPengguna]    Script Date: 10/01/2024 20:00:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblPengguna](
	[Kode_Pengguna] [varchar](20) NOT NULL,
	[Nama_Pengguna] [varchar](35) NULL,
	[Password] [varchar](15) NULL,
	[Level] [varchar](25) NULL,
 CONSTRAINT [PK_TblPengguna] PRIMARY KEY CLUSTERED 
(
	[Kode_Pengguna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblObat]  WITH CHECK ADD  CONSTRAINT [FK_TblObat_TblJenis_Obat] FOREIGN KEY([Jenis])
REFERENCES [dbo].[TblJenis_Obat] ([No])
GO
ALTER TABLE [dbo].[TblObat] CHECK CONSTRAINT [FK_TblObat_TblJenis_Obat]
GO
ALTER TABLE [dbo].[TblObat]  WITH CHECK ADD  CONSTRAINT [FK_TblObat_TblSatuan] FOREIGN KEY([Satuan])
REFERENCES [dbo].[TblSatuan] ([No])
GO
ALTER TABLE [dbo].[TblObat] CHECK CONSTRAINT [FK_TblObat_TblSatuan]
GO
ALTER TABLE [dbo].[TblPelanggan]  WITH CHECK ADD  CONSTRAINT [FK_TblPelanggan_TblJenis_Kelamin] FOREIGN KEY([Jenis_Kelamin])
REFERENCES [dbo].[TblJenis_Kelamin] ([Id_JenKel])
GO
ALTER TABLE [dbo].[TblPelanggan] CHECK CONSTRAINT [FK_TblPelanggan_TblJenis_Kelamin]
GO
ALTER TABLE [dbo].[TblPembelian_Rinci]  WITH NOCHECK ADD  CONSTRAINT [FK_TblPembelian_Rinci_TblPembelian] FOREIGN KEY([Faktur_Pembelian])
REFERENCES [dbo].[TblPembelian] ([Faktur_Pembelian])
GO
ALTER TABLE [dbo].[TblPembelian_Rinci] NOCHECK CONSTRAINT [FK_TblPembelian_Rinci_TblPembelian]
GO
ALTER TABLE [dbo].[TblPembelian_Rinci]  WITH CHECK ADD  CONSTRAINT [FK_TblPembelian_Rinci_TblPembelian_Rinci] FOREIGN KEY([Kode_Obat])
REFERENCES [dbo].[TblObat] ([Kode_Obat])
GO
ALTER TABLE [dbo].[TblPembelian_Rinci] CHECK CONSTRAINT [FK_TblPembelian_Rinci_TblPembelian_Rinci]
GO
ALTER TABLE [dbo].[TblPenjualan_Rinci]  WITH CHECK ADD  CONSTRAINT [FK_TblPenjualan_Rinci_TblObat] FOREIGN KEY([Kode_Obat])
REFERENCES [dbo].[TblObat] ([Kode_Obat])
GO
ALTER TABLE [dbo].[TblPenjualan_Rinci] CHECK CONSTRAINT [FK_TblPenjualan_Rinci_TblObat]
GO
ALTER TABLE [dbo].[TblPenjualan_Rinci]  WITH NOCHECK ADD  CONSTRAINT [FK_TblPenjualan_Rinci_TblPenjualan_Rinci] FOREIGN KEY([Faktur_Penjualan])
REFERENCES [dbo].[TblPenjualan] ([Faktur_Penjualan])
GO
ALTER TABLE [dbo].[TblPenjualan_Rinci] NOCHECK CONSTRAINT [FK_TblPenjualan_Rinci_TblPenjualan_Rinci]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblJenis_Obat"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblSatuan"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblObat"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwObat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwObat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblPelanggan"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 168
               Right = 428
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblJenis_Kelamin"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPelanggan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPelanggan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -96
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblJenis_Obat"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblObat"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "TblPembelian"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 637
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TblPembelian_Rinci"
            Begin Extent = 
               Top = 113
               Left = 34
               Bottom = 243
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "TblSatuan"
            Begin Extent = 
               Top = 138
               Left = 259
               Bottom = 234
               Right = 429
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblSupplier"
            Begin Extent = 
               Top = 147
               Left = 507
               Bottom = 277
               Right = 677
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         C' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'olumn = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPembelian'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -192
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TblJenis_Obat"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblObat"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "TblPelanggan"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 136
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TblPenjualan"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 232
               Right = 217
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "TblPenjualan_Rinci"
            Begin Extent = 
               Top = 138
               Left = 255
               Bottom = 268
               Right = 434
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "TblSatuan"
            Begin Extent = 
               Top = 138
               Left = 472
               Bottom = 234
               Right = 642
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPenjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPenjualan'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VwPenjualan'
GO
USE [master]
GO
ALTER DATABASE [DbPenjualanObat] SET  READ_WRITE 
GO
