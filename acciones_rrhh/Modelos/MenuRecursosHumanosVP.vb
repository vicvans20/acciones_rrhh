Public Class MenuRecursosHumanosVP
    Inherits ToolStripMenuItem
    Friend WithEvents AccionesRRHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SolicitarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PermisoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VacacionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public Sub New()
        Me.AccionesRRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PermisoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VacacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()

        Me.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VacacionesToolStripMenuItem, Me.PermisosToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.Name = "AccionesRRHHToolStripMenuItem"
        Me.Size = New System.Drawing.Size(102, 20)
        Me.Text = "Acciones RRHH"

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
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PermisoToolStripMenuItem, Me.VacacionToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'PermisoToolStripMenuItem
        '
        Me.PermisoToolStripMenuItem.Name = "PermisoToolStripMenuItem"
        Me.PermisoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.PermisoToolStripMenuItem.Text = "Permiso"
        '
        'VacacionToolStripMenuItem
        '
        Me.VacacionToolStripMenuItem.Name = "VacacionToolStripMenuItem"
        Me.VacacionToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VacacionToolStripMenuItem.Text = "Vacacion"
    End Sub

    'Events
    Private Sub SolicitarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitarVacacionesToolStripMenuItem.Click
        Dim solicitarVacaciones As New Vistas.Solicitar_Vacaciones()
        solicitarVacaciones.MdiParent = Me.Parent.FindForm
        solicitarVacaciones.Show()
    End Sub

    Private Sub AdministrarVacacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministrarVacacionesToolStripMenuItem.Click
        Dim administrarVacaciones As New Vistas.AdministrarVacaciones()
        administrarVacaciones.MdiParent = Me.Parent.FindForm
        administrarVacaciones.Show()
    End Sub

    Private Sub PermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisosToolStripMenuItem.Click
        Dim registrarPermisos As New Vistas.RegistrarPermisos()
        registrarPermisos.MdiParent = Me.Parent.FindForm
        registrarPermisos.Show()
    End Sub

    Private Sub ReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteToolStripMenuItem.Click
        Dim reporteV As New Vistas.Reporte_Vacaciones
        reporteV.MdiParent = Me.Parent.FindForm
        reporteV.Show()
    End Sub

    Private Sub PermisoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PermisoToolStripMenuItem.Click
        Dim reporteP As New Vistas.ReportePermiso
        reporteP.MdiParent = Me.Parent.FindForm
        reporteP.Show()
    End Sub

    Private Sub VacacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VacacionToolStripMenuItem.Click
        Dim reporteV As New Vistas.ReporteV
        reporteV.MdiParent = Me.Parent.FindForm
        reporteV.Show()
    End Sub
End Class
