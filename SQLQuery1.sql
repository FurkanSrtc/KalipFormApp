USE [KalipDB]
GO
/****** Object:  StoredProcedure [dbo].[prcPieChartOnlyDate]    Script Date: 23.05.2019 23:55:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[prcPieChartOnlyDate]
	-- Add the parameters for the stored procedure here
	@pBaslangic date,
	@pBitis date

AS
BEGIN
	SELECT CAST(MONTH(tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) AS Tarih, SUM(Adet) AS Adet 
FROM Numune
WHERE Tarih BETWEEN @pBaslangic AND @pBitis
GROUP BY CAST(MONTH(Tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) 

END

exec prcPieChartOnlyDate '2019-02-03','2019-05-03'

	SELECT NumuneAdi,CAST(MONTH(tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) AS Tarih, SUM(Adet) AS Adet 
FROM Numune
WHERE Tarih BETWEEN '2019-02-03' AND '2019-05-03'
GROUP BY CAST(MONTH(Tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) ,NumuneAdi
order by Tarih DESC