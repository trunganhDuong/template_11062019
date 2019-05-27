USE [template_20052019]
GO

/****** Object:  StoredProcedure [dbo].[Article_Save]    Script Date: 27/05/2019 8:11:19 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Article_Save]
	@_ArticleId INT = 0,
	@_ArticleTitle NVARCHAR(255),
	@_Sapo NVARCHAR(1024),
	@_Avatar VARCHAR(1024),
	@_Content NVARCHAR(MAX)
AS
BEGIN
	IF(@_ArticleId > 0)
	BEGIN
		UPDATE Articles
		SET ArticleTitle = @_ArticleTitle, Sapo=@_Sapo , Avatar = @_Avatar, Content = @_Content

		SELECT 1;
	END
	ELSE
	BEGIN
		INSERT INTO Articles(ArticleTitle, Sapo, Avatar, Content, CreatedDate)
		VALUES(@_ArticleTitle, @_Sapo, @_Avatar, @_Content, GETDATE())

		SELECT 1;
	END
END
GO


