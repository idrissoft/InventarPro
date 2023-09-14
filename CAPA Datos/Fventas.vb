Imports System.Data.SqlClient


Public Class Fventas

    Inherits Conection

    Function Get_ventas() As DataTable
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
    Sub Add_venta(ByVal Vvent As Vventas, V_det_vent As vdetalle_de_ventas, Vpro As Vproductos)
        Try
            GetConnection()
            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = GetConnection()

            cmd.Parameters.AddWithValue("@_fecha_venta", Vvent.Fecha_venta)
            cmd.Parameters.AddWithValue("@ID_Cliente", Vvent.ID_cliente)
            cmd.Parameters.AddWithValue("@Total", Vvent.Total)
            Vvent._id_ventas = Convert.ToInt32(cmd.ExecuteScalar())
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
            cmd1.Parameters.AddWithValue("@_id_ventas", Vvent._id_ventas)
            cmd1.Parameters.AddWithValue("@_id_producto", V_det_vent.id_producto)
            cmd1.Parameters.AddWithValue("@_cantidad_ventas", V_det_vent.cantidad_ventas)
            cmd1.Parameters.AddWithValue("@_precio_unitario", V_det_vent.precio_unitario)
            cmd1.Parameters.AddWithValue("@subtotal", V_det_vent.subtotal)
            Dim executeNonQuery As Integer = cmd1.ExecuteNonQuery

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try

    End Sub
    Sub Acualisacion_stock(ByVal dt As vdetalle_de_ventas, d As Vproductos)

        Dim Stock_Actual As Integer = d.Stock_Actual - dt.cantidad_ventas
        Dim ID_Producto As Integer = dt.id_producto
        If Stock_Actual > 0 Then
            Dim updateStockQuery As String = "EXEC update_productos @_stock_actual, @ID_Productos"
            Dim updateStockCmd As New SqlCommand(updateStockQuery, GetConnection)
            updateStockCmd.Parameters.AddWithValue("@_stock_actual", Stock_Actual)
            updateStockCmd.Parameters.AddWithValue("@id_Productos", ID_Producto)
            updateStockCmd.ExecuteNonQuery()
            CloseConnection()
        Else

            MessageBox.Show("No hay suficiente stock para completar la operación.")
        End If
    End Sub
    Function Get_detalle_ventas(ID_Ventas As Integer) As DataTable
        Dim dt1 As New DataTable
        Dim da As New SqlDataAdapter
        Try
            GetConnection()
            Dim cmd As New SqlCommand("mostrar_detalle_ventas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = GetConnection()
            cmd.Parameters.AddWithValue("@id_ventas", ID_Ventas)
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
