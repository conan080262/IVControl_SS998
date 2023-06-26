Imports System.IO

Public Class UpdateProduct
    Public SQL As New SQLControl

    Private dgvClickProdID As String

    Public Sub New(dgvClickProdID As String)
        InitializeComponent()
        Me.dgvClickProdID = dgvClickProdID
    End Sub

    Private Sub CreateProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Sub EndMe()
        Application.Exit()
    End Sub

    Private Sub btnBrowseImg_Click(sender As Object, e As EventArgs) Handles btnBrowseImg.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            pcbProdImg.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub


    Private Sub LoadGrid()
        SQL.AddParams("@ProductID", dgvClickProdID)
        SQL.ExecQuery("SELECT TOP 1 * FROM tb_product WHERE ProductID = @ProductID;")

        If SQL.HasException() Then
            Exit Sub
        End If
        Dim DBDT As DataRow = SQL.DBDT.Rows(0)
        tbProdName.Text = If(Not IsDBNull(DBDT("ProductName")), DBDT("ProductName").ToString(), String.Empty)
        tbProdPrice.Text = If(Not IsDBNull(DBDT("Price")), DBDT("Price").ToString(), String.Empty)
        tbProdQty.Text = If(Not IsDBNull(DBDT("Quantity")), DBDT("Quantity").ToString(), String.Empty)
        tbProdCat.Text = If(Not IsDBNull(DBDT("Category")), DBDT("Category").ToString(), String.Empty)

        Dim imageData As Byte() = Nothing
        If Not IsDBNull(DBDT("Picture")) Then
            imageData = DirectCast(DBDT("Picture"), Byte())
            Using ms As New MemoryStream(imageData)
                pcbProdImg.Image = Image.FromStream(ms)
            End Using
        End If



        'Dim fTemp As Form = New FormCheckData(SQL.DBDT)
        'fTemp.Show()
    End Sub

    Private Sub btnProdSave_Click(sender As Object, e As EventArgs) Handles btnProdSave.Click
        If tbProdName.Text.Length() > 0 Then
            UpdateProd()
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("กรุณาใส่ข้อมูลชื่อสินค้า")
        End If

    End Sub

    Private Sub UpdateProd()
        'UPDATE table_name
        'SET column1 = value1, column2 = value2, ...
        'WHERE condition;
        Dim sqlcmd As String = "UPDATE tb_product 
            SET ProductName = @ProductName, 
            Price = @Price, 
            Quantity = @Quantity, 
            Category = @Category, 
            Picture = @Picture,
            UpdatedDate = GETDATE(), 
            ActionBy = 'Admin' 
            WHERE ProductID = @ProductID"
        SQL.AddParams("@ProductID", dgvClickProdID)
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
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
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

    Private Sub pcbProdImg_Click(sender As Object, e As EventArgs) Handles pcbProdImg.Click

    End Sub

    Private Sub tbProdPrice_TextChanged(sender As Object, e As EventArgs) Handles tbProdPrice.TextChanged

    End Sub
End Class