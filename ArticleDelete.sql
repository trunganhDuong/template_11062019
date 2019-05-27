USE [template_20052019]
GO

/****** Object:  StoredProcedure [dbo].[Article_Delete]    Script Date: 27/05/2019 8:10:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Delete] 
	@_ItemId INT = 0
AS
BEGIN
	IF(@_ItemId > 0)
	BEGIN
		DELETE FROM Articles WHERE ArticleId = @_ItemId
		SELECT 1;
	END
	ELSE
	BEGIN
		SELECT 0;
	END
END
GO


