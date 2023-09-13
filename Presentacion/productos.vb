Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class productos

    Private ReadOnly _prod As New Fproductos()
    ReadOnly Vpro As New Vproductos()

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CenterToParent()
    End Sub
    Sub Mostrar()

        DataGridView_prudoctos.DataSource = _prod.Get_productos()
    End Sub
    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Vpro.Gnombre = nombre.Text
        Vpro.Gcantidad = CInt(cantidad.Text)
        Vpro.Gdescription = description.Text
        Vpro.Gprecio = CInt(precio.Text)
        Vpro.GFechaCreacion = fechacreacion.Text
        _prod.Add_productos(Vpro)
        Mostrar()
    End Sub
    Private Sub DataGridView_prudoctos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_prudoctos.CellClick
        Try
            Guardar_cambios.Visible = True
            Guardar.Visible = False
            id_productos.Text = DataGridView_prudoctos.SelectedCells.Item(0).Value.ToString
            nombre.Text = DataGridView_prudoctos.SelectedCells.Item(1).Value.ToString
            cantidad.Text = DataGridView_prudoctos.SelectedCells.Item(2).Value.ToString
            description.Text = DataGridView_prudoctos.SelectedCells.Item(3).Value.ToString
            precio.Text = DataGridView_prudoctos.SelectedCells.Item(4).Value.ToString
            fechacreacion.Text = DataGridView_prudoctos.SelectedCells.Item(5).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

        End Try
    End Sub
    Private Sub Guardar_cambios_Click_1(sender As Object, e As EventArgs) Handles Guardar_cambios.Click

        Vpro.Gid_productos = CInt(id_productos.Text)
        Vpro.Gnombre = nombre.Text
        Vpro.Gcantidad = CInt(cantidad.Text)
        Vpro.Gdescription = description.Text
        Vpro.Gprecio = CInt(precio.Text)
        Vpro.GFechaCreacion = fechacreacion.Text
        _prod.Modificar_productos(Vpro)
        Mostrar()
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
        Vpro.Gid_productos = CInt(DataGridView_prudoctos.SelectedCells.Item(0).Value)
        _prod.Eliminar_productos(Vpro)
        DataGridView_prudoctos.DataSource = _prod.Get_productos()
    End Sub
    Private Sub Buscar_productos()
        Try
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter("buscar_productos", _prod.GetConnection)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@letra", Buscar.Text)
            da.Fill(dt)
            DataGridView_prudoctos.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        Buscar_productos()
    End Sub

    Private Sub agregar_imagen_Click(sender As Object, e As EventArgs) Handles agregar_imagen.Click

        Try
            Using selectedRow As DataGridViewRow = DataGridView_prudoctos.SelectedRows(0)
                Dim id_Productos As Integer = Convert.ToInt32(selectedRow.Cells("id_Productos").Value)

                Dim openFileDialog1 As New OpenFileDialog()
                openFileDialog1.Filter = "Archivos de imagen (*.png;*.jpg;*.jpeg;*.gif)|*.png;*.jpg;*.jpeg;*.gif"
                openFileDialog1.Title = "Seleccionar imagen"
                If openFileDialog1.ShowDialog() = DialogResult.OK Then

                    Dim image As Image = Image.FromFile(openFileDialog1.FileName)
                    _prod.GetConnection()
                    Dim ms As New MemoryStream()
                    image.Save(ms, ImageFormat.Jpeg)
                    Dim imageData As Byte() = ms.ToArray()
                    Dim cmd As New SqlCommand("UPDATE Productos SET imagen=@imagen WHERE id_Productos=@id_Productos", _prod.GetConnection)
                    cmd.Parameters.AddWithValue("@imagen", imageData)
                    cmd.Parameters.AddWithValue("@id_Productos", id_Productos)
                    cmd.ExecuteNonQuery()

                    _prod.CloseConnection()
                End If
            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class