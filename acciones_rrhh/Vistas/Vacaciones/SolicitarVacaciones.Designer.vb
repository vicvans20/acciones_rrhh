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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.TextBox1 = New System.Windows.Forms.TextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.dateInicio = New System.Windows.Forms.MonthCalendar()
            Me.dateFin = New System.Windows.Forms.MonthCalendar()
            Me.cbPagada = New System.Windows.Forms.CheckBox()
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
            Me.bSend.Location = New System.Drawing.Point(378, 329)
            Me.bSend.Name = "bSend"
            Me.bSend.Size = New System.Drawing.Size(75, 23)
            Me.bSend.TabIndex = 1
            Me.bSend.Text = "Solicitar"
            Me.bSend.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(243, 106)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(65, 13)
            Me.Label1.TabIndex = 4
            Me.Label1.Text = "Fecha Inicio"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(505, 106)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 13)
            Me.Label2.TabIndex = 5
            Me.Label2.Text = "Fecha Fin"
            '
            'TextBox1
            '
            Me.TextBox1.Location = New System.Drawing.Point(525, 54)
            Me.TextBox1.Name = "TextBox1"
            Me.TextBox1.ReadOnly = True
            Me.TextBox1.Size = New System.Drawing.Size(124, 20)
            Me.TextBox1.TabIndex = 7
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(470, 57)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(34, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Saldo"
            '
            'dateInicio
            '
            Me.dateInicio.Location = New System.Drawing.Point(175, 128)
            Me.dateInicio.MaxSelectionCount = 1
            Me.dateInicio.Name = "dateInicio"
            Me.dateInicio.TabIndex = 9
            '
            'dateFin
            '
            Me.dateFin.Location = New System.Drawing.Point(422, 128)
            Me.dateFin.MaxSelectionCount = 1
            Me.dateFin.Name = "dateFin"
            Me.dateFin.TabIndex = 10
            '
            'cbPagada
            '
            Me.cbPagada.AutoSize = True
            Me.cbPagada.Location = New System.Drawing.Point(378, 303)
            Me.cbPagada.Name = "cbPagada"
            Me.cbPagada.Size = New System.Drawing.Size(74, 17)
            Me.cbPagada.TabIndex = 11
            Me.cbPagada.Text = "Pagadas?"
            Me.cbPagada.UseVisualStyleBackColor = True
            '
            'Solicitar_Vacaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(838, 364)
            Me.Controls.Add(Me.cbPagada)
            Me.Controls.Add(Me.dateFin)
            Me.Controls.Add(Me.dateInicio)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.TextBox1)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.bSend)
            Me.Controls.Add(Me.cbEmpleados)
            Me.Name = "Solicitar_Vacaciones"
            Me.Text = "Solicitar Vacaciones"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
        Friend WithEvents bSend As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dateInicio As System.Windows.Forms.MonthCalendar
        Friend WithEvents dateFin As System.Windows.Forms.MonthCalendar
        Friend WithEvents cbPagada As System.Windows.Forms.CheckBox
    End Class
End Namespace
