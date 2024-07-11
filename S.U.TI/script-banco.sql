Create DataBase BdSUTI
go

use BdSUTI
go

Create Table COMPANY (
Id int identity(1, 1),
[Name] nvarchar(100) not null,
CorporateReason nvarchar(100) UNIQUE not null,
CNPJ nvarchar(14) UNIQUE not null,
Branch nvarchar(50),
CONSTRAINT PK_CompanyID PRIMARY KEY (Id)
)

Create Table COMPANY_ADDRESS (
Id int identity(1, 1),
CEP nvarchar(8),
PublicPlace nvarchar(50),
Neighborhood nvarchar(100),
City nvarchar(100),
Number nvarchar(20),
CompanyId int not null,
CONSTRAINT PK_CompanyAddressID PRIMARY KEY (Id),
CONSTRAINT FK_CompanyIDAddress FOREIGN KEY (CompanyId) REFERENCES COMPANY (Id)
)

Create Table DEPARTMENT (
Id int identity(1, 1),
[Name] nvarchar(100) not null,
CompanyId int not null,
[Description] nvarchar(MAX),
CONSTRAINT PK_DepartmentID PRIMARY KEY (Id),
CONSTRAINT FK_CompanyIdDeparments FOREIGN KEY (CompanyId) REFERENCES COMPANY (Id)
)

Create Table PC_MAPPING(
Id int Identity(1, 1) not null,
PcId AS 'Pcm-' + CAST(Id AS NVARCHAR(MAX)),
[Name] nvarchar(50) not null,
[Login] nvarchar(50), 
[Password] nvarchar(50),
[User] nvarchar(50),
DepartmentID int,
[System] nvarchar(50),
[Ip] nvarchar(15),
Mask nvarchar(15),
Gateway nvarchar(15),
DNS nvarchar(15),
DNS2 nvarchar(15),
Proxy nvarchar(100), 
[Port] nvarchar(20),
Domain nvarchar(100),
AnyDesk nvarchar(13),
MACaddress nvarchar(50),
Notes nvarchar(MAX),
[Date] datetime,
CompanyId int,
CONSTRAINT PK_PcId PRIMARY KEY (Id),
CONSTRAINT FK_CompanyIdPc FOREIGN KEY (CompanyId) REFERENCES COMPANY (Id),
CONSTRAINT FK_DepartmentIdPc FOREIGN KEY (DepartmentId) REFERENCES DEPARTMENT (Id)
)

Create Table PC_HARDWARE_MAPPING (
Id int Identity(1, 1) not null,
PcId AS 'Pcm-' + CAST(Id AS NVARCHAR(MAX)),
[Platform] nvarchar(20),
CPU nvarchar(30),
Socket nvarchar(30),
Motherboard nvarchar(50),
Memory nvarchar(5),
DDR nvarchar(4),
Frequency nvarchar(7),
Slots nvarchar(10),
GPU nvarchar(30),
[Disk] nvarchar(6),
TypeDisk nvarchar(6),
Used nvarchar(6),
Offboard1 nvarchar(30),
Offboard2 nvarchar(30),
RegistrationNumber nvarchar(50),
[Date] datetime,
CONSTRAINT PK_PcIdHardware PRIMARY KEY (Id),
CONSTRAINT FK_HardwarePcId FOREIGN KEY (Id) REFERENCES PC_MAPPING (Id)
)