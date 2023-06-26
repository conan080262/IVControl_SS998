Imports System.Data.Common
Imports System.Data.SqlClient

Public Class FormProduct
    Public SQL As New SQLControl
    Private Sub FormProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        SQL.ExecQuery("SELECT * FROM tb_product;")
        If SQL.HasException() Then
            Exit Sub
        End If
        Dim btnColumn As New DataGridViewButtonColumn With {
            .HeaderText = "Update",
            .Text = "Update",
            .Name = "Update",
            .UseColumnTextForButtonValue = True, ' ใช้ข้อความในคอลัมน์เป็นข้อความบนปุ่ม
            .FlatStyle = FlatStyle.Flat
            }
        Dim btnColumn2 As New DataGridViewButtonColumn With {
            .HeaderText = "Delete",
            .Text = "Delete",
            .Name = "Delete",
            .UseColumnTextForButtonValue = True, ' ใช้ข้อความในคอลัมน์เป็นข้อความบนปุ่ม
            .FlatStyle = FlatStyle.Flat
            }

        Dim btnColumn3 As New DataGridViewButtonColumn With {
            .HeaderText = "จำนวนสินค้า",
            .Text = "เพิ่ม-ลด",
            .Name = "AddProduct",
            .UseColumnTextForButtonValue = True, ' ใช้ข้อความในคอลัมน์เป็นข้อความบนปุ่ม
            .FlatStyle = FlatStyle.Flat
            }

        dgvProduct.Columns.Clear()
        btnColumn3.DefaultCellStyle.BackColor = Color.GreenYellow
        dgvProduct.Columns.Add(btnColumn3)
        dgvProduct.DataSource = SQL.DBDT

        btnColumn2.DefaultCellStyle.BackColor = Color.Red
        btnColumn.DefaultCellStyle.BackColor = Color.Yellow
        dgvProduct.Columns.Add(btnColumn)
        dgvProduct.Columns.Add(btnColumn2)
        'dgvProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        Dim imgCol As DataGridViewImageColumn = DirectCast(dgvProduct.Columns("Picture"), DataGridViewImageColumn)
        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch


        'Dim column As DataGridViewColumn = dgvProduct.Columns("OriginalColumnName") ' Replace with the actual column name
        'column.HeaderText = "New Column Header Text"
        'column.DefaultCellStyle.BackColor = Color.LightBlue
        'column.DefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Bold)

        'dgvProduct.Refresh()
        'dgvProduct.Update()

    End Sub

    Private Sub dgvProduct_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellClick
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick

        If dgvProduct.Columns(e.ColumnIndex).Name = "AddProduct" And e.RowIndex > -1 Then

            'MsgBox(e.ColumnIndex & "   " & e.RowIndex)
            Dim clickedRow As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
            Dim value As Object = clickedRow.Cells("ProductID").Value
            Dim addProduct As New AddProduct(value.ToString())
            Dim result As DialogResult = addProduct.ShowDialog()

            If result = DialogResult.OK Then
                LoadGrid()
            ElseIf result = DialogResult.Cancel Then
                LoadGrid()
            End If

        End If

        If dgvProduct.Columns(e.ColumnIndex).Name = "Update" And e.RowIndex > -1 Then

            'MsgBox(e.ColumnIndex & "   " & e.RowIndex)
            Dim clickedRow As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
            Dim value As Object = clickedRow.Cells("ProductID").Value
            Dim updateProduct As New UpdateProduct(value.ToString())
            Dim result As DialogResult = updateProduct.ShowDialog()

            If result = DialogResult.OK Then
                LoadGrid()
            ElseIf result = DialogResult.Cancel Then
                LoadGrid()

            End If

        End If

        If dgvProduct.Columns(e.ColumnIndex).Name = "Delete" And e.RowIndex > -1 Then
            'MsgBox(e.ColumnIndex & "   " & e.RowIndex)
            Dim clickedRow As DataGridViewRow = dgvProduct.Rows(e.RowIndex)
            Dim value As Object = clickedRow.Cells("ProductID").Value
            DeleteProduct(value.ToString())
            LoadGrid()
            'MessageBox.Show("Clicked Value: " & value.ToString())

        End If
    End Sub

    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        CreateProduct.Show()
    End Sub

    Private Sub DeleteProduct(productID As String)
        Dim result1 As DialogResult = MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        Dim result2 As DialogResult = MessageBox.Show("Are you sure you want to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result1 = DialogResult.Yes AndAlso result2 = DialogResult.Yes Then
            SQL.AddParams("@ProductID", productID)
            SQL.ExecQuery("DELETE FROM tb_product WHERE ProductID=@ProductID")
        End If
        LoadGrid()
    End Sub

End Class