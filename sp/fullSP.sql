USE [QLVT]
GO
/****** Object:  StoredProcedure [dbo].[SP_TaoTaiKhoan]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TaoTaiKhoan] @LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'QLVT'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC SP_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'ChiNhanh'
	BEGIN 
		EXEC SP_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC SP_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC SP_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
	IF @ROLE= 'CongTy'
	BEGIN 
		EXEC SP_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC SP_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC SP_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'USER'
	BEGIN  
		EXEC SP_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_XoaTaiKhoan]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_XoaTaiKhoan] @USERNAME VARCHAR(50)
AS
 declare @LGNAME VARCHAR(50)

 select @LGNAME = NAME from sys.sql_logins WHERE sid = 
 (select sid from sys.sysusers where sys.sysusers.name = @USERNAME)
if @LGNAME = null return 2
    EXEC sp_droplogin @LGNAME 
	EXEC SP_REVOKEDBACCESS @USERNAME

if exists (select NAME FROM sys.sysusers WHERE UID = 
	(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
	 (SELECT UID FROM sys.sysusers  WHERE NAME=@USERNAME)))
	 
	if ((select NAME FROM sys.sysusers WHERE UID = 
	(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
	 (SELECT UID FROM sys.sysusers  WHERE NAME=@USERNAME))) = 'CongTy')
	 return 1 -- group la CongTy
GO
/****** Object:  View [dbo].[View_ChiNhanh]    Script Date: 08/18/2021 16:40:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ChiNhanh]
AS
SELECT     publ.description, subs.subscriber_server
FROM         dbo.sysmergesubscriptions AS subs INNER JOIN
                      dbo.sysmergepublications AS publ ON subs.pubid = publ.pubid AND subs.subscriber_server <> publ.publisher
WHERE     (subs.subscriber_server <> N'DOANTHIEU/SV4') AND (publ.description <> N'Tra Cứu')
GO
/****** Object:  StoredProcedure [dbo].[SP_XUATHANG]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_XUATHANG]
@Soluongxuat int, @mavt nvarchar (4)
as
if @Soluongxuat > (select Soluongton from Vattu where MAVT = @mavt)
return 1
else if @Soluongxuat <= (select Soluongton from Vattu where MAVT = @mavt)
begin
return 0
end
GO
/****** Object:  StoredProcedure [dbo].[SP_GiamSLT_Vattu]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_GiamSLT_Vattu] 
@MAVT nvarchar (4), @Soluong int
AS
update Vattu set Soluongton = Soluongton-@Soluong where MAVT = @MAVT
GO
/****** Object:  StoredProcedure [dbo].[SP_inVattu]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_inVattu] AS
Select MAVT, TENVT from Vattu Order by MAVT ASC
GO
/****** Object:  StoredProcedure [dbo].[SP_ThemSLT_Vattu]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_ThemSLT_Vattu] 
@MAVT nvarchar (4), @Soluong int
AS
update Vattu set Soluongton = @Soluong+Soluongton where MAVT = @MAVT
GO
/****** Object:  StoredProcedure [dbo].[SP_TimTenTheoMaNV]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_TimTenTheoMaNV] @MANV int
as

if exists(select  MANV from NHANVIEN with(INDEX(index_MANV)) where MANV=@MANV)
begin
select  HO+' '+TEN as hoten from NHANVIEN with(INDEX(index_MANV)) where MANV=@MANV
return 1
end
else
if exists(select  MANV from LINK1.QLVT.dbo.NHANVIEN with(INDEX(index_MANV)) where MANV=@MANV)
begin
select  HO+' '+TEN as hoten from LINK1.QLVT.dbo.NHANVIEN with(INDEX(index_MANV)) where MANV=@MANV
return 1
end
GO
/****** Object:  StoredProcedure [dbo].[SP_inNhanvien]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_inNhanvien]
as
select manv, ho+' '+ten as hoten, NGAYSINH, DIACHI, LUONG from NHANVIEN
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_DANGNHAP] @TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
if @TENUSER in (SELECT MANV FROM NHANVIEN)
begin
SELECT USERNAME = @TENUSER,
HOTEN = (SELECT HO+ ' '+ TEN FROM NHANVIEN  WHERE MANV = @TENUSER ),

NAME FROM sys.sysusers WHERE UID = 
(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
 (SELECT UID FROM sys.sysusers  WHERE NAME=@TENUSER))
 end
 else if @TENUSER in (SELECT MANV FROM LINK1.QLVT.dbo.NHANVIEN)
 begin
SELECT USERNAME = @TENUSER,
HOTEN = (SELECT HO+ ' '+ TEN FROM LINK1.QLVT.dbo.NHANVIEN  WHERE MANV = @TENUSER ),

NAME FROM sys.sysusers WHERE UID = 
(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
 (SELECT UID FROM sys.sysusers  WHERE NAME=@TENUSER))
 end
GO
/****** Object:  StoredProcedure [dbo].[SP_ChuyenNV]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_ChuyenNV] @CN nchar(10),@ho nvarchar(40),@ten nvarchar(10),@dc nvarchar(100),
@date datetime,@luong float,@USERNAME VARCHAR(50)
AS

 declare @MANV int, @LGNAME VARCHAR(50)
begin
if exists(select  nv.MANV  from LINK1.QLVT.dbo.NHANVIEN as nv where nv.HO+' '+nv.TEN = 
(select(HO+' '+TEN) from NHANVIEN where HO= @ho and TEN = @ten) )
	begin
	select @MANV =(select  nv.MANV  from LINK1.QLVT.dbo.NHANVIEN as nv where nv.HO+' '+nv.TEN = 
	(select(HO+' '+TEN) from NHANVIEN where HO= @ho and TEN = @ten) )
	update LINK1.QLVT.dbo.NHANVIEN set TrangThaiXoa = 0 where MANV = @MANV
	end
else
	begin
	select @MANV = (select COUNT(MANV)  from NHANVIEN ) + (select COUNT(MANV) from LINK1.QLVT.dbo.NHANVIEN)+1

	INSERT LINK1.QLVT.dbo.[Nhanvien] ([MANV], [HO], [TEN], [DIACHI], [NGAYSINH], [LUONG], [MACN], [TrangThaiXoa]) 
	VALUES (@MANV, @ho, @ten, @dc, @date, @luong, @CN,0)
	end
end

select @LGNAME = NAME from sys.sql_logins WHERE sid = (select sid from sys.sysusers where sys.sysusers.name = @USERNAME)
if @LGNAME = null return 2 -- khong tim thay login name
if exists(select NAME FROM sys.sysusers WHERE UID = 
	(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
	 (SELECT UID FROM sys.sysusers  WHERE NAME=@USERNAME)))
	begin
if ((select NAME FROM sys.sysusers WHERE UID = 
	(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
	 (SELECT UID FROM sys.sysusers  WHERE NAME=@USERNAME)))  = 'CongTy')
	 return 1 -- group la CongTy
	 else
		EXEC sp_droplogin @LGNAME 
		EXEC SP_REVOKEDBACCESS @USERNAME
	end
GO
/****** Object:  StoredProcedure [dbo].[SP_inDDH_PN_NULL]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_inDDH_PN_NULL] AS
Declare @tamnv table
(
	MANV int,
	HO nvarchar(40),
	TEN nvarchar(10)
)
insert into @tamnv
	select MANV, HO, TEN
	From NHANVIEN
	
Declare @tamvt table
(
	MAVT nchar(4),
	TENVT nvarchar(30)
)
insert into @tamvt
	select MAVT, TENVT 
	From Vattu
	
BEGIN
	select DATHANG.MasoDDH, DATHANG.NGAY, DATHANG.NhaCC, (tamnv.HO+' '+tamnv.TEN)as HOTEN , 
(tamvt.TENVT) as TENVT, CTDDH.SOLUONG as SOLUONG, CTDDH.DONGIA as DONGIA
from CTDDH full join DATHANG  on CTDDH.MasoDDH = DATHANG.MasoDDH 
left join PHIEUNHAP on DATHANG.MasoDDH = PHIEUNHAP.MasoDDH
join @tamvt tamvt on CTDDH.MAVT = tamvt.MAVT
join @tamnv tamnv on DATHANG.MANV = tamnv.MANV
where PHIEUNHAP.MasoDDH is null
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LaySoLuong_CTDDH]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_LaySoLuong_CTDDH]
@MAVT NVARCHAR (4), @MasoDDH NVARCHAR (50)
AS
select CTDDH.SOLUONG from CTDDH 
where CTDDH.MAVT = @MAVT AND CTDDH.MasoDDH = @MasoDDH
GO
/****** Object:  StoredProcedure [dbo].[SP_LayMaVT_CTDDH]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_LayMaVT_CTDDH]
@MasoDDH NVARCHAR (50)
AS
select CTDDH.MAVT, Vattu.TENVT from Vattu, CTDDH 
where CTDDH.MAVT = Vattu.MAVT and CTDDH.MasoDDH = @MasoDDH
GO
/****** Object:  StoredProcedure [dbo].[SP_LayDonGia_CTDDH]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_LayDonGia_CTDDH]
@MAVT NVARCHAR (4), @MasoDDH NVARCHAR (50)
AS
select CTDDH.DONGIA from CTDDH 
where CTDDH.MAVT = @MAVT AND CTDDH.MasoDDH = @MasoDDH
GO
/****** Object:  StoredProcedure [dbo].[SP_NHAPHANG]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_NHAPHANG]
	@MaDDH nchar(8),
	@MaVT nchar(4),
	@SoLuong int
AS
Declare @tbPN table
(
	MaVT nchar(4),
	SoLuong int
)
insert into @tbPN
	select MAVT, SoLuong
	From PHIEUNHAP join CTPN on PHIEUNHAP.MAPN=CTPN.MAPN
	where PHIEUNHAP.MasoDDH=@MaDDH 

if exists (select tbPN.MaVT from @tbPN tbPN where tbPN.MaVT = @MaVT )
	
	
	Declare @SLN int = (select SoLuong from @tbPN where MaVT=@MaVT) ,
			@SLDH int = (select SoLuong from CTDDH where MAVT=@MaVT and MasoDDH = @MaDDH)
	Declare @SLCon int = @SLDH - @SLN
	if @SLCon = 0 Return 0  -- đã nhập đủ hàng
	else if @SLCon > 0  -- chưa nhập đủ -> cho nhập
	begin
		if @SoLuong > @SLCon return 1 --vượt quá sl
		else if @SoLuong <= @SLCon 
			return 2 -- cho phép lưu
	end
	
	Else
	
	Begin
	Declare @Sluong int = (select SoLuong from CTDDH where MaVT = @MaVT and MasoDDH = @MaDDH)
	if(@Sluong < @SoLuong) return 1 --vượt quá số lượng
	else return 2 --cho nhập.	
End
GO
/****** Object:  StoredProcedure [dbo].[SP_KiemTraCTPN]    Script Date: 08/18/2021 16:40:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_KiemTraCTPN]
@maddh nvarchar(5), @mavt nvarchar(4)
as
Declare @tam table
(
	MAPN nvarchar(5),
	MAVT nvarchar(4)
)
insert into @tam
	select mapn, mavt
	From CTPN
if exists(select CTDDH.MasoDDH from CTDDH
join @tam tam on CTDDH.MAVT = tam.MAVT	
join DATHANG on CTDDH.MasoDDH = DATHANG.MasoDDH
join PHIEUNHAP on PHIEUNHAP.MasoDDH = DATHANG.MasoDDH
join CTPN on CTPN.MAPN = PHIEUNHAP.MAPN
where CTDDH.MasoDDH = @maddh and CTDDH.MAVT = @mavt) 
return 1
else
return 0
GO
