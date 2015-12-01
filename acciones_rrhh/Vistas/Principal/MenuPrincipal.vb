
Namespace Vistas
    Public Class MenuPrincipal

        Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End Sub

        Private Sub SolicitarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarVacacionesToolStripMenuItem.Click
            Dim solicitarVacaciones As New Vistas.Solicitar_Vacaciones()
            solicitarVacaciones.MdiParent = Me
            solicitarVacaciones.Show()
        End Sub

        Private Sub AdministrarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVacacionesToolStripMenuItem.Click
            Dim administrarVacaciones As New Vistas.AdministrarVacaciones()
            administrarVacaciones.MdiParent = Me
            administrarVacaciones.Show()
        End Sub

        Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
            Dim registrarPermisos As New Vistas.RegistrarPermisos()
            registrarPermisos.MdiParent = Me
            registrarPermisos.Show()
        End Sub

        Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
            Dim reporteV As New Vistas.Reporte_Vacaciones
            reporteV.MdiParent = Me
            reporteV.Show()
        End Sub

        Private Sub PermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisoToolStripMenuItem.Click
            Dim reporteP As New Vistas.ReportePermiso
            reporteP.MdiParent = Me
            reporteP.Show()
        End Sub

        Private Sub VacacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacacionToolStripMenuItem.Click
            Dim reporteV As New Vistas.ReporteV
            reporteV.MdiParent = Me
            reporteV.Show()
        End Sub
    End Class
End Namespace