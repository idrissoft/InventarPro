
Imports System.Data.SqlClient


Public Class Fproductos

    Inherits Conection

    Function mostrar_productos()
        Try
            conectado()
            Dim cmd = New SqlCommand("mostrar_cliente")
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
            desconectado()
        End Try
    End Function

    Function add_productos(ByVal dts As Vproductos)
        Try
            conectado()
            Dim cmd As New SqlCommand("insertar_productos ")
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
    Function modificar_productos(ByVal dts As Vproductos)
        Try
            conectado()
            Dim cmd As New SqlCommand("editar_productos ")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@id_productos", dts.gid_productos)
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
    Function eliminar_productos(ByVal dts As Vproductos)
        Dim prof As New productos()
        Try
            conectado()
            Dim cmd As New SqlCommand("delete from productos WHERE id_Productos= @id_Productos")
            cmd.Parameters.AddWithValue("@id_Productos", dts.gid_productos)
            cmd.Connection = con
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try

    End Function

End Class


