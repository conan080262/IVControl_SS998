Public Class ProductList
    Public SQL As New SQLControl
    Private Sub ProductList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM tb_product;")
        If SQL.HasException() Then
            Exit Sub
        End If
        Dim crProductList As New CRProductList
        crProductList.Database.Tables("tb_product").SetDataSource(SQL.DBDT)
        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = crProductList
    End Sub
End Class