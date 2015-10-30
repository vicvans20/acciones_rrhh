Namespace Vistas
    Public Class RegistrarEmpleado

        Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
            Using context As New rrhhEntities
                Dim emp As New empleado
                emp.primer_nombre = tbNombre.Text
                emp.apellidos = tbApellidos.Text
                emp.cedula = tbCedula.Text
                emp.telefono = tbTelefono.Text
                emp.departamento = tbDepartamento.Text
                emp.cargo = tbCargo.Text
                emp.salario = nSalario.Value
                emp.inss = tbInss.Text
                emp.fecha_contratacion = Date.Today
                context.empleados.Add(emp)
                context.SaveChanges()
            End Using

        End Sub
    End Class
End Namespace