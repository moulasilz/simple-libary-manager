CREATE DATABASE qlthuvien
use qlthuvien

CREATE TABLE [dbo].[bandoc] ( 

[mabandoc] INT NOT NULL ,
[ten] NVARCHAR(100) NOT NULL ,
[sdt] NVARCHAR(11) NOT NULL , 
[diachi] NVARCHAR(200) NOT NULL ,
[ngaysinh] DATE NOT NULL ,
[loi] INT NOT NULL ,

PRIMARY KEY ([mabandoc]) 
) ON [PRIMARY]
GO

INSERT INTO dbo.bandoc(mabandoc, ten, sdt, diachi, ngaysinh, loi)
	values
		('10001','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10002','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10003','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10004','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10005','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10006','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10007','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10008','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10009','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10010','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10011','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10012','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10013','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10014','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10015','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10016','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10017','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10018','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10019','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10020','Nguyen Thu Hien', '0999999999', 'Ninh Binh','2001/10/22','0'),
		('10021','Nguyen Anh Dương', '0991548154', 'Ninh Binh','2001/10/22','0')
		;

CREATE TABLE [dbo].[thethuvien] (

[mathe] INT NOT NULL ,
[mabandoc] INT NOT NULL ,
[ngaycap] DATE NOT NULL ,
[hanthe] DATE NOT NULL ,
FOREIGN KEY([mabandoc]) references [dbo].[bandoc]([mabandoc]),
PRIMARY KEY ([mathe]) 
) ON [PRIMARY]
GO

INSERT INTO dbo.thethuvien(mathe, mabandoc, ngaycap, hanthe)
	values
		('10001', '10001', '2022/03/10', '2022/04/10'),
		('10002', '10002', '2022/03/10', '2022/04/10'),
		('10003', '10003', '2022/03/10', '2022/04/10'),
		('10004', '10004', '2022/03/10', '2022/04/10'),
		('10005', '10005', '2022/03/10', '2022/04/10'),
		('10006', '10006', '2022/03/10', '2022/04/10'),
		('10007', '10007', '2022/03/10', '2022/04/10'),
		('10008', '10008', '2022/03/10', '2022/04/10'),
		('10009', '10009', '2022/03/10', '2022/04/10'),
		('10010', '10010', '2022/03/10', '2022/04/10'),
		('10011', '10011', '2022/03/10', '2022/04/10'),
		('10012', '10012', '2022/03/10', '2022/04/10'),
		('10013', '10013', '2022/03/10', '2022/04/10'),
		('10014', '10014', '2022/03/10', '2022/04/10'),
		('10015', '10015', '2022/03/10', '2022/04/10'),
		('10016', '10016', '2022/03/10', '2022/04/10'),
		('10017', '10017', '2022/03/10', '2022/04/10'),
		('10018', '10018', '2022/03/10', '2022/04/10'),
		('10019', '10019', '2022/03/10', '2022/04/10'),
		('10020', '10020', '2022/03/10', '2022/04/10'),
		('10021', '10021', '2022/04/10', '2022/06/10')
		;

CREATE TABLE [dbo].[sach] ( 

[masach] INT NOT NULL ,
[tensach] NVARCHAR(100) NOT NULL ,
[tentacgia] NVARCHAR(100) NOT NULL ,
[tinhtrangsach] NVARCHAR(100) NOT NULL ,
[luotmuon] INT NOT NULL ,
[ngaynhap] DATE NOT NULL,
[ngayxuat] DATE ,

PRIMARY KEY ([masach]) 
) ON [PRIMARY]  
GO 

