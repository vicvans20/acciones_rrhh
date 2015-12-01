Namespace Vistas
    Public Class Reporte_Vacaciones
        Dim newC As New DataGridViewColumn
        Private Sub UpdateAvalaibleVacations(empId As Integer)
            Using context As New DB_Recursos_HumanosEntities1
                Me.tbVaA.Text = Modelos.VacacionModel.calcular_saldo_vacaciones(empId)
            End Using
        End Sub
        Private Sub UpdateDataGridV(empId As Integer, filter As Boolean, fStart As Date, fEnd As Date)
            Using context As New DB_Recursos_HumanosEntities1
                Dim vList
                MessageBox.Show(filter)
                MessageBox.Show(fStart)
                MessageBox.Show(fEnd)
                If filter = True Then
                    vList = (From v In context.vacaciones Where v.Id_Empleado = empId And v.fecha_inicio >= fStart And v.fecha_fin <= fEnd Select New With {.FechaInicio = v.fecha_inicio, .FechaFin = v.fecha_fin, .Pagado = v.pagado}).ToList
                Else
                    vList = (From v In context.vacaciones Where v.Id_Empleado = empId Select New With {.FechaInicio = v.fecha_inicio, .FechaFin = v.fecha_fin, .Pagado = v.pagado}).ToList
                End If
                DataGridView1.Columns.Clear()
                DataGridView1.AutoGenerateColumns = True
                DataGridView1.DataSource = vList
                'Luego de cada clear, agrega la columna para debito
                DataGridView1.Columns.Add(newC)
                For Each r As DataGridViewRow In DataGridView1.Rows
                    r.Cells(3).Value = DateDiff(DateInterval.Day, r.Cells(0).Value, r.Cells(1).Value) + 1
                Next
            End Using
        End Sub
        Private Sub Reporte_Vacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Inicializa las caracteristicas de la columna de debito
            newC.Name = "Debitado"
            newC.CellTemplate = New DataGridViewTextBoxCell()

            Using context As New DB_Recursos_HumanosEntities1
                Dim empList = (From emp In context.Empleado Select New With {.id = emp.Id_Empleado, .nombreC = emp.Nombre & " " & emp.Apellido}).ToList
                cbEmpleados.DataSource = empList
                cbEmpleados.DisplayMember = "nombreC"
                cbEmpleados.ValueMember = "id"
            End Using
            Me.tbVaA.Text = Modelos.VacacionModel.calcular_saldo_vacaciones(cbEmpleados.SelectedValue)
        End Sub

        Private Sub cbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpleados.SelectionChangeCommitted
            UpdateAvalaibleVacations(cbEmpleados.SelectedValue)
        End Sub

        Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
            UpdateDataGridV(cbEmpleados.SelectedValue, Me.CheckBox1.Checked, Me.dtFiltroInicio.Value, Me.dtFiltroFin.Value)
        End Sub
    End Class
End Namespace