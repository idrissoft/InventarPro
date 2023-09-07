Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Fventas

    Inherits Conection

    Function mostrar_ventas()
        Try
            GetConnection()
            Dim cmd As New SqlCommand("mostrar_ventas")
            cmd.CommandType = 4
            cmd.Connection = Con
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
            CloseConnection()
        End Try
    End Function
    Sub Add_venta(ByVal dts As Vventas, dt As vdetalle_de_ventas)
        'agregar nueva venta

        Try
            GetConnection()
            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = Con}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Fecha_venta", dts.GFecha_venta)
            cmd.Parameters.AddWithValue("@ID_Cliente", dts.GID_cliente)
            cmd.Parameters.AddWithValue("@total", dts.Gtotal)
            dts.id_Ventas = cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try


        'agregar nueva detalle de venta
        Try
            GetConnection()
            Dim cmd1 As New SqlCommand("insertar_detalle_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = Con}
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Connection = Con

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
        Try
            GetConnection()
            Dim cmd As New SqlCommand("mostrar_detalle_ventas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con


            cmd.Parameters.AddWithValue("@ID_Ventas", ID_Ventas)
            If cmd.ExecuteNonQuery Then
                Dim dt1 As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt1)

                Return dt1

            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            CloseConnection()
        End Try
    End Function
End Class
