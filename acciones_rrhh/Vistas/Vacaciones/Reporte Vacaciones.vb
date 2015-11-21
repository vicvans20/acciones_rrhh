Public Class Reporte_Vacaciones

    Private Sub Reporte_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using context As New DB_Recursos_HumanosEntities
            Dim empList = (From emp In context.Empleadoes Select New With {.id = emp.Id_Empleado, .nombreC = emp.Nombre & " " & emp.Apellido}).ToList
            cbEmpleados.DataSource = empList
            cbEmpleados.DisplayMember = "nombreC"
            cbEmpleados.ValueMember = "id"
        End Using
    End Sub
End Class