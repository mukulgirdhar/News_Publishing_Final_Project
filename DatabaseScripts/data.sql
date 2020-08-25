INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'aead99d0-9396-4d8c-b3c0-96277ad9263c', N'site_admin', N'site_admin', N'23a402df-3b45-4c33-bf4a-00d239893cdb')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'bc015365-ca10-4c7a-b76a-937031ae2fa4', N'reporter', N'reporter', N'600d0f07-ef50-4ccf-bf11-643a27d7f369')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'52d76583-63e3-440e-b355-3803379b8ad3', N'admin@news.com', N'ADMIN@NEWS.COM', N'admin@news.com', N'ADMIN@NEWS.COM', 1, N'AQAAAAEAACcQAAAAEF1OTmfjjA1S5Hm6CeA32V15wUAUBV3Tb5A25ZqDjAQfsA9Jqzp4FsgbpAEjrsu3Yg==', N'FW7YZIZHYERHCYWYKN7W5NKROIVAE3KK', N'13d07a2c-6186-4c85-9f71-8f9a0fbbcba3', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7fdec723-1922-4bf2-8d2f-04bad6c0ab1a', N'reporter1@news.com', N'REPORTER1@NEWS.COM', N'reporter1@news.com', N'REPORTER1@NEWS.COM', 1, N'AQAAAAEAACcQAAAAELfiNQy1teH1FFSxpOZjpSnX1lajwZSR0yJRvGBZcxEABM2mhxnyvnWFttIxZe+mtQ==', N'NBTOQBNVLSS5YLZD4P36SDUYG44HE7ZE', N'43209a94-9b64-4568-92f7-619084605501', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'aade9161-0a4a-45d1-b86f-50961184d84d', N'mediaclub@news.com', N'MEDIACLUB@NEWS.COM', N'mediaclub@news.com', N'MEDIACLUB@NEWS.COM', 1, N'AQAAAAEAACcQAAAAELo4mjGr7KyPyAf9YVlUGPtuK/frF7d3I6ZDKDpcc1rRbhyZdWQJU3SamUiKqFRFTQ==', N'5HOVFZZ4G4LKXYYT3U2HGFZV3PD3H2LH', N'e32a53a8-cee2-4cb0-a4f4-bce6fe1f1695', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'52d76583-63e3-440e-b355-3803379b8ad3', N'aead99d0-9396-4d8c-b3c0-96277ad9263c')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7fdec723-1922-4bf2-8d2f-04bad6c0ab1a', N'bc015365-ca10-4c7a-b76a-937031ae2fa4')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aade9161-0a4a-45d1-b86f-50961184d84d', N'bc015365-ca10-4c7a-b76a-937031ae2fa4')
SET IDENTITY_INSERT [dbo].[NewsArticle] ON
INSERT INTO [dbo].[NewsArticle] ([Id], [Headline], [Content], [PublishedTime]) VALUES (2, N'AI recreates videos people are watching by reading their minds  ', N'Artificial intelligence is getting better at reading your mind. An AI could guess what videos people were watching purely from their brainwaves.  Grigory Rashkov at Russian research firm Neurobotics and his colleagues trained an AI using video clips of different objects and brainwave recordings of people watching them. The recordings were made using an electroencephalogram (EEG) cap and the video clips included nature scenes, people on jet skis and human expressions.  ', N'2020-08-25 16:05:07')
INSERT INTO [dbo].[NewsArticle] ([Id], [Headline], [Content], [PublishedTime]) VALUES (3, N'Turn any object into a robot using this program and a 3D printer ', N'Robots will soon be everywhere � especially if ordinary objects can be turned into them. A computer program can now use 3D printing to convert household objects into hand-activated robots.  These can be used to turn on bathroom taps with the wave of a hand or to give a window the ability to shut itself when the weather gets cold.  Xiang �Anthony� Chen at the University of California, Los Angeles, and his colleagues developed the tool, known as Robiot, to automate simple physical tasks. ', N'2020-08-25 16:29:41')
INSERT INTO [dbo].[NewsArticle] ([Id], [Headline], [Content], [PublishedTime]) VALUES (4, N'The Dark Knight star Heath Ledger''s most brutal Joker scene was real', N'An unearthed Christian Bale interview sheds light on Heath Ledger�s now-legendary portrayal of the Joker in Christopher Nolan film The Dark Knight.  Published by THR, the interview sees Batman actor Bale recount his memory of the �committed� performance from Ledger � who would have turned 40 today � revealing that the actor wanted to be hit for real in one of the 2008 film�s key moments: the interrogation scene.  The interview, conducted by Joseph McCabe in 2008, is featured in the new book 100 Things Batman Fans Should Know & Do Before They Die.  Bale remembered: �As you see in the movie, Batman starts beating the Joker and realises that this is not your ordinary foe. Because the more I beat him the more he enjoys it. The more I�m giving him satisfaction.  �Heath was behaving in a very similar fashion. He was kinda egging me on. I was saying, �You know what, I really don�t need to actually hit you. It�s going to look just as good if I don�t.� And he�s going, �Go on. Go on. Go on.�', N'2020-08-25 16:34:29')
INSERT INTO [dbo].[NewsArticle] ([Id], [Headline], [Content], [PublishedTime]) VALUES (5, N'Tesla Cybertruck Renderings Reimagine It As A Wagon, Two-Door', N'The Tesla Cybertruck is a lot of different things to a lot of different people. To some, Tesla�s electrified pickup is the future � a sci-fi-inspired vision of tomorrow�s truck. To others, it�s a laughingstock, a false start. Either way, Tesla knows how to make headlines, and it did not disappoint with the Cybertruck reveal last week. Tesla�s designers gave the truck an unconventional design, which has allowed some to imagine different versions of the truck. KDC Garage decided to apply the Cybertruck�s sharp-edged design to other body styles.', N'2020-08-25 16:42:58')
SET IDENTITY_INSERT [dbo].[NewsArticle] OFF

SET IDENTITY_INSERT [dbo].[Reporter] ON
INSERT INTO [dbo].[Reporter] ([Id], [ReportingCompany], [EmailAddress]) VALUES (1, N'Media Club55', N'mediaclub@news.com')
INSERT INTO [dbo].[Reporter] ([Id], [ReportingCompany], [EmailAddress]) VALUES (2, N'Reporter 1', N'reporter1@news.com')
SET IDENTITY_INSERT [dbo].[Reporter] OFF

SET IDENTITY_INSERT [dbo].[Publication] ON
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (1, 1, 2)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (2, 1, 3)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (3, 1, 4)
INSERT INTO [dbo].[Publication] ([Id], [ReporterId], [NewsArticleId]) VALUES (4, 2, 5)
SET IDENTITY_INSERT [dbo].[Publication] OFF