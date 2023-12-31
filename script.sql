use master 
go
create database AppAspMVC
USE [AppAspMVC]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[HomeAddress] [nvarchar](400) NULL,
	[DateBirth] [datetime2](7) NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Decreption] [nvarchar](max) NOT NULL,
	[Slug] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoryProduct]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[Title] [nvarchar](100) NOT NULL,
	[Decreption] [nvarchar](max) NOT NULL,
	[Slug] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_CategoryProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[DateSent] [datetime2](7) NOT NULL,
	[Message] [nvarchar](1000) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](160) NOT NULL,
	[Decerption] [nvarchar](max) NULL,
	[Slug] [nvarchar](160) NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Published] [bit] NOT NULL,
	[AuthorId] [nvarchar](450) NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Post] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostCategory]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostCategory](
	[PostId] [int] NOT NULL,
	[CategoryId] [int] NOT NULL,
 CONSTRAINT [PK_PostCategory] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC,
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](160) NOT NULL,
	[Decerption] [nvarchar](max) NULL,
	[Slug] [nvarchar](160) NULL,
	[Content] [nvarchar](max) NOT NULL,
	[Published] [bit] NOT NULL,
	[DateCreated] [datetime2](7) NOT NULL,
	[DateUpdated] [datetime2](7) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductCategoryProduct]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductCategoryProduct](
	[ProductId] [int] NOT NULL,
	[CategoryProductId] [int] NOT NULL,
 CONSTRAINT [PK_ProductCategoryProduct] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC,
	[CategoryProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductPhoto]    Script Date: 11/7/2023 11:57:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductPhoto](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [nvarchar](max) NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_ProductPhoto] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230621155116_Add1', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230822145554_Add_Category', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230824150059_Add_Post', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230916155128_Add-Product', N'5.0.17')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230917143704_Add-ProductPhoto', N'5.0.17')
GO
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] ON 

INSERT [dbo].[AspNetRoleClaims] ([Id], [RoleId], [ClaimType], [ClaimValue]) VALUES (9, N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416', N'can edit', N'user')
SET IDENTITY_INSERT [dbo].[AspNetRoleClaims] OFF
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'46ca98dc-c9ec-4844-bfdd-d42ea94660c5', N'Vip', N'VIP', N'd6d43a91-1141-434f-8347-b23fd7626efc')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'481813a6-7cd4-4417-9f2f-b476c680d404', N'Member', N'MEMBER', N'89f42757-1d30-4500-a0ff-336d8d6707b8')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'b2fcbd55-ada0-4817-b92f-d538002b6216', N'Admin', N'ADMIN', N'327206be-fd5c-4df7-a0bf-41040a43b60f')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416', N'Editor', N'EDITOR', N'3a46484e-801e-49a9-91a5-84217fc46198')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (8, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'canedit', N'role')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (9, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'caneditpassword', N'user')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (10, N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', N'can edit', N'user')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (11, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'NoiSinh', N'HaiPhong')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (12, N'2b285c31-dbd2-445b-9361-fbe7ccbbb09b', N'HocVan', N'Cao')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', N'46ca98dc-c9ec-4844-bfdd-d42ea94660c5')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'89b7568a-23c2-4bbe-8533-c1cef5971f22', N'46ca98dc-c9ec-4844-bfdd-d42ea94660c5')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'46ca98dc-c9ec-4844-bfdd-d42ea94660c5')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', N'481813a6-7cd4-4417-9f2f-b476c680d404')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'481813a6-7cd4-4417-9f2f-b476c680d404')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2b285c31-dbd2-445b-9361-fbe7ccbbb09b', N'b2fcbd55-ada0-4817-b92f-d538002b6216')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', N'b2fcbd55-ada0-4817-b92f-d538002b6216')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'89b7568a-23c2-4bbe-8533-c1cef5971f22', N'b2fcbd55-ada0-4817-b92f-d538002b6216')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'b2fcbd55-ada0-4817-b92f-d538002b6216')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2b285c31-dbd2-445b-9361-fbe7ccbbb09b', N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'89b7568a-23c2-4bbe-8533-c1cef5971f22', N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9de74c64-7867-4b1e-b044-b04b448e5cb9', N'cc453cf1-1d3b-410a-b88e-0b77b8a4d416')
GO
INSERT [dbo].[AspNetUsers] ([Id], [HomeAddress], [DateBirth], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2b285c31-dbd2-445b-9361-fbe7ccbbb09b', NULL, CAST(N'2001-01-30T00:00:00.0000000' AS DateTime2), N'mtien280168555@gmail.com', N'MTIEN280168555@GMAIL.COM', N'mtien280168555@gmail.com', N'MTIEN280168555@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEPKZgd2GDaroEH+kDMhuYl1UTFM7fRkcOEDaCk3hr0fpSTmYXWwL8KyR1CWaWlegxQ==', N'YFXGANVGAEICQXUTIIG4XQR5JFIUZI33', N'68fb9dda-723d-4fec-93fd-b7e292752e31', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [HomeAddress], [DateBirth], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'4cc5d244-cf6f-4f08-aa7f-a92881e6d191', NULL, CAST(N'2003-10-16T00:00:00.0000000' AS DateTime2), N'dtien5333@gmail.com', N'DTIEN5333@GMAIL.COM', N'dtien5333@gmail.com', N'DTIEN5333@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEJnjLoRuSUyNHFrv7fmWZmz2mqqTH6ZD6SSjNMPi0dFaE4gFLMeWM1ZUxu/qO31+Jw==', N'WQJ77NECQ7I3SZ5Q45WIKJ4PT2FLK4QL', N'd9c8923d-1902-4163-bd86-d3f476ffa927', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [HomeAddress], [DateBirth], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'89b7568a-23c2-4bbe-8533-c1cef5971f22', NULL, CAST(N'2002-01-14T00:00:00.0000000' AS DateTime2), N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAED+jV+A8HSN92h1geP6I4UFrik+btpdlEME0kuWosYgxxyfrtcXv+mSlAIhCQWcQ6A==', N'I4VUH6COTB2EB2JGETHBYPM5YCOYWFN4', N'00d89547-bd77-4331-8fb0-f5aa9ecd4187', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [HomeAddress], [DateBirth], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9de74c64-7867-4b1e-b044-b04b448e5cb9', NULL, CAST(N'2002-01-28T00:00:00.0000000' AS DateTime2), N'mtien280168@gmail.com', N'MTIEN280168@GMAIL.COM', N'mtien280168@gmail.com', N'MTIEN280168@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEGhxAzuCzeWtqC3boTEaExIlT1gXoiszeI7Qsux5IEVtyy/QZ4F3NB+Fqcz/MCZ1hg==', N'GP2JNNM4F5WEXNN56ECZTWWBSL2L6XKA', N'5ab20808-9a4a-4a76-b374-320ef6a496d4', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (9, 10, N'Lập Trình WPF', N'Serial dành cho những bạn đã biết về lập trình Winform và muốn học tiếp một ngôn ngữ mạnh và hiệu quả hơn cả Winform. Đó là WPF với cơ chế vẽ ảnh Vector thay cho Bitmap của Winform. Cơ chế Binding và ngôn ngữ XAML để giúp cho designer và developer có thể làm việc độc lập mà vẫn hỗ trợ nhau. Nội dung Serial này được phân tách chi tiết nhất có thể, nhằm giúp các bạn dễ hiểu và thực hành được ngay.', N'lap-trinh-wpf')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (10, 11, N'Lập Trình C#', N'Chuyên mục này là các bài viết hướng dẫn học ngôn ngữ lập trình C#, từ mức độ cơ bản - các vấn đề cốt lõi về C# đến các vấn đề nâng cao. Các bài thực hành với các ví dụ nhỏ chạy trên nền tảng .NET Core, đầu tiên là các ứng dụng Console, sau đó là ứng dụng Web với ASP.NET Core, ứng dụng WPF (với GUI trên nền tảng Windows). Bằng cách tiếp cận như vậy bạn có thể viết ứng dụng C# trên nền tảng mà bạn thích như Windows, macOS, Linux miễn là máy đó có cài đặt .NET Core Runtime.', N'lap-trinh-csharp')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (11, NULL, N'Lập Trình .Net', N'Khóa học lập trình ASP.NET Core từ căn bản đến nâng cao là món quà của TEDU gửi tới tất cả các bạn thành viên của TEDU. Đây là khóa học giúp các bạn mới bắt đầu với .NET Core nói chung và ASP.NET Core nói riêng có một nền tảng tốt để học lập trình ASP.NET Core sau này. Khóa học này sẽ hoàn toàn miễn phí cho tất cả mọi người và phát hành chính thức tại TEDU.COM.VN. Khóa học này sẽ bao gồm cả series bài viết tại https://tedu.com.vn/series/hoc-aspnet-core-can-ban.html và video trên phần khóa học.', N'lap-trinh-net')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (47, NULL, N'CM1Magni nihil', N'Et et provident est dignissimos.[fakedata]', N'ducimus-sit-cum')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (48, NULL, N'CM4Nostrum iure', N'Quibusdam voluptas enim sed quidem.[fakedata]', N'et-et-tempore')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (49, 47, N'CM2Hic excepturi est', N'Perspiciatis quo facere aut consequatur.[fakedata]', N'quidem-culpa-tempora')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (50, 47, N'CM3Illo et', N'Sit harum eos omnis omnis.[fakedata]', N'enim-reprehenderit-occaecati')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (51, 48, N'CM5Non quos', N'Et fugit est quia eum.[fakedata]', N'sit-rem-sit')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (52, 51, N'CM6Veritatis amet aliquam', N'Aliquid eos corporis tempore harum.[fakedata]', N'voluptate-reprehenderit-et')
INSERT [dbo].[Category] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (53, 10, N'Lập trình Asp.Net', N'<p><span style="color: rgb(51, 51, 51); font-family: RobotoCondensed, Helvetica, sans-serif;">ASP.NET Core là một open-source mới và framework đa nền tảng (cross-platform) cho việc xây dựng những ứng dụng hiện tại dựa trên kết nối đám mây, giống như web apps, IoT và backend cho mobile. Ứng dụng ASP.NET Core có thể chạy trên .NET Core hoặc trên phiên bản đầy đủ của&nbsp;</span><a href="https://dotnet.microsoft.com/en-us/download/dotnet-framework" target="_blank" rel="noopener" style="outline: none; text-decoration-line: none; transition: all 0.5s ease 0s; color: rgb(51, 51, 51); font-family: RobotoCondensed, Helvetica, sans-serif;">.NET Framework</a><span style="color: rgb(51, 51, 51); font-family: RobotoCondensed, Helvetica, sans-serif;">. Nó được thiết kế để cung cấp và tối ưu development framework cho những dụng cái mà được triển khai trên đám mây (clound) hoặc chạy on-promise.</span><br></p>', N'lap-trinh-asp')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoryProduct] ON 

INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (1, NULL, N'Nhóm sp1Quo', N'Dolores voluptas voluptatem consequatur quis.[fakedata]', N'modi-dolores-enim')
INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (2, NULL, N'Nhóm sp4Sit', N'Saepe nihil vel repellendus molestiae.[fakedata]', N'quam-vero-enim')
INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (3, 1, N'Nhóm sp2Excepturi quia', N'Non debitis ipsam rerum laborum.[fakedata]', N'possimus-aut-eos')
INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (4, 1, N'Nhóm sp3Iusto', N'Ut eligendi accusamus nesciunt ipsum.[fakedata]', N'vitae-distinctio-iure')
INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (5, 2, N'Nhóm sp5Quia', N'Iusto quaerat corporis harum ipsum.[fakedata]', N'illo-corrupti-et')
INSERT [dbo].[CategoryProduct] ([Id], [ParentCategoryId], [Title], [Decreption], [Slug]) VALUES (6, 5, N'Nhóm sp6Deleniti omnis', N'Vero aspernatur in non harum.[fakedata]', N'minima-pariatur-velit')
SET IDENTITY_INSERT [dbo].[CategoryProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [FullName], [Email], [DateSent], [Message], [Phone]) VALUES (3, N'Đặng Minh Tiến', N'mtienD@gmail.com.vn', CAST(N'2023-08-29T22:01:00.0000000' AS DateTime2), N'Chúc mừng Messi vô địch thế giới', N'09999999985')
INSERT [dbo].[Contacts] ([Id], [FullName], [Email], [DateSent], [Message], [Phone]) VALUES (5, N'Đặng Minh Tiến', N'mtienD@gmail.com.vn', CAST(N'2023-08-21T21:34:00.0000000' AS DateTime2), N'Được rồi đi thôi', N'02025555')
INSERT [dbo].[Contacts] ([Id], [FullName], [Email], [DateSent], [Message], [Phone]) VALUES (6, N'Đặng Tiến Đạt', N'ddatd@gmail.com.vn', CAST(N'2017-06-29T21:44:00.0000000' AS DateTime2), N'Không Buồn đâu', N'020255559')
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (125, N'Bài 9Molestias magnam quasi eveniet eveniet beatae ad', N'Itaque veritatis voluptas.', N'est-aperiam-temporibus', N'Rerum voluptas rem excepturi repudiandae dignissimos voluptas sapiente totam. Sed quis culpa non occaecati id. Natus facere sed et. Voluptatibus ipsam esse. Ut ut ratione delectus perspiciatis ut veritatis iure aut. Illo quia quia nihil assumenda beatae omnis delectus voluptates. Recusandae et molestiae quis recusandae facere. Iste eos consequatur eos sequi aspernatur quae rem. Illum quas eveniet distinctio modi consectetur est. Soluta quasi ut voluptas iusto sunt ullam sit voluptate.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-29T10:14:40.6605257' AS DateTime2), CAST(N'2023-09-16T18:29:30.2081907' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (126, N'Bài 31Blanditiis nihil excepturi illum dolore', N'Sint consectetur consectetur.', N'maxime-dolore-sunt', N'Quasi optio excepturi. Consequatur voluptas sed mollitia perspiciatis et corrupti mollitia sed. Ducimus et reprehenderit recusandae. Dolorum corrupti et doloribus repellat asperiores quia. Ut quisquam nisi voluptas iusto eos aut laborum velit voluptatem. Omnis suscipit totam quae qui. Quas voluptatem in.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-20T02:08:01.6056526' AS DateTime2), CAST(N'2021-02-20T02:08:01.6056526' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (127, N'Bài 32Et ut temporibus sunt', N'Aut et maiores.', N'perferendis-velit-accusamus', N'Debitis velit quia ab. Nihil provident aperiam officia accusantium ipsum quaerat sequi. Neque ut dolores voluptas est impedit. Non sequi qui amet quis provident. Nihil aut unde sint. Incidunt ipsum aliquam nulla qui velit reiciendis. Deleniti id dolorem sunt doloribus quam qui nostrum. Perferendis reiciendis occaecati quasi dolor ut quae officia. Ducimus saepe autem voluptas dolor voluptatum expedita cumque et. Voluptates quia quae molestiae maxime.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-24T13:02:10.2145104' AS DateTime2), CAST(N'2021-06-24T13:02:10.2145104' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (128, N'Bài 33Sed voluptatibus accusantium consequatur ipsum aut', N'Fugit excepturi doloribus.', N'quia-omnis-voluptatum', N'Ducimus qui quia quaerat officia delectus. Quis voluptatem dolorem. Repudiandae quis dolores accusamus eum et ut unde. Odit consequatur nihil inventore sunt nam in et excepturi. Doloribus et nam numquam voluptatum. Cumque eos blanditiis laudantium distinctio mollitia. Aspernatur ullam aspernatur repudiandae autem occaecati atque aliquid illum. Eius vel quidem. Ratione nobis et iure qui vero. Fugiat dolor dolore quasi voluptatem quam soluta facere excepturi.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-01-16T10:44:22.3585672' AS DateTime2), CAST(N'2021-01-16T10:44:22.3585672' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (129, N'Bài 34Et illo laborum dolorem qui cum', N'Delectus consequatur saepe.', N'voluptatum-et-dolore', N'Quo ab omnis quia sed beatae beatae id doloremque. Sint at nulla aliquid aspernatur. Animi corporis itaque odit accusamus est architecto iure non. Sit animi fugiat repellendus. Ut et incidunt amet quis consequuntur in reiciendis. Aperiam omnis sapiente. Et dolorum et. Aut modi voluptate accusamus rerum nisi delectus consectetur reiciendis.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-01-30T18:23:25.5482711' AS DateTime2), CAST(N'2021-01-30T18:23:25.5482711' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (130, N'Bài 35Est similique inventore asperiores magnam earum sit', N'Excepturi modi ut.', N'iste-occaecati-voluptatem', N'Non quasi explicabo est perferendis. Deserunt voluptatem sit quisquam. Autem autem tenetur blanditiis ut repellat reprehenderit. Laborum laborum fugit natus officiis porro blanditiis fuga similique exercitationem. Voluptatem unde eum ut perferendis ad officiis quas. Sit autem aut natus possimus exercitationem accusamus vel distinctio mollitia. Ipsum suscipit porro velit porro.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-28T17:10:56.7856972' AS DateTime2), CAST(N'2021-05-28T17:10:56.7856972' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (131, N'Bài 36Autem et recusandae', N'Dicta dolore iste.', N'repellat-fugiat-voluptates', N'Molestiae rerum ut molestias omnis et. Nulla facilis delectus aut hic excepturi illum. Ut dolorem velit omnis est provident voluptate dolores aliquid. Repudiandae amet ut officiis. Quisquam esse hic cum voluptates est quia. Voluptatem impedit est consequuntur. Iste ab sit eos facere tempora accusantium molestiae quod quam. Sapiente voluptatem ducimus rerum quis rerum laborum laboriosam.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-25T19:28:19.0534870' AS DateTime2), CAST(N'2023-09-15T05:55:35.4228536' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (132, N'Bài 37Et dolor nemo a eligendi magnam', N'Tenetur ut error.', N'temporibus-sed-voluptatem', N'Ea quos earum. Sed est iusto aut pariatur. Reiciendis asperiores quia quo. Voluptas nostrum quo fuga explicabo nemo sequi eum nemo quos. Nemo nulla dolorem. Consequatur consequatur commodi quod. Provident quas culpa magnam et dolor sit.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-01-22T21:20:40.3696105' AS DateTime2), CAST(N'2021-01-22T21:20:40.3696105' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (133, N'Bài 38Asperiores ut modi sequi occaecati earum eum', N'Et ea sit.', N'corrupti-provident-dolore', N'Consequatur aut totam deserunt voluptas dolorum quia ipsum. Totam sequi ex qui quo qui possimus sint. Aperiam debitis ipsa non tempora amet qui et qui doloremque. Voluptate quae nemo accusamus et assumenda. In qui corrupti et. Aspernatur recusandae quia delectus libero repudiandae temporibus velit. Ipsa porro eius repellendus deserunt aut officiis. Est velit necessitatibus exercitationem tempore. Quam nulla corrupti tenetur.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-20T06:44:08.2385540' AS DateTime2), CAST(N'2021-06-20T06:44:08.2385540' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (134, N'Bài 39Qui ut sed maiores aliquid pariatur inventore', N'Magni est aut.', N'hic-facilis-sit', N'Sit sunt dicta ad necessitatibus. Quia vel beatae laborum suscipit. Quo et sed sit a pariatur. Consectetur impedit tempora nobis sed est necessitatibus ut illo. Saepe hic laudantium est vero sunt possimus. Soluta illo sequi ut occaecati velit. Repudiandae occaecati veniam repellat odit aut natus sunt et possimus. Aut ea unde fuga repellat nemo et adipisci. Nam officiis cumque at. Commodi dolor ad quibusdam est a consectetur illum voluptas.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-23T21:53:38.0632094' AS DateTime2), CAST(N'2021-04-23T21:53:38.0632094' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (135, N'Bài 40Natus dicta omnis ex qui', N'Error nam occaecati.', N'illo-est-quis', N'Ipsum quia tempora aliquam eaque qui molestiae sit maxime. Quis exercitationem blanditiis quibusdam. Quis rerum molestiae dolores reprehenderit sit. Omnis at aut. Minus est eum perferendis non numquam. Omnis temporibus et officia excepturi qui enim dolor. Quia qui ipsa natus earum ipsum id cumque impedit.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-17T13:43:11.3260064' AS DateTime2), CAST(N'2021-06-17T13:43:11.3260064' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (136, N'Bài 41Minima quas deleniti et ipsam', N'Et tempora molestiae.', N'quaerat-quam-deleniti', N'Iste optio aut. Optio magni laboriosam amet non ut voluptates. Vel et sed. Repudiandae consequuntur corporis alias et architecto et. Explicabo eius veritatis accusantium modi ea iusto voluptatum. Ut consequatur et nesciunt. Alias culpa qui vel. Reiciendis ratione tempore natus sed voluptatem.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-06T05:59:03.9376708' AS DateTime2), CAST(N'2021-04-06T05:59:03.9376708' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (137, N'Bài 42Sit repellendus et aliquam modi animi rerum', N'Unde nihil ullam.', N'sapiente-ratione-vel', N'Aut et voluptates voluptas labore exercitationem ea omnis consequuntur. Esse ad dolorum voluptatem officia nihil distinctio vero. Optio sed non. Non omnis non. Aut harum cupiditate excepturi enim esse est debitis porro. Porro delectus qui quia sunt aspernatur impedit voluptas qui. Adipisci eligendi vitae illum non enim ut enim saepe. Reiciendis quis impedit quas cupiditate qui. Quia ratione eos ut eum officiis distinctio. Necessitatibus ad sunt ducimus aut laboriosam sunt velit libero mollitia.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-04T08:17:05.0392069' AS DateTime2), CAST(N'2021-02-04T08:17:05.0392069' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (138, N'Bài 43Est quia dolorem sed et maxime ut', N'Ullam voluptate minima.', N'omnis-commodi-est', N'Optio veniam necessitatibus consequatur illum nihil officiis. Eaque optio qui dolor ipsa. Officiis ipsa voluptates sit mollitia eveniet et amet quo officia. Ut officiis excepturi harum ab ut. Laborum quo reprehenderit magni omnis repellendus quis. Eum reiciendis et. Iste sed quis saepe iste non. Ut aliquid mollitia deserunt excepturi.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-13T16:21:16.8021008' AS DateTime2), CAST(N'2021-04-13T16:21:16.8021008' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (139, N'Bài 44Omnis qui enim corrupti culpa', N'Ut quibusdam nesciunt.', N'dolorem-qui-ratione', N'Rem et non voluptatem voluptatem doloremque velit magnam voluptatibus tenetur. Quod cumque voluptatem sit et aut. Voluptatum vel sunt sunt totam nostrum itaque. Ut eaque vitae qui consequatur rerum amet nemo. Non nam dolore corporis enim non accusantium similique voluptate ut. Voluptatem ipsum voluptatem a. Sit autem maxime accusamus ut animi rerum.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-28T16:03:22.2743941' AS DateTime2), CAST(N'2021-02-28T16:03:22.2743941' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (140, N'Bài 45Nostrum molestiae quod omnis vel', N'Nihil error et.', N'harum-beatae-eum', N'Quia dolorem et alias inventore. Eligendi cumque et. Quia dolor et voluptatem dignissimos iusto reiciendis non accusantium molestiae. Rem ab vero voluptatibus voluptatem temporibus optio et eveniet. Vel voluptatibus molestiae officia in aut eveniet perspiciatis. Harum quo minus ad quae aut sint. Odit a exercitationem iste omnis. Dolores minus sed quia sit autem incidunt asperiores. Dolorem modi quod.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-25T00:30:35.5276027' AS DateTime2), CAST(N'2021-05-25T00:30:35.5276027' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (141, N'Bài 46Quia eaque cumque', N'Eum recusandae est.', N'vero-vero-et', N'Totam officia tempore animi odit eum ad molestiae. Praesentium mollitia debitis placeat iure quidem voluptas error illo. Aut vel possimus et quia. Ipsum qui esse similique. Nisi reprehenderit voluptas ab voluptas voluptate in error fugit repudiandae. Ad quo voluptate aperiam velit quidem voluptatem. Nesciunt quia quisquam excepturi dolorem recusandae impedit ut.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-03-04T22:32:05.7027154' AS DateTime2), CAST(N'2021-03-04T22:32:05.7027154' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (142, N'Bài 30Sapiente aspernatur qui cum voluptas', N'Facilis repellat occaecati.', N'doloribus-placeat-itaque', N'Ipsam voluptas minus iste enim. Veritatis rem doloremque facere in et dolore occaecati eum. Id sed deleniti velit. Quia et omnis molestiae ipsum dolores esse rem. Omnis est porro dolorem iste minus sunt. Eligendi nostrum magni. Excepturi doloribus quod inventore voluptate recusandae illum. Consequatur ad ab dolor nobis aut eum dolor consequuntur aut.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-02T07:06:55.6914875' AS DateTime2), CAST(N'2021-05-02T07:06:55.6914875' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (143, N'Bài 8Dolor ipsam molestiae', N'Voluptate aut impedit.', N'sint-iusto-rerum', N'Quae similique deleniti. Incidunt ut rerum ullam. Illo non laborum ullam ipsum odit omnis ullam quia. Recusandae quibusdam et vel est. Iure molestiae consequuntur eum ea. Magnam qui vero ut. Dolor assumenda animi cupiditate est labore et est eaque.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-14T09:32:56.9343343' AS DateTime2), CAST(N'2021-02-14T09:32:56.9343343' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (144, N'Bài 29Quod consequatur provident', N'Quod eos quo.', N'et-qui-facilis', N'Nihil optio explicabo reprehenderit quia doloremque minima. In maxime dignissimos reprehenderit rerum. Ex et in reprehenderit est placeat. Eligendi qui qui officia. Natus magnam sunt. Explicabo adipisci officiis inventore. Et delectus explicabo consectetur dicta.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-08T21:57:19.8719440' AS DateTime2), CAST(N'2021-04-08T21:57:19.8719440' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (145, N'Bài 7Nihil veniam illum ad minus quasi consequatur', N'Nihil voluptas sed.', N'impedit-nam-magnam', N'Nesciunt eaque repudiandae dolores est. Beatae est ut rem enim eligendi alias accusantium illo autem. Autem quae quam eum quia laborum. A voluptatibus suscipit eum accusamus voluptatem consectetur. Esse enim a nobis voluptatem sit. Voluptatum itaque dolor explicabo quo. Distinctio dolores minima et aliquam delectus sit iure expedita aut.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-31T20:33:27.2588446' AS DateTime2), CAST(N'2021-05-31T20:33:27.2588446' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (146, N'Bài 10Quo minima voluptas aliquam', N'Deserunt ipsam repudiandae.', N'animi-natus-a', N'Voluptatem enim et magnam. Quod aliquam nam est. Sint ut quia error molestias voluptas placeat odit aut. Id ipsa rem odit quibusdam porro. In eos dolor doloribus sapiente vel et enim doloremque hic. Temporibus adipisci consequatur quia. Ipsum enim sint. Nobis natus illo voluptatem ut dolorem. Blanditiis modi quibusdam a blanditiis atque et. Aut et officiis iste ut debitis aliquam deleniti.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-11T14:22:37.6776462' AS DateTime2), CAST(N'2021-06-11T14:22:37.6776462' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (147, N'Bài 11Hic esse esse voluptatem eum', N'Cupiditate ratione pariatur.', N'praesentium-quis-et', N'Harum voluptatem autem quo repellendus dicta incidunt doloribus cumque. Qui consequuntur quis dolor exercitationem. Unde molestias et vitae neque iste expedita magnam. Saepe voluptatem dolores quia quia nesciunt unde nam repellat ad. Voluptas magni explicabo dolorem magnam ut saepe aut occaecati. Consectetur omnis consequatur quia minus illum. Recusandae rerum beatae commodi perspiciatis eveniet necessitatibus dolorem id.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-07T10:45:31.4222039' AS DateTime2), CAST(N'2021-06-07T10:45:31.4222039' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (148, N'Bài 12Ipsam incidunt nostrum dolor inventore qui rerum', N'Perferendis impedit a.', N'qui-amet-non', N'Facilis qui laudantium nihil atque corrupti repellat dignissimos. Est minus ex adipisci corrupti. Incidunt sed nisi sint. Quis eos tempore. Illum officiis error. Ipsam ea natus aut. Esse quisquam vel et sit laboriosam. Officiis beatae aut consequuntur.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-12T15:23:18.1579621' AS DateTime2), CAST(N'2021-05-12T15:23:18.1579621' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (149, N'Bài 13Ut esse consequuntur quod alias qui', N'Earum fugit nisi.', N'amet-qui-consectetur', N'Dolorem magni itaque neque harum reiciendis omnis assumenda voluptate quibusdam. Consequatur ut nesciunt. Illo unde quis et neque. Dignissimos magni consectetur rerum repellendus voluptatem consequuntur. Facere voluptatibus ullam est quia quae hic accusamus sapiente explicabo. Non consectetur voluptatem. Consectetur repudiandae ab quasi repellat est. Dolorem vitae ducimus voluptatem vel repellat maxime. Pariatur dolorem et eum expedita illum est.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-20T13:20:16.8163419' AS DateTime2), CAST(N'2021-02-20T13:20:16.8163419' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (150, N'Bài 14Harum quia excepturi voluptatem voluptatum omnis aperiam', N'Dolores totam possimus.', N'quod-aliquam-similique', N'Magni non dolore. Numquam minima consequatur libero hic quia odio dolore numquam. Ea nam sunt totam harum. A et ut. Aut voluptatem numquam ut aliquam quaerat quod autem fugit maxime. Et velit alias molestias alias itaque ducimus. Veritatis ratione earum unde tenetur inventore. Ipsum sed explicabo fuga quia voluptatum. Quia voluptas saepe et odit velit eligendi eum.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-27T22:46:42.0428026' AS DateTime2), CAST(N'2021-04-27T22:46:42.0428026' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (151, N'Bài 15Placeat id ipsa quia unde', N'Odit magni est.', N'qui-ut-culpa', N'Voluptas temporibus dicta quia cumque. Fuga quae rerum dicta neque et. Eum aperiam optio soluta et consequatur vitae velit ipsam non. Culpa praesentium qui est non adipisci perspiciatis. Quia consequatur voluptatem fuga est quia rerum facilis voluptas. Autem dolorem voluptate laboriosam cumque nisi deleniti error. Minima modi est veritatis cupiditate culpa atque et et. Perferendis fugiat facere. Ex dolores consequuntur error velit sunt quas. Neque et atque occaecati ipsa adipisci labore.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-18T08:02:08.7157640' AS DateTime2), CAST(N'2021-05-18T08:02:08.7157640' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (152, N'Bài 16Accusamus quas doloremque reiciendis', N'Minima dolor velit.', N'tenetur-cumque-excepturi', N'Dolorem aut ipsa dolorum ab nulla in. Quasi voluptatum exercitationem est inventore ducimus in consequatur sed. Iure atque non aut amet. Ad est veritatis vel dolorem. Delectus tenetur at iste esse. Deleniti quam qui qui sit voluptas veritatis. Aut perspiciatis occaecati maiores. Minus quas fugiat neque. Cum earum optio nobis.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-03-04T14:47:26.7927644' AS DateTime2), CAST(N'2021-03-04T14:47:26.7927644' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (153, N'Bài 17Aut voluptatum dignissimos', N'Praesentium ea dolores.', N'inventore-incidunt-sed', N'Ratione asperiores ullam. Qui perferendis aliquam minus magnam architecto quia. Et magni temporibus. Aut rem ut autem architecto et laborum maiores. Commodi expedita omnis tempore sit a. Non iure est ipsum. Architecto quia soluta molestiae laborum accusantium nihil doloribus eos quo. Omnis ut dolorum iste architecto qui. Veniam vel enim.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-02-10T21:04:59.2462094' AS DateTime2), CAST(N'2021-02-10T21:04:59.2462094' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (154, N'Bài 18In ut ut', N'Qui et est.', N'non-sapiente-et', N'Consequatur aliquid eius commodi laudantium quo et repellat. Cupiditate ad non iusto in in sed. Ut ea temporibus id pariatur nam. Recusandae omnis autem qui aut. Commodi itaque non occaecati vel quia at commodi in dignissimos. Ipsam quo recusandae vitae quis dolorum. Quisquam eveniet ea consequuntur eaque fugiat aut a est. Et voluptates quae voluptatem voluptatem sed neque laboriosam minima sint. Consectetur voluptatem fugit assumenda sapiente ipsam nostrum.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-01-25T19:09:33.9606955' AS DateTime2), CAST(N'2021-01-25T19:09:33.9606955' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (155, N'Bài 19Ut eius nulla nemo qui velit', N'Aperiam iste nemo.', N'voluptatem-eligendi-ipsam', N'At sint sapiente recusandae libero in. Nostrum dolor est maxime. Nihil dolore non. Quis ex architecto sint illum qui sapiente et. Reiciendis dicta blanditiis rerum a molestiae iusto amet molestias. Tempore corporis sit aut error dolorem repellat sapiente. Et rerum tempora quo suscipit dignissimos quis aut dolorem culpa.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-04-18T07:31:09.1562257' AS DateTime2), CAST(N'2021-04-18T07:31:09.1562257' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (156, N'Bài 20Eos non error fugiat', N'Quia quidem reprehenderit.', N'corrupti-quam-ullam', N'Sit odit aliquam excepturi aliquid illum eos consequatur voluptatem. Placeat quis sed quas. Quae laborum id repudiandae cumque sed asperiores aperiam. Magnam totam et quod odit adipisci. Accusantium velit atque aut sit fuga enim tempora est. Omnis nesciunt consequatur earum. In nulla unde et eligendi numquam quis illum id laboriosam. Nulla voluptatem aut. Quia eveniet a quia.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-11T22:13:22.2239164' AS DateTime2), CAST(N'2021-05-11T22:13:22.2239164' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (157, N'Bài 21Voluptatum repudiandae harum nisi dolore', N'Necessitatibus dolorum eum.', N'rerum-magnam-doloremque', N'Nemo saepe consequatur consectetur nemo et. Quod eum maxime assumenda odit omnis ab. Est ab et velit nobis. Assumenda earum qui veritatis. Reprehenderit quo ratione quis ipsum quas. Vel tenetur maiores. Non deserunt blanditiis quo voluptatibus.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-24T05:02:09.3464134' AS DateTime2), CAST(N'2021-05-24T05:02:09.3464134' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (158, N'Bài 22Nisi blanditiis ea', N'Minima minus rem.', N'aliquid-dolores-maiores', N'Ex magni molestiae odit assumenda deserunt explicabo in voluptatem inventore. Explicabo ea aliquam sed veritatis maxime. Ut reiciendis ab eum cum id qui consequatur dolorum vel. Accusamus nihil magni esse aperiam. Et nam ut earum iure optio ipsam ea voluptas et. Libero ad ex at. Quis aut natus ut non qui amet delectus sapiente aut. Voluptatem reprehenderit aliquid ut soluta. Aliquam voluptatem qui qui accusantium.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-03T17:20:06.8740435' AS DateTime2), CAST(N'2021-06-03T17:20:06.8740435' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (159, N'Bài 23Ut et accusantium consectetur et', N'Unde quisquam quia.', N'totam-doloremque-corporis', N'Sed vero magni rem ut. Eum voluptatibus velit esse repellat delectus. Aut voluptatum nisi sit eaque praesentium quos nisi neque minima. Illo aspernatur eligendi reiciendis. Harum eum repudiandae velit sit voluptatem qui adipisci repellendus. Sint perferendis quae iusto et id molestias vel occaecati excepturi. Voluptas esse rerum corrupti doloribus a culpa sapiente esse. Repellendus ea sequi dolor officia. Omnis a dolorem. Voluptatem ut et perspiciatis deleniti ullam est esse.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-03-20T11:47:50.6437264' AS DateTime2), CAST(N'2021-03-20T11:47:50.6437264' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (160, N'Bài 24Explicabo provident quia', N'Cumque et amet.', N'occaecati-tempore-voluptas', N'Quisquam magni est necessitatibus expedita. Est tenetur quam eligendi vero. Sunt aliquid ea aut eligendi incidunt neque non. Provident est itaque consequuntur voluptatum dolor sed harum non. Velit et et ut velit accusamus voluptate quasi. Repellendus mollitia ullam deleniti. Iure numquam inventore error repudiandae suscipit sapiente.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-01-15T08:25:10.5485431' AS DateTime2), CAST(N'2021-01-15T08:25:10.5485431' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (161, N'Bài 25Rerum ad aut dolores repellat nihil nihil', N'Iure aut quas.', N'eos-nulla-aut', N'Dignissimos quisquam tempora. Doloribus eos veniam. Voluptatem maxime enim ut. Voluptas quod voluptatem quia. Porro mollitia tempore sit eius commodi nesciunt. Adipisci facilis necessitatibus quae magnam ad consequatur nihil neque nam. Illo in est ab quibusdam inventore tenetur incidunt tenetur qui. Accusantium sint aut voluptatibus id.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-11T23:35:40.4668980' AS DateTime2), CAST(N'2021-06-11T23:35:40.4668980' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (162, N'Bài 26Ut tempora voluptas excepturi', N'Labore qui quidem.', N'id-explicabo-voluptatem', N'Ad et aut. Perspiciatis officiis ad voluptatem dolores quia dolores pariatur et ut. Ut libero repudiandae. Ab nesciunt consequuntur. Voluptatum eum velit cupiditate. Praesentium ut non. Sit hic rerum voluptates consequatur distinctio aliquid excepturi.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-06-01T12:36:24.7743708' AS DateTime2), CAST(N'2021-06-01T12:36:24.7743708' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (163, N'Bài 28Explicabo enim odit assumenda qui', N'Veritatis porro blanditiis.', N'explicabo-voluptas-provident', N'Enim aperiam dolore. Enim qui et officiis ipsum eaque. Assumenda officiis ipsum voluptatum accusantium harum et quo. Aut dolorem porro dolores fuga. Et est dolor voluptas. Consectetur tempore natus et impedit rerum similique. Velit mollitia repudiandae et mollitia. Ut rerum quis. Laboriosam itaque dolorum qui ipsam veritatis corrupti ipsam fugit.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-29T08:07:56.2812497' AS DateTime2), CAST(N'2021-05-29T08:07:56.2812497' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (164, N'Bài 27Commodi similique corrupti error', N'Animi quidem voluptas.', N'fugit-possimus-praesentium', N'Repudiandae voluptatem vero. Fugit magni aliquid consectetur aut eveniet soluta. Libero libero sit dolorem voluptatem consequatur natus cupiditate numquam. Qui sunt accusamus id iure eius sit ut et perferendis. Quasi aperiam quos. Quas unde eius. Facilis iusto eum a. Nihil ex aut id delectus quia hic ratione eveniet. Facere veniam harum autem quod magni aut sunt asperiores nam.[fakedata]', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2021-05-23T18:15:05.7888411' AS DateTime2), CAST(N'2021-05-23T18:15:05.7888411' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (165, N'Làm web app với C#', N'Bạn có thể trở thành webAppDeveloper với bài viết này', N'lam-web-app-voi-c', N'<p style="font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; background-color: rgb(248, 249, 250);"><code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 14px; color: rgb(194, 44, 114);">ASP.NET Core</code>&nbsp;là một Framework nguồn mở, đa nền tảng xây dựng trên&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 14px; color: rgb(194, 44, 114);">.NET Core</code>&nbsp;dành cho việc xây dựng các ứng dụng dựa trên kết nối internet, cụ thể sử dụng&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 14px; color: rgb(194, 44, 114);">ASP.NET Core</code>&nbsp;có thể:</p><ul style="font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; background-color: rgb(248, 249, 250); font-size: 13px;"><li>Xây dựng các ứng dụng dịch vụ web, IoT, backend cho ứng dụng di động (API).</li><li>Ứng dụng có thể chạy trên&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">.NET Core</code>&nbsp;hay&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">.NET Framework</code></li><li>Có thể sử dụng các cộng cụ để làm việc với ASP.NET trên Linux, Windows, macOS</li><li>Có thể host ứng dụng trên&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">Kestrel</code>,&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">IIS</code>,&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">Nginx</code>,&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">Apache</code>,&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">Docker</code>&nbsp;thậm chí tự host (tự chạy dịch vụ HTTP)</li><li>Sau khi thành thạo&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">ASP.NET Core</code>&nbsp;thì có thể sử dụng đến&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">ASP.NET Core MVC</code>&nbsp;để hỗ trợ kiến trúc MVC (Model-View-Controller), để phát triển ứng dụng module hóa cao hơn và được hỗ trợ các công nghệ như&nbsp;<code style="font-family: SFMono-Regular, Menlo, Monaco, Consolas, &quot;Liberation Mono&quot;, &quot;Courier New&quot;, monospace; font-size: 11.375px; color: rgb(194, 44, 114);">Razor</code></li></ul><p style="font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; background-color: rgb(248, 249, 250);">Để phát triển ứng dụng Web (như Website) trước tiên hãy đảm bảo đã biết về các kiến trức:</p>', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2023-09-15T16:51:15.7814734' AS DateTime2), CAST(N'2023-09-16T18:19:52.6770075' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (166, N'Làm sao để trở thành AppDev với C#', N'Bài viết này sẽ hướng dẫn bạn tạo một ứng dụng với wpf', N'lam-sao-de-tro-thanh-appdev-voi-c', N'<p id="aelm106" data-element-id="106" data-translation-ids="{&quot;InnerHtml&quot;:56779}" class="localized" style="margin: 1.2em 0px; padding: 0px; font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;;">App.xaml là điểm xuất phát chương trình của bạn. Visual Studio sẽ tự động tạo nó khi bạn bắt đầu một chương trình WPF mới, bao gồm cả một tệp Code-behind tên là App.xaml.cs. Hai tệp này đều giống như trường hợp của một cửa sổ (Window), cả 2 tệp đều là partial class và cùng làm việc để tạo giao diện (XAML) và Code-behind.</p><p id="aelm107" data-element-id="107" data-translation-ids="{&quot;InnerHtml&quot;:5537}" class="localized" style="margin: 1.2em 0px; padding: 0px; font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;;">App.xaml.cs mở rộng class Application, là class chính của một chương trình WPF. .NET sẽ đi đến class này đầu tiên để lấy hướng dẫn và sẽ khởi tạo cửa sổ (Window) hoăc trang (Page) từ đây. Đây cũng là nơi để đăng ký các sự kiện quan trọng của chương trình, như khởi động chương trình, các ngoại lệ không được khai báo v...v. Chi tiết về điều này sẽ được nói vào các chương sau.</p><p id="aelm108" data-element-id="108" data-translation-ids="{&quot;InnerHtml&quot;:5538}" class="localized" style="margin: 1.2em 0px; padding: 0px; font-family: -apple-system, BlinkMacSystemFont, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, Arial, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;;">Một trong những nét được sử dụng thường xuyên nhất của tệp App.xaml là định nghĩa tài nguyên chung để có thể sử dụng hoặc truy cập từ mọi nơi trong chương trình, ví dụ như các định dạng chung. Chi tiết về tài nguyên chung sẽ được đề cập ở các chương sau.<img src="https://localhost:44340/contents/biag8.jpg" style="width: 815px;"><img src="https://localhost:44340/contents/Picture/chuot-may-tinh--phu-kien-khong-the-thieu-voi-may00131-800x450.png" style="width: 800px;"></p>', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2023-09-15T16:54:27.0029704' AS DateTime2), CAST(N'2023-09-16T18:19:31.6141792' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (167, N'qqqqqqqqqqqqqq', N'qqqqqqqqqqqqqq', N'qqqqqqqqqqqqqq', N'<p>qqqqqqqqqqqqq</p>', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2023-09-16T01:15:06.1552051' AS DateTime2), CAST(N'2023-09-16T01:15:06.1560755' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (169, N'Bài asp', N'aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaddddddddddddddddatttt', N'bai-asp', N'<p>aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</p>', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2023-09-20T15:54:26.1440940' AS DateTime2), CAST(N'2023-09-20T15:54:26.1443614' AS DateTime2))
INSERT [dbo].[Post] ([PostId], [Title], [Decerption], [Slug], [Content], [Published], [AuthorId], [DateCreated], [DateUpdated]) VALUES (170, N'Lập trình nâng cao (.Net, C#, desktop C#)', N'Khóa học lập trình C# nâng cao', N'lap-trinh-nang-cao-net-c-desktop-c', N'<p>Khóa học lập trình C# nâng cao cùng với học việt STVietAcademy<br></p>', 1, N'9de74c64-7867-4b1e-b044-b04b448e5cb9', CAST(N'2023-09-24T00:06:13.0748060' AS DateTime2), CAST(N'2023-09-24T00:06:13.0756782' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Post] OFF
GO
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (125, 9)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (165, 9)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (166, 9)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (170, 9)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (125, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (131, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (165, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (166, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (169, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (170, 10)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (169, 11)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (170, 11)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (135, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (143, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (150, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (159, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (160, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (161, 47)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (129, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (132, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (138, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (144, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (148, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (152, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (155, 48)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (126, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (131, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (133, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (134, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (139, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (157, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (162, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (163, 49)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (128, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (136, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (137, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (146, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (147, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (149, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (153, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (156, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (164, 50)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (125, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (127, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (130, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (140, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (141, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (142, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (145, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (151, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (154, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (158, 51)
INSERT [dbo].[PostCategory] ([PostId], [CategoryId]) VALUES (169, 53)
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (1, N'SP 22Generic Cotton Chips', N'Aut molestiae labore.', N'consequatur-iusto-maxime', N'The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design[fakedata]', 1, CAST(N'2021-06-28T01:28:05.1175035' AS DateTime2), CAST(N'2023-09-19T17:35:39.6780161' AS DateTime2), CAST(678.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (2, N'SP 23Handcrafted Concrete Salad', N'Saepe placeat cum.', N'quae-quo-consectetur', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-04-16T20:16:33.5413894' AS DateTime2), CAST(N'2023-09-24T11:08:52.3812552' AS DateTime2), CAST(696.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (3, N'SP 24Practical Cotton Bacon', N'Veritatis sed maxime.', N'voluptatem-natus-nisi', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-02-02T20:15:24.3177053' AS DateTime2), CAST(N'2023-09-24T10:49:16.7595340' AS DateTime2), CAST(819.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (4, N'SP 25Sleek Cotton Towels', N'Illum magni aliquam.', N'perspiciatis-mollitia-consectetur', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-02-10T21:38:03.6304580' AS DateTime2), CAST(N'2021-02-10T21:38:03.6304580' AS DateTime2), CAST(547.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (5, N'SP 26Ergonomic Granite Cheese', N'Suscipit possimus qui.', N'temporibus-est-voluptatem', N'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016[fakedata]', 1, CAST(N'2021-01-18T13:10:14.1976428' AS DateTime2), CAST(N'2021-01-18T13:10:14.1976428' AS DateTime2), CAST(528.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (6, N'SP 27Licensed Concrete Keyboard', N'Repellat voluptatem aut.', N'et-eveniet-quia', N'The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality[fakedata]', 1, CAST(N'2021-02-27T05:19:17.9501688' AS DateTime2), CAST(N'2021-02-27T05:19:17.9501688' AS DateTime2), CAST(725.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (7, N'SP 28Generic Frozen Sausages', N'Itaque quia libero.', N'impedit-et-incidunt', N'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016[fakedata]', 1, CAST(N'2021-05-08T20:49:34.9414659' AS DateTime2), CAST(N'2021-05-08T20:49:34.9414659' AS DateTime2), CAST(825.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (8, N'SP 29Practical Soft Bacon', N'Saepe libero nihil.', N'distinctio-iste-aut', N'Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals[fakedata]', 1, CAST(N'2021-05-26T02:48:58.0954074' AS DateTime2), CAST(N'2021-05-26T02:48:58.0954074' AS DateTime2), CAST(970.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (9, N'SP 30Tasty Fresh Hat', N'Nemo voluptates occaecati.', N'autem-voluptatem-recusandae', N'The Football Is Good For Training And Recreational Purposes[fakedata]', 1, CAST(N'2021-02-20T17:32:05.3880705' AS DateTime2), CAST(N'2021-02-20T17:32:05.3880705' AS DateTime2), CAST(874.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (10, N'SP 31Fantastic Plastic Pants', N'Atque quis fuga.', N'perspiciatis-blanditiis-laboriosam', N'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients[fakedata]', 1, CAST(N'2021-04-13T14:04:51.4082331' AS DateTime2), CAST(N'2021-04-13T14:04:51.4082331' AS DateTime2), CAST(541.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (11, N'SP 32Refined Frozen Towels', N'Quas fugit cumque.', N'eaque-alias-laudantium', N'Boston''s most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles[fakedata]', 1, CAST(N'2021-02-11T13:02:39.3890051' AS DateTime2), CAST(N'2021-02-11T13:02:39.3890051' AS DateTime2), CAST(693.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (12, N'SP 33Gorgeous Wooden Bacon', N'Quo tempora est.', N'doloribus-cumque-explicabo', N'The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design[fakedata]', 1, CAST(N'2021-06-22T17:04:11.2080941' AS DateTime2), CAST(N'2021-06-22T17:04:11.2080941' AS DateTime2), CAST(569.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (13, N'SP 34Tasty Concrete Mouse', N'Corrupti ut nemo.', N'atque-unde-velit', N'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016[fakedata]', 1, CAST(N'2021-02-03T03:36:10.3533516' AS DateTime2), CAST(N'2021-02-03T03:36:10.3533516' AS DateTime2), CAST(645.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (14, N'SP 35Tasty Wooden Chips', N'Ut voluptates rerum.', N'et-et-vero', N'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients[fakedata]', 1, CAST(N'2021-02-06T20:42:54.9796440' AS DateTime2), CAST(N'2021-02-06T20:42:54.9796440' AS DateTime2), CAST(835.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (15, N'SP 36Practical Cotton Sausages', N'Eligendi in est.', N'et-vel-culpa', N'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients[fakedata]', 1, CAST(N'2021-02-11T15:42:20.3431977' AS DateTime2), CAST(N'2021-02-11T15:42:20.3431977' AS DateTime2), CAST(759.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (16, N'SP 37Licensed Cotton Pants', N'Sequi qui ducimus.', N'vel-dignissimos-quia', N'The Football Is Good For Training And Recreational Purposes[fakedata]', 1, CAST(N'2021-01-18T23:33:33.9399640' AS DateTime2), CAST(N'2021-01-18T23:33:33.9399640' AS DateTime2), CAST(722.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (17, N'SP 38Intelligent Soft Car', N'Non sed minima.', N'tenetur-ratione-beatae', N'New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart[fakedata]', 1, CAST(N'2021-05-23T20:31:49.2352764' AS DateTime2), CAST(N'2021-05-23T20:31:49.2352764' AS DateTime2), CAST(539.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (18, N'SP 21Licensed Plastic Chips', N'Est sit soluta.', N'dicta-nulla-perferendis', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-03-30T12:07:24.1235418' AS DateTime2), CAST(N'2021-03-30T12:07:24.1235418' AS DateTime2), CAST(679.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (19, N'SP 20Sleek Metal Ball', N'Facere modi dolorum.', N'deleniti-et-inventore', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-03-21T15:05:43.0248394' AS DateTime2), CAST(N'2021-03-21T15:05:43.0248394' AS DateTime2), CAST(617.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (20, N'SP 19Intelligent Rubber Gloves', N'Dolores ut aut.', N'quam-commodi-quod', N'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients[fakedata]', 1, CAST(N'2021-06-23T00:32:04.4611377' AS DateTime2), CAST(N'2021-06-23T00:32:04.4611377' AS DateTime2), CAST(683.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (21, N'SP 18Intelligent Plastic Computer', N'Consequatur mollitia autem.', N'aliquid-consequatur-sint', N'The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design[fakedata]', 1, CAST(N'2021-06-24T23:39:49.1469011' AS DateTime2), CAST(N'2021-06-24T23:39:49.1469011' AS DateTime2), CAST(667.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (22, N'SP 1Awesome Metal Mouse', N'Molestiae deleniti dolor.', N'tempora-quas-et', N'The automobile layout consists of a front-engine design, with transaxle-type transmissions mounted at the rear of the engine and four wheel drive[fakedata]', 1, CAST(N'2021-06-01T12:31:35.8459036' AS DateTime2), CAST(N'2021-06-01T12:31:35.8459036' AS DateTime2), CAST(949.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (23, N'SP 2Ergonomic Rubber Car', N'Aut repellat quo.', N'reprehenderit-labore-maiores', N'New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart[fakedata]', 1, CAST(N'2021-05-26T15:36:05.1881614' AS DateTime2), CAST(N'2021-05-26T15:36:05.1881614' AS DateTime2), CAST(879.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (24, N'SP 3Small Wooden Mouse', N'Aperiam voluptas reiciendis.', N'quaerat-nostrum-eos', N'Boston''s most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles[fakedata]', 1, CAST(N'2021-04-11T03:32:56.1523932' AS DateTime2), CAST(N'2021-04-11T03:32:56.1523932' AS DateTime2), CAST(642.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (25, N'SP 4Practical Rubber Chips', N'Consequuntur ea nam.', N'omnis-a-ut', N'The Football Is Good For Training And Recreational Purposes[fakedata]', 1, CAST(N'2021-05-21T13:07:43.0853664' AS DateTime2), CAST(N'2021-05-21T13:07:43.0853664' AS DateTime2), CAST(526.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (26, N'SP 5Licensed Wooden Cheese', N'Vel et ipsa.', N'eos-vitae-unde', N'Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals[fakedata]', 1, CAST(N'2021-03-14T11:57:57.3324496' AS DateTime2), CAST(N'2021-03-14T11:57:57.3324496' AS DateTime2), CAST(813.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (27, N'SP 6Generic Fresh Shoes', N'Occaecati enim nihil.', N'inventore-necessitatibus-soluta', N'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016[fakedata]', 1, CAST(N'2021-02-02T12:40:44.0699268' AS DateTime2), CAST(N'2021-02-02T12:40:44.0699268' AS DateTime2), CAST(968.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (28, N'SP 7Awesome Frozen Pants', N'Quia error harum.', N'qui-quia-quia', N'The slim & simple Maple Gaming Keyboard from Dev Byte comes with a sleek body and 7- Color RGB LED Back-lighting for smart functionality[fakedata]', 1, CAST(N'2021-06-01T05:06:47.5097006' AS DateTime2), CAST(N'2021-06-01T05:06:47.5097006' AS DateTime2), CAST(789.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (29, N'SP 8Tasty Granite Bike', N'Aspernatur ratione accusantium.', N'facilis-corrupti-laboriosam', N'The Nagasaki Lander is the trademarked name of several series of Nagasaki sport bikes, that started with the 1984 ABC800J[fakedata]', 1, CAST(N'2021-01-09T19:41:11.5234878' AS DateTime2), CAST(N'2021-01-09T19:41:11.5234878' AS DateTime2), CAST(742.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (30, N'SP 9Unbranded Fresh Chips', N'Voluptatum autem est.', N'nemo-odio-dolorem', N'Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support[fakedata]', 1, CAST(N'2021-05-05T08:01:26.6899610' AS DateTime2), CAST(N'2021-05-05T08:01:26.6899610' AS DateTime2), CAST(603.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (31, N'SP 10Refined Frozen Bacon', N'Repudiandae et nulla.', N'distinctio-inventore-non', N'The Football Is Good For Training And Recreational Purposes[fakedata]', 1, CAST(N'2021-04-05T02:00:12.1400032' AS DateTime2), CAST(N'2021-04-05T02:00:12.1400032' AS DateTime2), CAST(688.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (32, N'SP 11Generic Fresh Hat', N'Et ut suscipit.', N'voluptatem-earum-voluptas', N'Andy shoes are designed to keeping in mind durability as well as trends, the most stylish range of shoes & sandals[fakedata]', 1, CAST(N'2021-05-15T18:32:42.0663954' AS DateTime2), CAST(N'2021-05-15T18:32:42.0663954' AS DateTime2), CAST(974.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (33, N'SP 12Ergonomic Fresh Soap', N'Et aliquam perspiciatis.', N'ipsum-libero-error', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-06-21T20:25:37.4241769' AS DateTime2), CAST(N'2023-09-23T17:07:34.6796186' AS DateTime2), CAST(754.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (34, N'SP 13Refined Wooden Table', N'Dolores suscipit odio.', N'alias-rerum-dicta', N'Boston''s most advanced compression wear technology increases muscle oxygenation, stabilizes active muscles[fakedata]', 1, CAST(N'2021-06-01T05:44:48.0536384' AS DateTime2), CAST(N'2021-06-01T05:44:48.0536384' AS DateTime2), CAST(972.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (35, N'SP 14Tasty Frozen Chips', N'Eum omnis itaque.', N'non-culpa-optio', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-03-27T01:40:04.9906863' AS DateTime2), CAST(N'2021-03-27T01:40:04.9906863' AS DateTime2), CAST(948.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (36, N'SP 15Rustic Wooden Bike', N'Nam tempore ad.', N'voluptatem-corporis-et', N'New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016[fakedata]', 1, CAST(N'2021-05-26T07:10:08.9547322' AS DateTime2), CAST(N'2021-05-26T07:10:08.9547322' AS DateTime2), CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (37, N'SP 16Awesome Granite Soap', N'Voluptas fuga velit.', N'ducimus-dicta-similique', N'Carbonite web goalkeeper gloves are ergonomically designed to give easy fit[fakedata]', 1, CAST(N'2021-04-20T10:48:54.3167784' AS DateTime2), CAST(N'2021-04-20T10:48:54.3167784' AS DateTime2), CAST(537.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (38, N'SP 17Refined Rubber Computer', N'Fuga et ipsam.', N'repudiandae-cupiditate-omnis', N'The Apollotech B340 is an affordable wireless mouse with reliable connectivity, 12 months battery life and modern design[fakedata]', 1, CAST(N'2021-06-14T12:55:25.2541237' AS DateTime2), CAST(N'2021-06-14T12:55:25.2541237' AS DateTime2), CAST(819.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (39, N'SP 39Gorgeous Metal Pants', N'Omnis nihil esse.', N'id-officiis-molestias', N'New range of formal shirts are designed keeping you in mind. With fits and styling that will make you stand apart[fakedata]', 1, CAST(N'2021-01-28T02:27:15.4794990' AS DateTime2), CAST(N'2021-01-28T02:27:15.4794990' AS DateTime2), CAST(893.00 AS Decimal(18, 2)))
INSERT [dbo].[Product] ([ProductId], [Title], [Decerption], [Slug], [Content], [Published], [DateCreated], [DateUpdated], [Price]) VALUES (40, N'SP 40Refined Concrete Tuna', N'Velit laborum expedita.', N'quibusdam-ut-velit', N'The beautiful range of Apple Naturalé that has an exciting mix of natural ingredients. With the Goodness of 100% Natural Ingredients[fakedata]', 1, CAST(N'2021-03-26T18:57:42.9622181' AS DateTime2), CAST(N'2021-03-26T18:57:42.9622181' AS DateTime2), CAST(929.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (2, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (6, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (10, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (17, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (18, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (21, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (27, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (33, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (37, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (39, 1)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (2, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (7, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (12, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (20, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (22, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (24, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (29, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (32, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (33, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (35, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (38, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (40, 2)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (2, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (4, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (5, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (11, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (15, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (19, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (23, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (28, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (30, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (33, 3)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 4)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (8, 4)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (9, 4)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (13, 4)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (26, 4)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (14, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (16, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (25, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (31, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (34, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (36, 5)
INSERT [dbo].[ProductCategoryProduct] ([ProductId], [CategoryProductId]) VALUES (1, 6)
GO
SET IDENTITY_INSERT [dbo].[ProductPhoto] ON 

INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (5, N'qy1ggcrq.jpg', 40)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (13, N'k3gajygc.jpg', 40)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (15, N'b4xmi2fg.jpg', 40)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (16, N'eentesp1.png', 40)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (17, N'ep3xyvjc.jpg', 1)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (19, N'zahvdddm.jpg', 1)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (20, N'ny0mlhv4.png', 1)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (22, N'dl0qoe0b.jpg', 1)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (23, N'kslipi1g.png', 2)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (24, N'ztrgb4d1.jpg', 2)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (26, N'y0kupfpx.jpg', 2)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (27, N'fna0qcgg.jpg', 3)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (28, N'fwex0oic.jpg', 3)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (30, N'0abjicqa.jpg', 33)
INSERT [dbo].[ProductPhoto] ([Id], [FileName], [ProductId]) VALUES (31, N'lbvtvyco.jpg', 33)
SET IDENTITY_INSERT [dbo].[ProductPhoto] OFF
GO
ALTER TABLE [dbo].[Category] ADD  DEFAULT (N'') FOR [Decreption]
GO
ALTER TABLE [dbo].[Post] ADD  DEFAULT (N'') FOR [Content]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Category_ParentCategoryId] FOREIGN KEY([ParentCategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Category_ParentCategoryId]
GO
ALTER TABLE [dbo].[CategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_CategoryProduct_CategoryProduct_ParentCategoryId] FOREIGN KEY([ParentCategoryId])
REFERENCES [dbo].[CategoryProduct] ([Id])
GO
ALTER TABLE [dbo].[CategoryProduct] CHECK CONSTRAINT [FK_CategoryProduct_CategoryProduct_ParentCategoryId]
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD  CONSTRAINT [FK_Post_AspNetUsers_AuthorId] FOREIGN KEY([AuthorId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Post] CHECK CONSTRAINT [FK_Post_AspNetUsers_AuthorId]
GO
ALTER TABLE [dbo].[PostCategory]  WITH CHECK ADD  CONSTRAINT [FK_PostCategory_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostCategory] CHECK CONSTRAINT [FK_PostCategory_Category_CategoryId]
GO
ALTER TABLE [dbo].[PostCategory]  WITH CHECK ADD  CONSTRAINT [FK_PostCategory_Post_PostId] FOREIGN KEY([PostId])
REFERENCES [dbo].[Post] ([PostId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PostCategory] CHECK CONSTRAINT [FK_PostCategory_Post_PostId]
GO
ALTER TABLE [dbo].[ProductCategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategoryProduct_CategoryProduct_CategoryProductId] FOREIGN KEY([CategoryProductId])
REFERENCES [dbo].[CategoryProduct] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductCategoryProduct] CHECK CONSTRAINT [FK_ProductCategoryProduct_CategoryProduct_CategoryProductId]
GO
ALTER TABLE [dbo].[ProductCategoryProduct]  WITH CHECK ADD  CONSTRAINT [FK_ProductCategoryProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductCategoryProduct] CHECK CONSTRAINT [FK_ProductCategoryProduct_Product_ProductId]
GO
ALTER TABLE [dbo].[ProductPhoto]  WITH CHECK ADD  CONSTRAINT [FK_ProductPhoto_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([ProductId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProductPhoto] CHECK CONSTRAINT [FK_ProductPhoto_Product_ProductId]
GO
