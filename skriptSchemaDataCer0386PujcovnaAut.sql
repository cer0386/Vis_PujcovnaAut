USE [cer0386]
GO
/****** Object:  Table [vis].[auto]    Script Date: 04/01/2019 15:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[auto](
	[spz] [char](7) NOT NULL,
	[zakoupeno] [date] NOT NULL,
	[stk] [date] NOT NULL,
	[typ] [varchar](50) NOT NULL,
	[znacka] [varchar](25) NOT NULL,
	[pocet_nehod] [int] NOT NULL,
	[cena_za_den] [float] NOT NULL,
	[vyrazeno] [bit] NOT NULL,
 CONSTRAINT [auto_pk] PRIMARY KEY CLUSTERED 
(
	[spz] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[faktura]    Script Date: 04/01/2019 15:11:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[faktura](
	[cislo_faktury] [int] NOT NULL,
	[cislo_rezervace] [int] NOT NULL,
	[vytvoreno] [datetime] NOT NULL,
	[potvrzeno] [datetime] NULL,
	[zaplaceno] [datetime] NULL,
 CONSTRAINT [faktura_pk] PRIMARY KEY CLUSTERED 
(
	[cislo_faktury] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[platba]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[platba](
	[id_platba] [int] NOT NULL,
	[cislo_faktury] [int] NOT NULL,
	[typ_platby] [varchar](50) NOT NULL,
	[castka] [int] NOT NULL,
 CONSTRAINT [platba_pk] PRIMARY KEY CLUSTERED 
(
	[id_platba] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[rezervace]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[rezervace](
	[cislo_rezervace] [int] NOT NULL,
	[id_zakaznika] [int] NOT NULL,
	[vyzvednuti] [datetime] NOT NULL,
	[vraceni] [datetime] NOT NULL,
 CONSTRAINT [rezervace_pk] PRIMARY KEY CLUSTERED 
(
	[cislo_rezervace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[rezervovano]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[rezervovano](
	[cislo_rezervace] [int] NOT NULL,
	[auto_spz] [char](7) NOT NULL,
 CONSTRAINT [rezervovano_pk] PRIMARY KEY CLUSTERED 
(
	[cislo_rezervace] ASC,
	[auto_spz] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[upravuje]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[upravuje](
	[ID_zamestnance] [int] NOT NULL,
	[Cislo_Rezervace] [int] NOT NULL,
 CONSTRAINT [Upravuje_PK] PRIMARY KEY CLUSTERED 
(
	[ID_zamestnance] ASC,
	[Cislo_Rezervace] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[zakaznik]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[zakaznik](
	[id_zakaznika] [int] NOT NULL,
	[jmeno] [varchar](30) NOT NULL,
	[prijmeni] [varchar](30) NOT NULL,
	[mesto] [varchar](50) NOT NULL,
	[ulice] [varchar](50) NOT NULL,
	[cislo_popisne] [int] NOT NULL,
	[psc] [int] NOT NULL,
	[email] [varchar](50) NOT NULL,
	[cislo_ridickeho_prukazu] [char](8) NOT NULL,
 CONSTRAINT [zakaznik_pk] PRIMARY KEY CLUSTERED 
(
	[id_zakaznika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [vis].[zamestnanec]    Script Date: 04/01/2019 15:11:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [vis].[zamestnanec](
	[id_zamestnance] [int] NOT NULL,
	[jmeno] [varchar](30) NOT NULL,
	[prijmeni] [varchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[pozice] [varchar](50) NOT NULL,
 CONSTRAINT [zamestnanec_pk] PRIMARY KEY CLUSTERED 
(
	[id_zamestnance] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'5HNA0TJ', CAST(N'2006-09-06' AS Date), CAST(N'2021-01-12' AS Date), N'Coupé', N'Mercedes', 4, 1000, 1)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'EG5F2MD', CAST(N'2011-05-12' AS Date), CAST(N'2020-07-29' AS Date), N'Sedan', N'Citroen', 2, 500.6, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'EM0FCVY', CAST(N'2006-03-02' AS Date), CAST(N'2021-04-09' AS Date), N'Coupé', N'Škoda', 0, 700.65, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'G489R4W', CAST(N'2017-03-05' AS Date), CAST(N'2024-11-20' AS Date), N'Kabriolet', N'Seat', 2, 3214.45, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'J4HUIZR', CAST(N'2000-08-30' AS Date), CAST(N'2020-10-26' AS Date), N'Dodávka', N'Mitsubishi', 7, 9000, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'K4ZERS3', CAST(N'2015-02-23' AS Date), CAST(N'2019-07-08' AS Date), N'SUV', N'Seat', 2, 321.2, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'KY4WHI3', CAST(N'2010-06-28' AS Date), CAST(N'2017-05-25' AS Date), N'SUV', N'Ford', 9, 300.99, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'L6BZ30X', CAST(N'2008-04-21' AS Date), CAST(N'2017-11-19' AS Date), N'Roadster', N'Audi', 4, 1681.25, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'NIFD456', CAST(N'2010-08-28' AS Date), CAST(N'2017-05-25' AS Date), N'Kombi', N'Ford', 0, 987.65, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'W94L2UQ', CAST(N'2010-02-13' AS Date), CAST(N'2022-07-16' AS Date), N'Kombi', N'Audi', 5, 963.2, 1)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'XF0U8BL', CAST(N'2008-05-02' AS Date), CAST(N'2018-11-17' AS Date), N'Kombi', N'Kia', 4, 222.22, 0)
INSERT [vis].[auto] ([spz], [zakoupeno], [stk], [typ], [znacka], [pocet_nehod], [cena_za_den], [vyrazeno]) VALUES (N'XQBFDUB', CAST(N'2014-07-18' AS Date), CAST(N'2024-05-14' AS Date), N'Kombi', N'Toyota', 2, 780.6, 0)
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (1, 1, CAST(N'2005-02-28T14:49:18.000' AS DateTime), CAST(N'2005-02-28T14:49:18.000' AS DateTime), CAST(N'2005-02-28T14:49:18.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (2, 2, CAST(N'2015-11-04T07:07:33.000' AS DateTime), CAST(N'2015-11-04T07:07:33.000' AS DateTime), CAST(N'2015-11-04T07:07:33.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (3, 3, CAST(N'2000-12-18T04:22:55.000' AS DateTime), CAST(N'2000-12-20T04:22:55.000' AS DateTime), NULL)
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (4, 4, CAST(N'2003-06-09T07:09:39.000' AS DateTime), CAST(N'2003-06-09T20:09:39.000' AS DateTime), CAST(N'2003-06-09T20:09:39.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (5, 5, CAST(N'2008-11-19T12:21:53.000' AS DateTime), CAST(N'2008-11-19T12:21:53.000' AS DateTime), CAST(N'2008-11-19T12:21:53.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (6, 6, CAST(N'2017-08-04T15:50:47.000' AS DateTime), CAST(N'2017-08-06T15:50:47.000' AS DateTime), CAST(N'2017-08-06T15:50:47.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (7, 7, CAST(N'2010-12-08T13:35:22.000' AS DateTime), CAST(N'2010-12-08T13:35:22.000' AS DateTime), CAST(N'2010-12-08T13:35:22.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (8, 8, CAST(N'2014-04-22T23:53:13.000' AS DateTime), CAST(N'2014-04-22T23:53:13.000' AS DateTime), NULL)
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (9, 9, CAST(N'2004-01-22T04:49:11.000' AS DateTime), CAST(N'2004-01-23T04:49:11.000' AS DateTime), CAST(N'2004-01-23T04:49:11.000' AS DateTime))
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (10, 10, CAST(N'2017-08-10T18:21:20.000' AS DateTime), CAST(N'2017-08-11T07:21:20.000' AS DateTime), NULL)
INSERT [vis].[faktura] ([cislo_faktury], [cislo_rezervace], [vytvoreno], [potvrzeno], [zaplaceno]) VALUES (11, 11, CAST(N'2018-12-19T21:44:35.880' AS DateTime), CAST(N'2018-12-19T21:44:35.880' AS DateTime), NULL)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (1, 1, N'Kartou', 12814)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (2, 2, N'Hotovost', 20992)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (4, 4, N'Kartou', 27082)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (5, 5, N'Bankovní převod', 8114)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (6, 6, N'Hotovost', 29882)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (7, 7, N'Hotovost', 18303)
INSERT [vis].[platba] ([id_platba], [cislo_faktury], [typ_platby], [castka]) VALUES (9, 9, N'Kartou', 22179)
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (1, 1, CAST(N'2008-01-04T14:25:32.000' AS DateTime), CAST(N'2008-02-23T14:25:32.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (2, 1, CAST(N'2006-11-15T08:57:05.000' AS DateTime), CAST(N'2007-01-15T08:57:05.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (3, 2, CAST(N'2001-07-22T04:57:22.000' AS DateTime), CAST(N'2001-08-10T04:57:22.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (4, 3, CAST(N'2010-12-02T05:03:39.000' AS DateTime), CAST(N'2011-02-22T05:03:39.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (5, 2, CAST(N'2015-11-04T01:20:31.000' AS DateTime), CAST(N'2015-12-12T01:20:31.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (6, 6, CAST(N'2014-04-13T01:43:20.000' AS DateTime), CAST(N'2014-05-28T01:43:20.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (7, 7, CAST(N'2017-01-12T07:40:56.000' AS DateTime), CAST(N'2017-04-11T07:40:56.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (8, 6, CAST(N'2008-01-24T10:50:48.000' AS DateTime), CAST(N'2008-02-17T10:50:48.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (9, 4, CAST(N'2011-04-15T09:15:23.000' AS DateTime), CAST(N'2011-04-22T09:15:23.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (10, 5, CAST(N'2007-05-10T07:17:56.000' AS DateTime), CAST(N'2007-05-31T07:17:56.000' AS DateTime))
INSERT [vis].[rezervace] ([cislo_rezervace], [id_zakaznika], [vyzvednuti], [vraceni]) VALUES (11, 2, CAST(N'2019-01-20T00:00:00.000' AS DateTime), CAST(N'2019-03-01T00:00:00.000' AS DateTime))
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'EG5F2MD')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'EM0FCVY')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'J4HUIZR')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'KY4WHI3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'L6BZ30X')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'W94L2UQ')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (1, N'XF0U8BL')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (2, N'EG5F2MD')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (2, N'KY4WHI3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (2, N'XQBFDUB')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (3, N'EG5F2MD')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (3, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (4, N'L6BZ30X')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (4, N'XF0U8BL')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (5, N'G489R4W')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (5, N'J4HUIZR')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (5, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (5, N'KY4WHI3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (6, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (6, N'KY4WHI3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (6, N'W94L2UQ')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (7, N'W94L2UQ')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (8, N'J4HUIZR')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (9, N'G489R4W')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (10, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (11, N'K4ZERS3')
INSERT [vis].[rezervovano] ([cislo_rezervace], [auto_spz]) VALUES (11, N'KY4WHI3')
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (1, 10)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (2, 1)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (2, 3)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (2, 7)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (2, 9)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (2, 10)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (3, 8)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (3, 10)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (4, 6)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (4, 7)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (7, 4)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (7, 5)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (7, 10)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (8, 3)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (8, 10)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (9, 2)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (9, 6)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (9, 8)
INSERT [vis].[upravuje] ([ID_zamestnance], [Cislo_Rezervace]) VALUES (10, 1)
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (1, N'Pepa', N'Krnoš', N'Jablunkov', N'Babišova', 2, 70499, N'Pepa.Krnoš@tiscalli.cz', N'BB111112')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (2, N'Žaneta', N'Němcová', N'Frýdek-Místek', N'Sabinova', 4, 43576, N'Žaneta.Němcová@seznam.cz', N'CC111113')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (3, N'Žaneta', N'Svoboddová', N'Třinec', N'Jablunkovská', 12, 57388, N'Žaneta.Svobodová@tiscalli.cz', N'EE111114')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (4, N'Michaela', N'Němcová', N'Ostrava', N'Svobody', 16, 77280, N'Michaela.Němcová@email.cz', N'EE111115')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (5, N'Michal', N'Němec', N'Ostrava', N'1. Máje', 20, 20423, N'Michal.Němec@email.cz', N'DD111116')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (6, N'Radim', N'Černý', N'Olomouc', N'Varenská', 12, 59880, N'Radim.Černý@gmail.com', N'BB111117')
INSERT [vis].[zakaznik] ([id_zakaznika], [jmeno], [prijmeni], [mesto], [ulice], [cislo_popisne], [psc], [email], [cislo_ridickeho_prukazu]) VALUES (7, N'Ladislav', N'Kučera', N'Třinec', N'Svobody', 14, 57880, N'Ladislav.Kučera@seznam.cz', N'AA111118')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (1, N'Dominika', N'Krnošová', N'zam1@pujc.cz', N'Manažer')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (2, N'Jarmila', N'Pospíšilová', N'zam2@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (3, N'Magda', N'Svobodová', N'zam3@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (4, N'David', N'Jelínek', N'zam4@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (5, N'Michal', N'Dvořák', N'zam5@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (6, N'David', N'Beneš', N'zam6@pujc.cz', N'Manažer')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (7, N'Jarmila', N'Černá', N'zam7@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (8, N'David', N'Němec', N'zam8@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (9, N'Petr', N'Veselý', N'zam9@pujc.cz', N'Prodejce')
INSERT [vis].[zamestnanec] ([id_zamestnance], [jmeno], [prijmeni], [email], [pozice]) VALUES (10, N'Lukáš', N'Procházka', N'zam10@pujc.cz', N'Prodejce')
ALTER TABLE [vis].[faktura]  WITH CHECK ADD  CONSTRAINT [faktura_rezervace_fk] FOREIGN KEY([cislo_rezervace])
REFERENCES [vis].[rezervace] ([cislo_rezervace])
GO
ALTER TABLE [vis].[faktura] CHECK CONSTRAINT [faktura_rezervace_fk]
GO
ALTER TABLE [vis].[platba]  WITH CHECK ADD  CONSTRAINT [platba_faktura_fk] FOREIGN KEY([cislo_faktury])
REFERENCES [vis].[faktura] ([cislo_faktury])
GO
ALTER TABLE [vis].[platba] CHECK CONSTRAINT [platba_faktura_fk]
GO
ALTER TABLE [vis].[rezervace]  WITH CHECK ADD  CONSTRAINT [rezervace_zakaznik_fk] FOREIGN KEY([id_zakaznika])
REFERENCES [vis].[zakaznik] ([id_zakaznika])
GO
ALTER TABLE [vis].[rezervace] CHECK CONSTRAINT [rezervace_zakaznik_fk]
GO
ALTER TABLE [vis].[rezervovano]  WITH CHECK ADD  CONSTRAINT [rezervovano_auto_fk] FOREIGN KEY([auto_spz])
REFERENCES [vis].[auto] ([spz])
GO
ALTER TABLE [vis].[rezervovano] CHECK CONSTRAINT [rezervovano_auto_fk]
GO
ALTER TABLE [vis].[rezervovano]  WITH CHECK ADD  CONSTRAINT [rezervovano_rezervace_fk] FOREIGN KEY([cislo_rezervace])
REFERENCES [vis].[rezervace] ([cislo_rezervace])
GO
ALTER TABLE [vis].[rezervovano] CHECK CONSTRAINT [rezervovano_rezervace_fk]
GO
ALTER TABLE [vis].[upravuje]  WITH CHECK ADD  CONSTRAINT [Upravuje_Rezervace_FK] FOREIGN KEY([Cislo_Rezervace])
REFERENCES [vis].[rezervace] ([cislo_rezervace])
GO
ALTER TABLE [vis].[upravuje] CHECK CONSTRAINT [Upravuje_Rezervace_FK]
GO
ALTER TABLE [vis].[upravuje]  WITH CHECK ADD  CONSTRAINT [Upravuje_Zamestnanec_FK] FOREIGN KEY([ID_zamestnance])
REFERENCES [vis].[zamestnanec] ([id_zamestnance])
GO
ALTER TABLE [vis].[upravuje] CHECK CONSTRAINT [Upravuje_Zamestnanec_FK]
GO
