Namespace Vistas
    Public Class Solicitar_Vacaciones

        Private Sub Solicitar_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New rrhhEntities
                Dim empList = (From emp In context.empleados Select emp.primer_nombre, emp.apellidos, emp.id).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "primer_nombre"
                cbEmpleados.ValueMember = "id"
            End Using
        End Sub

        Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
            Using context As New rrhhEntities
                Dim vac As New vacacione
                vac.fecha_inicio = dateInicio.Value
                vac.fecha_fin = dateFin.Value
                vac.id_emp = cbEmpleados.SelectedValue
                vac.fecha_creacion = Today
                context.vacaciones.Add(vac)
                Try
                    context.SaveChanges()
                    MessageBox.Show("Solicitud guardada")
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End Using
        End Sub
    End Class
End Namespace