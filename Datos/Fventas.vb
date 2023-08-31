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
    Function Add_venta(ByVal dts As Vventas)
        Try
            Conectado()
            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = con}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Fecha_venta", dts.GFecha_venta)
            cmd.Parameters.AddWithValue("@ID_Cliente", dts.GID_cliente)
            cmd.Parameters.AddWithValue("@total", dts.Gtotal)

            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
End Class
