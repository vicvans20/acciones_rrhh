Namespace Vistas
    Public Class Solicitar_Vacaciones
        Private Function calcular_saldo_vacaciones(eid As Integer)
            Using context As New DB_Recursos_HumanosEntities
                Dim emp As New Empleado
                emp = context.Empleadoes.Find(eid)
                'emp = From e In context.empleados Select e Where e.id = 1
                Dim vList = (From v In context.vacaciones Select v Where v.Id_Empleado = eid).ToList
                Dim vDebitado As Double = 0
                For Each v In vList
                    vDebitado = vDebitado + DateDiff(DateInterval.Day, v.fecha_inicio, v.fecha_fin)
                Next
                Dim vAcumulado = DateDiff(DateInterval.Month, emp.FechaNacimiento, Date.Today) * 2.5
                Dim saldo = vAcumulado - vDebitado
                Return saldo
            End Using
        End Function
        Private Sub Solicitar_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities
                Dim empList = (From emp In context.Empleadoes Select emp.Nombre, emp.Apellido, emp.Id_Empleado).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "primer_nombre"
                cbEmpleados.ValueMember = "id"
            End Using
        End Sub

        Private Sub bSend_Click(sender As Object, e As EventArgs) Handles bSend.Click
            Using context As New DB_Recursos_HumanosEntities
                Dim vac As New vacacione
                vac.fecha_inicio = dateInicio.Value
                vac.fecha_fin = dateFin.Value
                vac.Id_Empleado = cbEmpleados.SelectedValue
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

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Dim sal = calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
            MessageBox.Show(CType(sal, String) + " dias")
        End Sub
    End Class
End Namespace