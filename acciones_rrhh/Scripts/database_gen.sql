USE MASTER
GO
if db_id('rrhh') is not null
BEGIN
	drop database rrhh
END
create database rrhh
GO
use rrhh
CREATE TABLE empleados
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	primer_nombre varchar(40) NOT NULL,
	apellidos varchar(40) NOT NULL,
	cedula varchar(15) NOT NULL,
	telefono varchar(10),
	fecha_contratacion date NOT NULL,
	vacaciones_acumuladas float NOT NULL CONSTRAINT "empleados_vacaciones_default" DEFAULT 0,
	fecha_creacion datetime2 NOT NULL CONSTRAINT "empleados_fecha_creacion" DEFAULT GETDATE(),
	cargo varchar(20) NOT NULL,
	departamento varchar(20) NOT NULL,
	salario float NOT NULL,
	inss varchar(15) NOT NULL,
	timestamp
);

CREATE TABLE vacaciones
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	id_emp integer NOT NULL,
	fecha_creacion datetime2 NOT NULL CONSTRAINT "vacaciones_fecha_creacion" DEFAULT GETDATE(),
	fecha_inicio date NOT NULL,
	fecha_fin date NOT NULL,
	aceptado bit NOT NULL,
	FOREIGN KEY(id_emp) REFERENCES empleados(id),
	timestamp
);

CREATE TABLE permisos
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	id_emp integer NOT NULL,
	fecha_creacion datetime2 NOT NULL CONSTRAINT permisos_fecha_creacion DEFAULT GETDATE(),
	fecha_inicio date NOT NULL,
	fecha_fin date NOT NULL,
	descripcion text NOT NULL,
	categoria varchar(10) NOT NULL,
	FOREIGN KEY(id_emp) REFERENCES empleados(id),
	timestamp
);

CREATE TABLE entradas
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	id_emp integer NOT NULL,
	fecha date NOT NULL,
	hora_marcado time NOT NULL,
	FOREIGN KEY(id_emp) REFERENCES empleados(id),
	CONSTRAINT "entrada_por_dia" UNIQUE(id_emp,fecha),
	timestamp
);

CREATE TABLE salidas
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	id_emp integer NOT NULL,
	id_entrada integer NOT NULL,
	hora_marcado time NOT NULL,
	FOREIGN KEY(id_emp) REFERENCES empleados(id),
	FOREIGN KEY(id_entrada) REFERENCES entradas(id),
	timestamp
);

CREATE TABLE liquidaciones
(
	id integer IDENTITY(1,1) PRIMARY KEY,
	id_emp integer NOT NULL,
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
	FOREIGN KEY(id_emp) REFERENCES empleados(id),
	timestamp
);

CREATE INDEX emp_cedula ON empleados(cedula)
CREATE INDEX emp_fecha_contratacion ON empleados(fecha_contratacion)