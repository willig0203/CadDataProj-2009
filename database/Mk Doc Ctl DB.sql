if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E001PIN_DelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E001PIN_DelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E001PIN_InsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E001PIN_InsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E001PIN_SelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E001PIN_SelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E001PIN_UpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E001PIN_UpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045SubTblDelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E045SubTblDelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045SubTblInsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E045SubTblInsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045SubTblSelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E045SubTblSelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045SubTblUpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E045SubTblUpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046CpyReqDelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046CpyReqDelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046CpyReqInsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046CpyReqInsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046CpyReqSelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046CpyReqSelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046CpyReqUpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046CpyReqUpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046SubTblDelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046SubTblDelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046SubTblInsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046SubTblInsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046SubTblSelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046SubTblSelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046SubTblUpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[E046SubTblUpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RevTxtDelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[RevTxtDelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RevTxtInsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[RevTxtInsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RevTxtSelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[RevTxtSelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RevTxtUpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[RevTxtUpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TrkBlksDelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[TrkBlksDelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TrkBlksInsCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[TrkBlksInsCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TrkBlksSelCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[TrkBlksSelCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TrkBlksUpdCmd]') and OBJECTPROPERTY(id, N'IsProcedure') = 1)
drop procedure [dbo].[TrkBlksUpdCmd]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Customers]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Customers]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DocumentReleasePhase]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DocumentReleasePhase]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[DocumentReleasePriority]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[DocumentReleasePriority]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E001ProductIntroductionNotice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E001ProductIntroductionNotice]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E002CBDSubTable]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E002CBDSubTable]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E002ConfigurationBaselineDocument]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E002ConfigurationBaselineDocument]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E003AsBltSubTbl]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E003AsBltSubTbl]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E003AsBuiltConfigurationRecord]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E003AsBuiltConfigurationRecord]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E023PartNumberRequest]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E023PartNumberRequest]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E024ItemMasterInput]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E024ItemMasterInput]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E025BillofMaterialInput]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E025BillofMaterialInput]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E025BillofMaterialInputSubTable]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E025BillofMaterialInputSubTable]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E026WhereUsedInput]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E026WhereUsedInput]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E028ComponentPartRequest]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E028ComponentPartRequest]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E029DeliverableDocumentationChecklist]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E029DeliverableDocumentationChecklist]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E037EngineeringChange]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E037EngineeringChange]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E039PrototypeReport]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E039PrototypeReport]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E040BillofMaterialChange]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E040BillofMaterialChange]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E041DocumentChangeNotice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E041DocumentChangeNotice]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E042SpecificationChangeNotice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E042SpecificationChangeNotice]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E043EquivalentItemAuthorizations]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E043EquivalentItemAuthorizations]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E044DocumentReleaseNotice]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E044DocumentReleaseNotice]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E044ReleasedDocuments]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E044ReleasedDocuments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045EngineeringChangePartNumberInput]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E045EngineeringChangePartNumberInput]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E045SubTable]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E045SubTable]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046CopyRequest]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E046CopyRequest]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[E046SubTable]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[E046SubTable]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Employees]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Employees]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[OrderDetails]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[OrderDetails]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Orders]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Orders]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Products]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Products]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProjectClassifications]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProjectClassifications]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProjectDepartments]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProjectDepartments]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProjectIs]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProjectIs]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ProjectTypes]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ProjectTypes]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[RevisionsText]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[RevisionsText]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TimeBilled]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TimeBilled]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TrackingBlockNames]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TrackingBlockNames]
GO

