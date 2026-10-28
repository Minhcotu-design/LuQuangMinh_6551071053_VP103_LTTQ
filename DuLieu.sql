

CREATE TABLE dbo.CongViec(
	MaSach nvarchar(15) Primary Key,
	TenSach nText not null,
	GiaTien nvarchar(12) not null
);

Insert into dbo.CongViec (MaSach, TenSach, GiaTien) Values
(N'S001',N'Lập trình C# cơ bản', 180000);

