Namespace Vistas
    Public Class RegistrarEmpleado
        Private Sub UpdateDataGrid(ByVal context As DB_Recursos_HumanosEntities, ByVal dg As DataGridView)
            Dim empList = (From emp In context.Empleado Select emp.Cedula, emp.Nombre, emp.Apellido, emp.Domicilio, emp.Cargo.Salario).ToList
            dg.DataSource = empList
        End Sub
        Private Sub RegistrarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities
                UpdateDataGrid(context, Me.DataGridView1)
                Dim profesionList = (From p In context.Profesiones Select p).ToList
                Dim infoAcademyList = (From ia In context.Informacion_Academica Select ia).ToList
                Dim antecedentesList = (From a In context.Antecedentes Select a).ToList
                Dim areaList = (From a In context.area Select a).ToList
                Dim cargoList = (From c In context.Cargo Select c).ToList

                empProfesion.DataSource = profesionList
                empProfesion.DisplayMember = "Profesion"
                empProfesion.ValueMember = "Id_Profesion"

                empInfoAcademica.DataSource = infoAcademyList
                empInfoAcademica.DisplayMember = "Tipo_Estudio"
                empInfoAcademica.ValueMember = "Id_hist_academico"

                empAntecedente.DataSource = antecedentesList
                empAntecedente.DisplayMember = "Antecedente1"
                empAntecedente.ValueMember = "Id_Antecedente"

                empArea.DataSource = areaList
                empArea.DisplayMember = "nombre"
                empArea.ValueMember = "ID"

                empCargo.DataSource = cargoList
                empCargo.DisplayMember = "Nombre_Cargo"
                empCargo.ValueMember = "Id_Cargo"

            End Using
        End Sub
        Private Sub bGuardar_Click(sender As Object, e As EventArgs) Handles bGuardar.Click
            Using context As New DB_Recursos_HumanosEntities
                Dim emp As New Empleado
                emp.Nombre = tbNombre.Text
                emp.Apellido = tbApellidos.Text
                emp.Cedula = tbCedula.Text
                emp.Telefono = tbTelefono.Text
                emp.FechaNacimiento = DateTimePicker1.Value
                emp.Estado_Civil = empEstadoCivil.Checked
                emp.Domicilio = empDomicilio.Text
                emp.Estado = Estado.Checked
                emp.Id_Profesion = empProfesion.SelectedValue
                emp.Id_Info_Academica = empInfoAcademica.SelectedValue
                emp.Id_Antecendete = empAntecedente.SelectedValue
                emp.Id_area = empArea.SelectedValue
                emp.Id_Cargo = empCargo.SelectedValue
                context.Empleado.Add(emp)
                Try
                    context.SaveChanges()
                    MessageBox.Show("Guardado exitoso")
                    UpdateDataGrid(context, Me.DataGridView1)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End Using
        End Sub

    End Class
End Namespace