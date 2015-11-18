Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RegistrarPermisos
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
            Me.dtInicio = New System.Windows.Forms.DateTimePicker()
            Me.dtFin = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.btsave = New System.Windows.Forms.Button()
            Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.ComboBox1 = New System.Windows.Forms.ComboBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'cbEmpleados
            '
            Me.cbEmpleados.FormattingEnabled = True
            Me.cbEmpleados.Location = New System.Drawing.Point(180, 12)
            Me.cbEmpleados.Name = "cbEmpleados"
            Me.cbEmpleados.Size = New System.Drawing.Size(444, 21)
            Me.cbEmpleados.TabIndex = 0
            '
            'dtInicio
            '
            Me.dtInicio.Location = New System.Drawing.Point(180, 75)
            Me.dtInicio.Name = "dtInicio"
            Me.dtInicio.Size = New System.Drawing.Size(200, 20)
            Me.dtInicio.TabIndex = 1
            '
            'dtFin
            '
            Me.dtFin.Location = New System.Drawing.Point(424, 75)
            Me.dtFin.Name = "dtFin"
            Me.dtFin.Size = New System.Drawing.Size(200, 20)
            Me.dtFin.TabIndex = 2
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(224, 56)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(105, 13)
            Me.Label1.TabIndex = 3
            Me.Label1.Text = "Desde (Día/Tiempo)"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(478, 56)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(102, 13)
            Me.Label2.TabIndex = 4
            Me.Label2.Text = "Hasta (Día/Tiempo)"
            '
            'btsave
            '
            Me.btsave.Location = New System.Drawing.Point(371, 272)
            Me.btsave.Name = "btsave"
            Me.btsave.Size = New System.Drawing.Size(75, 23)
            Me.btsave.TabIndex = 5
            Me.btsave.Text = "Registrar"
            Me.btsave.UseVisualStyleBackColor = True
            '
            'RichTextBox1
            '
            Me.RichTextBox1.Location = New System.Drawing.Point(180, 137)
            Me.RichTextBox1.Name = "RichTextBox1"
            Me.RichTextBox1.Size = New System.Drawing.Size(200, 96)
            Me.RichTextBox1.TabIndex = 7
            Me.RichTextBox1.Text = ""
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(246, 107)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(60, 13)
            Me.Label3.TabIndex = 8
            Me.Label3.Text = "Descipción"
            '
            'ComboBox1
            '
            Me.ComboBox1.FormattingEnabled = True
            Me.ComboBox1.Location = New System.Drawing.Point(424, 137)
            Me.ComboBox1.Name = "ComboBox1"
            Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
            Me.ComboBox1.TabIndex = 9
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(496, 107)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(54, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Categoría"
            '
            'RegistrarPermisos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(771, 322)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.ComboBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.RichTextBox1)
            Me.Controls.Add(Me.btsave)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtFin)
            Me.Controls.Add(Me.dtInicio)
            Me.Controls.Add(Me.cbEmpleados)
            Me.Name = "RegistrarPermisos"
            Me.Text = "Registrar Permisos"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cbEmpleados As System.Windows.Forms.ComboBox
        Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtFin As System.Windows.Forms.DateTimePicker
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents btsave As System.Windows.Forms.Button
        Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace