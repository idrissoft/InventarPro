Imports System.Data.SqlClient


Public Class Ventas
    Dim Dventa As New Dventas()
    Dim Nventas As New Nventas()
    Dim Eventas As New Eventas()
    Dim Edet_vent As New Edetalle_de_ventas()
    Dim Epro As New Eproductos()
    'Dim Eclient As New Eclientes()

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView_ventas.DataSource = Dventa.Get_ventas
        Dim Dcliente As New Dclientes
        CargarClientes()
        cargar_productos()
    End Sub

    Private Sub CargarClientes()
        Dim nombresClientes As List(Of String) = Nventas.ObtenerNombresClientes()
        ComboBox_clientes.Items.Clear()
        For Each nombre In nombresClientes
            ComboBox_clientes.Items.Add(nombre)
        Next
    End Sub

    Private Sub cargar_productos()
        Dim nombresproductos As List(Of String) = Nventas.ObtenerNombresProductos()
        Combo_productos.Items.Clear()
        For Each nombre In nombresproductos
            Combo_productos.Items.Add(nombre)
        Next
    End Sub

    Private Sub ComboBox_clientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_clientes.SelectedIndexChanged

        'Dim Eclient As New Eclientes()
        'Txt_cliente.Text = Eclient.Idcliente.ToString()
        'Txt_telefono.Text = Eclient.Telefono.ToString()
        'Txt_direccion.Text = Eclient.Direccion.ToString()

        'Dim Query As String = "SELECT ID_Cliente,telefono,direccion FROM clientes WHERE nombre = @nombre"
        'Dim Cmd As New SqlCommand(Query, Dventa.GetConnection())
        'Cmd.Parameters.AddWithValue("@nombre", ComboBox_clientes.Text)
        'Dim reader As SqlDataReader = Cmd.ExecuteReader()
        'If reader.HasRows Then
        '    reader.Read()
        '    Dim ID_cliente As Integer = Convert.ToInt32(reader("ID_Cliente"))
        '    Dim telefono As Decimal = Convert.ToDecimal(reader("telefono"))
        '    Dim direccion As String = CStr(reader("direccion"))
        '    Txt_cliente.Text = ID_cliente.ToString()
        '    Txt_telefono.Text = telefono.ToString()
        '    Txt_direccion.Text = direccion.ToString()
        '    reader.Close()
        'End If
    End Sub

    Private Sub Combo_productos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_productos.SelectedIndexChanged
        Dim Query1 As String = "select id_Productos,Precio_unitario,stock_actual,imagen from productos where nombre=@nombre "
        Dim Cmd1 As New SqlCommand(Query1, Dventa.GetConnection())
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

        If Txt_precio_total.Text <> "" Then
            Eventas.Fecha_venta = DateTimePicker1.Value
            Eventas.ID_cliente = CInt(Txt_cliente.Text)
            Eventas.Total = CInt(Txt_precio_total.Text)
            Edet_vent.Id_producto = CInt(Txt_id_productos.Text)
            Edet_vent.Cantidad_ventas = CInt(txtcantidad.Value)
            Edet_vent.Precio_unitario = CInt(Txt_PrecioUnitario.Text)
            Edet_vent.Subtotal = CInt(Txt_precio_total.Text)
            Epro.Stock_Actual = CInt(Txt_stock_acual.Text)

            Dim Stock_Actual As Integer = Epro.Stock_Actual - Edet_vent.Cantidad_ventas
            Dim ID_Producto As Integer = Edet_vent.Id_producto
            If Stock_Actual > 0 Then

                Dventa.Add_venta(Eventas, Edet_vent, Epro)
                Dventa.Acualisacion_stock(Edet_vent, Epro)
            Else

                MessageBox.Show("No hay suficiente stock para completar la operación.")
            End If
        Else
            MessageBox.Show("tiene que calcular el precio Total antes de crea una Dventa")
            DataGridView_ventas.DataSource = Dventa.Get_ventas
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
                Dim ID_Ventas As Integer = Convert.ToInt32(selectedRow.Cells("Id_ventas").Value)
                DataGridView_Detalle_Venta.DataSource = Dventa.Get_detalle_ventas(ID_Ventas)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

