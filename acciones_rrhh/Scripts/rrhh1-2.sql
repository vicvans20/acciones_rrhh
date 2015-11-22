/* acciones de rrhh changes 
   Agregar campo de pagado(bit) a vacaciones*/
use DB_Recursos_Humanos
alter table vacaciones
ADD pagado bit NOT NULL constraint vacaciones_pagado_default default 0
go
ADD pendiente_por_pagar bit NOT NULL constraint vacaciones_pendiente_pagado_default default 0
go