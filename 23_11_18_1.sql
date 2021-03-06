USE [master]
GO
/****** Object:  Database [Platez_prowel]    Script Date: 23.11.2018 13:25:31 ******/
CREATE DATABASE [Platez_prowel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Platez_prowel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Platez_prowel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Platez_prowel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Platez_prowel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Platez_prowel] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Platez_prowel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Platez_prowel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Platez_prowel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Platez_prowel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Platez_prowel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Platez_prowel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Platez_prowel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Platez_prowel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Platez_prowel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Platez_prowel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Platez_prowel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Platez_prowel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Platez_prowel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Platez_prowel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Platez_prowel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Platez_prowel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Platez_prowel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Platez_prowel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Platez_prowel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Platez_prowel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Platez_prowel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Platez_prowel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Platez_prowel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Platez_prowel] SET RECOVERY FULL 
GO
ALTER DATABASE [Platez_prowel] SET  MULTI_USER 
GO
ALTER DATABASE [Platez_prowel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Platez_prowel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Platez_prowel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Platez_prowel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Platez_prowel] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Platez_prowel', N'ON'
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Waiter]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Waiter] WITH PASSWORD=N'Mzp0tsZkRjM9lMmv7+oCcmNCAVKxeMHmGLtqpGSQ9Bg=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Waiter] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Vasilenco]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Vasilenco] WITH PASSWORD=N'vE4v0c0f1D9KLmxjYWyo6RrIJlJ73pn4FWnqYZU4As8=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Vasilenco] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [test]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [test] WITH PASSWORD=N'vztpkaYJhUXaEfcUZthCFIMVPwhpo8AkI0SZvb8UVFU=', DEFAULT_DATABASE=[Platez_prowel], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [test] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Restorator]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Restorator] WITH PASSWORD=N'iT0Vdlsl2pBnb9J6aJks3SmdNu/hamEiBV1HNcPrUls=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Restorator] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Operator]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Operator] WITH PASSWORD=N'Y2sFX+OabJeV3/I7o/EPSVsR6q9X1PxF3WKCFzKpp9s=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Operator] DISABLE
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT SERVICE\SQLTELEMETRY]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT SERVICE\SQLTELEMETRY] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT SERVICE\SQLSERVERAGENT]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT SERVICE\SQLSERVERAGENT] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT Service\MSSQLSERVER]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT Service\MSSQLSERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT Service\MSSQL$SQLEXPRESS]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT Service\MSSQL$SQLEXPRESS] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT AUTHORITY\СИСТЕМА]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT AUTHORITY\СИСТЕМА] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT AUTHORITY\NETWORK SERVICE]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT AUTHORITY\NETWORK SERVICE] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [NT AUTHORITY\LOCAL SERVICE]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [NT AUTHORITY\LOCAL SERVICE] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Lazarkov]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Lazarkov] WITH PASSWORD=N'7ZOwOybdj64Okci/cicpJOoK2HooHhZHsojOhV5Spdk=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Lazarkov] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Kuznetsov]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Kuznetsov] WITH PASSWORD=N'ME3LGDAcfiqAM/N8hafyEa+bs0Yo+A6iRQiUsWSM+RU=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Kuznetsov] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Konteenco]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Konteenco] WITH PASSWORD=N'mM/bMhi0sUQJ2HNDg0zq3Di6mD/P428XBeWmtLievrU=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Konteenco] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [GHL_admin]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [GHL_admin] WITH PASSWORD=N'zm3PT3J9OkVbfkjaM9NzsMKSSb8vqQN1Zev4iKqafGI=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [GHL_admin] DISABLE
GO
/****** Object:  Login [BUILTIN\Пользователи]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [BUILTIN\Пользователи] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/****** Object:  Login [BUILTIN\Администраторы]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [BUILTIN\Администраторы] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Boico]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Boico] WITH PASSWORD=N'NyZ6U3UF/ozRe9adKonA3KD0lYcBSr3IQ+LwxxsHxtc=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Boico] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [asdasdasd]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [asdasdasd] WITH PASSWORD=N'QrlWFYdODoAEg2jDSeWXT6Jgv9BwmUHkU503aDirHIU=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [asdasdasd] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [asd123]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [asd123] WITH PASSWORD=N'zxrHcVKN7GoVsSOGULPhW8LiII2n9io/gVVNL8wk4Ws=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [asd123] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Ann]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Ann] WITH PASSWORD=N'8UavRouXzdNs1FB6oe/59ARrudK9h6D2K4bEVCHdrgc=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [Ann] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [Administrator]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [Administrator] WITH PASSWORD=N'ViqBgNcQjkUfnycKDezzoFLEUvZCIePGClsGxrN/Rq0=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [Administrator] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [123]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [123] WITH PASSWORD=N'k7jBDnwMd30ahzNXbkHYNNN1iiHEXAEVZLaKf8cZNag=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[русский], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [123] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'khWmjQ7Xr+YugaNxfpYuvmEb4UCRnVc9lz9jgPuwXxU=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'JLD2RpoeiYBbJ0bp1bwMowYulJyRH9UDBmQDEEY0d6Y=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
/****** Object:  Login [l_certSignSmDetach]    Script Date: 23.11.2018 13:25:31 ******/
CREATE LOGIN [l_certSignSmDetach] FROM CERTIFICATE [_##PDW_SmDetachSigningCertificate##]
GO
ALTER AUTHORIZATION ON DATABASE::[Platez_prowel] TO [sa]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Vasilenco]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [test]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLSERVERAGENT]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQLSERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SQLEXPRESS]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Lazarkov]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Kuznetsov]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Konteenco]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [BUILTIN\Администраторы]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Boico]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Ann]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [l_certSignSmDetach]
GO
USE [Platez_prowel]
GO
/****** Object:  User [Vasilenco]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Vasilenco] FOR LOGIN [Vasilenco] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Test]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Test] FOR LOGIN [test] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Lazarkov]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Lazarkov] FOR LOGIN [Lazarkov] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Kuznetsov]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Kuznetsov] FOR LOGIN [Kuznetsov] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Konteenco]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Konteenco] FOR LOGIN [Konteenco] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Boico]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Boico] FOR LOGIN [Boico] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [Ann]    Script Date: 23.11.2018 13:25:31 ******/
CREATE USER [Ann] FOR LOGIN [Ann] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id_category] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[id_category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Category] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Paymont]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paymont](
	[id_platez] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [float] NULL,
	[Cost] [float] NULL,
	[Date] [date] NULL,
	[id_user] [int] NULL,
	[id_category] [int] NULL,
 CONSTRAINT [PK_Paymont] PRIMARY KEY CLUSTERED 
(
	[id_platez] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Paymont] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Paymount_Changes]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paymount_Changes](
	[id_platez] [int] NOT NULL,
	[Name] [varchar](50) NULL,
	[Quantity] [int] NULL,
	[Price] [float] NULL,
	[Cost] [float] NULL,
	[Date] [date] NULL,
	[id_user] [int] NULL,
	[id_category] [int] NULL,
	[date_update] [datetime] NULL,
	[Action] [nvarchar](50) NULL
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Changes] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[FIO] [varchar](max) NULL,
	[Login] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[Pin_Code] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Users] TO  SCHEMA OWNER 
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([id_category], [Name]) VALUES (1, N'Автомобиль')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (2, N'Коммунальные платежи')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (3, N'Медицина')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (4, N'Питание')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (5, N'Разное')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (6, N'Быт')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (7, N'Колледж')
INSERT [dbo].[Category] ([id_category], [Name]) VALUES (8, N'Тест')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Paymont] ON 

INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (178, N'Бензин', 3, 2238, 6714, CAST(N'2015-11-18' AS Date), 1, 1)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (179, N'Взнос за гараж', 1, 5000, 5000, CAST(N'2015-11-03' AS Date), 2, 1)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (180, N'Водоснабжение', 1, 16.41, 16.41, CAST(N'2015-11-04' AS Date), 3, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (181, N'Газоснабжение', 1, 3120, 3120, CAST(N'2015-11-05' AS Date), 4, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (182, N'Интернет', 1, 450, 450, CAST(N'2015-11-16' AS Date), 5, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (183, N'Квартплата', 1, 2964.58, 2964.58, CAST(N'2015-11-09' AS Date), 6, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (184, N'Мобильный', 1, 300, 300, CAST(N'2015-11-12' AS Date), 7, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (185, N'Сбор на кафедру', 1, 500, 500, CAST(N'2015-11-17' AS Date), 1, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (186, N'Телефон', 1, 170, 170, CAST(N'2015-11-20' AS Date), 1, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (187, N'Электроэнергия', 1, 184, 184, CAST(N'2015-11-06' AS Date), 4, 2)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (188, N'Анализы общие', 1, 280, 280, CAST(N'2015-11-02' AS Date), 2, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (189, N'Анализы специальные', 1, 1740, 1740, CAST(N'2015-11-27' AS Date), 1, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (190, N'Контейнер для анализов', 2, 20, 40, CAST(N'2015-11-02' AS Date), 6, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (191, N'Магнелис', 1, 202.4, 202.4, CAST(N'2015-11-23' AS Date), 7, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (192, N'Наринэ', 1, 449.5, 449.5, CAST(N'2015-11-24' AS Date), 1, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (193, N'Прием врача', 1, 220, 220, CAST(N'2015-11-25' AS Date), 6, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (194, N'Прием врача', 1, 330, 330, CAST(N'2015-11-27' AS Date), 4, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (195, N'Прием врача', 1, 400, 400, CAST(N'2015-11-19' AS Date), 4, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (196, N'Прием врача', 1, 400, 400, CAST(N'2015-11-18' AS Date), 2, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (197, N'Прием врача', 1, 450, 450, CAST(N'2015-11-11' AS Date), 3, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (198, N'Прием врача', 1, 800, 800, CAST(N'2015-11-27' AS Date), 5, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (199, N'ЭКГ', 1, 455, 455, CAST(N'2015-11-17' AS Date), 1, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (200, N'Юниспорт', 1, 3500, 3500, CAST(N'2015-11-24' AS Date), 6, 3)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (201, N'Булочки и тесто', 3, 240, 720, CAST(N'2015-11-22' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (202, N'Еда', 1, 24, 24, CAST(N'2015-11-30' AS Date), 5, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (203, N'Еда', 1, 80, 80, CAST(N'2015-11-21' AS Date), 2, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (204, N'Еда', 1, 81, 81, CAST(N'2015-11-28' AS Date), 3, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (205, N'Еда', 1, 82, 82, CAST(N'2015-11-29' AS Date), 3, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (206, N'Еда', 1, 127.82, 127.82, CAST(N'2015-11-13' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (207, N'Еда', 1, 137.18, 137.18, CAST(N'2015-11-26' AS Date), 1, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (208, N'Еда', 1, 138.73, 138.73, CAST(N'2015-11-08' AS Date), 6, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (209, N'Еда', 2, 144.75, 289.5, CAST(N'2015-11-04' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (210, N'Еда', 4, 159.2, 636.8, CAST(N'2015-11-01' AS Date), 2, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (211, N'Еда', 1, 195.39, 195.39, CAST(N'2015-11-28' AS Date), 3, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (212, N'Еда', 1, 213.31, 213.31, CAST(N'2015-11-26' AS Date), 5, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (213, N'Еда', 1, 258.84, 258.84, CAST(N'2015-11-21' AS Date), 3, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (214, N'Еда', 1, 261.21, 261.21, CAST(N'2015-11-21' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (215, N'Макароны', 3, 33, 99, CAST(N'2015-11-14' AS Date), 1, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (216, N'Семечки', 5, 35, 175, CAST(N'2015-11-07' AS Date), 6, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (217, N'Сметана', 2, 45, 90, CAST(N'2015-11-13' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (218, N'Столовая завтрак', 1, 19.42, 19.42, CAST(N'2015-11-16' AS Date), 1, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (219, N'Столовая ', 2, 58.86, 117.72, CAST(N'2015-11-09' AS Date), 6, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (220, N'Столовая', 1, 119.93, 119.93, CAST(N'2015-11-17' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (221, N'Столовая', 1, 127.66, 127.66, CAST(N'2015-11-20' AS Date), 2, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (222, N'Творог и сметана', 2, 94.96, 189.92, CAST(N'2015-11-22' AS Date), 3, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (223, N'Томатный сок', 2, 15, 30, CAST(N'2015-11-21' AS Date), 5, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (224, N'Хачапури и морс', 4, 82, 328, CAST(N'2015-11-07' AS Date), 4, 4)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (225, N'CD', 6, 165, 990, CAST(N'2015-11-10' AS Date), 2, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (226, N'Гипермаркет', 1, 2484, 2484, CAST(N'2015-11-07' AS Date), 3, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (227, N'Гипермаркет', 1, 3726, 3726, CAST(N'2015-11-14' AS Date), 5, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (228, N'Диски, кейс, стяжки', 5, 933, 4665, CAST(N'2015-11-16' AS Date), 1, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (229, N'Маникюр', 1, 550, 550, CAST(N'2015-11-28' AS Date), 6, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (230, N'Маркеры', 3, 120, 360, CAST(N'2015-11-29' AS Date), 7, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (231, N'Одежда', 1, 2871.84, 2871.84, CAST(N'2015-11-22' AS Date), 1, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (232, N'Плавательный набор', 1, 1040, 1040, CAST(N'2015-11-08' AS Date), 1, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (233, N'Туфли', 1, 699, 699, CAST(N'2015-11-21' AS Date), 2, 5)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (234, N'Губка для обуви', 2, 40, 80, CAST(N'2015-11-17' AS Date), 3, 6)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (235, N'Термометр для ванн', 1, 152.5, 152.5, CAST(N'2015-11-24' AS Date), 4, 6)
INSERT [dbo].[Paymont] ([id_platez], [Name], [Quantity], [Price], [Cost], [Date], [id_user], [id_category]) VALUES (236, N'Ушивание брюк', 1, 150, 150, CAST(N'2015-11-19' AS Date), 4, 6)
SET IDENTITY_INSERT [dbo].[Paymont] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (1, N'Бойко Игорь Петрович', N'Boico', N'aut_aliasg', 6039)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (2, N'Василенко Василий Александрович', N'Vasilenco', N'qwerty', 8797)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (3, N'Контеенко Дмитрий Семенович', N'Konteenco', N'placeat1972l', 1961)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (4, N'Лазарьков Петр Михайлович', N'Lazarkov', N'equam442', 4842)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (5, N'Кузнецов Василий Семенович', N'Kuznetsov', N'libero%88f', 8720)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (6, N'Дорофеева Анна Геннадьевна', N'Test', N'12345', 9812)
INSERT [dbo].[Users] ([id_user], [FIO], [Login], [Password], [Pin_Code]) VALUES (7, N'Прокопьева Елена Петровна', N'Ann', N'porro_autu', 9553)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Paymont]  WITH CHECK ADD  CONSTRAINT [FK_Paymont_Category] FOREIGN KEY([id_category])
REFERENCES [dbo].[Category] ([id_category])
GO
ALTER TABLE [dbo].[Paymont] CHECK CONSTRAINT [FK_Paymont_Category]
GO
ALTER TABLE [dbo].[Paymont]  WITH CHECK ADD  CONSTRAINT [FK_Paymont_Users] FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Paymont] CHECK CONSTRAINT [FK_Paymont_Users]
GO
/****** Object:  StoredProcedure [dbo].[Category_Delete]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Category_Delete] (@id_category int )
As
Begin
	SET NOCOUNT ON
	Delete From Category Where id_category = @id_category
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Category_Delete] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Category_Insert]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Category_Insert](@Name nvarchar(50))
AS
Begin
	SET NOCOUNT ON
	Insert into Category (Name) Values (@Name)
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Category_Insert] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Category_Select]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Category_Select] (@id_category int = null)
As
Begin
	SET NOCOUNT ON
	Select c.id_category as 'ID', c.Name as Наименование
	From Category c
	Where @id_category Is null or c.id_category=@id_category
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Category_Select] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Category_Update]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Category_Update] (@id_category int, @Name nvarchar(50))
As
Begin
	SET NOCOUNT ON
	Update Category
	Set Name = @Name
	Where id_category=@id_category
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Category_Update] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Delete]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Paymount_Delete] (@id_platej int)
As
Begin
	SET NOCOUNT ON
	Delete From Paymont
	Where id_platez = @id_platej
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Delete] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Full_Search]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Paymount_Full_Search]
(@id_user int,
@id_category int,
@sPeriod date,
@ePeriod date)
As
Begin
	SET NOCOUNT ON
	Select p.Name as 'Наименование платежа', p.Quantity as Количество, p.Price as Цена, p.Cost as Сумма, c.Name as Категория, p.Date as 'Дата платежа'
	From Paymont p Inner Join Category c On c.id_category = p.id_category
	Where p.Date BETWEEN @sPeriod AND @ePeriod AND p.id_category = @id_category AND p.id_user = @id_user
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Full_Search] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Insert]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Paymount_Insert] 
(@Name nvarchar(50),
@Kolvo int,
@Price float,
@id_user int,
@id_category int)
As
Begin
	SET NOCOUNT ON
	Insert into Paymont(Name,Quantity,Price,id_user,id_category)
	Values (@Name,@Kolvo,@Price,@id_user,@id_category)
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Insert] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Period]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Paymount_Period]
(@id_user int,
@sPeriod date,
@ePeriod date)
As
Begin
	SET NOCOUNT ON
	Select p.Name as 'Наименование платежа', p.Quantity as Количество, p.Price as Цена, p.Cost as Сумма, c.Name as Категория, p.Date as 'Дата платежа'
	From Paymont p Inner Join Category c On c.id_category = p.id_category
	Where p.Date BETWEEN @sPeriod AND @ePeriod AND p.id_user = @id_user
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Period] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Search]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Paymount_Search](@id_user int, @id_category int)
AS
Begin
	SET NOCOUNT ON
	Select p.Name as 'Наименование платежа', p.Quantity as Количество, p.Price as Цена, p.Cost as Сумма, c.Name as Категория, p.Date as 'Дата платежа'
	From Paymont p Inner Join Category c On c.id_category = p.id_category
	Where p.id_category = @id_category AND p.id_user = @id_user
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Search] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Select]    Script Date: 23.11.2018 13:25:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[Paymount_Select] (@id_user int = null)
As
Begin
	SET NOCOUNT ON
	Select p.id_platez as 'ID', p.Name as 'Наименование платежа', p.Quantity as Количество, p.Price as Цена, p.Cost as Сумма, c.Name as Категория, p.Date as 'Дата платежа'
	From Paymont p Inner Join Category c On c.id_category = p.id_category
	Where @id_user IS NULL OR p.id_user = @id_user
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Select] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Paymount_Update]    Script Date: 23.11.2018 13:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Paymount_Update](
@id_platej int,
@Name nvarchar(50),
@Kolvo int,
@Price float,
@Cost float,
@Date date,
@id_user int,
@id_category int)
AS
Begin
	SET NOCOUNT ON
	Update Paymont
	Set Name = @Name, Quantity = @Kolvo, Price = @Price, Cost = @Cost, Date = @Date, id_user = @id_user, id_category = @id_category
	Where id_platez = @id_platej
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Paymount_Update] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Users_Select]    Script Date: 23.11.2018 13:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Users_Select]
AS
Begin
	SET NOCOUNT ON
	Select Login as 'Имя пользователя'
	From Users
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Users_Select] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[Users_Update]    Script Date: 23.11.2018 13:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[Users_Update](
@id_user int,
@Password nvarchar(50),
@Pin_kod int
)
AS
Begin
	SET NOCOUNT ON
	Update Users
	Set Password = @Password, Pin_Code = @Pin_kod
	Where id_user = @id_user
	Return @@ERROR
End

GO
ALTER AUTHORIZATION ON [dbo].[Users_Update] TO  SCHEMA OWNER 
GO
/****** Object:  Trigger [dbo].[Paymount_Cost]    Script Date: 23.11.2018 13:25:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[Paymount_Cost]
   ON  [dbo].[Paymont]
   AFTER INSERT,UPDATE
AS 
BEGIN
	SET NOCOUNT ON;
	Update Paymont
	Set Cost = (Quantity*Price)
	Where id_platez = (select i.id_platez from inserted i)
END
GO
ALTER TABLE [dbo].[Paymont] ENABLE TRIGGER [Paymount_Cost]
GO
USE [master]
GO
ALTER DATABASE [Platez_prowel] SET  READ_WRITE 
GO
