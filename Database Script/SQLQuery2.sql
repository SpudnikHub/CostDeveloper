GO
CREATE TABLE [dbo].[tblAreaCost] (
    [AreatCostID]     INT            IDENTITY (1, 1) NOT NULL,
    [TypeID]          INT            NOT NULL,
    [MaterialID]      NVARCHAR (9)   NOT NULL,
    [TotalLenght]     DECIMAL (9, 2) NULL,
    [TotalWidth]      DECIMAL (9, 2) NULL,
    [TotalCost]       MONEY          NULL,
    [PricePerMeterSQ] MONEY          NULL,
    [TotalArea]       DECIMAL (9, 2) NULL
	
GO

/****** Object:  Index [PK_tblAreaCost]    Script Date: 2016/11/02 7:26:03 PM ******/
ALTER TABLE [dbo].[tblAreaCost] ADD  CONSTRAINT [PK_tblAreaCost] PRIMARY KEY CLUSTERED 
(
	[AreatCostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
GO


);
GO
CREATE TABLE [dbo].[tblAtlanticCanvasArea] (
    [AtlanticCanvasAreaID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]           NVARCHAR (9)   NOT NULL,
    [PricePerSqrMeter]     MONEY          NULL,
    [AreaLength]           DECIMAL (9, 3) NULL,
    [AreaWidth]            DECIMAL (9, 3) NULL,
    [TotalUsedAreaCost]    MONEY          NULL
);
GO
CREATE TABLE [dbo].[tblAtlanticCanvasLength] (
    [AtlanticCanvasLenID] INT             IDENTITY (1, 1) NOT NULL,
    [MaterialID]          NVARCHAR (9)    NOT NULL,
	    [FrameID]			int		NOT NULL,
    [FrameLenght]         DECIMAL (9, 3)  NULL,
    [FrameWidth]          DECIMAL (9, 3)  NULL,
    [NoOfFrames]          DECIMAL (18, 2) NULL,
    [TotalUsedFrameCost]  MONEY           NULL,
    [FrameArea]           DECIMAL (9, 3)  NULL,
    [CanvasOverlap]       DECIMAL (9, 3)  NULL,
    [TotalCanvasArea]     DECIMAL (9, 3)  NULL,
    [TotalFrameLength]    DECIMAL (9, 3)  NULL
);
GO
CREATE TABLE [dbo].[tblAtlanticCanvasBussCost] (
    [AtlanticCanvasBussCostID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]               NVARCHAR (9)   NOT NULL,
    [RatePerHour]              MONEY          NULL,
    [HoursWorked]              DECIMAL (2, 2) NULL,
    [TotalBussinessCost]       MONEY          NULL
);
GO
CREATE TABLE [dbo].[tblAtlanticCanvasVolume] (
    [AtlanticCanvasVolumeID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]             NVARCHAR (9)   NOT NULL,
    [PricePerLiter]          MONEY          NULL,
    [LitresUsed]             DECIMAL (9, 3) NULL,
    [TotalUsedVolumeCost]    MONEY          NULL
);
GO
CREATE TABLE [dbo].[tblBussinessCost] (
    [BussinessCostID] INT          IDENTITY (1, 1) NOT NULL,
    [TypeID]          INT          NOT NULL,
    [MaterialID]      NVARCHAR (9) NOT NULL,
    [CostName]        TEXT         NULL,
    [RatePerHour]     MONEY        NULL
);
GO
CREATE TABLE [dbo].[tblLengthCost] (
    [LenghtCostID]    INT            IDENTITY (1, 1) NOT NULL,
    [TypeID]          INT            NOT NULL,
    [MaterialID]      NVARCHAR (9)   NOT NULL,
    [NoPieces]        DECIMAL (18)   NULL,
    [LengthPerPiece]  DECIMAL (9, 2) NULL,
    [TotalLength]     DECIMAL (9, 2) NULL,
    [TotalCostPieces] MONEY          NULL,
    [PricePerMeter]   MONEY          NULL
);
GO
CREATE TABLE [dbo].[tblMaterial] (
    [MaterialID]  NVARCHAR (9) NOT NULL,
    [Name]        TEXT         NOT NULL,
    [Description] TEXT         NULL,
    [TypeID]      INT          NULL
);
GO
CREATE TABLE [dbo].[tblMaterialType] (
    [TypeID]      INT           IDENTITY (1, 1) NOT NULL,
    [MeasureType] NVARCHAR (50) NOT NULL
);
GO
CREATE TABLE [dbo].[tblVolumeCost] (
    [VolumeCostID]  INT            IDENTITY (1, 1) NOT NULL,
    [TypeID]        INT            NOT NULL,
    [MaterialID]    NVARCHAR (9)   NOT NULL,
    [TotalVolume]   DECIMAL (9, 2) NULL,
    [PricePerLiter] MONEY          NULL,
    [TotalCost]     MONEY          NULL
);
SET IDENTITY_INSERT [dbo].[tblAreaCost] ON
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (1, 2, N'CAN002', CAST(15.00 AS Decimal(9, 2)), CAST(0.61 AS Decimal(9, 2)), CAST(750.0000 AS Money), CAST(81.9700 AS Money), CAST(9.15 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (2, 2, N'PHO001', CAST(30.00 AS Decimal(9, 2)), CAST(1.12 AS Decimal(9, 2)), CAST(1741.1000 AS Money), CAST(51.8200 AS Money), CAST(33.60 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (3, 2, N'GLA001', CAST(1.00 AS Decimal(9, 2)), CAST(0.80 AS Decimal(9, 2)), CAST(387.0000 AS Money), CAST(483.7500 AS Money), CAST(0.80 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (4, 2, N'MOU001', CAST(1.20 AS Decimal(9, 2)), CAST(2.40 AS Decimal(9, 2)), CAST(150.0000 AS Money), CAST(52.0800 AS Money), CAST(2.88 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (5, 2, N'HAR001', CAST(1.00 AS Decimal(9, 2)), CAST(0.80 AS Decimal(9, 2)), CAST(89.0000 AS Money), CAST(111.2500 AS Money), CAST(0.80 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (6, 2, N'PRI001', CAST(1.00 AS Decimal(9, 2)), CAST(1.00 AS Decimal(9, 2)), CAST(100.0000 AS Money), CAST(100.0000 AS Money), CAST(1.00 AS Decimal(9, 2)))
INSERT INTO [dbo].[tblAreaCost] ([AreatCostID], [TypeID], [MaterialID], [TotalLenght], [TotalWidth], [TotalCost], [PricePerMeterSQ], [TotalArea]) VALUES (7, 2, N'BRO001', CAST(1.20 AS Decimal(9, 2)), CAST(2.40 AS Decimal(9, 2)), CAST(10.0000 AS Money), CAST(3.4700 AS Money), CAST(2.88 AS Decimal(9, 2)))
SET IDENTITY_INSERT [dbo].[tblAreaCost] OFF

SET IDENTITY_INSERT [dbo].[tblBussinessCost] ON
INSERT INTO [dbo].[tblBussinessCost] ([BussinessCostID], [TypeID], [MaterialID], [CostName], [RatePerHour]) VALUES (1, 4, N'LAB001', N'Labour', CAST(83.3300 AS Money))
INSERT INTO [dbo].[tblBussinessCost] ([BussinessCostID], [TypeID], [MaterialID], [CostName], [RatePerHour]) VALUES (2, 4, N'LEA001', N'Lease', CAST(90.0000 AS Money))
SET IDENTITY_INSERT [dbo].[tblBussinessCost] OFF
SET IDENTITY_INSERT [dbo].[tblFrameType] ON
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (1, N'Square 250')
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (2, N'A2')
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (3, N'Square 450')
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (4, N'450 X 350')
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (5, N'550 X 450')
INSERT INTO [dbo].[tblFrameType] ([FrameID], [Frame Name]) VALUES (6, N'Pano')
SET IDENTITY_INSERT [dbo].[tblFrameType] OFF

SET IDENTITY_INSERT [dbo].[tblMaterialType] ON
INSERT INTO [dbo].[tblMaterialType] ([TypeID], [MeasureType]) VALUES (1, N'Length')
INSERT INTO [dbo].[tblMaterialType] ([TypeID], [MeasureType]) VALUES (2, N'Area')
INSERT INTO [dbo].[tblMaterialType] ([TypeID], [MeasureType]) VALUES (3, N'Volume')
INSERT INTO [dbo].[tblMaterialType] ([TypeID], [MeasureType]) VALUES (4, N'Bussiness ')
SET IDENTITY_INSERT [dbo].[tblMaterialType] OFF
