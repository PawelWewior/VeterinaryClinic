USE [Vet]
GO
/****** Object:  Table [dbo].[Choroba]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Choroba](
	[IDChoroba] [int] IDENTITY(1,1) NOT NULL,
	[NazwaCh] [nvarchar](50) NOT NULL,
	[OpisCh] [nvarchar](50) NOT NULL,
	[WymogHospitalizacji] [nchar](3) NOT NULL,
	[IDZwierze] [int] NOT NULL,
 CONSTRAINT [PK_Choroba] PRIMARY KEY CLUSTERED 
(
	[IDChoroba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Opiekun]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opiekun](
	[IDOpiekun] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](30) NOT NULL,
	[Nazwisko] [nvarchar](30) NOT NULL,
	[Telefon] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Wlasciciel] PRIMARY KEY CLUSTERED 
(
	[IDOpiekun] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[IDPersonel] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[Nazwisko] [nvarchar](50) NOT NULL,
	[Stanowisko] [nvarchar](50) NOT NULL,
	[Telefon] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[IDPersonel] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pomieszczenia]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pomieszczenia](
	[IDPomieszczenia] [int] IDENTITY(1,1) NOT NULL,
	[NrPomieszczenia] [int] NOT NULL,
 CONSTRAINT [PK_Pomieszczenia] PRIMARY KEY CLUSTERED 
(
	[IDPomieszczenia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sprzet]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sprzet](
	[IDSprzet] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [nvarchar](50) NOT NULL,
	[CzyDostepny] [nchar](3) NOT NULL,
	[IDPersonel] [int] NULL,
 CONSTRAINT [PK_Sprzet] PRIMARY KEY CLUSTERED 
(
	[IDSprzet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wizyta]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wizyta](
	[IDWizyta] [int] IDENTITY(1,1) NOT NULL,
	[DataWizyty] [nvarchar](50) NOT NULL,
	[KosztWizyty] [decimal](18, 0) NOT NULL,
	[IDZwierze] [int] NOT NULL,
	[IDPersonel] [int] NOT NULL,
 CONSTRAINT [PK_Wizyta] PRIMARY KEY CLUSTERED 
(
	[IDWizyta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zwierze]    Script Date: 2021-06-21 14:54:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zwierze](
	[IDZwierze] [int] IDENTITY(1,1) NOT NULL,
	[Imie] [nvarchar](50) NOT NULL,
	[TypZwierzecia] [nvarchar](20) NOT NULL,
	[Gatunek] [nvarchar](50) NOT NULL,
	[Wiek] [int] NOT NULL,
	[IDOpiekun] [int] NOT NULL,
	[IDPersonel] [int] NULL,
	[IDPomieszczenia] [int] NULL,
 CONSTRAINT [PK_Pacjent] PRIMARY KEY CLUSTERED 
(
	[IDZwierze] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Choroba]  WITH CHECK ADD  CONSTRAINT [FK_Choroba_Zwierze] FOREIGN KEY([IDZwierze])
REFERENCES [dbo].[Zwierze] ([IDZwierze])
GO
ALTER TABLE [dbo].[Choroba] CHECK CONSTRAINT [FK_Choroba_Zwierze]
GO
ALTER TABLE [dbo].[Sprzet]  WITH CHECK ADD  CONSTRAINT [FK_Sprzet_Personel] FOREIGN KEY([IDPersonel])
REFERENCES [dbo].[Personel] ([IDPersonel])
ON UPDATE SET NULL
GO
ALTER TABLE [dbo].[Sprzet] CHECK CONSTRAINT [FK_Sprzet_Personel]
GO
ALTER TABLE [dbo].[Wizyta]  WITH CHECK ADD  CONSTRAINT [FK_Wizyta_Personel] FOREIGN KEY([IDPersonel])
REFERENCES [dbo].[Personel] ([IDPersonel])
GO
ALTER TABLE [dbo].[Wizyta] CHECK CONSTRAINT [FK_Wizyta_Personel]
GO
ALTER TABLE [dbo].[Wizyta]  WITH CHECK ADD  CONSTRAINT [FK_Wizyta_Zwierze] FOREIGN KEY([IDZwierze])
REFERENCES [dbo].[Zwierze] ([IDZwierze])
GO
ALTER TABLE [dbo].[Wizyta] CHECK CONSTRAINT [FK_Wizyta_Zwierze]
GO
ALTER TABLE [dbo].[Zwierze]  WITH CHECK ADD  CONSTRAINT [FK_Zwierze_Opiekun] FOREIGN KEY([IDOpiekun])
REFERENCES [dbo].[Opiekun] ([IDOpiekun])
GO
ALTER TABLE [dbo].[Zwierze] CHECK CONSTRAINT [FK_Zwierze_Opiekun]
GO
ALTER TABLE [dbo].[Zwierze]  WITH CHECK ADD  CONSTRAINT [FK_Zwierze_Personel] FOREIGN KEY([IDPersonel])
REFERENCES [dbo].[Personel] ([IDPersonel])
GO
ALTER TABLE [dbo].[Zwierze] CHECK CONSTRAINT [FK_Zwierze_Personel]
GO
ALTER TABLE [dbo].[Zwierze]  WITH CHECK ADD  CONSTRAINT [FK_Zwierze_Pomieszczenia] FOREIGN KEY([IDPomieszczenia])
REFERENCES [dbo].[Pomieszczenia] ([IDPomieszczenia])
GO
ALTER TABLE [dbo].[Zwierze] CHECK CONSTRAINT [FK_Zwierze_Pomieszczenia]
GO
