create database QLCF_TTHQT on primary
(
	name=QLCF,
	filename='D:\QLCF23.mdf',
	size=5mb,
	maxsize=10mb,
	filegrowth=10%
)
log on
(
	name=QLCF_Log,
	filename='D:\QLCF23_Log.ldf',
	size=1mb,
	maxsize=5mb,
	filegrowth=10%
)
use QLCF_TTHQT
go


create table NHANVIEN
(
	MANV varchar(10) primary key not null,
	TENNV nvarchar(50),
	DIACHI nvarchar(50),
	GIOITINH nvarchar(5),
	NGAYSINH date,
	SDT varchar(10),
	CHUCVU nvarchar(30),
)
go

create table LOAI
(
	MALOAI varchar(10) primary key not null,
	TENLOAI nvarchar(50)
)
go

create table SANPHAM
(
	MASP varchar(10) primary key not null ,
	MALOAI varchar(10),
	TENSP nvarchar(50),
	DVT nvarchar(10),
	DONGIA int,
	constraint FK_SP_MALOAI foreign key (MALOAI) references LOAI(MALOAI)
)
go

create table BAN
(
	MABAN varchar(10) primary key,
	SOBAN int
)
go

create table HOADON(
	MAHD varchar(10) primary key not null,
	MANV varchar(10),
	MABAN varchar(10),
	NGAYBAN date,
	TONGTIEN float,
	constraint FK_HD_MABAN foreign key (MABAN) references BAN(MABAN),
	constraint FK_HD_MANV foreign key (MANV) references NHANVIEN(MANV),
	)
go

create table CHITIETHD
(
	MAHD varchar(10),
	MASP varchar(10),
	THANHTIEN float,
	SL int,
	primary key (MAHD,MASP),
	constraint FK_CTHD_MAHD foreign key (MAHD) references HOADON(MAHD),
	constraint FK_CTHD_MASP foreign key (MASP) references SANPHAM(MASP)
)
go

-- insert
SET DATEFORMAT DMY
INSERT INTO NHANVIEN
VALUES
('NV01',N'Nguyễn Minh Hòa',N'93/22 Tân Kỳ,Tân Quý Q.Tân Phú',N'Nam','17/10/2002','0353803490',N'Thu Ngân'),
('NV02',N'Đỗ Huệ Mẫn',N'371 Ðiện Biên Phủ P.24 Q.Bình Thạnh',N'Nữ','05/08/2002','0938373728',N'Thu Ngân'),
('NV03',N'Nguyễn Đức Huy ',N'371 Ðiện Biên Phủ P.24 Q.Bình Thạnh',N'Nam','05/08/1998','0938373728',N'Phục Vụ'),
('NV04',N'Trần Đức Nghĩa',N'84A Nguyễn Thế Truyện, Q.Tân Phú',N'Nam','2/12/2000','0911395301',N'Thu Ngân'),
('NV05',N'Trần Đức Nam',N'20A Nguyễn Thế Truyện, Q.Tân Phú',N'Nam','12/12/2000','0968557686',N'Phục vụ'),
('NV06',N'Đỗ Mỹ Linh',N'20 Quang Trung, Q.Gò Vấp',N'Nữ','16/12/2001','0383436679',N'Phục vụ'),
('NV07',N'Trần Ngọc Tuấn',N'20 Lê Lợi, Q.Gò Vấp',N'Nữ','20/2/2001','0988797553',N'Phục vụ')
go

INSERT INTO LOAI
VALUES('L001',N'Cafe'),
('L002',N'Trà'),
('L003',N'Đá xay'),
('L004',N'Nước ngọt'),
('L005',N'Bánh ngọt')
go

INSERT INTO SANPHAM
VALUES 
('SP001','L001',N'Cafe đá',N'Ly',12000),
('SP002','L001',N'Cafe sữa',N'Ly',15000),
('SP003','L001',N'Cafe sữa tươi',N'Ly',20000),
('SP004','L002',N'Trà vải',N'Ly',25000),
('SP005','L002',N'Trà đào',N'Ly',25000),
('SP006','L002',N'Trà sữa truyền thống',N'Ly',28000),
('SP007','L002',N'Trà sữa thái đỏ',N'Ly',28000),
('SP008','L002',N'Trà sữa thái xanh',N'Ly',28000),
('SP009','L003',N'Cafe đá xay',N'Ly',25000),
('SP010','L003',N'Socola đá xay',N'Ly',28000),
('SP011','L003',N'Đá xay oreo',N'Ly',28000),
('SP012','L004',N'Sting',N'Chai',15000),
('SP013','L004',N'Coca',N'Lon',15000),
('SP014','L005',N'Bánh flan',N'Cái',20000),
('SP015','L005',N'Bánh bông lan trứng muối',N'Cái',20000),
('SP016','L005',N'Bánh tiramisu',N'Cái',30000),
('SP017','L005',N'Bánh Donus',N'Cái',30000)
go

