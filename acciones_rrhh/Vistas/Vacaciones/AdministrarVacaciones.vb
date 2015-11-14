Namespace Vistas
    Public Class AdministrarVacaciones
        Private Sub UpdateDataGridV()
            Using context As New DB_Recursos_HumanosEntities
                Dim empVList = (From emp In context.Empleadoes Join v In context.vacaciones On emp.Id_Empleado Equals v.Id_Empleado Where v.aceptado = False Select emp.Nombre, emp.Apellido, emp.Cedula, v.fecha_inicio, v.fecha_fin, v.id).ToList
                DataGridView1.DataSource = empVList
            End Using
        End Sub
        Private Sub AdministrarVacaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            UpdateDataGridV()
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
                        Dim vac = context.vacaciones.Find(vid)
                        vac.aceptado = True
                        context.SaveChanges()
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

