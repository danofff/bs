USE [Shop]
GO
/****** Object:  Table [dbo].[TableCity]    Script Date: 31.03.2018 13:34:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableCity](
	[CityId] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableCity] PRIMARY KEY CLUSTERED 
(
	[CityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableUsers]    Script Date: 31.03.2018 13:34:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableUsers](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](150) NULL,
	[Password] [nvarchar](150) NULL,
	[lName] [nvarchar](150) NULL,
	[fName] [nvarchar](150) NULL,
	[Gender] [bit] NULL,
	[EmailAddress] [nvarchar](150) NULL,
	[ContactNo] [nvarchar](50) NULL,
	[CityId] [int] NULL,
	[PathToPhoto] [nvarchar](50) NULL,
 CONSTRAINT [PK_TableUsers] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TableCity] ON 

INSERT [dbo].[TableCity] ([CityId], [CityName]) VALUES (1, N'Almaty')
INSERT [dbo].[TableCity] ([CityId], [CityName]) VALUES (2, N'Astana')
INSERT [dbo].[TableCity] ([CityId], [CityName]) VALUES (3, N'Karagandy')
INSERT [dbo].[TableCity] ([CityId], [CityName]) VALUES (4, N'Atyrau')
SET IDENTITY_INSERT [dbo].[TableCity] OFF
SET IDENTITY_INSERT [dbo].[TableUsers] ON 

INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (1, N'admin', N'admin', N'Admin', N'MAdmin', NULL, NULL, NULL, 1, N'https://randomuser.me/api/portraits/women/31.jpg')
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (2, N'jon', N'jon', N'jon', NULL, NULL, NULL, NULL, 0, N'https://randomuser.me/api/portraits/women/93.jpg')
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (3, N'', N'', N'', NULL, NULL, NULL, NULL, 0, NULL)
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (32, N'sadfsa', N'dfsadf', N'sdafasf', NULL, NULL, NULL, NULL, 0, NULL)
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (34, N'gertsen', N'123', N'yevgeniy ', NULL, NULL, NULL, NULL, 0, NULL)
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (35, N'gertsen', N'123', N'yevgeniy ', NULL, NULL, NULL, NULL, 0, NULL)
INSERT [dbo].[TableUsers] ([UserId], [Login], [Password], [lName], [fName], [Gender], [EmailAddress], [ContactNo], [CityId], [PathToPhoto]) VALUES (57, N'rwe', N'', N'rew', NULL, NULL, NULL, NULL, 2, NULL)
SET IDENTITY_INSERT [dbo].[TableUsers] OFF
