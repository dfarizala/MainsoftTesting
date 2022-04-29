/****** Object:  Database [testing_db]    Script Date: 29/04/2022 9:41:17 a. m. ******/
CREATE DATABASE [testing_db]  (EDITION = 'Standard', SERVICE_OBJECTIVE = 'S0', MAXSIZE = 250 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [testing_db] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [testing_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testing_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testing_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testing_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testing_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [testing_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testing_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testing_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testing_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testing_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testing_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testing_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testing_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testing_db] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [testing_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testing_db] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [testing_db] SET  MULTI_USER 
GO
ALTER DATABASE [testing_db] SET ENCRYPTION ON
GO
ALTER DATABASE [testing_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [testing_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Exam]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ExamName] [varchar](400) NULL,
	[EstimatedTime] [int] NULL,
	[Status] [varchar](20) NULL,
	[ExamProfile] [int] NULL,
	[ExamTechnology] [int] NULL,
	[NumberOfQuestions] [int] NULL,
	[CrationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Exam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamProfiles]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamProfiles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProfileName] [varchar](200) NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_ExamProfiles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamTechnology]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamTechnology](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TechnologyName] [varchar](200) NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_ExamTechnology] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExamTopic]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExamTopic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TopicName] [varchar](200) NULL,
	[CereationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_ExamTopic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionHeader]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionHeader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NULL,
	[QuestionType] [int] NULL,
	[QuestionTopic] [int] NULL,
	[QuestionText] [varchar](1000) NULL,
	[QuestionImage] [varchar](500) NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_QuestionHeader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuestionOptions]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuestionOptions](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[QuestionHeaderId] [int] NULL,
	[OptionText] [varchar](500) NULL,
	[IsCorrect] [int] NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_QuestionOptions] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recruiter]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recruiter](
	[id] [int] NOT NULL,
	[RecruiterName] [varchar](500) NULL,
	[Role] [int] NULL,
	[Email] [varchar](200) NULL,
	[Password] [varchar](1000) NULL,
	[Status] [int] NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_Recruiter] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExam]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExam](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ExamId] [int] NULL,
	[UserId] [int] NULL,
	[Start] [datetime] NULL,
	[Finish] [datetime] NULL,
	[TotalTime] [int] NULL,
	[ExamPercentage] [int] NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_UserExam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExamAnswers]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExamAnswers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[UserExamId] [int] NULL,
	[TechnologyId] [int] NULL,
	[TopicId] [int] NULL,
	[QuestionId] [int] NULL,
	[AnswerId] [int] NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_UserAnswers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserExamTopic]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserExamTopic](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[UserExamId] [int] NULL,
	[TopicId] [int] NULL,
	[TopicPercentage] [int] NULL,
	[CreationUser] [varchar](20) NULL,
	[CreationDate] [datetime] NULL,
	[ModificationUser] [varchar](20) NULL,
	[ModificationDate] [datetime] NULL,
 CONSTRAINT [PK_UserTopicAverage] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29/04/2022 9:41:17 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RecruiterId] [int] NULL,
	[Name] [varchar](200) NULL,
	[LastName] [varchar](200) NULL,
	[CellPhone] [varchar](20) NULL,
	[Phone] [varchar](20) NULL,
	[Gender] [varchar](20) NULL,
	[MaritalStatus] [varchar](20) NULL,
	[DocType] [varchar](10) NULL,
	[DocNumber] [varchar](20) NULL,
	[Address] [varchar](200) NULL,
	[Nationality] [varchar](200) NULL,
	[Age] [varchar](10) NULL,
	[BirthCity] [varchar](200) NULL,
	[JobSituation] [varchar](20) NULL,
	[LastJobCompany] [varchar](200) NULL,
	[LastJobName] [varchar](200) NULL,
	[LastJobReasson] [varchar](500) NULL,
	[AcademicLevel] [varchar](20) NULL,
	[AcademicInstitution] [varchar](200) NULL,
	[DegreeFinalization] [varchar](20) NULL,
	[DegreeTitle] [varchar](200) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Exam] ON 

