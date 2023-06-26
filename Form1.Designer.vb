<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbUsername = New System.Windows.Forms.Label()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.gbLogin = New System.Windows.Forms.GroupBox()
        Me.llbLogin = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbPassword = New System.Windows.Forms.Label()
        Me.cbUsername = New System.Windows.Forms.ComboBox()
        Me.gbLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbUsername
        '
        Me.lbUsername.AutoSize = True
        Me.lbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsername.Location = New System.Drawing.Point(55, 58)
        Me.lbUsername.Name = "lbUsername"
        Me.lbUsername.Size = New System.Drawing.Size(63, 25)
        Me.lbUsername.TabIndex = 0
        Me.lbUsername.Text = "User:"
        '
        'tbPassword
        '
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.Location = New System.Drawing.Point(159, 116)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(183, 31)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.UseSystemPasswordChar = True
        '
        'gbLogin
        '
        Me.gbLogin.Controls.Add(Me.llbLogin)
        Me.gbLogin.Controls.Add(Me.PictureBox1)
        Me.gbLogin.Controls.Add(Me.lbPassword)
        Me.gbLogin.Controls.Add(Me.cbUsername)
        Me.gbLogin.Controls.Add(Me.tbPassword)
        Me.gbLogin.Controls.Add(Me.lbUsername)
        Me.gbLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLogin.Location = New System.Drawing.Point(12, 12)
        Me.gbLogin.Name = "gbLogin"
        Me.gbLogin.Size = New System.Drawing.Size(552, 187)
        Me.gbLogin.TabIndex = 2
        Me.gbLogin.TabStop = False
        Me.gbLogin.Text = "Inventory Control Login"
        '
        'llbLogin
        '
        Me.llbLogin.AutoSize = True
        Me.llbLogin.Location = New System.Drawing.Point(215, 152)
        Me.llbLogin.Name = "llbLogin"
        Me.llbLogin.Size = New System.Drawing.Size(70, 25)
        Me.llbLogin.TabIndex = 5
        Me.llbLogin.TabStop = True
        Me.llbLogin.Text = "Login"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IVControl_SS998.My.Resources.Resources.program
        Me.PictureBox1.Location = New System.Drawing.Point(376, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(164, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lbPassword
        '
        Me.lbPassword.AutoSize = True
        Me.lbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPassword.Location = New System.Drawing.Point(55, 119)
        Me.lbPassword.Name = "lbPassword"
        Me.lbPassword.Size = New System.Drawing.Size(66, 25)
        Me.lbPassword.TabIndex = 3
        Me.lbPassword.Text = "Pass:"
        '
        'cbUsername
        '
        Me.cbUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUsername.FormattingEnabled = True
        Me.cbUsername.Location = New System.Drawing.Point(159, 55)
        Me.cbUsername.Name = "cbUsername"
        Me.cbUsername.Size = New System.Drawing.Size(183, 33)
        Me.cbUsername.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 211)
        Me.Controls.Add(Me.gbLogin)
        Me.Name = "Form1"
        Me.Text = "InventoryControl SuwanService998"
        Me.gbLogin.ResumeLayout(False)
        Me.gbLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbUsername As Label
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents gbLogin As GroupBox
    Friend WithEvents lbPassword As Label
    Friend WithEvents cbUsername As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents llbLogin As LinkLabel
End Class
