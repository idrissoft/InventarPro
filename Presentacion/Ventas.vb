Imports System.Data.SqlClient

Public Class Ventas
    Dim func_venta As New Fventas
    Dim c As New Conection
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView1.DataSource = func_venta.mostrar_ventas
        Dim func_cliente As New Fclientes
        CargarClientes()
    End Sub

    Sub CargarClientes()


        Dim query As String = "SELECT Nombre FROM Clientes"
        Dim cmd As New SqlCommand(query, c.con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        ComboBox_clientes.Items.Clear()

        While reader.Read()
            ComboBox_clientes.Items.Add(reader("Nombre").ToString())
        End While

        reader.Close()

    End Sub


End Class