Imports System.Windows

Public Class FormMenu

    'Partial Public Class FormMenu
    '    Inherits RibbonForm

    '    Public Sub New()
    '        InitializeComponent()
    '    End Sub

    '    ' Other code for the form

    'End Class

    Public activeForm1 As Form

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If panelMenu.Width > 40 Then
            TimerPanelReduce.Enabled = True
        Else
            TimerPanelInc.Enabled = True
        End If
    End Sub
    Private Sub TimerPanelReduce_Tick(sender As Object, e As EventArgs) Handles TimerPanelReduce.Tick

        If panelMenu.Width > 40 Then
            btnHome.Text = ""
            btnNoti.Text = ""
            btnProduct.Text = ""
            btnReport.Text = ""
            btnSetting.Text = ""
            btnStartSell.Text = ""
            panelMenu.Width = panelMenu.Width - 10
        Else
            TimerPanelReduce.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelInc_Tick(sender As Object, e As EventArgs) Handles TimerPanelInc.Tick

        If panelMenu.Width < 207 Then
            panelMenu.Width = panelMenu.Width + 10
        Else
            btnHome.Text = "About"
            btnNoti.Text = "Notification"
            btnProduct.Text = "Product"
            btnReport.Text = "Report"
            btnSetting.Text = "Setting"
            btnStartSell.Text = "Start Sell"
            TimerPanelInc.Enabled = False
        End If
    End Sub

    Private Sub OpenChildForm(childForm As Form, btnSender As Object)
        If activeForm1 IsNot Nothing Then activeForm1.Close()
        activeForm1 = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Me.panelDesktopPane.Controls.Add(childForm)
        Me.panelDesktopPane.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblTitle.Text = childForm.Text

    End Sub

    Private Sub btnProduct_Click(sender As Object, e As EventArgs) Handles btnProduct.Click
        OpenChildForm(New FormProduct(), sender)
    End Sub
    Public Function ReturnActiveForm() As Form
        Return activeForm1
    End Function

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        OpenChildForm(New FormHome(), sender)
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        OpenChildForm(New FormReport(), sender)
    End Sub

    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click
        OpenChildForm(New FormNoti(), sender)
    End Sub

    Private Sub btnSetting_Click(sender As Object, e As EventArgs) Handles btnSetting.Click
        OpenChildForm(New FormSetting(), sender)
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub FormMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub btnStartSell_Click(sender As Object, e As EventArgs) Handles btnStartSell.Click
        Me.Hide()
        FormSell.Show()

    End Sub
End Class