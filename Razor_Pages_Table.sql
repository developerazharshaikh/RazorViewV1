USE [Azhar]
GO
/****** Object:  Table [dbo].[RAZOR_PAGES]    Script Date: 25-10-2022 20:59:53 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RAZOR_PAGES]') AND type in (N'U'))
DROP TABLE [dbo].[RAZOR_PAGES]
GO
/****** Object:  Table [dbo].[RAZOR_PAGES]    Script Date: 25-10-2022 20:59:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RAZOR_PAGES](
	[PageId] [uniqueidentifier] NOT NULL,
	[ParentId] [uniqueidentifier] NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Body] [nvarchar](max) NOT NULL,
	[ViewName] [nvarchar](250) NULL,
	[ViewData] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[RAZOR_PAGES] ([PageId], [ParentId], [Title], [Body], [ViewName], [ViewData]) VALUES (N'88c516c3-877c-43a3-8f15-6937400db921', N'88c516c3-877c-43a3-8f15-6937400db921', N'Test', N'hereh', N'/Views/RenderRazor/ContactUs.cshtml', N'@{
    ViewBag.Title = "RAZOR";
}  <h2></h2> 

@(1 + 21)')
GO
INSERT [dbo].[RAZOR_PAGES] ([PageId], [ParentId], [Title], [Body], [ViewName], [ViewData]) VALUES (N'88c516c3-877c-43a3-8f15-6937400db924', N'88c516c3-877c-43a3-8f15-6937400db921', N'Test2', N'hdashdh', N'/Views/Home/Index.cshtml', N'@{
    ViewBag.Title = "RAZOR";
}  <h2>@ViewBag.Message</h2> 

@(1 + 1)')
GO
