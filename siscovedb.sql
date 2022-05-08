USE [master]
GO

/****** Object:  Database [siscovedb]    Script Date: 4/1/2021 09:56:00 ******/
CREATE DATABASE [siscovedb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SISCOVEDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\SISCOVEDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SISCOVEDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\SISCOVEDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [siscovedb] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [siscovedb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [siscovedb] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [siscovedb] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [siscovedb] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [siscovedb] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [siscovedb] SET ARITHABORT OFF 
GO

ALTER DATABASE [siscovedb] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [siscovedb] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [siscovedb] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [siscovedb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [siscovedb] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [siscovedb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [siscovedb] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [siscovedb] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [siscovedb] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [siscovedb] SET  ENABLE_BROKER 
GO

ALTER DATABASE [siscovedb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [siscovedb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [siscovedb] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [siscovedb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [siscovedb] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [siscovedb] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [siscovedb] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [siscovedb] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [siscovedb] SET  MULTI_USER 
GO

ALTER DATABASE [siscovedb] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [siscovedb] SET DB_CHAINING OFF 
GO

ALTER DATABASE [siscovedb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [siscovedb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [siscovedb] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [siscovedb] SET QUERY_STORE = OFF
GO

USE [siscovedb]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [siscovedb] SET  READ_WRITE 
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[customers]    Script Date: 4/1/2021 10:00:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[customers](
	[id_customer] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NULL,
	[ci] [nvarchar](50) NULL,
	[info] [nvarchar](max) NULL,
	[ruc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_customer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[distributors]    Script Date: 4/1/2021 10:00:49 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[distributors](
	[id_distributor] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[info] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_distributor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[prices_sale]    Script Date: 4/1/2021 10:01:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[prices_sale](
	[id_price] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NULL,
	[info] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_price] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

ALTER TABLE [dbo].[prices_sale]  WITH CHECK ADD FOREIGN KEY([id_product])
REFERENCES [dbo].[products] ([id_product])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[products]    Script Date: 4/1/2021 10:03:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[products](
	[id_product] [int] IDENTITY(1,1) NOT NULL,
	[description] [nvarchar](100) NOT NULL,
	[comment] [nvarchar](max) NULL,
	[quantity] [int] NOT NULL,
	[date] [date] NOT NULL,
	[bool_count] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[purchases]    Script Date: 4/1/2021 10:03:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[purchases](
	[id_purchase] [int] IDENTITY(1,1) NOT NULL,
	[id_purchase_info] [int] NOT NULL,
	[id_product] [int] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
	[bool] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_purchase] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[purchases]  WITH CHECK ADD FOREIGN KEY([id_product])
REFERENCES [dbo].[products] ([id_product])
GO

ALTER TABLE [dbo].[purchases]  WITH CHECK ADD FOREIGN KEY([id_purchase_info])
REFERENCES [dbo].[purchases_info] ([id_purchase_info])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[purchases_info]    Script Date: 4/1/2021 10:03:44 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[purchases_info](
	[id_purchase_info] [int] IDENTITY(1,1) NOT NULL,
	[id_distributor] [int] NOT NULL,
	[date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_purchase_info] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[purchases_info]  WITH CHECK ADD FOREIGN KEY([id_distributor])
REFERENCES [dbo].[distributors] ([id_distributor])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[sales]    Script Date: 4/1/2021 10:04:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sales](
	[id_sale] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NOT NULL,
	[id_sale_info] [int] NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
	[bool] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sale] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[sales]  WITH CHECK ADD FOREIGN KEY([id_product])
REFERENCES [dbo].[products] ([id_product])
GO

ALTER TABLE [dbo].[sales]  WITH CHECK ADD FOREIGN KEY([id_sale_info])
REFERENCES [dbo].[sales_info] ([id_sale_info])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[sales_info]    Script Date: 4/1/2021 10:04:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[sales_info](
	[id_sale_info] [int] IDENTITY(1,1) NOT NULL,
	[date] [date] NOT NULL,
	[impress] [bit] NOT NULL,
	[id_customer] [int] NOT NULL,
	[state] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sale_info] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[sales_info]  WITH CHECK ADD FOREIGN KEY([id_customer])
REFERENCES [dbo].[customers] ([id_customer])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[tel]    Script Date: 4/1/2021 10:04:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tel](
	[id_tel] [int] IDENTITY(1,1) NOT NULL,
	[id_cust_dist] [int] NOT NULL,
	[tel] [nvarchar](50) NOT NULL,
	[cust_dist] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[units]    Script Date: 4/1/2021 10:04:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[units](
	[id_unity] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_unity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[units_product]    Script Date: 4/1/2021 10:05:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[units_product](
	[id_unity_product] [int] IDENTITY(1,1) NOT NULL,
	[id_product] [int] NOT NULL,
	[id_unity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_unity_product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[units_product]  WITH CHECK ADD FOREIGN KEY([id_product])
REFERENCES [dbo].[products] ([id_product])
GO

ALTER TABLE [dbo].[units_product]  WITH CHECK ADD FOREIGN KEY([id_unity])
REFERENCES [dbo].[units] ([id_unity])
GO

USE [siscovedb]
GO

/****** Object:  Table [dbo].[users]    Script Date: 4/1/2021 10:05:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[users](
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[level] [int] NOT NULL,
	[password] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

