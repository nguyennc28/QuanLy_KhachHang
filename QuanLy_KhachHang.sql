if exists (select * from sysobjects where id = object_id(N'[sproc_CongNo_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CongNo_GetCount]
GO

/* Procedure sproc_CongNo_GetCount*/
CREATE PROCEDURE sproc_CongNo_GetCount
AS
SELECT
	COUNT(*)
FROM
	[CongNo]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_CongNo_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CongNo_Get]
GO

/* Procedure sproc_CongNo_Get*/
CREATE PROCEDURE sproc_CongNo_Get
AS
SELECT
	--[MaKhachHang_DichVu],
	--[MaNhanVien],
	--[NgayThongBao],
	--[Sotien],
	--[HanNop]

*
FROM
	[CongNo]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_CongNo_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CongNo_Add]
GO

/* Procedure sproc_CongNo_Add*/
CREATE PROCEDURE sproc_CongNo_Add
	@MaKhachHang_DichVu int,
	@MaNhanVien int,
	@NgayThongBao datetime,
	@Sotien numeric(12),
	@HanNop datetime
AS

	INSERT INTO [CongNo]
	(
		[MaKhachHang_DichVu],
		[MaNhanVien],
		[NgayThongBao],
		[Sotien],
		[HanNop]
	)
	VALUES
	(
		@MaKhachHang_DichVu,
		@MaNhanVien,
		@NgayThongBao,
		@Sotien,
		@HanNop
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_GetCount]
GO

/* Procedure sproc_CSKH_GetCount*/
CREATE PROCEDURE sproc_CSKH_GetCount
AS
SELECT
	COUNT(*)
FROM
	[CSKH]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_Get]
GO

/* Procedure sproc_CSKH_Get*/
CREATE PROCEDURE sproc_CSKH_Get
AS
SELECT
	--[Ma_CSKH],
	--[MaKhachHang_DichVu],
	--[MaKetQua],
	--[MaNhanVien],
	--[NgayThucHien],
	--[NoiDung]

*
FROM
	[CSKH]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_GetByMa_CSKH]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_GetByMa_CSKH]
GO

/* Procedure sproc_CSKH_GetByMa_CSKH*/
CREATE PROCEDURE sproc_CSKH_GetByMa_CSKH
@Ma_CSKH int
AS
SELECT
	--[Ma_CSKH],
	--[MaKhachHang_DichVu],
	--[MaKetQua],
	--[MaNhanVien],
	--[NgayThucHien],
	--[NoiDung]

*
FROM
	[CSKH]
WHERE
	[Ma_CSKH] = @Ma_CSKH
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_GetPaged]
GO

/* Procedure sproc_CSKH_GetPaged*/
CREATE PROCEDURE sproc_CSKH_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [Ma_CSKH]
FROM [CSKH]


-- query out
SELECT *
FROM [CSKH]
WHERE [Ma_CSKH]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_Add]
GO

/* Procedure sproc_CSKH_Add*/
CREATE PROCEDURE sproc_CSKH_Add
	@Ma_CSKH int OUTPUT
	,@MaKhachHang_DichVu int
	,@MaKetQua tinyint
	,@MaNhanVien int
	,@NgayThucHien datetime
	,@NoiDung nvarchar(100)

AS

	INSERT INTO [CSKH]
	(
		[Ma_CSKH],
		[MaKhachHang_DichVu],
		[MaKetQua],
		[MaNhanVien],
		[NgayThucHien],
		[NoiDung]
	)
	VALUES
	(
		@Ma_CSKH,
		@MaKhachHang_DichVu,
		@MaKetQua,
		@MaNhanVien,
		@NgayThucHien,
		@NoiDung
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_Update]
GO

/* Procedure sproc_CSKH_Update*/
CREATE PROCEDURE sproc_CSKH_Update
	@MaKhachHang_DichVu int,
	@MaKetQua tinyint,
	@MaNhanVien int,
	@NgayThucHien datetime,
	@NoiDung nvarchar(100),
	@Ma_CSKH int

AS
UPDATE [CSKH]
SET
	[MaKhachHang_DichVu] = @MaKhachHang_DichVu,
	[MaKetQua] = @MaKetQua,
	[MaNhanVien] = @MaNhanVien,
	[NgayThucHien] = @NgayThucHien,
	[NoiDung] = @NoiDung
