create database QuanLyHangHoa
go
use QuanLyHangHoa
go

create table DMChatLieu(
MaCLieu char(6) primary key,
TenCLieu nvarchar(20)
);

create table DMHang(
MaHang char(6) primary key,
TenHang nvarchar(20),
SoLuong int,
DonGiaNhap decimal(10,2),
DonGiaBan decimal(10,2),
Hinh nvarchar(100),
GhiChu nvarchar(100),
MaCLieu char(6),
FOREIGN KEY (MaCLieu) REFERENCES DMChatLieu(MaCLieu)
);
go
use QuanLyHangHoa
insert into DMChatLieu(MaCLieu,TenCLieu)
values
('CL01',N'Do dien tu'),
('CL02',N'Bong'),
('CL03',N'do de vo');