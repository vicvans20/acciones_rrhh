Namespace Vistas
    Public Class RegistrarEmpleado
        Private Sub UpdateDataGrid(ByVal context As rrhhEntities, ByVal dg As DataGridView)
            Dim empList = (From emp In context.empleados Select emp.cedula, emp.primer_nombre, emp.apellidos, emp.salario).ToList
            dg.DataSource = empList
        End Sub
        Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New rrhhEntities
                UpdateDataGrid(context, Me.DataGridView1)
            End Using
        End Sub
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
                UpdateDataGrid(context, Me.DataGridView1)
            End Using
        End Sub
    End Class
End Namespace