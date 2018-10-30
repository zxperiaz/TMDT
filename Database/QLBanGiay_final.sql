﻿
CREATE DATABASE QLBanGiay
GO
--
USE QLBanGiay
GO

--TABLE--
CREATE TABLE LoaiNguoiDung
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaLoaiNguoiDung VARCHAR(10) UNIQUE NOT NULL,
	TenLoaiNguoiDung NVARCHAR(20), --Merchant, Customer, Nhân viên--
	TinhTrang NVARCHAR(20)
)

CREATE TABLE TaiKhoan
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	TenDangNhap VARCHAR(20) UNIQUE NOT NULL,
	MatKhau VARCHAR(50) NOT NULL,
	Email VARCHAR(100) UNIQUE NOT NULL,
	Ten NVARCHAR(100),
	DienThoai VARCHAR(20) UNIQUE,
	CMND VARCHAR(20) UNIQUE,
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
	Mau NVARCHAR(20), --Màu--
	IdHangSanPham UNIQUEIDENTIFIER NOT NULL, --FK--
	PhanLoai NVARCHAR(10), --Nam/Nữ--
	Gia FLOAT,
	SoLuong INT,
	Hinh NVARCHAR(200),
	ChiTiet NVARCHAR(500),
	GiamGia FLOAT, -- vidu : 0.1 = 10% --
	TinhTrang NVARCHAR(20)
)

CREATE TABLE SizeSanPham
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --FK--
	Size INT,
	TinhTrang NVARCHAR(20)
)

CREATE TABLE HangSanPham
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaHang VARCHAR(10) UNIQUE NOT NULL,
	TenHang NVARCHAR(100),
	TinhTrang NVARCHAR(20)
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
	TinhTrang NVARCHAR(20)
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
	IdViTri UNIQUEIDENTIFIER NOT NULL, -- FK -- 
	TongTien FLOAT,
	ThoiLuong INT, --Ngày--
	TinhTrang NVARCHAR(20)
)

CREATE TABLE TrangQuangCao
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaTrang VARCHAR(10) UNIQUE NOT NULL,
	TenTrang NVARCHAR(100),
	ChuThich NVARCHAR(100),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE ViTriQuangcao
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	MaViTri VARCHAR(10) UNIQUE NOT NULL,
	TenViTri NVARCHAR(100),
	IdTrang UNIQUEIDENTIFIER NOT NULL, -- FK --
	DonGia FLOAT,
	ChuThich NVARCHAR(100),
	TinhTrang NVARCHAR(20)
)

CREATE TABLE GioHang
(
	IdTaiKhoan UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	IdSanPham UNIQUEIDENTIFIER NOT NULL, --PK, FK--
	SoLuong INT,
	ThoiGian TIME, --Thời gian còn lại, hết trả số lượng về 0--
	TinhTrang NVARCHAR(20)
)

CREATE TABLE GiaShip
(
	Id UNIQUEIDENTIFIER PRIMARY KEY,
	Loai NVARCHAR(20), -- NOI THANH HAY NGOAI THANH
	Gia FLOAT,
	NgayCapNhat DATETIME
)

ALTER TABLE TaiKhoan
	ADD
		CONSTRAINT FK_TaiKhoan_IdLoaiNguoiDung FOREIGN KEY (IdLoaiNguoiDung) REFERENCES LoaiNguoiDung(Id)

ALTER TABLE DanhGia
	ADD
		CONSTRAINT FK_DanhGia_IdTaiKhoanDanhGia FOREIGN KEY (IdTaiKhoanDanhGia) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_DanhGia_IdTaiKhoanDuocDanhGia FOREIGN KEY (IdTaiKhoanDuocDanhGia) REFERENCES TaiKhoan(Id)

ALTER TABLE SanPham
	ADD
		CONSTRAINT FK_SanPham_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_SanPham_IdHangSanPham FOREIGN KEY (IdHangSanPham) REFERENCES HangSanPham(Id)

ALTER TABLE SizeSanPham
	ADD
		CONSTRAINT FK_SizeSanPham_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id)

ALTER TABLE PhieuGiao
	ADD
		CONSTRAINT FK_PhieuGiao_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_PhieuGiao_IdKhuyenMai FOREIGN KEY (IdKhuyenMai) REFERENCES KhuyenMai(Id)

ALTER TABLE ChiTietPhieuGiao
	ADD
		CONSTRAINT FK_ChiTietPhieuGiao_IdPhieuGiao FOREIGN KEY (IdPhieuGiao) REFERENCES PhieuGiao(Id),
		CONSTRAINT FK_ChiTietPhieuGiao_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
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

