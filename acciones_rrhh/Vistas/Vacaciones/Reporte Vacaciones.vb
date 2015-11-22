Namespace Vistas
    Public Class Reporte_Vacaciones
        Dim newC As New DataGridViewColumn
                
        Private Sub UpdateDataGridV(empId As Integer)
            Using context As New DB_Recursos_HumanosEntities
                'Dim vList = (From v In context.vacaciones Select v.id, v.fecha_fin, v.fecha_fin).ToList
                Dim vList = (From v In context.vacaciones Where v.Id_Empleado = empId Select New With {.FechaInicio = v.fecha_inicio, .FechaFin = v.fecha_fin}).ToList
                'DataGridView1.DataSource = Nothing
                DataGridView1.Columns.Clear()
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = vList
                'Luego de cada clear, agrega la columna para debito
                DataGridView1.Columns.Add(newC)
                For Each r As DataGridViewRow In DataGridView1.Rows
                    r.Cells(2).Value = DateDiff(DateInterval.Day, r.Cells(0).Value, r.Cells(1).Value)
                Next
            End Using
        End Sub
        Private Sub Reporte_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inicializa las caracteristicas de la columna de debito
            newC.Name = "Debitado"
            newC.CellTemplate = New DataGridViewTextBoxCell()

            Using context As New DB_Recursos_HumanosEntities
                Dim empList = (From emp In context.Empleadoes Select New With {.id = emp.Id_Empleado, .nombreC = emp.Nombre & " " & emp.Apellido}).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "nombreC"
                cbEmpleados.ValueMember = "id"
            End Using
        End Sub

        Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectionChangeCommitted
            UpdateDataGridV(cbEmpleados.SelectedValue)
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            MessageBox.Show(cbEmpleados.SelectedValue)
        End Sub
    End Class
End Namespace