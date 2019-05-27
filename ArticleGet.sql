USE [template_20052019]
GO

/****** Object:  StoredProcedure [dbo].[Article_Get]    Script Date: 27/05/2019 8:11:00 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Articl
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Get]
	@_ItemId INT = 0,
	@_PageSize INT = 20,
	@_PageIndex INT = 1
AS
BEGIN
	IF(@_ItemId > 0)
	BEGIN
		SELECT * FROM Articles WHERE ArticleId = @_ItemId
	END
	ELSE
	BEGIN
		DECLARE @_Start INT, @_End INT
		SET @_Start = @_PageSize * (@_PageIndex - 1) + 1;
		SET @_End = @_Start + @_PageSize - 1;

		WITH tbl AS
		(
			SELECT TOP(@_PageSize * @_PageIndex) *, ROW_NUMBER() OVER (ORDER BY ArticleId DESC) AS RowIndex FROM Articles
		)
		SELECT * FROM tbl WHERE RowIndex >= @_Start AND RowIndex <= @_End

		SELECT COUNT(ArticleId) AS TotalRecord FROM Articles
	END
END
GO


