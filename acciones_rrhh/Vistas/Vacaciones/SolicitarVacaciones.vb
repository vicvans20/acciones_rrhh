Namespace Vistas
    Public Class Solicitar_Vacaciones
        ' Cargar combo box al iniciar el form
        Private Sub Solicitar_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities
                Dim empList = (From emp In context.Empleado Select New With {.id = emp.Id_Empleado, .nombreC = emp.Nombre & " " & emp.Apellido}).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "nombreC"
                cbEmpleados.ValueMember = "id"
            End Using
        End Sub
        ' Enviar solicitud
        Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
            If (Me.dateInicio.SelectionStart > Me.dateFin.SelectionStart) Then
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.")
                Return
            End If
            Dim sal = Modelos.VacacionModel.calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
            Try
                If DateDiff(DateInterval.Day, Me.dateInicio.SelectionStart, Me.dateFin.SelectionStart) + 1 > sal Then
                    Throw New ArgumentException("Su saldo de disponible no es suficiente para completar la solicitud.")
                End If
                Using context As New DB_Recursos_HumanosEntities
                    Dim vac As New vacaciones
                    vac.fecha_inicio = dateInicio.SelectionStart
                    vac.fecha_fin = dateFin.SelectionStart
                    vac.Id_Empleado = cbEmpleados.SelectedValue
                    vac.fecha_creacion = Today
                    context.vacaciones.Add(vac)
                    context.SaveChanges()
                    MessageBox.Show("Solicitud guardada")
                End Using
            Catch ex As ArgumentException
                MessageBox.Show(ex.Message)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectionChangeCommitted
            Me.TextBox1.Text = Modelos.VacacionModel.calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
        End Sub
    End Class
End Namespace