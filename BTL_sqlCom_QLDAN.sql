create database BTL_QuanLyCuaHangDoAnNhanh
on primary
(
	Name = BTL_QLDAN_DATA,
	Filename = 'D:\HQTCSDL\BTL_HQTCSDL\BTL_QLDAN_data.mdf',
	Size = 10MB,
	MaxSize = UNLIMITED,
	Filegrowth = 5MB
)
Log on
(
	Name = BTL_QLDAN_LOG,
	Filename = 'D:\HQTCSDL\BTL_HQTCSDL\BTL_QLDAN_log.ldf',
	Size = 5MB,
	MaxSize = UNLIMITED,
	FileGrowth=1MB
)
go
use BTL_QuanLyCuaHangDoAnNhanh
create table nhanvien(
manv varchar(10) not null primary key,    --mã nhân viên
hoten Nvarchar(30),              --họ tên
ngaysinh date,                   --ngày sinh
diachi Nvarchar(30),             --địa chỉ
gioitinh Nvarchar(10),           --giới tính
sodienthoai int)                 --số điện thoại

create table sanpham(
masp varchar(10) not null primary key,    --mã sản phẩm
tensp Nvarchar(30),              --tên sản phẩm
giaban int)                      --giá bán

create table hoadonra(
mahdr varchar(10) not null primary key,   --mã hóa đơn
masp varchar(10),                --mã sản phẩm
soluong int,                     --số lượng
thanhtien int,                   --thành tiền
ngayban date,                    --ngày bán
manv varchar(10) foreign key (manv) references nhanvien(manv))     --mã nhân viên

create table khachhang(
makh varchar(10) primary key not null,                             --mã khách hàng
tenkh Nvarchar(30),                                                --tên khách hàng
diachi Nvarchar(30),                                               --địa chỉ
sdt int,                                                           --số điện thoại
mahdr varchar(10) foreign key (mahdr) references hoadonra(mahdr))  --mã hóa đơn


create table nhapkho(                                              
ma varchar(10) primary key not null,                               --mã hàng nhập
ten Nvarchar(30),                                                  --tên hàng nhập
soluong int,                                                       --số lượng
gianhap int,                                                       --giá nhập
ngaynhap date,                                                     --ngày nhập
tonkho int,                                                        --tồn kho
manv varchar(10) foreign key (manv) references nhanvien(manv))     --mã nhân viên


insert into nhanvien values ('NV01',N'vũ mạnh dũng','12/12/1999',N'hà nội','Nam','0123456789')
insert into nhanvien values ('NV02',N'dương thanh khiên','09/01/1998',N'hà nội','Nam','0123456788')
insert into nhanvien values ('NV03',N'nguyễn minh chiều','09/09/1999',N'hải phòng','Nam','012345677')
insert into nhanvien values ('NV04',N'nguyễn tuấn anh','04/30/1997',N'nam định','Nam','0123434367')
insert into nhanvien values ('NV05',N'quế ngọc hải','03/21/1996',N'tuyên quang','Nam','015445677')
insert into nhanvien values ('NV06',N'ngô kim hảo','11/22/1998',N'hà nội',N'Nữ','015445677')
insert into nhanvien values ('NV07',N'đặng thị trang','02/09/1995',N'bắc ninh',N'Nữ','012345457')
insert into nhanvien values ('NV08',N'lê hữu độ','10/14/1993',N'hà nam','Nam','0123457677')
insert into nhanvien values ('NV09',N'nguyễn quỳnh trang','09/23/1999',N'ninh bình',N'Nữ','012345657')
insert into nhanvien values ('NV10',N'ngô văn hải','05/15/1999',N'hòa bình','Nam','012345327')
insert into nhanvien values ('NV11',N'lương xuân trường','08/13/1998',N'hà nội','Nam','012875377')
insert into nhanvien values ('NV12',N'nguyễn ngọc trinh','07/27/1999',N'hải dương',N'Nữ','013958677')
insert into nhanvien values ('NV13',N'mai hồng ngọc','06/11/1996',N'thái nguyên',N'Nữ','012059477')
insert into nhanvien values ('NV14',N'trịnh diệu linh','12/17/1995',N'thanh hóa',N'Nữ','012341538')
insert into nhanvien values ('NV15',N'ngất văn đại','10/19/1997',N'hải phòng','Nam','012384057')
insert into nhanvien values ('NV16',N'đặng văn lâm','11/12/1998',N'thanh hóa','Nam','012874077')
insert into nhanvien values ('NV17',N'nguyễn tiến linh','08/02/1993',N'hà tĩnh','Nam','012003577')
insert into nhanvien values ('NV18',N'hà đức chinh','02/06/1992',N'hà nội','Nam','012346643')
insert into nhanvien values ('NV19',N'nguyễn anh đức','02/09/1994',N'bắc ninh','Nam','012341121')
insert into nhanvien values ('NV20',N'bùi thị hoa','01/08/1993',N'bắc giang',N'Nữ','012399783')
insert into nhanvien values ('NV21',N'chu việt hoàng','06/30/1997',N'hưng yên','Nam','012354287')
insert into nhanvien values ('NV22',N'nguyễn thị ánh viên','05/27/1996',N'hà nội',N'Nữ','012300437')
insert into nhanvien values ('NV23',N'lê tú vi','12/03/1999',N'hưng yên',N'Nữ','012874377')

