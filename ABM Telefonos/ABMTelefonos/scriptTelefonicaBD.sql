
USE Telefonica
GO
/****** Object:  Table [dbo].[Marcas]    Script Date: 18/6/2021 20:58:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marcas](
	[idMarca] [int] NOT NULL,
	[nombreMarca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Marcas] PRIMARY KEY CLUSTERED 
(
	[idMarca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telefonos]    Script Date: 18/6/2021 20:58:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telefonos](
	[codigo] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[marca] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_Telefonos] PRIMARY KEY CLUSTERED 
(
	[codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (1, N'Samsung')
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (2, N'Motorola')
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (3, N'LG')
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (4, N'Huawei')
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (5, N'Apple')
INSERT [dbo].[Marcas] ([idMarca], [nombreMarca]) VALUES (6, N'Sony')
GO
INSERT [dbo].[Telefonos] ([codigo], [nombre], [marca], [precio]) VALUES (1, N'S21', 1, 50000)
INSERT [dbo].[Telefonos] ([codigo], [nombre], [marca], [precio]) VALUES (2, N'G9', 2, 60000)
INSERT [dbo].[Telefonos] ([codigo], [nombre], [marca], [precio]) VALUES (3, N'P30', 4, 70000)
GO
