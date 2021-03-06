USE [master]
GO
/****** Object:  Database [SentechDB]    Script Date: 11/21/2015 02:04:50 ******/
CREATE DATABASE [SentechDB] ON  PRIMARY 
( NAME = N'SentechDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SentechDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SentechDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\SentechDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SentechDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SentechDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SentechDB] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [SentechDB] SET ANSI_NULLS OFF
GO
ALTER DATABASE [SentechDB] SET ANSI_PADDING OFF
GO
ALTER DATABASE [SentechDB] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [SentechDB] SET ARITHABORT OFF
GO
ALTER DATABASE [SentechDB] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [SentechDB] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [SentechDB] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [SentechDB] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [SentechDB] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [SentechDB] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [SentechDB] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [SentechDB] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [SentechDB] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [SentechDB] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [SentechDB] SET  DISABLE_BROKER
GO
ALTER DATABASE [SentechDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [SentechDB] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [SentechDB] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [SentechDB] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [SentechDB] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [SentechDB] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [SentechDB] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [SentechDB] SET  READ_WRITE
GO
ALTER DATABASE [SentechDB] SET RECOVERY SIMPLE
GO
ALTER DATABASE [SentechDB] SET  MULTI_USER
GO
ALTER DATABASE [SentechDB] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [SentechDB] SET DB_CHAINING OFF
GO
USE [SentechDB]
GO
/****** Object:  StoredProcedure [dbo].[ContactList]    Script Date: 11/21/2015 02:05:08 ******/
DROP PROCEDURE [dbo].[ContactList]
GO
/****** Object:  StoredProcedure [dbo].[GetAddEditContact]    Script Date: 11/21/2015 02:05:08 ******/
DROP PROCEDURE [dbo].[GetAddEditContact]
GO
/****** Object:  Table [dbo].[OrganaizationDetails]    Script Date: 11/21/2015 02:04:56 ******/
ALTER TABLE [dbo].[OrganaizationDetails] DROP CONSTRAINT [DF_OrganaizationDetails_Status]
GO
DROP TABLE [dbo].[OrganaizationDetails]
GO
/****** Object:  Table [dbo].[PostionMaster]    Script Date: 11/21/2015 02:04:56 ******/
ALTER TABLE [dbo].[PostionMaster] DROP CONSTRAINT [DF_PostionMaster_IsActive]
GO
DROP TABLE [dbo].[PostionMaster]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 11/21/2015 02:04:56 ******/
ALTER TABLE [dbo].[UserInfo] DROP CONSTRAINT [DF_UserInfo_URole]
GO
DROP TABLE [dbo].[UserInfo]
GO
/****** Object:  Table [dbo].[DomainMaster]    Script Date: 11/21/2015 02:04:55 ******/
ALTER TABLE [dbo].[DomainMaster] DROP CONSTRAINT [DF_DomainMaster_IsActive]
GO
DROP TABLE [dbo].[DomainMaster]
GO
/****** Object:  Table [dbo].[CallStatusMaster]    Script Date: 11/21/2015 02:04:55 ******/
DROP TABLE [dbo].[CallStatusMaster]
GO
/****** Object:  Table [dbo].[ChatHistory]    Script Date: 11/21/2015 02:04:55 ******/
ALTER TABLE [dbo].[ChatHistory] DROP CONSTRAINT [DF_ChatHistory_TalkedOn]
GO
DROP TABLE [dbo].[ChatHistory]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 11/21/2015 02:04:55 ******/
ALTER TABLE [dbo].[ContactDetails] DROP CONSTRAINT [DF_ContactDetails_InAction]
GO
DROP TABLE [dbo].[ContactDetails]
GO
/****** Object:  User [SentecUser]    Script Date: 11/21/2015 02:04:50 ******/
DROP USER [SentecUser]
GO
/****** Object:  User [SentecUser]    Script Date: 11/21/2015 02:04:50 ******/
CREATE USER [SentecUser] FOR LOGIN [SentecUser] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 11/21/2015 02:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[ContactId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrganizationId] [bigint] NOT NULL,
	[CntName] [varchar](500) NOT NULL,
	[PositionId] [int] NULL,
	[EmailId] [varchar](500) NULL,
	[ContNumber] [varchar](500) NULL,
	[InAction] [bit] NOT NULL CONSTRAINT [DF_ContactDetails_InAction]  DEFAULT ((0)),
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ContactDetails] ON
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (1, 1, N'asdf', 1, N'asdf', N'asdf', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (2, 1, N'fffff', 2, N'ggggggg', N'123123', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (3, 10, N'sadf', NULL, NULL, NULL, 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (4, 11, N'asdf', 2, N'asdf', N'asdf', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (5, 13, N'sdf', NULL, NULL, NULL, 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (6, 1, N'pqr', 2, N'aSD', N'44444', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (7, 2, N'ASDF', 2, N'SDAF', N'ASDF', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (8, 28, N'asdf', 3, N'asdf', N'asd', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (9, 22, N'asdf', 1, N'asdf', N'asdf', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (10, 29, N'talked with', 1, N'asdf', N'asdf', 0)
INSERT [dbo].[ContactDetails] ([ContactId], [OrganizationId], [CntName], [PositionId], [EmailId], [ContNumber], [InAction]) VALUES (11, 15, N'asdf', 2, N'sdaf', N'asdf', 0)
SET IDENTITY_INSERT [dbo].[ContactDetails] OFF
/****** Object:  Table [dbo].[ChatHistory]    Script Date: 11/21/2015 02:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ChatHistory](
	[ContactId] [bigint] NOT NULL,
	[TalkedOn] [varchar](500) NOT NULL CONSTRAINT [DF_ChatHistory_TalkedOn]  DEFAULT (getdate()),
	[FeedBack] [varchar](max) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (1, N'Nov 20 2015  7:40PM', N'test feedback')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (1, N'Nov 20 2015  7:41PM', N'test feedback')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (2, N'Nov 20 2015  7:47PM', N'xya feedback')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (1, N'Nov 21 2015 12:17AM', N'asdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (7, N'Nov 21 2015 12:21AM', N'sdfg')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (7, N'Nov 21 2015 12:21AM', N'sdfg')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (4, N'Nov 21 2015  1:53AM', N'sdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (1, N'Nov 21 2015  1:53AM', N'asdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (8, N'Nov 21 2015 12:32AM', N'asdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (9, N'Nov 21 2015 12:41AM', N'asdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (8, N'Nov 21 2015 12:51AM', N'ffff')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (10, N'Nov 21 2015  1:11AM', N'asdf')
INSERT [dbo].[ChatHistory] ([ContactId], [TalkedOn], [FeedBack]) VALUES (1, N'Nov 21 2015  1:25AM', N'not interested')
/****** Object:  Table [dbo].[CallStatusMaster]    Script Date: 11/21/2015 02:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CallStatusMaster](
	[CallStatusId] [int] IDENTITY(1,1) NOT NULL,
	[CallStatusName] [varchar](100) NOT NULL,
 CONSTRAINT [PK_CallStatusMaster] PRIMARY KEY CLUSTERED 
(
	[CallStatusId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CallStatusMaster] ON
INSERT [dbo].[CallStatusMaster] ([CallStatusId], [CallStatusName]) VALUES (1, N'New')
INSERT [dbo].[CallStatusMaster] ([CallStatusId], [CallStatusName]) VALUES (2, N'Inprocess')
INSERT [dbo].[CallStatusMaster] ([CallStatusId], [CallStatusName]) VALUES (3, N'Closed')
INSERT [dbo].[CallStatusMaster] ([CallStatusId], [CallStatusName]) VALUES (4, N'FAILED')
SET IDENTITY_INSERT [dbo].[CallStatusMaster] OFF
/****** Object:  Table [dbo].[DomainMaster]    Script Date: 11/21/2015 02:04:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DomainMaster](
	[DomainId] [bigint] IDENTITY(1,1) NOT NULL,
	[DomainName] [varchar](500) NOT NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_DomainMaster_IsActive]  DEFAULT ((1)),
 CONSTRAINT [PK_DomainMaster] PRIMARY KEY CLUSTERED 
(
	[DomainId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[DomainMaster] ON
INSERT [dbo].[DomainMaster] ([DomainId], [DomainName], [IsActive]) VALUES (1, N'School/College', 1)
INSERT [dbo].[DomainMaster] ([DomainId], [DomainName], [IsActive]) VALUES (2, N'Hospital', 1)
INSERT [dbo].[DomainMaster] ([DomainId], [DomainName], [IsActive]) VALUES (3, N'Warehouse', 1)
INSERT [dbo].[DomainMaster] ([DomainId], [DomainName], [IsActive]) VALUES (4, N'Industry', 1)
INSERT [dbo].[DomainMaster] ([DomainId], [DomainName], [IsActive]) VALUES (5, N'CHS', 1)
SET IDENTITY_INSERT [dbo].[DomainMaster] OFF
/****** Object:  Table [dbo].[UserInfo]    Script Date: 11/21/2015 02:04:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfo](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[UName] [varchar](500) NOT NULL,
	[ULName] [varchar](500) NULL,
	[UContactInfo] [varchar](200) NULL,
	[UAddress] [varchar](500) NULL,
	[uPassword] [varchar](500) NOT NULL,
	[URole] [varchar](50) NOT NULL CONSTRAINT [DF_UserInfo_URole]  DEFAULT (user_name()),
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON
INSERT [dbo].[UserInfo] ([userId], [UName], [ULName], [UContactInfo], [UAddress], [uPassword], [URole]) VALUES (1, N'testUser', N'testLastName', NULL, NULL, N'password', N'User')
INSERT [dbo].[UserInfo] ([userId], [UName], [ULName], [UContactInfo], [UAddress], [uPassword], [URole]) VALUES (2, N'userNoTwo', N'userNoTwo', NULL, NULL, N'password', N'User')
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
/****** Object:  Table [dbo].[PostionMaster]    Script Date: 11/21/2015 02:04:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PostionMaster](
	[PositionId] [bigint] IDENTITY(1,1) NOT NULL,
	[PositionName] [varchar](500) NOT NULL,
	[IsActive] [bit] NOT NULL CONSTRAINT [DF_PostionMaster_IsActive]  DEFAULT ((1)),
 CONSTRAINT [PK_PostionMaster] PRIMARY KEY CLUSTERED 
(
	[PositionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[PostionMaster] ON
INSERT [dbo].[PostionMaster] ([PositionId], [PositionName], [IsActive]) VALUES (1, N'Hr', 1)
INSERT [dbo].[PostionMaster] ([PositionId], [PositionName], [IsActive]) VALUES (2, N'Admin', 1)
INSERT [dbo].[PostionMaster] ([PositionId], [PositionName], [IsActive]) VALUES (3, N'Manager', 1)
SET IDENTITY_INSERT [dbo].[PostionMaster] OFF
/****** Object:  Table [dbo].[OrganaizationDetails]    Script Date: 11/21/2015 02:04:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrganaizationDetails](
	[OrganizationId] [bigint] IDENTITY(1,1) NOT NULL,
	[OrgName] [varchar](500) NOT NULL,
	[OrgState] [varchar](500) NULL,
	[OrgCity] [varchar](500) NULL,
	[OrgAddress] [varchar](max) NULL,
	[DomainId] [int] NULL,
	[userId] [int] NOT NULL,
	[nextCall] [datetime] NULL,
	[CallStatusId] [int] NOT NULL CONSTRAINT [DF_OrganaizationDetails_Status]  DEFAULT ('New'),
 CONSTRAINT [PK_OrganaizationDetails] PRIMARY KEY CLUSTERED 
(
	[OrganizationId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[OrganaizationDetails] ON
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (1, N'asdf', N'asdf', N'asdf', N'jkqqq', 4, 1, CAST(0x0000A557001F0950 AS DateTime), 2)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (2, N'org two', NULL, NULL, NULL, 1, 1, CAST(0x0000A55700057E40 AS DateTime), 2)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (3, N'org three', NULL, NULL, NULL, 4, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (10, N'test four', NULL, NULL, NULL, 3, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (11, N'test five', N'asdf', N'asdf', N'asdf', 2, 1, CAST(0x0000A557001EC300 AS DateTime), 2)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (12, N'org six', N'state', N'city', N'asdf', 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (13, N'asdf', N'asdf', N'asdf', N'asdf', 1, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (14, N'aaa new', NULL, NULL, NULL, 1, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (15, N'asdf new two', NULL, NULL, NULL, 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (16, N'pqr 1', NULL, NULL, NULL, 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (17, N'pqr 2', NULL, NULL, NULL, 1, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (18, N'pqr 3', NULL, NULL, NULL, 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (19, N'pqr 4', NULL, NULL, NULL, 4, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (20, N'pqr 14', NULL, NULL, NULL, 1, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (21, N'pqr 15', NULL, NULL, NULL, 4, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (22, N'prr 16', NULL, NULL, NULL, 2, 1, CAST(0x0000A557000AFC80 AS DateTime), 2)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (23, N'pqr 17', NULL, NULL, NULL, 3, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (24, N'pqr 18', NULL, NULL, NULL, 4, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (25, N'prq 19', NULL, NULL, NULL, 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (26, N'prq 20', NULL, NULL, NULL, 2, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (27, N'prq 21', NULL, NULL, NULL, 3, 1, NULL, 1)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (28, N'pqr 22', NULL, NULL, NULL, 4, 1, CAST(0x0000A559000DBBA0 AS DateTime), 2)
INSERT [dbo].[OrganaizationDetails] ([OrganizationId], [OrgName], [OrgState], [OrgCity], [OrgAddress], [DomainId], [userId], [nextCall], [CallStatusId]) VALUES (29, N'org one', NULL, NULL, NULL, 1, 2, CAST(0x0000A557001339E0 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[OrganaizationDetails] OFF
/****** Object:  StoredProcedure [dbo].[GetAddEditContact]    Script Date: 11/21/2015 02:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Shantanu
-- Create date: 15 05 10
-- Description:	GetContacts
--exec GetAddEditContact 0
-- =============================================
CREATE PROCEDURE [dbo].[GetAddEditContact]
@OrganisaztionId bigint = 0
AS
BEGIN
	
	SET NOCOUNT ON;
	
	IF OBJECT_ID('tempdb..#tempContactDetails') IS NOT NULL DROP TABLE #tempContactDetails
		
	select * into #tempContactDetails from ContactDetails where 1=2
	SET IDENTITY_INSERT #tempContactDetails on
	insert into #tempContactDetails(CntName,ContNumber, ContactId, EmailId,InAction,OrganizationId,PositionId)
	values('','',0,'',0,@OrganisaztionId,0)
	select * from #tempContactDetails
	
	select PositionId,PositionName from PostionMaster
	
	select DomainId, DomainName from DomainMaster
	
	select OrgName, OrgState, OrgCity, OrgAddress, a.DomainId, b.DomainName 
	from OrganaizationDetails a
	join DomainMaster b on a.DomainId = b.DomainId
	where a.OrganizationId = @OrganisaztionId
	
	select ContactId, CntName, EmailId, ContNumber, InAction, b.PositionId, b.PositionName 
	from ContactDetails a 
	join PostionMaster b on a.PositionId = b.PositionId
	where a.OrganizationId = @OrganisaztionId
	
	select b.ContactId, b.CntName, TalkedOn, FeedBack 
	from ContactDetails b 
	join ChatHistory a on a.ContactId = b.ContactId and b.OrganizationId = @OrganisaztionId
	
	
	select CallStatusId, CallStatusName from CallStatusMaster
	
	
	IF OBJECT_ID('tempdb..#tempContactDetails') IS NOT NULL DROP TABLE #tempContactDetails
	
END
GO
/****** Object:  StoredProcedure [dbo].[ContactList]    Script Date: 11/21/2015 02:05:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
/*declare @RecordCount INT = 0
exec ContactList 1, 1, 1, 5,  @RecordCount output
select @RecordCount*/
-- =============================================
CREATE PROCEDURE [dbo].[ContactList]
	-- Add the parameters for the stored procedure here
	 @userId int = 0
	,@IsTodayWork bit = 0
    ,@PageIndex INT = 1
    ,@PageSize INT = 10
    ,@RecordCount INT OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	
	select
	ROW_NUMBER() OVER
	(
	   ORDER BY nextCall desc, [OrganizationId] ASC
	)AS RowNumber, 
	a.OrganizationId,	a.OrgName,	a.OrgState,	a.OrgCity,	
	a.OrgAddress,	a.DomainId,	a.userId,	
	CONVERT(varchar(50), nextCall,103) + ' ' + stuff( right( convert(varchar(26), nextCall, 109), 15 ), 7, 7, ' ' ) as 'NextCall',	
	a.CallStatusId,
	b.DomainName, c.UName + ' ' + c.ULName as 'UserName', d.CallStatusName,
	nextCall as 'dtnextCall'
	INTO #Results
	from OrganaizationDetails a
	join DomainMaster b on a.DomainId = b.DomainId and a.userId = @userId
	join UserInfo c on a.userId = c.userId and a.userId = @userId
	join CallStatusMaster d on a.CallStatusId = d.CallStatusId and a.userId = @userId
	
	
	if(@IsTodayWork = 1)
	begin
		delete from #Results 
		where CallStatusId not in (1,2) or dtnextCall is null or dtnextCall < DATEADD(D,0, DATEDIFF(D, 0, GETDATE()))	
		/*truncate table #Results
		INSERT INTO #Results
		select
		ROW_NUMBER() OVER
		(
		   ORDER BY [OrganizationId] ASC
		)AS RowNumber, 
		a.OrganizationId,	a.OrgName,	a.OrgState,	a.OrgCity,	
		a.OrgAddress,	a.DomainId,	a.userId,	
		CONVERT(varchar(50), nextCall,103) + ' ' + stuff( right( convert(varchar(26), nextCall, 109), 15 ), 7, 7, ' ' ) as 'NextCall',	
		a.CallStatusId,
		b.DomainName, c.UName + ' ' + c.ULName as 'UserName', d.CallStatusName,
		nextCall as 'dtnextCall'
		from OrganaizationDetails a
		join DomainMaster b on a.DomainId = b.DomainId and a.userId = @userId
		join UserInfo c on a.userId = c.userId and a.userId = @userId
		join CallStatusMaster d on a.CallStatusId = d.CallStatusId and a.userId = @userId
		where a.CallStatusId in (1,2) and nextCall is not null and nextCall >= DATEADD(D,0, DATEDIFF(D, 0, GETDATE()))	
		*/
	end
	
	SELECT @RecordCount = COUNT(*)
    FROM #Results
	
	SELECT *
    FROM #Results
    WHERE RowNumber BETWEEN (((@PageIndex -1) * @PageSize) + 1) AND (((((@PageIndex -1) * @PageSize) + 1) + @PageSize) - 1)
	ORDER BY dtnextCall DESC
	
	DROP TABLE #Results
	
END
GO
