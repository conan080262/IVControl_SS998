Public Class SellHistory
    Public SQL As New SQLControl

    Private Sub SellHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM tb_product;")
        If SQL.HasException() Then
            Exit Sub
        End If
        Dim SellHis As New CrystalReport1

        SellHis.Database.Tables("tb_product").SetDataSource(SQL.DBDT)


        SQL.ExecQuery("SELECT * FROM tb_prodhistory;")
        If SQL.HasException() Then
            Exit Sub
        End If
        SellHis.Database.Tables("tb_prodhistory").SetDataSource(SQL.DBDT)

        SQL.ExecQuery("SELECT * FROM tb_sellhistory;")
        If SQL.HasException() Then
            Exit Sub
        End If
        SellHis.Database.Tables("tb_sellhistory").SetDataSource(SQL.DBDT)


        CrystalReportViewer1.ReportSource = Nothing
        CrystalReportViewer1.ReportSource = SellHis
    End Sub
End Class