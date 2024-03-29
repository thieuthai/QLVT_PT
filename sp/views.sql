USE [QLVT]
GO
/****** Object:  View [dbo].[View_ChiNhanh]    Script Date: 08/03/2021 16:11:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ChiNhanh]
AS
SELECT publ.description, subs.subscriber_server
FROM     dbo.sysmergesubscriptions AS subs INNER JOIN
                  dbo.sysmergepublications AS publ ON subs.pubid = publ.pubid AND subs.subscriber_server <> publ.publisher
GO