CREATE TABLE [dbo].[Customers] (
	[CustomerID] [int] NOT NULL ,
	[CompanyName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ContactFirstName] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[ContactLastName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CompanyOrDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[BillingAddress] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL ,
	[City] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[StateOrProvince] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL ,
	[PostalCode] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL ,
	[CountryRegion] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ContactTitle] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PhoneNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[Extension] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[FaxNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[EmailAddress] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Notes] [ntext] COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[DocumentReleasePhase] (
	[ID] [int] NOT NULL ,
	[DocumentReleasePhase] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[DocumentReleasePriority] (
	[ID] [int] NOT NULL ,
	[DocumentReleasePriority] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E001ProductIntroductionNotice] (
	[ProjectNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[EngineeringManager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringManagerDate] [smalldatetime] NULL ,
	[Product] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProjectTitle] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[ProjectIs] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProjectClassification] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SpecifyOtherProjectClassification] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[ProjectDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProjectType] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurposeOfProject] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[ProdIntrNoticeNumID] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E002CBDSubTable] (
	[CBDRecId] [int] NOT NULL ,
	[CBDNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[IndentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Quantity] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[TraceabilityCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Revision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E002ConfigurationBaselineDocument] (
	[CBDNumber] [int] NOT NULL ,
	[CDBRevision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CDBDate] [smalldatetime] NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[Customer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CustomerDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E003AsBltSubTbl] (
	[ABCRecId] [int] NOT NULL ,
	[ABCRNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[IndentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Quantity] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AsDesignedAsBuiltDifferences] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E003AsBuiltConfigurationRecord] (
	[ABCRNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ABCRRevision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ABCRDate] [smalldatetime] NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[Manufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturingDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E023PartNumberRequest] (
	[PartNumberRequestNumber] [int] NOT NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[EngineeringManager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringManagerDate] [smalldatetime] NULL ,
	[PartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturesPartNumberIfApplicable] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E024ItemMasterInput] (
	[ItemMasterInputNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[EngineeringPartNumber] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringDashNumber] [nvarchar] (5) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringRevisionCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringDescription] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringUnitofMeasure] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringProductCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringEngineeringChangeNumberAndDate] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[InventoryControlSourceCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[InventoryControlSpareCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[InventoryControlPlanningCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[InventoryControlOrderQuantity] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[InventoryControlABCCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProductionControlManufacturingLeadTime] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProductionControlYieldPercent] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProductionControlShrinkageFactor] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProductionControlForcastedUsage] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurchasingCommodityCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurchasingPurchasingLeadTime] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurchasingBuyerCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AccountingLaborHours] [int] NULL ,
	[AccountingMaterialCost] [money] NULL ,
	[AccountingVendorCost] [money] NULL ,
	[SignatureEngineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SignatureDateEngineering] [smalldatetime] NULL ,
	[SignatureManufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SignatureDateManufacturing] [smalldatetime] NULL ,
	[SignaturePurchasing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SignatureDatePurchasing] [smalldatetime] NULL ,
	[SignatureQuality] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SignatureDateQuality] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E025BillofMaterialInput] (
	[BillofMaterialInputNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[ParentPartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ParentAassemblyName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DataEntryCode] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[NextHigherAssembly] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AuthorizationsEngineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AuthorizationsEngineeringDate] [smalldatetime] NULL ,
	[AuthorizationsManufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AuthorizationsManufacturingDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E025BillofMaterialInputSubTable] (
	[BillofMaterialInputNumber] [int] NULL ,
	[ItemNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[BOMItemNumber] [int] NULL ,
	[ComponentPartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[QuantityPer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EffectivityStartDate] [smalldatetime] NULL ,
	[EffectivityStartSerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EffectivityCloseDate] [smalldatetime] NULL ,
	[EffectivityCloseSerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DeletetoOperatorSequenceNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[KitLeadTimeOffset] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[IssuingStoresAccount] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E026WhereUsedInput] (
	[WhereUsedInputNumber] [int] NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[EngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OldPart] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OldPartDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[QuantityPer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[NextAssembly] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[NextAssemblyDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[TopLevelPartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Feature-Option] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ModelNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Product] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Customer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:EngineeringDate] [smalldatetime] NULL ,
	[Authorizations:Manufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:ManufacturingDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E028ComponentPartRequest] (
	[ComponentPartRequestNumber] [int] NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[CPRNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Manager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDate] [smalldatetime] NULL ,
	[WhereUsed] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ReasonforRequest] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturerName1] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturerPartNumber1] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturerName2] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManufacturerPartNumber2] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CostEstimate] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProjectNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Action] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Remarks] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorization:Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorization:EngineeringDate] [smalldatetime] NULL ,
	[DocumentControl] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentControlDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E029DeliverableDocumentationChecklist] (
	[DeliverableDocumentationChecklistNumber] [int] NOT NULL ,
	[PartName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Customer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurchaseOrderorContract] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DeliverableDocumentationChecklistDate] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ItemList?] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Remarks] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PreparedBy] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PreparedByDate] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ApprovedBy] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ApprovedByDate] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E037EngineeringChange] (
	[EngineeringChangeNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[Manager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDate] [smalldatetime] NULL ,
	[Priority] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ClassofChange] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AffectedDocuments] [int] NULL ,
	[DescriptionofChange] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations-Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations-EngineeringDate] [smalldatetime] NULL ,
	[Authorizations-Manufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations-ManufacturingDate] [smalldatetime] NULL ,
	[Authorizations-Quality] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations-QualityDate] [smalldatetime] NULL ,
	[Authorizations-Purchasing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations-PurchasingDate] [smalldatetime] NULL ,
	[RfcNewRelease] [bit] NULL ,
	[RfcDesignError] [bit] NULL ,
	[RfcDraftingError] [bit] NULL ,
	[RfcRedrawError] [bit] NULL ,
	[RfcFacilitateProduction] [bit] NULL ,
	[RfcFacilitateInspection] [bit] NULL ,
	[RfcScheduleImprovement] [bit] NULL ,
	[RfcCostImprovement] [bit] NULL ,
	[RfcCustomerDirected] [bit] NULL ,
	[RfcVendorRequested] [bit] NULL ,
	[RfcSafteyInprovement] [bit] NULL ,
	[RfcOtherExplain] [ntext] COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E039PrototypeReport] (
	[PrototypeReportNumber] [int] NOT NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[Manager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDate] [smalldatetime] NULL ,
	[ProductType] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DescriptionofPrototype] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Recommendation] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DrawingNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ConditionsofTest] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Results] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:EngineeringDate] [smalldatetime] NULL ,
	[Authorizations:Manfacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:ManfacturingDate] [smalldatetime] NULL ,
	[Authorizations:Quality] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:QualityDate] [smalldatetime] NULL ,
	[Authorizations:Purchasing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:PurchasingDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E040BillofMaterialChange] (
	[BOMChangeNumber] [int] NOT NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[Manager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDate] [smalldatetime] NULL ,
	[DescriptionofChange] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Disposition] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EffectivityDate] [smalldatetime] NULL ,
	[PartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PartName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DrawingNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Justification] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[RejectReason] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:EngineeringDate] [smalldatetime] NULL ,
	[Authorizations:Manufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:ManufacturingDate] [smalldatetime] NULL ,
	[Authorizations:Quality] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:QualityDate] [smalldatetime] NULL ,
	[Authorizations:Purchasing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:PurchasingDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E041DocumentChangeNotice] (
	[DocumentChangeNoticeNumber] [int] NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[CCBChairPerson] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CCBChairPersonDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CCBChairPersonDate] [smalldatetime] NULL ,
	[DocumentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Revision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AssociatedEngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[WASCondition] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[NowCondition] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[IncorporatedBy] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[IncorporatedDate] [smalldatetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E042SpecificationChangeNotice] (
	[SpecificationChangeNoticeNumber] [int] NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[CCBChairPerson] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CCBChairPersonDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CCBChairPersonDate] [smalldatetime] NULL ,
	[DocumentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Revision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[AssociatedEngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[WASCondition] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[NowCondition] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[IncorporatedBy] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[IncorporatedDate] [smalldatetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E043EquivalentItemAuthorizations] (
	[EIANumber] [int] NOT NULL ,
	[Originator] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[OriginatorDate] [smalldatetime] NULL ,
	[Manager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDepartment] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ManagerDate] [smalldatetime] NULL ,
	[ProgramNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DrawingNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DrawingDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DrawingRevision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ChangePartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ChangePartNumberDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ToPartNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ToPartNumberDescription] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EffectiveforSerialNumberOnly] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[orFromSerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ThroughSerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PurposeoftheSubstitution] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:Engineering] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:EngineeringDate] [smalldatetime] NULL ,
	[Authorizations:Manufacturing] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:ManufacturingDate] [smalldatetime] NULL ,
	[Authorizations:Quality] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Authorizations:QualityDate] [smalldatetime] NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E044DocumentReleaseNotice] (
	[DocumentReleaseNoticeNumberID] [int] IDENTITY (1, 1) NOT FOR REPLICATION  NOT NULL ,
	[Engineer] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineerDate] [smalldatetime] NULL ,
	[EngineeringManager] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringManagerDate] [smalldatetime] NULL ,
	[Priority] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentReleasePhase] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentControl] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ReleaseDate] [smalldatetime] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E044ReleasedDocuments] (
	[FileName] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[Layout] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[TitleBlock] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[RevisionBlock] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ControlStamp] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentReleaseNoticeNumber] [int] NOT NULL ,
	[DocumentNumberID] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E045EngineeringChangePartNumberInput] (
	[EngineeringChangePartNumberInputNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[DocumentNumber] [nvarchar] (100) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentTitle] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[NumberofSheets] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocumentSize] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[BillofMaterialSheets] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E045SubTable] (
	[EngineeringChangePartNumberInputNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DocRevision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringChangeNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PendingDate] [smalldatetime] NULL ,
	[CCBStatus] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EngineeringChangeReleaseDate] [smalldatetime] NULL ,
	[IncorporationDate] [smalldatetime] NULL ,
	[NoteComments] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[ID] [int] IDENTITY (1, 1) NOT NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[E046CopyRequest] (
	[CopyRequestNumber] [int] IDENTITY (1, 1) NOT NULL ,
	[DepartmentNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CRDate] [smalldatetime] NULL ,
	[DateRequired] [smalldatetime] NULL ,
	[PickUp] [bit] NULL ,
	[Mail] [bit] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[E046SubTable] (
	[DocumentNumber] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[Revision] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Description] [nvarchar] (250) COLLATE Latin1_General_CI_AS NULL ,
	[SheetsQty] [int] NULL ,
	[NumberofCopies] [int] NULL ,
	[DocumentNumberID] [int] IDENTITY (1, 1) NOT NULL ,
	[CopyRequestNumber] [int] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Employees] (
	[EmployeeID] [int] NOT NULL ,
	[DepartmentName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[SocialSecurityNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[EmployeeNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[NationalEmplNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[FirstName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[MiddleName] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[LastName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Title] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EmailName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Extension] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[Address] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL ,
	[City] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[StateOrProvince] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL ,
	[Region] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PostalCode] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL ,
	[Country/Region] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[HomePhone] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[WorkPhone] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[DepartmentID] [int] NULL ,
	[Birthdate] [smalldatetime] NULL ,
	[DateHired] [smalldatetime] NULL ,
	[Salary] [money] NULL ,
	[BillingRate] [money] NULL ,
	[Deductions] [smallint] NULL ,
	[SupervisorID] [int] NULL ,
	[SpouseName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EmrgcyContactName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[EmrgcyContactPhone] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[Photograph] [image] NULL ,
	[Notes] [ntext] COLLATE Latin1_General_CI_AS NULL ,
	[OfficeLocation] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[OrderDetails] (
	[OrderDetailID] [int] NOT NULL ,
	[OrderID] [int] NULL ,
	[ProductID] [int] NULL ,
	[DateSold] [smalldatetime] NULL ,
	[Quantity] [float] NULL ,
	[UnitPrice] [money] NULL ,
	[Discount] [float] NULL ,
	[SalePrice] [money] NULL ,
	[SalesTax] [money] NULL ,
	[LineTotal] [money] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Orders] (
	[OrderID] [int] NOT NULL ,
	[CustomerID] [int] NULL ,
	[EmployeeID] [int] NULL ,
	[OrderDate] [smalldatetime] NULL ,
	[PurchaseOrderNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[RequiredByDate] [smalldatetime] NULL ,
	[PromisedByDate] [smalldatetime] NULL ,
	[ShipName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ShipAddress] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL ,
	[ShipCity] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ShipState] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ShipStateOrProvince] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ShipPostalCode] [nvarchar] (20) COLLATE Latin1_General_CI_AS NULL ,
	[ShipCountry] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ShipPhoneNumber] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL ,
	[ShipDate] [smalldatetime] NULL ,
	[ShippingMethodID] [int] NULL ,
	[FreightCharge] [money] NULL ,
	[SalesTaxRate] [float] NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[Products] (
	[ProductID] [int] NOT NULL ,
	[ProductName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ProductDescription] [nvarchar] (255) COLLATE Latin1_General_CI_AS NULL ,
	[CategoryID] [int] NULL ,
	[SupplierID] [int] NULL ,
	[SerialNumber] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[UnitsInStock] [int] NULL ,
	[UnitsOnOrder] [int] NULL ,
	[UnitPrice] [money] NULL ,
	[ReorderLevel] [int] NULL ,
	[Discontinued] [bit] NOT NULL ,
	[LeadTime] [nvarchar] (30) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProjectClassifications] (
	[ID] [int] NOT NULL ,
	[ProjectClassifications] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProjectDepartments] (
	[ID] [int] NOT NULL ,
	[ProjectDepartments] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProjectIs] (
	[ID] [int] NOT NULL ,
	[ProjectIs] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[ExistingNumberIfCurrent] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[ProjectTypes] (
	[ID] [int] NOT NULL ,
	[ProjectTypes] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[RevisionsText] (
	[ID] [int] IDENTITY (1, 1) NOT NULL ,
	[RevisionText] [char] (250) COLLATE Latin1_General_CI_AS NOT NULL 
) ON [PRIMARY]
GO

CREATE TABLE [dbo].[TimeBilled] (
	[TimeBilledID] [int] NOT NULL ,
	[CustomerID] [int] NULL ,
	[ProjectID] [int] NULL ,
	[EmployeeID] [int] NULL ,
	[BillingDate] [smalldatetime] NULL ,
	[HourlyRate] [money] NULL ,
	[BillableHours] [float] NULL ,
	[Notes] [ntext] COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[TrackingBlockNames] (
	[BlockName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Type] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PlotSettingsName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CurrentStyleSheet] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PlotConfigurationName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[CanonicalMediaName] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[PlotCentered] [bit] NULL ,
	[PlotRotation] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[Plotscale] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[BlockID] [int] IDENTITY (1, 1) NOT NULL ,
	[DescAtt1] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DescAtt2] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[DescAtt3] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL ,
	[RevAtt1] [nvarchar] (50) COLLATE Latin1_General_CI_AS NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[E001ProductIntroductionNotice] WITH NOCHECK ADD 
	CONSTRAINT [PK_E001ProductIntroductionNotice] PRIMARY KEY  CLUSTERED 
	(
		[ProdIntrNoticeNumID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E024ItemMasterInput] WITH NOCHECK ADD 
	CONSTRAINT [PK_E024ItemMasterInput] PRIMARY KEY  CLUSTERED 
	(
		[ItemMasterInputNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E025BillofMaterialInput] WITH NOCHECK ADD 
	CONSTRAINT [PK_E025BillofMaterialInput] PRIMARY KEY  CLUSTERED 
	(
		[BillofMaterialInputNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E025BillofMaterialInputSubTable] WITH NOCHECK ADD 
	CONSTRAINT [PK_E025BillofMaterialInputSubTable] PRIMARY KEY  CLUSTERED 
	(
		[ItemNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E037EngineeringChange] WITH NOCHECK ADD 
	CONSTRAINT [PK_E037EngineeringChange] PRIMARY KEY  CLUSTERED 
	(
		[EngineeringChangeNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E044DocumentReleaseNotice] WITH NOCHECK ADD 
	CONSTRAINT [PK_E044DocumentReleaseNotice] PRIMARY KEY  CLUSTERED 
	(
		[DocumentReleaseNoticeNumberID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E044ReleasedDocuments] WITH NOCHECK ADD 
	CONSTRAINT [PK_E044ReleasedDocuments] PRIMARY KEY  CLUSTERED 
	(
		[DocumentNumberID] DESC 
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E045EngineeringChangePartNumberInput] WITH NOCHECK ADD 
	CONSTRAINT [PK_E045EngineeringChangePartNumberInput] PRIMARY KEY  CLUSTERED 
	(
		[EngineeringChangePartNumberInputNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E045SubTable] WITH NOCHECK ADD 
	CONSTRAINT [PK_E045SubTable] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E046CopyRequest] WITH NOCHECK ADD 
	CONSTRAINT [PK_E046CopyRequest] PRIMARY KEY  CLUSTERED 
	(
		[CopyRequestNumber]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[E046SubTable] WITH NOCHECK ADD 
	CONSTRAINT [PK_E046SubTable] PRIMARY KEY  CLUSTERED 
	(
		[DocumentNumberID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[RevisionsText] WITH NOCHECK ADD 
	CONSTRAINT [PK_RevisionsText] PRIMARY KEY  CLUSTERED 
	(
		[ID]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TrackingBlockNames] WITH NOCHECK ADD 
	CONSTRAINT [PK_TrackingBlockNames] PRIMARY KEY  CLUSTERED 
	(
		[BlockID]
	)  ON [PRIMARY] 
GO

 CREATE  INDEX [IX_E044DocumentReleaseNotice] ON [dbo].[E044DocumentReleaseNotice]([DocumentReleaseNoticeNumberID] DESC ) ON [PRIMARY]
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E001PIN_DelCmd
(
	@Original_ProdIntrNoticeNumID int,
	@Original_Engineer nvarchar(50),
	@Original_EngineerDate smalldatetime,
	@Original_EngineeringManager nvarchar(50),
	@Original_EngineeringManagerDate smalldatetime,
	@Original_Product nvarchar(50),
	@Original_ProjectClassification nvarchar(50),
	@Original_ProjectDepartment nvarchar(50),
	@Original_ProjectIs nvarchar(50),
	@Original_ProjectNumber nvarchar(50),
	@Original_ProjectType nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM E001ProductIntroductionNotice WHERE (ProdIntrNoticeNumID = @Original_ProdIntrNoticeNumID) AND (Engineer = @Original_Engineer OR @Original_Engineer IS NULL AND Engineer IS NULL) AND (EngineerDate = @Original_EngineerDate OR @Original_EngineerDate IS NULL AND EngineerDate IS NULL) AND (EngineeringManager = @Original_EngineeringManager OR @Original_EngineeringManager IS NULL AND EngineeringManager IS NULL) AND (EngineeringManagerDate = @Original_EngineeringManagerDate OR @Original_EngineeringManagerDate IS NULL AND EngineeringManagerDate IS NULL) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (ProjectClassification = @Original_ProjectClassification OR @Original_ProjectClassification IS NULL AND ProjectClassification IS NULL) AND (ProjectDepartment = @Original_ProjectDepartment OR @Original_ProjectDepartment IS NULL AND ProjectDepartment IS NULL) AND (ProjectIs = @Original_ProjectIs OR @Original_ProjectIs IS NULL AND ProjectIs IS NULL) AND (ProjectNumber = @Original_ProjectNumber OR @Original_ProjectNumber IS NULL AND ProjectNumber IS NULL) AND (ProjectType = @Original_ProjectType OR @Original_ProjectType IS NULL AND ProjectType IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E001PIN_InsCmd
(
	@ProjectNumber nvarchar(50),
	@Engineer nvarchar(50),
	@EngineerDate smalldatetime,
	@EngineeringManager nvarchar(50),
	@EngineeringManagerDate smalldatetime,
	@Product nvarchar(50),
	@ProjectTitle ntext,
	@ProjectIs nvarchar(50),
	@ProjectClassification nvarchar(50),
	@SpecifyOtherProjectClassification ntext,
	@ProjectDepartment nvarchar(50),
	@ProjectType nvarchar(50),
	@PurposeOfProject ntext
)
AS
	SET NOCOUNT OFF;
INSERT INTO E001ProductIntroductionNotice(ProjectNumber, Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, Product, ProjectTitle, ProjectIs, ProjectClassification, SpecifyOtherProjectClassification, ProjectDepartment, ProjectType, PurposeOfProject) VALUES (@ProjectNumber, @Engineer, @EngineerDate, @EngineeringManager, @EngineeringManagerDate, @Product, @ProjectTitle, @ProjectIs, @ProjectClassification, @SpecifyOtherProjectClassification, @ProjectDepartment, @ProjectType, @PurposeOfProject);
	SELECT ProjectNumber, Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, Product, ProjectTitle, ProjectIs, ProjectClassification, SpecifyOtherProjectClassification, ProjectDepartment, ProjectType, PurposeOfProject, ProdIntrNoticeNumID FROM E001ProductIntroductionNotice WHERE (ProdIntrNoticeNumID = @@IDENTITY)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E001PIN_SelCmd
AS
	SET NOCOUNT ON;
SELECT ProjectNumber, Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, Product, ProjectTitle, ProjectIs, ProjectClassification, SpecifyOtherProjectClassification, ProjectDepartment, ProjectType, PurposeOfProject, ProdIntrNoticeNumID FROM E001ProductIntroductionNotice
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E001PIN_UpdCmd
(
	@ProjectNumber nvarchar(50),
	@Engineer nvarchar(50),
	@EngineerDate smalldatetime,
	@EngineeringManager nvarchar(50),
	@EngineeringManagerDate smalldatetime,
	@Product nvarchar(50),
	@ProjectTitle ntext,
	@ProjectIs nvarchar(50),
	@ProjectClassification nvarchar(50),
	@SpecifyOtherProjectClassification ntext,
	@ProjectDepartment nvarchar(50),
	@ProjectType nvarchar(50),
	@PurposeOfProject ntext,
	@Original_ProdIntrNoticeNumID int,
	@Original_Engineer nvarchar(50),
	@Original_EngineerDate smalldatetime,
	@Original_EngineeringManager nvarchar(50),
	@Original_EngineeringManagerDate smalldatetime,
	@Original_Product nvarchar(50),
	@Original_ProjectClassification nvarchar(50),
	@Original_ProjectDepartment nvarchar(50),
	@Original_ProjectIs nvarchar(50),
	@Original_ProjectNumber nvarchar(50),
	@Original_ProjectType nvarchar(50),
	@ProdIntrNoticeNumID int
)
AS
	SET NOCOUNT OFF;
UPDATE E001ProductIntroductionNotice SET ProjectNumber = @ProjectNumber, Engineer = @Engineer, EngineerDate = @EngineerDate, EngineeringManager = @EngineeringManager, EngineeringManagerDate = @EngineeringManagerDate, Product = @Product, ProjectTitle = @ProjectTitle, ProjectIs = @ProjectIs, ProjectClassification = @ProjectClassification, SpecifyOtherProjectClassification = @SpecifyOtherProjectClassification, ProjectDepartment = @ProjectDepartment, ProjectType = @ProjectType, PurposeOfProject = @PurposeOfProject WHERE (ProdIntrNoticeNumID = @Original_ProdIntrNoticeNumID) AND (Engineer = @Original_Engineer OR @Original_Engineer IS NULL AND Engineer IS NULL) AND (EngineerDate = @Original_EngineerDate OR @Original_EngineerDate IS NULL AND EngineerDate IS NULL) AND (EngineeringManager = @Original_EngineeringManager OR @Original_EngineeringManager IS NULL AND EngineeringManager IS NULL) AND (EngineeringManagerDate = @Original_EngineeringManagerDate OR @Original_EngineeringManagerDate IS NULL AND EngineeringManagerDate IS NULL) AND (Product = @Original_Product OR @Original_Product IS NULL AND Product IS NULL) AND (ProjectClassification = @Original_ProjectClassification OR @Original_ProjectClassification IS NULL AND ProjectClassification IS NULL) AND (ProjectDepartment = @Original_ProjectDepartment OR @Original_ProjectDepartment IS NULL AND ProjectDepartment IS NULL) AND (ProjectIs = @Original_ProjectIs OR @Original_ProjectIs IS NULL AND ProjectIs IS NULL) AND (ProjectNumber = @Original_ProjectNumber OR @Original_ProjectNumber IS NULL AND ProjectNumber IS NULL) AND (ProjectType = @Original_ProjectType OR @Original_ProjectType IS NULL AND ProjectType IS NULL);
	SELECT ProjectNumber, Engineer, EngineerDate, EngineeringManager, EngineeringManagerDate, Product, ProjectTitle, ProjectIs, ProjectClassification, SpecifyOtherProjectClassification, ProjectDepartment, ProjectType, PurposeOfProject, ProdIntrNoticeNumID FROM E001ProductIntroductionNotice WHERE (ProdIntrNoticeNumID = @ProdIntrNoticeNumID)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E045SubTblDelCmd
(
	@Original_ID int,
	@Original_CCBStatus nvarchar(50),
	@Original_DocRevision nvarchar(50),
	@Original_EngineeringChangeNumber nvarchar(50),
	@Original_EngineeringChangePartNumberInputNumber nvarchar(50),
	@Original_EngineeringChangeReleaseDate smalldatetime,
	@Original_IncorporationDate smalldatetime,
	@Original_PendingDate smalldatetime
)
AS
	SET NOCOUNT OFF;
DELETE FROM E045SubTable WHERE (ID = @Original_ID) AND (CCBStatus = @Original_CCBStatus OR @Original_CCBStatus IS NULL AND CCBStatus IS NULL) AND (DocRevision = @Original_DocRevision OR @Original_DocRevision IS NULL AND DocRevision IS NULL) AND (EngineeringChangeNumber = @Original_EngineeringChangeNumber OR @Original_EngineeringChangeNumber IS NULL AND EngineeringChangeNumber IS NULL) AND (EngineeringChangePartNumberInputNumber = @Original_EngineeringChangePartNumberInputNumber OR @Original_EngineeringChangePartNumberInputNumber IS NULL AND EngineeringChangePartNumberInputNumber IS NULL) AND (EngineeringChangeReleaseDate = @Original_EngineeringChangeReleaseDate OR @Original_EngineeringChangeReleaseDate IS NULL AND EngineeringChangeReleaseDate IS NULL) AND (IncorporationDate = @Original_IncorporationDate OR @Original_IncorporationDate IS NULL AND IncorporationDate IS NULL) AND (PendingDate = @Original_PendingDate OR @Original_PendingDate IS NULL AND PendingDate IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E045SubTblInsCmd
(
	@EngineeringChangePartNumberInputNumber nvarchar(50),
	@DocRevision nvarchar(50),
	@EngineeringChangeNumber nvarchar(50),
	@PendingDate smalldatetime,
	@CCBStatus nvarchar(50),
	@EngineeringChangeReleaseDate smalldatetime,
	@IncorporationDate smalldatetime,
	@NoteComments ntext
)
AS
	SET NOCOUNT OFF;
INSERT INTO E045SubTable(EngineeringChangePartNumberInputNumber, DocRevision, EngineeringChangeNumber, PendingDate, CCBStatus, EngineeringChangeReleaseDate, IncorporationDate, NoteComments) VALUES (@EngineeringChangePartNumberInputNumber, @DocRevision, @EngineeringChangeNumber, @PendingDate, @CCBStatus, @EngineeringChangeReleaseDate, @IncorporationDate, @NoteComments);
	SELECT EngineeringChangePartNumberInputNumber, DocRevision, EngineeringChangeNumber, PendingDate, CCBStatus, EngineeringChangeReleaseDate, IncorporationDate, NoteComments, ID FROM E045SubTable WHERE (ID = @@IDENTITY)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E045SubTblSelCmd
AS
	SET NOCOUNT ON;
SELECT EngineeringChangePartNumberInputNumber, DocRevision, EngineeringChangeNumber, PendingDate, CCBStatus, EngineeringChangeReleaseDate, IncorporationDate, NoteComments, ID FROM E045SubTable
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E045SubTblUpdCmd
(
	@EngineeringChangePartNumberInputNumber nvarchar(50),
	@DocRevision nvarchar(50),
	@EngineeringChangeNumber nvarchar(50),
	@PendingDate smalldatetime,
	@CCBStatus nvarchar(50),
	@EngineeringChangeReleaseDate smalldatetime,
	@IncorporationDate smalldatetime,
	@NoteComments ntext,
	@Original_ID int,
	@Original_CCBStatus nvarchar(50),
	@Original_DocRevision nvarchar(50),
	@Original_EngineeringChangeNumber nvarchar(50),
	@Original_EngineeringChangePartNumberInputNumber nvarchar(50),
	@Original_EngineeringChangeReleaseDate smalldatetime,
	@Original_IncorporationDate smalldatetime,
	@Original_PendingDate smalldatetime,
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE E045SubTable SET EngineeringChangePartNumberInputNumber = @EngineeringChangePartNumberInputNumber, DocRevision = @DocRevision, EngineeringChangeNumber = @EngineeringChangeNumber, PendingDate = @PendingDate, CCBStatus = @CCBStatus, EngineeringChangeReleaseDate = @EngineeringChangeReleaseDate, IncorporationDate = @IncorporationDate, NoteComments = @NoteComments WHERE (ID = @Original_ID) AND (CCBStatus = @Original_CCBStatus OR @Original_CCBStatus IS NULL AND CCBStatus IS NULL) AND (DocRevision = @Original_DocRevision OR @Original_DocRevision IS NULL AND DocRevision IS NULL) AND (EngineeringChangeNumber = @Original_EngineeringChangeNumber OR @Original_EngineeringChangeNumber IS NULL AND EngineeringChangeNumber IS NULL) AND (EngineeringChangePartNumberInputNumber = @Original_EngineeringChangePartNumberInputNumber OR @Original_EngineeringChangePartNumberInputNumber IS NULL AND EngineeringChangePartNumberInputNumber IS NULL) AND (EngineeringChangeReleaseDate = @Original_EngineeringChangeReleaseDate OR @Original_EngineeringChangeReleaseDate IS NULL AND EngineeringChangeReleaseDate IS NULL) AND (IncorporationDate = @Original_IncorporationDate OR @Original_IncorporationDate IS NULL AND IncorporationDate IS NULL) AND (PendingDate = @Original_PendingDate OR @Original_PendingDate IS NULL AND PendingDate IS NULL);
	SELECT EngineeringChangePartNumberInputNumber, DocRevision, EngineeringChangeNumber, PendingDate, CCBStatus, EngineeringChangeReleaseDate, IncorporationDate, NoteComments, ID FROM E045SubTable WHERE (ID = @ID)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046CpyReqDelCmd
(
	@Original_CopyRequestNumber int,
	@Original_CRDate smalldatetime,
	@Original_DateRequired smalldatetime,
	@Original_DepartmentNumber nvarchar(50),
	@Original_Mail bit,
	@Original_PickUp bit
)
AS
	SET NOCOUNT OFF;
DELETE FROM E046CopyRequest WHERE (CopyRequestNumber = @Original_CopyRequestNumber) AND (CRDate = @Original_CRDate OR @Original_CRDate IS NULL AND CRDate IS NULL) AND (DateRequired = @Original_DateRequired OR @Original_DateRequired IS NULL AND DateRequired IS NULL) AND (DepartmentNumber = @Original_DepartmentNumber OR @Original_DepartmentNumber IS NULL AND DepartmentNumber IS NULL) AND (Mail = @Original_Mail OR @Original_Mail IS NULL AND Mail IS NULL) AND (PickUp = @Original_PickUp OR @Original_PickUp IS NULL AND PickUp IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046CpyReqInsCmd
(
	@DepartmentNumber nvarchar(50),
	@CRDate smalldatetime,
	@DateRequired smalldatetime,
	@PickUp bit,
	@Mail bit
)
AS
	SET NOCOUNT OFF;
INSERT INTO E046CopyRequest(DepartmentNumber, CRDate, DateRequired, PickUp, Mail) VALUES (@DepartmentNumber, @CRDate, @DateRequired, @PickUp, @Mail);
	SELECT CopyRequestNumber, DepartmentNumber, CRDate, DateRequired, PickUp, Mail FROM E046CopyRequest WHERE (CopyRequestNumber = @@IDENTITY) ORDER BY CopyRequestNumber DESC
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046CpyReqSelCmd
AS
	SET NOCOUNT ON;
SELECT CopyRequestNumber, DepartmentNumber, CRDate, DateRequired, PickUp, Mail FROM E046CopyRequest ORDER BY CopyRequestNumber DESC
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046CpyReqUpdCmd
(
	@DepartmentNumber nvarchar(50),
	@CRDate smalldatetime,
	@DateRequired smalldatetime,
	@PickUp bit,
	@Mail bit,
	@Original_CopyRequestNumber int,
	@Original_CRDate smalldatetime,
	@Original_DateRequired smalldatetime,
	@Original_DepartmentNumber nvarchar(50),
	@Original_Mail bit,
	@Original_PickUp bit,
	@CopyRequestNumber int
)
AS
	SET NOCOUNT OFF;
UPDATE E046CopyRequest SET DepartmentNumber = @DepartmentNumber, CRDate = @CRDate, DateRequired = @DateRequired, PickUp = @PickUp, Mail = @Mail WHERE (CopyRequestNumber = @Original_CopyRequestNumber) AND (CRDate = @Original_CRDate OR @Original_CRDate IS NULL AND CRDate IS NULL) AND (DateRequired = @Original_DateRequired OR @Original_DateRequired IS NULL AND DateRequired IS NULL) AND (DepartmentNumber = @Original_DepartmentNumber OR @Original_DepartmentNumber IS NULL AND DepartmentNumber IS NULL) AND (Mail = @Original_Mail OR @Original_Mail IS NULL AND Mail IS NULL) AND (PickUp = @Original_PickUp OR @Original_PickUp IS NULL AND PickUp IS NULL);
	SELECT CopyRequestNumber, DepartmentNumber, CRDate, DateRequired, PickUp, Mail FROM E046CopyRequest WHERE (CopyRequestNumber = @CopyRequestNumber) ORDER BY CopyRequestNumber DESC
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046SubTblDelCmd
(
	@Original_DocumentNumberID int,
	@Original_CopyRequestNumber int,
	@Original_Description nvarchar(250),
	@Original_DocumentNumber nvarchar(50),
	@Original_NumberofCopies int,
	@Original_Revision nvarchar(50),
	@Original_SheetsQty int
)
AS
	SET NOCOUNT OFF;
DELETE FROM E046SubTable WHERE (DocumentNumberID = @Original_DocumentNumberID) AND (CopyRequestNumber = @Original_CopyRequestNumber OR @Original_CopyRequestNumber IS NULL AND CopyRequestNumber IS NULL) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (DocumentNumber = @Original_DocumentNumber OR @Original_DocumentNumber IS NULL AND DocumentNumber IS NULL) AND (NumberofCopies = @Original_NumberofCopies OR @Original_NumberofCopies IS NULL AND NumberofCopies IS NULL) AND (Revision = @Original_Revision OR @Original_Revision IS NULL AND Revision IS NULL) AND (SheetsQty = @Original_SheetsQty OR @Original_SheetsQty IS NULL AND SheetsQty IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046SubTblInsCmd
(
	@DocumentNumber nvarchar(50),
	@Revision nvarchar(50),
	@Description nvarchar(250),
	@SheetsQty int,
	@NumberofCopies int,
	@CopyRequestNumber int
)
AS
	SET NOCOUNT OFF;
INSERT INTO E046SubTable(DocumentNumber, Revision, Description, SheetsQty, NumberofCopies, CopyRequestNumber) VALUES (@DocumentNumber, @Revision, @Description, @SheetsQty, @NumberofCopies, @CopyRequestNumber);
	SELECT DocumentNumber, Revision, Description, SheetsQty, NumberofCopies, DocumentNumberID, CopyRequestNumber FROM E046SubTable WHERE (DocumentNumberID = @@IDENTITY)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046SubTblSelCmd
AS
	SET NOCOUNT ON;
SELECT DocumentNumber, Revision, Description, SheetsQty, NumberofCopies, DocumentNumberID, CopyRequestNumber FROM E046SubTable
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.E046SubTblUpdCmd
(
	@DocumentNumber nvarchar(50),
	@Revision nvarchar(50),
	@Description nvarchar(250),
	@SheetsQty int,
	@NumberofCopies int,
	@CopyRequestNumber int,
	@Original_DocumentNumberID int,
	@Original_CopyRequestNumber int,
	@Original_Description nvarchar(250),
	@Original_DocumentNumber nvarchar(50),
	@Original_NumberofCopies int,
	@Original_Revision nvarchar(50),
	@Original_SheetsQty int,
	@DocumentNumberID int
)
AS
	SET NOCOUNT OFF;
UPDATE E046SubTable SET DocumentNumber = @DocumentNumber, Revision = @Revision, Description = @Description, SheetsQty = @SheetsQty, NumberofCopies = @NumberofCopies, CopyRequestNumber = @CopyRequestNumber WHERE (DocumentNumberID = @Original_DocumentNumberID) AND (CopyRequestNumber = @Original_CopyRequestNumber OR @Original_CopyRequestNumber IS NULL AND CopyRequestNumber IS NULL) AND (Description = @Original_Description OR @Original_Description IS NULL AND Description IS NULL) AND (DocumentNumber = @Original_DocumentNumber OR @Original_DocumentNumber IS NULL AND DocumentNumber IS NULL) AND (NumberofCopies = @Original_NumberofCopies OR @Original_NumberofCopies IS NULL AND NumberofCopies IS NULL) AND (Revision = @Original_Revision OR @Original_Revision IS NULL AND Revision IS NULL) AND (SheetsQty = @Original_SheetsQty OR @Original_SheetsQty IS NULL AND SheetsQty IS NULL);
	SELECT DocumentNumber, Revision, Description, SheetsQty, NumberofCopies, DocumentNumberID, CopyRequestNumber FROM E046SubTable WHERE (DocumentNumberID = @DocumentNumberID)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.RevTxtDelCmd
(
	@Original_ID int,
	@Original_RevisionText char(250)
)
AS
	SET NOCOUNT OFF;
DELETE FROM RevisionsText WHERE (ID = @Original_ID) AND (RevisionText = @Original_RevisionText)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.RevTxtInsCmd
(
	@RevisionText char(250)
)
AS
	SET NOCOUNT OFF;
INSERT INTO RevisionsText(RevisionText) VALUES (@RevisionText);
	SELECT ID, RevisionText FROM RevisionsText WHERE (ID = @@IDENTITY)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.RevTxtSelCmd
AS
	SET NOCOUNT ON;
SELECT ID, RevisionText FROM RevisionsText
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.RevTxtUpdCmd
(
	@RevisionText char(250),
	@Original_ID int,
	@Original_RevisionText char(250),
	@ID int
)
AS
	SET NOCOUNT OFF;
UPDATE RevisionsText SET RevisionText = @RevisionText WHERE (ID = @Original_ID) AND (RevisionText = @Original_RevisionText);
	SELECT ID, RevisionText FROM RevisionsText WHERE (ID = @ID)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.TrkBlksDelCmd
(
	@Original_BlockID int,
	@Original_BlockName nvarchar(50),
	@Original_CanonicalMediaName nvarchar(50),
	@Original_CurrentStyleSheet nvarchar(50),
	@Original_DescAtt1 nvarchar(50),
	@Original_DescAtt2 nvarchar(50),
	@Original_DescAtt3 nvarchar(50),
	@Original_PlotCentered bit,
	@Original_PlotConfigurationName nvarchar(50),
	@Original_PlotRotation nvarchar(50),
	@Original_PlotSettingsName nvarchar(50),
	@Original_Plotscale nvarchar(50),
	@Original_RevAtt1 nvarchar(50),
	@Original_Type nvarchar(50)
)
AS
	SET NOCOUNT OFF;
DELETE FROM TrackingBlockNames WHERE (BlockID = @Original_BlockID) AND (BlockName = @Original_BlockName OR @Original_BlockName IS NULL AND BlockName IS NULL) AND (CanonicalMediaName = @Original_CanonicalMediaName OR @Original_CanonicalMediaName IS NULL AND CanonicalMediaName IS NULL) AND (CurrentStyleSheet = @Original_CurrentStyleSheet OR @Original_CurrentStyleSheet IS NULL AND CurrentStyleSheet IS NULL) AND (DescAtt1 = @Original_DescAtt1 OR @Original_DescAtt1 IS NULL AND DescAtt1 IS NULL) AND (DescAtt2 = @Original_DescAtt2 OR @Original_DescAtt2 IS NULL AND DescAtt2 IS NULL) AND (DescAtt3 = @Original_DescAtt3 OR @Original_DescAtt3 IS NULL AND DescAtt3 IS NULL) AND (PlotCentered = @Original_PlotCentered OR @Original_PlotCentered IS NULL AND PlotCentered IS NULL) AND (PlotConfigurationName = @Original_PlotConfigurationName OR @Original_PlotConfigurationName IS NULL AND PlotConfigurationName IS NULL) AND (PlotRotation = @Original_PlotRotation OR @Original_PlotRotation IS NULL AND PlotRotation IS NULL) AND (PlotSettingsName = @Original_PlotSettingsName OR @Original_PlotSettingsName IS NULL AND PlotSettingsName IS NULL) AND (Plotscale = @Original_Plotscale OR @Original_Plotscale IS NULL AND Plotscale IS NULL) AND (RevAtt1 = @Original_RevAtt1 OR @Original_RevAtt1 IS NULL AND RevAtt1 IS NULL) AND (Type = @Original_Type OR @Original_Type IS NULL AND Type IS NULL)
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.TrkBlksInsCmd
(
	@BlockName nvarchar(50),
	@Type nvarchar(50),
	@PlotSettingsName nvarchar(50),
	@CurrentStyleSheet nvarchar(50),
	@PlotConfigurationName nvarchar(50),
	@CanonicalMediaName nvarchar(50),
	@PlotCentered bit,
	@PlotRotation nvarchar(50),
	@Plotscale nvarchar(50),
	@DescAtt1 nvarchar(50),
	@DescAtt2 nvarchar(50),
	@DescAtt3 nvarchar(50),
	@RevAtt1 nvarchar(50)
)
AS
	SET NOCOUNT OFF;
INSERT INTO TrackingBlockNames(BlockName, Type, PlotSettingsName, CurrentStyleSheet, PlotConfigurationName, CanonicalMediaName, PlotCentered, PlotRotation, Plotscale, DescAtt1, DescAtt2, DescAtt3, RevAtt1) VALUES (@BlockName, @Type, @PlotSettingsName, @CurrentStyleSheet, @PlotConfigurationName, @CanonicalMediaName, @PlotCentered, @PlotRotation, @Plotscale, @DescAtt1, @DescAtt2, @DescAtt3, @RevAtt1);
	SELECT BlockName, Type, PlotSettingsName, CurrentStyleSheet, PlotConfigurationName, CanonicalMediaName, PlotCentered, PlotRotation, Plotscale, BlockID, DescAtt1, DescAtt2, DescAtt3, RevAtt1 FROM TrackingBlockNames WHERE (BlockID = @@IDENTITY) ORDER BY BlockName
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.TrkBlksSelCmd
AS
	SET NOCOUNT ON;
SELECT BlockName, Type, PlotSettingsName, CurrentStyleSheet, PlotConfigurationName, CanonicalMediaName, PlotCentered, PlotRotation, Plotscale, BlockID, DescAtt1, DescAtt2, DescAtt3, RevAtt1 FROM TrackingBlockNames ORDER BY BlockName
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

CREATE PROCEDURE dbo.TrkBlksUpdCmd
(
	@BlockName nvarchar(50),
	@Type nvarchar(50),
	@PlotSettingsName nvarchar(50),
	@CurrentStyleSheet nvarchar(50),
	@PlotConfigurationName nvarchar(50),
	@CanonicalMediaName nvarchar(50),
	@PlotCentered bit,
	@PlotRotation nvarchar(50),
	@Plotscale nvarchar(50),
	@DescAtt1 nvarchar(50),
	@DescAtt2 nvarchar(50),
	@DescAtt3 nvarchar(50),
	@RevAtt1 nvarchar(50),
	@Original_BlockID int,
	@Original_BlockName nvarchar(50),
	@Original_CanonicalMediaName nvarchar(50),
	@Original_CurrentStyleSheet nvarchar(50),
	@Original_DescAtt1 nvarchar(50),
	@Original_DescAtt2 nvarchar(50),
	@Original_DescAtt3 nvarchar(50),
	@Original_PlotCentered bit,
	@Original_PlotConfigurationName nvarchar(50),
	@Original_PlotRotation nvarchar(50),
	@Original_PlotSettingsName nvarchar(50),
	@Original_Plotscale nvarchar(50),
	@Original_RevAtt1 nvarchar(50),
	@Original_Type nvarchar(50),
	@BlockID int
)
AS
	SET NOCOUNT OFF;
UPDATE TrackingBlockNames SET BlockName = @BlockName, Type = @Type, PlotSettingsName = @PlotSettingsName, CurrentStyleSheet = @CurrentStyleSheet, PlotConfigurationName = @PlotConfigurationName, CanonicalMediaName = @CanonicalMediaName, PlotCentered = @PlotCentered, PlotRotation = @PlotRotation, Plotscale = @Plotscale, DescAtt1 = @DescAtt1, DescAtt2 = @DescAtt2, DescAtt3 = @DescAtt3, RevAtt1 = @RevAtt1 WHERE (BlockID = @Original_BlockID) AND (BlockName = @Original_BlockName OR @Original_BlockName IS NULL AND BlockName IS NULL) AND (CanonicalMediaName = @Original_CanonicalMediaName OR @Original_CanonicalMediaName IS NULL AND CanonicalMediaName IS NULL) AND (CurrentStyleSheet = @Original_CurrentStyleSheet OR @Original_CurrentStyleSheet IS NULL AND CurrentStyleSheet IS NULL) AND (DescAtt1 = @Original_DescAtt1 OR @Original_DescAtt1 IS NULL AND DescAtt1 IS NULL) AND (DescAtt2 = @Original_DescAtt2 OR @Original_DescAtt2 IS NULL AND DescAtt2 IS NULL) AND (DescAtt3 = @Original_DescAtt3 OR @Original_DescAtt3 IS NULL AND DescAtt3 IS NULL) AND (PlotCentered = @Original_PlotCentered OR @Original_PlotCentered IS NULL AND PlotCentered IS NULL) AND (PlotConfigurationName = @Original_PlotConfigurationName OR @Original_PlotConfigurationName IS NULL AND PlotConfigurationName IS NULL) AND (PlotRotation = @Original_PlotRotation OR @Original_PlotRotation IS NULL AND PlotRotation IS NULL) AND (PlotSettingsName = @Original_PlotSettingsName OR @Original_PlotSettingsName IS NULL AND PlotSettingsName IS NULL) AND (Plotscale = @Original_Plotscale OR @Original_Plotscale IS NULL AND Plotscale IS NULL) AND (RevAtt1 = @Original_RevAtt1 OR @Original_RevAtt1 IS NULL AND RevAtt1 IS NULL) AND (Type = @Original_Type OR @Original_Type IS NULL AND Type IS NULL);
	SELECT BlockName, Type, PlotSettingsName, CurrentStyleSheet, PlotConfigurationName, CanonicalMediaName, PlotCentered, PlotRotation, Plotscale, BlockID, DescAtt1, DescAtt2, DescAtt3, RevAtt1 FROM TrackingBlockNames WHERE (BlockID = @BlockID) ORDER BY BlockName
GO
SET QUOTED_IDENTIFIER OFF 
GO
SET ANSI_NULLS ON 
GO

