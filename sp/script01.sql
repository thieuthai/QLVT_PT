USE [another_QLVT]
GO
/****** Object:  StoredProcedure [dbo].[sp_DanhsachChinhanh]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_DanhsachChinhanh] 
	
AS
BEGIN
	SELECT PUBS.description, subscriber_server
   FROM dbo.sysmergepublications PUBS,  dbo.sysmergesubscriptions SUBS
   WHERE PUBS.pubid= SUBS.PUBID  AND PUBS.publisher <> SUBS.subscriber_server
END
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[sp_TaoTaiKhoan]
	@LGNAME VARCHAR(50),
	@PASS VARCHAR(50),
	@USERNAME VARCHAR(50),
	@ROLE VARCHAR(50)
AS
BEGIN
  DECLARE @RET INT
  EXEC @RET= SP_ADDLOGIN @LGNAME, @PASS,'another_QLVT'                     

  IF (@RET =1)  -- LOGIN NAME BI TRUNG
     RETURN 1

  EXEC @RET= SP_GRANTDBACCESS @LGNAME, @USERNAME
  IF (@RET =1)  -- USER  NAME BI TRUNG
  BEGIN
       EXEC SP_DROPLOGIN @LGNAME
       RETURN 2
  END
  EXEC sp_addrolemember @ROLE, @USERNAME
  IF @ROLE= 'ChiNhanh'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
	IF @ROLE= 'CongTy'
	BEGIN 
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END
  IF @ROLE= 'NhanVien'
	BEGIN  
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

END
GO
/****** Object:  StoredProcedure [dbo].[SP_GiamSLT_Vattu]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_XUATHANG]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_ThemSLT_Vattu]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_inVattu]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_inVattu]
AS
Select MAVT, TENVT from Vattu Order by MAVT
GO
/****** Object:  StoredProcedure [dbo].[SP_inNhanvien]    Script Date: 08/03/2021 17:25:22 ******/
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
select manv, ho+' '+ten as hoten, NGAYSINH, DIACHI, LUONG from Nhanvien
GO
/****** Object:  StoredProcedure [dbo].[SP_DANGNHAP]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROC [dbo].[SP_DANGNHAP]
@TENLOGIN NVARCHAR (50)
AS
DECLARE @TENUSER NVARCHAR(50)
SELECT @TENUSER=NAME FROM sys.sysusers WHERE sid = SUSER_SID(@TENLOGIN)
if @TENUSER in (SELECT MANV FROM Nhanvien)
SELECT USERNAME = @TENUSER,
HOTEN = (SELECT HO+ ' '+ TEN FROM Nhanvien  WHERE MANV = @TENUSER ),

NAME FROM sys.sysusers WHERE UID = 
(SELECT GROUPUID FROM SYS.SYSMEMBERS WHERE MEMBERUID=
 (SELECT UID FROM sys.sysusers  WHERE NAME=@TENUSER))
GO
/****** Object:  StoredProcedure [dbo].[SP_inDDH_PN_NULL]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_inDDH_PN_NULL]
AS
BEGIN
	select DatHang.MasoDDH, DatHang.NGAY, DatHang.NhaCC, DatHang.MANV, 
isnull(CTDDH.MAVT,0) as MAVT, isnull(CTDDH.SOLUONG, 0) as SOLUONG, isnull(CTDDH.DONGIA,0) as DONGIA
from CTDDH full join DatHang on CTDDH.MasoDDH = DatHang.MasoDDH 
left join PhieuNhap on DatHang.MasoDDH = PhieuNhap.MasoDDH
where PhieuNhap.MasoDDH is null
END
GO
/****** Object:  StoredProcedure [dbo].[SP_LaySoLuong_CTDDH]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LayMaVT_CTDDH]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_LayDonGia_CTDDH]    Script Date: 08/03/2021 17:25:22 ******/
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
/****** Object:  StoredProcedure [dbo].[SP_NHAPHANG]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[SP_NHAPHANG]
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
	From PhieuNhap join CTPN on PhieuNhap.MAPN=CTPN.MAPN
	where PhieuNhap.MasoDDH=@MaDDH 

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
/****** Object:  StoredProcedure [dbo].[sp_KiemTraCTPN]    Script Date: 08/03/2021 17:25:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[sp_KiemTraCTPN]
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
join DatHang on CTDDH.MasoDDH = DatHang.MasoDDH
join PhieuNhap on PhieuNhap.MasoDDH = DatHang.MasoDDH
join CTPN on CTPN.MAPN = PhieuNhap.MAPN
where CTDDH.MasoDDH = @maddh and CTDDH.MAVT = @mavt) 
return 1
else
return 0
GO
