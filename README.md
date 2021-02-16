<p align="center">
<img width="500" src="https://user-images.githubusercontent.com/50195250/108059578-c9d3ad00-7066-11eb-97c5-dc2f4db3efcd.png">
</p>

# ReCapCar nedir ?

Çok katmanlı kurumsal mimaride hazırlanmış bir günlük araba kiralama projesidir. 

Tabloları oluşturmak için gerekli [SQL](https://github.com/AtakanCSKNDR/ReCapProject/ReCapCar.sql) dosyası.

## 1 - Katmanlar

#### Entities(1.1)

Veritabanı tablolarına denk gelen entitylerin API, Console veya UI projeleri için kullanılan request/response modellerinin ve DTO(Data transfer object) larının bulunduğu katmandır

#### DataAccess(1.2)

Veri erişim katmanıdır. Veritabanı işlemlerinin (CRUD Operations) gerçekleştirildiği katmandır.

#### Bussiness(1.3)

İş kodlarımızı bu katmanda yazıyoruz. DataAccess in veritabanından aldığı verileri işleyip kontrolden geçiren katmandır.

#### Presentation Layer(1.4)

Verilerin gösterilecegi katmandır. Bu bir API olabilir yada bir Console. Bizim projemizde ConsoleUI ve API katmanları mevcut dilediğinizi başlangıç projesi olarak seçip ayaga kaldırabilirsiniz.

## 2 - SQL

Projenin son halindeki mevcut veritabanı tabloları;

**💾 dbo.Brands**

```sql
CREATE TABLE [dbo].[Brands] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

**💾 dbo.Cars**

```sql
CREATE TABLE [dbo].[Cars] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT           NOT NULL,
    [ColorId]     INT           NOT NULL,
    [ModelYear]   VARCHAR (50)  NOT NULL,
    [DailyPrice]  DECIMAL (18)  NOT NULL,
    [Description] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

**💾 dbo.Colors**

```sql
CREATE TABLE [dbo].[Colors] (
    [Id]   INT          IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

**💾 dbo.Customers**

```sql
CREATE TABLE [dbo].[Customers] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [UserId]      INT          NOT NULL,
    [CompanyName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

💾 **dbo.Rentals**

```sql
CREATE TABLE [dbo].[Rentals] (
    [Id]         INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NOT NULL,
    [CustomerId] INT      NOT NULL,
    [RentDate]   DATETIME NULL,
    [ReturnDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```

**💾 dbo.Users**

```sql
CREATE TABLE [dbo].[Users] (
    [Id]        INT          IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (50) NOT NULL,
    [LastName]  VARCHAR (50) NOT NULL,
    [Email]     VARCHAR (50) NOT NULL,
    [Password]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
```
