USE [Siparis]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[AdminName] [nvarchar](50) NULL,
	[AdminPassword] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Basket]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Basket](
	[BasketID] [int] IDENTITY(1,1) NOT NULL,
	[BasketBuyerName] [varchar](20) NULL,
	[BasketBuyerAddress] [varchar](200) NULL,
	[BasketItem] [varchar](20) NULL,
	[BasketItemWeight] [int] NULL,
	[BasketBuyerPrice] [int] NULL,
	[BasketBuyerQuantity] [int] NULL,
	[BasketCustomerID] [int] NULL,
	[BasketProductID] [int] NULL,
	[BasketDate] [nvarchar](50) NULL CONSTRAINT [DF_Basket_BasketDate]  DEFAULT (getdate())
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CheckPayment]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckPayment](
	[CheckID] [int] IDENTITY(1,1) NOT NULL,
	[CheckHolderName] [nvarchar](30) NULL,
	[CheckBankName] [nvarchar](30) NULL,
	[CheckCustomerID] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CreditCart]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CreditCart](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[CartNumber] [nvarchar](30) NULL,
	[CartCvv] [nvarchar](10) NULL,
	[CartTHRU] [nvarchar](10) NULL,
	[CartPassword] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OnlineOrder]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OnlineOrder](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderName] [nvarchar](50) NULL,
	[OrderAddress] [nvarchar](50) NULL,
	[OrderItem] [nvarchar](50) NULL,
	[OrderItemWeight] [int] NULL,
	[OrderBuyerPrice] [int] NULL,
	[OrderBuyerQuantity] [int] NULL,
	[OrderCustomerID] [int] NULL,
	[OrderProductID] [int] NULL,
	[OrderDate] [nvarchar](50) NULL,
	[OrderStatus] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductType] [nvarchar](50) NULL,
	[ProductWeight] [int] NULL,
	[ProductPrice] [int] NULL,
	[ProductSize] [nchar](10) NULL,
	[ProductQuantity] [int] NULL,
	[ProductMaterial] [varchar](20) NULL,
	[ProductDescription] [nvarchar](100) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tbl_Customer]    Script Date: 25.12.2021 14:13:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tbl_Customer](
	[CustomerID] [tinyint] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](20) NULL,
	[CustomerPassword] [varchar](20) NULL,
	[CustomerAddress] [varchar](200) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminID], [AdminName], [AdminPassword]) VALUES (1, N'Yavuz', N'05')
INSERT [dbo].[Admin] ([AdminID], [AdminName], [AdminPassword]) VALUES (2, N'Mahir', N'1234')
INSERT [dbo].[Admin] ([AdminID], [AdminName], [AdminPassword]) VALUES (3, N'kerem', N'4235')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Basket] ON 

INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (34, N'Mahir', N'Aydın Cendere Mahallesi Kuşkonmaz Sokak ', N'Ceket L         ', 600, 168, 2, 7, 5, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (35, N'Mahir', N'Aydın Cendere Mahallesi Kuşkonmaz Sokak ', N'Gömlek M         ', 3600, 270, 3, 7, 11, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (46, N'Hamza', N'Adana Merkez Duranlar mahallesi', N'Gömlek S         ', 300, 324, 3, 5, 10, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (47, N'Hamza', N'Adana Merkez Duranlar mahallesi', N'Gömlek S         ', 2400, 135, 3, 5, 12, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (52, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Sweatshirt XL       ', 10000, 132, 4, 2, 31, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (53, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Kazak S         ', 1600, 75, 4, 2, 13, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (51, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Gömlek L         ', 6400, 90, 4, 2, 19, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (54, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Ceket XS        ', 1200, 84, 4, 2, 21, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (49, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Sweatshirt L        ', 8000, 528, 4, 2, 30, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (50, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Gömlek S         ', 3200, 540, 4, 2, 12, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (55, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye', N'Gömlek L         ', 6400, 90, 4, 2, 19, N'24-Ara-2021')
INSERT [dbo].[Basket] ([BasketID], [BasketBuyerName], [BasketBuyerAddress], [BasketItem], [BasketItemWeight], [BasketBuyerPrice], [BasketBuyerQuantity], [BasketCustomerID], [BasketProductID], [BasketDate]) VALUES (48, N'Hamza', N'Adana Merkez Duranlar mahallesi', N'Sweatshirt L        ', 1200, 132, 3, 5, 1, N'24-Ara-2021')
SET IDENTITY_INSERT [dbo].[Basket] OFF
SET IDENTITY_INSERT [dbo].[CheckPayment] ON 

INSERT [dbo].[CheckPayment] ([CheckID], [CheckHolderName], [CheckBankName], [CheckCustomerID]) VALUES (1, N'sadasd', N'Zirrat', NULL)
INSERT [dbo].[CheckPayment] ([CheckID], [CheckHolderName], [CheckBankName], [CheckCustomerID]) VALUES (2, N'Necim', N'Ziraat', 7)
SET IDENTITY_INSERT [dbo].[CheckPayment] OFF
SET IDENTITY_INSERT [dbo].[CreditCart] ON 

INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (1, N'3131313131313131', N'313', N'31313131', N'3131')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (2, N'1', N'1', N'1', N'1')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (3, N'3', N'31', N'31', N'1')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (4, N'0000-0000-0000-0000', N'31', N'31', N'31')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (5, N'3131-3131-3131-3131', N'31', N'313', N'31')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (6, N'1111-1111-1111-1111', N'110', N'111', N'1000')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (8, N'3131-3131-3131-3131', N'313', N'3131', N'3131')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (10, N'1111-1111-1111-1111', N'11', N'11', N'1111')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (11, N'1234-5678-9123-4566', N'311', N'31312525', N'3131')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (7, N'1111-1111-1111-1111', N'110', N'111', N'1000')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (12, N'1111-1111-1111-1111', N'111', N'111', N'1111')
INSERT [dbo].[CreditCart] ([CartId], [CartNumber], [CartCvv], [CartTHRU], [CartPassword]) VALUES (13, N'3205-4205-8452-1047', N'919', N'1227', N'1111')
SET IDENTITY_INSERT [dbo].[CreditCart] OFF
SET IDENTITY_INSERT [dbo].[OnlineOrder] ON 

INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (1, N'Mahir', N'İstanbul', N'Ceket L         ', 400, 84, 1, 7, 5, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (2, N'Mehmet', N'dsadasdada', N'Ceket xs        ', 100, 70, 1, 1, 7, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (3, N'Necim Durmaz', N'İstanbul çarşısı', N'Sweatshirt L        ', 400, 132, 1, 2, 1, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (4, N'Necim', N'İstanbul Kadiköy Adıgüzel Apartmanı A blok kat:6 n', N'Gömlek S         ', 2400, 405, 3, 2, 12, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (8, N'Necim', N'İzmir Karşıyaka Güzelçam Mah. No:75', N'Ceket L         ', 300, 84, 1, 2, 5, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (10, N'Mahir', N'Erzurum Kirazlı Mah. No:28', N'Gömlek M         ', 1200, 90, 1, 7, 11, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (11, N'Mahir', N'Ankara Değirmenönü Mah.', N'Gömlek M         ', 4800, 360, 4, 7, 11, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (12, N'Necim', N'Adıyaman Asmalıbahçe Mah: No:51', N'Ceket L         ', 600, 84, 2, 2, 5, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (13, N'Necim', N'İstanbul Beylikdüzü', N'Ceket xs        ', 300, 70, 1, 2, 7, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (15, N'Mahir', N'Aydın Cendere Mahallesi Kuşkonmaz Sokak ', N'Gömlek S         ', 500, 540, 5, 7, 10, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (16, N'Mahir', N'Aydın Cendere Mahallesi Kuşkonmaz Sokak ', N'Gömlek M         ', 2400, 180, 2, 7, 11, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (20, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (5, N'Yavuz', N'Denizli Gerzele mah No:27', N'Kazak XS        ', 300, 180, 3, 6, 4, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (6, N'Mehmet', N'Aydın Kuşadası no:72 daire:4', N'Gömlek M         ', 3600, 270, 3, 1, 11, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (7, N'Hamza', N'dasdasdas', N'Gömlek S         ', 100, 108, 1, 5, 10, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (14, N'Mehmet', N'İzmir basmane No:90', N'Sweatshirt L        ', 400, 132, 1, 1, 1, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (18, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul', N'Gömlek S         ', 2400, 405, 3, 2, 12, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (19, N'Hamza', N'Adana Merkez Duranlar mahallesi', N'Gömlek M         ', 3600, 270, 3, 5, 11, N'24-Ara-2021', 1)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (9, N'Mahir', N'Antalya Güzelobo mah. havaalanı cad. uysal apt. ka', N'Kazak XS        ', 200, 120, 2, 7, 4, N'24-Ara-2021', 0)
INSERT [dbo].[OnlineOrder] ([OrderID], [OrderName], [OrderAddress], [OrderItem], [OrderItemWeight], [OrderBuyerPrice], [OrderBuyerQuantity], [OrderCustomerID], [OrderProductID], [OrderDate], [OrderStatus]) VALUES (17, N'Necim', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul', N'Gömlek M         ', 4800, 360, 4, 2, 11, N'24-Ara-2021', 0)
SET IDENTITY_INSERT [dbo].[OnlineOrder] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (1, N'Sweatshirt', 400, 132, N'L         ', 6, N'Keten', N'%20 Pamuk %80 Keten ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (2, N'Ceket', 100, 84, N'XS        ', 0, N'Keten', N'%25 Pamuk %75 Keten')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (7, N'Ceket', 300, 70, N'xs        ', 15, N'Pamuk', N'%100 Pamuk Kapüşonlu
')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (4, N'Kazak', 100, 60, N'XS        ', -2, N'Keten', N'%90 Keten %10 Pamuk')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (5, N'Ceket', 300, 84, N'L         ', 17, N'Keten', N'%100 Pamuk Bol Giyim Kalın Pamuk')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (10, N'Gömlek', 100, 108, N'S         ', 9, N'Keten', N'%10 Yün %90 Keten')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (11, N'Gömlek', 1200, 90, N'M         ', 3, N'Pamuk', N'%100 Pamuk Kalın Pamuk')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (12, N'Gömlek', 800, 135, N'S         ', 24, N'Kadife', N'%50 pamuk %50 deri Oversize')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (13, N'Kazak', 400, 75, N'S         ', 60, N'Kadife', N'%100 kadife hafif giyim bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (14, N'Gömlek', 400, 135, N'XS        ', 50, N'Kadife', N'%100 kadife hafif giyim bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (16, N'Kazak', 200, 50, N'XS        ', 50, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (18, N'Sweatshirt', 2000, 110, N'L         ', 50, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (21, N'Ceket', 300, 84, N'XS        ', 30, N'Keten', N'%75 Keten %25 pamuk bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (23, N'Sweatshirt', 1000, 132, N'S         ', 60, N'Keten', N'%75 Keten %25 pamuk bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (24, N'Kazak', 400, 60, N'S         ', 60, N'Keten', N'%75 Keten %25 pamuk bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (25, N'Kazak', 400, 60, N'S         ', 34, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (28, N'Sweatshirt', 1000, 132, N'S         ', 54, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (30, N'Sweatshirt', 2000, 132, N'L         ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (32, N'Sweatshirt', 1000, 132, N'S         ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (33, N'Kazak', 400, 60, N'S         ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (15, N'Gömlek', 400, 90, N'XS        ', 50, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (17, N'Kazak', 800, 50, N'L         ', 50, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (19, N'Gömlek', 1600, 90, N'L         ', 30, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (20, N'Gömlek', 400, 90, N'XS        ', 30, N'Pamuk', N'%100 pamuk klasik kesim ')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (22, N'Ceket', 600, 84, N'S         ', 60, N'Keten', N'%75 Keten %25 pamuk bol kesim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (27, N'Kazak', 400, 60, N'S         ', 54, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (29, N'Sweatshirt', 1500, 132, N'M         ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (31, N'Sweatshirt', 2500, 132, N'XL        ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (34, N'Sweatshirt', 1000, 132, N'S         ', 24, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
INSERT [dbo].[Products] ([ProductID], [ProductType], [ProductWeight], [ProductPrice], [ProductSize], [ProductQuantity], [ProductMaterial], [ProductDescription]) VALUES (26, N'Gömlek', 800, 108, N'S         ', 54, N'Keten', N'%100 Keten Bol Kesim Unisex giyim')
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Tbl_Customer] ON 

INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (1, N'Mehmet', N'1234', N'İzmir basmane tren garı karşısı')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (2, N'Necim', N'12345', N'İstanbul çarşı sokak pazar mahallesi no34 istanbul turkiye')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (10, N'Mehmet', N'123', N'Manisa aylin sokak gülpembe apt. no:!4')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (11, N'Yusuf', N'12319239123', N'Diyarbakir batman sokak izmir mahalllesi')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (5, N'Hamza', N'123', N'Adana Merkez Duranlar mahallesi')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (6, N'Yavuz', N'123451', N'Denizli Akkonak Mahallesi Güzelyalı Sokak')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (7, N'Mahir', N'1234', N'Aydın Cendere Mahallesi Kuşkonmaz Sokak ')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (12, N'Aylin', N'12123213', N'Ankara Sen sokak 19')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (13, N'Okan', N'459459', N'Balıkesir gülpembe mahellesi izmir sokak:19')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (14, N'Ezgi', N'1111111', N'Ankara kızılay manastır apartmanı no:19')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (15, N'Ali', N'12323', N'DİKMEN İŞHANI K 1 N 13 GULLUK, Güllük')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (16, N'Melih', N'1111131', N'BANKALAR C 213')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (17, N'Ezgi', N'131329', N'Kiliçlar,28, 78602, Safranbolu/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (18, N'Mustafa', N'912391', N'Uzamiş,31, 58762, Hafik/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (19, N'Selin', N'123123', N'Hoşoba Köyü,1, 17202, Biga/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (20, N'Emir', N'1239123', N'Küçükbostanci,10, 10100, Altieylül/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (21, N'Yavuz', N'1293192', N'Cumhuriyet Mah.,19, 5802, Taşova/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (22, N'Selim', N'1231112', N'Aşağitoklu Köyü,24, 4802, Taşliçay/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (23, N'Melih', N'9191919191', N'Aktoprak,10, 61030, Ortahisar/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (24, N'Berk', N'129912921', N'Düzmevki,15, 74110, Merkez/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (25, N'Murat', N'91919191919', N'Düzmevki,15, 74110, Merkez/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (26, N'Melisa', N'191919', N'Yemişli Köyü,7, 37942, Çatalzeytin/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (27, N'Selina', N'12312', N'Kayadibi,8, 37452, Hanönü/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (28, N'Mustafa', N'919191919', N'Azmimilli,13, 81010, Merkez/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (29, N'Yusuf', N'19191923123', N'Hokmela,31, 8100, Merkez/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (30, N'Boncu', N'571023', N'Molla,2, 57802, Erfelek/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (31, N'Burhan', N'919191', N'Aksungur,20, 49400, Malazgirt/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (32, N'Melih', N'12312312', N'Kemer,35, 45300, Salihli/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (33, N'Mustafa', N'1919191', N'Uyanik Mah.,18, 2802, Samsat/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (34, N'Erdem', N'0111919', N'Yeşilyurt,22, 45750, Gördes/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (35, N'Melih', N'100110', N'Yayci,1, 52300, Ünye/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (36, N'Zeynep', N'1919191', N'Kiliç,29, 33630, Anamur/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (37, N'Sena', N'100101010', N'Tosmurlu,2, 33940, Silifke/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (38, N'Güllü', N'19101010', N'Gülüstanoğlu,20, 78602, Safranbolu/Istanbul, Turkey')
INSERT [dbo].[Tbl_Customer] ([CustomerID], [CustomerName], [CustomerPassword], [CustomerAddress]) VALUES (39, N'Melih', N'01010101', N'Killik Köyü,10, 50802, Hacibektaş/Istanbul, Turkey')
SET IDENTITY_INSERT [dbo].[Tbl_Customer] OFF