WHERE
	[Ma_CSKH] = @Ma_CSKH
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_CSKH_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_CSKH_Delete]
GO

/* Procedure sproc_CSKH_Delete*/
CREATE PROCEDURE sproc_CSKH_Delete
	@Ma_CSKH int
AS
DELETE
FROM
	[CSKH]
WHERE
	[Ma_CSKH] = @Ma_CSKH
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_GetCount]
GO

/* Procedure sproc_DM_DichVu_GetCount*/
CREATE PROCEDURE sproc_DM_DichVu_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DM_DichVu]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_Get]
GO

/* Procedure sproc_DM_DichVu_Get*/
CREATE PROCEDURE sproc_DM_DichVu_Get
AS
SELECT
	--[MaDichVu],
	--[TenDichVu]

*
FROM
	[DM_DichVu]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_GetByMaDichVu]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_GetByMaDichVu]
GO

/* Procedure sproc_DM_DichVu_GetByMaDichVu*/
CREATE PROCEDURE sproc_DM_DichVu_GetByMaDichVu
@MaDichVu tinyint
AS
SELECT
	--[MaDichVu],
	--[TenDichVu]

*
FROM
	[DM_DichVu]
WHERE
	[MaDichVu] = @MaDichVu
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_GetPaged]
GO

/* Procedure sproc_DM_DichVu_GetPaged*/
CREATE PROCEDURE sproc_DM_DichVu_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	tinyint
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaDichVu]
FROM [DM_DichVu]


-- query out
SELECT *
FROM [DM_DichVu]
WHERE [MaDichVu]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_Add]
GO

/* Procedure sproc_DM_DichVu_Add*/
CREATE PROCEDURE sproc_DM_DichVu_Add
	@MaDichVu tinyint OUTPUT
	,@TenDichVu nvarchar(50)

AS

	INSERT INTO [DM_DichVu]
	(
		[MaDichVu],
		[TenDichVu]
	)
	VALUES
	(
		@MaDichVu,
		@TenDichVu
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_Update]
GO

/* Procedure sproc_DM_DichVu_Update*/
CREATE PROCEDURE sproc_DM_DichVu_Update
	@TenDichVu nvarchar(50),
	@MaDichVu tinyint

AS
UPDATE [DM_DichVu]
SET
	[TenDichVu] = @TenDichVu
WHERE
	[MaDichVu] = @MaDichVu
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_DichVu_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_DichVu_Delete]
GO

/* Procedure sproc_DM_DichVu_Delete*/
CREATE PROCEDURE sproc_DM_DichVu_Delete
	@MaDichVu tinyint
AS
DELETE
FROM
	[DM_DichVu]
WHERE
	[MaDichVu] = @MaDichVu
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_GetCount]
GO

/* Procedure sproc_DM_KetQua_GetCount*/
CREATE PROCEDURE sproc_DM_KetQua_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DM_KetQua]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_Get]
GO

/* Procedure sproc_DM_KetQua_Get*/
CREATE PROCEDURE sproc_DM_KetQua_Get
AS
SELECT
	--[MaKetQua],
	--[TenKetQua]

*
FROM
	[DM_KetQua]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_GetByMaKetQua]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_GetByMaKetQua]
GO

/* Procedure sproc_DM_KetQua_GetByMaKetQua*/
CREATE PROCEDURE sproc_DM_KetQua_GetByMaKetQua
@MaKetQua tinyint
AS
SELECT
	--[MaKetQua],
	--[TenKetQua]

*
FROM
	[DM_KetQua]
WHERE
	[MaKetQua] = @MaKetQua
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_GetPaged]
GO

/* Procedure sproc_DM_KetQua_GetPaged*/
CREATE PROCEDURE sproc_DM_KetQua_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	tinyint
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaKetQua]
FROM [DM_KetQua]


-- query out
SELECT *
FROM [DM_KetQua]
WHERE [MaKetQua]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_Add]
GO

/* Procedure sproc_DM_KetQua_Add*/
CREATE PROCEDURE sproc_DM_KetQua_Add
	@MaKetQua tinyint OUTPUT
	,@TenKetQua nvarchar(20)

