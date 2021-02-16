CREATE TABLE [dbo].[Brands]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Colors]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NULL
)

CREATE TABLE [dbo].[Cars]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BrandId] INT NOT NULL, 
    [ColorId] INT NOT NULL, 
    [ModelYear] VARCHAR(50) NOT NULL, 
    [DailyPrice] DECIMAL NOT NULL, 
    [Description] VARCHAR(MAX) NOT NULL
)

CREATE TABLE [dbo].[Customers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [CompanyName] VARCHAR(50) NOT NULL
)

CREATE TABLE [dbo].[Rentals]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CarId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [RentDate] DATETIME NULL, 
    [ReturnDate] DATETIME NULL
)

CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [Password] VARCHAR(50) NOT NULL
)

INSERT INTO Colors(Name)
VALUES
	('Red'),
	('Green'),
	('Blue'),
	('Black'),
	('White'),
	('Grey');

INSERT INTO Brands(Name)
VALUES
('Alfa Romeo'),
('Audi'),
('BMW'),
('Bentley'),
('Buick'),
('Cadillac'),
('Chevrolet'),
('Chrysler'),
('Dodge'),
('Fiat'),
('Ford'),
('GMC'),
('Genesis'),
('Honda'),
('Hyundai'),
('Infiniti'),
('Jaguar'),
('Jeep'),
('Kia'),
('Land'),
('Lexus'),
('Lincoln'),
('Lotus'),
('Maserati'),
('Mazda'),
('Mercedes'),
('Mercury'),
('Mini'),
('Mitsubishi'),
('Nikola'),
('Nissan'),
('Polestar'),
('Pontiac'),
('Porsche'),
('Ram'),
('Rivian'),
('Rolls'),
('Saab'),
('Saturn'),
('Scion'),
('Smart'),
('Subaru'),
('Suzuki'),
('Tesla'),
('Toyota'),
('Volkswagen'),
('Volvo');