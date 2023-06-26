Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CreateProduct

    Public SQL As New SQLControl
    Private Sub btnBrowseImg_Click(sender As Object, e As EventArgs) Handles btnBrowseImg.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pcbProdImg.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadGrid()



    End Sub

    Private Sub btnProdSave_Click(sender As Object, e As EventArgs) Handles btnProdSave.Click
        If tbProdName.Text.Length() > 0 Then
            InsertProd()
        Else
            MsgBox("กรุณาใส่ข้อมูลชื่อสินค้า")
        End If

    End Sub

    Private Sub InsertProd()
        Dim sqlcmd As String = "Insert Into tb_product (BarcodeID,ProductName,Price,Quantity,Category,Picture,CreatedDate,UpdatedDate,ActionBy)" &
            " Values (@BarcodeID,@ProductName,@Price,@Quantity,@Category,@Picture,GETDATE(),GETDATE(),'Admin')"
        Dim BarcodeID As String = Guid.NewGuid().ToString("N")
        SQL.AddParams("@BarcodeID", BarcodeID)
        SQL.AddParams("@ProductName", tbProdName.Text)
        SQL.AddParams("@Price", tbProdPrice.Text)
        SQL.AddParams("@Quantity", tbProdQty.Text)
        SQL.AddParams("@Category", tbProdCat.Text)
        Dim ms As New MemoryStream
        Dim img As Image = pcbProdImg.Image
        Dim bmpImage As New Bitmap(img)
        bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Dim data As Byte() = ms.GetBuffer

        SQL.AddParams("@Picture", data)

        SQL.ExecQuery(sqlcmd)
        If SQL.HasException() Then
            Exit Sub
        End If

        MsgBox("Product Saved")
    End Sub

    Private Sub tbProdPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbProdPrice.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso tbProdPrice.Text.Contains(".") Then
            e.Handled = True ' ไม่อนุญาตให้ปุ่มถูกป้อน
        End If
    End Sub

    Private Sub tbProdPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbProdPrice.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.C OrElse e.KeyCode = Keys.V) Then
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub tbProdQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbProdQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso tbProdQty.Text.Contains(".") Then
            e.Handled = True ' ไม่อนุญาตให้ปุ่มถูกป้อน
        End If
    End Sub

    Private Sub tbProdQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbProdQty.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.C OrElse e.KeyCode = Keys.V) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub btnCancleImg_Click(sender As Object, e As EventArgs) Handles btnCancleImg.Click
        pcbProdImg.Image = My.Resources.No_Image_Placeholder_svg
    End Sub
End Class