AS

	INSERT INTO [DM_KetQua]
	(
		[MaKetQua],
		[TenKetQua]
	)
	VALUES
	(
		@MaKetQua,
		@TenKetQua
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_Update]
GO

/* Procedure sproc_DM_KetQua_Update*/
CREATE PROCEDURE sproc_DM_KetQua_Update
	@TenKetQua nvarchar(20),
	@MaKetQua tinyint

AS
UPDATE [DM_KetQua]
SET
	[TenKetQua] = @TenKetQua
WHERE
	[MaKetQua] = @MaKetQua
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_KetQua_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_KetQua_Delete]
GO

/* Procedure sproc_DM_KetQua_Delete*/
CREATE PROCEDURE sproc_DM_KetQua_Delete
	@MaKetQua tinyint
AS
DELETE
FROM
	[DM_KetQua]
WHERE
	[MaKetQua] = @MaKetQua
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_GetCount]
GO

/* Procedure sproc_DM_Nguon_GetCount*/
CREATE PROCEDURE sproc_DM_Nguon_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DM_Nguon]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_Get]
GO

/* Procedure sproc_DM_Nguon_Get*/
CREATE PROCEDURE sproc_DM_Nguon_Get
AS
SELECT
	--[MaNguon],
	--[TenNguon]

*
FROM
	[DM_Nguon]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_GetByMaNguon]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_GetByMaNguon]
GO

/* Procedure sproc_DM_Nguon_GetByMaNguon*/
CREATE PROCEDURE sproc_DM_Nguon_GetByMaNguon
@MaNguon int
AS
SELECT
	--[MaNguon],
	--[TenNguon]

*
FROM
	[DM_Nguon]
WHERE
	[MaNguon] = @MaNguon
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_GetPaged]
GO

/* Procedure sproc_DM_Nguon_GetPaged*/
CREATE PROCEDURE sproc_DM_Nguon_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaNguon]
FROM [DM_Nguon]


-- query out
SELECT *
FROM [DM_Nguon]
WHERE [MaNguon]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_Add]
GO

/* Procedure sproc_DM_Nguon_Add*/
CREATE PROCEDURE sproc_DM_Nguon_Add
	@MaNguon int OUTPUT
	,@TenNguon nvarchar(20)

AS

	INSERT INTO [DM_Nguon]
	(
		[MaNguon],
		[TenNguon]
	)
	VALUES
	(
		@MaNguon,
		@TenNguon
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_Update]
GO

/* Procedure sproc_DM_Nguon_Update*/
CREATE PROCEDURE sproc_DM_Nguon_Update
	@TenNguon nvarchar(20),
	@MaNguon int

AS
UPDATE [DM_Nguon]
SET
	[TenNguon] = @TenNguon
WHERE
	[MaNguon] = @MaNguon
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_Nguon_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_Nguon_Delete]
GO

/* Procedure sproc_DM_Nguon_Delete*/
CREATE PROCEDURE sproc_DM_Nguon_Delete
	@MaNguon int
AS
DELETE
FROM
	[DM_Nguon]
WHERE
	[MaNguon] = @MaNguon
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_GetCount]
GO

/* Procedure sproc_DM_PhongBan_GetCount*/
CREATE PROCEDURE sproc_DM_PhongBan_GetCount
AS
SELECT
	COUNT(*)
FROM
	[DM_PhongBan]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_Get]
GO

/* Procedure sproc_DM_PhongBan_Get*/
CREATE PROCEDURE sproc_DM_PhongBan_Get
AS
SELECT
	--[MaPhong],
	--[TenPhong]

*
FROM
	[DM_PhongBan]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_GetByMaPhong]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_GetByMaPhong]
GO

/* Procedure sproc_DM_PhongBan_GetByMaPhong*/
CREATE PROCEDURE sproc_DM_PhongBan_GetByMaPhong
@MaPhong tinyint
AS
SELECT
	--[MaPhong],
	--[TenPhong]

*
FROM
	[DM_PhongBan]
WHERE
	[MaPhong] = @MaPhong
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_GetPaged]
GO

/* Procedure sproc_DM_PhongBan_GetPaged*/
CREATE PROCEDURE sproc_DM_PhongBan_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	tinyint
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaPhong]
FROM [DM_PhongBan]