ALTER TABLE QuangCao
	ADD
		CONSTRAINT FK_QuangCao_IdGoiQuangCao FOREIGN KEY (IdGoiQuangCao) REFERENCES GoiQuangCao(Id),
		CONSTRAINT FK_QuangCao_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id)

ALTER TABLE GioHang
	ADD
		CONSTRAINT FK_GioHang_IdTaiKhoan FOREIGN KEY (IdTaiKhoan) REFERENCES TaiKhoan(Id),
		CONSTRAINT FK_GioHang_IdSanPham FOREIGN KEY (IdSanPham) REFERENCES SanPham(Id),
		CONSTRAINT PK_GioHang_IdTaiKhoan_IdSanPham PRIMARY KEY (IdTaiKhoan, IdSanPham)

ALTER TABLE GoiQuangCao
	ADD
		CONSTRAINT FK_GoiQuangCao_ViTriQuangCao FOREIGN KEY(IdViTri) REFERENCES ViTriQuangCao(Id)

ALTER TABLE ViTriQuangCao
	ADD
		CONSTRAINT FK_ViTriQuangCao_TrangQuangCao FOREIGN KEY(IdTrang) REFERENCES TrangQuangCao(Id)

--DỮ LIỆU--
INSERT INTO LoaiNguoiDung
	VALUES ('75523BB6-C366-4A28-A85C-B4C8C1D5747A', 'USR-WMT', N'Webmaster', N'Không khoá'),
		   ('15CF8A9B-517E-4BAE-91E2-F30C596990ED', 'USR-CUS', N'Khách hàng', N'Không khoá'),
		   ('EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', 'USR-MER', N'Thương nhân', N'Không khoá')