insert into sanpham values ('sp01',N'gà chiên','20000')
insert into sanpham values ('sp02',N'xúc xích rán','10000')
insert into sanpham values ('sp03',N'nem chua','5000')
insert into sanpham values ('sp04',N'bánh mì pate','20000')
insert into sanpham values ('sp05',N'cá viên chiên','30000')
insert into sanpham values ('sp06',N'bánh xèo','10000')
insert into sanpham values ('sp07',N'bánh tráng trộn','15000')
insert into sanpham values ('sp08',N'pizza','40000')
insert into sanpham values ('sp09',N'humberger','50000')
insert into sanpham values ('sp10',N'ốc vặn hấp','20000')
insert into sanpham values ('sp11',N'thịt xiên nướng','19000')
insert into sanpham values ('sp12',N'phở cuốn','10000')
insert into sanpham values ('sp13',N'trứng cút lôn','5000')
insert into sanpham values ('sp14',N'chân gà xả ớt','25000')
insert into sanpham values ('sp15',N'khoai lang kén','9000')
insert into sanpham values ('sp16',N'hotdog','22000')
insert into sanpham values ('sp17',N'chè thập cẩm','12000')
insert into sanpham values ('sp18',N'tào phớ','7000')
insert into sanpham values ('sp19',N'sữa chua mít','15000')
insert into sanpham values ('sp20',N'sữa chua đánh đá','10000')
insert into sanpham values ('sp21',N'coca','6000')
insert into sanpham values ('sp22',N'weakup 247','9000')
insert into sanpham values ('sp23',N'nutri','8000')
insert into sanpham values ('sp24',N'pepsi','7000')
insert into sanpham values ('sp25',N'bia hà nội','12000')
insert into sanpham values ('sp26',N'gà nướng susan','30000')



insert into hoadonra values ('HD01','sp01','2','40000','10/10/2018','NV01')
insert into hoadonra values ('HD02','sp02','3','30000','11/30/2018','NV02')
insert into hoadonra values ('HD03','sp04','1','20000','09/14/2018','NV01')
insert into hoadonra values ('HD04','sp03','4','15000','01/15/2018','NV03')
insert into hoadonra values ('HD05','sp02','5','50000','01/17/2018','NV01')
insert into hoadonra values ('HD06','sp01','3','60000','08/29/2018','NV02')
insert into hoadonra values ('HD07','sp05','1','30000','07/11/2018','NV03')
insert into hoadonra values ('HD08','sp07','6','90000','05/01/2018','NV01')
insert into hoadonra values ('HD09','sp07,sp03','2','20000','01/11/2019','NV02')
insert into hoadonra values ('HD10','sp06,sp12','4','40000','01/11/2019','NV04')
insert into hoadonra values ('HD11','sp07,sp22','3','39000','01/11/2019','NV03')
insert into hoadonra values ('HD12','sp13,sp23','6','36000','01/11/2019','NV02')
insert into hoadonra values ('HD13','sp12','5','50000','01/11/2019','NV02')
insert into hoadonra values ('HD14','sp04','2','40000','01/11/2019','NV01')
insert into hoadonra values ('HD15','sp05,sp06','6','100000','02/11/2019','NV01')
insert into hoadonra values ('HD16','sp16,sp18','4','65000','02/12/2019','NV05')
insert into hoadonra values ('HD17','sp10,sp24','4','54000','02/12/2019','NV05')
insert into hoadonra values ('HD18','sp05','4','120000','02/12/2019','NV03')
insert into hoadonra values ('HD19','sp02','7','70000','02/12/2019','NV03')
insert into hoadonra values ('HD20','sp01','5','100000','02/12/2019','NV01')
insert into hoadonra values ('HD21','sp08','6','240000','02/12/2019','NV05')
insert into hoadonra values ('HD22','sp14','3','75000','02/12/2019','NV04')
insert into hoadonra values ('HD23','sp15','10','90000','02/12/2019','NV01')
insert into hoadonra values ('HD24','sp08','2','80000','03/12/2019','NV03')

