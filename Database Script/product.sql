USE [ProductsDB]
GO

/****** Object:  Table [dbo].[Product]    Script Date: 6/13/2022 4:30:15 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Category] [varchar](50) NOT NULL,
	[Price] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
GO
SET IDENTITY_INSERT [dbo].[Product] ON
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (1, N'Potato', N'Groceries', CAST(100.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (2, N'Tomato', N'Groceries', CAST(150.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (3, N'Onion', N'Groceries', CAST(70.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (4, N'The Magic of Thinking Big', N'Books', CAST(250.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (5, N'Rich Dad Poor Dad', N'Books', CAST(230.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (6, N'The Secret', N'Books', CAST(270.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (13, N'Mobile', N'Electronics', CAST(45000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (14, N'Chair', N'Furniture', CAST(500.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (15, N'Flowers', N'Decoration', CAST(200.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[Product] ([Id], [Name], [Category], [Price]) VALUES (16, N'Table', N'Furniture', CAST(500.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[Product] OFF