-- query out
SELECT *
FROM [DM_PhongBan]
WHERE [MaPhong]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_Add]
GO

/* Procedure sproc_DM_PhongBan_Add*/
CREATE PROCEDURE sproc_DM_PhongBan_Add
	@MaPhong tinyint OUTPUT
	,@TenPhong varchar(30)

AS

	INSERT INTO [DM_PhongBan]
	(
		[MaPhong],
		[TenPhong]
	)
	VALUES
	(
		@MaPhong,
		@TenPhong
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_Update]
GO

/* Procedure sproc_DM_PhongBan_Update*/
CREATE PROCEDURE sproc_DM_PhongBan_Update
	@TenPhong varchar(30),
	@MaPhong tinyint

AS
UPDATE [DM_PhongBan]
SET
	[TenPhong] = @TenPhong
WHERE
	[MaPhong] = @MaPhong
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_DM_PhongBan_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_DM_PhongBan_Delete]
GO

/* Procedure sproc_DM_PhongBan_Delete*/
CREATE PROCEDURE sproc_DM_PhongBan_Delete
	@MaPhong tinyint
AS
DELETE
FROM
	[DM_PhongBan]
WHERE
	[MaPhong] = @MaPhong
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_GetCount]
GO

/* Procedure sproc_KhachHang_GetCount*/
CREATE PROCEDURE sproc_KhachHang_GetCount
AS
SELECT
	COUNT(*)
FROM
	[KhachHang]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_Get]
GO

/* Procedure sproc_KhachHang_Get*/
CREATE PROCEDURE sproc_KhachHang_Get
AS
SELECT
	--[MaKhachHang],
	--[TenKhachHang],
	--[DiaChiLienHe],
	--[DiaChiVAT],
	--[Email],
	--[DienThoai],
	--[NguoiLienHe]

*
FROM
	[KhachHang]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_GetByMaKhachHang]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_GetByMaKhachHang]
GO

/* Procedure sproc_KhachHang_GetByMaKhachHang*/
CREATE PROCEDURE sproc_KhachHang_GetByMaKhachHang
@MaKhachHang int
AS
SELECT
	--[MaKhachHang],
	--[TenKhachHang],
	--[DiaChiLienHe],
	--[DiaChiVAT],
	--[Email],
	--[DienThoai],
	--[NguoiLienHe]

*
FROM
	[KhachHang]
WHERE
	[MaKhachHang] = @MaKhachHang
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_GetPaged]
GO

/* Procedure sproc_KhachHang_GetPaged*/
CREATE PROCEDURE sproc_KhachHang_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaKhachHang]
FROM [KhachHang]


-- query out
SELECT *
FROM [KhachHang]
WHERE [MaKhachHang]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_Add]
GO

/* Procedure sproc_KhachHang_Add*/
CREATE PROCEDURE sproc_KhachHang_Add
	@MaKhachHang int OUTPUT
	,@TenKhachHang nvarchar(20)
	,@DiaChiLienHe nvarchar(120)
	,@DiaChiVAT nvarchar(120)
	,@Email varchar(30)
	,@DienThoai varchar(20)
	,@NguoiLienHe nvarchar(30)

AS

	INSERT INTO [KhachHang]
	(
		[MaKhachHang],
		[TenKhachHang],
		[DiaChiLienHe],
		[DiaChiVAT],
		[Email],
		[DienThoai],
		[NguoiLienHe]
	)
	VALUES
	(
		@MaKhachHang,
		@TenKhachHang,
		@DiaChiLienHe,
		@DiaChiVAT,
		@Email,
		@DienThoai,
		@NguoiLienHe
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_Update]
GO

/* Procedure sproc_KhachHang_Update*/
CREATE PROCEDURE sproc_KhachHang_Update
	@TenKhachHang nvarchar(20),
	@DiaChiLienHe nvarchar(120),
	@DiaChiVAT nvarchar(120),
	@Email varchar(30),
	@DienThoai varchar(20),
	@NguoiLienHe nvarchar(30),
	@MaKhachHang int

