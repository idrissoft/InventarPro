Imports System.Data.SqlClient

Public Class productos
    Dim dt As DataTable
    Dim func As New Fproductos()
    Dim dts As New Vproductos()

    Private Sub productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        CenterToParent()
    End Sub
    Sub mostrar()

        DataGridView_prudoctos.DataSource = func.mostrar_productos()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim dts As New Vproductos()
        Dim func As New Fproductos()
        dts.Gnombre = nombre.Text
        dts.gcantidad = cantidad.Text
        dts.Gdescription = description.Text
        dts.gprecio = precio.Text
        dts.GFechaCreacion = fechacreacion.Text
        func.add_productos(dts)
        mostrar()
    End Sub
    Private Sub DataGridView_prudoctos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_prudoctos.CellClick
        Try
            Guardar_cambios.Visible = True
            Guardar.Visible = False
            id_productos.Text = DataGridView_prudoctos.SelectedCells.Item(0).Value
            nombre.Text = DataGridView_prudoctos.SelectedCells.Item(1).Value
            cantidad.Text = DataGridView_prudoctos.SelectedCells.Item(2).Value
            description.Text = DataGridView_prudoctos.SelectedCells.Item(3).Value
            precio.Text = DataGridView_prudoctos.SelectedCells.Item(4).Value
            fechacreacion.Text = DataGridView_prudoctos.SelectedCells.Item(5).Value
        Catch ex As Exception
            'MsgBox(ex.Message)

        Finally

        End Try
    End Sub
    Private Sub Guardar_cambios_Click_1(sender As Object, e As EventArgs) Handles Guardar_cambios.Click

        dts.gid_productos = id_productos.Text
        dts.Gnombre = nombre.Text
        dts.gcantidad = cantidad.Text
        dts.Gdescription = description.Text
        dts.gprecio = precio.Text
        dts.GFechaCreacion = fechacreacion.Text
        func.modificar_productos(dts)
        mostrar()
    End Sub

    Private Sub nuevo_productos_Click(sender As Object, e As EventArgs) Handles nuevo_productos.Click
        Panel11.Visible = True
        Guardar_cambios.Visible = False
        Guardar.Visible = True
        id_productos.Text = ""
        nombre.Text = ""
        cantidad.Text = ""
        description.Text = ""
        precio.Text = ""
        fechacreacion.Text = ""
    End Sub

    Private Sub editar_productos_Click(sender As Object, e As EventArgs) Handles editar_productos.Click
        Panel11.Visible = True
    End Sub
    Public Mid_productos As String
    Public Sub eliminar_productos_Click(sender As Object, e As EventArgs) Handles eliminar_productos.Click
        dts.gid_productos = DataGridView_prudoctos.SelectedCells.Item(0).Value
        func.eliminar_productos(dts)
        DataGridView_prudoctos.DataSource = func.mostrar_productos()
    End Sub
    Function buscar_productos()
        Dim conn As New Conection()
        Dim dt As New DataTable()
        Dim con As SqlConnection = conn.conectado()
        Dim da As New SqlDataAdapter("buscar_productos", con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.SelectCommand.Parameters.AddWithValue("@letra", Buscar.Text)
        da.Fill(dt)
        Return dt
    End Function
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        DataGridView_prudoctos.DataSource = buscar_productos()
    End Sub
End Class