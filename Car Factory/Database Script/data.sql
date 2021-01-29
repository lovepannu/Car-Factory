SET IDENTITY_INSERT [dbo].[Car] ON
INSERT INTO [dbo].[Car] ([CarID], [CarName], [CarModel], [FuelType]) VALUES (1, N'BMW', 1980, N'Diesel')
INSERT INTO [dbo].[Car] ([CarID], [CarName], [CarModel], [FuelType]) VALUES (2, N'Audi', 1985, N'Petrol')
INSERT INTO [dbo].[Car] ([CarID], [CarName], [CarModel], [FuelType]) VALUES (3, N'Swift', 1990, N'Diesel')
INSERT INTO [dbo].[Car] ([CarID], [CarName], [CarModel], [FuelType]) VALUES (4, N'Range Rover', 1998, N'Petrol')
INSERT INTO [dbo].[Car] ([CarID], [CarName], [CarModel], [FuelType]) VALUES (5, N'Toyota', 1990, N'Petrol')
SET IDENTITY_INSERT [dbo].[Car] OFF
SET IDENTITY_INSERT [dbo].[Seller] ON
INSERT INTO [dbo].[Seller] ([SellerID], [SellerName], [ContactNumber], [EmailId], [CarID]) VALUES (1, N'Josh', 2265768, N'Josh@gmail.com', 1)
INSERT INTO [dbo].[Seller] ([SellerID], [SellerName], [ContactNumber], [EmailId], [CarID]) VALUES (2, N'Ben', 22678799, N'Ben@gmail.com', 2)
INSERT INTO [dbo].[Seller] ([SellerID], [SellerName], [ContactNumber], [EmailId], [CarID]) VALUES (3, N'Tonny', 2276900, N'Tonny@gmail.com', 3)
INSERT INTO [dbo].[Seller] ([SellerID], [SellerName], [ContactNumber], [EmailId], [CarID]) VALUES (4, N'Nikk', 22769899, N'Nikk@gmail.com', 4)
INSERT INTO [dbo].[Seller] ([SellerID], [SellerName], [ContactNumber], [EmailId], [CarID]) VALUES (5, N'Denny', 22767983, N'Denny@gmail.com', 5)
SET IDENTITY_INSERT [dbo].[Seller] OFF
SET IDENTITY_INSERT [dbo].[Buyer] ON
INSERT INTO [dbo].[Buyer] ([BuyerID], [BuyerName], [ContactNumber], [BuyerAddress], [SellerID]) VALUES (1, N'Lin', 2256588, N'1/4,Alpha street', 1)
INSERT INTO [dbo].[Buyer] ([BuyerID], [BuyerName], [ContactNumber], [BuyerAddress], [SellerID]) VALUES (2, N'Anny', 22656578, N'Sint Street', 2)
INSERT INTO [dbo].[Buyer] ([BuyerID], [BuyerName], [ContactNumber], [BuyerAddress], [SellerID]) VALUES (3, N'Sit', 22657689, N'Winny ', 3)
INSERT INTO [dbo].[Buyer] ([BuyerID], [BuyerName], [ContactNumber], [BuyerAddress], [SellerID]) VALUES (4, N'Rey', 226576898, N'East Street', 4)
INSERT INTO [dbo].[Buyer] ([BuyerID], [BuyerName], [ContactNumber], [BuyerAddress], [SellerID]) VALUES (5, N'Yuvi', 22567879, N'022567687', 5)
SET IDENTITY_INSERT [dbo].[Buyer] OFF
SET IDENTITY_INSERT [dbo].[Price] ON
INSERT INTO [dbo].[Price] ([PriceID], [CarName], [CarPrice], [CarID]) VALUES (1, N'BMW', 1000000, 1)
INSERT INTO [dbo].[Price] ([PriceID], [CarName], [CarPrice], [CarID]) VALUES (2, N'Audi', 1200000, 2)
INSERT INTO [dbo].[Price] ([PriceID], [CarName], [CarPrice], [CarID]) VALUES (3, N'Swift', 700000, 3)
INSERT INTO [dbo].[Price] ([PriceID], [CarName], [CarPrice], [CarID]) VALUES (4, N'Range Rover', 2000000, 4)
INSERT INTO [dbo].[Price] ([PriceID], [CarName], [CarPrice], [CarID]) VALUES (5, N'Toyota', 1270000, 5)
SET IDENTITY_INSERT [dbo].[Price] OFF
