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
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
            Me.empEstadoCivil = New System.Windows.Forms.CheckBox()
            Me.empDomicilio = New System.Windows.Forms.TextBox()
            Me.Estado = New System.Windows.Forms.CheckBox()
            Me.empProfesion = New System.Windows.Forms.ComboBox()
            Me.empInfoAcademica = New System.Windows.Forms.ComboBox()
            Me.empAntecedente = New System.Windows.Forms.ComboBox()
            Me.empArea = New System.Windows.Forms.ComboBox()
            Me.empCargo = New System.Windows.Forms.ComboBox()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.Label11 = New System.Windows.Forms.Label()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'bGuardar
            '
            Me.bGuardar.Location = New System.Drawing.Point(319, 230)
            Me.bGuardar.Name = "bGuardar"
            Me.bGuardar.Size = New System.Drawing.Size(75, 23)
            Me.bGuardar.TabIndex = 0
            Me.bGuardar.Text = "Guardar"
            Me.bGuardar.UseVisualStyleBackColor = True
            '
            'tbNombre
            '
            Me.tbNombre.Location = New System.Drawing.Point(12, 33)
            Me.tbNombre.Name = "tbNombre"
            Me.tbNombre.Size = New System.Drawing.Size(196, 20)
            Me.tbNombre.TabIndex = 1
            '
            'tbApellidos
            '
            Me.tbApellidos.Location = New System.Drawing.Point(12, 85)
            Me.tbApellidos.Name = "tbApellidos"
            Me.tbApellidos.Size = New System.Drawing.Size(196, 20)
            Me.tbApellidos.TabIndex = 2
            '
            'tbCedula
            '
            Me.tbCedula.Location = New System.Drawing.Point(12, 131)
            Me.tbCedula.Name = "tbCedula"
            Me.tbCedula.Size = New System.Drawing.Size(196, 20)
            Me.tbCedula.TabIndex = 3
            '
            'tbTelefono
            '
            Me.tbTelefono.Location = New System.Drawing.Point(12, 180)
            Me.tbTelefono.Name = "tbTelefono"
            Me.tbTelefono.Size = New System.Drawing.Size(196, 20)
            Me.tbTelefono.TabIndex = 4
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(69, 9)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(44, 13)
            Me.Label1.TabIndex = 10
            Me.Label1.Text = "Nombre"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(69, 61)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(44, 13)
            Me.Label2.TabIndex = 11
            Me.Label2.Text = "Apellido"
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(73, 111)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(40, 13)
            Me.Label3.TabIndex = 12
            Me.Label3.Text = "Cedula"
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(69, 164)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(49, 13)
            Me.Label4.TabIndex = 13
            Me.Label4.Text = "Telefono"
            '
            'DataGridView1
            '
            Me.DataGridView1.AllowUserToAddRows = False
            Me.DataGridView1.AllowUserToDeleteRows = False
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(188, 269)
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(370, 171)
            Me.DataGridView1.TabIndex = 18
            '
            'DateTimePicker1
            '
            Me.DateTimePicker1.Location = New System.Drawing.Point(264, 33)
            Me.DateTimePicker1.Name = "DateTimePicker1"
            Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
            Me.DateTimePicker1.TabIndex = 19
            '
            'empEstadoCivil
            '
            Me.empEstadoCivil.AutoSize = True
            Me.empEstadoCivil.Location = New System.Drawing.Point(264, 85)
            Me.empEstadoCivil.Name = "empEstadoCivil"
            Me.empEstadoCivil.Size = New System.Drawing.Size(62, 17)
            Me.empEstadoCivil.TabIndex = 20
            Me.empEstadoCivil.Text = "Casado"
            Me.empEstadoCivil.UseVisualStyleBackColor = True
            '
            'empDomicilio
            '
            Me.empDomicilio.Location = New System.Drawing.Point(264, 131)
            Me.empDomicilio.Name = "empDomicilio"
            Me.empDomicilio.Size = New System.Drawing.Size(200, 20)
            Me.empDomicilio.TabIndex = 21
            '
            'Estado
            '
            Me.Estado.AutoSize = True
            Me.Estado.Location = New System.Drawing.Point(377, 85)
            Me.Estado.Name = "Estado"
            Me.Estado.Size = New System.Drawing.Size(59, 17)
            Me.Estado.TabIndex = 22
            Me.Estado.Text = "Estado"
            Me.Estado.UseVisualStyleBackColor = True
            '
            'empProfesion
            '
            Me.empProfesion.FormattingEnabled = True
            Me.empProfesion.Location = New System.Drawing.Point(264, 180)
            Me.empProfesion.Name = "empProfesion"
            Me.empProfesion.Size = New System.Drawing.Size(200, 21)
            Me.empProfesion.TabIndex = 23
            '
            'empInfoAcademica
            '
            Me.empInfoAcademica.FormattingEnabled = True
            Me.empInfoAcademica.Location = New System.Drawing.Point(487, 32)
            Me.empInfoAcademica.Name = "empInfoAcademica"
            Me.empInfoAcademica.Size = New System.Drawing.Size(200, 21)
            Me.empInfoAcademica.TabIndex = 24
            '
            'empAntecedente
            '
            Me.empAntecedente.FormattingEnabled = True
            Me.empAntecedente.Location = New System.Drawing.Point(487, 81)
            Me.empAntecedente.Name = "empAntecedente"
            Me.empAntecedente.Size = New System.Drawing.Size(200, 21)
            Me.empAntecedente.TabIndex = 25
            '
            'empArea
            '
            Me.empArea.FormattingEnabled = True
            Me.empArea.Location = New System.Drawing.Point(487, 130)
            Me.empArea.Name = "empArea"
            Me.empArea.Size = New System.Drawing.Size(200, 21)
            Me.empArea.TabIndex = 26
            '
            'empCargo
            '
            Me.empCargo.FormattingEnabled = True
            Me.empCargo.Location = New System.Drawing.Point(487, 180)
            Me.empCargo.Name = "empCargo"
            Me.empCargo.Size = New System.Drawing.Size(200, 21)
            Me.empCargo.TabIndex = 27
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(337, 9)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(44, 13)
            Me.Label5.TabIndex = 28
            Me.Label5.Text = "Nombre"
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Location = New System.Drawing.Point(332, 105)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(49, 13)
            Me.Label6.TabIndex = 29
            Me.Label6.Text = "Domicilio"
            '
            'Label7
            '
            Me.Label7.AutoSize = True
            Me.Label7.Location = New System.Drawing.Point(337, 154)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(51, 13)
            Me.Label7.TabIndex = 30
            Me.Label7.Text = "Profesion"
            '
            'Label8
            '
            Me.Label8.AutoSize = True
            Me.Label8.Location = New System.Drawing.Point(534, 9)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(118, 13)
            Me.Label8.TabIndex = 31
            Me.Label8.Text = "Información Acádemica"
            '
            'Label9
            '
            Me.Label9.AutoSize = True
            Me.Label9.Location = New System.Drawing.Point(570, 56)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(73, 13)
            Me.Label9.TabIndex = 32
            Me.Label9.Text = "Antecedentes"
            '
            'Label10
            '
            Me.Label10.AutoSize = True
            Me.Label10.Location = New System.Drawing.Point(570, 105)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(29, 13)
            Me.Label10.TabIndex = 33
            Me.Label10.Text = "Area"
            '
            'Label11
            '
            Me.Label11.AutoSize = True
            Me.Label11.Location = New System.Drawing.Point(570, 154)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(35, 13)
            Me.Label11.TabIndex = 34
            Me.Label11.Text = "Cargo"
            '
            'RegistrarEmpleado
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(908, 452)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.empCargo)
            Me.Controls.Add(Me.empArea)
            Me.Controls.Add(Me.empAntecedente)
            Me.Controls.Add(Me.empInfoAcademica)
            Me.Controls.Add(Me.empProfesion)
            Me.Controls.Add(Me.Estado)
            Me.Controls.Add(Me.empDomicilio)
            Me.Controls.Add(Me.empEstadoCivil)
            Me.Controls.Add(Me.DateTimePicker1)
            Me.Controls.Add(Me.DataGridView1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.tbTelefono)
            Me.Controls.Add(Me.tbCedula)
            Me.Controls.Add(Me.tbApellidos)
            Me.Controls.Add(Me.tbNombre)
            Me.Controls.Add(Me.bGuardar)
            Me.Name = "RegistrarEmpleado"
            Me.Text = "RegistrarEmpleado"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents bGuardar As System.Windows.Forms.Button
        Friend WithEvents tbNombre As System.Windows.Forms.TextBox
        Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
        Friend WithEvents tbCedula As System.Windows.Forms.TextBox
        Friend WithEvents tbTelefono As System.Windows.Forms.TextBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
        Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
        Friend WithEvents empEstadoCivil As System.Windows.Forms.CheckBox
        Friend WithEvents empDomicilio As System.Windows.Forms.TextBox
        Friend WithEvents Estado As System.Windows.Forms.CheckBox
        Friend WithEvents empProfesion As System.Windows.Forms.ComboBox
        Friend WithEvents empInfoAcademica As System.Windows.Forms.ComboBox
        Friend WithEvents empAntecedente As System.Windows.Forms.ComboBox
        Friend WithEvents empArea As System.Windows.Forms.ComboBox
        Friend WithEvents empCargo As System.Windows.Forms.ComboBox
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
    End Class
End Namespace
