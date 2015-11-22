Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Reporte_Vacaciones
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
            Me.cbEmpleados = New System.Windows.Forms.ComboBox()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.tbVaA = New System.Windows.Forms.TextBox()
            Me.Label2 = New System.Windows.Forms.Label()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cbEmpleados
            '
            Me.cbEmpleados.FormattingEnabled = True
            Me.cbEmpleados.Location = New System.Drawing.Point(136, 12)
            Me.cbEmpleados.Name = "cbEmpleados"
            Me.cbEmpleados.Size = New System.Drawing.Size(359, 21)
            Me.cbEmpleados.TabIndex = 0
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.AllowUserToResizeColumns = False
            Me.DataGridView1.AllowUserToResizeRows = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(136, 87)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(595, 295)
            Me.DataGridView1.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(378, 53)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(117, 13)
            Me.Label1.TabIndex = 2
            Me.Label1.Text = "Vacaciones Aprobadas"
            '
            'tbVaA
            '
            Me.tbVaA.Location = New System.Drawing.Point(584, 12)
            Me.tbVaA.Name = "tbVaA"
            Me.tbVaA.ReadOnly = True
            Me.tbVaA.Size = New System.Drawing.Size(147, 20)
            Me.tbVaA.TabIndex = 3
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(544, 15)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(34, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Saldo"
            '
            'Reporte_Vacaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(851, 407)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.tbVaA)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.DataGridView1)
            Me.Controls.Add(Me.cbEmpleados)
            Me.Name = "Reporte_Vacaciones"
            Me.Text = "Reporte_Vacaciones"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents tbVaA As System.Windows.Forms.TextBox
        Friend WithEvents Label2 As System.Windows.Forms.Label
    End Class
End Namespace