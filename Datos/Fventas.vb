Imports System.Data.SqlClient


Public Class Fventas

    Inherits Conection

    Function mostrar_ventas() As DataTable
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Try

            cmd = New SqlCommand("mostrar_ventas") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = GetConnection()
            da = New SqlDataAdapter(cmd)


            da.Fill(dt)


        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CloseConnection()
        End Try
        Return dt
    End Function
    Sub Add_venta(ByVal dts As Vventas, dt As vdetalle_de_ventas)
        Try
            GetConnection()
            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = GetConnection()

            cmd.Parameters.AddWithValue("@Fecha_venta", dts.GFecha_venta)
            cmd.Parameters.AddWithValue("@ID_Cliente", dts.GID_cliente)
            cmd.Parameters.AddWithValue("@total", dts.Gtotal)
            dts.id_Ventas = Convert.ToInt32(cmd.ExecuteScalar())

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try


        'agregar nueva detalle de venta
        Try

            Dim cmd1 As New SqlCommand("insertar_detalle_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Connection = GetConnection()

            cmd1.Parameters.AddWithValue("@ID_Ventas", dts.id_Ventas)
            cmd1.Parameters.AddWithValue("@ID_Producto", dt.ID_Producto)
            cmd1.Parameters.AddWithValue("@Cantidad_ventas", dt.Cantidad_ventas)
            cmd1.Parameters.AddWithValue("@Precio_Unitario", dt.Precio_Unitario)
            cmd1.Parameters.AddWithValue("@subtotal", dt.Subtotal)

            Dim executeNonQuery As Integer = cmd1.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try
    End Sub

    Function mostrar_detalle_ventas(ID_Ventas As Integer) As DataTable
        Dim dt1 As New DataTable
        Dim da As New SqlDataAdapter
        Try
            GetConnection()
            Dim cmd As New SqlCommand("mostrar_detalle_ventas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = GetConnection()
            cmd.Parameters.AddWithValue("@ID_Ventas", ID_Ventas)
            da = New SqlDataAdapter(cmd)
            da.Fill(dt1)
            Return dt1
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function
End Class
