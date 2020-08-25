SET IDENTITY_INSERT [dbo].[Publication] ON
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (1, 1, 2)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (2, 1, 3)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (3, 1, 4)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (4, 2, 5)
SET IDENTITY_INSERT [dbo].[Publication] OFF
