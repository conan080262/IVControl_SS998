Imports System.Data.SqlClient

Public Class SQLControl
    Private DBCon As New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=DBStockControl;Integrated Security=True;")
    Private DBCmd As SqlCommand

    'DB Data
    Public DBDA As SqlDataAdapter
    Public DBDT As DataTable

    'Query Parameters
    Public Params As New List(Of SqlParameter)

    'Query Stat
    Public RecordCount As Integer
    Public stException As String = ""

    Public Sub New()

    End Sub

    Public Sub New(ConnectionString As String)
        DBCon = New SqlConnection(ConnectionString)
    End Sub

    'Excute Query
    Public Sub ExecQuery(Query As String)
        RecordCount = 0
        stException = ""

        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))

            Params.Clear()
            DBDT = New DataTable
            DBDA = New SqlDataAdapter(DBCmd)

            RecordCount = DBDA.Fill(DBDT)


        Catch ex As Exception
            stException = "ExecQuery Error: " & ex.Message
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try


    End Sub

    Public Function ExecQuery_SCOPE_IDENTITY(Query As String) As Integer
        RecordCount = 0
        stException = ""

        Try
            DBCon.Open()

            DBCmd = New SqlCommand(Query, DBCon)

            Params.ForEach(Sub(p) DBCmd.Parameters.Add(p))
            Params.Clear()

            Dim lastInsertedID As Integer = Convert.ToInt32(DBCmd.ExecuteScalar())
            Return lastInsertedID

        Catch ex As Exception
            stException = "ExecQuery Error: " & ex.Message
        Finally
            If DBCon.State = ConnectionState.Open Then
                DBCon.Close()
            End If
        End Try


    End Function

    Public Sub AddParams(Name As String, Value As Object)

        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(stException) Then
            If Report = True Then
                MsgBox("Pass", MsgBoxStyle.OkOnly, "Success:")
            End If
            Return False
        Else
            MsgBox(stException, MsgBoxStyle.Critical, "Error:")
            Return True
        End If

    End Function

End Class
