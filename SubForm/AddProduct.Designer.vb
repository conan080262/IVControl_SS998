<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProduct
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
        Me.lbhProdName = New System.Windows.Forms.Label()
        Me.cbAddProd = New System.Windows.Forms.CheckBox()
        Me.cbRedProd = New System.Windows.Forms.CheckBox()
        Me.lbProdName = New System.Windows.Forms.Label()
        Me.tbProdQty = New System.Windows.Forms.TextBox()
        Me.lbQty = New System.Windows.Forms.Label()
        Me.lbhNowQty = New System.Windows.Forms.Label()
        Me.lbNowQty = New System.Windows.Forms.Label()
        Me.lbCalQty = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbhProdName
        '
        Me.lbhProdName.AutoSize = True
        Me.lbhProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhProdName.Location = New System.Drawing.Point(41, 27)
        Me.lbhProdName.Name = "lbhProdName"
        Me.lbhProdName.Size = New System.Drawing.Size(86, 25)
        Me.lbhProdName.TabIndex = 0
        Me.lbhProdName.Text = "ชื่อสินค้า:"
        '
        'cbAddProd
        '
        Me.cbAddProd.AutoSize = True
        Me.cbAddProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAddProd.Location = New System.Drawing.Point(46, 107)
        Me.cbAddProd.Name = "cbAddProd"
        Me.cbAddProd.Size = New System.Drawing.Size(163, 29)
        Me.cbAddProd.TabIndex = 1
        Me.cbAddProd.Text = "เพิ่มจำนวนสินค้า"
        Me.cbAddProd.UseVisualStyleBackColor = True
        '
        'cbRedProd
        '
        Me.cbRedProd.AutoSize = True
        Me.cbRedProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRedProd.Location = New System.Drawing.Point(230, 107)
        Me.cbRedProd.Name = "cbRedProd"
        Me.cbRedProd.Size = New System.Drawing.Size(153, 29)
        Me.cbRedProd.TabIndex = 2
        Me.cbRedProd.Text = "ลดจำนวนสินค้า"
        Me.cbRedProd.UseVisualStyleBackColor = True
        '
        'lbProdName
        '
        Me.lbProdName.AutoSize = True
        Me.lbProdName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbProdName.Location = New System.Drawing.Point(120, 27)
        Me.lbProdName.Name = "lbProdName"
        Me.lbProdName.Size = New System.Drawing.Size(80, 25)
        Me.lbProdName.TabIndex = 3
        Me.lbProdName.Text = "ชื่อสินค้า"
        '
        'tbProdQty
        '
        Me.tbProdQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProdQty.Location = New System.Drawing.Point(120, 147)
        Me.tbProdQty.Name = "tbProdQty"
        Me.tbProdQty.Size = New System.Drawing.Size(179, 31)
        Me.tbProdQty.TabIndex = 4
        '
        'lbQty
        '
        Me.lbQty.AutoSize = True
        Me.lbQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQty.Location = New System.Drawing.Point(41, 150)
        Me.lbQty.Name = "lbQty"
        Me.lbQty.Size = New System.Drawing.Size(73, 25)
        Me.lbQty.TabIndex = 5
        Me.lbQty.Text = "จำนวน:"
        '
        'lbhNowQty
        '
        Me.lbhNowQty.AutoSize = True
        Me.lbhNowQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbhNowQty.Location = New System.Drawing.Point(41, 64)
        Me.lbhNowQty.Name = "lbhNowQty"
        Me.lbhNowQty.Size = New System.Drawing.Size(175, 25)
        Me.lbhNowQty.TabIndex = 6
        Me.lbhNowQty.Text = "จำนวนสินค้าปัจจุบัน:"
        '
        'lbNowQty
        '
        Me.lbNowQty.AutoSize = True
        Me.lbNowQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNowQty.Location = New System.Drawing.Point(209, 64)
        Me.lbNowQty.Name = "lbNowQty"
        Me.lbNowQty.Size = New System.Drawing.Size(67, 25)
        Me.lbNowQty.TabIndex = 7
        Me.lbNowQty.Text = "จำนวน"
        '
        'lbCalQty
        '
        Me.lbCalQty.AutoSize = True
        Me.lbCalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCalQty.Location = New System.Drawing.Point(305, 153)
        Me.lbCalQty.Name = "lbCalQty"
        Me.lbCalQty.Size = New System.Drawing.Size(282, 25)
        Me.lbCalQty.TabIndex = 8
        Me.lbCalQty.Text = "(กรุณาเลือก เพิ่ม/ลด จำนวนสินค้า)"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(211, 193)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 34)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'AddProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 245)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lbCalQty)
        Me.Controls.Add(Me.lbNowQty)
        Me.Controls.Add(Me.lbhNowQty)
        Me.Controls.Add(Me.lbQty)
        Me.Controls.Add(Me.tbProdQty)
        Me.Controls.Add(Me.lbProdName)
        Me.Controls.Add(Me.cbRedProd)
        Me.Controls.Add(Me.cbAddProd)
        Me.Controls.Add(Me.lbhProdName)
        Me.Name = "AddProduct"
        Me.Text = "AddProduct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbhProdName As Label
    Friend WithEvents cbAddProd As CheckBox
    Friend WithEvents cbRedProd As CheckBox
    Friend WithEvents lbProdName As Label
    Friend WithEvents tbProdQty As TextBox
    Friend WithEvents lbQty As Label
    Friend WithEvents lbhNowQty As Label
    Friend WithEvents lbNowQty As Label
    Friend WithEvents lbCalQty As Label
    Friend WithEvents btnSave As Button
End Class
