/*
No database-level extended properties were found or all existing extended properties are open in other windows
*/CREATE TABLE [dbo].[Brands] (
    [brandId]   INT        NOT NULL,
    [brandName] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([brandId] ASC)
);

INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (1, N'Volvo               ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (2, N'Renault             ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (3, N'Mercedes            ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (4, N'BMW                 ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (5, N'Audi                ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (6, N'Opel                ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (7, N'Peugeot             ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (8, N'Nissan              ')
INSERT INTO [dbo].[Brands] ([brandId], [brandName]) VALUES (9, N'Toyota              ')


CREATE TABLE [dbo].[Cars] (
    [carId]       INT          NOT NULL,
    [carBrandId]  INT          NULL,
    [carColorId]  INT          NULL,
    [carName]     NCHAR (30)   NULL,
    [modelYear]   DATE         NULL,
    [dailyPrice]  DECIMAL (18) NULL,
    [description] NCHAR (40)   NULL,
    PRIMARY KEY CLUSTERED ([carId] ASC)
);

INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (1, 1, 2, N'XC40                          ', N'2017-01-01', CAST(400 AS Decimal(18, 0)), N'T5 Gasoline                             ')
INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (2, 3, 5, N'E250                          ', N'2018-01-01', CAST(450 AS Decimal(18, 0)), N'4MATIC                                  ')
INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (3, 6, 6, N'Astra                         ', N'2015-01-01', CAST(200 AS Decimal(18, 0)), N'Diesel manual                           ')
INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (4, 4, 1, N'320d                          ', N'2019-01-01', CAST(350 AS Decimal(18, 0)), N'xDrive                                  ')
INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (5, 1, 3, N'V40                           ', N'2016-01-01', CAST(300 AS Decimal(18, 0)), N'T3 Gasoline                             ')
INSERT INTO [dbo].[Cars] ([carId], [carBrandId], [carColorId], [carName], [modelYear], [dailyPrice], [description]) VALUES (6, 2, 7, N'Clio                          ', N'2018-01-01', CAST(199 AS Decimal(18, 0)), N'1.3 tCe                                 ')


CREATE TABLE [dbo].[Colors] (
    [colorId]   INT        NOT NULL,
    [colorName] NCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([colorId] ASC)
);

INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (1, N'White               ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (2, N'Black               ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (3, N'Blue                ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (4, N'Yellow              ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (5, N'Gray                ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (6, N'Green               ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (7, N'Red                 ')
INSERT INTO [dbo].[Colors] ([colorId], [colorName]) VALUES (8, N'Orange              ')

CREATE TABLE [dbo].[Customers] (
    [customerId]  INT        NOT NULL,
    [companyName] NCHAR (40) NOT NULL,
    PRIMARY KEY CLUSTERED ([customerId] ASC)
);

INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (1, N'Eczacıbaşı                              ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (2, N'Subor                                   ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (3, N'Arçelik                                 ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (4, N'Yemeksepeti                             ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (5, N'Microsoft                               ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (6, N'Oresoft                                 ')
INSERT INTO [dbo].[Customers] ([customerId], [companyName]) VALUES (7, N'Apple                                   ')


CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           NOT NULL,
    [Name] VARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Rentals] (
    [id]         INT      NOT NULL,
    [carId]      INT      NOT NULL,
    [customerId] INT      NOT NULL,
    [rentDate]   DATETIME NOT NULL,
    [returnDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

INSERT INTO [dbo].[Rentals] ([id], [carId], [customerId], [rentDate], [returnDate]) VALUES (1, 3, 2, N'2021-04-01 00:00:00', NULL)
INSERT INTO [dbo].[Rentals] ([id], [carId], [customerId], [rentDate], [returnDate]) VALUES (2, 5, 3, N'2021-05-01 00:00:00', N'2021-05-10 00:00:00')
INSERT INTO [dbo].[Rentals] ([id], [carId], [customerId], [rentDate], [returnDate]) VALUES (3, 1, 2, N'2021-01-01 00:00:00', N'2021-02-01 00:00:00')
INSERT INTO [dbo].[Rentals] ([id], [carId], [customerId], [rentDate], [returnDate]) VALUES (4, 1, 5, N'2021-02-01 00:00:00', N'2021-03-01 00:00:00')
INSERT INTO [dbo].[Rentals] ([id], [carId], [customerId], [rentDate], [returnDate]) VALUES (5, 6, 1, N'2021-05-01 00:00:00', NULL)

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [userId]           INT NULL,
    [operationClaimId] INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Users] (
    [userId]       INT             IDENTITY (1, 1) NOT NULL,
    [firstName]    NCHAR (20)      NOT NULL,
    [lastName]     NCHAR (30)      NOT NULL,
    [email]        NCHAR (40)      NOT NULL,
    [passwordSalt] VARBINARY (MAX) NOT NULL,
    [passwordHash] VARBINARY (MAX) NULL,
    [Status]       BIT             NULL,
    PRIMARY KEY CLUSTERED ([userId] ASC)
);

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([userId], [firstName], [lastName], [email], [passwordSalt], [passwordHash], [Status]) VALUES (1, N'Can                 ', N'Yoldas                        ', N'can.yoldas0@outlook.com                 ', <Binary Data>, <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Users] ([userId], [firstName], [lastName], [email], [passwordSalt], [passwordHash], [Status]) VALUES (2, N'Naz                 ', N'Ekizoglu                      ', N'nazekizoglu@gmail.com                   ', <Binary Data>, <SQLVARIANT>, NULL)
INSERT INTO [dbo].[Users] ([userId], [firstName], [lastName], [email], [passwordSalt], [passwordHash], [Status]) VALUES (3, N'Nuri                ', N'Cekin                         ', N'nuricekin@gmail.com                     ', <Binary Data>, <SQLVARIANT>, NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
