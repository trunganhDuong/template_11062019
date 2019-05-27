USE [template_20052019]
GO

/****** Object:  Table [dbo].[Articles]    Script Date: 27/05/2019 8:10:11 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Articles](
	[ArticleId] [int] IDENTITY(1,1) NOT NULL,
	[ArticleTitle] [nvarchar](255) NULL,
	[Sapo] [nvarchar](1024) NULL,
	[Avatar] [varchar](255) NULL,
	[Content] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Articles] PRIMARY KEY CLUSTERED 
(
	[ArticleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