AS
UPDATE [KhachHang]
SET
	[TenKhachHang] = @TenKhachHang,
	[DiaChiLienHe] = @DiaChiLienHe,
	[DiaChiVAT] = @DiaChiVAT,
	[Email] = @Email,
	[DienThoai] = @DienThoai,
	[NguoiLienHe] = @NguoiLienHe
WHERE
	[MaKhachHang] = @MaKhachHang
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_Delete]
GO

/* Procedure sproc_KhachHang_Delete*/
CREATE PROCEDURE sproc_KhachHang_Delete
	@MaKhachHang int
AS
DELETE
FROM
	[KhachHang]
WHERE
	[MaKhachHang] = @MaKhachHang
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_GetCount]
GO

/* Procedure sproc_KhachHang_DichVu_GetCount*/
CREATE PROCEDURE sproc_KhachHang_DichVu_GetCount
AS
SELECT
	COUNT(*)
FROM
	[KhachHang_DichVu]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_Get]
GO

/* Procedure sproc_KhachHang_DichVu_Get*/
CREATE PROCEDURE sproc_KhachHang_DichVu_Get
AS
SELECT
	--[MaKhachHang_DichVu],
	--[MaKhachHang],
	--[MaDichVu],
	--[MaNguon],
	--[GiaTriHopDong],
	--[SoHopDong],
	--[TomTatHopDong],
	--[NgayThanhLyHD],
	--[NgayBatDauDichVu],
	--[NgayKetThucDichVu]

*
FROM
	[KhachHang_DichVu]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_GetByMaKhachHang_DichVu]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_GetByMaKhachHang_DichVu]
GO

/* Procedure sproc_KhachHang_DichVu_GetByMaKhachHang_DichVu*/
CREATE PROCEDURE sproc_KhachHang_DichVu_GetByMaKhachHang_DichVu
@MaKhachHang_DichVu int
AS
SELECT
	--[MaKhachHang_DichVu],
	--[MaKhachHang],
	--[MaDichVu],
	--[MaNguon],
	--[GiaTriHopDong],
	--[SoHopDong],
	--[TomTatHopDong],
	--[NgayThanhLyHD],
	--[NgayBatDauDichVu],
	--[NgayKetThucDichVu]

*
FROM
	[KhachHang_DichVu]
WHERE
	[MaKhachHang_DichVu] = @MaKhachHang_DichVu
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_GetPaged]
GO

/* Procedure sproc_KhachHang_DichVu_GetPaged*/
CREATE PROCEDURE sproc_KhachHang_DichVu_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaKhachHang_DichVu]
FROM [KhachHang_DichVu]


-- query out
SELECT *
FROM [KhachHang_DichVu]
WHERE [MaKhachHang_DichVu]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_Add]
GO

/* Procedure sproc_KhachHang_DichVu_Add*/
CREATE PROCEDURE sproc_KhachHang_DichVu_Add
	@MaKhachHang_DichVu int OUTPUT
	,@MaKhachHang int
	,@MaDichVu tinyint
	,@MaNguon int
	,@GiaTriHopDong numeric(12)
	,@SoHopDong varchar(20)
	,@TomTatHopDong nvarchar(1000)
	,@NgayThanhLyHD datetime
	,@NgayBatDauDichVu datetime
	,@NgayKetThucDichVu datetime

AS

	INSERT INTO [KhachHang_DichVu]
	(
		[MaKhachHang_DichVu],
		[MaKhachHang],
		[MaDichVu],
		[MaNguon],
		[GiaTriHopDong],
		[SoHopDong],
		[TomTatHopDong],
		[NgayThanhLyHD],
		[NgayBatDauDichVu],
		[NgayKetThucDichVu]
	)
	VALUES
	(
		@MaKhachHang_DichVu,
		@MaKhachHang,
		@MaDichVu,
		@MaNguon,
		@GiaTriHopDong,
		@SoHopDong,
		@TomTatHopDong,
		@NgayThanhLyHD,
		@NgayBatDauDichVu,
		@NgayKetThucDichVu
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_Update]
GO

/* Procedure sproc_KhachHang_DichVu_Update*/
CREATE PROCEDURE sproc_KhachHang_DichVu_Update
	@MaKhachHang int,
	@MaDichVu tinyint,
	@MaNguon int,
	@GiaTriHopDong numeric(12),
	@SoHopDong varchar(20),
	@TomTatHopDong nvarchar(1000),
	@NgayThanhLyHD datetime,
	@NgayBatDauDichVu datetime,
	@NgayKetThucDichVu datetime,
	@MaKhachHang_DichVu int

