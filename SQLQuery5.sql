USE [KalipDB]
GO
/****** Object:  StoredProcedure [dbo].[prcPieChartOnlyDate]    Script Date: 24.05.2019 00:30:02 ******/
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

SELECT NumuneAdi,CAST(MONTH(tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) AS Tarih, SUM(Adet) AS Adet 
FROM Numune
WHERE Tarih BETWEEN '2015' AND '2020'
GROUP BY CAST(MONTH(Tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) ,NumuneAdi
order by Tarih DESC, Adet Desc