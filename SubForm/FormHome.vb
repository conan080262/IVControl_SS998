Imports System.IO

Public Class FormHome
    Dim SQL As New SQLControl

    Private Sub FormHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LoadGrid()

        Dim sqlcmd1 As String = "SELECT SUM(tb1.QtyHistory*tb_product.Price) AS TotalPrice FROM 
                                (SELECT * FROM tb_prodhistory WHERE cast(CreatedDate as Date) = cast(getdate() as Date) AND MENU = 'SellMenu') AS tb1 
                                LEFT JOIN tb_product 
                                ON tb1.ProdID = tb_product.ProductID"

        Dim sqlcmd2 As String = "SELECT tb_product.ProductName,tb_product.Picture,  tb1.* FROM (SELECT TOP 2 ProdID,SUM(QtyHistory) AS ttQty
                                FROM tb_prodhistory
                                WHERE cast(CreatedDate as Date) > cast(DATEADD(DAY, -15, GETDATE()) as Date) 
                                GROUP BY ProdID
                                ORDER BY ttQty DESC) AS tb1
                                LEFT JOIN tb_product
                                ON tb1.ProdID = tb_product.ProductID"

        Dim sqlcmd3 As String = "SELECT ProductName,Quantity,Picture FROM tb_product WHERE Quantity < 20"

        SQL.ExecQuery(sqlcmd1)

        If Not SQL.HasException() Then
            lblProdSell.Text = If(Not IsDBNull(SQL.DBDT.Rows(0).Item("TotalPrice")), Format(SQL.DBDT.Rows(0).Item("TotalPrice"), "0.00").ToString(), "0")
        End If




        SQL.ExecQuery(sqlcmd2)

        If Not SQL.HasException() Then
            Label2.Text = SQL.DBDT.Rows(0).Item("ProductName")
            Label3.Text = SQL.DBDT.Rows(1).Item("ProductName")
            Dim imageData As Byte() = Nothing
            If Not IsDBNull(SQL.DBDT.Rows(0).Item("Picture")) Then
                imageData = DirectCast(SQL.DBDT.Rows(0).Item("Picture"), Byte())
                Using ms As New MemoryStream(imageData)
                    PictureBox1.Image = Image.FromStream(ms)
                End Using
            End If

            If Not IsDBNull(SQL.DBDT.Rows(1).Item("Picture")) Then
                imageData = DirectCast(SQL.DBDT.Rows(1).Item("Picture"), Byte())
                Using ms As New MemoryStream(imageData)
                    PictureBox2.Image = Image.FromStream(ms)
                End Using
            End If
        End If


        SQL.ExecQuery(sqlcmd3)

        If Not SQL.HasException() Then
            DataGridView1.Rows.Clear()

            For Each row As DataRow In SQL.DBDT.Rows
                DataGridView1.Rows.Add(row("ProductName"), row("Quantity"), row("Picture"))
            Next

            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dim imgCol As DataGridViewImageColumn = DirectCast(DataGridView1.Columns("Picture"), DataGridViewImageColumn)
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch

            For Each row As DataGridViewRow In DataGridView1.Rows
                row.Height = 60
            Next
        End If





    End Sub

    Private Sub lblProdLess_Click(sender As Object, e As EventArgs) Handles lblProdLess.Click

    End Sub

    Private Sub lblProdSell_Click(sender As Object, e As EventArgs) Handles lblProdSell.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class