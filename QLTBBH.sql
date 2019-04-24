create database QUANLYBHTB1;

use QUANLYBHTB1;


create table nhomhang (
	maNH int identity(1,1) not null primary key,
	tenNH nvarchar(30) );

create table hanghoa (
	maHH int identity(1,1) not null primary key,
	tenHH nvarchar(30),
	dacdiem nvarchar(50),
	dactinh nvarchar(50),
	maNH int not null );

create table hangban (
	maHB int identity(1,1) not null primary key,
	tenHB nvarchar(30),
	SL int,
	gia float,
	TGbaohanh date,
	maHH int not null );

create table HDbanhang (
	maHD int identity(1,1) not null primary key,
	tenNV nvarchar(30),
	tenKH nvarchar(30),
	TGban date,
	tinhtrangHD nvarchar(30),
	maHB int not null );

create table phieunhan (
	maPN int identity(1,1) not null primary key,
	tenNV nvarchar(30),
	tenKH nvarchar(30),
	diachiKH nvarchar(50),
	ngaynhan date,
	ngaytra date,
	maHB int not null );

create table TBbaohanh (
	maTBBH int identity(1,1) not null primary key,
	tinhtrangBH nvarchar(50),
	PDnguyennhan nvarchar(50),
	maHB int not null );

create table nhatkiBH (
	maNKBH int identity(1,1) not null primary key,
	nguyennhan nvarchar(50),
	cachgiaiquyet nvarchar(50),
	tenNV nvarchar(30),
	ngayBD date,
	ngayKT date,
	maTBBH int not null );


alter table hanghoa add constraint FK_HH_NH	foreign key(maNH) references nhomhang(maNH)on delete no action on update no action;

alter table hangban add constraint FK_HB_HH  foreign key(maHH) references hanghoa(maHH)on delete no action on update no action;					

alter table HDbanhang   add constraint FK_HDBH_HB foreign key(maHB) references hangban(maHB)on delete no action on update no action;

alter table phieunhan  add constraint FK_PN_HB foreign key(maHB) references hangban(maHB)on delete no action on update no action;
							
alter table TBbaohanh add constraint FK_TBBH_HB	foreign key(maHB) references hangban(maHB)on delete no action on update no action;

alter table nhatkiBH add constraint FK_NKBH_TBBH	foreign key(maTBBH) references TBbaohanh(maTBBH)on delete no action on update no action;
--thêm dữ liệu--

insert into nhomhang values 
	( N'thiết bị nhập'),
	( N'thiết bị xuất'),
	( N'thiết bị xử lý');
	select*from nhomhang


insert into hanghoa values  
	( N'màn hình', N'màn mỏng', N'hiển thị', 2),
	( N'bàn phím', N'màu đen', N'nhập kí tự', 1),
	( N'loa', N'loa tròn', N'phát âm thanh', 2),
	( N'chip',N'kích thước nhỏ', N'xử lý',3), 
	( N'chuột',N'không dây', N'hỗ trợ',1);
	select * from hanghoa

insert into hangban values  
	( N'màn hình', '3' , '500000', '6/30/2019',1),
	( N'loa', '2', '200000', '5/30/2019',3),
	( N'chuột', '4' , '100000','4/30/2019',5);
	
	select * from hangban

insert into HDbanhang values   
	 (N'Nguyễn Hòa', N'Nguyễn Hà','1/2/2019', N'trả góp',1),
     (N'Nguyễn Thảo', N'Vũ Thanh','12/1/2018', N'đã thanh toán', 3),
	 (N'Vũ Thúy',N'Lê Linh','3/20/2019',N'đã thanh toán',2);
	
	select * from HDbanhang
	
insert into phieunhan values		
	(N'Mai',N'Nguyễn Hà',N'hà nội','4/1/2019', '5/1/2019',1),
	(N'Lan',N'Lê Linh',N'phú thọ', '3/8/2019','4/28/2019',2),
	(N'Hương',N'Vũ Thanh',N'ninh bình','4/10/2019','4/25/2019',3);
	
	select *from phieunhan

insert into TBbaohanh values		
	(N'mất kết nối',N'hỏng usb',3),
	(N'nhiễu hình',N'lỏng cáp màn hình',1),
	(N'mất tiếng',N'đứt dây',2);
	select *from TBbaohanh