AS
UPDATE [KhachHang_DichVu]
SET
	[MaKhachHang] = @MaKhachHang,
	[MaDichVu] = @MaDichVu,
	[MaNguon] = @MaNguon,
	[GiaTriHopDong] = @GiaTriHopDong,
	[SoHopDong] = @SoHopDong,
	[TomTatHopDong] = @TomTatHopDong,
	[NgayThanhLyHD] = @NgayThanhLyHD,
	[NgayBatDauDichVu] = @NgayBatDauDichVu,
	[NgayKetThucDichVu] = @NgayKetThucDichVu
WHERE
	[MaKhachHang_DichVu] = @MaKhachHang_DichVu
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_KhachHang_DichVu_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_KhachHang_DichVu_Delete]
GO

/* Procedure sproc_KhachHang_DichVu_Delete*/
CREATE PROCEDURE sproc_KhachHang_DichVu_Delete
	@MaKhachHang_DichVu int
AS
DELETE
FROM
	[KhachHang_DichVu]
WHERE
	[MaKhachHang_DichVu] = @MaKhachHang_DichVu
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetCount]
GO

/* Procedure sproc_NhanVien_GetCount*/
CREATE PROCEDURE sproc_NhanVien_GetCount
AS
SELECT
	COUNT(*)
FROM
	[NhanVien]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Get]
GO

/* Procedure sproc_NhanVien_Get*/
CREATE PROCEDURE sproc_NhanVien_Get
AS
SELECT
	--[MaNhanVien],
	--[HoTen],
	--[NgaySinh],
	--[DienThoai],
	--[Email]

*
FROM
	[NhanVien]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetByMaNhanVien]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetByMaNhanVien]
GO

/* Procedure sproc_NhanVien_GetByMaNhanVien*/
CREATE PROCEDURE sproc_NhanVien_GetByMaNhanVien
@MaNhanVien int
AS
SELECT
	--[MaNhanVien],
	--[HoTen],
	--[NgaySinh],
	--[DienThoai],
	--[Email]

*
FROM
	[NhanVien]
WHERE
	[MaNhanVien] = @MaNhanVien
GO



if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_GetPaged]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_GetPaged]
GO

/* Procedure sproc_NhanVien_GetPaged*/
CREATE PROCEDURE sproc_NhanVien_GetPaged
	@RecPerPage INT,
	@PageIndex INT
AS

DECLARE @FirstRec INT
DECLARE @LastRec INT

SET @FirstRec = (@PageIndex - 1)*@RecPerPage + 1
SET @LastRec = @PageIndex *@RecPerPage 

-- create temp table to paging
CREATE TABLE #tmp_paging_index
(
	recID		INT IDENTITY(1,1) NOT NULL,
	messageID	int
)

-- insert temp records
INSERT INTO #tmp_paging_index(messageID)
SELECT [MaNhanVien]
FROM [NhanVien]


-- query out
SELECT *
FROM [NhanVien]
WHERE [MaNhanVien]
IN (
	SELECT messageID 
	FROM #tmp_paging_index 
	WHERE recID >= @FirstRec AND recID <= @LastRec
)
DROP TABLE #tmp_paging_index

GO



if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Add]
GO

/* Procedure sproc_NhanVien_Add*/
CREATE PROCEDURE sproc_NhanVien_Add
	@MaNhanVien int OUTPUT
	,@HoTen varchar(30)
	,@NgaySinh datetime
	,@DienThoai varchar(20)
	,@Email nvarchar(30)

AS

	INSERT INTO [NhanVien]
	(
		[MaNhanVien],
		[HoTen],
		[NgaySinh],
		[DienThoai],
		[Email]
	)
	VALUES
	(
		@MaNhanVien,
		@HoTen,
		@NgaySinh,
		@DienThoai,
		@Email
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Update]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Update]
GO

/* Procedure sproc_NhanVien_Update*/
CREATE PROCEDURE sproc_NhanVien_Update
	@HoTen varchar(30),
	@NgaySinh datetime,
	@DienThoai varchar(20),
	@Email nvarchar(30),
	@MaNhanVien int

