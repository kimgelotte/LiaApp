SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc sp_testing
as
select * from db_newton.Företag
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_TransactionIndex_c936fea1-8e0d-41f4-b266-8e6d395efd6e](
	[Id] [uniqueidentifier] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIA_Period](
	[Id] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
 CONSTRAINT [PrimaryKey_b9883b89-21e4-4520-b943-e9bf22c80405] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klass](
	[ClassName] [varchar](10) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[StudentCount] [nvarchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[LIA_Period1_Id] [int] NOT NULL,
	[LIA_Period2_Id] [int] NOT NULL,
	[StudieName] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[OngoingStudie] [bit] NULL,
 CONSTRAINT [PrimaryKey_d967edf5-f864-4dbe-b0ce-cda373010712] PRIMARY KEY CLUSTERED 
(
	[ClassName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] NOT NULL,
	[Namn] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[PersonNummer] [varchar](12) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[Adress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[PostAdress] [varchar](8) COLLATE Finnish_Swedish_CI_AS NULL,
	[PostNummer] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[Examen] [bit] NOT NULL,
	[MejlAdress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[ClassNamn] [varchar](10) COLLATE Finnish_Swedish_CI_AS NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Absence](
	[Student_Id] [int] NOT NULL,
	[Absence] [nvarchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[LIA_Period] [int] NOT NULL,
 CONSTRAINT [PrimaryKey_7e1ebce5-4544-4c62-8cd9-84bf6c91d0e2] PRIMARY KEY CLUSTERED 
(
	[Student_Id] ASC,
	[StartDate] ASC,
	[LIA_Period] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Företag](
	[Företag] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[Adress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[Telefon] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[PostAdress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[PostNummer] [varchar](10) COLLATE Finnish_Swedish_CI_AS NULL,
 CONSTRAINT [PK_Företag] PRIMARY KEY CLUSTERED 
(
	[Företag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KontaktPerson](
	[Id] [int] NOT NULL,
	[Namn] [nvarchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[Telefon] [nvarchar](15) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[MejlAdress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[Företag] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
 CONSTRAINT [PrimaryKey_169983f4-516e-4f85-9697-464750183499] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[P_Id] [int] NOT NULL,
	[PNamn] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[Telefon] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
	[MejlAdress] [varchar](50) COLLATE Finnish_Swedish_CI_AS NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[P_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalVisits](
	[Visit_Id] [int] NOT NULL,
	[P_Id] [int] NOT NULL,
	[VisitDate] [date] NOT NULL,
	[Visit_Done] [bit] NULL,
 CONSTRAINT [PrimaryKey_6c1d6b88-7fbc-420b-bf4b-0319eb26806c] PRIMARY KEY CLUSTERED 
(
	[Visit_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LIA](
	[LIA_Period] [int] NOT NULL,
	[Student_Id] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[Company] [varchar](50) COLLATE Finnish_Swedish_CI_AS NOT NULL,
	[Visit_Id] [int] NULL,
 CONSTRAINT [PrimaryKey_731c4027-197f-4a74-91c3-9cc3886caa54] PRIMARY KEY CLUSTERED 
(
	[LIA_Period] ASC,
	[Student_Id] ASC,
	[Company] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
ALTER TABLE [dbo].[Klass]  WITH CHECK ADD  CONSTRAINT [FK_Klass_0] FOREIGN KEY([LIA_Period1_Id])
REFERENCES [dbo].[LIA_Period] ([Id])
GO
ALTER TABLE [dbo].[Klass] CHECK CONSTRAINT [FK_Klass_0]
GO
ALTER TABLE [dbo].[Klass]  WITH CHECK ADD  CONSTRAINT [FK_Klass_1] FOREIGN KEY([LIA_Period2_Id])
REFERENCES [dbo].[LIA_Period] ([Id])
GO
ALTER TABLE [dbo].[Klass] CHECK CONSTRAINT [FK_Klass_1]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_0] FOREIGN KEY([ClassNamn])
REFERENCES [dbo].[Klass] ([ClassName])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_0]
GO
ALTER TABLE [dbo].[Absence]  WITH CHECK ADD  CONSTRAINT [FK_SjukFrånvaro_0] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[Absence] CHECK CONSTRAINT [FK_SjukFrånvaro_0]
GO
ALTER TABLE [dbo].[Absence]  WITH CHECK ADD  CONSTRAINT [FK_SjukFrånvaro_1] FOREIGN KEY([LIA_Period])
REFERENCES [dbo].[LIA_Period] ([Id])
GO
ALTER TABLE [dbo].[Absence] CHECK CONSTRAINT [FK_SjukFrånvaro_1]
GO
ALTER TABLE [dbo].[KontaktPerson]  WITH CHECK ADD  CONSTRAINT [FK_KontaktPerson_0] FOREIGN KEY([Företag])
REFERENCES [dbo].[Företag] ([Företag])
GO
ALTER TABLE [dbo].[KontaktPerson] CHECK CONSTRAINT [FK_KontaktPerson_0]
GO
ALTER TABLE [dbo].[PersonalVisits]  WITH CHECK ADD  CONSTRAINT [FK_Personal_Besök_0] FOREIGN KEY([P_Id])
REFERENCES [dbo].[Personal] ([P_Id])
GO
ALTER TABLE [dbo].[PersonalVisits] CHECK CONSTRAINT [FK_Personal_Besök_0]
GO
ALTER TABLE [dbo].[LIA]  WITH CHECK ADD  CONSTRAINT [FK_LIA_0] FOREIGN KEY([LIA_Period])
REFERENCES [dbo].[LIA_Period] ([Id])
GO
ALTER TABLE [dbo].[LIA] CHECK CONSTRAINT [FK_LIA_0]
GO
ALTER TABLE [dbo].[LIA]  WITH CHECK ADD  CONSTRAINT [FK_LIA_1] FOREIGN KEY([Student_Id])
REFERENCES [dbo].[Student] ([Id])
GO
ALTER TABLE [dbo].[LIA] CHECK CONSTRAINT [FK_LIA_1]
GO
ALTER TABLE [dbo].[LIA]  WITH CHECK ADD  CONSTRAINT [FK_LIA_2] FOREIGN KEY([Company])
REFERENCES [dbo].[Företag] ([Företag])
GO
ALTER TABLE [dbo].[LIA] CHECK CONSTRAINT [FK_LIA_2]
GO
ALTER TABLE [dbo].[LIA]  WITH CHECK ADD  CONSTRAINT [FK_LIA_3] FOREIGN KEY([Visit_Id])
REFERENCES [dbo].[PersonalVisits] ([Visit_Id])
GO
ALTER TABLE [dbo].[LIA] CHECK CONSTRAINT [FK_LIA_3]
GO
-- BCPArgs:2:[dbo].[LIA_Period] in "c:\SQLAzureMW\BCPData\dbo.LIA_Period.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:2:[dbo].[Klass] in "c:\SQLAzureMW\BCPData\dbo.Klass.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:4:[dbo].[Student] in "c:\SQLAzureMW\BCPData\dbo.Student.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:1:[dbo].[Absence] in "c:\SQLAzureMW\BCPData\dbo.Absence.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:1:[dbo].[Företag] in "c:\SQLAzureMW\BCPData\dbo.Företag.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:1:[dbo].[KontaktPerson] in "c:\SQLAzureMW\BCPData\dbo.KontaktPerson.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:2:[dbo].[Personal] in "c:\SQLAzureMW\BCPData\dbo.Personal.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:1:[dbo].[PersonalVisits] in "c:\SQLAzureMW\BCPData\dbo.PersonalVisits.dat" -E -n -C RAW -b 1000 -a 4096
GO
-- BCPArgs:1:[dbo].[LIA] in "c:\SQLAzureMW\BCPData\dbo.LIA.dat" -E -n -C RAW -b 1000 -a 4096
GO