insert into nhatkiBH values		
	(N'hỏng usb',N'thay usb',N'hải','4/12/2019', '5/22/2019',1),
	(N'lỏng cáp',N'ép cáp',N'long','4/5/2019','4/25/2019',2),
	(N'đứt dây',N'nối dây',N'nam','3/10/2019','4/26/2019',3);
	select *from nhatkiBH

---1 Bảng nhóm hàng---
create  proc select_NH
as
select *from [dbo].[nhomhang]  
	--thêm nhóm hàng
	create proc insert_NH
	@ma int,
	@ten nvarchar(30)
	as
	insert into [dbo].[nhomhang] values(@ten)
	go
	--update nhóm hàng
	create proc update_NH
	@ma int,
	@ten nvarchar(30)
	as
	update [dbo].[nhomhang] set [tenNH]=@ten where [maNH]=@ma
	go
		--xóa nhóm hàng
	create proc delete_NH
	@ma int
	as 
	delete from [dbo].[nhomhang] where [maNH]=@ma
	go


---2 Bảng hàng hóa
create  proc select_HH
as
select maHH, tenHH, dacdiem, dactinh, tenNH from hanghoa inner join nhomhang
on hanghoa.maNH=nhomhang.maNH

	--thêm hàng hóa
	create proc insert_HH
	--@mahh int,
	@tenhh nvarchar(50),
	@dacdiem nvarchar(50),
	@dactinh nvarchar(50),
	@manh int
	as
	begin 
		insert into hanghoa(tenHH,dacdiem,dactinh,maNH)
		values(@tenhh,@dacdiem,@dactinh,@manh)
	END
	GO
	--update hàng hóa
	create proc update_HH
	@mahh int,
	@tenhh nvarchar(50),
	@dacdiem nvarchar(50),
	@dactinh nvarchar(50),
	@manh int
	as
	update [dbo].[hanghoa]
	set tenHH=@tenhh, dacdiem=@dacdiem, dactinh=@dactinh, maNH=@manh 
	where maHH=@mahh
	go
	--delete hàng hóa 
	create proc delete_HH
	@mahh int
	as
	delete from [dbo].[hanghoa] where maHH=@mahh
	go


---3 Bảng hàng bán 
create  proc select_HB
as
select maHB, tenHB, SL, gia, TGbaohanh,tenHH from hangban inner join hanghoa
on hangban.maHH=hanghoa.maHH

	--thêm hàng bán
	create proc insert_HB
---	@mahb int,
	@tenhb nvarchar(50),
	@sl int,
	@gia float,
	@tgbaohanh date,
	@mahh int
	as
	begin 
		insert into hangban(tenHB,SL,gia,TGbaohanh, maHH)
		values(@tenhb,@sl,@gia,@tgbaohanh,@mahh)
	END
	GO
	--update hàng bán 
	create proc update_HB
	@mahb int,
	@tenhb nvarchar(50),
	@sl int,
	@gia float,
	@tgbaohanh date,
	@mahh int
	as
	update hangban
	set tenHB=@tenhb, SL=@sl, gia=@gia, TGbaohanh=@tgbaohanh, maHH=@mahh
	where maHB=@mahb
	go
	--delete hàng bán
	create proc delete_HB
	@mahb int
	as
	delete from hangban where maHB=@mahb
	go


---4 Bảng hóa đơn bán hàng
create  proc select_HDBH
as
select *from  HDbanhang
	--thêm HDBH
	create proc insert_HDBH1
	----@mahd int,
	@tennv nvarchar(50),
	@tenkh nvarchar(50),
	@tgban date,
	@tinhtranghd nvarchar(50),
	@mahb int
	as
	begin 
		insert into HDbanhang(tenNV,tenKH,TGban,tinhtrangHD,maHB)
		values(@tennv, @tenkh, @tgban, @tinhtranghd,@mahb)
	END
	GO
	--update HDBH
	create proc update_HDBH
	@mahd int,
	@tennv nvarchar(50),
	@tenkh nvarchar(50),
	@tgban date,
	@tinhtranghd nvarchar(50),
	@mahb int
	as
	update HDbanhang
	set tenNV=@tennv, tenKH=@tenkh, TGban=@tgban, tinhtrangHD=@tinhtranghd, maHB=@mahb
	where maHD=@mahd
	go
	--delete hdbh
	create proc delete_HDBH
	@mahd int
	as
	delete from HDbanhang where maHD=@mahd
	go


