CREATE DATABASE /*!32312 IF NOT EXISTS*/ `SurveyDb` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `SurveyDb`;


/****** Object:  Table [dbo].[Survey]    Script Date: 9/7/2021 4:26:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Survey](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserID] [nchar](10) NULL,
	[Come] [nvarchar](50) NULL,
	[UseLib] [nvarchar](50) NULL,
	[KnowLib] [nvarchar](50) NULL,
	[Purpose] [nvarchar](50) NULL,
	[Reason] [nvarchar](50) NULL,
	[TimeLibOpen] [nvarchar](50) NULL,
	[Search] [nvarchar](50) NULL,
	[InformationDatabase] [nvarchar](50) NULL,
	[SearchDatabase] [nvarchar](50) NULL,
	[InformationCategory] [nvarchar](50) NULL,
	[ExactlyCategory] [nvarchar](50) NULL,
	[InformationWebsite] [nvarchar](50) NULL,
	[ExactlyWebsite] [nvarchar](50) NULL,
	[SearchWebsite] [nvarchar](50) NULL,
	[ReadEffective] [nvarchar](50) NULL,
	[BorrowEffective] [nvarchar](50) NULL,
	[ReferEffective] [nvarchar](50) NULL,
	[InternetEffective] [nvarchar](50) NULL,
	[PhotoEffective] [nvarchar](50) NULL,
	[DifferentEffective] [nvarchar](250) NULL,
	[SpaceReview] [nvarchar](50) NULL,
	[SeatReview] [nvarchar](50) NULL,
	[RoomReview] [nvarchar](50) NULL,
	[DeviceReview] [nvarchar](50) NULL,
	[InternetReview] [nvarchar](50) NULL,
	[WifiReview] [nvarchar](50) NULL,
	[ShelfReview] [nvarchar](50) NULL,
	[AdditionReview] [nvarchar](250) NULL,
	[DocumentVN] [nvarchar](50) NULL,
	[DocumentEN] [nvarchar](50) NULL,
	[DocumentJP] [nvarchar](50) NULL,
	[DocumentCN] [nvarchar](50) NULL,
	[DocumentKP] [nvarchar](50) NULL,
	[DocumentDE] [nvarchar](50) NULL,
	[ProjectDocument] [nvarchar](50) NULL,
	[NewpaperDocument] [nvarchar](50) NULL,
	[EbookDocument] [nvarchar](50) NULL,
	[UpdateDocument] [nvarchar](50) NULL,
	[EffectiveDocument] [nvarchar](50) NULL,
	[DifferentDocument] [nvarchar](250) NULL,
	[ManageAttitude] [nvarchar](50) NULL,
	[ServiceAttitude] [nvarchar](50) NULL,
	[DifferentAttitude] [nvarchar](250) NULL,
	[ProcessInformation] [nvarchar](50) NULL,
	[ProperProcedure] [nvarchar](50) NULL,
	[DifferentProcedure] [nvarchar](250) NULL,
	[SpeedLink] [nvarchar](50) NULL,
	[EffectiveLink] [nvarchar](50) NULL,
	[DifferentLink] [nvarchar](250) NULL,
	[YourSatisfied] [nvarchar](250) NULL,
	[NotSatisfied] [nvarchar](250) NULL,
	[Feedback] [nvarchar](250) NULL,
 CONSTRAINT [PK_Survey] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



