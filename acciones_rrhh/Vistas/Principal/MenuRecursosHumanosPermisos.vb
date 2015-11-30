Public Class MenuRecursosHumanosPermisos
    Inherits ToolStripMenuItem
    Friend WithEvents AccionesRRHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public Sub New()
        Me.AccionesRRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        'AccionesRRHHToolStripMenuItem
        '
        Me.AccionesRRHHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VacacionesToolStripMenuItem, Me.PermisosToolStripMenuItem})
        Me.AccionesRRHHToolStripMenuItem.Name = "AccionesRRHHToolStripMenuItem"
        Me.AccionesRRHHToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.AccionesRRHHToolStripMenuItem.Text = "Acciones RRHH"
        '
        'VacacionesToolStripMenuItem
        '
        Me.VacacionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SolicitarVacacionesToolStripMenuItem, Me.AdministrarVacacionesToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.VacacionesToolStripMenuItem.Name = "VacacionesToolStripMenuItem"
        Me.VacacionesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VacacionesToolStripMenuItem.Text = "Vacaciones"
        '
        'SolicitarVacacionesToolStripMenuItem
        '
        Me.SolicitarVacacionesToolStripMenuItem.Name = "SolicitarVacacionesToolStripMenuItem"
        Me.SolicitarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SolicitarVacacionesToolStripMenuItem.Text = "Solicitar Vacaciones"
        '
        'AdministrarVacacionesToolStripMenuItem
        '
        Me.AdministrarVacacionesToolStripMenuItem.Name = "AdministrarVacacionesToolStripMenuItem"
        Me.AdministrarVacacionesToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.AdministrarVacacionesToolStripMenuItem.Text = "Administrar Vacaciones"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'PermisosToolStripMenuItem
        '
        Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
        Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PermisosToolStripMenuItem.Text = "Permisos"
    End Sub
    Public Sub SolicitarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarVacacionesToolStripMenuItem.Click
        Dim solicitarVacaciones As New Vistas.Solicitar_Vacaciones()
        solicitarVacaciones.MdiParent = Me.Parent.FindForm
        solicitarVacaciones.Show()
    End Sub

    Public Sub AdministrarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVacacionesToolStripMenuItem.Click
        Dim administrarVacaciones As New Vistas.AdministrarVacaciones()
        administrarVacaciones.MdiParent = Me.Parent.FindForm
        administrarVacaciones.Show()
    End Sub

    Public Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        Dim registrarPermisos As New Vistas.RegistrarPermisos()
        registrarPermisos.MdiParent = Me.Parent.FindForm
        registrarPermisos.Show()
    End Sub

    Public Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Dim reporteV As New Vistas.Reporte_Vacaciones
        reporteV.MdiParent = Me.Parent.FindForm
        reporteV.Show()
    End Sub
End Class