insert into khachhang values ('KH01',N'vũ đức đạt',N'hà nội',			'01112145','HD01')
insert into khachhang values ('KH02',N'nguyễn quang hải',N'nam định',	'01112134','HD02')
insert into khachhang values ('KH03',N'đoàn văn hậu',N'hải phòng',		'0134748284','HD03')
insert into khachhang values ('KH04',N'bùi tiến dũng',N'hải dương',		'0937495473','HD04')
insert into khachhang values ('KH05',N'hà đức chinh',N'hà nội',			'0874993642','HD05')
insert into khachhang values ('KH06',N'đào ngọc hà',N'hà nội',			'0794048032','HD06')
insert into khachhang values ('KH07',N'nhật kim anh',N'bắc ninh',		'0947859201','HD07')
insert into khachhang values ('KH08',N'vũ mạnh dũng',N'hà nội',			'0974902843','HD08')
insert into khachhang values ('KH09',N'lê thị thúy',N'hưng yên',		'0903748294','HD09')
insert into khachhang values ('KH10',N'lê diệu hương',N'hà nam',		'0438472903','HD10')
insert into khachhang values ('KH11',N'châu việt cường',N'hà nội',		'0900485921','HD11')
insert into khachhang values ('KH12',N'bùi anh tuấn',N'hà nội',			'0937482741','HD12')
insert into khachhang values ('KH13',N'nguyễn đan trường',N'hải phòng',	'0389473993','HD13')
insert into khachhang values ('KH14',N'châu đăng khoa',N'hải dương',	'0370003742','HD14')
insert into khachhang values ('KH15',N'nguyễn thị hoa',N'hà nội',		'0363850032','HD15')
insert into khachhang values ('KH16',N'trịnh thị hạnh',N'nam định',		'0284930284','HD16')
insert into khachhang values ('KH17',N'doãn phương dung',N'hà nội',		'0948462903','HD17')
insert into khachhang values ('KH18',N'mai phương thúy',N'hà nội',		'0893748200','HD18')
insert into khachhang values ('KH19',N'ông cao thắng',N'hà nội',		'0123467200','HD19')
insert into khachhang values ('KH20',N'nguyễn phương thảo',N'nam định',	'0284700004','HD20')
insert into khachhang values ('KH21',N'nguyễn thị thu phương',N'hải dương','0947849044','HD21')
insert into khachhang values ('KH22',N'dương thanh khiên',N'hưng yên',	'0948274900','HD22')

insert into nhapkho values ('sp01',N'đùi gà','100','15000','10/18/2019','10','NV06')
insert into nhapkho values ('sp02',N'xúc xích','200','8000','10/18/2019','20','NV06')
insert into nhapkho values ('sp03',N'nem chua','300','3000','10/18/2019','9','NV06')
insert into nhapkho values ('sp04',N'gà','10','1000000','10/18/2019','0','NV07')
insert into nhapkho values ('sp05',N'coca','100','500000','10/18/2019','10','NV08')
insert into nhapkho values ('sp06',N'bia hà nội','100','700000','10/18/2019','20','NV07')
insert into nhapkho values ('sp07',N'óc đậu','10','100000','10/18/2019','1','NV08')
insert into nhapkho values ('sp08',N'cá viên chiên','30','600000','10/18/2019','5','NV07')
insert into nhapkho values ('sp09',N'trứng lộn','200','600000','10/18/2019','0','NV06')
insert into nhapkho values ('sp10',N'weakup 247','100','600000','10/18/2019','10','NV08')
insert into nhapkho values ('sp11',N'nutri','50','250000','10/19/2019','4','NV06')
insert into nhapkho values ('sp12',N'mít','3','150000','10/19/2019','1','NV07')
insert into nhapkho values ('sp13',N'ốc','20','200000','10/19/2019','0','NV08')
insert into nhapkho values ('sp14',N'sữa chua','200','1000000','10/19/2019','30','NV08')
insert into nhapkho values ('sp15',N'bánh mì','30','90000','10/19/2019','0','NV06')
insert into nhapkho values ('sp16',N'thịt lợn','30','1500000','10/19/2019','1','NV07')
insert into nhapkho values ('sp17',N'thịt bò','10','1500000','10/19/2019','2','NV08')
insert into nhapkho values ('sp18',N'phở','10','200000','10/19/2019','0','NV06')
insert into nhapkho values ('sp19',N'bánh đa','100','200000','10/19/2019','10','NV07')