INSERT INTO TaiKhoan
	VALUES('CA2EE7E2-7F64-4A5A-A49B-E22E9E05F053', 'merchant1', 'F98919752BF9BFB31E539A1FE663FD68', 'hieu.trung.030197@gmail.com', N'Hiếu Trung', '09354268754', '654238415', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
	      ('18D79B1D-EE48-459A-AD1D-09A05A4773AD', 'merchant2', '8B550A0CA911A53B1C6FC398C7828F40', 'tnngo.97@gmail.com', N'Thị Nho', '09345123654', '356984126', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
		  ('499A28F6-67A2-4D2D-B027-183058A07646', 'merchant3', '3E99AD8EE3FBCBFA3D369D7FB0B0EA89', 'merchant03@gmail.com', N'Thanh Thảo', '0935426714', '657135426', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
		  ('739E7B3F-D6B8-4C48-81B4-487B75589E80', 'merchant4', 'DBB63DEE74EAD9034DEFD63D91D197E9', 'merchant04@gmail.com', N'Bá Đông', '0936582613', '958743265', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
		  ('9D042E88-B462-4811-9FED-4CC6A1C7A3AC', 'merchant5', 'B522147E61BA70E1757ADF4988757BCA', 'merchant05@gmail.com', N'Lý Thành', '0934513559', '154786254', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
		  ('1A31055B-A4BB-4BD7-81AB-1792CEB4B080', 'merchant6', 'F0277B130FA4966F39FD1986168DC042', 'merchant06@gmail.com', N'Quốc Thắng', '0937423651', '597326549', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', GETDATE(), 0, N'Không khoá'),
		  ('0C2F1A1B-6412-4FE2-B229-5FCE555349FC', 'customer1', 'FFBC4675F864E0E9AAB8BDF7A0437010', 'chunglinhdan@gmail.com', N'Trang Thảo', '0934851349', '954134782', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('1FFCCD2B-D22D-4F01-8E5B-2CA3B690D5D7', 'customer2', '5CE4D191FD14AC85A1469FB8C29B7A7B', 'quachdaivy7@gmail.com', N'Đại Vĩ', '0935684251', '597268451', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('7C24DC80-B487-40D2-A656-B6358962BBF5', 'customer3', '033F7F6121501AE98285AD77F216D5E7', 'customer3@gmail.com', N'Anh Vũ', '0934621574', '684326519', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('1D154C23-D7F1-47C6-8E3A-4CA13CBC837D', 'customer4', '55FEB130BE438E686AD6A80D12DD8F44', 'customer4@gmail.com', N'Kiến Vinh', '0934625795', '132574985', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('EA550E6B-34F1-45F7-BEAB-52435507FD03', 'customer5', '9E8486CDD435BEDA9A60806DD334D964', 'customer5@gmail.com', N'Anh Dũng', '0931652346', '953264158', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('5FED6DA6-45E0-4825-8B03-689E30C5EC17', 'customer6', 'DBAA8BD25E06CC641F5406027C026E8B', 'customer6@gmail.com', N'Minh Bảo', '0934851362', '745632658', '15CF8A9B-517E-4BAE-91E2-F30C596990ED', GETDATE(), 0, N'Không khoá'),
		  ('87186AF2-0D45-4ACD-898D-D799728C08AE', 'admin', '21232F297A57A5A743894A0E4A801FC3', 'feast.pock@gmail.com', N'Thiên Tuấn', '0934816735', '341267458', '75523BB6-C366-4A28-A85C-B4C8C1D5747A', GETDATE(), 0, N'Không khoá'),
		  ('8634C513-90FB-4DB7-9E80-F8278ECDEF68', 'admin2', 'C84258E9C39059A89AB77D846DDAB909', 'admin2@gmail.com', N'Hoàng Tuấn', '0934125436', '6598742365', '75523BB6-C366-4A28-A85C-B4C8C1D5747A', GETDATE(), 0, N'Không khoá')

INSERT INTO TinhThanh(Id,MaTinhThanh,TenTinhThanh,TinhTrang)
	VALUES
		  --Miền Bắc--
		  ('29EAC416-7A36-4523-BEE5-4584BA6B46BD','TT-01',N'Hà Nội',N'Không khoá'),
	      ('D39C9656-E5C5-4BB1-8C21-75D2CE92E13A','TT-02',N'Hà Giang',N'Không khoá'),
		  ('4201025A-F3F3-4082-9F67-2960F1987846','TT-03',N'Cao Bằng',N'Không khoá'),
		  ('C5803409-CBEA-4F88-8944-3413BD8CA1B0','TT-04',N'Bắc Kạn',N'Không khoá'),
		  ('CFBCFAB1-9EE6-4406-B057-940DBF737FE1','TT-05',N'Tuyên Quang',N'Không khoá'),
		  ('7C66F864-14CC-48DE-8CF2-B7DEA49BAB35','TT-06',N'Sơn La',N'Không khoá'),
		  ('21ABF173-C30F-43C7-9A42-2C2EFCEF2BA4','TT-07',N'Lào Cai',N'Không khoá'),
		  ('4FE093F8-525E-4825-945C-08C2B7A44C28','TT-08',N'Hải Phòng',N'Không khoá'),
		  ('D6A1904B-48B7-4C6C-8523-53546D209AC8','TT-09',N'Hải Dương',N'Không khoá'),
		  ('698927EA-DC64-4B9F-A58D-D78459CA6540','TT-10',N'Quảng Ninh',N'Không khoá'),
		  --Miên Trung--
		  ('89646395-6011-43E5-A8D0-8DD0826C8B7A','TT-11',N'Nghệ An',N'Không khoá'),
		  ('4584F350-6497-4F74-9341-9D3AD757BC41','TT-12',N'Hà Tĩnh',N'Không khoá'),
		  ('75BAF916-2B94-4DDB-89E7-A2C75B2FF8B9','TT-13',N'Quảng Trị',N'Không khoá'),
		  ('AD60B8AA-732B-4546-9EB1-0E0E565D3417','TT-14',N'Thừa Thiên Huế',N'Không khoá'),
		  ('9EFC73A5-AD71-40EC-B78C-4169800433AB','TT-15',N'Bình Định',N'Không khoá'),
		  ('33795BB6-3340-40F9-8DC0-E1A12252BBD7','TT-16',N'Quảng Trị',N'Không khoá'),
		  ('67D74025-1A09-4239-9622-B44E6B8BA0FB','TT-17',N'Quảng Nam',N'Không khoá'),
		  ('005A59B7-3812-4B23-B154-D8894AB92905','TT-18',N'Đà Nẵng',N'Không khoá'),
		  ('41CD4149-E90F-40F9-B249-B7B98AB4579E','TT-19',N'Phú Yên',N'Không khoá'),
		  --Miền Nam--
		  ('1D683773-5757-4C4E-BE2B-5537B5F567BD','TT-20',N'TP.Hồ Chí Minh',N'Không khoá'),
		  ('EF349D02-B36F-4BB5-B52E-152454BF2454','TT-21',N'Long An',N'Không khoá'),
		  ('61CA453B-3879-4D0E-A254-6D43F54189F1','TT-22',N'Tiền Giang',N'Không khoá'),
		  ('00FEDBBC-6BBA-4BB7-80B8-66A5E3AFF7CC','TT-23',N'Bến Tre',N'Không khoá'),
		  ('226B95A4-16E8-4830-8775-11A04A7BD803','TT-24',N'Trà Vinh',N'Không khoá'),
		  ('50D8C6E3-BCC8-45C4-B724-BE029A071C83','TT-25',N'Vĩnh Long',N'Không khoá'),
		  ('E33B46F3-313E-4008-923E-BA1C27184C19','TT-26',N'An Giang',N'Không khoá'),
		  ('FDF3C543-791C-47F7-8CAF-3AC502996138','TT-27',N'Sóc Trăng',N'Không khoá'),
		  ('24AD4EE6-FD58-43AE-8C7B-A81CAF2E6C60','TT-28',N'Bạc Liêu',N'Không khoá'),
		  ('78AE09D8-B2C7-4023-B133-A515DD3CA8D8','TT-29',N'Cà Mau',N'Không khoá')

INSERT INTO DiaChi
	VALUES('A42E13C6-0AAE-469C-B5A1-3ECDDC7767EB', 'CA2EE7E2-7F64-4A5A-A49B-E22E9E05F053', N'209 Trần Phú P4 Q5', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('239C76CD-7C6B-4F38-8D1A-22080B75C18C', 'CA2EE7E2-7F64-4A5A-A49B-E22E9E05F053', N'94 Nguyễn Chí Thanh P3 Q10', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('CC133D4A-805C-456A-BD6A-F735561DEDA6', '18D79B1D-EE48-459A-AD1D-09A05A4773AD', N'386 Lê Hồng Phong P1 Q10', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('012D35DA-6F9F-477B-B6D9-4D3190AC539F', '499A28F6-67A2-4D2D-B027-183058A07646', N'S322B Quốc lộ 62 P6', 'EF349D02-B36F-4BB5-B52E-152454BF2454', N'Không khoá'),
		  ('7B1C2C92-4C07-46E1-A5E5-644A766F023E', '739E7B3F-D6B8-4C48-81B4-487B75589E80', N'92A Tán Kế P3', '00FEDBBC-6BBA-4BB7-80B8-66A5E3AFF7CC', N'Không khoá'),
		  ('447076CA-E76C-4CF6-A55E-62C68F6B18E9', '9D042E88-B462-4811-9FED-4CC6A1C7A3AC', N'49 Cách Mạng Tháng Tám P3', '00FEDBBC-6BBA-4BB7-80B8-66A5E3AFF7CC', N'Không khoá'),
		  ('38E1D107-A4E9-4C6C-AB50-3B4DFA5573D4', '1A31055B-A4BB-4BD7-81AB-1792CEB4B080', N'466C5 Nguyễn Huệ P.Phú Khương', '00FEDBBC-6BBA-4BB7-80B8-66A5E3AFF7CC', N'Không khoá'),
		  ('9B71D7CA-08F7-403B-BA95-38D2E4BDE140', '0C2F1A1B-6412-4FE2-B229-5FCE555349FC', N'236 Phó Cơ Điều P6 Q11', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('DF75434B-4CB4-4515-9A44-FB8239CA6AD7', '0C2F1A1B-6412-4FE2-B229-5FCE555349FC', N'440 Trần Văn Đang P10 Q3', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('C7120B3E-B986-4A98-AACF-36CF83D124C7', '1FFCCD2B-D22D-4F01-8E5B-2CA3B690D5D7', N'289 Lãnh Binh Thăng P8 Q11', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('700FC48E-6033-440F-9DFE-4D7A137A1251', '7C24DC80-B487-40D2-A656-B6358962BBF5', N'220 Nguyễn Tri Phương Q.Thanh Khê', '005A59B7-3812-4B23-B154-D8894AB92905', N'Không khoá'),
		  ('32D3A808-0F76-473F-8BE0-80BCC6489DA5', '1D154C23-D7F1-47C6-8E3A-4CA13CBC837D', N'39 Núi Thành Q.Hải Châu', '005A59B7-3812-4B23-B154-D8894AB92905', N'Không khoá'),
		  ('424C7F44-CAC8-4228-93EF-A7B0FC80E058', 'EA550E6B-34F1-45F7-BEAB-52435507FD03', N'38 Trần Cao Vân', 'AD60B8AA-732B-4546-9EB1-0E0E565D3417', N'Không khoá'),
		  ('F0A0BEC1-F0EF-41AD-9311-57CF95177F33', '5FED6DA6-45E0-4825-8B03-689E30C5EC17', N'80 Mai Thúc Loan, Thuận Lộc', 'AD60B8AA-732B-4546-9EB1-0E0E565D3417', N'Không khoá'),
		  ('752E8997-23E9-4DC4-8529-5FBC68066895', '87186AF2-0D45-4ACD-898D-D799728C08AE', N'482 Hồng Bàng P6 Q6', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá'),
		  ('8D644CFB-1075-4895-AA04-4EC46EA6B786', '8634C513-90FB-4DB7-9E80-F8278ECDEF68', N'56 Bành Văn Trân P7 Q.Tân Bình', '1D683773-5757-4C4E-BE2B-5537B5F567BD', N'Không khoá')