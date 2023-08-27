Imports System.Data.SqlClient
Public Class Fclientes
    Inherits Conection
    Public Function mostrar_clieintes()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("select * from clientes", con)
        conectado()
        cmd.Connection=con
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
