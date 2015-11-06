--TODOS LOS SCRIPT DE RRHH SISTEMAS PARA APLICACIONES TRANSACCIONALES.

USE MASTER
GO
if db_id('DB_Recursos_Humanos') is not null
BEGIN
	drop database DB_Recursos_Humanos;
END
create database DB_Recursos_Humanos;
GO

use DB_Recursos_Humanos;

--POR ÚLTIMO COPIAN TODO ESTO...

--CONTRATACIÓN CON EMPLEADO PRINCIPAL.

--Empleado
CREATE TABLE [dbo].[Empleado](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Apellido] [nvarchar](50) NOT NULL,
	[Cedula] [nvarchar](50) NOT NULL,
	Telefono varchar (13) not null,
	FechaNacimiento datetime not null,
	[Estado_Civil] [bit] NOT NULL,
	[Domicilio] [nvarchar](150) NULL,
	[Estado] [bit] NOT NULL,
	[Id_Profesion] [int] NOT NULL,
	[Id_Info_Academica] [int] NOT NULL,
	[Id_Antecendete] [int] NOT NULL,
	Id_area int not null,
	Id_Cargo int not null 
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--falta llave de area.

--agregado. CARGO.
CREATE TABLE [dbo].[Cargo](
	[Id_Cargo] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Cargo] [nvarchar](50) NOT NULL,
	[Salario] [int] NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Id_Oficina] [int] NULL,
 CONSTRAINT [PK_Cargo] PRIMARY KEY CLUSTERED 
