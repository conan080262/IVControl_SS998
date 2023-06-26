Public Class FormCheckData
    Private DT As DataTable

    Public Sub New(dt As DataTable)
        InitializeComponent()
        Me.DT = dt
    End Sub

    Private Sub CheckData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = DT
    End Sub


End Class