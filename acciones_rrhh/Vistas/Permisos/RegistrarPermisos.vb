Namespace Vistas
    Public Class RegistrarPermisos

        Private Sub RegistrarPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities
                Dim empList = (From emp In context.Empleadoes Select emp.Nombre, emp.Apellido, emp.Id_Empleado).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "Nombre"
                cbEmpleados.ValueMember = "Id_Empleado"
            End Using
            Dim categories() As String = {"Permiso Administrativo", "Permiso Especial", "Subsidio"}
            Dim categoryList As New Generic.List(Of String)(categories)
            ComboBox1.DataSource = categoryList
        End Sub

        Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
            If (Me.dtInicio.Value > Me.dtFin.Value) Then
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.")
                Return
            End If
            Using context As New DB_Recursos_HumanosEntities
                Dim p As New permiso
                p.fecha_inicio = dtInicio.Value
                p.fecha_fin = dtFin.Value
                p.descripcion = RichTextBox1.Text
                p.categoria = ComboBox1.SelectedValue
                p.Id_Empleado = cbEmpleados.SelectedValue
                p.fecha_creacion = Today
                Try
                    context.permisos.Add(p)
                    context.SaveChanges()
                    MessageBox.Show("Solicitud guardada")
                Catch ex As Exception
                    MessageBox.Show("Hubo un error, porfavor verifique que los datos estan correctos e intente de nuevo.")
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Sub
    End Class
End Namespace