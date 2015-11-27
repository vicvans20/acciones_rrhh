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
            Me.dtFiltroInicio = New System.Windows.Forms.DateTimePicker()
            Me.dtFiltroFin = New System.Windows.Forms.DateTimePicker()
            Me.btBuscar = New System.Windows.Forms.Button()
            Me.CheckBox1 = New System.Windows.Forms.CheckBox()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
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
            Me.DataGridView1.Location = New System.Drawing.Point(136, 192)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(595, 302)
            Me.DataGridView1.TabIndex = 1
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(368, 176)
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
            'dtFiltroInicio
            '
            Me.dtFiltroInicio.Location = New System.Drawing.Point(136, 104)
            Me.dtFiltroInicio.Name = "dtFiltroInicio"
            Me.dtFiltroInicio.Size = New System.Drawing.Size(200, 20)
            Me.dtFiltroInicio.TabIndex = 5
            Me.dtFiltroInicio.Value = New Date(2015, 11, 27, 0, 0, 0, 0)
            '
            'dtFiltroFin
            '
            Me.dtFiltroFin.Location = New System.Drawing.Point(531, 104)
            Me.dtFiltroFin.Name = "dtFiltroFin"
            Me.dtFiltroFin.Size = New System.Drawing.Size(200, 20)
            Me.dtFiltroFin.TabIndex = 6
            Me.dtFiltroFin.Value = New Date(2015, 11, 27, 0, 0, 0, 0)
            '
            'btBuscar
            '
            Me.btBuscar.Location = New System.Drawing.Point(371, 132)
            Me.btBuscar.Name = "btBuscar"
            Me.btBuscar.Size = New System.Drawing.Size(114, 23)
            Me.btBuscar.TabIndex = 7
            Me.btBuscar.Text = "Buscar"
            Me.btBuscar.UseVisualStyleBackColor = True
            '
            'CheckBox1
            '
            Me.CheckBox1.AutoSize = True
            Me.CheckBox1.Location = New System.Drawing.Point(381, 109)
            Me.CheckBox1.Name = "CheckBox1"
            Me.CheckBox1.Size = New System.Drawing.Size(104, 17)
            Me.CheckBox1.TabIndex = 8
            Me.CheckBox1.Text = "Filtrar por fechas"
            Me.CheckBox1.UseVisualStyleBackColor = True
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(203, 88)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(38, 13)
            Me.Label3.TabIndex = 9
            Me.Label3.Text = "Desde"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(620, 88)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(35, 13)
            Me.Label4.TabIndex = 10
            Me.Label4.Text = "Hasta"
            '
            'Reporte_Vacaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(851, 506)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.CheckBox1)
            Me.Controls.Add(Me.btBuscar)
            Me.Controls.Add(Me.dtFiltroFin)
            Me.Controls.Add(Me.dtFiltroInicio)
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
        Friend WithEvents dtFiltroInicio As System.Windows.Forms.DateTimePicker
        Friend WithEvents dtFiltroFin As System.Windows.Forms.DateTimePicker
        Friend WithEvents btBuscar As System.Windows.Forms.Button
        Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
    End Class
End Namespace