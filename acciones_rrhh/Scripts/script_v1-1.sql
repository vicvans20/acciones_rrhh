/* rrhh version 1.1 changes 
CHANGELOG 
1.1V
 ->Tabla permisos
  - Cambio de tipo date a datetime2 en las columnas fecha_inicio y fecha_fin para permisos registrados en el mismo día
  - Columna categoria: cambiar extensión de varchar(10) a varchar(30)
*/
use rrhh
alter table permisos
alter column categoria nvarchar(30) not null
go
alter table permisos
alter column fecha_inicio datetime2 not null
go
alter table permisos
alter column fecha_fin datetime2 not null
go