INSERT INTO BAN
VALUES('B01',1),
('B02',2),
('B03',3),
('B04',4),
('B05',5),
('B06',6),
('B07',7),
('B08',8),
('B09',9),
('B010',10)
GO
set dateformat dmy
INSERT INTO HOADON
VALUES
('HD01','NV01','B01','17/10/2022',NULL),
('HD02','NV01','B02','24/12/2022',NULL),
('HD03','NV04','B03','01/01/2022',NULL),
('HD04','NV04','B04','17/10/2022',NULL),
('HD05','NV01','B01','20/10/2022',NULL),
('HD06','NV01','B05','20/10/2022',NULL),
('HD07','NV02','B06','20/10/2022',NULL),
('HD08','NV04','B05','21/10/2022',NULL)
GO

select * from hoadon
INSERT INTO CHITIETHD
VALUES
('HD01','SP001',12000,3),
('HD01','SP002',15000,1),
('HD02','SP004',25000,2),
('HD02','SP008',50000,2),
('HD03','SP003',20000,5),
('HD04','SP006',28000,1)
GO

-------RÀNG BUỘC 
alter table NHANVIEN
add constraint DEF_GIOITINH check (GIOITINH=N'Nam' or GIOITINH =N'Nữ')
go
alter table NHANVIEN
add constraint DEF_NGAYSINH check (NGAYSINH < CURRENT_TIMESTAMP )
go
alter table  SANPHAM
add constraint  DEF_DONGIA check  ( DonGia >=0)
go
alter table HOADON
add constraint DEF_PRICE1 check (TONGTIEN>=0)
go
alter table CHITIETHD
add constraint DEF_THANHTIEN check (THANHTIEN >=0)
go
alter table CHITIETHD
add constraint DEF_SL check (SL >=0)
go 
alter table BAN
add constraint DEF_TENBAN unique(SOBAN)
go
--Sao luu va phuc hoi
select * from hoadon 

--Trigger mã hóa đơn tự động tăng
alter trigger THEM_1SP on SANPHAM
after insert
as
	begin
		Declare @MASP varchar(10)
		if not exists (select * from sanpham) 
			Set @MASP=1
		else
			Set @MASP=(select RIGHT(MAX(masp),2) from sanpham)+1
		Set @MASP= 'SP' +REPLICATE('0',2-LEN(@MASP)) + @MASP
		update SANPHAM set masp=@MASP where masp=(select masp from inserted)
	end
go

create trigger THEM_NV on NHANVIEN
after insert
as
	begin
		Declare @mahd varchar(10)
		if not exists (select * from HOADON) 
			Set @mahd=1
		else
			Set @mahd=(select RIGHT(MAX(MAHD),2) from HOADON)+1
		Set @mahd= 'HD' +REPLICATE('0',2-LEN(@mahd)) + @mahd
		update HOADON set MAHD=@mahd where MAHD=(select MAHD from inserted)
	end
go
-----------PROCEDURE
--Thủ tục lấy thông tin hóa đơn
go
create function DEM (@ngay date)
returns int
as
	begin
		declare @dem int
		set @dem = (select count(*)
					from HOADON
					where NGAYBAN = @ngay)
		return @dem
	end
go


create proc demnv 
as 
	select * from dbo.demnhanvien 
go
create proc DS_HOADON
with Encryption 
as
	select * from HOADON
--Doanh thu  
go
create proc doanhthu
with Encryption
as
	select * from HOADON
--Gọi
--Thủ tục lấy thông tin nhân viên
go
create proc TT_NHANVIEN
with Encryption
as
	select * from NHANVIEN
--Thủ tục lấy danh sách bàn
go
create proc DS_BAN
with Encryption
as
	select * from BAN
