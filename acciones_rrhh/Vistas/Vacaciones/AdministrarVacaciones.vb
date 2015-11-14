Namespace Vistas
    Public Class AdministrarVacaciones
        Private Sub UpdateDataGridV()
            Using context As New DB_Recursos_HumanosEntities
                ' Solo las vacaciones cuya fecha de fin sea mayor que la fecha actual
                Dim empVList = (From emp In context.Empleadoes Join v In context.vacaciones On emp.Id_Empleado Equals v.Id_Empleado Where v.aceptado = False And v.fecha_fin > Date.Today Select emp.Nombre, emp.Apellido, emp.Cedula, v.fecha_inicio, v.fecha_fin, v.id).ToList
                DataGridView1.DataSource = empVList
            End Using
        End Sub
        Private Sub AdministrarVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Cargar registros de vacaciones disponibles para evaluar
            UpdateDataGridV()
            'Agregar icono para aceptar vacaciones
            Dim delbut As New DataGridViewImageColumn
            delbut.Image = My.Resources.icon
            delbut.Width = 50
            delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridView1.Columns.Add(delbut)
        End Sub

        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
            If ((e.ColumnIndex = 6) And (e.RowIndex >= 0)) Then
                Dim vid = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString)
                Dim result = MessageBox.Show("Aprobar vacación?", "Confirmation", MessageBoxButtons.OKCancel)
                If result = Windows.Forms.DialogResult.OK Then
                    Using context As New DB_Recursos_HumanosEntities
                        Try
                            Dim vac = context.vacaciones.Find(vid)
                            ' Si el empleado no tiene suficiente saldo para cumplir la vacacion
                            If (Modelos.VacacionModel.calcular_saldo_vacaciones(vac.Id_Empleado) <
                                (DateDiff(DateInterval.Day, vac.fecha_inicio, vac.fecha_fin))) Then
                                Throw New ArgumentException("El empleado no cuenta con suficiente saldo.")
                            End If
                            vac.aceptado = True
                            context.SaveChanges()
                            DataGridView1.CurrentCell = Nothing
                            DataGridView1.Rows(e.RowIndex).Visible = False
                            MessageBox.Show("Vacación aprobada exitosamente!")
                        Catch ex As ArgumentException
                            MessageBox.Show(ex.Message)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                        End Try
                    End Using
                Else
                End If
            End If
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Me.Close()
            Vistas.MenuPrincipal.Visible = True
        End Sub
    End Class
End Namespace

