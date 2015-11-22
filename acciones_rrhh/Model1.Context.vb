﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class DB_Recursos_HumanosEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=DB_Recursos_HumanosEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Antecedentes() As DbSet(Of Antecedentes)
    Public Overridable Property area() As DbSet(Of area)
    Public Overridable Property Candidato() As DbSet(Of Candidato)
    Public Overridable Property capacitacion() As DbSet(Of capacitacion)
    Public Overridable Property Cargo() As DbSet(Of Cargo)
    Public Overridable Property centro_capacit() As DbSet(Of centro_capacit)
    Public Overridable Property Contrato() As DbSet(Of Contrato)
    Public Overridable Property Debilidades() As DbSet(Of Debilidades)
    Public Overridable Property DetEspecialidadesCand() As DbSet(Of DetEspecialidadesCand)
    Public Overridable Property DetEspecialidadesReq() As DbSet(Of DetEspecialidadesReq)
    Public Overridable Property DetIdiomasCand() As DbSet(Of DetIdiomasCand)
    Public Overridable Property DetIdiomasReq() As DbSet(Of DetIdiomasReq)
    Public Overridable Property Documentacion() As DbSet(Of Documentacion)
    Public Overridable Property Empleado() As DbSet(Of Empleado)
    Public Overridable Property encuesta() As DbSet(Of encuesta)
    Public Overridable Property entradas() As DbSet(Of entradas)
    Public Overridable Property Especialidades() As DbSet(Of Especialidades)
    Public Overridable Property EspecialidadesReq() As DbSet(Of EspecialidadesReq)
    Public Overridable Property Fortalezas() As DbSet(Of Fortalezas)
    Public Overridable Property Idiomas() As DbSet(Of Idiomas)
    Public Overridable Property IdiomasRequeridos() As DbSet(Of IdiomasRequeridos)
    Public Overridable Property Indicadores() As DbSet(Of Indicadores)
    Public Overridable Property Informacion_Academica() As DbSet(Of Informacion_Academica)
    Public Overridable Property liquidaciones() As DbSet(Of liquidaciones)
    Public Overridable Property Niveles_Evaluativos() As DbSet(Of Niveles_Evaluativos)
    Public Overridable Property Oficina() As DbSet(Of Oficina)
    Public Overridable Property permisos() As DbSet(Of permisos)
    Public Overridable Property plan_estudio() As DbSet(Of plan_estudio)
    Public Overridable Property pregunta() As DbSet(Of pregunta)
    Public Overridable Property Profesiones() As DbSet(Of Profesiones)
    Public Overridable Property respuesta() As DbSet(Of respuesta)
    Public Overridable Property Resultados() As DbSet(Of Resultados)
    Public Overridable Property salidas() As DbSet(Of salidas)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property TB_Adm_Contenido() As DbSet(Of TB_Adm_Contenido)
    Public Overridable Property TB_Adm_OpcionesSistema() As DbSet(Of TB_Adm_OpcionesSistema)
    Public Overridable Property TB_Adm_RolesDeUsuario() As DbSet(Of TB_Adm_RolesDeUsuario)
    Public Overridable Property TB_Adm_Sesion() As DbSet(Of TB_Adm_Sesion)
    Public Overridable Property TB_Adm_Usuario() As DbSet(Of TB_Adm_Usuario)
    Public Overridable Property TB_Adm_Usuario_OpcionesSistema() As DbSet(Of TB_Adm_Usuario_OpcionesSistema)
    Public Overridable Property TB_Adm_Usuario_Roles() As DbSet(Of TB_Adm_Usuario_Roles)
    Public Overridable Property TB_CUOTA() As DbSet(Of TB_CUOTA)
    Public Overridable Property TB_DEDUCCION() As DbSet(Of TB_DEDUCCION)
    Public Overridable Property TB_DEVENGADO() As DbSet(Of TB_DEVENGADO)
    Public Overridable Property TB_ESTADO() As DbSet(Of TB_ESTADO)
    Public Overridable Property TB_MOVIMIENTO_DEDUCCION() As DbSet(Of TB_MOVIMIENTO_DEDUCCION)
    Public Overridable Property TB_MOVIMIENTO_DEVENGADO() As DbSet(Of TB_MOVIMIENTO_DEVENGADO)
    Public Overridable Property TB_PLAZO_PAGO() As DbSet(Of TB_PLAZO_PAGO)
    Public Overridable Property TB_PRESTAMO() As DbSet(Of TB_PRESTAMO)
    Public Overridable Property TB_RECIBO_CUOTA() As DbSet(Of TB_RECIBO_CUOTA)
    Public Overridable Property tema() As DbSet(Of tema)
    Public Overridable Property tema_plan() As DbSet(Of tema_plan)
    Public Overridable Property vacaciones() As DbSet(Of vacaciones)
    Public Overridable Property Vacantes() As DbSet(Of Vacantes)

    Public Overridable Function sp_alterdiagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_creatediagram(diagramname As String, owner_id As Nullable(Of Integer), version As Nullable(Of Integer), definition As Byte()) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim versionParameter As ObjectParameter = If(version.HasValue, New ObjectParameter("version", version), New ObjectParameter("version", GetType(Integer)))

        Dim definitionParameter As ObjectParameter = If(definition IsNot Nothing, New ObjectParameter("definition", definition), New ObjectParameter("definition", GetType(Byte())))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter)
    End Function

    Public Overridable Function sp_dropdiagram(diagramname As String, owner_id As Nullable(Of Integer)) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagramdefinition(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagramdefinition_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagramdefinition_Result)("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_helpdiagrams(diagramname As String, owner_id As Nullable(Of Integer)) As ObjectResult(Of sp_helpdiagrams_Result)
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of sp_helpdiagrams_Result)("sp_helpdiagrams", diagramnameParameter, owner_idParameter)
    End Function

    Public Overridable Function sp_renamediagram(diagramname As String, owner_id As Nullable(Of Integer), new_diagramname As String) As Integer
        Dim diagramnameParameter As ObjectParameter = If(diagramname IsNot Nothing, New ObjectParameter("diagramname", diagramname), New ObjectParameter("diagramname", GetType(String)))

        Dim owner_idParameter As ObjectParameter = If(owner_id.HasValue, New ObjectParameter("owner_id", owner_id), New ObjectParameter("owner_id", GetType(Integer)))

        Dim new_diagramnameParameter As ObjectParameter = If(new_diagramname IsNot Nothing, New ObjectParameter("new_diagramname", new_diagramname), New ObjectParameter("new_diagramname", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter)
    End Function

    Public Overridable Function sp_upgraddiagrams() As Integer
        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction("sp_upgraddiagrams")
    End Function

End Class