INSERT [dbo].[Exam] ([id], [ExamName], [EstimatedTime], [Status], [ExamProfile], [ExamTechnology], [NumberOfQuestions], [CrationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (1, N'Prueba .NET', 120, N'1', 4, 1, 5, N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Exam] OFF
GO
SET IDENTITY_INSERT [dbo].[ExamProfiles] ON 

INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (1, N'Trainee', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (2, N'Junior', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (3, N'Junior Plus', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (4, N'Semi Senior', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (5, N'Senior 1', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamProfiles] ([id], [ProfileName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (6, N'Senior 2', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExamProfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[ExamTechnology] ON 

INSERT [dbo].[ExamTechnology] ([id], [TechnologyName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (1, N'.NET', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamTechnology] ([id], [TechnologyName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (2, N'Java', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamTechnology] ([id], [TechnologyName], [CreationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (3, N'SQL Server', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExamTechnology] OFF
GO
SET IDENTITY_INSERT [dbo].[ExamTopic] ON 

INSERT [dbo].[ExamTopic] ([id], [TopicName], [CereationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (1, N'POO', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamTopic] ([id], [TopicName], [CereationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (2, N'C#', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamTopic] ([id], [TopicName], [CereationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (3, N'CSS', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
INSERT [dbo].[ExamTopic] ([id], [TopicName], [CereationUser], [CreationDate], [ModificationUser], [ModificationDate]) VALUES (4, N'HTML', N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime), N'SYSTEM', CAST(N'2022-04-26T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ExamTopic] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (1, NULL, N'string', NULL, N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'0', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string', N'string')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (2, NULL, N'Diego', NULL, N'3125864447', N'3407981', N'Masculino', N'Divorciado', N'CC', N'80202658', N'Calle 22c # 29 a 47', N'Colombiano', N'39', N'Buenaventura', N'Empleado', N'Mainsoft Ltda.', N'Desarrollador Senior', N'Ninguna', N'Profesional', N'FUP', N'2015', N'Ingeniero de sistemas')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (5, NULL, N'Prueba', NULL, N'23472389', N'8329472', N'Masculino', N'Soltero', N'CC', N'84534573', N'Calle 2', N'Colombiano', N'1', N'Bogota', N'Empleado', N'Mainsoft', N'Gerente', N'', N'Bachiller', N'sjfhiwerufhi', N'2000', N'kdfsjwoefwfw')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (6, NULL, N'Carlos', NULL, N'2134454545', N'8329472', N'Masculino', N'Casado', N'CC', N'54564544', N'calle 100', N'Colombiano', N'32', N'Bogota', N'Empleado', N'Mainsoft', N'Gerente', N'', N'Especializacion', N'sjfhiwerufhi', N'2000', N'kdfsjwoefwfw')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (7, NULL, N'Diego', N'Arizala', N'3125864447', N'3407981', N'Masculino', N'Separado', N'CC', N'80202658', N'Calle 22c # 29a 47', N'Colombiano', N'39', N'Buenaventura', N'Empleado', N'Mainsoft', N'Desarrollador Senior', N'Ninguno', N'Profesional', N'Fundacion Universitaria Panamercana', N'2015', N'Ingeniero de sistemas')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (8, NULL, N'GERMAN', N'BRAVO', N'3113458794', N'5409467|', N'Masculino', N'Casado', N'CC', N'79494830', N'CALLE 74 F SUR', N'COLOMBIANO', N'53', N'BOGOTA', N'Empleado', N'MAINSOFT', N'RECLUTAMIENTOO', N'EMPLEADO ACTIVO', N'Técnico', N'UNIVERSIDAD DE LA SALLE', N'2010', N'INGENERO DE SISTEMAS')
INSERT [dbo].[Users] ([id], [RecruiterId], [Name], [LastName], [CellPhone], [Phone], [Gender], [MaritalStatus], [DocType], [DocNumber], [Address], [Nationality], [Age], [BirthCity], [JobSituation], [LastJobCompany], [LastJobName], [LastJobReasson], [AcademicLevel], [AcademicInstitution], [DegreeFinalization], [DegreeTitle]) VALUES (9, NULL, N'Juan', N'Talamera', N'3127654562', N'4536271', N'Masculino', N'Soltero', N'CC', N'1234567890', N'Calle Prueba no. 25 -56', N'Colombia', N'43', N'Cali', N'Empleado', N'AsistSoftware', N'Administrador', N'Ninguno', N'Profesional', N'Universidad la Gran Colombia', N'2017', N'Administrador de empresas')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_Exam_ExamProfiles] FOREIGN KEY([ExamProfile])
REFERENCES [dbo].[ExamProfiles] ([id])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_Exam_ExamProfiles]
GO
ALTER TABLE [dbo].[Exam]  WITH CHECK ADD  CONSTRAINT [FK_Exam_ExamTechnology] FOREIGN KEY([ExamTechnology])
REFERENCES [dbo].[ExamTechnology] ([id])
GO
ALTER TABLE [dbo].[Exam] CHECK CONSTRAINT [FK_Exam_ExamTechnology]
GO
ALTER TABLE [dbo].[QuestionHeader]  WITH CHECK ADD  CONSTRAINT [FK_QuestionHeader_Exam] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([id])
GO
ALTER TABLE [dbo].[QuestionHeader] CHECK CONSTRAINT [FK_QuestionHeader_Exam]
GO
ALTER TABLE [dbo].[QuestionHeader]  WITH CHECK ADD  CONSTRAINT [FK_QuestionHeader_ExamTopic] FOREIGN KEY([QuestionTopic])
REFERENCES [dbo].[ExamTopic] ([id])
GO
ALTER TABLE [dbo].[QuestionHeader] CHECK CONSTRAINT [FK_QuestionHeader_ExamTopic]
GO
ALTER TABLE [dbo].[QuestionOptions]  WITH CHECK ADD  CONSTRAINT [FK_QuestionOptions_QuestionHeader] FOREIGN KEY([QuestionHeaderId])
REFERENCES [dbo].[QuestionHeader] ([id])
GO
ALTER TABLE [dbo].[QuestionOptions] CHECK CONSTRAINT [FK_QuestionOptions_QuestionHeader]
GO
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD  CONSTRAINT [FK_UserExam_Exam] FOREIGN KEY([ExamId])
REFERENCES [dbo].[Exam] ([id])
GO
ALTER TABLE [dbo].[UserExam] CHECK CONSTRAINT [FK_UserExam_Exam]
GO
ALTER TABLE [dbo].[UserExam]  WITH CHECK ADD  CONSTRAINT [FK_UserExam_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UserExam] CHECK CONSTRAINT [FK_UserExam_Users]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_ExamTechnology] FOREIGN KEY([TechnologyId])
REFERENCES [dbo].[ExamTechnology] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_ExamTechnology]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_ExamTopic] FOREIGN KEY([TopicId])
REFERENCES [dbo].[ExamTopic] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_ExamTopic]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_QuestionHeader] FOREIGN KEY([QuestionId])
REFERENCES [dbo].[QuestionHeader] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_QuestionHeader]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_QuestionOptions] FOREIGN KEY([AnswerId])
REFERENCES [dbo].[QuestionOptions] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_QuestionOptions]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_UserExam] FOREIGN KEY([UserExamId])
REFERENCES [dbo].[UserExam] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_UserExam]
GO
ALTER TABLE [dbo].[UserExamAnswers]  WITH CHECK ADD  CONSTRAINT [FK_UserExamAnswers_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UserExamAnswers] CHECK CONSTRAINT [FK_UserExamAnswers_Users]
GO
ALTER TABLE [dbo].[UserExamTopic]  WITH CHECK ADD  CONSTRAINT [FK_UserExamTopic_ExamTopic] FOREIGN KEY([TopicId])
REFERENCES [dbo].[ExamTopic] ([id])
GO
ALTER TABLE [dbo].[UserExamTopic] CHECK CONSTRAINT [FK_UserExamTopic_ExamTopic]
GO
ALTER TABLE [dbo].[UserExamTopic]  WITH CHECK ADD  CONSTRAINT [FK_UserExamTopic_UserExam] FOREIGN KEY([UserExamId])
REFERENCES [dbo].[UserExam] ([id])
GO
ALTER TABLE [dbo].[UserExamTopic] CHECK CONSTRAINT [FK_UserExamTopic_UserExam]
GO
ALTER TABLE [dbo].[UserExamTopic]  WITH CHECK ADD  CONSTRAINT [FK_UserExamTopic_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[UserExamTopic] CHECK CONSTRAINT [FK_UserExamTopic_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Recruiter] FOREIGN KEY([RecruiterId])
REFERENCES [dbo].[Recruiter] ([id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Recruiter]
GO
ALTER DATABASE [testing_db] SET  READ_WRITE 
GO
