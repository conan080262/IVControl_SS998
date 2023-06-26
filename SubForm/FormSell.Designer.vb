<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSell
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.mPanel1 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblProdPrice = New System.Windows.Forms.Label()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.pcbProd = New System.Windows.Forms.PictureBox()
        Me.sPanel1 = New System.Windows.Forms.Panel()
        Me.tbBarcode = New System.Windows.Forms.TextBox()
        Me.lblBarcode = New System.Windows.Forms.Label()
        Me.mPanel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvProdList = New System.Windows.Forms.DataGridView()
        Me.Picture = New System.Windows.Forms.DataGridViewImageColumn()
        Me.NameProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDiffPrice = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBackMenu = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pcbProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sPanel1.SuspendLayout()
        Me.mPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgvProdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mPanel1
        '
        Me.mPanel1.Controls.Add(Me.Panel1)
        Me.mPanel1.Controls.Add(Me.sPanel1)
        Me.mPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.mPanel1.Location = New System.Drawing.Point(0, 0)
        Me.mPanel1.Name = "mPanel1"
        Me.mPanel1.Size = New System.Drawing.Size(412, 607)
        Me.mPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblProdPrice)
        Me.Panel1.Controls.Add(Me.lblProdName)
        Me.Panel1.Controls.Add(Me.pcbProd)
        Me.Panel1.Location = New System.Drawing.Point(0, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel1.Size = New System.Drawing.Size(412, 492)
        Me.Panel1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(286, 407)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 43)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "บาท"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProdPrice
        '
        Me.lblProdPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProdPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdPrice.Location = New System.Drawing.Point(107, 407)
        Me.lblProdPrice.Name = "lblProdPrice"
        Me.lblProdPrice.Size = New System.Drawing.Size(173, 43)
        Me.lblProdPrice.TabIndex = 7
        Me.lblProdPrice.Text = "0.00"
        Me.lblProdPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProdName
        '
        Me.lblProdName.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProdName.Location = New System.Drawing.Point(61, 63)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(275, 43)
        Me.lblProdName.TabIndex = 1
        Me.lblProdName.Text = "ชื่อสินค้า"
        Me.lblProdName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pcbProd
        '
        Me.pcbProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pcbProd.Location = New System.Drawing.Point(61, 126)
        Me.pcbProd.Name = "pcbProd"
        Me.pcbProd.Size = New System.Drawing.Size(275, 267)
        Me.pcbProd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProd.TabIndex = 0
        Me.pcbProd.TabStop = False
        '
        'sPanel1
        '
        Me.sPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sPanel1.Controls.Add(Me.tbBarcode)
        Me.sPanel1.Controls.Add(Me.lblBarcode)
        Me.sPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.sPanel1.Location = New System.Drawing.Point(0, 0)
        Me.sPanel1.Name = "sPanel1"
        Me.sPanel1.Padding = New System.Windows.Forms.Padding(15)
        Me.sPanel1.Size = New System.Drawing.Size(412, 115)
        Me.sPanel1.TabIndex = 2
        '
        'tbBarcode
        '
        Me.tbBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBarcode.Location = New System.Drawing.Point(122, 37)
        Me.tbBarcode.MaxLength = 40
        Me.tbBarcode.Name = "tbBarcode"
        Me.tbBarcode.Size = New System.Drawing.Size(270, 31)
        Me.tbBarcode.TabIndex = 1
        '
        'lblBarcode
        '
        Me.lblBarcode.AutoSize = True
        Me.lblBarcode.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBarcode.Location = New System.Drawing.Point(11, 44)
        Me.lblBarcode.Name = "lblBarcode"
        Me.lblBarcode.Size = New System.Drawing.Size(107, 20)
        Me.lblBarcode.TabIndex = 0
        Me.lblBarcode.Text = "กรุณายิงบาร์โค๊ด"
        '
        'mPanel2
        '
        Me.mPanel2.Controls.Add(Me.Panel4)
        Me.mPanel2.Controls.Add(Me.Panel3)
        Me.mPanel2.Controls.Add(Me.Panel2)
        Me.mPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mPanel2.Location = New System.Drawing.Point(412, 0)
        Me.mPanel2.Name = "mPanel2"
        Me.mPanel2.Size = New System.Drawing.Size(649, 607)
        Me.mPanel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dgvProdList)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel4.Size = New System.Drawing.Size(649, 368)
        Me.Panel4.TabIndex = 5
        '
        'dgvProdList
        '
        Me.dgvProdList.AllowUserToAddRows = False
        Me.dgvProdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProdList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Picture, Me.NameProd, Me.Price, Me.Qty, Me.Total, Me.ProductID})
        Me.dgvProdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProdList.Location = New System.Drawing.Point(15, 15)
        Me.dgvProdList.Name = "dgvProdList"
        Me.dgvProdList.Size = New System.Drawing.Size(617, 336)
        Me.dgvProdList.TabIndex = 0
        '
        'Picture
        '
        Me.Picture.HeaderText = "รูปภาพ"
        Me.Picture.Name = "Picture"
        Me.Picture.ReadOnly = True
        Me.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'NameProd
        '
        Me.NameProd.HeaderText = "ชื่อสินค้า"
        Me.NameProd.Name = "NameProd"
        Me.NameProd.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "ราคา"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Qty
        '
        Me.Qty.HeaderText = "จำนวน"
        Me.Qty.Name = "Qty"
        '
        'Total
        '
        Me.Total.HeaderText = "รวม"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'ProductID
        '
        Me.ProductID.HeaderText = "ProductID"
        Me.ProductID.Name = "ProductID"
        Me.ProductID.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.lblDiffPrice)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.lblTotalPrice)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 425)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel3.Size = New System.Drawing.Size(649, 182)
        Me.Panel3.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(406, 48)
        Me.TextBox1.MaxLength = 40
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(169, 26)
        Me.TextBox1.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(581, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "บาท"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiffPrice
        '
        Me.lblDiffPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDiffPrice.BackColor = System.Drawing.Color.Aqua
        Me.lblDiffPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiffPrice.Location = New System.Drawing.Point(402, 84)
        Me.lblDiffPrice.Name = "lblDiffPrice"
        Me.lblDiffPrice.Size = New System.Drawing.Size(173, 25)
        Me.lblDiffPrice.TabIndex = 11
        Me.lblDiffPrice.Text = "0.00"
        Me.lblDiffPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(211, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 25)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "เงินทอน"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(581, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "บาท"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 25)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "กรอกจำนวนเงินลูกค้า"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 25)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "บาท"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(475, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 48)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "คิดเงิน"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotalPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(402, 15)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(173, 25)
        Me.lblTotalPrice.TabIndex = 3
        Me.lblTotalPrice.Text = "0.00"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(211, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รวมยอด ราคาสินค้า"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnBackMenu)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(15)
        Me.Panel2.Size = New System.Drawing.Size(649, 57)
        Me.Panel2.TabIndex = 3
        '
        'btnBackMenu
        '
        Me.btnBackMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBackMenu.BackColor = System.Drawing.Color.Red
        Me.btnBackMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackMenu.Location = New System.Drawing.Point(569, 12)
        Me.btnBackMenu.Name = "btnBackMenu"
        Me.btnBackMenu.Size = New System.Drawing.Size(60, 31)
        Me.btnBackMenu.TabIndex = 5
        Me.btnBackMenu.Text = "กลับ"
        Me.btnBackMenu.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 43)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "รายการสินค้า"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormSell
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1061, 607)
        Me.Controls.Add(Me.mPanel2)
        Me.Controls.Add(Me.mPanel1)
        Me.Name = "FormSell"
        Me.Text = "FormSell"
        Me.mPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.pcbProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sPanel1.ResumeLayout(False)
        Me.sPanel1.PerformLayout()
        Me.mPanel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgvProdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents mPanel1 As Panel
    Friend WithEvents tbBarcode As TextBox
    Friend WithEvents lblBarcode As Label
    Friend WithEvents mPanel2 As Panel
    Friend WithEvents sPanel1 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgvProdList As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblProdName As Label
    Friend WithEvents pcbProd As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblProdPrice As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDiffPrice As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnBackMenu As Button
    Friend WithEvents Picture As DataGridViewImageColumn
    Friend WithEvents NameProd As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents ProductID As DataGridViewTextBoxColumn
End Class
