Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Solicitar_Vacaciones
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
            Me.bSend = New System.Windows.Forms.Button()
            Me.dateInicio = New System.Windows.Forms.DateTimePicker()
            Me.dateFin = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            '
            'cbEmpleados
            '
            Me.cbEmpleados.FormattingEnabled = True
            Me.cbEmpleados.Location = New System.Drawing.Point(175, 27)
            Me.cbEmpleados.Name = "cbEmpleados"
            Me.cbEmpleados.Size = New System.Drawing.Size(474, 21)
            Me.cbEmpleados.TabIndex = 0
            '
            'bSend
            '
            Me.bSend.Location = New System.Drawing.Point(367, 209)
            Me.bSend.Name = "bSend"
            Me.bSend.Size = New System.Drawing.Size(75, 23)
            Me.bSend.TabIndex = 1
            Me.bSend.Text = "Solicitar"
            Me.bSend.UseVisualStyleBackColor = True
            '
            'dateInicio
            '
            Me.dateInicio.Location = New System.Drawing.Point(300, 78)
            Me.dateInicio.Name = "dateInicio"
            Me.dateInicio.Size = New System.Drawing.Size(220, 20)
            Me.dateInicio.TabIndex = 2
            '
            'dateFin
            '
            Me.dateFin.Location = New System.Drawing.Point(300, 117)
            Me.dateFin.Name = "dateFin"
            Me.dateFin.Size = New System.Drawing.Size(220, 20)
            Me.dateFin.TabIndex = 3
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(386, 55)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(65, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Fecha Inicio"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(386, 101)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Fecha Fin"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(673, 27)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(153, 23)
            Me.Button1.TabIndex = 6
            Me.Button1.Text = "Saldo de vacaciones"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Solicitar_Vacaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(838, 321)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dateFin)
            Me.Controls.Add(Me.dateInicio)
            Me.Controls.Add(Me.bSend)
            Me.Controls.Add(Me.cbEmpleados)
            Me.Name = "Solicitar_Vacaciones"
            Me.Text = "Solicitar Vacaciones"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
        Friend WithEvents bSend As System.Windows.Forms.Button
        Friend WithEvents dateInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dateFin As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Button1 As System.Windows.Forms.Button
    End Class
End Namespace
