USE [master]
GO
/****** Object:  Database [apartmanyonetimi]    Script Date: 11.5.2020 16:45:21 ******/
CREATE DATABASE [apartmanyonetimi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'apartmanyonetimi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\apartmanyonetimi.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'apartmanyonetimi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\apartmanyonetimi_log.ldf' , SIZE = 4672KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [apartmanyonetimi] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [apartmanyonetimi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [apartmanyonetimi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET ARITHABORT OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [apartmanyonetimi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [apartmanyonetimi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [apartmanyonetimi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET  DISABLE_BROKER 
GO
ALTER DATABASE [apartmanyonetimi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [apartmanyonetimi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [apartmanyonetimi] SET  MULTI_USER 
GO
ALTER DATABASE [apartmanyonetimi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [apartmanyonetimi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [apartmanyonetimi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [apartmanyonetimi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [apartmanyonetimi]
GO
/****** Object:  Table [dbo].[adres]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adres](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adres] [varchar](350) NULL,
 CONSTRAINT [PK_adres] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[arsiv]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[arsiv](
	[arsiv_id] [int] IDENTITY(1,1) NOT NULL,
	[gelis_tarih] [varchar](12) NULL,
	[cikis_tarih] [varchar](12) NULL,
	[tasinma_tarih] [varchar](12) NULL,
	[text] [varchar](300) NULL,
 CONSTRAINT [PK_arsiv] PRIMARY KEY CLUSTERED 
(
	[arsiv_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[binalar]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[binalar](
	[bina_id] [int] IDENTITY(1,1) NOT NULL,
	[bina_adi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_binalar] PRIMARY KEY CLUSTERED 
(
	[bina_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[borclar]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[borclar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kisi_tc] [char](11) NOT NULL,
	[borc_aciklama] [varchar](200) NULL,
	[tarih] [varchar](50) NULL,
	[son_odeme_tarihi] [varchar](50) NULL,
	[tutar] [int] NULL,
	[odendigi_tarih] [varchar](50) NULL,
 CONSTRAINT [PK_borclar_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[daireler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[daireler](
	[daire_id] [int] IDENTITY(1,1) NOT NULL,
	[bina_adi] [varchar](50) NOT NULL,
	[daire_kat] [varchar](3) NULL,
	[daire_kapi_no] [varchar](3) NULL,
	[ikamet_eden_kisi] [varchar](60) NULL,
	[kisi_tc] [char](11) NULL,
	[kisi_tel] [char](11) NULL,
	[kisi_eposta] [varchar](50) NULL,
	[kisi_notlar] [varchar](250) NULL,
	[gelis_tarihi] [varchar](50) NULL,
	[cikis_tarihi] [varchar](50) NULL,
	[bakiye] [int] NULL,
 CONSTRAINT [PK_daireler] PRIMARY KEY CLUSTERED 
(
	[daire_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[eski_daireler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
CREATE TABLE [dbo].[eski_daireler](
	[daire_id] [int] IDENTITY(1,1) NOT NULL,
	[bina_adi] [varchar](50) NOT NULL,
	[daire_kat] [varchar](3) NULL,
	[daire_kapi_no] [varchar](3) NULL,
	[ikamet_eden_kisi] [varchar](60) NULL,
	[kisi_tc] [char](11) NULL,
	[kisi_tel] [char](11) NULL,
	[kisi_eposta] [varchar](50) NULL,
	[kisi_notlar] [varchar](50) NULL,
	[gelis_tarihi] [varchar](50) NULL,
	[cikis_tarihi] [varchar](50) NULL,
 CONSTRAINT [PK_eski_daireler] PRIMARY KEY CLUSTERED 
(
	[daire_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[eski_personel]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[eski_personel](
	[p_id] [int] IDENTITY(1,1) NOT NULL,
	[adsoyad] [varchar](50) NULL,
	[telefon] [char](12) NULL,
	[eposta] [varchar](50) NULL,
	[tc] [char](11) NULL,
	[gelis_tarihi] [char](10) NULL,
	[cikis_tarihi] [char](10) NULL,
	[brans] [varchar](25) NULL,
	[blok] [varchar](25) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[eski_yoneticiler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[eski_yoneticiler](
	[y_id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](60) NOT NULL,
	[soyad] [varchar](50) NOT NULL,
	[tel] [char](12) NOT NULL,
	[eposta] [varchar](50) NOT NULL,
	[tc] [char](11) NOT NULL,
	[sifre] [varchar](40) NOT NULL,
	[yetki] [varchar](50) NULL,
	[gelis_tarihi] [varchar](50) NULL,
	[cikis_tarihi] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kasa]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kasa](
	[kasa_id] [int] IDENTITY(1,1) NOT NULL,
	[gider] [int] NULL,
	[gelir] [int] NULL,
	[aciklama] [varchar](50) NULL,
	[aciklama_detay] [varchar](100) NULL,
	[tarih] [varchar](50) NULL,
 CONSTRAINT [PK_kasa] PRIMARY KEY CLUSTERED 
(
	[kasa_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[kisiler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[kisiler](
	[kisi_id] [int] IDENTITY(1,1) NOT NULL,
	[kisi_adsoyad] [varchar](50) NOT NULL,
	[kisi_tc] [char](11) NOT NULL,
	[kisi_tel] [char](11) NOT NULL,
	[kisi_eposta] [varchar](50) NOT NULL,
	[kisi_notlar] [varchar](250) NOT NULL,
	[gelis_tarihi] [varchar](12) NULL,
	[cikis_tarihi] [varchar](12) NULL,
 CONSTRAINT [PK_kisiler] PRIMARY KEY CLUSTERED 
(
	[kisi_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[makbuz]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[makbuz](
	[no] [int] IDENTITY(1,1) NOT NULL,
	[kisi_tc] [varchar](11) NULL,
	[aciklama] [varchar](200) NULL,
	[makbuz_tarihi] [varchar](50) NULL,
	[bina_adi] [varchar](50) NULL,
	[daire_kat] [varchar](50) NULL,
	[daire_kapi_no] [varchar](50) NULL,
	[donem] [varchar](50) NULL,
	[veren] [varchar](50) NULL,
	[alan] [varchar](50) NULL,
	[miktar] [int] NULL,
 CONSTRAINT [PK_makbuz] PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[personel]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[personel](
	[p_id] [int] IDENTITY(1,1) NOT NULL,
	[adsoyad] [varchar](50) NULL,
	[telefon] [char](12) NULL,
	[eposta] [varchar](50) NULL,
	[tc] [char](11) NULL,
	[gelis_tarihi] [char](10) NULL,
	[brans] [varchar](25) NULL,
	[blok] [varchar](25) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[siteler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[siteler](
	[site_id] [int] IDENTITY(1,1) NOT NULL,
	[site_adi] [varchar](50) NOT NULL,
	[site_adresi] [varchar](90) NOT NULL,
 CONSTRAINT [PK_siteler] PRIMARY KEY CLUSTERED 
(
	[site_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[yetkiler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[yetkiler](
	[yetki_id] [int] IDENTITY(1,1) NOT NULL,
	[yetki] [varchar](50) NOT NULL,
 CONSTRAINT [PK_yetkiler] PRIMARY KEY CLUSTERED 
(
	[yetki_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[yoneticiler]    Script Date: 11.5.2020 16:45:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[yoneticiler](
	[y_id] [int] IDENTITY(1,1) NOT NULL,
	[ad] [varchar](60) NOT NULL,
	[soyad] [varchar](50) NOT NULL,
	[tel] [char](12) NOT NULL,
	[eposta] [varchar](50) NOT NULL,
	[tc] [char](11) NOT NULL,
	[sifre] [varchar](40) NOT NULL,
	[yetki] [varchar](50) NULL,
	[guvenlik_sorusu] [varchar](200) NULL,
	[cevap] [varchar](100) NULL,
	[gelis_tarihi] [varchar](50) NULL,
 CONSTRAINT [PK_yoneticiler] PRIMARY KEY CLUSTERED 
(
	[y_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [apartmanyonetimi] SET  READ_WRITE 
GO
