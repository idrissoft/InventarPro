Imports System.Data.SqlClient


Public MustInherit Class Conection
    Private _connection As New SqlConnection
    Friend Function GetConnection() As SqlConnection
        Try
            _connection = New SqlConnection("server=MBWS093\SQLEXPRESS; database=InventarPro; integrated security=true")
            _connection.Open()
            Return _connection
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try
    End Function
    Friend Function CloseConnection() As Boolean
        Dim result As Boolean

        result = False
        Try
            If _connection.State <> ConnectionState.Closed Then
                _connection.Close()
                result = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return result
    End Function


End Class
