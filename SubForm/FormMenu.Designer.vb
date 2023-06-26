<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenu))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.panelBtnSlide = New System.Windows.Forms.Panel()
        Me.TimerPanelReduce = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelInc = New System.Windows.Forms.Timer(Me.components)
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.panelHeader = New System.Windows.Forms.Panel()
        Me.panelDesktopPane = New System.Windows.Forms.Panel()
        Me.btnStartSell = New System.Windows.Forms.Button()
        Me.btnSetting = New System.Windows.Forms.Button()
        Me.btnNoti = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnProduct = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnProdList1 = New System.Windows.Forms.RibbonButton()
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        Me.panelBtnSlide.SuspendLayout()
        Me.panelHeader.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.btnStartSell)
        Me.panelMenu.Controls.Add(Me.btnSetting)
        Me.panelMenu.Controls.Add(Me.btnNoti)
        Me.panelMenu.Controls.Add(Me.btnReport)
        Me.panelMenu.Controls.Add(Me.btnProduct)
        Me.panelMenu.Controls.Add(Me.btnHome)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Controls.Add(Me.panelBtnSlide)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.MaximumSize = New System.Drawing.Size(207, 0)
        Me.panelMenu.MinimumSize = New System.Drawing.Size(40, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(207, 557)
        Me.panelMenu.TabIndex = 0
        '
        'panelLogo
        '
        Me.panelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.panelLogo.Controls.Add(Me.PictureBox2)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 42)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(207, 81)
        Me.panelLogo.TabIndex = 1
        '
        'panelBtnSlide
        '
        Me.panelBtnSlide.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.panelBtnSlide.Controls.Add(Me.PictureBox1)
        Me.panelBtnSlide.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelBtnSlide.Location = New System.Drawing.Point(0, 0)
        Me.panelBtnSlide.Name = "panelBtnSlide"
        Me.panelBtnSlide.Size = New System.Drawing.Size(207, 42)
        Me.panelBtnSlide.TabIndex = 0
        '
        'TimerPanelReduce
        '
        Me.TimerPanelReduce.Interval = 30
        '
        'TimerPanelInc
        '
        Me.TimerPanelInc.Interval = 30
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Product"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTitle.Location = New System.Drawing.Point(435, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(79, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "HOME"
        '
        'panelHeader
        '
        Me.panelHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.panelHeader.Controls.Add(Me.lblTitle)
        Me.panelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelHeader.Location = New System.Drawing.Point(207, 0)
        Me.panelHeader.Name = "panelHeader"
        Me.panelHeader.Size = New System.Drawing.Size(1111, 42)
        Me.panelHeader.TabIndex = 1
        '
        'panelDesktopPane
        '
        Me.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelDesktopPane.Location = New System.Drawing.Point(207, 42)
        Me.panelDesktopPane.Name = "panelDesktopPane"
        Me.panelDesktopPane.Size = New System.Drawing.Size(1111, 515)
        Me.panelDesktopPane.TabIndex = 2
        '
        'btnStartSell
        '
        Me.btnStartSell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStartSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStartSell.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStartSell.FlatAppearance.BorderSize = 0
        Me.btnStartSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartSell.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartSell.ForeColor = System.Drawing.Color.Black
        Me.btnStartSell.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0013_Sale
        Me.btnStartSell.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStartSell.Location = New System.Drawing.Point(0, 393)
        Me.btnStartSell.Name = "btnStartSell"
        Me.btnStartSell.Size = New System.Drawing.Size(207, 54)
        Me.btnStartSell.TabIndex = 7
        Me.btnStartSell.Text = "Start Sell"
        Me.btnStartSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStartSell.UseVisualStyleBackColor = False
        '
        'btnSetting
        '
        Me.btnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSetting.FlatAppearance.BorderSize = 0
        Me.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.LightGray
        Me.btnSetting.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0021_Parcel
        Me.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetting.Location = New System.Drawing.Point(0, 339)
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(207, 54)
        Me.btnSetting.TabIndex = 5
        Me.btnSetting.Text = "  Setting"
        Me.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSetting.UseVisualStyleBackColor = True
        Me.btnSetting.Visible = False
        '
        'btnNoti
        '
        Me.btnNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNoti.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNoti.FlatAppearance.BorderSize = 0
        Me.btnNoti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoti.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNoti.ForeColor = System.Drawing.Color.LightGray
        Me.btnNoti.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0029_Mail
        Me.btnNoti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNoti.Location = New System.Drawing.Point(0, 285)
        Me.btnNoti.Name = "btnNoti"
        Me.btnNoti.Size = New System.Drawing.Size(207, 54)
        Me.btnNoti.TabIndex = 4
        Me.btnNoti.Text = "  Notification"
        Me.btnNoti.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNoti.UseVisualStyleBackColor = True
        Me.btnNoti.Visible = False
        '
        'btnReport
        '
        Me.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.LightGray
        Me.btnReport.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0008_Tag
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(0, 231)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(207, 54)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "  Report"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnProduct
        '
        Me.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnProduct.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProduct.FlatAppearance.BorderSize = 0
        Me.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProduct.ForeColor = System.Drawing.Color.LightGray
        Me.btnProduct.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0001_Cart2
        Me.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProduct.Location = New System.Drawing.Point(0, 177)
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.Size = New System.Drawing.Size(207, 54)
        Me.btnProduct.TabIndex = 2
        Me.btnProduct.Text = "  Product"
        Me.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProduct.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHome.FlatAppearance.BorderSize = 0
        Me.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.ForeColor = System.Drawing.Color.LightGray
        Me.btnHome.Image = Global.IVControl_SS998.My.Resources.Resources.ICON_0027_Sun_Glasses
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(0, 123)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(207, 54)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox2.Image = Global.IVControl_SS998.My.Resources.Resources.program1
        Me.PictureBox2.Location = New System.Drawing.Point(67, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.IVControl_SS998.My.Resources.Resources.menu
        Me.PictureBox1.Location = New System.Drawing.Point(167, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnProdList1
        '
        Me.btnProdList1.Image = CType(resources.GetObject("btnProdList1.Image"), System.Drawing.Image)
        Me.btnProdList1.LargeImage = CType(resources.GetObject("btnProdList1.LargeImage"), System.Drawing.Image)
        Me.btnProdList1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnProdList1.Name = "btnProdList1"
        Me.btnProdList1.SmallImage = CType(resources.GetObject("btnProdList1.SmallImage"), System.Drawing.Image)
        Me.btnProdList1.Text = "Product List"
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 557)
        Me.Controls.Add(Me.panelDesktopPane)
        Me.Controls.Add(Me.panelHeader)
        Me.Controls.Add(Me.panelMenu)
        Me.KeyPreview = True
        Me.Name = "FormMenu"
        Me.Text = "FormMenu"
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        Me.panelBtnSlide.ResumeLayout(False)
        Me.panelHeader.ResumeLayout(False)
        Me.panelHeader.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelBtnSlide As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnProduct As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSetting As Button
    Friend WithEvents btnNoti As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents TimerPanelReduce As Timer
    Friend WithEvents TimerPanelInc As Timer
    Friend WithEvents btnStartSell As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents lblTitle As Label
    Friend WithEvents panelHeader As Panel
    Friend WithEvents btnProdList1 As RibbonButton
    Friend WithEvents panelDesktopPane As Panel
End Class
