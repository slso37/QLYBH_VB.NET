
----------TẠO DATABASE QUAN LY BAN HANG-----------
--Xóa Database cũ (nếu có)
IF EXISTS(SELECT name FROM sysDATABASEs WHERE name='QLYBH')
DROP DATABASE QLYBH
GO
--Tạo Database mới
CREATE DATABASE QLYBH
GO
USE QLYBH
GO
----------TẠO CÁC BẢNG-----------
--1. Tạo bảng tblKhachHang
--Kiểm tra xem Table tblKhachHang đã tồn tại chưa nếu có thì xóa và tạo mới
IF EXISTS(SELECT name FROM sysobjects WHERE name='tblKhachHang')
DROP TABLE tblKhachHang
GO
--Tạo bảng
CREATE TABLE tblKhachHang 
(
MaKH NVarChar(50) NOT null, 
HoTen NVarChar(50) NOT null, 
NgaySinh Date NOT null, 
GioiTinh NvarChar (5) NOT null, 
DiaChi NVarChar (150) NOT null, 
DienThoai Varchar(20)			          
CONSTRAINT PK_KhachHang PRIMARY KEY(MaKH)
)
GO
--2. Tạo bảng MatHang
IF EXISTS(SELECT name FROM sysobjects WHERE name='tblMatHang')
DROP TABLE tblMatHang
GO
CREATE TABLE tblMatHang
(
MaMH NVarChar(50) NOT null,
TenMatHang NVarChar(50) NOT null, 
DVT NVarChar(10) NOT null
CONSTRAINT PK_MatHang PRIMARY KEY(MaMH)
)
--3. Tạo bảng tblBanHang
IF EXISTS(SELECT name FROM sysobjects WHERE name='tblBanHang')
DROP TABLE tblBanHang
GO
CREATE TABLE tblBanHang
(
SoHieuHD NVarChar(20) NOT null, 
MaKH NVarChar(50) NOT null,
NgayMuaBan Date, 
NguoiBanHang NVarChar(50)
CONSTRAINT PK_tblBanHang PRIMARY KEY(SoHieuHD),
CONSTRAINT FK_tblBanHang_tblKhachHang FOREIGN KEY(MaKH) REFERENCES tblKhachHang(MaKH)
)
--4. Tạo bảng tblChiTietBanHang
IF EXISTS(SELECT name FROM sysobjects WHERE name='tblChiTietBanHang')
DROP TABLE tblChiTietHoaDon
GO
--Cần phải tạo bảng Khoa trước bảng Nganh vì bảng Nganh tham chiếu đến MaKhoa của bảng Khoa
CREATE TABLE tblChiTietHoaDon
(
SoHieuHD NVarChar(20) NOT null,
MaMH NVarChar(50) NOT null, 
SoLuong Int NOT null, 
DonGia Float NOT null
CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY(SoHieuHD,MaMH), 
CONSTRAINT FK_tblChiTietHoaDon_tblMatHang FOREIGN KEY(MaMH) REFERENCES tblMatHang(MaMH)
)

