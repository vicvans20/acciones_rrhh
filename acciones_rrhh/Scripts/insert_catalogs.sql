use DB_Recursos_Humanos
insert into Profesiones (Profesion,Descripcion) values
('Ingeniero en Sistemas','Desarrollador de sistemas'),
('Diseñador','Diseño y maquetación'),
('Contador','Contaduria y finanzas')

insert into Antecedentes (Antecedente,Descripcion) values
('Nose que es esto','ok?'),
('Otro','mas')

insert into Oficina (Nombre, Descripcion) values
('Tecnologías y desarrollo','Tecnologías y soporte técnico'),
('Contabilidad','Contabilidad y finanzas')

insert into Cargo (Nombre_Cargo,Salario,Descripcion,Id_Oficina) values
('Análista de sistemas',1200,'Manejo de proyectos',1),
('Desarrollador',500,'Programación',1),
('Contador',300,'Contabilidad de transacciones',2)

insert into area (nombre) values
(1,'Informática'),
(2,'Finanzas'),
(3,'Gerencia')

insert into Informacion_Academica (Tipo_Estudio,Descripcion) values
('Universitario','Managua'),
('Maestría','Finanzas')