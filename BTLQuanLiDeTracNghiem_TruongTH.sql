CREATE DATABASE [db_BTLQuanLiDeThiTracNghiem];
GO;
USE [db_BTLQuanLiDeThiTracNghiem]

Create table tblAdmin(
	sTaikhoan varchar(10) primary key not null,
	sMatkhau varchar(10) not null
);
insert tblAdmin(sTaikhoan,sMatkhau) Values('admin','admin');
--- 2. HOCSINH ---KC-sMahocsinh
CREATE TABLE tblHocsinh(
	sMahocsinh nvarchar(30) NOT NULL,
	sHoten nvarchar(50) NOT NULL,
	tNgaysinh datetime NOT NULL,
	iKhoi int NOT NULL,
	sTenDN varchar(50) NOT NULL,
	sMatkhau varchar(15) NOT NULL,
);
ALTER TABLE tblHocsinh ADD CONSTRAINT PK_sMahocsinh PRIMARY KEY (sMahocsinh);
ALTER TABLE tblHocsinh ADD CONSTRAINT sTenDN_unique UNIQUE(sTenDN);

INSERT tblHocsinh(sMahocsinh, sHoten, tNgaysinh, iKhoi, sTenDN, sMatkhau) 
VALUES  
		--Khối 10
		('HS1001', N'Nguyễn Văn An', '2006-01-11', 10, '10A1001', '10A1001'),
		('HS1002', N'Trần Thị Bình', '2006-02-25', 10, '10A1002', '10A1002'),
		('HS1003', N'Phan Tú Anh', '2006-07-08', 10, '10A1003', '10A1003'),
		('HS1004', N'Nguyễn Việt Dũng', '2006-05-01', 10, '10A1004', '10A1004'),
		('HS1005', N'Hoàng Thị Bích', '2006-09-05', 10, '10A1005', '10A1005'),
		--Khối 11
		('HS1101', N'Phan Thắng', '2005-03-14', 11, '11A1101', '11A1101'),
		('HS1102', N'Tạ Bích Hằng ', '2005-04-24', 11, '11A1102','11A1102'),
		('HS1103', N'Tố Thị Quyên', '2005-03-13', 11, '11A1103', '11A1103'),
		('HS1104', N'Hà Thanh Hương', '2005-04-28', 11, '11A1104', '11A1104'),
		('HS1105', N'Vũ Tín Nghĩa', '2005-12-03', 11, '11A1105', '11A1105'),
		--Khối 12
		('HS1201', N'Hoàng Anh Dũng', '2004-11-20', 12, '12A1201','12A1201'),
		('HS1202', N'Cao Trọng Tú', '2004-08-29', 12, '12A1202','12A1202'),
		('HS1203', N'Trần Văn Hùng', '2004-05-10', 12, '12A1203','12A1203'),
		('HS1204', N'Đỗ Mai Hồng', '2004-09-26', 12, '12A1204','12A1204'),
		('HS1205', N'Hồ Nguyên Bảo', '2004-10-08', 12, '12A1205','12A1205');
SELECT * FROM tblHocsinh;

--- 3. MONTHI ---KC-sMaMon
CREATE TABLE tblMonthi(
	sMamon nvarchar(20) NOT NULL,
	sTenmon nvarchar(30) NOT NULL,
);
ALTER TABLE tblMonthi ADD CONSTRAINT PK_sMamon PRIMARY KEY (sMamon);
--Môn khối 10
INSERT tblMonthi (sMamon, sTenmon)
VALUES	('TO10', N'Toán 10'),
		('LY10', N'Lý 10'),
		('HO10', N'Hoá 10'),
		('SI10', N'Sử 10'),
		('DI10', N'Địa 10'),
		('GD10', N'GDCD 10');
--Môn Khối 11
INSERT tblMonthi (sMamon, sTenmon)
VALUES	('TO11', N'Toán 11'),
		('LY11', N'Lý 11'),
		('HO11', N'Hoá 11'),
		('SI11', N'Sử 11'),
		('DI11', N'Địa 11'),
		('GD11', N'GDCD 11');
--Môn khối 12
INSERT tblMonthi (sMamon, sTenmon)
VALUES	('TO12', N'Toán 12'),
		('LY12', N'Lý 12'),
		('HO12', N'Hoá 12'),
		('SI12', N'Sử'),
		('DI12', N'Địa 12'),
		('GD12', N'GDCD 12');
SELECT * FROM tblMonthi;

