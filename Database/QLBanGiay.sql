﻿CREATE DATABASE QLBanGiay
GO
--
USE QLBanGiay
GO

--TABLE--
CREATE TABLE LoaiNguoiDung
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaLoaiNguoiDung VARCHAR(10) UNIQUE NOT NULL,
	TenLoaiNguoiDung NVARCHAR(20) --Merchant, Customer, Nhân viên--
)

--CREATE TABLE NhanVien
--(
--	Id UNIQUEIDENTIFIER PRIMARY KEY,
--	MaNhanVien VARCHAR(10) UNIQUE NOT NULL,
--	TenNhanVien NVARCHAR(100),
--	GioiTinh NVARCHAR(10),
--	NgaySinh DATE,
--	DiaChi NVARCHAR(200),
--	DienThoai VARCHAR(20),
--	CMND VARCHAR(20),
--	IdLoaiNguoiDung UNIQUEIDENTIFIER NOT NULL, --FK--
--	LuongCoBan FLOAT,
--	HeSoLuong FLOAT,
--	PhuCap FLOAT,
--	TongLuong FLOAT,
--	TinhTrang NVARCHAR(20)
--)

CREATE TABLE TaiKhoan
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	TaiKhoan VARCHAR(20) UNIQUE NOT NULL,
	MatKhau VARCHAR(30) NOT NULL,
	Email VARCHAR(100),
	Ten NVARCHAR(100),
	DienThoai VARCHAR(20),
	CMND VARCHAR(20),
	IdLoaiNguoiDung UNIQUEIDENTIFIER NOT NULL, --FK--
	NgayTao DATETIME,
	DanhGia FLOAT,
	TinhTrang NVARCHAR(20)
)

CREATE TABLE DanhGia
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdTaiKhoanDanhGia UNIQUEIDENTIFIER NOT NULL, --FK (Id người đánh giá)--
	IdTaiKhoanDuocDanhGia UNIQUEIDENTIFIER NOT NULL, --FK (Id người được đánh giá)--
	Diem FLOAT --Điểm đánh giá--
)

CREATE TABLE SanPham
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaSanPham VARCHAR(10) UNIQUE NOT NULL,
	TenSanPham NVARCHAR(100),
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	Size INT,
	Mau NVARCHAR(20),
	Hang NVARCHAR(50),
	Gia FLOAT,
	SoLuong INT,
	Hinh NVARCHAR(200),
	ChiTiet NVARCHAR(500),
	GiamGia FLOAT, -- vidu : 10 = 10% --
	TinhTrang NVARCHAR(20)
)

CREATE TABLE PhieuNhap
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaPhieuNhap VARCHAR(10) UNIQUE NOT NULL,
	--IdNhanVien UNIQUEIDENTIFIER NOT NULL, --FK--
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	NgayNhap DATETIME,
	TongTien FLOAT,
	TinhTrang NVARCHAR(20)
)

CREATE TABLE ChiTietPhieuNhap
(
	IdPhieuNhap UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	SoLuong INT,
	Gia FLOAT
)

CREATE TABLE PhieuGiao
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaPhieuGiao VARCHAR(10) UNIQUE NOT NULL,
	CMNDGiao VARCHAR(20) NOT NULL,
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	DiaChi NVARCHAR(200),
	NgayTao DATETIME,
	NgayGiao DATETIME,
	IdKhuyenMai UNIQUEIDENTIFIER NOT NULL, --FK--
	TongTien FLOAT,
	TinhTrang NVARCHAR(20)
)

CREATE TABLE ChiTietPhieuGiao
(
	IdPhieuGiao UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	SoLuong INT,
	IdHoaHong UNIQUEIDENTIFIER NOT NULL, --FK--
	Gia FLOAT
)

CREATE TABLE PhieuDat
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaPhieuDat VARCHAR(10) UNIQUE NOT NULL,
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	NgayTao DATETIME,
	IdKhuyenMai UNIQUEIDENTIFIER NOT NULL, --FK--
	TongTien FLOAT,
	TinhTrang NVARCHAR(20)
)

CREATE TABLE ChiTietPhieuDat
(
	IdPhieuDat UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	SoLuong INT
)

CREATE TABLE TinhThanh --Tỉnh thành--
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaTinhThanh VARCHAR(10) UNIQUE NOT NULL,
	TenTinhThanh NVARCHAR(20),
	Quan NVARCHAR(20),
	Gia FLOAT
)

CREATE TABLE DiaChi
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	Duong NVARCHAR(100) NOT NULL, --Đường--
	IdTinhThanh UNIQUEIDENTIFIER NOT NULL, --FK--
	TinhTrang NVARCHAR(20)
)

CREATE TABLE KhuyenMai
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaKhuyenMai VARCHAR(10) UNIQUE NOT NULL,
	NgayBatDau DATETIME,
	NgayKetThuc DATETIME,
	GiamGia FLOAT,
	NoiDung NVARCHAR(500),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE HoaHong
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaHoaHong VARCHAR(10) UNIQUE NOT NULL,
	PhanTram FLOAT,
	NgayBatDau DATETIME
)

CREATE TABLE HopDong
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaHopDong VARCHAR(10) UNIQUE NOT NULL,
	--IdNhanVien UNIQUEIDENTIFIER NOT NULL, --FK--
	NgayBatDau DATETIME,
	NgayKetThuc DATETIME,
	ChuThich NVARCHAR(500),
	Gia FLOAT
)

