USE [master]
GO
/****** Object:  Database [GestionResidence]    Script Date: 24/01/2020 15:04:30 ******/
CREATE DATABASE [GestionResidence]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionResidence', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GestionResidence.mdf' , SIZE = 57344KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GestionResidence_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\GestionResidence_log.ldf' , SIZE = 1792KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GestionResidence] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionResidence].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionResidence] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionResidence] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionResidence] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionResidence] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionResidence] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionResidence] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionResidence] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GestionResidence] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionResidence] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionResidence] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionResidence] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionResidence] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionResidence] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionResidence] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionResidence] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionResidence] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionResidence] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionResidence] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionResidence] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionResidence] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionResidence] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionResidence] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionResidence] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionResidence] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionResidence] SET  MULTI_USER 
GO
ALTER DATABASE [GestionResidence] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionResidence] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionResidence] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionResidence] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GestionResidence]
GO
/****** Object:  StoredProcedure [dbo].[AssignationChambre]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AssignationChambre] 
	-- Add the parameters for the stored procedure here
	(
			@Chambre_ChambreId Int,
			@Resident_ResidentId Int,
			@PeriodeLocationDateDebut date,
			@PeriodeLocationDateFin date,
			@Formule_FormuleId Int,
			@Supplement_SupplementId Int
			)

AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

IF EXISTS (SELECT PeriodeLocationId FROM [DBO].[Location] 
WHERE Chambre_ChambreId=@Chambre_ChambreId AND (PeriodeLocationDateDebut = @PeriodeLocationDateDebut AND PeriodeLocationDateFin = @PeriodeLocationDateFin
OR @PeriodeLocationDateDebut BETWEEN PeriodeLocationDateDebut AND PeriodeLocationDateFin OR @PeriodeLocationDateDebut BETWEEN PeriodeLocationDateDebut AND PeriodeLocationDateFin))

BEGIN 
 
SELECT 1

END
ELSE

INSERT INTO [DBO].[Location] (Chambre_ChambreId, Resident_ResidentId, PeriodeLocationDateDebut, PeriodeLocationDateFin, Formule_FormuleId, Supplement_SupplementId)
VALUES (@Chambre_ChambreId, @Resident_ResidentId, @PeriodeLocationDateDebut, @PeriodeLocationDateFin, @Formule_FormuleId, @Supplement_SupplementId)
SELECT 0
END




GO
/****** Object:  StoredProcedure [dbo].[InsertResident]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertResident] 
	-- Add the parameters for the stored procedure here
	(
			@ResidentIdentifiant VarChar (16),
			@ResidentNom VarChar (30),
            @ResidentPrenom VarChar (50),
            @ResidentDateDeNaissance Date,
            @ResidentCodePostal Int,
            @ResidentVille VarChar (50),
            @ResidentTypeDeVoie VarChar (20),
            @ResidentVoie VarChar (10),
            @ResidentNumero VarChar (10),
            @ResidentTelephone VarChar (14),
            @ResidentMail VarChar (50),
			@ResidentSecu VarChar (13),
            @ResidentIban VarChar (50),
            @ResidentPhoto VarChar (100),
            @Civilite_CiviliteId Int,
            @Nationalite_NationaliteId Int
			)

AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

IF EXISTS (SELECT ResidentIdentifiant FROM [DBO].[Resident] WHERE ResidentIdentifiant=@ResidentIdentifiant)
BEGIN 
 
    -- Insert statements for procedure here
SELECT 1

END
ELSE

INSERT INTO [DBO].[Resident] (ResidentIdentifiant, ResidentNom, ResidentPrenom, ResidentDateDeNaissance, ResidentCodePostal, ResidentVille, ResidentTypeDeVoie, ResidentVoie, ResidentNumero, ResidentTelephone, ResidentMail, ResidentSecu, ResidentIban, ResidentPhoto, Civilite_CiviliteId, Nationalite_NationaliteId)
VALUES (@ResidentIdentifiant, @ResidentNom, @ResidentPrenom, @ResidentDateDeNaissance, @ResidentCodePostal, @ResidentVille, @ResidentTypeDeVoie, @ResidentVoie, @ResidentNumero, @ResidentTelephone, @ResidentMail, @ResidentSecu, @ResidentIban, @ResidentPhoto, @Civilite_CiviliteId, @Nationalite_NationaliteId)

SELECT 0
END





GO
/****** Object:  StoredProcedure [dbo].[UpdateResident]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateResident] 
	-- Add the parameters for the stored procedure here
	(	
			@ResidentId int,
			@ResidentIdentifiant VarChar (16),
			@ResidentNom VarChar (30),
            @ResidentPrenom VarChar (50),
            @ResidentDateDeNaissance Date,
            @ResidentCodePostal Int,
            @ResidentVille VarChar (50),
            @ResidentTypeDeVoie VarChar (20),
            @ResidentVoie VarChar (10),
            @ResidentNumero VarChar (10),
            @ResidentTelephone VarChar (14),
            @ResidentMail VarChar (50),
			@ResidentSecu VarChar (13),
            @ResidentIban VarChar (50),
            @ResidentPhoto VarChar (100),
            @Civilite_CiviliteId Int,
            @Nationalite_NationaliteId Int
			)

AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
-- interfering with SELECT statements.
SET NOCOUNT ON;

IF EXISTS (SELECT ResidentId FROM [DBO].[Resident] WHERE ResidentId=@ResidentId)
BEGIN
UPDATE Resident SET 


ResidentIdentifiant = @ResidentIdentifiant,
ResidentNom = @ResidentNom,
ResidentPrenom = @ResidentPrenom,
ResidentDateDeNaissance = @ResidentDateDeNaissance,
ResidentCodePostal = @ResidentCodePostal,
ResidentVille = @ResidentVille,
ResidentTypeDeVoie = @ResidentTypeDeVoie,
ResidentVoie = @ResidentVoie,
ResidentNumero = @ResidentNumero,
ResidentTelephone = @ResidentTelephone,
ResidentMail = @ResidentMail,
ResidentSecu = @ResidentSecu,
ResidentIban = @ResidentIban,
ResidentPhoto = @ResidentPhoto,
Civilite_CiviliteId = @Civilite_CiviliteId,
Nationalite_NationaliteId = @Nationalite_NationaliteId 

WHERE ResidentId=@ResidentId
   
SELECT 1

END
ELSE



SELECT 0
END






GO
/****** Object:  Table [dbo].[bano_62]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[bano_62](
	[Colonne1] [varchar](50) NULL,
	[numero] [varchar](50) NULL,
	[adresse] [varchar](50) NULL,
	[codepostal] [varchar](50) NULL,
	[ville] [varchar](50) NULL,
	[source] [varchar](50) NULL,
	[latitude] [varchar](50) NULL,
	[longitude] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Chambre]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Chambre](
	[ChambreId] [int] IDENTITY(1,1) NOT NULL,
	[ChambreIdentifiant] [varchar](50) NULL,
	[ChambreType] [varchar](20) NULL,
	[ChambreEtage] [int] NULL,
	[ChambrePrixMensuelHT] [decimal](18, 0) NULL,
	[ChambrePrixMensuelTTC] [decimal](18, 0) NULL,
	[TVA_TVAId] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Civilite]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Civilite](
	[CiviliteId] [int] IDENTITY(1,1) NOT NULL,
	[CiviliteNom] [varchar](15) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employe](
	[EmployeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeIdentifiant] [varchar](30) NOT NULL,
	[EmployeMDP] [varchar](16) NOT NULL,
	[EmployeNom] [varchar](30) NOT NULL,
	[EmployePrenom] [varchar](30) NOT NULL,
	[EmployeDateDeNaissance] [date] NOT NULL,
	[EmployeCodePostal] [int] NOT NULL,
	[EmployeVille] [varchar](30) NOT NULL,
	[EmployeTypeDeVoie] [varchar](20) NOT NULL,
	[EmployeVoie] [varchar](30) NOT NULL,
	[EmployeNumero] [varchar](10) NOT NULL,
	[EmployeTelephone] [char](14) NOT NULL,
	[EmployeMail] [varchar](50) NOT NULL,
	[Residence_ResidenceId] [int] NOT NULL,
	[Civilite_CiviliteId] [int] NOT NULL,
	[Nationalite_NationaliteId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Facture]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facture](
	[FactureId] [int] IDENTITY(1,1) NOT NULL,
	[FactureDate] [date] NOT NULL,
	[FactureTotalHT] [decimal](18, 0) NOT NULL,
	[FactureTotalTTC] [decimal](18, 0) NOT NULL,
	[TVA_TVAId] [int] NOT NULL,
	[FactureEtat] [varchar](45) NOT NULL,
	[Resident_ResidentId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Formule]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Formule](
	[FormuleId] [int] IDENTITY(1,1) NOT NULL,
	[FormuleNom] [int] NOT NULL,
	[FormuleDescriptif] [varchar](255) NOT NULL,
	[FormulePrixHT] [decimal](18, 0) NOT NULL,
	[FormulePrixTTC] [decimal](18, 0) NOT NULL,
	[TVA_TVAId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Location]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[PeriodeLocationId] [int] IDENTITY(1,1) NOT NULL,
	[Chambre_ChambreId] [int] NULL,
	[Resident_ResidentId] [int] NULL,
	[Supplement_SupplementId] [int] NULL,
	[Formule_FormuleId] [int] NULL,
	[PeriodeLocationDateDebut] [date] NULL,
	[PeriodeLocationDateFin] [date] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nationalite]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nationalite](
	[NationaliteId] [varchar](50) NULL,
	[NationaliteNom] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Residence]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Residence](
	[ResidenceId] [int] IDENTITY(1,1) NOT NULL,
	[ResidenceIdentifiant] [varchar](30) NOT NULL,
	[ResidenceNom] [varchar](30) NOT NULL,
	[ResidenceCodePostal] [int] NOT NULL,
	[ResidenceVille] [varchar](30) NOT NULL,
	[ResidenceTypeDeVoie] [varchar](20) NOT NULL,
	[ResidenceVoie] [varchar](30) NOT NULL,
	[ResidenceNumero] [varchar](10) NOT NULL,
	[ResidenceTelephone] [char](14) NOT NULL,
	[ResidenceMail] [varchar](30) NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Resident]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Resident](
	[ResidentId] [int] IDENTITY(1,1) NOT NULL,
	[ResidentIdentifiant] [varchar](30) NOT NULL,
	[ResidentNom] [varchar](50) NOT NULL,
	[ResidentPrenom] [varchar](50) NOT NULL,
	[ResidentDateDeNaissance] [date] NOT NULL,
	[ResidentCodePostal] [int] NOT NULL,
	[ResidentVille] [varchar](50) NOT NULL,
	[ResidentTypeDeVoie] [varchar](20) NOT NULL,
	[ResidentVoie] [varchar](50) NOT NULL,
	[ResidentNumero] [varchar](10) NOT NULL,
	[ResidentTelephone] [char](14) NOT NULL,
	[ResidentMail] [varchar](50) NOT NULL,
	[ResidentSecu] [varchar](13) NOT NULL,
	[ResidentIban] [varchar](50) NOT NULL,
	[ResidentPhoto] [varchar](100) NULL,
	[Residence_ResidenceId] [int] NULL,
	[Civilite_CiviliteId] [int] NOT NULL,
	[Nationalite_NationaliteId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Supplement]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Supplement](
	[SupplementId] [int] IDENTITY(1,1) NOT NULL,
	[SupplementNom] [varchar](15) NOT NULL,
	[SupplementDescriptif] [varchar](255) NOT NULL,
	[SupplementPrixHT] [decimal](18, 0) NOT NULL,
	[SupplementPrixTTC] [decimal](18, 0) NOT NULL,
	[TVA_TVAId] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TVA]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TVA](
	[TVAId] [int] IDENTITY(1,1) NOT NULL,
	[TVAMontant] [decimal](18, 0) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[VueChambres]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueChambres]
AS
SELECT dbo.Chambre.ChambreIdentifiant, dbo.Chambre.ChambreType, dbo.Chambre.ChambreEtage, dbo.Resident.ResidentIdentifiant, dbo.Resident.ResidentNom, dbo.Resident.ResidentPrenom, dbo.Location.PeriodeLocationDateDebut, 
                  dbo.Location.PeriodeLocationDateFin
FROM     dbo.Chambre LEFT OUTER JOIN
                  dbo.Location ON dbo.Chambre.ChambreId = dbo.Location.Chambre_ChambreId LEFT OUTER JOIN
                  dbo.Resident ON dbo.Location.Resident_ResidentId = dbo.Resident.ResidentId


GO
/****** Object:  View [dbo].[VueChambres2]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueChambres2]
AS
SELECT dbo.VueChambres.ChambreIdentifiant, dbo.VueChambres.ChambreType, dbo.VueChambres.ChambreEtage, dbo.VueChambres.ResidentIdentifiant, dbo.VueChambres.ResidentNom, dbo.VueChambres.ResidentPrenom, 
                  dbo.VueChambres.PeriodeLocationDateDebut, dbo.VueChambres.PeriodeLocationDateFin
FROM     dbo.VueChambres INNER JOIN
                      (SELECT ChambreIdentifiant, MIN(PeriodeLocationDateDebut) AS minDebut
                       FROM      dbo.VueChambres AS VueChambres_1
                       GROUP BY ChambreIdentifiant) AS tempTable ON tempTable.ChambreIdentifiant = dbo.VueChambres.ChambreIdentifiant
WHERE  (tempTable.minDebut = dbo.VueChambres.PeriodeLocationDateDebut) OR
                  (dbo.VueChambres.ResidentIdentifiant IS NULL)


GO
/****** Object:  View [dbo].[VueChambreArrivée]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueChambreArrivée]
AS
SELECT dbo.VueChambres.ChambreIdentifiant, dbo.VueChambres.PeriodeLocationDateDebut, dbo.VueChambres.ResidentNom, dbo.VueChambres.ResidentPrenom
FROM     dbo.VueChambres INNER JOIN
                      (SELECT ChambreIdentifiant AS Chambre, MIN(PeriodeLocationDateDebut) AS minDebut
                       FROM      dbo.VueChambres AS VueChambres_1
                       GROUP BY ChambreIdentifiant) AS tempTable ON tempTable.Chambre = dbo.VueChambres.ChambreIdentifiant
WHERE  (tempTable.minDebut = dbo.VueChambres.PeriodeLocationDateDebut) OR
                  (dbo.VueChambres.ResidentIdentifiant IS NULL)


GO
/****** Object:  View [dbo].[VueChambreDepart]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VueChambreDepart]
AS
SELECT dbo.VueChambres.PeriodeLocationDateFin, dbo.VueChambres.ResidentIdentifiant, dbo.VueChambres.ResidentNom
FROM     dbo.VueChambres INNER JOIN
                      (SELECT ChambreIdentifiant AS Chambre, MIN(PeriodeLocationDateFin) AS minFin
                       FROM      dbo.VueChambres AS VueChambres_1
                       GROUP BY ChambreIdentifiant) AS tempTable ON tempTable.Chambre = dbo.VueChambres.ChambreIdentifiant
WHERE  (tempTable.minFin = dbo.VueChambres.PeriodeLocationDateFin) OR
                  (dbo.VueChambres.ResidentIdentifiant IS NULL)


GO
/****** Object:  View [dbo].[ViewResident]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewResident]
AS
SELECT ResidentId, ResidentIdentifiant + ' ' + ResidentNom + '  ' + ResidentPrenom AS identite
FROM     dbo.Resident


GO
/****** Object:  View [dbo].[VueClients]    Script Date: 24/01/2020 15:04:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VueClients]
AS
SELECT dbo.Resident.ResidentIdentifiant, dbo.Resident.ResidentNom, dbo.Resident.ResidentPrenom, dbo.Chambre.ChambreIdentifiant, dbo.Formule.FormuleDescriptif, dbo.Location.PeriodeLocationDateDebut, 
                  dbo.Location.PeriodeLocationDateFin
FROM     dbo.Resident LEFT OUTER JOIN
                  dbo.Location ON dbo.Resident.ResidentId = dbo.Location.Resident_ResidentId LEFT OUTER JOIN
                  dbo.Chambre ON dbo.Location.Chambre_ChambreId = dbo.Chambre.ChambreId LEFT OUTER JOIN
                  dbo.Formule ON dbo.Location.Formule_FormuleId = dbo.Formule.FormuleId



GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Resident"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 317
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 5628
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewResident'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewResident'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VueChambres"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 324
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "tempTable"
            Begin Extent = 
               Top = 7
               Left = 372
               Bottom = 126
               Right = 616
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2100
         Width = 2484
         Width = 2592
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambreArrivée'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambreArrivée'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VueChambres"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 324
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tempTable"
            Begin Extent = 
               Top = 7
               Left = 372
               Bottom = 126
               Right = 616
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambreDepart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambreDepart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Chambre"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 307
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Location"
            Begin Extent = 
               Top = 7
               Left = 355
               Bottom = 282
               Right = 631
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Resident"
            Begin Extent = 
               Top = 7
               Left = 679
               Bottom = 170
               Right = 948
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambres'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[23] 4[3] 2[29] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VueChambres"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 324
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tempTable"
            Begin Extent = 
               Top = 7
               Left = 372
               Bottom = 126
               Right = 616
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 2652
         Width = 2628
         Width = 1584
         Width = 1776
         Width = 1608
         Width = 1608
         Width = 1668
         Width = 1644
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambres2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueChambres2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[11] 2[19] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Chambre"
            Begin Extent = 
               Top = 15
               Left = 782
               Bottom = 248
               Right = 1041
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Location"
            Begin Extent = 
               Top = 29
               Left = 367
               Bottom = 276
               Right = 643
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Resident"
            Begin Extent = 
               Top = 22
               Left = 28
               Bottom = 292
               Right = 297
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Formule"
            Begin Extent = 
               Top = 317
               Left = 792
               Bottom = 480
               Right = 1036
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1272
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueClients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'nd
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueClients'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VueClients'
GO
USE [master]
GO
ALTER DATABASE [GestionResidence] SET  READ_WRITE 
GO
