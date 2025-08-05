CREATE TABLE [dbo].[Licencia](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NameUsuario] [nvarchar](max) NULL,
    [Identificacion] [nvarchar](20) NULL,
	[Edad] [int] NULL,
	[IdLicencia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Ro] FOREIGN KEY([IdLicencia])
REFERENCES [dbo].[Licencia] ([Id])
GO

ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Ro]
GO




CREATE TABLE Clase(
Id INT PRIMARY KEY IDENTITY,
Descripcion NVARCHAR(400)
);

GO


CREATE TABLE Modulo(

Id INT PRIMARY KEY IDENTITY,
Descripcion NVARCHAR(400),
IdMateria INT,
CONSTRAINT  Fk_IdMateria_Modulo FOREIGN KEY(IdMateria)
REFERENCES Clase(Id)
);


GO


CREATE TABLE InscripcionModulo(
Id INT PRIMARY KEY IDENTITY,
IdUsuario INT,
IdModulo INT,
CONSTRAINT  Fk_IdUsuario_InscripcionModulo FOREIGN KEY(IdUsuario)
REFERENCES Usuario(Id),
CONSTRAINT  Fk_IdModulo_InscripcionModulo FOREIGN KEY(IdModulo)
REFERENCES Modulo(Id)
);
GO


GO
INSERT [dbo].[Licencia]([Description]) VALUES (N'A1')
INSERT [dbo].[Licencia]([Description]) VALUES (N'A2')
INSERT [dbo].[Licencia]([Description]) VALUES (N'B1')
INSERT [dbo].[Licencia]([Description]) VALUES (N'B2')
INSERT [dbo].[Licencia]([Description]) VALUES (N'C1')
INSERT [dbo].[Licencia]([Description]) VALUES (N'C2')
GO


GO
INSERT [dbo].[Clase]([Descripcion]) VALUES (N'Adaptación')
INSERT [dbo].[Clase]([Descripcion]) VALUES (N'Ética')
 INSERT [dbo].[Clase]([Descripcion]) VALUES (N'Marco Legal')
GO


INSERT  [dbo].[Modulo] ([Descripcion],[IdMateria] ) VALUES ('Adaptación 1', 1)
INSERT  [dbo].[Modulo]([Descripcion],[IdMateria] )  VALUES (N'Adaptación 2', 1)
INSERT  [dbo].[Modulo]([Descripcion],[IdMateria] )  VALUES (N'Ética I', 2)
INSERT  [dbo].[Modulo]([Descripcion],[IdMateria] )  VALUES (N'Ética II', 2)
INSERT [dbo].[Modulo]([Descripcion],[IdMateria] )  VALUES (N'Marco Legal I', 3)
INSERT  [dbo].[Modulo]([Descripcion],[IdMateria]) VALUES (N'Marco Legal II', 3)


GO

 CREATE PROCEDURE SPEstudiantes
 AS
 BEGIN

	SELECT 
	U.NameUsuario,
    U.Identificacion,
    U.Edad,
    L.Description
	FROM Usuario AS U
	INNER JOIN Licencia AS L ON U.IdLicencia = L.Id

 END



