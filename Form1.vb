Public Class Form1
    Dim SQL As New SQLControl

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreloadUsername()

    End Sub
    Private Sub PreloadUsername()

        Dim sqlcmd As String = "SELECT username from tb_user"
        SQL.ExecQuery(sqlcmd)
        If SQL.HasException() Then
            Exit Sub
        End If

        If SQL.RecordCount > 0 Then
            For Each row As DataRow In SQL.DBDT.Rows
                Dim username As String = row("Username")
                cbUsername.Items.Add(row("Username"))
            Next
        Else
            cbUsername.Items.Clear()

        End If

    End Sub

    Private Sub llbLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llbLogin.LinkClicked

        Dim sqlcmd As String = "SELECT TOP 1 * from tb_user WHERE username = @username And password = @password"

        If Not String.IsNullOrEmpty(cbUsername.SelectedItem) Then
            SQL.AddParams("@username", cbUsername.SelectedItem.ToString())
        End If

        If Not String.IsNullOrEmpty(tbPassword.Text) Then
            SQL.AddParams("@password", tbPassword.Text.ToString())
        End If



        SQL.ExecQuery(sqlcmd)
        If SQL.RecordCount > 0 Then
            ETCModule.MyNOWUSER.Username = SQL.DBDT.Rows(0).Item("username")
            Me.Hide()
            FormMenu.Show()
        Else
            MsgBox("ข้อมูลไม่ถูกต้อง")

        End If

    End Sub
End Class