CREATE TABLE QuangCao
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaQuangCao VARCHAR(10) UNIQUE NOT NULL,
	IdGoiQuangCao UNIQUEIDENTIFIER NOT NULL, --FK--
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --FK--
	Hinh NVARCHAR(200) NOT NULL,
	NgayBatDau DATETIME,
	NgayKetThuc DATETIME,
	ChuThich NVARCHAR(500),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE GoiQuangCao
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaGoiQuangCao VARCHAR(10) UNIQUE NOT NULL,
	ViTri NVARCHAR(100),
	Gia FLOAT,
	ThoiLuong INT --Ngày--
)

CREATE TABLE GioHang
(
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	SoLuong INT,
	ThoiGian TIME, --Thời gian còn lại, hết trả số lượng về 0--
	TinhTrang NVARCHAR(20)
)

--FOREIGN KEY--
--ALTER TABLE NhanVien
--	ADD
--		CONSTRAINT FK_NhanVien_IdLoaiNguoiDung FOREIGN KEY (IdLoaiNguoiDung) REFERENCES LoaiNguoiDung(Id)

ALTER TABLE TaiKhoan
	ADD
		CONSTRAINT FK_TaiKhoan_IdLoaiNguoiDung FOREIGN KEY (IdLoaiNguoiDung) REFERENCES LoaiNguoiDung(Id)

ALTER TABLE DanhGia
	ADD
		CONSTRAINT FK_DanhGia_IdTaiKhoanDanhGia FOREIGN KEY (IdTaiKhoanDanhGia) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_DanhGia_IdTaiKhoanDuocDanhGia FOREIGN KEY (IdTaiKhoanDuocDanhGia) REFERENCES TaiKhoan(Id)

ALTER TABLE SanPham
	ADD
		CONSTRAINT FK_SanPham_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id)

ALTER TABLE PhieuNhap
	ADD
		--CONSTRAINT FK_PhieuNhap_IdNhanVien FOREIGN KEY (IdNhanVien) REFERENCES NhanVien(Id),
		CONSTRAINT FK_PhieuNhap_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id)

ALTER TABLE ChiTietPhieuNhap
	ADD
		CONSTRAINT FK_ChiTietPhieuNhap_IdPhieuNhap FOREIGN KEY (IdPhieuNhap) REFERENCES PhieuNhap(Id),
		CONSTRAINT FK_ChiTietPhieuNhap_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
		CONSTRAINT PK_ChiTietPhieuNhap_IdPhieuNhap_IdSanPham PRIMARY KEY (IdPhieuNhap, IdSanPham)

ALTER TABLE PhieuGiao
	ADD
		CONSTRAINT FK_PhieuGiao_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_PhieuGiao_IdKhuyenMai FOREIGN KEY (IdKhuyenMai) REFERENCES KhuyenMai(Id)

ALTER TABLE ChiTietPhieuGiao
	ADD
		CONSTRAINT FK_ChiTietPhieuGiao_IdPhieuGiao FOREIGN KEY (IdPhieuGiao) REFERENCES PhieuGiao(Id),
		CONSTRAINT FK_ChiTietPhieuGiao_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
		CONSTRAINT FK_ChiTietPhieuGiao_IdHoaHong FOREIGN KEY (IdHoaHong) REFERENCES HoaHong(Id),
		CONSTRAINT PK_ChiTietPhieuGiao_IdPhieuGiao_IdSanPham PRIMARY KEY (IdPhieuGiao, IdSanPham)

ALTER TABLE PhieuDat
	ADD
		CONSTRAINT FK_PhieuDat_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_PhieuDat_IdKhuyenMai FOREIGN KEY (IdKhuyenMai) REFERENCES KhuyenMai(Id)

ALTER TABLE ChiTietPhieuDat
	ADD
		CONSTRAINT FK_ChiTietPhieuDat_IdPhieuDat FOREIGN KEY (IdPhieuDat) REFERENCES PhieuDat(Id),
		CONSTRAINT FK_ChiTietPhieuDat_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
		CONSTRAINT PK_ChiTietPhieuDat_IdPhieuDat_IdSanPham PRIMARY KEY (IdPhieuDat, IdSanPham)

ALTER TABLE DiaChi
	ADD
		CONSTRAINT FK_DiaChi_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_DiaChi_IdTinhThanh FOREIGN KEY (IdTinhThanh) REFERENCES TinhThanh(Id)

--ALTER TABLE HopDong
--	ADD
--		CONSTRAINT FK_HopDong_IdNhanVien FOREIGN KEY (IdNhanVien) REFERENCES NhanVien(Id)

ALTER TABLE QuangCao
	ADD
		CONSTRAINT FK_QuangCao_IdGoiQuangCao FOREIGN KEY (IdGoiQuangCao) REFERENCES GoiQuangCao(Id),
		CONSTRAINT FK_QuangCao_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id)

ALTER TABLE GioHang
	ADD
		CONSTRAINT FK_GioHang_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_GioHang_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
		CONSTRAINT PK_GioHang_IdTaiKhoan_IdSanPham PRIMARY KEY (IdTaiKhoan, IdSanPham)