--- 4. CAUHOI ---PK:sMacauhoi, FK:sMamon(tblMonthi)-sMagiaovien(tblGiaovien)
CREATE TABLE tblCauhoi(
	iIDcauhoi int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	sNoidung nvarchar(300) NOT NULL,
	sDapanA nvarchar(100) NOT NULL,
	sDapanB nvarchar(100) NOT NULL,
	sDapanC nvarchar(100) NOT NULL,
	sDapanD nvarchar(100) NOT NULL,
	sDapandung nvarchar(100) NOT NULL,
	sMamon nvarchar(20),
	FOREIGN KEY(sMamon) REFERENCES tblMonthi(sMamon)
);
--4.1 Add dữ liệu cho câu hỏi
SET IDENTITY_INSERT [dbo].[tblCauhoi] ON 
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(1,N'Cho hai tập hợp A={ 0,1,4,7,8,9 },B={ 1,2,3,4,6,7,9}. Tập hợp B\ A bằng:',N'{ 2,3,6 }',N'{ 0,8 }',N'{ 1,4,7,9 }',N'{ 1,3,7,9 }',N'A',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(2,N'Tọa độ đỉnh của Parabol y=(x^2)-4x+8 là điểm I có hoành độ là:',N'x=-2',N'x=2',N'x=4',N'x=-4',N'B',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(3,N'Mỗi học sinh lớp 10A đều học Tiếng Nga hoặc tiếng Đức. Biết rằng có 25 bạn học tiếng Nga, 20 bạn học tiếng Đức, 10 bạn học cả hai tiếng Nga và tiếng Đức. Hỏi lớp 10A có tất cả bao nhiêu học sinh?',N'40',N'45',N'35',N'55',N'C',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(4,N'Cho 3 điểm A(-2, -1), B(1; 3), C(10, 3). Tìm tọa độ D để ABCD là hình bình hành',N'D( -7,1)',N'D( 1,-1)',N'D( 2,-3)',N'D( 5,1)',N'A',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(5,N'Cho tập A={ 0,2,5,8}, có bao nhiêu tập hợp con có đúng hai phần tử?',N'4',N'6',N'7',N'5',N'B',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(6,N'Đâu là công thức tính diện tích hình chữ nhật với chiều dài a và chiều rộng b',N'a+b',N'a*b',N'a/b',N'a-b',N'B',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(7,N'Góc lượng giác có số đo 2700° thì có số đo theo rađian là',N'27',N'15π',N'-27π',N'-15π',N'B',N'TO10');
INSERT tblCauhoi(iIDcauhoi, sNoidung, sDapanA, sDapanB, sDapanC, sDapanD, sDapandung, sMamon) VALUES(12,N'Sau khi gửi 100 triệu vào ngân hàng 1 năm với suất 0,2 bạn nhận được bao nhiêu tiền?',N'200 triệu',N'300 triệu',N'150 triệu',N'Không có đáp án đúng',N'D',N'TO10');
--- 6. KETQUA ---
CREATE TABLE tblKetqua(
	iMaketqua int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	sMahocsinh nvarchar(30) NOT NULL,
	sHotenKQ nvarchar(50) NOT NULL,
	sTenmon nvarchar(20) NOT NULL,
	iSocaudung int NOT NULL,
	iDiem int,
	tNgaythi datetime NOT NULL,
);
ALTER TABLE tblKetqua ADD CONSTRAINT FK_sMahocsinhKQ FOREIGN KEY(sMahocsinh) REFERENCES tblHocsinh(sMahocsinh);

--den day chua chay phan tao tai khoan
--Tạo tài khoản người dùng
create login Hocsinh
with password = '123456'
create login Giaovien
with password = '123456'
--Tạo user--
create user Hocsinh
for login Hocsinh;
create user Giaovien
for login Giaovien;

--1.Tạo Procedure bảng tblHocsinh
CREATE PROCEDURE spHocsinh_GET
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM tblHocsinh
END
GO
CREATE PROCEDURE spHocsinh_UPDATE
	@sMahocsinh nvarchar(30),
	@sHoten nvarchar(50),
	@tNgaysinh datetime,
	@iKhoi int,
	@sTenDN varchar(50),
	@sMatkhau varchar(15)
AS
	UPDATE tblHocsinh
	SET sHoten=@sHoten, 
		tNgaysinh=@tNgaysinh,
		iKhoi=@iKhoi,
		sTenDN=@sTenDN,
		sMatkhau=@sMatkhau
	WHERE sMahocsinh= @sMahocsinh
	GO

alter PROCEDURE spHocsinh_INSERT
	@sMahocsinh nvarchar(30),
	@sHoten nvarchar(50),
	@tNgaysinh datetime,
	@iKhoi int,
	@sTenDN varchar(50),
	@sMatkhau varchar(15)
AS
	INSERT [dbo].[tblHocsinh] ([sMahocsinh], [sHoten], [tNgaysinh], [iKhoi], [sTenDN], [sMatkhau])
	VALUES (@sMahocsinh,
			@sHoten,
			@tNgaysinh, 
			@iKhoi, 
			@sTenDN, 
			@sMatkhau)
	SET @sMahocsinh= @@IDENTITY
	GO

--2.Tạo Procedure bảng tblGiaovien
CREATE PROCEDURE spGiaovien_GET
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM tblGiaovien
END
GO
CREATE PROCEDURE spGiaovien_UPDATE
	@sMagiaovien nvarchar(30),
	@sHoten nvarchar(50),
	@tNgaysinh datetime,
	@sMail nvarchar(50),
	@sTenDN varchar(50),
	@sMatkhau varchar(15)
AS
	UPDATE tblGiaovien
	SET sHoten=@sHoten, 
		tNgaysinh=@tNgaysinh,
		sMail=@sMail,
		sTenDN=@sTenDN,
		sMatkhau=@sMatkhau
	WHERE sMagiaovien= @sMagiaovien
	GO

CREATE PROCEDURE spGiaovien_INSERT
	@sMagiaovien nvarchar(30),
	@sHoten nvarchar(50),
	@tNgaysinh datetime,
	@sMail nvarchar(50),
	@sTenDN varchar(50),
	@sMatkhau varchar(15)
AS
	INSERT [dbo].[tblGiaovien] ([sHoten], [tNgaysinh], [sMail], [sTenDN], [sMatkhau])
	VALUES (@sHoten,
			@tNgaysinh, 
			@sMail, 
			@sTenDN, 
			@sMatkhau)
	SET @sMagiaovien= @@IDENTITY
	GO

--3.PROC bảng câu hỏi
CREATE PROCEDURE spCauhoi_GET
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM tblCauhoi
END
GO

create proc spCauhoi_INSERT
@iIDcauhoi [int] output,
@sNoidung nvarchar(300),
@sDapanA nvarchar(100),
@sDapanB nvarchar(100),
@sDapanC nvarchar(100),
@sDapanD nvarchar(100),
@sDapandung nvarchar(100),
@sMamon nvarchar(20)
as
INSERT [dbo].[tblCauhoi] ([sNoidung], [sDapanA],[sDapanB], [sDapanC], [sDapanD], [sDapandung], [sMamon]) 
VALUES (@sNoidung, @sDapanA, @sDapanB, @sDapanC, @sDapanD, @sDapandung, @sMamon)
set @iIDcauhoi = @@IDENTITY 
go

Create proc spCauhoi_UPDATE
@iIDcauhoi [int],
@sNoidung nvarchar(300),
@sDapanA nvarchar(100),
@sDapanB nvarchar(100),
@sDapanC nvarchar(100),
@sDapanD nvarchar(100),
@sDapandung nvarchar(100),
@sMamon nvarchar(20)
as

update [dbo].[tblCauhoi]
set sNoidung = @sNoidung ,
	sDapanA = @sDapanA ,
	sDapanB = @sDapanB ,
	sDapanC = @sDapanC ,
	sDapanD = @sDapanD ,
	sDapandung = @sDapandung ,
	sMamon = @sMamon 
where iIDcauhoi = @iIDcauhoi
go

--4.proc bang ket qua
alter PROCEDURE spKetqua_GET
AS
BEGIN
SET NOCOUNT ON;
SELECT * FROM tblKetqua
END
GO

alter proc spKetqua_INSERT
@iMaketqua [int] output,
@sMahocsinh nvarchar(30),
@sHotenKQ nvarchar(50),
@sTenmon nvarchar(20),
@iSocaudung int,
@iDiem int,
@tNgaythi datetime
as
INSERT [dbo].[tblKetqua] ([sMahocsinh], [sHotenKQ], [sTenmon], [iSocaudung], [iDiem], [tNgaythi]) 
VALUES (@sMahocsinh, @sHotenKQ, @sTenmon, @iSocaudung, @iDiem, @tNgaythi)
set @iMaketqua = @@IDENTITY 
go

--Proc cập nhật admin
alter proc spAdmin_UPDATEPASSWORD
@sMatkhau varchar(10)
as
update tblAdmin
set sMatkhau = @sMatkhau
where sTaikhoan = 'admin'
go
