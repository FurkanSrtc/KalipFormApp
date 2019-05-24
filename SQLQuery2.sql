-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE NumuneTariheGoreSatisOranlarý
	-- Add the parameters for the stored procedure here
@pBaslangic date,
	@pBitis date
	
	AS
BEGIN


	SELECT NumuneAdi,CAST(MONTH(tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) AS Tarih, SUM(Adet) AS Adet 
FROM Numune
WHERE Tarih BETWEEN @pBaslangic AND @pBitis
GROUP BY CAST(MONTH(Tarih) AS VARCHAR(2)) + '-' + CAST(YEAR(Tarih) AS VARCHAR(4)) ,NumuneAdi
order by Tarih DESC


END
GO
