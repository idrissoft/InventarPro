
Imports System.Data.SqlClient
Public Class Fproductos

    Inherits Conection
    Function Mostrar_productos()
        Try
            Conectado()
            Dim cmd As New SqlCommand("mostrar_cliente") With {.CommandType = CommandType.StoredProcedure, .Connection = con}
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

    Function Add_productos(ByVal dts As Vproductos)
        Try
            conectado()
            Dim cmd As New SqlCommand("insertar_productos ") With {
            .CommandType = CommandType.StoredProcedure,
            .Connection = con}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@nombre", dts.Gnombre)
            cmd.Parameters.AddWithValue("@cantidad", dts.gcantidad)
            cmd.Parameters.AddWithValue("@description", dts.Gdescription)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function
    Function Modificar_productos(ByVal dts As Vproductos)
        Try
            Conectado()
            Dim cmd As New SqlCommand("editar_productos ") With {.CommandType = CommandType.StoredProcedure, .Connection = con}
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@id_productos", dts.Gid_productos)
            cmd.Parameters.AddWithValue("@nombre", dts.Gnombre)
            cmd.Parameters.AddWithValue("@cantidad", dts.Gcantidad)
            cmd.Parameters.AddWithValue("@description", dts.Gdescription)
            cmd.Parameters.AddWithValue("@precio", dts.Gprecio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectado()
        End Try
    End Function
    Function Eliminar_productos(ByVal dts As Vproductos)
        Dim prof As New productos()
        Try
            Conectado()
            Dim cmd As New SqlCommand("delete from productos WHERE id_Productos= @id_Productos")
            cmd.Parameters.AddWithValue("@id_Productos", dts.gid_productos)
            cmd.Connection = con
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