--Thủ tục thêm 1 hóa đơn
go
create proc THEM_HD @manv varchar(10), @maban varchar(10), @ngayban date, @tongtien float
with Encryption 
as
	insert into HOADON values('',@manv,@maban,@ngayban,@tongtien)

--Thủ tục lấy danh sách chi tiết hóa đơn theo mã hóa đơn
go
create proc DS_CTHD @mahd char(10)
with Encryption 
as
	select *
	from CHITIETHD
	where MAHD = @mahd
--Thủ tục lấy danh sách sản phẩm
go
create proc DS_SP 
with Encryption 
as
	select *
	from SANPHAM
--Hàm xuất thông tin sản phẩm có mã truyền vào
go
create function P_TT_SANPHAM_MA (@ma char(10))
returns table
	return (select * from SANPHAM where MASP = @ma)
go
---Thủ tục gọi hàm
go
create proc TT_SANPHAM_MA @ma char(10)
with Encryption 
as
	select * from dbo.P_TT_SANPHAM_MA(@ma)
--Thủ tục lấy tất cả danh sách CTHD
go
create proc DS_ALL_CTHD 
with Encryption 
as
	select * from CHITIETHD
-- xóa chi tiết hóa đơn 
GO
create proc xoactdh @MASP varchar(10)
with Encryption
as
	Delete CHITIETHD where MASP = @MASP
GO
-- sửa chi tiết hóa đơn 
GO
create proc updatecthd	
	@MAHD varchar(10),
	@MASP varchar(10),
	@THANHTIEN FLOAT,
	@SL INT
with Encryption
as
	update CHITIETHD
	set MAHD = @MAHD , MASP = @MASP , THANHTIEN = @THANHTIEN , SL = @SL
	where MASP=@MASP
GO
--Thủ tục cập nhật tổng tiền
go
create proc CAPNHAT_TONGTIEN @mahd char(10), @tongtien float
with Encryption
as
	update HOADON
	set TONGTIEN = @tongtien
	where MAHD = @mahd
--Thêm sản phẩm vào chi tiết hóa đơn
go
create proc THEM_CTHD (@mahd char(10),@masp char(10), @thanhtien float,@sl int)
with Encryption
as
	insert into CHITIETHD values(@mahd,@masp,@thanhtien,@sl)
--Gọi
exec THEM_CTHD 'HD04','SP002',12000,1
--Thủ tục lấy danh sách hóa đơn khi tìm kiếm theo ngày
go
create proc TIMKIEM_NGAY @ngay date
with Encryption
as
	begin transaction
		if not exists (select NGAYBAN from HOADON where NGAYBAN = @ngay)  
		begin
			print N'Ngày này không có'
			rollback transaction
			return
		end
		else
		begin
			select * from HOADON
			where NGAYBAN = @ngay
			commit transaction
		end
go
-- Hàm đếm số hóa đơn trong 1 ngày
go
create function DEM (@ngay date)
returns int
as
	begin
		declare @dem int
		set @dem = (select count(*)
					from HOADON
					where NGAYBAN = @ngay)
		return @dem
	end
go
--Thủ tục gọi hàm
go
create proc DEM_HOADON @ngay date
with Encryption
as
	declare @dem int
	set @dem = dbo.DEM(@ngay)
	return @dem 



--- hiển thị nhân viên
go
create proc [dbo].[hienthinhanvien]
with Encryption
as
begin
	select * from  nhanvien
end
go
--- hiển thị giới tính
go
create function hienthigioitinh()
		returns table
		as
			return (SELECT * FROM nhanvien)
go

-- lấy giới tính
create proc cbboxgt
with Encryption
as 
		 select * from  dbo.hienthigioitinh()

go
-- lấy chức vụ
create proc cbboxcv
with Encryption
as 
		select * from  dbo.hienthigioitinh()
go
--- lấy loại
create proc cbboxloai
with Encryption
as
  select * from loai
-- thêm nhân viên
go
alter proc [dbo].[InsertNV1] @MANV varchar(10) ,@TENNV nvarchar(50), @DIACHI nvarchar(50), @GIOITINH nvarchar(5) ,@NGAYSINH datetime,@SDT varchar(10) ,@CHUCVU nvarchar(30)
with Encryption
as
Insert into NHANVIEN values (@MANV,@TENNV,@DIACHI,@GIOITINH,@NGAYSINH,@SDT,@CHUCVU)
GO
-- xóa nhân viên 
create proc [dbo].[DeleteNV] @MANV varchar(10)
with Encryption
as
	Delete NHANVIEN where MANV = @MANV
