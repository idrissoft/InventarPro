Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

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
    Sub Add_venta(ByVal dts As Vventas, dt As vdetalle_de_ventas)
        'agregar nueva venta

        Try
            Conectado()
            Dim cmd As New SqlCommand("insertar_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = con}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Fecha_venta", dts.GFecha_venta)
            cmd.Parameters.AddWithValue("@ID_Cliente", dts.GID_cliente)
            cmd.Parameters.AddWithValue("@total", dts.Gtotal)
            dts.id_Ventas = cmd.ExecuteScalar()
            'Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            'Return False
        Finally
            Desconectado()
        End Try


        'Dim command As New SqlCommand("INSERT INTO libros(nombre, autor, precio, ficha, description,estado) OUTPUT INSERTED.idlibro VALUES (@nombre, @autor, @precio, @ficha, @description,@estado)", con)
        'command.Parameters.AddWithValue("@nombre", TextBox1.Text)
        'command.Parameters.AddWithValue("@autor", TextBox2.Text)
        'command.Parameters.AddWithValue("@precio", TextBox3.Text)
        'command.Parameters.AddWithValue("@ficha", DateTimePicker1.Value)
        'command.Parameters.AddWithValue("@description", TextBox4.Text)
        'command.Parameters.AddWithValue("@estado", "activo")
        'con.Open()
        'dts.id_Ventas = command.ExecuteScalar()
        'con.Close()

        'agregar nueva detalle de venta
        Try
            Conectado()
            Dim cmd1 As New SqlCommand("insertar_detalle_venta ") With {.CommandType = CommandType.StoredProcedure, .Connection = con}
            cmd1.CommandType = CommandType.StoredProcedure
            cmd1.Connection = con

            cmd1.Parameters.AddWithValue("@ID_Ventas", dts.id_Ventas)
            cmd1.Parameters.AddWithValue("@ID_Producto", dt.ID_Producto)
            cmd1.Parameters.AddWithValue("@Cantidad_ventas", dt.Cantidad_ventas)
            cmd1.Parameters.AddWithValue("@Precio_Unitario", dt.Precio_Unitario)
            cmd1.Parameters.AddWithValue("@subtotal", dt.Subtotal)

            Dim executeNonQuery As Integer = cmd1.ExecuteNonQuery
            'Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            'Return False
        Finally
            Desconectado()
        End Try
    End Sub

    Function mostrar_detalle_ventas()
        Try
            Conectado()
            Dim cmd As New SqlCommand("mostrar_detalle_ventas")
            cmd.CommandType = 4
            cmd.Connection = con
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
            Desconectado()
        End Try
    End Function
End Class
