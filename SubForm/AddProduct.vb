Imports System.IO

Public Class AddProduct

    Private dgvClickProdID As String
    Public SQL As New SQLControl
    Private DBDT As DataRow

    Public Sub New(dgvClickProdID As String)
        InitializeComponent()
        Me.dgvClickProdID = dgvClickProdID
    End Sub

    Sub EndMe()
        Application.Exit()
    End Sub

    Private Sub tbProdQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbProdQty.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            MsgBox("nonono")
            e.Handled = True
        End If
    End Sub

    Private Sub changeCalQty()
        Dim dbQuantity As Integer = 0
        Dim prodQty As Integer = 0

        If Not (IsDBNull(DBDT("Quantity"))) Then
            dbQuantity = CInt(DBDT("Quantity"))
        End If
        If Not String.IsNullOrEmpty(tbProdQty.Text) Then
            prodQty = CInt(tbProdQty.Text)
        End If

        If cbAddProd.Checked Then
            lbCalQty.Text = "(" & dbQuantity + prodQty & ")"
        ElseIf cbRedProd.Checked Then
            lbCalQty.Text = "(" & dbQuantity - prodQty & ")"
        Else
            lbCalQty.Text = "(กรุณาเลือก เพิ่ม/ลด จำนวนสินค้า)"
        End If
    End Sub

    Private Sub tbProdQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbProdQty.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.C OrElse e.KeyCode = Keys.V) Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub AddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        SQL.AddParams("@ProductID", dgvClickProdID)
        SQL.ExecQuery("SELECT TOP 1 * FROM tb_product WHERE ProductID = @ProductID;")

        If SQL.HasException() Then
            Exit Sub
        End If
        DBDT = SQL.DBDT.Rows(0)

        lbProdName.Text = If(Not IsDBNull(DBDT("ProductName")), DBDT("ProductName").ToString(), String.Empty)
        lbNowQty.Text = If(Not IsDBNull(DBDT("Quantity")), DBDT("Quantity").ToString(), String.Empty)
        'Dim fTemp As Form = New FormCheckData(SQL.DBDT)
        'fTemp.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not String.IsNullOrEmpty(tbProdQty.Text) Then
            If cbAddProd.Checked Or cbRedProd.Checked Then
                InsertProdHis()
                Me.DialogResult = DialogResult.OK
            Else
                MsgBox("กรุณาติ๊กที่ เพิ่ม/ลด")
            End If

        Else
            MsgBox("กรุณาใส่จำนวน")
        End If


    End Sub

    Private Sub cbAddProd_CheckedChanged(sender As Object, e As EventArgs) Handles cbAddProd.CheckedChanged
        If cbAddProd.Checked Then
            cbRedProd.Enabled = False
        Else
            cbRedProd.Enabled = True
        End If
        changeCalQty()
    End Sub

    Private Sub cbRedProd_CheckedChanged(sender As Object, e As EventArgs) Handles cbRedProd.CheckedChanged
        If cbRedProd.Checked Then
            cbAddProd.Enabled = False
        Else
            cbAddProd.Enabled = True
        End If
        changeCalQty()
    End Sub

    Private Sub tbProdQty_TextChanged(sender As Object, e As EventArgs) Handles tbProdQty.TextChanged
        changeCalQty()
    End Sub

    Private Sub InsertProdHis()
        Dim dbQuantity As Integer = 0
        Dim prodQty As Integer = 0

        If Not (IsDBNull(DBDT("Quantity"))) Then
            dbQuantity = CInt(DBDT("Quantity"))
        End If
        If Not String.IsNullOrEmpty(tbProdQty.Text) Then
            prodQty = CInt(tbProdQty.Text)
        End If

        Dim sqlcmd As String = "Insert Into tb_prodhistory (GUID,ProdID,QtyHistory,ActionBy,CreatedDate,Type,Menu)" &
            " Values (@GUID,@ProdID,@QtyHistory,'Admin',GETDATE(),@Type,@Menu)"
        Dim BarcodeID As String = Guid.NewGuid().ToString("N")
        SQL.AddParams("@GUID", BarcodeID)

        SQL.AddParams("@ProdID", dgvClickProdID)
        SQL.AddParams("@QtyHistory", prodQty)
        SQL.AddParams("@Type", If(cbAddProd.Checked, "Add", "Sub"))
        SQL.AddParams("@Menu", "BackEnd")

        SQL.ExecQuery(sqlcmd)
        If SQL.HasException() Then
            Exit Sub
        End If



        If cbAddProd.Checked Then
            dbQuantity = dbQuantity + prodQty
        ElseIf cbRedProd.Checked Then
            dbQuantity = dbQuantity - prodQty
        End If


        sqlcmd = "UPDATE tb_product 
            SET 
            Quantity = @Quantity,
            UpdatedDate = GETDATE(), 
            ActionBy = 'Admin' 
            WHERE ProductID = @ProductID"


        SQL.AddParams("@Quantity", dbQuantity)
        SQL.AddParams("@ProductID", dgvClickProdID)
        SQL.ExecQuery(sqlcmd)
        If SQL.HasException() Then
            Exit Sub
        End If

        MsgBox("Product Saved")
    End Sub
End Class