GO
-- sửa nhân viên
create proc [dbo].[UpdateNV] @MANV varchar(10) ,@TENNV nvarchar(50), @DIACHI nvarchar(50), @GIOITINH nvarchar(5) ,@NGAYSINH datetime,@SDT varchar(10) ,@CHUCVU nvarchar(30)
with Encryption
as
	update NHANVIEN
	set TENNV = @TENNV , DIACHI = @DIACHI , GIOITINH = @GIOITINH , NGAYSINH = @NGAYSINH , SDT = @SDT, CHUCVU = @CHUCVU
	where MANV = @MANV
GO
-- hiển thị danh mục sản phẩm
create proc [dbo].[danhmucsp] 
with Encryption
as
begin 
	select * from sanpham
end
GO
-- lấy loại
create function [dbo].[getloai]()
returns table
as
	return (SELECT * FROM SANPHAM)
GO
-- thêm sản phẩm
alter proc [dbo].[insertsp] 
	@MASP varchar(10),
	@MALOAI varchar(10),
	@TENSP nvarchar(50),
	@DVT nvarchar(10),
	@DonGia int
with Encryption
as 
	insert into sanpham values ('',@MALOAI,@TENSP,@DVT,@DonGia)
GO
select * from sanpham
exec insertsp '','l001','a','cái',30000
-- xóa sản phẩm
create proc [dbo].[DeleteSP] @MASP varchar(10)
with Encryption
as
	Delete SANPHAM where MASP = @MASP
GO
-- sửa sản phẩm
GO
create proc [dbo].[UpdateSP]	
	@MASP varchar(10),
	@MALOAI varchar(10),
	@TENSP nvarchar(50),
	@DVT nvarchar(10),
	@DonGia int
with Encryption
as
	update SANPHAM
	set MASP=@MASP,MALOAI = @MALOAI,TENSP = @TENSP  , DVT = @DVT , DonGia = @DonGia
	where MASP=@MASP
GO	
-- tạo cursor tính tổng sản phẩm
declare tinhtongsp cursor Dynamic
For 
	Select count(*) FROM sanpham
	Open tinhtongsp
	declare @sosp int
FETCH NEXT FROM tinhtongsp INTO @sosp
WHILE (@@FETCH_STATUS=0)
BEGIN
	
	 select count(*) 
	from sanpham 
	FETCH NEXT FROM tinhtongsp INTO @sosp
END
Close tinhtongsp
Deallocate tinhtongsp
--thủ tục tổng sp
go
create proc tongsp
as
		declare tinhtongsp cursor Dynamic
		For 
			Select count(*) FROM sanpham
			Open tinhtongsp
			declare @sosp int
		FETCH NEXT FROM tinhtongsp INTO @sosp
		WHILE (@@FETCH_STATUS=0)
		BEGIN
	
			 select count(*) 
			from sanpham 
			FETCH NEXT FROM tinhtongsp INTO @sosp
		END
		Close tinhtongsp
		Deallocate tinhtongsp
--transaction--
--1. Them 1 loai moi vao bang Loai, kiem tra co tat ca bao nhieu loai
declare @MaL varchar(10)
set @MaL = 'L007'
declare @TenL nvarchar(50)
set @TenL = N'Sua Tuoi'

begin tran ThemLoai
	insert into LOAI(MALOAI,TENLOAI) values (@MaL,@TenL)
	----
	select COUNT(*) from LOAI
commit tran ThemLoai
go
--rollback tran ThemLoai
--2. Kiem tra ma ban da ton tai chua, neu chua them moi 
--Ông chưa use lộn bài rồi
declare @Ma varchar(10)
set @Ma = 'B011'
declare @So nvarchar(50)
set @So = 11

begin tran Ktra
	if exists(select * from BAN where MABAN = @Ma)
		print 'Da ton tai ma ban nay!!!'
	else
		insert into BAN(MABAN,SOBAN) values (@Ma,@So)
commit tran Ktra
go
use QLCF_TTHQT
go
select * from CHITIETHD








