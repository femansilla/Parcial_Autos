


use master

go


create database AUTOS_DB

Go


USE [AUTOS_DB]
GO

/****** Object:  Table [dbo].[MARCAS]    Script Date: 10/21/2016 16:47:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MARCAS](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MARCAS] PRIMARY KEY CLUSTERED 
(
	[IdMarca] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

USE [AUTOS_DB]
GO

/****** Object:  Table [dbo].[AUTOS]    Script Date: 10/21/2016 16:47:42 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[AUTOS](
	[IdAuto] [int] IDENTITY(1,1) NOT NULL,
	[IdMarca] [int] NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Linea] [varchar](50) NOT NULL,
	[Anio] [int] NULL,
	[Color] [varchar](50) NULL,
 CONSTRAINT [PK_AUTOS] PRIMARY KEY CLUSTERED 
(
	[IdAuto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[AUTOS]  WITH CHECK ADD  CONSTRAINT [FK_AUTOS_MARCAS] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[MARCAS] ([IdMarca])
GO

ALTER TABLE [dbo].[AUTOS] CHECK CONSTRAINT [FK_AUTOS_MARCAS]
GO

USE [AUTOS_DB]
GO

/****** Object:  Table [dbo].[PIEZAS]    Script Date: 10/21/2016 16:47:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PIEZAS](
	[IdPieza] [int] IDENTITY(1,1) NOT NULL,
	[Pieza] [varchar](50) NOT NULL,
	[IdMarca] [int] NOT NULL,
 CONSTRAINT [PK_PIEZAS] PRIMARY KEY CLUSTERED 
(
	[IdPieza] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[PIEZAS]  WITH CHECK ADD  CONSTRAINT [FK_PIEZAS_MARCAS] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[MARCAS] ([IdMarca])
GO

ALTER TABLE [dbo].[PIEZAS] CHECK CONSTRAINT [FK_PIEZAS_MARCAS]
GO

USE [AUTOS_DB]
GO

/****** Object:  Table [dbo].[AUTOS_PIEZAS]    Script Date: 10/21/2016 16:48:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AUTOS_PIEZAS](
	[IdAutoPieza] [int] IDENTITY(1,1) NOT NULL,
	[IdAuto] [int] NOT NULL,
	[IdPieza] [int] NOT NULL,
 CONSTRAINT [PK_AUTOS_PIEZAS] PRIMARY KEY CLUSTERED 
(
	[IdAutoPieza] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AUTOS_PIEZAS]  WITH CHECK ADD  CONSTRAINT [FK_AUTOS_PIEZAS_AUTOS] FOREIGN KEY([IdAuto])
REFERENCES [dbo].[AUTOS] ([IdAuto])
GO

ALTER TABLE [dbo].[AUTOS_PIEZAS] CHECK CONSTRAINT [FK_AUTOS_PIEZAS_AUTOS]
GO

ALTER TABLE [dbo].[AUTOS_PIEZAS]  WITH CHECK ADD  CONSTRAINT [FK_AUTOS_PIEZAS_PIEZAS] FOREIGN KEY([IdPieza])
REFERENCES [dbo].[PIEZAS] ([IdPieza])
GO

ALTER TABLE [dbo].[AUTOS_PIEZAS] CHECK CONSTRAINT [FK_AUTOS_PIEZAS_PIEZAS]
GO

USE [AUTOS_DB]
GO

/****** Object:  Table [dbo].[USUARIOS]    Script Date: 10/21/2016 16:48:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[USUARIOS](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[PalabraClave] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USUARIOS] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO




-------
--agrego datos
------------------------------
Insert into MARCAS Values ('Ford')
Insert into MARCAS Values ('Renault')
Insert into MARCAS Values ('Fiat')
Insert into MARCAS Values ('Volskwagen')
Insert into MARCAS Values ('Audi')
Insert into MARCAS Values ('BMW')
Insert into MARCAS Values ('Mercedes Benz')
Insert into MARCAS Values ('Honda')
Insert into MARCAS Values ('Hyundai')
Insert into MARCAS Values ('Toyota')
Insert into MARCAS Values ('Citrôen')
Insert into MARCAS Values ('Pirelli')
Insert into MARCAS Values ('GoodYear')
Insert into MARCAS Values ('Firestone')
Insert into MARCAS Values ('Sony')
Insert into MARCAS Values ('Samsung')
Insert into MARCAS Values ('GARMIN')

Insert into AUTOS Values (1, 'Fiesta KD', 'Titanium', 2010, 'Blanco')
Insert into AUTOS Values (1, 'Fiesta KD', 'Titanium PowerShift', 2015, 'Gris Plata')
Insert into AUTOS Values (2, 'Clio', 'Mio', 2014, 'Rojo')
Insert into AUTOS Values (2, 'Mégane', 'A/D', 2010, 'Dorado')
Insert into AUTOS Values (4, 'Golf', 'HighLine', 2015, 'Blanco')
Insert into AUTOS Values (4, 'Golf', 'Trendline', 2015, 'Negro')
Insert into AUTOS Values (4, 'Fox', 'Confortline', 2010, 'Amarillo')
Insert into AUTOS Values (5, 'A4', 'Spotback', 2010, 'Plata')
Insert into AUTOS Values (5, 'TT', 'Sport', 2015, 'Negro')

Insert into PIEZAS Values ('Motor', 1)--1
Insert into PIEZAS Values ('Motor', 5)--2
Insert into PIEZAS Values ('Motor', 10)--3
Insert into PIEZAS Values ('Neumáticos', 12)--4
Insert into PIEZAS Values ('Llantas', 13)--5
Insert into PIEZAS Values ('Alzacristales', 4)--6
Insert into PIEZAS Values ('Cierre Centralizado', 1)--7
Insert into PIEZAS Values ('Airbags', 10)--8
Insert into PIEZAS Values ('Caja Manual', 5)--9
Insert into PIEZAS Values ('Caja Automática', 5)--10
Insert into PIEZAS Values ('Sistema audio', 15)--11
Insert into PIEZAS Values ('Aire Acondicionado', 16)--12
Insert into PIEZAS Values ('GPS', 17)--13

Insert into AUTOS_PIEZAS Values(5, 2)
Insert into AUTOS_PIEZAS Values(5, 10)
Insert into AUTOS_PIEZAS Values(5, 13)

Insert into AUTOS_PIEZAS Values(6,2)
Insert into AUTOS_PIEZAS Values(6, 9)
Insert into AUTOS_PIEZAS Values(6, 12)

Insert into AUTOS_PIEZAS Values(7, 10)
Insert into AUTOS_PIEZAS Values(7, 6)
Insert into AUTOS_PIEZAS Values(7, 3)

Insert into AUTOS_PIEZAS Values(8, 11)
Insert into AUTOS_PIEZAS Values(8, 8)
Insert into AUTOS_PIEZAS Values(8, 5)

Insert into AUTOS_PIEZAS Values(9, 1)
Insert into AUTOS_PIEZAS Values(9, 5)
Insert into AUTOS_PIEZAS Values(9, 10)

Insert into AUTOS_PIEZAS Values(1,1)
Insert into AUTOS_PIEZAS Values(1,9)
Insert into AUTOS_PIEZAS Values(1,4)

Insert into AUTOS_PIEZAS Values(2, 1)
Insert into AUTOS_PIEZAS Values(2, 10)
Insert into AUTOS_PIEZAS Values(2, 13)

Insert into AUTOS_PIEZAS Values(3, 3)
Insert into AUTOS_PIEZAS Values(3, 12)
Insert into AUTOS_PIEZAS Values(3, 5)

Insert into AUTOS_PIEZAS Values(4, 6)
Insert into AUTOS_PIEZAS Values(4, 13)
Insert into AUTOS_PIEZAS Values(4, 12)

insert into usuarios values ('admin', '123')
insert into usuarios values ('test', 'test')