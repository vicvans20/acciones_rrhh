Imports Microsoft.Reporting.WinForms
Namespace Vistas
    Public Class ReportePermiso

        Private Sub ReportePermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using context As New DB_Recursos_HumanosEntities1
                Dim rv As New ReportViewer
                Dim rds As New ReportDataSource
                rds.Name = "DataSet1"
                'rds.Value = (From emp In context.Empleado Join p In context.permisos On p.Id_Empleado Equals emp.Id_Empleado Select emp.Nombre, emp.Apellido, emp.Cedula, p.descripcion, p.categoria, p.fecha_inicio, p.fecha_fin).ToList
                rds.Value = (From vw In context.VW_Permisos Select vw).ToList
                rv.LocalReport.DataSources.Add(rds)
                rv.LocalReport.ReportEmbeddedResource = "WindowsApplication1.Report1.rdlc"
                rv.RefreshReport()
                Me.Controls.Add(rv)
            End Using
        End Sub
    End Class
End Namespace
