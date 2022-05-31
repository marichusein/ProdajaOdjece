USE [master]
GO

/****** Object:  Database [maturskirad]    Script Date: 5/31/2022 9:20:14 PM ******/
CREATE DATABASE [maturskirad]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'maturskirad', FILENAME = N'D:\sqql\MSSQL14.MSSQLSERVER\MSSQL\DATA\maturskirad.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'maturskirad_log', FILENAME = N'D:\sqql\MSSQL14.MSSQLSERVER\MSSQL\DATA\maturskirad_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [maturskirad].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [maturskirad] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [maturskirad] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [maturskirad] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [maturskirad] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [maturskirad] SET ARITHABORT OFF 
GO

ALTER DATABASE [maturskirad] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [maturskirad] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [maturskirad] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [maturskirad] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [maturskirad] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [maturskirad] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [maturskirad] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [maturskirad] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [maturskirad] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [maturskirad] SET  ENABLE_BROKER 
GO

ALTER DATABASE [maturskirad] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [maturskirad] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [maturskirad] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [maturskirad] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [maturskirad] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [maturskirad] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [maturskirad] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [maturskirad] SET RECOVERY FULL 
GO

ALTER DATABASE [maturskirad] SET  MULTI_USER 
GO

ALTER DATABASE [maturskirad] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [maturskirad] SET DB_CHAINING OFF 
GO

ALTER DATABASE [maturskirad] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [maturskirad] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [maturskirad] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [maturskirad] SET QUERY_STORE = OFF
GO

ALTER DATABASE [maturskirad] SET  READ_WRITE 
GO

