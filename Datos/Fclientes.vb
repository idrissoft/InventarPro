Imports System.Data.SqlClient
Public Class Fclientes
    Inherits Conection
    Public Function Mostrar_clieintes()
        Dim dt As New DataTable()
        Dim cmd As New SqlCommand("select * from clientes", con)
        Conectado()
        cmd.Connection = con
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
