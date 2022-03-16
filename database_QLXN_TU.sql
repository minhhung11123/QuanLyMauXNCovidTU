create database QLXN_TU
go
use QLXN_TU
go
create table TaiKhoan
(
	ID int identity not null primary key,
	TenDangNhap varchar(32) not null,
	MatKhau varchar(32) not null,
	Ten nvarchar(50) not null,
	QuyenHan tinyint not null,
	TrangThai bit not null default 1
)
go
create table PhanQuyen
(
	ID int not null primary key,
	MoTa nvarchar not null
)
go
create table BenhPham
(
	ID bigint identity not null,

)