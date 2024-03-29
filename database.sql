USE [master]
GO
/****** Object:  Database [libraryManagement]    Script Date: 2.01.2023 19:22:11 ******/
CREATE DATABASE [libraryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'libraryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\libraryManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'libraryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\libraryManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [libraryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [libraryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [libraryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [libraryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [libraryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [libraryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [libraryManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [libraryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [libraryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [libraryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [libraryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [libraryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [libraryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [libraryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [libraryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [libraryManagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [libraryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [libraryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [libraryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [libraryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [libraryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [libraryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [libraryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [libraryManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [libraryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [libraryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [libraryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [libraryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [libraryManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [libraryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'libraryManagement', N'ON'
GO
ALTER DATABASE [libraryManagement] SET QUERY_STORE = OFF
GO
USE [libraryManagement]
GO
/****** Object:  Table [dbo].[admins]    Script Date: 2.01.2023 19:22:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[admins](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 2.01.2023 19:22:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[AuthorName] [nvarchar](100) NOT NULL,
	[Kind] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_books] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[booktransfer]    Script Date: 2.01.2023 19:22:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[booktransfer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[BookGiven] [date] NOT NULL,
	[isReturned] [bit] NOT NULL,
 CONSTRAINT [PK_booktransfer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[studentLogin]    Script Date: 2.01.2023 19:22:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentLogin](
	[StudentID] [int] NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_studentLogin] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[students]    Script Date: 2.01.2023 19:22:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[Gender] [bit] NOT NULL,
 CONSTRAINT [PK_students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[admins] ([Username], [Password]) VALUES (N'admin', N'YLzkGPkb3/fTJspJVZyJOg==')
GO
SET IDENTITY_INSERT [dbo].[books] ON 
GO
INSERT [dbo].[books] ([ID], [Name], [AuthorName], [Kind]) VALUES (1, N'1984', N'George Orwell', N'Novel')
GO
INSERT [dbo].[books] ([ID], [Name], [AuthorName], [Kind]) VALUES (2, N'Chess', N'Stefan Zweig', N'Novel')
GO
INSERT [dbo].[books] ([ID], [Name], [AuthorName], [Kind]) VALUES (3, N'The Adventures of Tom Sawyer', N'Mark Twain', N'Novel')
GO
INSERT [dbo].[books] ([ID], [Name], [AuthorName], [Kind]) VALUES (4, N'Crime and Punishment', N'Fyodor Dostoevsky', N'Novel')
GO
SET IDENTITY_INSERT [dbo].[books] OFF
GO
SET IDENTITY_INSERT [dbo].[booktransfer] ON 
GO
INSERT [dbo].[booktransfer] ([ID], [BookID], [StudentID], [BookGiven], [isReturned]) VALUES (1, 3, 1, CAST(N'2023-01-02' AS Date), 1)
GO
INSERT [dbo].[booktransfer] ([ID], [BookID], [StudentID], [BookGiven], [isReturned]) VALUES (2, 1, 1, CAST(N'2023-01-02' AS Date), 0)
GO
INSERT [dbo].[booktransfer] ([ID], [BookID], [StudentID], [BookGiven], [isReturned]) VALUES (3, 4, 2, CAST(N'2023-01-02' AS Date), 0)
GO
INSERT [dbo].[booktransfer] ([ID], [BookID], [StudentID], [BookGiven], [isReturned]) VALUES (4, 2, 3, CAST(N'2023-01-02' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[booktransfer] OFF
GO
INSERT [dbo].[studentLogin] ([StudentID], [Username], [Password]) VALUES (1, N'kadirugurlu', N'kFrojTvc7OTcxYKchsMAhw==')
GO
INSERT [dbo].[studentLogin] ([StudentID], [Username], [Password]) VALUES (2, N'silanurciftci', N'kBrpx+RZjPP8WTI5zlVGrw==')
GO
INSERT [dbo].[studentLogin] ([StudentID], [Username], [Password]) VALUES (3, N'mmertugurlu', N'Gf5B1yrZznpn47zzAhO/cw==')
GO
SET IDENTITY_INSERT [dbo].[students] ON 
GO
INSERT [dbo].[students] ([ID], [Name], [Surname], [DOB], [Gender]) VALUES (1, N'Kadir', N'Uğurlu', CAST(N'2002-06-17' AS Date), 1)
GO
INSERT [dbo].[students] ([ID], [Name], [Surname], [DOB], [Gender]) VALUES (2, N'Sılanur', N'Çiftci', CAST(N'2002-01-07' AS Date), 0)
GO
INSERT [dbo].[students] ([ID], [Name], [Surname], [DOB], [Gender]) VALUES (3, N'Muhammed Mert', N'Uğurlu', CAST(N'2003-12-25' AS Date), 1)
GO
SET IDENTITY_INSERT [dbo].[students] OFF
GO
ALTER TABLE [dbo].[booktransfer]  WITH CHECK ADD  CONSTRAINT [FK_booktransfer_books] FOREIGN KEY([BookID])
REFERENCES [dbo].[books] ([ID])
GO
ALTER TABLE [dbo].[booktransfer] CHECK CONSTRAINT [FK_booktransfer_books]
GO
ALTER TABLE [dbo].[booktransfer]  WITH CHECK ADD  CONSTRAINT [FK_booktransfer_students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[students] ([ID])
GO
ALTER TABLE [dbo].[booktransfer] CHECK CONSTRAINT [FK_booktransfer_students]
GO
ALTER TABLE [dbo].[studentLogin]  WITH CHECK ADD  CONSTRAINT [FK_studentLogin_students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[students] ([ID])
GO
ALTER TABLE [dbo].[studentLogin] CHECK CONSTRAINT [FK_studentLogin_students]
GO
USE [master]
GO
ALTER DATABASE [libraryManagement] SET  READ_WRITE 
GO