/* view đưa ra những khách hàng ở hà nội*/
create view khach(makh, tenkh, sdt)
as
select makh,tenkh,sdt
from khachhang
where khachhang.diachi=N'hà nội'
select * from khach

/* view cho biết khách hàng nào hóa đơn cao nhất */
create view hoadon(mahdr,masp,manv,thanhtien)
as
select mahdr,masp,manv,thanhtien
from hoadonra
where thanhtien=(select max(thanhtien) from hoadonra)

select *from hoadon

/*tạo viewsanpham in ra tất cả các sản phẩm có lượng tồn kho trên 10 */
create view viewtonkho(ma,ten,tonkho)
as
select ma,ten,tonkho
from nhapkho
where tonkho>10
select * from viewtonkho

/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

/*hàm đưa ra lượng hàng còn tồn kho của các sản phẩm vào kho với tham số truyền vào là các mặt hàng */
create function tongtonkho(@ten Nvarchar(30))
returns @bien Table(ma varchar(10),ten nvarchar(30),ngaynhap date,tonkho int)
as begin
	insert into @bien
	select nhapkho.ma,nhapkho.ten,nhapkho.ngaynhap,nhapkho.tonkho
	from nhapkho
	where nhapkho.ten=@ten
	return
end
select  *from tongtonkho('xúc xích')


/*hàm trả về danh sách nhân viên sinh sau ngày nào đó, ngày là tham số truyền vào */
create function BangNV(@Ngaysinh date)
returns table
as
return(select * from nhanvien where nhanvien.ngaysinh> @Ngaysinh)
select * from BangNV('10/5/1999')


/* hàm in ra mã sinh viên và họ tên của nhân viên đã bán được sản phẩm nào đó, với sản phẩm là tham số truyền vào */
create function dsnv_sanpham(@tensp  Nvarchar(30))
returns @bien TABLE(manv varchar(10),hoten Nvarchar(30))
as 
begin
insert into @bien
select nhanvien.manv,nhanvien.hoten
from nhanvien, hoadonra,sanpham 
where nhanvien.manv = hoadonra.manv
and hoadonra.masp=sanpham.masp
and sanpham.tensp=@tensp
return
end
select * from dsnv_sanpham('gà chiên')


/* viet ham tính số lượng hóa đơn các sản phẩm đã được bán, với sản phẩm là tham số được truyền vào*/
create function slsp_tensp(@tensp Nvarchar(30))
returns int 
as
begin
declare @SL int;
select @SL = count(mahdr)
from  sanpham ,hoadonra
where hoadonra.masp= sanpham.masp
and sanpham.tensp = @tensp
return @SL
end

select  dbo.slsp_tensp('xúc xích rán')

/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/


/* trigger tự động tính thanhtien của bảng hoadonra khi thêm 1 bản ghi mới gồm mahdr,masp,soluong */
create trigger thanhtienn
on hoadonra
for insert as
if((select masp from inserted) is not null)
begin
update hoadonra
set thanhtien=soluong*giaban
from hoadonra,sanpham,(select masp,mahdr from inserted) as I
where sanpham.masp=hoadonra.masp
and hoadonra.mahdr=I.mahdr
and sanpham.masp=I.masp
end

insert into hoadonra(mahdr,masp,soluong) values ('HD25','sp02','5')


/* trigger xóa */
create trigger delete_trigger
On hoadonra
instead of delete
as
begin
delete from khachhang
where mahdr=(select mahdr from deleted)
delete from hoadonra
where mahdr=(select mahdr from deleted)
end

delete from hoadonra
where mahdr='HD01'


