Imports System.Data.SqlClient


Public Class Ventas
    Dim venta As New Fventas

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView_ventas.DataSource = venta.Get_ventas
        Dim func_cliente As New Fclientes
        CargarClientes()
        cargar_productos()
    End Sub

    Private Sub CargarClientes()
        venta.GetConnection()
        Dim query As String = "SELECT Nombre FROM Clientes"
        Dim cmd As New SqlCommand(query, venta.GetConnection())
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        ComboBox_clientes.Items.Clear()
        While reader.Read()
            ComboBox_clientes.Items.Add(reader("Nombre").ToString())
        End While
        reader.Close()
    End Sub
    Private Sub cargar_productos()
        Dim query As String = "SELECT nombre FROM Productos"
        Dim cmd As New SqlCommand(query, venta.GetConnection())
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        Combo_productos.Items.Clear()
        While reader.Read()
            Combo_productos.Items.Add(reader("nombre").ToString())
        End While
        reader.Close()
    End Sub

    Private Sub ComboBox_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_clientes.SelectedIndexChanged
        Dim Query As String = "SELECT ID_Cliente,telefono,direccion FROM clientes WHERE nombre = @nombre"
        Dim Cmd As New SqlCommand(Query, venta.GetConnection())
        Cmd.Parameters.AddWithValue("@nombre", ComboBox_clientes.Text)
        Dim reader As SqlDataReader = Cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim ID_cliente As Integer = Convert.ToInt32(reader("ID_Cliente"))
            Dim telefono As Decimal = Convert.ToDecimal(reader("telefono"))
            Dim direccion As String = CStr(reader("direccion"))
            Txt_cliente.Text = ID_cliente.ToString()
            Txt_telefono.Text = telefono.ToString()
            Txt_direccion.Text = direccion.ToString()
            reader.Close()
        End If
    End Sub

    Private Sub Combo_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_productos.SelectedIndexChanged
        Dim Query1 As String = "select id_Productos,Precio_unitario,stock_actual,imagen from productos where nombre=@nombre "
        Dim Cmd1 As New SqlCommand(Query1, venta.GetConnection())
        Cmd1.Parameters.AddWithValue("@nombre", Combo_productos.Text)
        Dim reader As SqlDataReader = Cmd1.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim id_productos As Integer = Convert.ToInt32(reader("ID_productos"))
            Dim Precio_unitario As Integer = Convert.ToInt32(reader("Precio_unitario"))
            Dim Stock_Actual As Integer = Convert.ToInt32(reader("stock_actual"))
            Dim I() As Byte = CType(reader("imagen"), Byte())
            Dim ms As New IO.MemoryStream(I)
            imagen1.Image = Image.FromStream(ms)
            imagen1.SizeMode = PictureBoxSizeMode.StretchImage
            Txt_id_productos.Text = CStr(id_productos)
            Txt_PrecioUnitario.Text = CStr(Precio_unitario)
            Txt_stock_acual.Text = CStr(Stock_Actual)
            reader.Close()
        End If
    End Sub
    '><><><><><><><><><
    Private Sub Btn_crear_venta_Click(sender As Object, e As EventArgs) Handles Btn_crear_venta.Click
        Dim Vvent As New Vventas()
        Dim Vdet_vent As New vdetalle_de_ventas()
        Dim Vpro As New Vproductos
        Dim Fvent As New Fventas()
        If Txt_precio_total.Text <> "" Then
            Vvent.Fecha_venta = DateTimePicker1.Value
            Vvent.ID_cliente = CInt(Txt_cliente.Text)
            Vvent.Total = CInt(Txt_precio_total.Text)
            Vdet_vent.id_producto = CInt(Txt_id_productos.Text)
            Vdet_vent.cantidad_ventas = CInt(txtcantidad.Value)
            Vdet_vent.precio_unitario = CInt(Txt_PrecioUnitario.Text)
            Vdet_vent.subtotal = CInt(Txt_precio_total.Text)
            Vpro.Stock_Actual = CInt(Txt_stock_acual.Text)

            Dim Stock_Actual As Integer = Vpro.Stock_Actual - Vdet_vent.cantidad_ventas
            Dim ID_Producto As Integer = Vdet_vent.id_producto
            If Stock_Actual > 0 Then

                Fvent.Add_venta(Vvent, Vdet_vent, Vpro)
                Fvent.Acualisacion_stock(Vdet_vent, Vpro)
            Else

                MessageBox.Show("No hay suficiente stock para completar la operación.")
            End If
        Else
            MessageBox.Show("tiene que calcular el precio Total antes de crea una venta")
            DataGridView_ventas.DataSource = venta.Get_ventas
        End If
    End Sub

    Private Sub Calcul_Precio_total_Click(sender As Object, e As EventArgs) Handles Calcul_Precio_total.Click
        Dim Precio_unitario As Integer = Integer.Parse(Txt_PrecioUnitario.Text)
        Dim cantidad As Integer = CInt(txtcantidad.Value)
        Txt_precio_total.Text = CStr(Precio_unitario * cantidad)
    End Sub


    Private Sub DataGridView_ventas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_ventas.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim selectedRow As DataGridViewRow
                selectedRow = DataGridView_ventas.Rows(e.RowIndex)
                Dim ID_Ventas As Integer = Convert.ToInt32(selectedRow.Cells("id_ventas").Value)
                DataGridView_Detalle_Venta.DataSource = venta.Get_detalle_ventas(ID_Ventas)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

