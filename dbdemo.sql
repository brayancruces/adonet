USE [master]
GO
/****** Object:  Database [dbdemo]    Script Date: 26/03/2018 10:44:39 p.m. ******/
CREATE DATABASE [dbdemo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbdemo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbdemo.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbdemo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\dbdemo_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbdemo] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbdemo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbdemo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbdemo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbdemo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbdemo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbdemo] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbdemo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbdemo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbdemo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbdemo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbdemo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbdemo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbdemo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbdemo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbdemo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbdemo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbdemo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbdemo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbdemo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbdemo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbdemo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbdemo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbdemo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbdemo] SET RECOVERY FULL 
GO
ALTER DATABASE [dbdemo] SET  MULTI_USER 
GO
ALTER DATABASE [dbdemo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbdemo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbdemo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbdemo] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [dbdemo] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbdemo', N'ON'
GO
USE [dbdemo]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 26/03/2018 10:44:39 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[producto] [varchar](45) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_addventa]    Script Date: 26/03/2018 10:44:39 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_addventa]
	-- Add the parameters for the stored procedure here
	@producto varchar(45),
	@cantidad int	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO Venta VALUES(@producto,@cantidad);
END

GO
USE [master]
GO
ALTER DATABASE [dbdemo] SET  READ_WRITE 
GO
