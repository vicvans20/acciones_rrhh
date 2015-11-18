Namespace Vistas
    Public Class Solicitar_Vacaciones
        ' Cargar combo box al iniciar el form
        Private Sub Solicitar_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities
                Dim empList = (From emp In context.Empleadoes Select emp.Nombre, emp.Apellido, emp.Id_Empleado).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "Nombre"
                cbEmpleados.ValueMember = "Id_Empleado"
            End Using
        End Sub
        ' Enviar solicitud
        Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
            If (Me.dateInicio.Value > Me.dateFin.Value) Then
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.")
                Return
            End If
            Dim sal = Modelos.VacacionModel.calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
            Try
                If DateDiff(DateInterval.Day, Me.dateInicio.Value, Me.dateFin.Value) > sal Then
                    Throw New ArgumentException("Su saldo de disponible no es suficiente para completar la solicitud.")
                End If
                Using context As New DB_Recursos_HumanosEntities
                    Dim vac As New vacacione
                    vac.fecha_inicio = dateInicio.Value
                    vac.fecha_fin = dateFin.Value
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
        ' Retorna el saldo disponible
        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim sal = Modelos.VacacionModel.calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
            MessageBox.Show(CType(sal, String) + " dias")
        End Sub
    End Class
End Namespace