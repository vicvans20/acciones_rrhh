Namespace Vistas
    Public Class AdministrarVacaciones
        Private Sub UpdateDataGridV()
            Using context As New DB_Recursos_HumanosEntities1
                ' Solo las vacaciones cuya fecha de fin sea mayor que la fecha actual
                Dim empVList = (From emp In context.Empleado Join v In context.vacaciones On emp.Id_Empleado Equals v.Id_Empleado Where v.aceptado = False And v.fecha_fin > Date.Today Select v.id, emp.Nombre, emp.Apellido, emp.Cedula, v.fecha_inicio, v.fecha_fin, v.pagado).ToList
                DataGridView1.DataSource = empVList
                'Agregar icono para aceptar vacaciones
                Dim delbut As New DataGridViewImageColumn
                delbut.Image = My.Resources.icon
                delbut.Width = 50
                delbut.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                DataGridView1.Columns.Add(delbut)
            End Using
        End Sub
        Private Sub AdministrarVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            'Cargar registros de vacaciones disponibles para evaluar
            UpdateDataGridV()
        End Sub

        Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
            If ((e.ColumnIndex = 0) And (e.RowIndex >= 0)) Then
                Using context As New DB_Recursos_HumanosEntities1
                    Dim vid = Integer.Parse(DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString)
                    Dim vac = context.vacaciones.Find(vid)
                    MessageBox.Show("Se debitaran " + CType((DateDiff(DateInterval.Day, vac.fecha_inicio, vac.fecha_fin) + 1), String) + " días." +
                                   Environment.NewLine + "La persona cuenta con " + CType(Modelos.VacacionModel.calcular_saldo_vacaciones(vac.Id_Empleado), String) + " días disponibles.")
                    ' MessageBox.Show("La persona cuenta con " + CType(Modelos.VacacionModel.calcular_saldo_vacaciones(vac.Id_Empleado), String) + " días de vacaciones")
                    ' Si el empleado no tiene suficiente saldo para cumplir la vacacion
                    If (Modelos.VacacionModel.calcular_saldo_vacaciones(vac.Id_Empleado) <
                        (DateDiff(DateInterval.Day, vac.fecha_inicio, vac.fecha_fin)) + 1) Then
                        MessageBox.Show("El empleado no cuenta con suficiente saldo.")
                        Return
                    End If
                    Dim result = MessageBox.Show("Aprobar vacación?", "Confirmation", MessageBoxButtons.OKCancel)
                    If result = Windows.Forms.DialogResult.OK Then
                        Try
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

                    Else
                    End If
                End Using
            End If
        End Sub
    End Class
End Namespace

