'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class entradas
    Public Property id As Integer
    Public Property Id_Empleado As Integer
    Public Property fecha As Date
    Public Property hora_marcado As System.TimeSpan
    Public Property timestamp As Byte()

    Public Overridable Property Empleado As Empleado
    Public Overridable Property salidas As ICollection(Of salidas) = New HashSet(Of salidas)

End Class