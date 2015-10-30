Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class RegistrarEmpleado
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
            Me.bGuardar = New System.Windows.Forms.Button()
            Me.tbNombre = New System.Windows.Forms.TextBox()
            Me.tbApellidos = New System.Windows.Forms.TextBox()
            Me.tbCedula = New System.Windows.Forms.TextBox()
            Me.tbTelefono = New System.Windows.Forms.TextBox()
            Me.tbDepartamento = New System.Windows.Forms.TextBox()
            Me.tbCargo = New System.Windows.Forms.TextBox()
            Me.tbInss = New System.Windows.Forms.TextBox()
            Me.nSalario = New System.Windows.Forms.NumericUpDown()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            CType(Me.nSalario, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bGuardar
            '
            Me.bGuardar.Location = New System.Drawing.Point(405, 227)
            Me.bGuardar.Name = "bGuardar"
            Me.bGuardar.Size = New System.Drawing.Size(75, 23)
            Me.bGuardar.TabIndex = 0
            Me.bGuardar.Text = "Guardar"
            Me.bGuardar.UseVisualStyleBackColor = True
            '
            'tbNombre
            '
            Me.tbNombre.Location = New System.Drawing.Point(291, 12)
            Me.tbNombre.Name = "tbNombre"
            Me.tbNombre.Size = New System.Drawing.Size(100, 20)
            Me.tbNombre.TabIndex = 1
            '
            'tbApellidos
            '
            Me.tbApellidos.Location = New System.Drawing.Point(291, 57)
            Me.tbApellidos.Name = "tbApellidos"
            Me.tbApellidos.Size = New System.Drawing.Size(100, 20)
            Me.tbApellidos.TabIndex = 2
            '
            'tbCedula
            '
            Me.tbCedula.Location = New System.Drawing.Point(291, 106)
            Me.tbCedula.Name = "tbCedula"
            Me.tbCedula.Size = New System.Drawing.Size(100, 20)
            Me.tbCedula.TabIndex = 3
            '
            'tbTelefono
            '
            Me.tbTelefono.Location = New System.Drawing.Point(291, 155)
            Me.tbTelefono.Name = "tbTelefono"
            Me.tbTelefono.Size = New System.Drawing.Size(100, 20)
            Me.tbTelefono.TabIndex = 4
            '
            'tbDepartamento
            '
            Me.tbDepartamento.Location = New System.Drawing.Point(482, 11)
            Me.tbDepartamento.Name = "tbDepartamento"
            Me.tbDepartamento.Size = New System.Drawing.Size(100, 20)
            Me.tbDepartamento.TabIndex = 5
            '
            'tbCargo
            '
            Me.tbCargo.Location = New System.Drawing.Point(482, 54)
            Me.tbCargo.Name = "tbCargo"
            Me.tbCargo.Size = New System.Drawing.Size(100, 20)
            Me.tbCargo.TabIndex = 6
            '
            'tbInss
            '
            Me.tbInss.Location = New System.Drawing.Point(482, 148)
            Me.tbInss.Name = "tbInss"
            Me.tbInss.Size = New System.Drawing.Size(100, 20)
            Me.tbInss.TabIndex = 8
            '
            'nSalario
            '
            Me.nSalario.Location = New System.Drawing.Point(482, 104)
            Me.nSalario.Name = "nSalario"
            Me.nSalario.Size = New System.Drawing.Size(100, 20)
            Me.nSalario.TabIndex = 9
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(225, 18)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Nombre"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(225, 60)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Apellido"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(225, 106)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(40, 13)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Cedula"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(225, 162)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(49, 13)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Telefono"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(402, 18)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(74, 13)
            Me.Label5.TabIndex = 14
            Me.Label5.Text = "Departamento"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(406, 60)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(35, 13)
            Me.Label6.TabIndex = 15
            Me.Label6.Text = "Cargo"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(406, 106)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(39, 13)
            Me.Label7.TabIndex = 16
            Me.Label7.Text = "Salario"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(402, 155)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(62, 13)
            Me.Label8.TabIndex = 17
            Me.Label8.Text = "Codigo Inss"
            '
            'RegistrarEmpleado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(908, 262)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.nSalario)
            Me.Controls.Add(Me.tbInss)
            Me.Controls.Add(Me.tbCargo)
            Me.Controls.Add(Me.tbDepartamento)
            Me.Controls.Add(Me.tbTelefono)
            Me.Controls.Add(Me.tbCedula)
            Me.Controls.Add(Me.tbApellidos)
            Me.Controls.Add(Me.tbNombre)
            Me.Controls.Add(Me.bGuardar)
            Me.Name = "RegistrarEmpleado"
            Me.Text = "RegistrarEmpleado"
            CType(Me.nSalario, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents bGuardar As System.Windows.Forms.Button
        Friend WithEvents tbNombre As System.Windows.Forms.TextBox
        Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
        Friend WithEvents tbCedula As System.Windows.Forms.TextBox
        Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
        Friend WithEvents tbDepartamento As System.Windows.Forms.TextBox
        Friend WithEvents tbCargo As System.Windows.Forms.TextBox
        Friend WithEvents tbInss As System.Windows.Forms.TextBox
        Friend WithEvents nSalario As System.Windows.Forms.NumericUpDown
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
    End Class
End Namespace
