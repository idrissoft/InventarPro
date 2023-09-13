﻿
Imports System.Data.SqlClient
Public Class Fproductos

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

    Friend Function Add_productos(ByVal dts As Vproductos) As Boolean
        Try

            Dim cmd As New SqlCommand("insertar_productos ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}
            cmd.Parameters.AddWithValue("@nombre", dts.Gnombre)
            cmd.Parameters.AddWithValue("@cantidad", dts.Gcantidad)
            cmd.Parameters.AddWithValue("@description", dts.Gdescription)
            cmd.Parameters.AddWithValue("@precio", dts.Gprecio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery()
            Return executeNonQuery > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Function Modificar_productos(ByVal dts As Vproductos) As Boolean
        Try

            Dim cmd As New SqlCommand("editar_productos ") With {.CommandType = CommandType.StoredProcedure, .Connection = GetConnection()}

            cmd.Parameters.AddWithValue("@id_productos", dts.Gid_productos)
            cmd.Parameters.AddWithValue("@nombre", dts.Gnombre)
            cmd.Parameters.AddWithValue("@cantidad", dts.Gcantidad)
            cmd.Parameters.AddWithValue("@description", dts.Gdescription)
            cmd.Parameters.AddWithValue("@precio", dts.Gprecio)
            Dim executeNonQuery As Integer = cmd.ExecuteNonQuery
            Return executeNonQuery > 0
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            CloseConnection()
        End Try
    End Function
    Function Eliminar_productos(ByVal dts As Vproductos) As Boolean
        Dim prof As New productos()
        Try

            Dim cmd As New SqlCommand("delete from productos WHERE id_Productos= @id_Productos")
            cmd.Parameters.AddWithValue("@id_Productos", dts.Gid_productos)
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
End Class


