<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReport))
        Me.btnSellHis = New System.Windows.Forms.RibbonButton()
        Me.btnProdList = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel2 = New System.Windows.Forms.RibbonPanel()
        Me.RibbonPanel1 = New System.Windows.Forms.RibbonPanel()
        Me.TabControl1 = New MdiTabControl.TabControl()
        Me.RibbonButton1 = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel3 = New System.Windows.Forms.RibbonPanel()
        Me.Ribbon1 = New System.Windows.Forms.Ribbon()
        Me.RibbonTab1 = New System.Windows.Forms.RibbonTab()
        Me.RibbonPanel4 = New System.Windows.Forms.RibbonPanel()
        Me.btnSellHistory = New System.Windows.Forms.RibbonButton()
        Me.RibbonPanel5 = New System.Windows.Forms.RibbonPanel()
        Me.btnProductList = New System.Windows.Forms.RibbonButton()
        Me.TabControl2 = New MdiTabControl.TabControl()
        Me.RibbonPanel6 = New System.Windows.Forms.RibbonPanel()
        Me.SuspendLayout()
        '
        'btnSellHis
        '
        Me.btnSellHis.Image = CType(resources.GetObject("btnSellHis.Image"), System.Drawing.Image)
        Me.btnSellHis.LargeImage = CType(resources.GetObject("btnSellHis.LargeImage"), System.Drawing.Image)
        Me.btnSellHis.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnSellHis.Name = "btnSellHis"
        Me.btnSellHis.SmallImage = CType(resources.GetObject("btnSellHis.SmallImage"), System.Drawing.Image)
        Me.btnSellHis.Text = "Sell History"
        '
        'btnProdList
        '
        Me.btnProdList.Image = CType(resources.GetObject("btnProdList.Image"), System.Drawing.Image)
        Me.btnProdList.LargeImage = CType(resources.GetObject("btnProdList.LargeImage"), System.Drawing.Image)
        Me.btnProdList.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnProdList.Name = "btnProdList"
        Me.btnProdList.SmallImage = CType(resources.GetObject("btnProdList.SmallImage"), System.Drawing.Image)
        Me.btnProdList.Text = "Product List"
        '
        'RibbonPanel2
        '
        Me.RibbonPanel2.Items.Add(Me.btnProdList)
        Me.RibbonPanel2.Name = "RibbonPanel2"
        Me.RibbonPanel2.Text = "Product"
        '
        'RibbonPanel1
        '
        Me.RibbonPanel1.Items.Add(Me.btnSellHis)
        Me.RibbonPanel1.Name = "RibbonPanel1"
        Me.RibbonPanel1.Text = "Sell"
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(800, 450)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 2
        '
        'RibbonButton1
        '
        Me.RibbonButton1.Image = CType(resources.GetObject("RibbonButton1.Image"), System.Drawing.Image)
        Me.RibbonButton1.LargeImage = CType(resources.GetObject("RibbonButton1.LargeImage"), System.Drawing.Image)
        Me.RibbonButton1.MinimumSize = New System.Drawing.Size(80, 0)
        Me.RibbonButton1.Name = "RibbonButton1"
        Me.RibbonButton1.SmallImage = CType(resources.GetObject("RibbonButton1.SmallImage"), System.Drawing.Image)
        Me.RibbonButton1.Text = "Sell History"
        '
        'RibbonPanel3
        '
        Me.RibbonPanel3.Items.Add(Me.RibbonButton1)
        Me.RibbonPanel3.Name = "RibbonPanel3"
        Me.RibbonPanel3.Text = "Sell"
        '
        'Ribbon1
        '
        Me.Ribbon1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Ribbon1.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.Minimized = False
        Me.Ribbon1.Name = "Ribbon1"
        '
        '
        '
        Me.Ribbon1.OrbDropDown.BorderRoundness = 8
        Me.Ribbon1.OrbDropDown.Location = New System.Drawing.Point(0, 0)
        Me.Ribbon1.OrbDropDown.Name = ""
        Me.Ribbon1.OrbDropDown.Size = New System.Drawing.Size(527, 72)
        Me.Ribbon1.OrbDropDown.TabIndex = 0
        Me.Ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010
        Me.Ribbon1.OrbText = "Report"
        '
        '
        '
        Me.Ribbon1.QuickAccessToolbar.AltKey = "m"
        Me.Ribbon1.QuickAccessToolbar.DropDownButtonVisible = False
        Me.Ribbon1.RibbonTabFont = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Ribbon1.Size = New System.Drawing.Size(800, 135)
        Me.Ribbon1.TabIndex = 1
        Me.Ribbon1.Tabs.Add(Me.RibbonTab1)
        Me.Ribbon1.TabSpacing = 3
        Me.Ribbon1.Text = "Ribbon1"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel4)
        Me.RibbonTab1.Panels.Add(Me.RibbonPanel5)
        Me.RibbonTab1.Text = "Product"
        '
        'RibbonPanel4
        '
        Me.RibbonPanel4.Items.Add(Me.btnSellHistory)
        Me.RibbonPanel4.Name = "RibbonPanel4"
        Me.RibbonPanel4.Text = "Sell"
        '
        'btnSellHistory
        '
        Me.btnSellHistory.Image = CType(resources.GetObject("btnSellHistory.Image"), System.Drawing.Image)
        Me.btnSellHistory.LargeImage = CType(resources.GetObject("btnSellHistory.LargeImage"), System.Drawing.Image)
        Me.btnSellHistory.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnSellHistory.Name = "btnSellHistory"
        Me.btnSellHistory.SmallImage = CType(resources.GetObject("btnSellHistory.SmallImage"), System.Drawing.Image)
        Me.btnSellHistory.Text = "Sell History"
        '
        'RibbonPanel5
        '
        Me.RibbonPanel5.Items.Add(Me.btnProductList)
        Me.RibbonPanel5.Name = "RibbonPanel5"
        Me.RibbonPanel5.Text = "Product"
        '
        'btnProductList
        '
        Me.btnProductList.Image = CType(resources.GetObject("btnProductList.Image"), System.Drawing.Image)
        Me.btnProductList.LargeImage = CType(resources.GetObject("btnProductList.LargeImage"), System.Drawing.Image)
        Me.btnProductList.MinimumSize = New System.Drawing.Size(80, 0)
        Me.btnProductList.Name = "btnProductList"
        Me.btnProductList.SmallImage = CType(resources.GetObject("btnProductList.SmallImage"), System.Drawing.Image)
        Me.btnProductList.Text = "Product List"
        '
        'TabControl2
        '
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 135)
        Me.TabControl2.MenuRenderer = Nothing
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.Size = New System.Drawing.Size(800, 315)
        Me.TabControl2.TabCloseButtonImage = Nothing
        Me.TabControl2.TabCloseButtonImageDisabled = Nothing
        Me.TabControl2.TabCloseButtonImageHot = Nothing
        Me.TabControl2.TabIndex = 2
        '
        'RibbonPanel6
        '
        Me.RibbonPanel6.Items.Add(Me.btnProdList)
        Me.RibbonPanel6.Name = "RibbonPanel6"
        Me.RibbonPanel6.Text = "Product"
        '
        'FormReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Ribbon1)
        Me.KeyPreview = True
        Me.Name = "FormReport"
        Me.Text = "FormReport"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSellHis As RibbonButton
    Friend WithEvents btnProdList As RibbonButton
    Friend WithEvents RibbonPanel2 As RibbonPanel
    Friend WithEvents RibbonPanel1 As RibbonPanel
    Friend WithEvents TabControl1 As MdiTabControl.TabControl
    Friend WithEvents RibbonButton1 As RibbonButton
    Friend WithEvents RibbonPanel3 As RibbonPanel
    Friend WithEvents Ribbon1 As Ribbon
    Friend WithEvents RibbonTab1 As RibbonTab
    Friend WithEvents RibbonPanel4 As RibbonPanel
    Friend WithEvents RibbonPanel5 As RibbonPanel
    Friend WithEvents TabControl2 As MdiTabControl.TabControl
    Friend WithEvents RibbonPanel6 As RibbonPanel
    Friend WithEvents btnSellHistory As RibbonButton
    Friend WithEvents btnProductList As RibbonButton
End Class
