CREATE TABLE [dbo].[Contact] (

        [numcontact] [int] NOT NULL ,

        [nomcontact] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL ,

        [Picture] [image] NULL 

) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]