AS
UPDATE [NhanVien]
SET
	[HoTen] = @HoTen,
	[NgaySinh] = @NgaySinh,
	[DienThoai] = @DienThoai,
	[Email] = @Email
WHERE
	[MaNhanVien] = @MaNhanVien
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Delete]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Delete]
GO

/* Procedure sproc_NhanVien_Delete*/
CREATE PROCEDURE sproc_NhanVien_Delete
	@MaNhanVien int
AS
DELETE
FROM
	[NhanVien]
WHERE
	[MaNhanVien] = @MaNhanVien
GO

if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Phong_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Phong_GetCount]
GO

/* Procedure sproc_NhanVien_Phong_GetCount*/
CREATE PROCEDURE sproc_NhanVien_Phong_GetCount
AS
SELECT
	COUNT(*)
FROM
	[NhanVien_Phong]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Phong_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Phong_Get]
GO

/* Procedure sproc_NhanVien_Phong_Get*/
CREATE PROCEDURE sproc_NhanVien_Phong_Get
AS
SELECT
	--[MaNhanVien],
	--[MaPhong],
	--[ThoiGianBatDau],
	--[ThowiGianKetThuc]

*
FROM
	[NhanVien_Phong]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_NhanVien_Phong_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_NhanVien_Phong_Add]
GO

/* Procedure sproc_NhanVien_Phong_Add*/
CREATE PROCEDURE sproc_NhanVien_Phong_Add
	@MaNhanVien int,
	@MaPhong tinyint,
	@ThoiGianBatDau datetime,
	@ThowiGianKetThuc datetime
AS

	INSERT INTO [NhanVien_Phong]
	(
		[MaNhanVien],
		[MaPhong],
		[ThoiGianBatDau],
		[ThowiGianKetThuc]
	)
	VALUES
	(
		@MaNhanVien,
		@MaPhong,
		@ThoiGianBatDau,
		@ThowiGianKetThuc
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_PhiCSKH_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PhiCSKH_GetCount]
GO

/* Procedure sproc_PhiCSKH_GetCount*/
CREATE PROCEDURE sproc_PhiCSKH_GetCount
AS
SELECT
	COUNT(*)
FROM
	[PhiCSKH]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_PhiCSKH_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PhiCSKH_Get]
GO

/* Procedure sproc_PhiCSKH_Get*/
CREATE PROCEDURE sproc_PhiCSKH_Get
AS
SELECT
	--[Ma_CSKH],
	--[MaNhanVien],
	--[NgayNop],
	--[SoTien],
	--[NguoiNop],
	--[GhiChu]

*
FROM
	[PhiCSKH]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_PhiCSKH_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_PhiCSKH_Add]
GO

/* Procedure sproc_PhiCSKH_Add*/
CREATE PROCEDURE sproc_PhiCSKH_Add
	@Ma_CSKH int,
	@MaNhanVien int,
	@NgayNop datetime,
	@SoTien numeric(12),
	@NguoiNop nvarchar(30),
	@GhiChu nvarchar(1000)
AS

	INSERT INTO [PhiCSKH]
	(
		[Ma_CSKH],
		[MaNhanVien],
		[NgayNop],
		[SoTien],
		[NguoiNop],
		[GhiChu]
	)
	VALUES
	(
		@Ma_CSKH,
		@MaNhanVien,
		@NgayNop,
		@SoTien,
		@NguoiNop,
		@GhiChu
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_ThanhToan_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ThanhToan_GetCount]
GO

/* Procedure sproc_ThanhToan_GetCount*/
CREATE PROCEDURE sproc_ThanhToan_GetCount
AS
SELECT
	COUNT(*)
FROM
	[ThanhToan]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_ThanhToan_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ThanhToan_Get]
GO

/* Procedure sproc_ThanhToan_Get*/
CREATE PROCEDURE sproc_ThanhToan_Get
AS
SELECT
	--[MaKhachHang_DichVu],
	--[NgayThanhToan],
	--[SoTien],
	--[MaNhanVien],
	--[NgayNop]

*
FROM
	[ThanhToan]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_ThanhToan_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_ThanhToan_Add]
