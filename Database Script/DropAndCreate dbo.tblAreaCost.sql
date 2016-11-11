USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAreaCost] Script Date: 2016/11/02 1:16:45 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAreaCost];


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
);
USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticCanvasArea] Script Date: 2016/11/02 1:17:56 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticCanvasArea];


GO
CREATE TABLE [dbo].[tblAtlanticCanvasArea] (
    [AtlanticCanvasAreaID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]           NVARCHAR (9)   NOT NULL,
    [PricePerSqrMeter]     MONEY          NULL,
    [AreaLength]           DECIMAL (9, 3) NULL,
    [AreaWidth]            DECIMAL (9, 3) NULL,
    [TotalUsedAreaCost]    MONEY          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticCanvasBussCost] Script Date: 2016/11/02 1:18:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticCanvasBussCost];


GO
CREATE TABLE [dbo].[tblAtlanticCanvasBussCost] (
    [AtlanticCanvasBussCostID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]               NVARCHAR (9)   NOT NULL,
    [RatePerHour]              MONEY          NULL,
    [HoursWorked]              DECIMAL (2, 2) NULL,
    [TotalBussinessCost]       MONEY          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticCanvasLength] Script Date: 2016/11/02 1:18:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticCanvasLength];


GO
CREATE TABLE [dbo].[tblAtlanticCanvasLength] (
    [AtlanticCanvasLenID] INT             IDENTITY (1, 1) NOT NULL,
    [MaterialID]          NVARCHAR (9)    NOT NULL,
    [FrameLenght]         DECIMAL (9, 3)  NULL,
    [FrameWidth]          DECIMAL (9, 3)  NULL,
    [NoOfFrames]          DECIMAL (18, 2) NULL,
    [TotalUsedFrameCost]  MONEY           NULL,
    [FrameArea]           DECIMAL (9, 3)  NULL,
    [CanvasOverlap]       DECIMAL (9, 3)  NULL,
    [TotalCanvasArea]     DECIMAL (9, 3)  NULL,
    [TotalFrameLength]    DECIMAL (9, 3)  NULL,
    [FrameDescription]    TEXT            NULL
);


USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticCanvasVolume] Script Date: 2016/11/02 1:18:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticCanvasVolume];


GO
CREATE TABLE [dbo].[tblAtlanticCanvasVolume] (
    [AtlanticCanvasVolumeID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]             NVARCHAR (9)   NOT NULL,
    [PricePerLiter]          MONEY          NULL,
    [LitresUsed]             DECIMAL (9, 3) NULL,
    [TotalUsedVolumeCost]    MONEY          NULL
);
USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticFramedArea] Script Date: 2016/11/02 1:18:50 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticFramedArea];


GO
CREATE TABLE [dbo].[tblAtlanticFramedArea] (
    [AtlanticFramedAreaID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]           NVARCHAR (9)   NOT NULL,
    [PricePerSqrMeter]     MONEY          NULL,
    [AreaLength]           DECIMAL (9, 3) NULL,
    [AreaWidth]            DECIMAL (9, 3) NULL,
    [TotalUsedAreaCost]    MONEY          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticFramedBussCost] Script Date: 2016/11/02 1:19:01 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticFramedBussCost];


GO
CREATE TABLE [dbo].[tblAtlanticFramedBussCost] (
    [AtlanticFramedBussCostID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]               NVARCHAR (9)   NOT NULL,
    [RatePerHour]              MONEY          NULL,
    [HoursWorked]              DECIMAL (2, 2) NULL,
    [TotalBussinessCost]       MONEY          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticFramedLength] Script Date: 2016/11/02 1:19:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticFramedLength];


GO
CREATE TABLE [dbo].[tblAtlanticFramedLength] (
    [AtlanticFrameLenID] INT             IDENTITY (1, 1) NOT NULL,
    [MaterialID]         NVARCHAR (9)    NOT NULL,
    [FrameLenght]        DECIMAL (9, 3)  NULL,
    [FrameWidth]         DECIMAL (9, 3)  NULL,
    [NoOfFrames]         DECIMAL (18, 2) NULL,
    [TotalUsedFrameCost] MONEY           NULL,
    [FrameArea]          DECIMAL (9, 3)  NULL,
    [CanvasOverlap]      DECIMAL (9, 3)  NULL,
    [TotalCanvasArea]    DECIMAL (9, 3)  NULL,
    [TotalFrameLength]   DECIMAL (9, 3)  NULL
);


USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblAtlanticFramedVolume] Script Date: 2016/11/02 1:19:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblAtlanticFramedVolume];


GO
CREATE TABLE [dbo].[tblAtlanticFramedVolume] (
    [AtlanticFrmedVolumeID] INT            IDENTITY (1, 1) NOT NULL,
    [MaterialID]            NVARCHAR (9)   NOT NULL,
    [PricePerLiter]         MONEY          NULL,
    [LitresUsed]            DECIMAL (9, 3) NULL,
    [TotalUsedVolumeCost]   MONEY          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblBussinessCost] Script Date: 2016/11/02 1:19:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblBussinessCost];


GO
CREATE TABLE [dbo].[tblBussinessCost] (
    [BussinessCostID] INT          IDENTITY (1, 1) NOT NULL,
    [TypeID]          INT          NOT NULL,
    [MaterialID]      NVARCHAR (9) NOT NULL,
    [CostName]        TEXT         NULL,
    [RatePerHour]     MONEY        NULL
);


USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblLengthCost] Script Date: 2016/11/02 1:19:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblLengthCost];


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

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblMaterial] Script Date: 2016/11/02 1:19:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblMaterial];


GO
CREATE TABLE [dbo].[tblMaterial] (
    [MaterialID]  NVARCHAR (9) NOT NULL,
    [Name]        TEXT         NOT NULL,
    [Description] TEXT         NULL,
    [TypeID]      INT          NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblMaterialType] Script Date: 2016/11/02 1:20:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblMaterialType];


GO
CREATE TABLE [dbo].[tblMaterialType] (
    [TypeID]      INT           IDENTITY (1, 1) NOT NULL,
    [MeasureType] NVARCHAR (50) NOT NULL
);

USE [dbNewAge]
GO

/****** Object: Table [dbo].[tblVolumeCost] Script Date: 2016/11/02 1:20:29 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[tblVolumeCost];


GO
CREATE TABLE [dbo].[tblVolumeCost] (
    [VolumeCostID]  INT            IDENTITY (1, 1) NOT NULL,
    [TypeID]        INT            NOT NULL,
    [MaterialID]    NVARCHAR (9)   NOT NULL,
    [TotalVolume]   DECIMAL (9, 2) NULL,
    [PricePerLiter] MONEY          NULL,
    [TotalCost]     MONEY          NULL
);