(
	[Id_Cargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


--Tabla ANTECEDENTES
CREATE TABLE [dbo].[Antecedentes](
	[Id_Antecedente] [int] IDENTITY(1,1) NOT NULL,
	[Antecedente] [nvarchar](70) NOT NULL,
	[Descripcion] [nvarchar](300) NOT NULL
) ON [PRIMARY]

--contrato
CREATE TABLE [dbo].[Contrato](
	[Id_Contrato] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Contratacion] [date] NULL,
	[Fecha_Fin] [date] NULL,
	--[Id_Usuario] [int] NULL,
	--Para que debe estar relacionado con usuario. El empleado tiene un cargo tiene un contrato y solo el estaría relacionado a user.
	[Id_Empleado] [int] NULL,
	[Id_Documento] [int] NULL,
	[Id_Cargo] [int] NULL,
 CONSTRAINT [PK_Contrato] PRIMARY KEY CLUSTERED 
(
	[Id_Contrato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--DOCUMENTACIÓN
CREATE TABLE [dbo].[Documentacion](
	[Id_Documento] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Documento] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Documentacion] PRIMARY KEY CLUSTERED 
(
	[Id_Documento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


--INFORMACIÓN ACADÉMICA
CREATE TABLE [dbo].[Informacion_Academica](
	[Id_hist_academico] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Estudio] [nvarchar](70) NULL,
	[Descripcion] [nvarchar](100) NULL,
 CONSTRAINT [PK_Informacion_Academica] PRIMARY KEY CLUSTERED 
(
	[Id_hist_academico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--OFICINA
CREATE TABLE [dbo].[Oficina](
	[Id_Oficina] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NULL,
 CONSTRAINT [PK_Oficina] PRIMARY KEY CLUSTERED 
(
	[Id_Oficina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

--PROFESIONES
CREATE TABLE [dbo].[Profesiones](
	[Id_Profesion] [int] IDENTITY(1,1) NOT NULL,
	[Profesion] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](150) NULL,
 CONSTRAINT [PK_Profesiones] PRIMARY KEY CLUSTERED 
(
	[Id_Profesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Cargo]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Oficina] FOREIGN KEY([Id_Oficina])
REFERENCES [dbo].[Oficina] ([Id_Oficina])
GO
ALTER TABLE [dbo].[Cargo] CHECK CONSTRAINT [FK_Cargo_Oficina]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Cargo] FOREIGN KEY([Id_Cargo])
REFERENCES [dbo].[Cargo] ([Id_Cargo])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Cargo]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Documentacion] FOREIGN KEY([Id_Documento])
REFERENCES [dbo].[Documentacion] ([Id_Documento])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Documentacion]
GO
ALTER TABLE [dbo].[Contrato]  WITH CHECK ADD  CONSTRAINT [FK_Contrato_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Contrato] CHECK CONSTRAINT [FK_Contrato_Empleado]

ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Informacion_Academica] FOREIGN KEY([Id_Info_Academica])
REFERENCES [dbo].[Informacion_Academica] ([Id_hist_academico])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Informacion_Academica]
GO
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Profesiones] FOREIGN KEY([Id_Profesion])
REFERENCES [dbo].[Profesiones] ([Id_Profesion])
GO
ALTER TABLE [dbo].[Empleado] CHECK CONSTRAINT [FK_Empleado_Profesiones]

ALTER TABLE Antecedentes with check add constraint PK_Antecedentes PRIMARY KEY (Id_Antecedente)

ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Antecedente_Empleado] FOREIGN KEY([Id_Antecendete])
REFERENCES [dbo].[Antecedentes] ([Id_Antecedente])

--llave cargo con empleado
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Cargo_Empleado] FOREIGN KEY([Id_Cargo])
REFERENCES [dbo].[Cargo] ([Id_Cargo])

--LA LLAVE CON USER ES ELIMINADA PORQUE NO VEO POR QUÉ ESTAR RELACIONADA CON CONTRATO
--SINO MÁS BN CON EMPLEADO ASÍ QUE MÁS ADELANTE LO HARÉ DICHA RELACIÓN USER-EMPLEADO.

--SELECCIÓN

--detalle idioma requerido.
CREATE TABLE [dbo].[DetIdiomasReq](
	[ID_IdiomaReq] [int] IDENTITY(1,1) NOT NULL,
	[tb_DetIdiomasReq_titulo] [varchar](50) NULL,
	[tb_DetIdiomasReq_dominio] [float] NULL,
 CONSTRAINT [PK_DetIdiomasReq] PRIMARY KEY CLUSTERED 
(
	[ID_IdiomaReq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--detalle idioma candidato.
CREATE TABLE [dbo].[DetIdiomasCand](
	[ID_DetCandidatosIdioma] [int] IDENTITY(1,1) NOT NULL,
	[tb_DetIdiCan_idioma] [varchar](50) NULL,
	[tb_DetIdiCan_dominio] [float] NULL,
 CONSTRAINT [PK_DetIdiomasCand] PRIMARY KEY CLUSTERED 
(
	[ID_DetCandidatosIdioma] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


--detalle especialidad requerida.

CREATE TABLE [dbo].[DetEspecialidadesReq](
	[ID_EspecialidadesReq] [int] IDENTITY(1,1) NOT NULL,
	[tb_DetEspecialidadesReq_titulo] [varchar](50) NULL,
	[tb_DetespecialidadesReq_aniosExp] [int] NULL,
 CONSTRAINT [PK_DetEspecialidadesReq] PRIMARY KEY CLUSTERED 
(
	[ID_EspecialidadesReq] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--detalle especialidad candidato.
CREATE TABLE [dbo].[DetEspecialidadesCand](
	[Id_DetalleEspecialistaCandidato] [int] IDENTITY(1,1) NOT NULL,
	[tb_DetEspeCan_titulo] [varchar](max) NULL,
	[tb_DetEspeCan_aniosExpe] [int] NULL,
 CONSTRAINT [PK_DetEspecialidadesCand] PRIMARY KEY CLUSTERED 
(
	[Id_DetalleEspecialistaCandidato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--Idiomas requeridos

CREATE TABLE [dbo].[IdiomasRequeridos](
	[tb_idiomasReq_id] [int] IDENTITY(1,1) NOT NULL,
	[ID_DetalleIdiomaReq] [int] NULL,
 CONSTRAINT [PK_IdiomasRequeridos] PRIMARY KEY CLUSTERED 
(
	[tb_idiomasReq_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--idiomas
CREATE TABLE [dbo].[Idiomas](
	[tb_idiomas_id] [int] IDENTITY(1,1) NOT NULL,
	[DetalleIdiomaCandidato] [int] NULL,
 CONSTRAINT [PK_Idiomas] PRIMARY KEY CLUSTERED 
(
	[tb_idiomas_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--especialidad req
CREATE TABLE [dbo].[EspecialidadesReq](
	[tb_EspecialidadesReq_id] [int] IDENTITY(1,1) NOT NULL,
	[ID_DetalleEspecReq] [int] NULL,
 CONSTRAINT [PK_EspecialidadesReq] PRIMARY KEY CLUSTERED 
(
	[tb_EspecialidadesReq_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--especialidades
CREATE TABLE [dbo].[Especialidades](
	[Id_Especialidad] [int] IDENTITY(1,1) NOT NULL,
	[DetalleEspecialidad] [int] NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[Id_Especialidad] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--vacantes
CREATE TABLE [dbo].[Vacantes](
	[ID_Vacante] [int] IDENTITY(1,1) NOT NULL,
	[tb_Vacantes_cargo] [varchar](max) NULL,
	[tb_Vacantes_genero] [varchar](50) NULL,
	[tb_Vacantes_edadMax] [int] NULL,
	[tb_Vacantes_edadMin] [int] NULL,
	[tb_Vacantes_ofertaSal] [float] NULL,
	[tb_Vacantes_nivelAcade] [varchar](50) NULL,
	[tb_Vacantes_idioma] [int] NULL,
	[tb_Vacantes_especialidad] [int] NULL,
	[tb_Vacantes_notaMinTestPsicologico] [float] NULL,
	[tb_Vacantes_notaMinTestPsicometrico] [float] NULL,
	[tb_Vacantes_notaMinTestTecnico] [float] NULL,
 CONSTRAINT [PK_Vacantes] PRIMARY KEY CLUSTERED 
(
	[ID_Vacante] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

--vacante candidato
CREATE TABLE [dbo].[Candidato](
	[ID_Candidato] [int] IDENTITY(1,1) NOT NULL,
	[tb_Candidatos_nombres] [varchar](max) NULL,
	[tb_Candidatos_apellidos] [varbinary](max) NULL,
	[tb_Candidatos_genero] [bit] NULL,
	[tb_Candidatos_cedula] [varchar](50) NULL,
	[tb_Candidatos_fecNac] [date] NULL,
	[tb_Candidatos_estadoCivil] [varchar](50) NULL,
	[tb_Candidatos_domicilio] [varchar](max) NULL,
	[tb_Candidatos_ciudad] [varchar](50) NULL,
	[tb_Candidatos_departamento] [varchar](50) NULL,
	[tb_Candidatos_pais] [varchar](50) NULL,
	[tb_Candidatos_telefonoConv] [varchar](50) NULL,
	[tb_Candidatos_telefonomovil] [varchar](50) NULL,
	[tb_Candidatos_correoElectronico] [varchar](50) NULL,
	[tb_Candidatos_especialidad] [int] NULL,
	[tb_Candidatos_idioma] [int] NULL,
	[tb_Candidatos_nivelAcademico] [varchar](50) NULL,
	[tb_Candidatos_notaTestPsicologico] [float] NULL,
	[tb_Candidatos_notaTestPsicometrico] [float] NULL,
	[tb_Candidatos_notaTestTecnico] [float] NULL,
 CONSTRAINT [PK_Candidato] PRIMARY KEY CLUSTERED 
(
	[ID_Candidato] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]


--llaves foráneas de selección.
GO
/****** Object:  ForeignKey [FK_IdiomasRequeridos_DetIdiomasReq]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[IdiomasRequeridos]  WITH CHECK ADD  CONSTRAINT [FK_IdiomasRequeridos_DetIdiomasReq] FOREIGN KEY([ID_DetalleIdiomaReq])
REFERENCES [dbo].[DetIdiomasReq] ([ID_IdiomaReq])
GO
ALTER TABLE [dbo].[IdiomasRequeridos] CHECK CONSTRAINT [FK_IdiomasRequeridos_DetIdiomasReq]
GO
/****** Object:  ForeignKey [FK_Idiomas_DetIdiomasCand]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Idiomas]  WITH CHECK ADD  CONSTRAINT [FK_Idiomas_DetIdiomasCand] FOREIGN KEY([DetalleIdiomaCandidato])
REFERENCES [dbo].[DetIdiomasCand] ([ID_DetCandidatosIdioma])
GO
ALTER TABLE [dbo].[Idiomas] CHECK CONSTRAINT [FK_Idiomas_DetIdiomasCand]
GO
/****** Object:  ForeignKey [FK_EspecialidadesReq_DetEspecialidadesReq]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[EspecialidadesReq]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesReq_DetEspecialidadesReq] FOREIGN KEY([ID_DetalleEspecReq])
REFERENCES [dbo].[DetEspecialidadesReq] ([ID_EspecialidadesReq])
GO
ALTER TABLE [dbo].[EspecialidadesReq] CHECK CONSTRAINT [FK_EspecialidadesReq_DetEspecialidadesReq]
GO
/****** Object:  ForeignKey [FK_Especialidades_DetEspecialidadesCand]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Especialidades]  WITH CHECK ADD  CONSTRAINT [FK_Especialidades_DetEspecialidadesCand] FOREIGN KEY([DetalleEspecialidad])
REFERENCES [dbo].[DetEspecialidadesCand] ([Id_DetalleEspecialistaCandidato])
GO
ALTER TABLE [dbo].[Especialidades] CHECK CONSTRAINT [FK_Especialidades_DetEspecialidadesCand]
GO
/****** Object:  ForeignKey [FK_Vacantes_EspecialidadesReq]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Vacantes]  WITH CHECK ADD  CONSTRAINT [FK_Vacantes_EspecialidadesReq] FOREIGN KEY([tb_Vacantes_especialidad])
REFERENCES [dbo].[EspecialidadesReq] ([tb_EspecialidadesReq_id])
GO
ALTER TABLE [dbo].[Vacantes] CHECK CONSTRAINT [FK_Vacantes_EspecialidadesReq]
GO
/****** Object:  ForeignKey [FK_Vacantes_IdiomasRequeridos]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Vacantes]  WITH CHECK ADD  CONSTRAINT [FK_Vacantes_IdiomasRequeridos] FOREIGN KEY([tb_Vacantes_idioma])
REFERENCES [dbo].[IdiomasRequeridos] ([tb_idiomasReq_id])
GO
ALTER TABLE [dbo].[Vacantes] CHECK CONSTRAINT [FK_Vacantes_IdiomasRequeridos]
GO
/****** Object:  ForeignKey [FK_Candidato_Especialidades]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Candidato]  WITH CHECK ADD  CONSTRAINT [FK_Candidato_Especialidades] FOREIGN KEY([tb_Candidatos_especialidad])
REFERENCES [dbo].[Especialidades] ([Id_Especialidad])
GO
ALTER TABLE [dbo].[Candidato] CHECK CONSTRAINT [FK_Candidato_Especialidades]
GO
/****** Object:  ForeignKey [FK_Candidato_Idiomas]    Script Date: 10/28/2015 19:04:10 ******/
ALTER TABLE [dbo].[Candidato]  WITH CHECK ADD  CONSTRAINT [FK_Candidato_Idiomas] FOREIGN KEY([tb_Candidatos_idioma])
REFERENCES [dbo].[Idiomas] ([tb_idiomas_id])
GO
ALTER TABLE [dbo].[Candidato] CHECK CONSTRAINT [FK_Candidato_Idiomas]
GO


--CAPACITACIÓN

--AREA
CREATE TABLE area(
ID int NOT NULL PRIMARY KEY,
nombre varchar(40) NOT NULL
);
--llave foránea con empleados.
ALTER TABLE [dbo].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Area_Empleado] FOREIGN KEY([Id_area])
REFERENCES [dbo].[area] ([ID])

CREATE TABLE centro_capacit(
ID int NOT NULL PRIMARY KEY,
nombre varchar(20) NOT NULL
);

CREATE TABLE pregunta(
ID int NOT NULL PRIMARY KEY,
pregunta varchar(100) NOT NULL
);

CREATE TABLE respuesta(
ID int NOT NULL PRIMARY KEY,
ID_pregunta int NOT NULL FOREIGN KEY REFERENCES pregunta(ID),
respuesta varchar(100) NOT NULL,
correcta int NOT NULL
);

CREATE TABLE encuesta(
ID int NOT NULL PRIMARY KEY,
ID_pregunta int NOT NULL FOREIGN KEY REFERENCES pregunta(ID)
);

CREATE TABLE tema(
ID int NOT NULL PRIMARY KEY,
nombre varchar(20) NOT NULL
);

CREATE TABLE tema_plan(
ID_plan int NOT NULL PRIMARY KEY,
ID_tema int NOT NULL FOREIGN KEY REFERENCES tema(ID)
);

CREATE TABLE plan_estudio(
ID int NOT NULL PRIMARY KEY,
ID_tema_plan int NOT NULL FOREIGN KEY REFERENCES tema_plan(ID_plan),
anio varchar(10) NOT NULL
);

CREATE TABLE capacitacion(
ID int NOT NULL PRIMARY KEY,
ID_plan int NOT NULL FOREIGN KEY REFERENCES plan_estudio(ID),
nombre varchar(30) NOT NULL,
fecha date NOT NULL,
duracion int NOT NULL,
ID_centro_cap int NOT NULL FOREIGN KEY REFERENCES centro_capacit(ID),
ID_encuesta int NOT NULL FOREIGN KEY REFERENCES encuesta(ID),
ID_area int NOT NULL FOREIGN KEY REFERENCES area(ID)
);

CREATE TABLE capacitacion_empleado(
Id_empleado int NOT NULL FOREIGN KEY REFERENCES [dbo].[Empleado](Id_Empleado),
ID_capacitacion int NOT NULL FOREIGN KEY REFERENCES capacitacion(ID)
);

--EVALUACI+ON AL DESEMPEÑO

CREATE TABLE [dbo].[Debilidades](
	[Id_Debilidades] [int] NOT NULL,
	[Nombre_Debilidades] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Debilidades] PRIMARY KEY CLUSTERED 
(
	[Id_Debilidades] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Fortalezas](
	[Id_Fortalezas] [int] NOT NULL,
	[Nombre_Fortalezas] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Fortalezas] PRIMARY KEY CLUSTERED 
(
	[Id_Fortalezas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Indicadores](
	[Id_Indicador] [int] NOT NULL,
	[Nombre_Indicador] [nvarchar](50) NOT NULL,
	[Id_Nivel_Evaluativo] [int] NOT NULL,
	[Id_Fortalezas] [int] NOT NULL,
	[Id_Debilidades] [int] NOT NULL,
	[Fecha_Evaluacion] [date] NOT NULL,
 CONSTRAINT [PK_Indicadores] PRIMARY KEY CLUSTERED 
(
	[Id_Indicador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Niveles_Evaluativos](
	[Id_Nivel_Evaluativo] [int] NOT NULL,
	[Tipo_Nivel_Evaluativo] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Niveles_Evaluativos] PRIMARY KEY CLUSTERED 
(
	[Id_Nivel_Evaluativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[Resultados](
	[Id_Resultados] [int] NOT NULL,
	[Id_Indicador] [int] NOT NULL,
	[Resultado_Final] [nchar](10) NULL,
	[Id_Empleado] [int] NOT NULL,
 CONSTRAINT [PK_Resultados] PRIMARY KEY CLUSTERED 
(
	[Id_Resultados] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

ALTER TABLE [dbo].[Indicadores]  WITH CHECK ADD  CONSTRAINT [FK_Indicadores_Debilidades] FOREIGN KEY([Id_Debilidades])
REFERENCES [dbo].[Debilidades] ([Id_Debilidades])
GO
ALTER TABLE [dbo].[Indicadores] CHECK CONSTRAINT [FK_Indicadores_Debilidades]
GO
ALTER TABLE [dbo].[Indicadores]  WITH CHECK ADD  CONSTRAINT [FK_Indicadores_Fortalezas] FOREIGN KEY([Id_Fortalezas])
REFERENCES [dbo].[Fortalezas] ([Id_Fortalezas])
GO
ALTER TABLE [dbo].[Indicadores] CHECK CONSTRAINT [FK_Indicadores_Fortalezas]
GO
ALTER TABLE [dbo].[Indicadores]  WITH CHECK ADD  CONSTRAINT [FK_Indicadores_Niveles_Evaluativos] FOREIGN KEY([Id_Nivel_Evaluativo])
REFERENCES [dbo].[Niveles_Evaluativos] ([Id_Nivel_Evaluativo])
GO
ALTER TABLE [dbo].[Indicadores] CHECK CONSTRAINT [FK_Indicadores_Niveles_Evaluativos]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Empleados] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Empleados]
GO
ALTER TABLE [dbo].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Indicadores1] FOREIGN KEY([Id_Indicador])
REFERENCES [dbo].[Indicadores] ([Id_Indicador])
GO
ALTER TABLE [dbo].[Resultados] CHECK CONSTRAINT [FK_Resultados_Indicadores1]
GO

--ACCIONES DE RRHH
CREATE TABLE vacaciones
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	Id_Empleado integer NOT NULL,
	fecha_creacion datetime2 NOT NULL CONSTRAINT "vacaciones_fecha_creacion" DEFAULT GETDATE(),
	fecha_inicio date NOT NULL,
	fecha_fin date NOT NULL,
	aceptado bit NOT NULL,
	FOREIGN KEY(Id_Empleado) REFERENCES Empleado(Id_Empleado),
	timestamp
);

CREATE TABLE permisos
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	Id_Empleado integer NOT NULL,
	fecha_creacion datetime2 NOT NULL CONSTRAINT permisos_fecha_creacion DEFAULT GETDATE(),
	fecha_inicio datetime2 NOT NULL,
	fecha_fin datetime2 NOT NULL,
	descripcion text NOT NULL,
	categoria varchar(30) NOT NULL,
	FOREIGN KEY(Id_Empleado) REFERENCES Empleado(Id_Empleado),
	timestamp
);

CREATE TABLE entradas
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	Id_Empleado integer NOT NULL,
	fecha date NOT NULL,
	hora_marcado time NOT NULL,
	FOREIGN KEY(Id_Empleado) REFERENCES Empleado(Id_Empleado),
	CONSTRAINT "entrada_por_dia" UNIQUE(Id_Empleado,fecha),
	timestamp
);

CREATE TABLE salidas
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	Id_Empleado integer NOT NULL,
	id_entrada integer NOT NULL,
	hora_marcado time NOT NULL,
	FOREIGN KEY(Id_Empleado) REFERENCES Empleado(Id_Empleado),
	FOREIGN KEY(id_entrada) REFERENCES entradas(id),
	timestamp
);

CREATE TABLE liquidaciones
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	Id_Empleado integer NOT NULL,
	fecha_egreso date NOT NULL,
	fecha_creacion datetime2 NOT NULL CONSTRAINT "liquidaciones_fecha_creacion" DEFAULT GETDATE(),
	total_aguinaldo float NOT NULL,
	total_vacaciones float NOT NULL,
	total_indemnizacion float NOT NULL,
	total_salarios_restantes float NOT NULL,
	deduccion_inss float NOT NULL,
	deduccion_prestamo_personales float NOT NULL,
	deduccion_otros float NOT NULL,
	descripcion_otros text,
	pago_total float NOT NULL,
	FOREIGN KEY(Id_Empleado) REFERENCES Empleado(Id_Empleado),
	timestamp
);

CREATE INDEX emp_cedula ON Empleado(Cedula)

CREATE INDEX emp_fecha_contratacion ON Contrato(Fecha_Contratacion)

--NÓMINA

CREATE TABLE TB_DEVENGADO (
	ID INTEGER PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(100) NOT NULL
);

CREATE TABLE TB_DEDUCCION (
	ID INTEGER PRIMARY KEY IDENTITY(1,1),
	NOMBRE VARCHAR(50) NOT NULL,
	DESCRIPCION VARCHAR(100) NOT NULL
);

CREATE TABLE TB_MOVIMIENTO_DEVENGADO (
	ID INTEGER PRIMARY KEY IDENTITY(1,1),
	EMPLEADO INTEGER NOT NULL REFERENCES [Empleado]([Id_Empleado]),
	AÑO INTEGER NOT NULL,
	MES INTEGER NOT NULL,
	DIA_INICIO INTEGER NOT NULL,
	DIA_FIN INTEGER NOT NULL,
	MONTO MONEY NOT NULL,
	ID_DEVENGADOS INTEGER NOT NULL REFERENCES TB_DEVENGADO(ID)
);

CREATE TABLE TB_MOVIMIENTO_DEDUCCION (
	ID INTEGER PRIMARY KEY IDENTITY(1,1),
	EMPLEADO INTEGER NOT NULL REFERENCES [Empleado]([Id_Empleado]),
	AÑO INTEGER NOT NULL,
	MES INTEGER NOT NULL,
	DIA_INICIO INTEGER NOT NULL,
	DIA_FIN INTEGER NOT NULL,
	MONTO MONEY NOT NULL,
	ID_DEDUCCION INTEGER NOT NULL REFERENCES TB_DEDUCCION(ID)
);



--crédito

CREATE TABLE [dbo].[TB_PRESTAMO](
	[id_prestamo] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
	[id_plazo_pago] [int] NOT NULL,
	--[id_nomina] [int] NOT NULL,
	--[salario_actual] [float] NOT NULL,
	[fecha_inicio] [date] NOT NULL,
	[fecha_final] [date] NOT NULL,
	[monto_prestado] [float] NOT NULL,
	[Id_Empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_prestamo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[TB_CUOTA](
	[id_cuota] [int] NOT NULL,
	[fecha_pago] [datetime] NOT NULL,
	[numero_cuota] [int] NOT NULL,
	[monto_cuota] [float] NOT NULL,
	[id_prestamo] [int] NOT NULL,
	[id_estado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_cuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[TB_ESTADO](
	[id_estado] [int] NOT NULL,
	[nombre_estado] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


CREATE TABLE [dbo].[TB_PLAZO_PAGO](
	[id_plazo_pago] [int] NOT NULL,
	[plazo_pago] [varchar](10) NOT NULL,
	[cant_plazo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_plazo_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[TB_RECIBO_CUOTA](
	[id_prestamo] [int] NOT NULL,
	[id_cuota] [int] NOT NULL,
	[fecha_pago_emitido] [datetime] NOT NULL,
	[ciudad_emitido] [int] NOT NULL,
	[Id_Empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_prestamo] ASC,
	[id_cuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]


ALTER TABLE [dbo].[TB_CUOTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_CUOTA_TB_PRESTAMO] FOREIGN KEY([id_prestamo])
REFERENCES [dbo].[TB_PRESTAMO] ([id_prestamo])
ALTER TABLE [dbo].[TB_CUOTA] CHECK CONSTRAINT [FK_TB_CUOTA_TB_PRESTAMO]
--Préstamo y estado
ALTER TABLE [dbo].[TB_PRESTAMO]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRESTAMO_TB_ESTADO] FOREIGN KEY([id_estado])
REFERENCES [dbo].[TB_ESTADO] ([id_estado])
GO
ALTER TABLE [dbo].[TB_PRESTAMO] CHECK CONSTRAINT [FK_TB_PRESTAMO_TB_ESTADO]
GO

ALTER TABLE [dbo].[TB_PRESTAMO]  WITH CHECK ADD  CONSTRAINT [FK_prestamo_pagoPlazo] FOREIGN KEY([id_plazo_pago])
REFERENCES [dbo].[TB_PLAZO_PAGO] ([id_plazo_pago])
GO

ALTER TABLE [dbo].[TB_PRESTAMO]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRESTAMO_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[TB_PRESTAMO] CHECK CONSTRAINT [FK_TB_PRESTAMO_Empleado]

--RECIBO CUOTA CON CUOTA
ALTER TABLE [dbo].[TB_RECIBO_CUOTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_RECIBO_CUOTA_TB_CUOTA] FOREIGN KEY([id_cuota])
REFERENCES [dbo].[TB_CUOTA] ([id_cuota])
GO
ALTER TABLE [dbo].[TB_RECIBO_CUOTA] CHECK CONSTRAINT [FK_TB_RECIBO_CUOTA_TB_CUOTA]

ALTER TABLE [dbo].[TB_PRESTAMO]  WITH CHECK ADD  CONSTRAINT [FK_TB_PRESTAMO_TB_PLAZO_PAGO] FOREIGN KEY([id_plazo_pago])
REFERENCES [dbo].[TB_PLAZO_PAGO] ([id_plazo_pago])
GO
ALTER TABLE [dbo].[TB_PRESTAMO] CHECK CONSTRAINT [FK_TB_PRESTAMO_TB_PLAZO_PAGO]





--RECIBO CUOTA Y PRÉSTAMO
ALTER TABLE [dbo].[TB_RECIBO_CUOTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_RECIBO_CUOTA_TB_PRESTAMO] FOREIGN KEY([id_prestamo])
REFERENCES [dbo].[TB_PRESTAMO] ([id_prestamo])
GO
ALTER TABLE [dbo].[TB_RECIBO_CUOTA] CHECK CONSTRAINT [FK_TB_RECIBO_CUOTA_TB_PRESTAMO]

--RECIBO CUOTA Y EMPLEADO DIRECTAMENTE.
ALTER TABLE [dbo].[TB_RECIBO_CUOTA]  WITH CHECK ADD  CONSTRAINT [FK_TB_RECIBO_CUOTA_Empleado] FOREIGN KEY([Id_Empleado])
REFERENCES [dbo].[Empleado] ([Id_Empleado])
GO
ALTER TABLE [dbo].[TB_RECIBO_CUOTA] CHECK CONSTRAINT [FK_TB_RECIBO_CUOTA_Empleado]

--SEGURIDAD.


--  Create Tables 
CREATE TABLE TB_Adm_Contenido ( 
	id_contenido smallint NOT NULL identity (1,1),
	id_sesion smallint NOT NULL,
	id_user smallint NOT NULL,
	tabla_registro varchar(50) NULL,
	registros_creados nvarchar(max) NULL,
	tabla_cambios varchar(50) NULL,
	cambios_realizados nvarchar(max) NULL
)
;

CREATE TABLE TB_Adm_OpcionesSistema ( 
	id_opciones smallint NOT NULL identity (1,1),
	nombre_opciones varchar(60) NOT NULL,
	desc_opciones varchar(max) NOT NULL,
	modulo varchar (max) not null
)
;


CREATE TABLE TB_Adm_RolesDeUsuario ( 
	id_rolUsuario smallint NOT NULL identity (1,1),
	rol_usuario varchar(50) NOT NULL,
	descripcion_rol varchar(max) NOT NULL
)
;

CREATE TABLE TB_Adm_Sesion ( 
	id_sesion smallint NOT NULL identity (1,1),
	id_user smallint NOT NULL,
	fechaSesion date NOT NULL,
	horaIngreso date NOT NULL,
	horaFinalizado date NOT NULL
)
;

CREATE TABLE TB_Adm_Usuario ( 
	id_user smallint NOT NULL identity (1,1),
	Id_Empleado int NOT NULL FOREIGN KEY REFERENCES [dbo].[Empleado](Id_Empleado),
	nombre varchar(35) NOT NULL,
	passUser varchar(30) NOT NULL
)
;

CREATE TABLE TB_Adm_Usuario_OpcionesSistema ( 
	id_userOpciones smallint NOT NULL identity (1,1),
	id_user smallint NOT NULL,
	id_opciones smallint NOT NULL
)
;


CREATE TABLE TB_Adm_Usuario_Roles ( 
	id_userRoles smallint NOT NULL identity (1,1),
	id_user smallint NOT NULL,
	id_rolUsuario smallint NOT NULL
)
;

--  Create Primary Key Constraints 
ALTER TABLE TB_Adm_Contenido ADD CONSTRAINT PK_TB_Adm_Contenido 
	PRIMARY KEY CLUSTERED (id_contenido)
;

ALTER TABLE TB_Adm_OpcionesSistema ADD CONSTRAINT PK_Permisos 
	PRIMARY KEY CLUSTERED (id_opciones)
;

ALTER TABLE TB_Adm_RolesDeUsuario ADD CONSTRAINT PK_Roles 
	PRIMARY KEY CLUSTERED (id_rolUsuario)
;

ALTER TABLE TB_Adm_Sesion ADD CONSTRAINT PK_Sesion 
	PRIMARY KEY CLUSTERED (id_sesion)
;

ALTER TABLE TB_Adm_Usuario ADD CONSTRAINT PK_Usuario 
	PRIMARY KEY CLUSTERED (id_user)
;

ALTER TABLE TB_Adm_Usuario_OpcionesSistema ADD CONSTRAINT PK_Usuario_OpcionesSistema 
	PRIMARY KEY CLUSTERED (id_userOpciones)
;

ALTER TABLE TB_Adm_Usuario_Roles ADD CONSTRAINT PK_Usuario_Roles 
	PRIMARY KEY CLUSTERED (id_userRoles)
;


--  Create Indexes 
ALTER TABLE TB_Adm_Contenido
	ADD CONSTRAINT UQ_TB_Adm_Contenido_id_contenido UNIQUE (id_contenido)
;

ALTER TABLE TB_Adm_OpcionesSistema
	ADD CONSTRAINT UQ_TB_Adm_Opciones_id_opciones UNIQUE (id_opciones)
;

ALTER TABLE TB_Adm_RolesDeUsuario
	ADD CONSTRAINT UQ_TB_Adm_RolesDeUsuario_id_rolUsuario UNIQUE (id_rolUsuario)
;

ALTER TABLE TB_Adm_Sesion
	ADD CONSTRAINT UQ_TB_Adm_Sesion_id_sesion UNIQUE (id_sesion)
;

ALTER TABLE TB_Adm_Usuario
	ADD CONSTRAINT UQ_TB_Adm_Usuario_id_user UNIQUE (id_user)
;

ALTER TABLE TB_Adm_Usuario_OpcionesSistema
	ADD CONSTRAINT UQ_Usuario_OpcionesSistema_id_userOpciones UNIQUE (id_userOpciones)
;

ALTER TABLE TB_Adm_Usuario_Roles
	ADD CONSTRAINT UQ_Usuario_Roles_id_userRoles UNIQUE (id_userRoles)
;


--  Create Foreign Key Constraints 
ALTER TABLE TB_Adm_Contenido ADD CONSTRAINT FK_TB_Adm_Contenido_TB_Adm_Sesion 
	FOREIGN KEY (id_sesion) REFERENCES TB_Adm_Sesion (id_sesion)
;

ALTER TABLE TB_Adm_Contenido ADD CONSTRAINT FK_TB_Adm_Contenido_TB_Adm_Usuario 
	FOREIGN KEY (id_user) REFERENCES TB_Adm_Usuario (id_user)
;

ALTER TABLE TB_Adm_Sesion ADD CONSTRAINT FK_TB_Adm_Sesion_TB_Adm_Usuario 
	FOREIGN KEY (id_user) REFERENCES TB_Adm_Usuario (id_user)
;

ALTER TABLE TB_Adm_Usuario_OpcionesSistema ADD CONSTRAINT FK_Usuario_OpcionesSistema_TB_Adm_OpcionesSistema 
	FOREIGN KEY (id_opciones) REFERENCES TB_Adm_OpcionesSistema (id_opciones)
;

ALTER TABLE TB_Adm_Usuario_OpcionesSistema ADD CONSTRAINT FK_Usuario_OpcionesSistema_TB_Adm_Usuario 
	FOREIGN KEY (id_user) REFERENCES TB_Adm_Usuario (id_user)
;

ALTER TABLE TB_Adm_Usuario_Roles ADD CONSTRAINT FK_Usuario_Roles_TB_Adm_RolesDeUsuario 
	FOREIGN KEY (id_rolUsuario) REFERENCES TB_Adm_RolesDeUsuario (id_rolUsuario)
;

ALTER TABLE TB_Adm_Usuario_Roles ADD CONSTRAINT FK_Usuario_Roles_TB_Adm_Usuario 
	FOREIGN KEY (id_user) REFERENCES TB_Adm_Usuario (id_user)
;
