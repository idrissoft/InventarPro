
Imports System.Data.SqlClient
Public Class Dproductos

    Inherits Conection
    Friend Function Get_productos() As DataTable
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Dim cmd As SqlCommand

        Try
            cmd = New SqlCommand With {
            .CommandText = "mostrar_cliente",
            .CommandType = CommandType.StoredProcedure,
            .Connection = GetConnection()
            }

            da = New SqlDataAdapter(cmd)

            da.Fill(dt)

        Catch ex As Exception
            MsgBox(ex.Message)
            dt = Nothing
        Finally
            CloseConnection()
        End Try

        Return dt

    End Function

    Friend Function Add_productos(Epro As Eproductos) As Boolean
        Try

            Dim cmd As New SqlCommand("insertar_productos ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.Parameters.AddWithValue("@_nombre", Epro.nombre)
            cmd.Parameters.AddWithValue("@cantidad", Epro.cantidad)
            cmd.Parameters.AddWithValue("@_description", Epro.description)
            cmd.Parameters.AddWithValue("@precio", Epro.precio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery()
            Return executeNonQuery > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Function Modificar_productos(ByVal Epro As Eproductos) As Boolean
        Try

            Dim cmd As New SqlCommand("editar_productos ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}

            cmd.Parameters.AddWithValue("@_id_productos", Epro.id_productos)
            cmd.Parameters.AddWithValue("@_nombre", Epro.nombre)
            cmd.Parameters.AddWithValue("@cantidad", Epro.cantidad)
            cmd.Parameters.AddWithValue("@_description", Epro.description)
            cmd.Parameters.AddWithValue("@precio", Epro.precio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Function Eliminar_productos(ByVal Epro As Eproductos) As Boolean
        Dim prof As New productos()
        Try

            Dim cmd As New SqlCommand("delete from productos WHERE id_Productos= @id_Productos")
            cmd.Parameters.AddWithValue("@id_Productos", Epro.id_productos)
            cmd.Connection = GetConnection()
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Function Buscar_productos(Epro As Eproductos) As DataTable

        Dim dt As New DataTable()
        Using conn As SqlConnection = GetConnection()
            Dim da As New SqlDataAdapter("buscar_productos", conn)
            da.SelectCommand.CommandType = CommandType.StoredProcedure

            da.SelectCommand.Parameters.AddWithValue("@letra", Epro.nombre)
            da.Fill(dt)
        End Using
        Return dt
    End Function
End Class


