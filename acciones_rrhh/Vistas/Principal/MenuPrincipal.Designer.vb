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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(283, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(193, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "Menu Temporal de Acciones de RRHH"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(286, 83)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(190, 23)
            Me.Button1.TabIndex = 1
            Me.Button1.Text = "Solicitar Vacaciones"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(286, 133)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(190, 23)
            Me.Button2.TabIndex = 2
            Me.Button2.Text = "Manejar Vacaciones"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'MenuPrincipal
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 438)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label1)
            Me.Name = "MenuPrincipal"
            Me.Text = "Acciones de Recursos Humanos"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
    End Class
End Namespace
