Create DataBase BdSUTI
go

use BdSUTI
go

Create Table PCMAPPING(
Id int primary key Identity(1, 1) not null,
PcId AS 'Pcm-' + CAST(Id AS NVARCHAR(MAX)),
[Name] nvarchar(50) not null,
[Login] nvarchar(50), 
[Password] nvarchar(50),
[User] nvarchar(50),
[Sector] nvarchar (50),
[System] nvarchar (50),
[IP] nvarchar(15),
Mask nvarchar(15),
Gateway nvarchar(15),
DNS nvarchar(15),
DNS2 nvarchar(15),
Proxy nvarchar(100), 
[Port] nvarchar(20),
Domain nvarchar(100),
AnyDesk nvarchar (13),
MAC nvarchar (50),
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
Offboard1 nvarchar (30),
Offboard2 nvarchar (30),
Registry nvarchar (50),
Obsertvation nvarchar(MAX),
[Date] nvarchar(30),
Active bit
)