--5. Tạo bảng TaiKhoan
IF EXISTS(SELECT name FROM sysobjects WHERE name='TaiKhoan')
DROP TABLE TaiKhoan
GO
CREATE TABLE TaiKhoan
(
TenDN NVarChar(20) NOT null,
MatKhau NVarChar(50) NOT null, 
CONSTRAINT PK_TenDN PRIMARY KEY(TenDN)
)
GO
--------------THÊM DỮ LIỆU VÀO BẢNG--------------
--1. Chèn dữ liệu cho bảng tblKhachHang
Set DateFormat DMY
Go
INSERT INTO tblKhachHang(MaKH, Hoten, NgaySinh, Gioitinh, Diachi, DienThoai) VALUES ('KH01',N'Trần Nguyên Hương','03/03/1980',N'Nam',N'Hà Nội', '0988180955')
INSERT INTO tblKhachHang(MaKH, Hoten, NgaySinh, Gioitinh, Diachi, DienThoai) VALUES ('KH02',N'Nguyễn Phương Dung','16/08/1981', N'Nữ',N'Thái Nguyên', '0981234566')
INSERT INTO tblKhachHang(MaKH, Hoten, NgaySinh, Gioitinh, Diachi, DienThoai) VALUES ('KH03',N'Trần Văn Ước','01/03/1981',N'Nam',N'Nam Định', '0989876789')
INSERT INTO tblKhachHang(MaKH, Hoten, NgaySinh, Gioitinh, Diachi, DienThoai) VALUES ('KH04',N'Hoàng Thu Phương','03/01/1987',N'Nữ',N'Hà Nội', '0985635679')
INSERT INTO tblKhachHang(MaKH, Hoten, NgaySinh, Gioitinh, Diachi, DienThoai) VALUES ('KH05',N'Trương Thị Thu Hà','19/05/1980',N'Nữ',N'Nghệ An', '0985676554')
Go
select * from tblKhachHang
Go
--2. Chèn dữ liệu cho bảng tblMatHang
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH01',N'Điện thoại',N'Chiếc')
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH02',N'Laptop',N'Chiếc')
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH03',N'Tivi',N'Chiếc')
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH04',N'Gạo',N'Kg')
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH05',N'Sắt',N'Cây')
INSERT INTO tblMatHang(MaMH,TenMatHang, DVT) VALUES ('MH06',N'Ấm chén',N'Bộ')
Go
select * from tblMatHang
Go

--3. Chèn dữ liệu cho bảng tblBanHang
SET dateformat DMY 
GO

INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD001','KH01','01/04/2022',N'Trần Thị Hoa')
INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD002','KH02','02/04/2022',N'Trần Thị Hoa')
INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD003','KH01','01/04/2022',N'Trần Thị Nga')
INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD004','KH03','12/04/2022',N'Nguyễn Thị Minh')
INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD005','KH04','01/04/2022',N'Phạm Văn Tiệp')
INSERT INTO tblBanHang(SoHieuHD,MaKH,NgayMuaBan,NguoiBanHang) VALUES ('HD006','KH04','01/05/2022',N'Hoàng Thị Tám')
Go
select * from tblBanHang
Go

--4. Chèn dữ liệu cho bảng tblChiTietHoaDon
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD001','MH01',7,2000000)
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD001','MH02',2,1000000)
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD001','MH03',1,2000000)
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD002','MH02',2,200000)
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD002','MH03',7,400000)
INSERT INTO tblChiTietHoaDon(SoHieuHD,MaMH,SoLuong, DonGia) VALUES ('HD003','MH04',9,300000)
Go
select * from tblChiTietHoaDon
Go

--5. Chèn dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan(TenDN,MatKhau) VALUES ('admin','admin')
INSERT INTO TaiKhoan(TenDN,MatKhau) VALUES ('huongtn','huongtn')
Go
select * from TaiKhoan
Go
CREATE PROCEDURE HoaDonBanHang  
@SoHieuHD NVarChar
AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;
-- Insert statements for procedure here
SELECT tblBanHang.*, tblKhachHang.HoTen, tblKhachHang.DienThoai, tblKhachHang.DiaChi,tblMatHang.TenMatHang, tblMatHang.DVT,tblChiTietHoaDon.SoLuong,  tblChiTietHoaDon.DonGia,tblChiTietHoaDon.SoLuong * tblChiTietHoaDon.DonGia  AS ThanhTien FROM tblBanHang, tblKhachHang, tblMatHang, tblChiTietHoaDon WHERE tblBanHang.MaKH = tblKhachHang.MaKH AND tblBanHang.SoHieuHD =tblChiTietHoaDon.SoHieuHD AND tblMatHang.MaMH = tblChiTietHoaDon.MaMH AND tblBanHang.SoHieuHD = @SoHieuHD
RETURN
END

set dateformat DMY
Go

select SoHieuHD, NgayMuaBan, NguoiBanHang  from tblBanHang, tblKhachHang where tblBanHang.MaKH=tblKhachHang.MaKH and tblKhachHang.MaKH='KH01'
Go
Select tblMatHang.MaMH, TenMatHang, SoLuong, DVT, DonGIa From tblMatHang, tblChiTietHoaDon where tblMatHang.maMH=tblChiTietHoaDon.MaMH and tblChiTietHoaDon.SoHieuHD='HD001'
