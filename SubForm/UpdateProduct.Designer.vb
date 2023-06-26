<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProduct
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
        Me.btnProdSave = New System.Windows.Forms.Button()
        Me.pcbProdImg = New System.Windows.Forms.PictureBox()
        Me.btnCancleImg = New System.Windows.Forms.Button()
        Me.btnBrowseImg = New System.Windows.Forms.Button()
        Me.lbProdImg = New System.Windows.Forms.Label()
        Me.tbProdCat = New System.Windows.Forms.TextBox()
        Me.lbProdCat = New System.Windows.Forms.Label()
        Me.tbProdQty = New System.Windows.Forms.TextBox()
        Me.lbProdQty = New System.Windows.Forms.Label()
        Me.tbProdPrice = New System.Windows.Forms.TextBox()
        Me.lbProdPrice = New System.Windows.Forms.Label()
        Me.tbProdName = New System.Windows.Forms.TextBox()
        Me.lbProdName = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.pcbProdImg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProdSave
        '
        Me.btnProdSave.BackColor = System.Drawing.Color.Lime
        Me.btnProdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProdSave.Location = New System.Drawing.Point(111, 426)
        Me.btnProdSave.Name = "btnProdSave"
        Me.btnProdSave.Size = New System.Drawing.Size(83, 36)
        Me.btnProdSave.TabIndex = 26
        Me.btnProdSave.Text = "Save"
        Me.btnProdSave.UseVisualStyleBackColor = False
        '
        'pcbProdImg
        '
        Me.pcbProdImg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pcbProdImg.Image = Global.IVControl_SS998.My.Resources.Resources.No_Image_Placeholder_svg
        Me.pcbProdImg.Location = New System.Drawing.Point(64, 230)
        Me.pcbProdImg.Name = "pcbProdImg"
        Me.pcbProdImg.Size = New System.Drawing.Size(184, 184)
        Me.pcbProdImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcbProdImg.TabIndex = 25
        Me.pcbProdImg.TabStop = False
        '
        'btnCancleImg
        '
        Me.btnCancleImg.Location = New System.Drawing.Point(210, 194)
        Me.btnCancleImg.Name = "btnCancleImg"
        Me.btnCancleImg.Size = New System.Drawing.Size(72, 23)
        Me.btnCancleImg.TabIndex = 24
        Me.btnCancleImg.Text = "Cancel"
        Me.btnCancleImg.UseVisualStyleBackColor = True
        '
        'btnBrowseImg
        '
        Me.btnBrowseImg.Location = New System.Drawing.Point(118, 194)
        Me.btnBrowseImg.Name = "btnBrowseImg"
        Me.btnBrowseImg.Size = New System.Drawing.Size(72, 23)
        Me.btnBrowseImg.TabIndex = 23
        Me.btnBrowseImg.Text = "Browse"
        Me.btnBrowseImg.UseVisualStyleBackColor = True
        '
        'lbProdImg
        '
        Me.lbProdImg.AutoSize = True
        Me.lbProdImg.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdImg.Location = New System.Drawing.Point(11, 190)
        Me.lbProdImg.Name = "lbProdImg"
        Me.lbProdImg.Size = New System.Drawing.Size(101, 25)
        Me.lbProdImg.TabIndex = 22
        Me.lbProdImg.Text = "เพิ่มรูปภาพ"
        '
        'tbProdCat
        '
        Me.tbProdCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdCat.Location = New System.Drawing.Point(118, 137)
        Me.tbProdCat.MaxLength = 20
        Me.tbProdCat.Name = "tbProdCat"
        Me.tbProdCat.Size = New System.Drawing.Size(164, 31)
        Me.tbProdCat.TabIndex = 21
        '
        'lbProdCat
        '
        Me.lbProdCat.AutoSize = True
        Me.lbProdCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdCat.Location = New System.Drawing.Point(23, 140)
        Me.lbProdCat.Name = "lbProdCat"
        Me.lbProdCat.Size = New System.Drawing.Size(84, 25)
        Me.lbProdCat.TabIndex = 20
        Me.lbProdCat.Text = "หมวดหมู่"
        '
        'tbProdQty
        '
        Me.tbProdQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdQty.Location = New System.Drawing.Point(118, 100)
        Me.tbProdQty.MaxLength = 10
        Me.tbProdQty.Name = "tbProdQty"
        Me.tbProdQty.Size = New System.Drawing.Size(164, 31)
        Me.tbProdQty.TabIndex = 19
        '
        'lbProdQty
        '
        Me.lbProdQty.AutoSize = True
        Me.lbProdQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdQty.Location = New System.Drawing.Point(23, 103)
        Me.lbProdQty.Name = "lbProdQty"
        Me.lbProdQty.Size = New System.Drawing.Size(67, 25)
        Me.lbProdQty.TabIndex = 18
        Me.lbProdQty.Text = "จำนวน"
        '
        'tbProdPrice
        '
        Me.tbProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdPrice.Location = New System.Drawing.Point(118, 63)
        Me.tbProdPrice.MaxLength = 20
        Me.tbProdPrice.Name = "tbProdPrice"
        Me.tbProdPrice.Size = New System.Drawing.Size(164, 31)
        Me.tbProdPrice.TabIndex = 17
        '
        'lbProdPrice
        '
        Me.lbProdPrice.AutoSize = True
        Me.lbProdPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdPrice.Location = New System.Drawing.Point(23, 66)
        Me.lbProdPrice.Name = "lbProdPrice"
        Me.lbProdPrice.Size = New System.Drawing.Size(52, 25)
        Me.lbProdPrice.TabIndex = 16
        Me.lbProdPrice.Text = "ราคา"
        '
        'tbProdName
        '
        Me.tbProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdName.Location = New System.Drawing.Point(118, 26)
        Me.tbProdName.MaxLength = 20
        Me.tbProdName.Name = "tbProdName"
        Me.tbProdName.Size = New System.Drawing.Size(164, 31)
        Me.tbProdName.TabIndex = 15
        '
        'lbProdName
        '
        Me.lbProdName.AutoSize = True
        Me.lbProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdName.Location = New System.Drawing.Point(23, 29)
        Me.lbProdName.Name = "lbProdName"
        Me.lbProdName.Size = New System.Drawing.Size(80, 25)
        Me.lbProdName.TabIndex = 14
        Me.lbProdName.Text = "ชื่อสินค้า"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 485)
        Me.Controls.Add(Me.btnProdSave)
        Me.Controls.Add(Me.pcbProdImg)
        Me.Controls.Add(Me.btnCancleImg)
        Me.Controls.Add(Me.btnBrowseImg)
        Me.Controls.Add(Me.lbProdImg)
        Me.Controls.Add(Me.tbProdCat)
        Me.Controls.Add(Me.lbProdCat)
        Me.Controls.Add(Me.tbProdQty)
        Me.Controls.Add(Me.lbProdQty)
        Me.Controls.Add(Me.tbProdPrice)
        Me.Controls.Add(Me.lbProdPrice)
        Me.Controls.Add(Me.tbProdName)
        Me.Controls.Add(Me.lbProdName)
        Me.Name = "UpdateProduct"
        Me.Text = "UpdateProduct"
        CType(Me.pcbProdImg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProdSave As Button
    Friend WithEvents pcbProdImg As PictureBox
    Friend WithEvents btnCancleImg As Button
    Friend WithEvents btnBrowseImg As Button
    Friend WithEvents lbProdImg As Label
    Friend WithEvents tbProdCat As TextBox
    Friend WithEvents lbProdCat As Label
    Friend WithEvents tbProdQty As TextBox
    Friend WithEvents lbProdQty As Label
    Friend WithEvents tbProdPrice As TextBox
    Friend WithEvents lbProdPrice As Label
    Friend WithEvents tbProdName As TextBox
    Friend WithEvents lbProdName As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