GO

/* Procedure sproc_ThanhToan_Add*/
CREATE PROCEDURE sproc_ThanhToan_Add
	@MaKhachHang_DichVu int,
	@NgayThanhToan datetime,
	@SoTien numeric(12),
	@MaNhanVien int,
	@NgayNop datetime
AS

	INSERT INTO [ThanhToan]
	(
		[MaKhachHang_DichVu],
		[NgayThanhToan],
		[SoTien],
		[MaNhanVien],
		[NgayNop]
	)
	VALUES
	(
		@MaKhachHang_DichVu,
		@NgayThanhToan,
		@SoTien,
		@MaNhanVien,
		@NgayNop
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_VAT_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_VAT_GetCount]
GO

/* Procedure sproc_VAT_GetCount*/
CREATE PROCEDURE sproc_VAT_GetCount
AS
SELECT
	COUNT(*)
FROM
	[VAT]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_VAT_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_VAT_Get]
GO

/* Procedure sproc_VAT_Get*/
CREATE PROCEDURE sproc_VAT_Get
AS
SELECT
	--[MaKhachHang_DichVu],
	--[MaNhanVien],
	--[NgayXuatVAT],
	--[SoTien]

*
FROM
	[VAT]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_VAT_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_VAT_Add]
GO

/* Procedure sproc_VAT_Add*/
CREATE PROCEDURE sproc_VAT_Add
	@MaKhachHang_DichVu int,
	@MaNhanVien int,
	@NgayXuatVAT datetime,
	@SoTien numeric(12)
AS

	INSERT INTO [VAT]
	(
		[MaKhachHang_DichVu],
		[MaNhanVien],
		[NgayXuatVAT],
		[SoTien]
	)
	VALUES
	(
		@MaKhachHang_DichVu,
		@MaNhanVien,
		@NgayXuatVAT,
		@SoTien
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_GetCount]
GO

/* Procedure sproc_trace_xe_action_map_GetCount*/
CREATE PROCEDURE sproc_trace_xe_action_map_GetCount
AS
SELECT
	COUNT(*)
FROM
	[trace_xe_action_map]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_Get]
GO

/* Procedure sproc_trace_xe_action_map_Get*/
CREATE PROCEDURE sproc_trace_xe_action_map_Get
AS
SELECT
	--[trace_column_id],
	--[package_name],
	--[xe_action_name]

*
FROM
	[trace_xe_action_map]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_action_map_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_action_map_Add]
GO

/* Procedure sproc_trace_xe_action_map_Add*/
CREATE PROCEDURE sproc_trace_xe_action_map_Add
	@trace_column_id smallint,
	@package_name nvarchar(60),
	@xe_action_name nvarchar(60)
AS

	INSERT INTO [trace_xe_action_map]
	(
		[trace_column_id],
		[package_name],
		[xe_action_name]
	)
	VALUES
	(
		@trace_column_id,
		@package_name,
		@xe_action_name
	)
GO
if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_GetCount]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_GetCount]
GO

/* Procedure sproc_trace_xe_event_map_GetCount*/
CREATE PROCEDURE sproc_trace_xe_event_map_GetCount
AS
SELECT
	COUNT(*)
FROM
	[trace_xe_event_map]
GO


if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_Get]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_Get]
GO

/* Procedure sproc_trace_xe_event_map_Get*/
CREATE PROCEDURE sproc_trace_xe_event_map_Get
AS
SELECT
	--[trace_event_id],
	--[package_name],
	--[xe_event_name]

*
FROM
	[trace_xe_event_map]
GO






if exists (select * from sysobjects where id = object_id(N'[sproc_trace_xe_event_map_Add]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
	drop procedure [sproc_trace_xe_event_map_Add]
GO

/* Procedure sproc_trace_xe_event_map_Add*/
CREATE PROCEDURE sproc_trace_xe_event_map_Add
	@trace_event_id smallint,
	@package_name nvarchar(60),
	@xe_event_name nvarchar(60)
AS

	INSERT INTO [trace_xe_event_map]
	(
		[trace_event_id],
		[package_name],
		[xe_event_name]
	)
	VALUES
	(
		@trace_event_id,
		@package_name,
		@xe_event_name
	)
GO
