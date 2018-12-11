USE QLBanGiay
GO
--
INSERT INTO TrangQuangCao
	VALUES ('75523BB6-C366-4A28-A85C-B4C8C1D5747A', 'AD-HOME', N'Trang chủ', N'Test',N'Không khoá'),
		   ('15CF8A9B-517E-4BAE-91E2-F30C596990ED', 'AD-GH', N'Gian Hàng', N'Test',N'Không khoá'),
		   ('EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156', 'AD-AD', N'Quảng Cáo', N'Test',N'Không khoá')
GO
		   

INSERT INTO ViTriQuangcao
	VALUES ('5284E840-16E1-4C73-9D00-1ACA5FF4642D', 'VT-HOME1', N'Trang chủ 1','75523BB6-C366-4A28-A85C-B4C8C1D5747A',60000, N'Test', N'Không khoá'),
		   ('FF517A22-38AE-4584-8447-0A41594EDEC3', 'VT-GH1', N'Gian Hàng 1', '15CF8A9B-517E-4BAE-91E2-F30C596990ED',50000,  N'Test', N'Không khoá'),
		   ('8C46E232-2EDF-4186-A5EA-901E5ABE0D33', 'VT-AD1', N'Quảng Cáo 1', 'EA9FC9A5-9C26-40A4-9E8E-BB3DAE4E0156',66666,  N'Test',N'Không khoá')
GO

INSERT INTO GoiQuangCao
VALUES('8804015b-62f8-46ed-b2bd-e662a1730381','G-HOME11', '5284E840-16E1-4C73-9D00-1ACA5FF4642D',60000,1,N'Không khoá'),
('66f36fc5-8d06-4d5e-ab8b-76d46c935ca6','G-HOME14', '5284E840-16E1-4C73-9D00-1ACA5FF4642D',240000,4,N'Không khoá')
GO 


INSERT INTO QuangCao
VALUES ('51791099-c591-436f-aa87-6e9d860378ac','QC-1','8804015b-62f8-46ed-b2bd-e662a1730381','18D79B1D-EE48-459A-AD1D-09A05A4773AD','','2018-9-1','2018-9-9','',N'Không khoá'),
('14329aca-9c43-4736-94bf-e420778a17f0','QC-2','8804015b-62f8-46ed-b2bd-e662a1730381','18D79B1D-EE48-459A-AD1D-09A05A4773AD','','2018-9-17','2018-10-11','',N'Không khoá')


GO




		   
GO

CREATE FUNCTION daysinmonth(@month int, @year int) 
returns table
as 
return (WITH N(N)AS 
(SELECT 1 FROM(VALUES(1),(1),(1),(1),(1),(1))M(N)),
tally(N)AS(SELECT ROW_NUMBER()OVER(ORDER BY N.N)FROM N,N a)
SELECT N day,datefromparts(@year,@month,N) dates FROM tally
WHERE N <= day(EOMONTH(datefromparts(@year,@month,1))))
GO

		select * from [dbo].[daysinmonth](12,2016)
GO

CREATE FUNCTION ngaythichhop(@month int,@year int,@idgoi uniqueidentifier)
returns table
as

return (
Select day from [dbo].[daysinmonth](@month,@year)
where (((select count(*) from QuangCao where @idgoi=IdGoiQuangCao AND ngaybatdau >= dates And Ngaybatdau < (Select DATEADD(day,((Select thoiluong from GoiQuangCao where @idgoi=Id)*7),dates)))=0)
AND ( (select count(*) from QuangCao where @idgoi=IdGoiQuangCao AND ngayketthuc > dates  And ngayketthuc <= (Select DATEADD(day,((Select thoiluong from GoiQuangCao where @idgoi=Id)*7),dates)))=0)
AND NOT ((Select top 1 ngaybatdau from QuangCao where @idgoi=IdGoiQuangCao AND ngaybatdau<dates  order by NgayBatDau DESC) > (Select top 1 ngayketthuc from QuangCao where @idgoi=IdGoiQuangCao AND ngayketthuc <=dates  order by NgayKetThuc DESC))
OR (Select count(*) from QuangCao where @idgoi=IdGoiQuangCao) = 0))
GO


Select * from GoiQuangCao
GO
Select * from ngaythichhop(9,2018,'8804015b-62f8-46ed-b2bd-e662a1730381')
GO

