Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MenuPrincipal
        Inherits System.Windows.Forms.Form

        'Form reemplaza a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Requerido por el Diseñador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Diseñador de Windows Forms.  
        'No lo modifique con el editor de código.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
            Me.NóminaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AccionesRRHHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.VacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SolicitarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AdministrarVacacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.PermisosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.MenuStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip1
            '
            Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
            Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NóminaToolStripMenuItem, Me.AccionesRRHHToolStripMenuItem, Me.AyudaToolStripMenuItem})
            Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip1.Name = "MenuStrip1"
            Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
            Me.MenuStrip1.TabIndex = 0
            Me.MenuStrip1.Text = "Acciones RRHH"
            '
            'NóminaToolStripMenuItem
            '
            Me.NóminaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadoToolStripMenuItem})
            Me.NóminaToolStripMenuItem.Name = "NóminaToolStripMenuItem"
            Me.NóminaToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
            Me.NóminaToolStripMenuItem.Text = "Nómina"
            '
            'EmpleadoToolStripMenuItem
            '
            Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
            Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
            Me.EmpleadoToolStripMenuItem.Text = "Empleado"
            '
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
            'PermisosToolStripMenuItem
            '
            Me.PermisosToolStripMenuItem.Name = "PermisosToolStripMenuItem"
            Me.PermisosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
            Me.PermisosToolStripMenuItem.Text = "Permisos"
            '
            'AyudaToolStripMenuItem
            '
            Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
            Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
            Me.AyudaToolStripMenuItem.Text = "Ayuda"
            '
            'ReporteToolStripMenuItem
            '
            Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
            Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
            Me.ReporteToolStripMenuItem.Text = "Reporte"
            '
            'MenuPrincipal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 438)
            Me.Controls.Add(Me.MenuStrip1)
            Me.IsMdiContainer = True
            Me.MainMenuStrip = Me.MenuStrip1
            Me.Name = "MenuPrincipal"
            Me.Text = "Acciones de Recursos Humanos"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip1.ResumeLayout(False)
            Me.MenuStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents NóminaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents EmpleadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AccionesRRHHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents VacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents SolicitarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AdministrarVacacionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents PermisosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents ReporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    End Class
End Namespace
