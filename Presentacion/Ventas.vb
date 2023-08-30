Imports System.Data.SqlClient

Public Class Ventas
    Dim func_venta As New Fventas
    Dim c As New Conection
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView1.DataSource = func_venta.mostrar_ventas
        Dim func_cliente As New Fclientes
        CargarClientes()
        cargar_productos()
    End Sub

    Private Sub CargarClientes()

        c.Conectado()
        Dim query As String = "SELECT Nombre FROM Clientes"
        Dim cmd As New SqlCommand(query, c.con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        ComboBox_clientes.Items.Clear()

        While reader.Read()
            ComboBox_clientes.Items.Add(reader("Nombre").ToString())
        End While

        reader.Close()

    End Sub

    Private Sub cargar_productos()
        c.Conectado()
        Dim query As String = "SELECT nombre FROM Productos"
        Dim cmd As New SqlCommand(query, c.con)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Combo_productos.Items.Clear()

        While reader.Read()
            Combo_productos.Items.Add(reader("nombre").ToString())
        End While

        reader.Close()
    End Sub

End Class