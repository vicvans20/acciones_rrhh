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

Partial Public Class TB_PRESTAMO
    Public Property id_prestamo As Integer
    Public Property id_estado As Integer
    Public Property id_plazo_pago As Integer
    Public Property fecha_inicio As Date
    Public Property fecha_final As Date
    Public Property monto_prestado As Double
    Public Property Id_Empleado As Integer

    Public Overridable Property Empleado As Empleado
    Public Overridable Property TB_CUOTA As ICollection(Of TB_CUOTA) = New HashSet(Of TB_CUOTA)
    Public Overridable Property TB_ESTADO As TB_ESTADO
    Public Overridable Property TB_PLAZO_PAGO As TB_PLAZO_PAGO
    Public Overridable Property TB_PLAZO_PAGO1 As TB_PLAZO_PAGO
    Public Overridable Property TB_RECIBO_CUOTA As ICollection(Of TB_RECIBO_CUOTA) = New HashSet(Of TB_RECIBO_CUOTA)

End Class