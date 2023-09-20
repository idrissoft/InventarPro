Imports System.Data.SqlClient


Public Class Dventas

    Inherits Conection

    Friend Function Get_ventas() As DataTable
        Dim dt As New DataTable()
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand
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

    Friend Function ObtenerNombresClientes() As List(Of String)
        Dim nombres As New List(Of String)()

        Dim query As String = "SELECT nombre FROM Clientes"
        Dim cmd As New SqlCommand(query, GetConnection)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                nombres.Add(reader("nombre").ToString())
            End While
        End Using

        Return nombres
    End Function
    Friend Function ObtenerNombresproductos() As List(Of String)
        Dim nombres As New List(Of String)()

        Dim query As String = "SELECT nombre FROM Productos"
        Dim cmd As New SqlCommand(query, GetConnection)

        Using reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                nombres.Add(reader("nombre").ToString())
            End While
        End Using

        Return nombres
    End Function
    Sub Add_venta(ByVal Vvent As Eventas, Vdet_vent As Edetalle_de_ventas, Vpro As Eproductos)
        Try

            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.Parameters.AddWithValue("@fecha_venta", Vvent.Fecha_venta)
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
            cmd1.Parameters.AddWithValue("@Id_ventas", Vvent.id_ventas)
            cmd1.Parameters.AddWithValue("@Id_producto", Vdet_vent.Id_producto)
            cmd1.Parameters.AddWithValue("@Cantidad_ventas", Vdet_vent.Cantidad_ventas)
            cmd1.Parameters.AddWithValue("@Precio_unitario", Vdet_vent.Precio_unitario)
            cmd1.Parameters.AddWithValue("@Subtotal", Vdet_vent.Subtotal)
            Dim executeNonQuery As Integer = cmd1.ExecuteNonQuery
            MessageBox.Show("la Dventa ha creado correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try

    End Sub
    Sub Acualisacion_stock(ByVal dt As Edetalle_de_ventas, d As Eproductos)
        Try
            Dim Stock_Actual As Integer = d.Stock_Actual - dt.Cantidad_ventas
            Dim ID_Productos As Integer = dt.Id_producto
            'If Stock_Actual > 0 Then
            Dim updateStockQuery As String = "EXEC update_productos @stock_actual, @ID_Productos"
            Dim updateStockCmd As New SqlCommand(updateStockQuery, GetConnection)
            updateStockCmd.Parameters.AddWithValue("@stock_actual", Stock_Actual)
            updateStockCmd.Parameters.AddWithValue("@ID_Productos", ID_Productos)
            updateStockCmd.ExecuteNonQuery()
            '    CloseConnection()
            'Else

            '    MessageBox.Show("No hay suficiente stock para completar la operación.")
            'End If
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            CloseConnection()
        End Try
    End Sub
    Friend Function Get_detalle_ventas(ID_Ventas As Integer) As DataTable
        Dim dt1 As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand
        Try

            cmd = New SqlCommand("mostrar_detalle_ventas") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.Parameters.AddWithValue("@Id_ventas", ID_Ventas)
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
