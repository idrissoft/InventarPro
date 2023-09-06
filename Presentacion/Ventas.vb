Imports System.Data.SqlClient

Public Class Ventas
    Dim func_venta As New Fventas
    Dim c As New Conection
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView_ventas.DataSource = func_venta.mostrar_ventas
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


    Private Sub ComboBox_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_clientes.SelectedIndexChanged
        Dim Query As String = "SELECT ID_Cliente,telefono,direccion FROM clientes WHERE nombre = @nombre"
        Dim Cmd As New SqlCommand(Query, c.con)
        Cmd.Parameters.AddWithValue("@nombre", ComboBox_clientes.Text)

        Dim reader As SqlDataReader = Cmd.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim ID_cliente As Integer = Convert.ToInt32(reader("ID_Cliente"))
            Dim telefono As Decimal = Convert.ToDecimal(reader("telefono"))
            Dim direccion As String = reader("direccion")
            Txt_cliente.Text = ID_cliente.ToString()
            Txt_telefono.Text = telefono.ToString()
            Txt_direccion.Text = direccion.ToString()
            reader.Close()
        End If
    End Sub

    Private Sub Combo_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_productos.SelectedIndexChanged
        Dim Query1 As String = "select id_Productos,Precio_unitario,Stock_Actual from productos where nombre=@nombre "
        Dim Cmd1 As New SqlCommand(Query1, c.con)
        Cmd1.Parameters.AddWithValue("@nombre", Combo_productos.Text)
        Dim reader As SqlDataReader = Cmd1.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim id_productos As Integer = Convert.ToInt32(reader("ID_productos"))
            Dim Precio_unitario As Integer = Convert.ToInt32(reader("Precio_unitario"))
            Dim Stock_Actual As Integer = Convert.ToInt32(reader("Stock_Actual"))
            Txt_id_productos.Text = id_productos
            Txt_PrecioUnitario.Text = Precio_unitario
            Txt_stock_acual.Text = Stock_Actual
            reader.Close()
        End If
    End Sub

    Private Sub Btn_crear_venta_Click(sender As Object, e As EventArgs) Handles Btn_crear_venta.Click
        Dim dts1 As New Vventas()
        Dim dt As New vdetalle_de_ventas()
        Dim fun As New Fventas()
        dts1.GFecha_venta = DateTimePicker1.Value
        dts1.GID_cliente = Txt_cliente.Text
        dts1.Gtotal = Txt_precio_total.Text
        'dt.Gid_ventas =
        dt.Gid_producto = Txt_id_productos.Text
        dt.Gcantidad_ventas = CInt(txtcantidad.Value)
        dt.Gprecio_unitario = Txt_PrecioUnitario.Text
        dt.Gsubtotal = Txt_precio_total.Text
        fun.Add_venta(dts1, dt)
        fun.mostrar_ventas()

    End Sub

    Private Sub agregar_venta_Click(sender As Object, e As EventArgs) Handles agregar_venta.Click
        Dim Precio_unitario As Integer = Integer.Parse(Txt_PrecioUnitario.Text)
        Dim cantidad As Integer = CInt(txtcantidad.Value)
        Txt_precio_total.Text = Precio_unitario * cantidad
    End Sub

    Private Sub DataGridView_ventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ventas.CellContentClick
        DataGridView_Detalle_Venta.DataSource = func_venta.mostrar_detalle_ventas()
    End Sub
End Class