Imports System.Data.SqlClient

Public Class productos

    ReadOnly func As New Fproductos()
    ReadOnly dts As New Vproductos()

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CenterToParent()
    End Sub
    Sub Mostrar()

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

    Private Sub Nuevo_productos_Click(sender As Object, e As EventArgs) Handles nuevo_productos.Click
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

    Private Sub Editar_productos_Click(sender As Object, e As EventArgs) Handles editar_productos.Click
        Panel11.Visible = True
    End Sub
    Public Mid_productos As String
    Public Sub Eliminar_productos_Click(sender As Object, e As EventArgs) Handles eliminar_productos.Click
        dts.gid_productos = DataGridView_prudoctos.SelectedCells.Item(0).Value
        func.Eliminar_productos(dts)
        DataGridView_prudoctos.DataSource = func.mostrar_productos()
    End Sub
    Private Sub Buscar_productos()
        Try
            Dim conn As New Conection()
            conn.conectado()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("buscar_productos", conn.con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@letra", Buscar.Text)
            da.Fill(dt)
            DataGridView_prudoctos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        buscar_productos()
    End Sub


End Class