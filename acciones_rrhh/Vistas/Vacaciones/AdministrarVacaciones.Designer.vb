﻿Namespace Vistas
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class AdministrarVacaciones
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
            Me.DataGridView1 = New System.Windows.Forms.DataGridView()
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataGridView1
            '
            Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DataGridView1.Location = New System.Drawing.Point(26, 12)
            Me.DataGridView1.MultiSelect = False
            Me.DataGridView1.Name = "DataGridView1"
            Me.DataGridView1.ReadOnly = True
            Me.DataGridView1.Size = New System.Drawing.Size(752, 165)
            Me.DataGridView1.TabIndex = 0
            '
            'AdministrarVacaciones
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(800, 388)
            Me.Controls.Add(Me.DataGridView1)
            Me.Name = "AdministrarVacaciones"
            Me.Text = "Administrar Vacaciones"
            CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

    End Class
End Namespace