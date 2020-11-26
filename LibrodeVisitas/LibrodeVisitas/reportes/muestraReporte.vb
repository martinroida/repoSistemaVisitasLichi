Public Class frmMuestraReporte
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        Dim rptReporteVisitas As New Reporte1
        CrystalReportViewer1.ReportSource = rptReporteVisitas
        CrystalReportViewer1.RefreshReport()
    End Sub
End Class