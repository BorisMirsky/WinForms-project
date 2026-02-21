/****** Ручное создание Database [studentdb], потом заполнение кодом ниже ******/


CREATE TABLE [dbo].[StudentDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Zip] [nvarchar](50) NOT NULL,
	[Hobbies] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StudentDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[StudentDetails] ON 

INSERT [dbo].[StudentDetails] ([Id], [Name], [Email], [Phone], [Zip], [Hobbies]) VALUES (1, N'sneha', N'sneha@gmail.com', N'8979798989', N'98989', N'movie')
INSERT [dbo].[StudentDetails] ([Id], [Name], [Email], [Phone], [Zip], [Hobbies]) VALUES (2, N'bhi', N'bhi@gmail.com', N'7868687879', N'11111', N'football')
INSERT [dbo].[StudentDetails] ([Id], [Name], [Email], [Phone], [Zip], [Hobbies]) VALUES (3, N'samu shree', N'samu@gmail.com', N'7868607898', N'88888', N'movie, music')
INSERT [dbo].[StudentDetails] ([Id], [Name], [Email], [Phone], [Zip], [Hobbies]) VALUES (4, N'Nobi', N'nobi@gmail.com', N'7968788989', N'77777', N'movie, football, swimming, music')
SET IDENTITY_INSERT [dbo].[StudentDetails] OFF
GO
USE [master]
GO
ALTER DATABASE [studentdb] SET  READ_WRITE 
GO