/*Thêm vào bảng nhanvien ràng buộc không cho phép ngày sinh của nhân viên >ngày hiện tại*/
 create Trigger insert_trigger_nhanvien
 on nhanvien
 for insert 
 as
 begin
 if(select ngaysinh from inserted)>getdate()
 begin
  print N'ngày sinh của nhân viên sai !'
 rollback tran
 end
 end

 insert into nhanvien values ('NV30',N'nguyễn văn nam','02/02/1999',N'tuyên quang',N'Nam','012345423')


/* trigger nếu người dùng muốn thay đổi makh của bảng khách hàng thì không cho phép hiển thị thông báo */
create trigger update_makh
on khachhang
for update as
if UPDATE(makh)
begin
print N'không thể thay đổi makh'
rollback transaction
end

update khachhang
set makh='KH05'
where makh='KH26'


/*-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

/*thủ tục tìm kiếm 1 khách hàng nào đó*/ 
create proc sp_tkkh @tenkh Nvarchar(30)
as begin
if(@tenkh='')
select N'không có' as makh, N'không có' as tenkhach, N'không có' as diachi, N'không có' as sdt, N'không có' as mahdr
else begin
select makh,tenkh,diachi,sdt,mahdr
from khachhang
where tenkh like @tenkh+'' or makh like @tenkh+''
end end

sp_tkkh N'nguyễn quang hải'



/*thủ tục tìm 1 nhân viên nào đó, với địa chỉ là tham số truyền vào */
create procedure dsnv_theoTinh @Tinh Nvarchar(30)
as
begin
select *from nhanvien
where nhanvien.diachi like @Tinh
end
use BTL_QuanLyCuaHangDoAnNhanh
execute dsnv_theoTinh N'hải phòng'
drop procedure dsnv_theoTinh

/* thủ tục đếm số hóa đơn bán được trong một ngày nào đó  */
create PROCEDURE tinhtong
@thang date
as
begin
select count (mahdr) as N'số hóa đơn bán được', sum(thanhtien) as N'số tiền thu về'
from hoadonra
where hoadonra.ngayban=@thang
end

tinhtong @thang='01/11/2019'

/* thủ tục tính tổng số tiền phải chi khi nhập hàng một ngày nào đó trong năm */
create proc tinhtongtien
@thang date
as
begin
select sum(gianhap) as'tổng số tiền phải chi là:'
from nhapkho
where nhapkho.ngaynhap=@thang
end

tinhtongtien @thang='10/18/2019'


/*thủ tục trả về kiểu biên con trỏ chứa danh sách nhan viên có giới tính được truyền vào là tham số*/

create procedure thuTucCursor
@gioitinh nvarchar (10),
@dsnv cursor varying output
as
begin
set @dsnv = CURSOR
FOR
select * 
from nhanvien
where gioitinh=@gioitinh	
Open @dsnv
End

declare @myCURSOR  CURSOR
exec thuTucCursor N'nam', @dsnv =@myCURSOR  OUTPUT
FETCH NEXT from  @myCURSOR
while (@@FETCH_STATUS =0)
FETCH NEXT from @myCURSOR
close @myCURSOR
deallocate @myCURSOR;

--------------------------------------------------------------------------------------------------------------


/* phân quyền và bảo mật */

--tạo SQL Server login

 sp_addlogin 'admin','admin'
 sp_addlogin 'nhanvien','nhanvien'

-- Tạo database user
use BTL_QuanLyCuaHangDoAnNhanh
exec sp_grantdbaccess 'admin','giamdoc'

use BTL_QuanLyCuaHangDoAnNhanh
exec sp_grantdbaccess 'nhanvien','nv'


--cấp quyền cho user giamdoc
grant Select, insert, update, delete to giamdoc
grant select on khach to giamdoc
grant select on hoadon to giamdoc
grant select on viewtonkho to giamdoc
grant select on tongtonkho to giamdoc
grant select on Bangnv to giamdoc
grant select on dsnv_sanpham to giamdoc

--xóa user trong CSDL
-- /// sp_revokedbaccess ‘user name’  ///


--Cấp quyền cho user nv
grant select, insert , update, delete on hoadon to nv
grant select, insert , update, delete on khachhang to nv
grant select, insert , update, delete on sanpham to nv
grant select, insert , update, delete on nhapkho to nv


create table quyen
(
	tentk nvarchar(50),
	mk nvarchar(50),
	quyen nvarchar(50)
)

insert into quyen values (N'admin',N'admin',N'admin')
insert into quyen values (N'nhanvien',N'nhanvien',N'nv')
insert into quyen values (N'admin',N'giamdoc',N'giamdoc')