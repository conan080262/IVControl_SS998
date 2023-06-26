Public Class FormReport
    Private Sub FormReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSellHistory_Click(sender As Object, e As EventArgs) Handles btnSellHistory.Click
        Dim frm As SellHistory = DirectCast(Application.OpenForms("SellHistory"), SellHistory)
        If frm Is Nothing Then
            frm = New SellHistory()
            TabControl2.TabPages.Add(frm)

        Else
            TabControl2.TabPages(frm).Select()

        End If

    End Sub

    Private Sub btnProductList_Click(sender As Object, e As EventArgs) Handles btnProductList.Click
        Dim frm As ProductList = DirectCast(Application.OpenForms("ProductList"), ProductList)
        If frm Is Nothing Then
            frm = New ProductList()
            TabControl2.TabPages.Add(frm)
        Else
            TabControl2.TabPages(frm).Select()
        End If
    End Sub
End Class