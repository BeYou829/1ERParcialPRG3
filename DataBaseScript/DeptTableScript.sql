USE [dbmvcp3]
GO

/****** Object:  Table [dbo].[mDepartamento]    Script Date: 2/15/2024 10:01:09 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[mDepartamento](
	[IdDepto] [int] IDENTITY(1,1) NOT NULL,
	[DeptoNombre] [nvarchar](50) NULL,
	[Activo] [int] NULL,
 CONSTRAINT [PK_mDepartamento] PRIMARY KEY CLUSTERED 
(
	[IdDepto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


