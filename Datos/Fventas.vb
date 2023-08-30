Imports System.Data.SqlClient
Public Class Fventas
    Inherits Conection
    Function mostrar_ventas()
        Try
            Conectado()
            Dim cmd As New SqlCommand("mostrar_ventas")
            cmd.CommandType = 4
            cmd.Connection = con
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectado()
        End Try
    End Function

End Class
