
Namespace Vistas
    Public Class MenuPrincipal

        Private Sub EmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadoToolStripMenuItem.Click
            'Open the child form into parent Form
            Dim registrarEmpleado As New Vistas.RegistrarEmpleado()
            registrarEmpleado.MdiParent = Me
            registrarEmpleado.Show()
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
    End Class
End Namespace