INSERT INTO dbo.sach(masach, tensach, tentacgia, tinhtrangsach, luotmuon, ngaynhap)
	values
		('110001', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110002', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110003', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110004', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110005', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110006', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110007', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110008', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110009', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110010', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110011', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110012', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110013', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110014', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110015', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110016', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110017', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110018', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110019', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10'),
		('110020', 'Harry Potter', 'J.K. Rowling','new','0', '2022/03/10');




CREATE TABLE [dbo].[phieumuon] (

[maphieumuon] INT NOT NULL ,
[mathe] INT NOT NULL ,
[ngayhentra] DATE NOT NULL ,
[ngaymuon] DATE NOT NULL ,
[ngaytra] DATE ,

foreign key(mathe) references [dbo].[thethuvien](mathe),

PRIMARY KEY ([maphieumuon]) 
) ON [PRIMARY]  
GO 

INSERT INTO dbo.phieumuon(maphieumuon,mathe,ngayhentra,ngaymuon,ngaytra)
	values
		('1', '10001', '2022/03/21', '2022/03/11', '2022/03/21'),
		('2', '10002', '2022/03/21', '2022/03/11', '2022/03/21'),
		('3', '10003', '2022/03/21', '2022/03/11', '2022/03/21'),
		('4', '10004', '2022/03/21', '2022/03/11', '2022/03/21'),
		('5', '10005', '2022/03/21', '2022/03/11', '2022/03/21'),
		('6', '10006', '2022/03/21', '2022/03/11', '2022/03/21'),
		('7', '10007', '2022/03/21', '2022/03/11', '2022/03/21'),
		('8', '10008', '2022/03/21', '2022/03/11', '2022/03/21'),
		('9', '10009', '2022/03/21', '2022/03/11', '2022/03/21'),
		('10', '10010', '2022/03/21', '2022/03/11', '2022/03/21'),
		('11', '10011', '2022/03/21', '2022/03/11', '2022/03/21'),
		('12', '10012', '2022/03/21', '2022/03/11', '2022/03/21'),
		('13', '10013', '2022/03/21', '2022/03/11', '2022/03/21'),
		('14', '10014', '2022/03/21', '2022/03/11', '2022/03/21'),
		('15', '10015', '2022/03/21', '2022/03/11', '2022/03/21'),
		('16', '10016', '2022/03/21', '2022/03/11', '2022/03/21'),
		('17', '10017', '2022/03/21', '2022/03/11', '2022/03/21'),
		('18', '10018', '2022/03/21', '2022/03/11', '2022/03/21'),
		('19', '10019', '2022/03/21', '2022/03/11', '2022/03/21'),
		('20', '10020', '2022/03/21', '2022/03/11', '2022/03/21')
		;

CREATE TABLE [dbo].[chitietphieumuon] (
[machitiet] INT NOT NULL ,
[maphieumuon] INT NOT NULL ,
[masach] INT NOT NULL ,

foreign key(masach) references dbo.sach(masach),
foreign key(maphieumuon) references [dbo].[phieumuon](maphieumuon),

PRIMARY KEY ([machitiet]) 
) ON [PRIMARY]  
GO 
INSERT INTO dbo.chitietphieumuon(machitiet,maphieumuon,masach)  
    values
        ('1', '1', '110001'),
        ('2', '1', '110002'),
        ('3', '2', '110002'),
        ('4', '3', '110003'),
        ('5', '4', '110004'),
        ('6', '5', '110005'),
        ('7', '6', '110006'),
        ('8', '7', '110007'),
        ('9', '8', '110008'),
        ('10', '9', '110009'),
        ('11', '10', '110010'),
        ('12', '11', '110011'),
        ('13', '12', '110012'),
        ('14', '13', '110013'),
        ('15', '14', '110014'),
        ('16', '15', '110015'),
        ('17', '16', '110016'),
        ('18', '17', '110017'),
        ('19', '18', '110018'),
        ('20', '19', '110019'),
        ('21', '19', '110020'),
        ('22', '20', '110020')
        ;

		
-- drop table dbo.chitietphieumuon
-- drop table dbo.phieumuon
-- drop table dbo.thethuvien
-- drop table dbo.bandoc
-- drop table  dbo.sach
-- drop database qlthuvien

		
			










