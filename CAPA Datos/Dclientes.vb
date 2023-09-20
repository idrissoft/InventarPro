Imports System.Data.SqlClient
Public Class Dclientes
    Inherits Conection
    Dim Ecliente As New Eclientes
    Friend Function Get_clientes() As DataTable
        Dim dt As New DataTable()
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        cmd = New SqlCommand("select * from clientes", GetConnection())

        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
    Friend Function ObtenerInfoClientePorNombre(nombre As String) As Eclientes
        Dim Query As String = "SELECT ID_Cliente,telefono,direccion FROM clientes WHERE nombre = @nombre"
        Dim Cmd As New SqlCommand(Query, GetConnection())
        Cmd.Parameters.AddWithValue("@nombre", nombre)
        Dim reader As SqlDataReader = Cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim ID_cliente As Integer = Convert.ToInt32(reader("ID_Cliente"))
            Dim telefono As Decimal = Convert.ToDecimal(reader("telefono"))
            Dim direccion As String = CStr(reader("direccion"))
            Ecliente.Idcliente = CInt(ID_cliente.ToString())
            Ecliente.Telefono = telefono.ToString()
            Ecliente.Direccion = direccion.ToString()
            reader.Close()
        End If
        Return Ecliente
    End Function
End Class
