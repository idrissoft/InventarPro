Imports System.Data.SqlClient
Public Class Fclientes
    Inherits Conection
    Public Function mostrar_clieintes()
        Dim dt As DataTable
        Dim cmd As New SqlCommand("select from cliente", con)
        cmd.Connection=con
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Class
