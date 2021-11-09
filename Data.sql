create database QuanLyNhaHang
go

use QuanLyNhaHang

create table users
(
	iduser varchar(10) primary key not null,
	account varchar(10) not null,
	nameuser nvarchar(50) ,
	passworduser varchar(10) not null
)

create table tablefood
(
	idtable int primary key not null,
	nametable NVARCHAR(100) not null,
	statustable nvarchar (20) not null,
)

CREATE TABLE bill
(
	idbill int primary key not null,
	idtable int not null,
	iduser varchar(10) not null,
	totalmoney float not null,
	discount int not null,
	saletime date not null,

	
	foreign key (iduser) references dbo.users(iduser),
	foreign key (idtable) references dbo.tablefood(idtable)
)	

create table foodcategory 
(
	idfoodcategory int primary key not null,
	namefoodcategory nvarchar(50) not null
)

create table food
(
	idfood varchar(10) primary key not null,
	idfoodcategory int not null,
	namefood nvarchar(50) not null,
	pricefood int not null,
	unitcount nvarchar(10) not null,
	
	foreign key (idfoodcategory) references dbo.foodcategory(idfoodcategory)
)

create table billinfo
(
	idfood varchar(10) not null,
	idbill int not null,
	countdish int not null,

	foreign key (idfood) references dbo.food (idfood),
	foreign key (idbill) references dbo.bill(idbill)
)

--users 
INSERT INTO users values ('admin', 'admin', 'admin', 'admin')
INSERT INTO users values ('staff', 'tk1', 'tk1', 'tk1')

--TableFood
INSERT INTO tablefood VALUES (N'1' , N'Bàn 1' , N'Trống')
INSERT INTO tablefood VALUES (N'2' , N'Bàn 2' , N'Trống')
INSERT INTO tablefood VALUES (N'3' , N'Bàn 3' , N'Trống')
INSERT INTO tablefood VALUES (N'4' , N'Bàn 4' , N'Trống')
INSERT INTO tablefood VALUES (N'5' , N'Bàn 5' , N'Trống')
INSERT INTO tablefood VALUES (N'6' , N'Bàn 6' , N'Trống')
INSERT INTO tablefood VALUES (N'7' , N'Bàn 7' , N'Trống')
INSERT INTO tablefood VALUES (N'8' , N'Bàn 8' , N'Trống')
INSERT INTO tablefood VALUES (N'9' , N'Bàn 9' , N'Trống')
INSERT INTO tablefood VALUES (N'10' , N'Bàn 10' , N'Trống')
INSERT INTO tablefood VALUES (N'11' , N'Bàn 11' , N'Trống')

--FoodCategory
INSERT INTO foodcategory VALUES ('1' , N'Nước')
INSERT INTO foodcategory VALUES ('2' , N'Món nướng')
INSERT INTO foodcategory VALUES ('3' , N'Món xào')
INSERT INTO foodcategory VALUES ('4' , N'Món chiên')
INSERT INTO foodcategory VALUES ('5' , N'Món luộc')
INSERT INTO foodcategory VALUES ('6' , N'Món hấp')

--Food
INSERT INTO food VALUES ('N1', '1', N'Bia Tiger' , '13000' , N'Chai')
INSERT INTO food VALUES ('N2', '1', N'Bia Heniken' , '15000' , N'Chai')
INSERT INTO food VALUES ('N3', '1', N'Coca-Cola' , '12000' , N'Lon')
INSERT INTO food VALUES ('N4', '1', N'7Up' , '1000' , N'Lon')
INSERT INTO food VALUES ('M1', '2', N'Khô mực' , '70000' , N'100g')
INSERT INTO food VALUES ('X1', '3', N'Mì xào hải sản' , '80000' , N'Dĩa')
INSERT INTO food VALUES ('X2', '3', N'Mì xào thập cẩm' , '80000' , N'Dĩa')
INSERT INTO food VALUES ('C1', '4', N'Mực chiên giòn' , '60000' , N'Dĩa')
INSERT INTO food VALUES ('L1', '5', N'Gà luộc nguyên con' , '130000' , N'Con')	
INSERT INTO food VALUES ('H1', '6', N'Nghiêu hấp sả' , '30000' , N'Tô')





create database QuanLyNhanSu

ON PRIMARY 
(NAME ='QLNS', filename = 'C:\QLNS\QLNS.mdf', size =100MB,MAXSIZE = Unlimited, filegrowth = 10%),

filegroup [FG1]
(NAME = 'QLNS1', filename = 'C:\QLNS\QLNS1.ndf', size = 50MB, MAXSIZE =500MB, filegrowth = 10%),

filegroup [FG1]
(NAME = 'QLNS2', filename = 'D:\DB\QLNS2.ndf', size = 80MB, MAXSIZE =80MB, filegrowth = 0%)

LOG ON
(NAME = 'QLNS_log', filename = 'D:\DB\QLNS_log.ldf', size = 10MB, MAXSIZE =Unlimited)