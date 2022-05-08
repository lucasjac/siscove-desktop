/*1*/
USE [siscovedb]
GO
/*CUSTOMERS*/
INSERT INTO [dbo].[customers] ([name], [ci])
SELECT s.[NAME], s.[RUC] FROM [SISCOVE].[dbo].[Customers] s
/*DISTRIBUTORS*/
SET IDENTITY_INSERT [dbo].distributors ON;
INSERT INTO [dbo].[distributors] ([id_distributor], [name])
SELECT s.[ID_DISTRIBUTORS], s.[NAME] FROM [SISCOVE].[dbo].[Distributors] s
SET IDENTITY_INSERT [dbo].Distributors OFF;
/*PRODUCTS*/
SET IDENTITY_INSERT [dbo].[products] ON;
INSERT INTO [dbo].[products] ([id_product], [description], [quantity], [date], [bool_count])
SELECT s.[ID_STOCK], s.[PRODUCT], s.[QUANTITY], GETDATE(), 0 FROM [SISCOVE].[dbo].[Stock] s
SET IDENTITY_INSERT [dbo].[products] OFF;
/*PRICES*/
INSERT INTO [dbo].[prices_sale] ([id_product], [price])
SELECT s.[ID_STOCK], s.[PRICE1] FROM [SISCOVE].[dbo].[Stock] s
INSERT INTO [dbo].[prices_sale] ([id_product], [price])
SELECT s.[ID_STOCK], s.[PRICE2] FROM [SISCOVE].[dbo].[Stock] s
INSERT INTO [dbo].[prices_sale] ([id_product], [price])
SELECT s.[ID_STOCK], s.[PRICE3] FROM [SISCOVE].[dbo].[Stock] s
/*PURCHASES_INFO*/
INSERT INTO [dbo].[purchases_info] ([id_distributor], [date])
SELECT s.[ID_DISTRIBUTORS], s.[DATE] FROM [SISCOVE].[dbo].[Purchases] s
GROUP BY s.[DATE], s.[ID_DISTRIBUTORS]
/*PURCHASES*/
INSERT INTO [dbo].[purchases] ([id_purchase_info], [id_product], [price], [quantity], [bool])
SELECT si.[id_purchase_info], s.[ID_STOCK], s.[PRICE], s.[QUANTITY], s.[F] FROM [SISCOVE].[dbo].[Purchases] s, [dbo].purchases_info si
WHERE s.[DATE] = si.[date]
/*SALES_INFO*/
INSERT INTO [dbo].[sales_info] ([date], [impress])
SELECT s.[DATE], 0 FROM [SISCOVE].[dbo].[Sales] s
GROUP BY s.[DATE]
/*SALES*/
INSERT INTO [dbo].[sales] ([id_sale_info], [id_product], [price], [quantity], [sold], [bool])
SELECT si.[id_sale_info], s.[ID_STOCK], s.[PRICE], s.[QUANTITY], 1, s.[F] FROM [SISCOVE].[dbo].[Sales] s, [dbo].[sales_info] si
WHERE s.[DATE] = si.[date]
GO


