USE [TimeTrackerDB]
GO
/****** Object:  Table [dbo].[TimeLog]    Script Date: 5/28/2019 7:38:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[LogDate] [date] NOT NULL,
	[TimeIn1] [time](7) NULL,
	[TimeOut1] [time](7) NULL,
	[TimeIn2] [time](7) NULL,
	[TimeOut2] [time](7) NULL,
	[TimeIn3] [time](7) NULL,
	[TimeOut3] [time](7) NULL,
 CONSTRAINT [PK_TimeLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TimeLog] ON 

INSERT [dbo].[TimeLog] ([Id], [UserId], [LogDate], [TimeIn1], [TimeOut1], [TimeIn2], [TimeOut2], [TimeIn3], [TimeOut3]) VALUES (1, 1, CAST(N'2019-03-03' AS Date), NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[TimeLog] OFF