---5 Bảng phiếu nhận
create  proc select_PN
as
select *from  phieunhan
	--thêm phiếu nhận
	create proc insert_PN
	@mapn int,
	@tennv nvarchar(50),
	@tenkh nvarchar(50),
	@diachikh nvarchar(50),
	@ngaynhan date,
	@ngaytra date,
	@mahb int
	as
	begin 
		insert into phieunhan(tenNV,tenKH,diachiKH,ngaynhan,ngaytra,maHB)
		values(@tennv, @tenkh,@diachikh,@ngaynhan,@ngaytra,@mahb)
	END
	GO
	--update phiếu nhận
	create proc update_PN
	@mapn int,
	@tennv nvarchar(50),
	@tenkh nvarchar(50),
	@diachikh nvarchar(50),
	@ngaynhan date,
	@ngaytra date,
	@mahb int
	as
	update phieunhan
	set tenNV=@tennv, tenKH=@tenkh, diachiKH=@diachikh, ngaynhan=@ngaynhan, ngaytra=@ngaytra, maHB=@mahb
	where maPN=@mapn
	go
	--delete phieunhan
	create proc delete_PN
	@mapn int
	as
	delete from phieunhan where maPN=@mapn
	go


---6 Bảng thiết bị bảo hành
create  proc select_TBBH
as
select *from  TBbaohanh
	--thêm thiết bị bảo hành 
	create proc insert_TBBH
	@matbbh int,
	@tinhtrangbh nvarchar(50),
	@pdnguyennhan nvarchar(50),
	@mahb int
	as
	begin 
		insert into TBbaohanh(maTBBH,tinhtrangBH,PDnguyennhan,maHB)
		values(@matbbh,@tinhtrangbh,@pdnguyennhan,@mahb)
	end
	go
	--update  thiết bị bảo hành
	create proc update_TBBH
	@matbbh int,
	@tinhtrangbh nvarchar(50),
	@pdnguyennhan nvarchar(50),
	@mahb int
	as
	update TBbaohanh
	set tinhtrangBH=@tinhtrangbh,PDnguyennhan=@pdnguyennhan,maHB=@mahb
	where maTBBH=@matbbh
	go
	--delete  thiết bị bảo hành
	create proc delete_TBBH
	@matbbh int
	
	as
	delete from TBbaohanh where maTBBH=@matbbh
	go


---7 Bảng nhật kí bảo hành
create  proc select_NKBH
as
select *from  nhatkiBH
	--thêm nhật kí bảo hành
	create proc insert_NKBH
	@mankbh int,
	@nguyennhan nvarchar(50),
	@cachgiaiquyet nvarchar(50),
	@tennv nvarchar(50),
	@ngaybd date,
	@ngaykt date,
	@matbbh int
	as
	begin 
		insert into nhatkiBH(nguyennhan,cachgiaiquyet,tenNV,ngayBD,ngayKT,maTBBH)
		values(@nguyennhan,@cachgiaiquyet,@tennv,@ngaybd,@ngaykt,@matbbh)
	end
	go
	--update  nhật kí bảo hành
	create proc update_NKBH
	@mankbh int,
	@nguyennhan nvarchar(50),
	@cachgiaiquyet nvarchar(50),
	@tennv nvarchar(50),
	@ngaybd date,
	@ngaykt date,
	@matbbh int
	as
	update nhatkiBH
	set nguyennhan=@nguyennhan,cachgiaiquyet=@cachgiaiquyet,tenNV=@tennv,ngayBD=@ngaybd,ngayKT=@ngaykt,maTBBH=@matbbh
	where maNKBH=@mankbh
	go
	--delete  nhật kí bảo hành
	create proc delete_NKBH
	@mankbh int
	as
	delete from nhatkiBH where maNKBH=@mankbh
	go


----lấy ra thông tin hàng bán
	go
	create proc rp_gia
	as
	select * from hangban
	exec rp_gia

	create view vw_gia
	as
	select * from hangban

	-------thay mã bằng tên ------
--- nhóm hàng 
create proc cbo_nhomhang
as
select maNH, tenNH from nhomhang

--- hàng hóa 
create proc cbo_hanghoa
as
select maHH, tenHH from hanghoa
