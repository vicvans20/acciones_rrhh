Namespace Vistas
    Public Class RegistrarPermisos

        Private Sub RegistrarPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities1
                Dim empList = (From emp In context.Empleado Select New With {.id = emp.Id_Empleado, .nombreC = emp.Nombre & " " & emp.Apellido}).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "nombreC"
                cbEmpleados.ValueMember = "id"
            End Using
            Dim categories() As String = {"Permiso Administrativo", "Permiso Especial", "Subsidio"}
            Dim categoryList As New Generic.List(Of String)(categories)
            ComboBox1.DataSource = categoryList
        End Sub

        Private Sub btsave_Click(sender As Object, e As EventArgs) Handles btsave.Click
           
            ' Convert time and date to datetime
            Dim dtInicio As DateTime = Me.dtDInicio.Value.ToShortDateString
            dtInicio = dtInicio + dtTInicio.Value.TimeOfDay
            Dim dtFin As DateTime = Me.dtDFin.Value.ToShortDateString
            dtFin = dtFin + dtTFin.Value.TimeOfDay
            If (dtInicio >= dtFin) Then
                MessageBox.Show("La fecha de inicio no puede ser mayor o igual que la fecha de fin.")
                Return
            End If
            Using context As New DB_Recursos_HumanosEntities1
                Dim p As New permisos
                p.fecha_inicio = dtInicio
                p.fecha_fin = dtFin
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