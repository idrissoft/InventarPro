Imports System.Data.SqlClient
Public Class Fclientes
    Inherits Conection

    Friend Function Get_clientes() As DataTable
        Dim dt As New DataTable()
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        cmd = New SqlCommand("select * from clientes", GetConnection())

        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function

End Class
