use DB_Recursos_Humanos
insert into Profesiones (Profesion,Descripcion) values
('Ingeniero en Sistemas','Desarrollador de sistemas'),
('Dise�ador','Dise�o y maquetaci�n'),
('Contador','Contaduria y finanzas')

insert into Antecedentes (Antecedente,Descripcion) values
('Nose que es esto','ok?'),
('Otro','mas')

insert into Oficina (Nombre, Descripcion) values
('Tecnolog�as y desarrollo','Tecnolog�as y soporte t�cnico'),
('Contabilidad','Contabilidad y finanzas')

insert into Cargo (Nombre_Cargo,Salario,Descripcion,Id_Oficina) values
('An�lista de sistemas',1200,'Manejo de proyectos',1),
('Desarrollador',500,'Programaci�n',1),
('Contador',300,'Contabilidad de transacciones',2)

insert into area (nombre) values
(1,'Inform�tica'),
(2,'Finanzas'),
(3,'Gerencia')

insert into Informacion_Academica (Tipo_Estudio,Descripcion) values
('Universitario','Managua'),
('Maestr�a','Finanzas')