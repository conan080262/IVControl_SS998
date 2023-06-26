Imports System.IO

Public Class FormSell
    Dim SQL As New SQLControl


    'Private Sub sPanel1_Paint(sender As Object, e As PaintEventArgs) Handles sPanel1.Paint
    '    ControlPaint.DrawBorder(e.Graphics, sPanel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    'End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
    '    ControlPaint.DrawBorder(e.Graphics, Panel1.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    'End Sub

    'Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
    '    ControlPaint.DrawBorder(e.Graphics, Panel2.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    'End Sub

    'Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
    '    ControlPaint.DrawBorder(e.Graphics, Panel4.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    'End Sub

    'Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
    '    ControlPaint.DrawBorder(e.Graphics, Panel3.ClientRectangle, Color.DarkBlue, ButtonBorderStyle.Solid)
    'End Sub


    Private Sub passProduct()
        Dim tbprod As String = tbBarcode.Text
        Dim sql1 As String = "SELECT TOP 1 * FROM tb_product WHERE BarcodeID = @BarcodeID"
        SQL.AddParams("@BarcodeID", tbprod)
        SQL.ExecQuery(sql1)
        If SQL.RecordCount > 0 Then
            Dim DBDT As DataRow = SQL.DBDT.Rows(0)
            lblProdName.Text = If(Not IsDBNull(DBDT("ProductName")), DBDT("ProductName").ToString(), "ไม่พบชื่อสินค้า")

            Dim imageData As Byte() = Nothing
            If Not IsDBNull(DBDT("Picture")) Then
                imageData = DirectCast(DBDT("Picture"), Byte())
                Using ms As New MemoryStream(imageData)
                    pcbProd.Image = Image.FromStream(ms)
                End Using
            End If
            lblProdPrice.Text = If(Not IsDBNull(DBDT("Price")), Format(DBDT("Price"), "0.00").ToString(), "0.00")

            Dim rowIndex As Integer = dgvProdList.Rows.Add(DBDT("Picture"), DBDT("ProductName"),
                                                           Format(DBDT("Price"), "0.00").ToString(), "1",
                                                           Format(DBDT("Price"), "0.00").ToString(), DBDT("ProductID")
                                                           )

            dgvProdList.Rows(rowIndex).Height = 80
            dgvProdList.FirstDisplayedScrollingRowIndex = dgvProdList.RowCount - 1
            lbtotalPrice(1, CDbl(DBDT("Price")))
        Else
            MsgBox("ไม่พบรายการสินค้า")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles tbBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            passProduct()
            tbBarcode.Clear()
        End If
    End Sub

    Private Sub FormSell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvProdList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim imgCol As DataGridViewImageColumn = DirectCast(dgvProdList.Columns("Picture"), DataGridViewImageColumn)
        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch
        dgvProdList.Columns("Qty").DefaultCellStyle.BackColor = Color.LightGreen
    End Sub

    Private Sub lbtotalPrice(Qty As Double, Price As Double)
        Dim sum As Double = CDbl(lblTotalPrice.Text)
        sum = sum + (Qty * Price)
        lblTotalPrice.Text = Format(sum, "0.00").ToString()
        changeCalDiffPrice()
    End Sub

    Private Sub dgvProdList_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdList.CellEndEdit

        If dgvProdList.Columns(e.ColumnIndex).Name = "Qty" And e.RowIndex > -1 Then
            Dim clickedRow As DataGridViewRow = dgvProdList.Rows(e.RowIndex)
            Dim Qty As Double = CDbl(clickedRow.Cells("Qty").Value)
            Dim Price As Double = CDbl(clickedRow.Cells("Price").Value)
            clickedRow.Cells("Total").Value = Format(CDbl(Qty) * CDbl(Price), "0.00").ToString()
            lbtotalPrice(Qty, Price)

        End If

    End Sub




    Private Sub tbProdPrice_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
            e.Handled = True
        End If
        If e.KeyChar = "." AndAlso TextBox1.Text.Contains(".") Then
            e.Handled = True ' ไม่อนุญาตให้ปุ่มถูกป้อน
        End If
    End Sub

    Private Sub tbProdPrice_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.C OrElse e.KeyCode = Keys.V) Then
            e.SuppressKeyPress = True
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        changeCalDiffPrice()
    End Sub

    Private Sub changeCalDiffPrice()

        Dim reMon As Double = 0

        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            reMon = CDbl(TextBox1.Text)
        End If
        lblDiffPrice.Text = Format((reMon - CDbl(lblTotalPrice.Text)), "0.00").ToString()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CInt(lblDiffPrice.Text) >= 0 Then
            InsertProd()

        Else
            MsgBox("ลูกค้าจ่ายเงินไม่พอ")
        End If
    End Sub

    Private Sub tbBarcode_TextChanged(sender As Object, e As EventArgs) Handles tbBarcode.TextChanged

    End Sub

    Private Sub InsertProd()
        Dim sGUID As String
        sGUID = Guid.NewGuid().ToString("N")
        Dim sqlcmd1 As String = "Insert Into tb_sellhistory (CreatedDate,RecieveMoney,SumMoney,TotalMoney,GUID)" &
            " Values (GETDATE(),@RecieveMoney,@SumMoney,@TotalMoney,@GUID); SELECT SCOPE_IDENTITY();"
        SQL.AddParams("@GUID", sGUID)
        SQL.AddParams("@RecieveMoney", TextBox1.Text.ToString())
        SQL.AddParams("@SumMoney", lblDiffPrice.Text.ToString())
        SQL.AddParams("@TotalMoney", lblTotalPrice.Text.ToString())
        Dim lastInsertedID As Integer = SQL.ExecQuery_SCOPE_IDENTITY(sqlcmd1)
        If SQL.HasException() Then
            Exit Sub
        End If

        Dim sqlcmd2 As String = "Insert Into tb_prodhistory (GUID,ProdID,QtyHistory,ActionBy,CreatedDate,Type,Menu,sellhistory_id)" &
            " Values (@GUID,@ProdID,@QtyHistory,@ActionBy,GETDATE(),@Type,@Menu,@sellhistory_id)"
        Dim sqlcmd3 As String = "UPDATE tb_product 
            SET 
            Quantity = Quantity - @Quantity, 
            UpdatedDate = GETDATE(), 
            ActionBy = 'Admin' 
            WHERE ProductID = @ProductID"

        For Each row As DataGridViewRow In dgvProdList.Rows
            Dim columnProductID As String = row.Cells("ProductID").Value.ToString()
            Dim columnQty As String = row.Cells("Qty").Value.ToString()
            sGUID = Guid.NewGuid().ToString("N")
            SQL.AddParams("@GUID", sGUID)
            SQL.AddParams("@ProdID", columnProductID)
            SQL.AddParams("@QtyHistory", columnQty)
            SQL.AddParams("@ActionBy", "Admin")
            SQL.AddParams("@Type", "Sub")
            SQL.AddParams("@Menu", "SellMenu")
            SQL.AddParams("@sellhistory_id", lastInsertedID)
            SQL.ExecQuery(sqlcmd2)
            If SQL.HasException() Then
                Exit Sub
            End If

            SQL.AddParams("@Quantity", columnQty)
            SQL.AddParams("@ProductID", columnProductID)
            SQL.ExecQuery(sqlcmd3)
            If SQL.HasException() Then
                Exit Sub
            End If

        Next

        ReloadForm()
        MsgBox("Sell Saved")
    End Sub
    Private Sub ReloadForm()
        Me.Controls.Clear() 'removes all the controls on the form
        InitializeComponent() 'load all the controls again
        FormSell_Load(Nothing, EventArgs.Empty) 'Load everything in your form, load event again
        'FormSell_Load(e, e)
    End Sub
    Private Sub btnBackMenu_Click(sender As Object, e As EventArgs) Handles btnBackMenu.Click
        Me.Hide()
        FormMenu.Show()
    End Sub

    Private Sub dgvProdList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProdList.CellContentClick

    End Sub

    Private Sub DataGridView1_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles dgvProdList.UserDeletedRow
        '' เข้าถึงข้อมูลบรรทัดที่ถูกลบ
        'Dim deletedRow As DataGridViewRow = e.Row


        '' ตัวอย่างการเข้าถึงคอลัมน์และค่าในบรรทัดที่ถูกลบ
        'Dim colPrice As Object = deletedRow.Cells("Price").Value
        'Dim colQty As Object = deletedRow.Cells("Qty").Value
        'lbtotalPrice(colQty, colPrice * -1)
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgvProdList.UserDeletingRow
        Dim deletedRow As DataGridViewRow = e.Row


        ' ตัวอย่างการเข้าถึงคอลัมน์และค่าในบรรทัดที่ถูกลบ
        Dim colPrice As Object = deletedRow.Cells("Price").Value
        Dim colQty As Object = deletedRow.Cells("Qty").Value
        lbtotalPrice(colQty, colPrice * -1)
    End Sub

    Private Sub FormSell_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        FormMenu.Show()
    End Sub
End Class