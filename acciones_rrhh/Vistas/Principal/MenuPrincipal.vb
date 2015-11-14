
Namespace Vistas
    Public Class MenuPrincipal

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
            Me.Visible = False
            Vistas.Solicitar_Vacaciones.ShowDialog()
        End Sub

        Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
            Me.Visible = False
            Vistas.AdministrarVacaciones.Show()
        End Sub
    End Class
End Namespace