Namespace Modelos
    Public Class VacacionModel
        ' Calcula el saldo del empleado basado en sus vacaciones aprobadas.
        Public Shared Function calcular_saldo_vacaciones(eid As Integer)
            Using context As New DB_Recursos_HumanosEntities
                Dim emp As New Empleado
                emp = context.Empleado.Find(eid)
                Dim lc = emp.Contrato.Last.Fecha_Contratacion
                Dim vList = (From v In context.vacaciones Select v Where v.Id_Empleado = eid And v.aceptado = True And v.fecha_inicio > lc).ToList
                Dim vDebitado As Double = 0
                For Each v In vList
                    vDebitado = vDebitado + (DateDiff(DateInterval.Day, v.fecha_inicio, v.fecha_fin) + 1)
                Next
                Try
                    Dim vAcumulado = DateDiff(DateInterval.Month, CType(lc, Date), Date.Today) * 2.5
                    Dim saldo = vAcumulado - vDebitado
                    Return saldo
                Catch ex As System.InvalidOperationException
                    MessageBox.Show("Hubo un error, porfavor verifique que el empleado seleccionado tiene un contrato asociado.")
                Catch ex As Exception
                    MessageBox.Show("Hubo un error, porfavor verifique que todos los datos esten en orden e intente de nuevo.")
                End Try
                Return 0
            End Using
        End Function
    End Class
End Namespace
