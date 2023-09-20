Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO

Public Class productos

    Private ReadOnly Dprod As New Dproductos()
    Private Nprod As New Nproductos()
    ReadOnly Epro As New Eproductos()

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
        CenterToParent()
    End Sub
    Sub Mostrar()

        DataGridView_prudoctos.DataSource = Dprod.Get_productos()
    End Sub
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles Buscar.TextChanged
        Epro.nombre = Buscar.Text
        DataGridView_prudoctos.DataSource = Nprod.Buscar_productos(Epro)
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Epro.nombre = nombre.Text
        Epro.cantidad = CInt(cantidad.Text)
        Epro.description = description.Text
        Epro.precio = CInt(precio.Text)
        Epro.FechaCreacion = fechacreacion.Text
        Dprod.Add_productos(Epro)
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

        Epro.id_productos = CInt(id_productos.Text)
        Epro.nombre = nombre.Text
        Epro.cantidad = CInt(cantidad.Text)
        Epro.description = description.Text
        Epro.precio = CInt(precio.Text)
        Epro.FechaCreacion = fechacreacion.Text
        Dprod.Modificar_productos(Epro)
        Mostrar()
    End Sub
    'Vpro.nombre=nombre.Text 
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
        Epro.id_productos = CInt(DataGridView_prudoctos.SelectedCells.Item(0).Value)
        Dprod.Eliminar_productos(Epro)
        DataGridView_prudoctos.DataSource = Dprod.Get_productos()
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
                    Dprod.GetConnection()
                    Dim ms As New MemoryStream()
                    image.Save(ms, ImageFormat.Jpeg)
                    Dim imageData As Byte() = ms.ToArray()
                    Dim cmd As New SqlCommand("UPDATE Productos SET imagen=@imagen WHERE id_Productos=@id_Productos", Dprod.GetConnection)
                    cmd.Parameters.AddWithValue("@imagen", imageData)
                    cmd.Parameters.AddWithValue("@id_Productos", id_Productos)
                    cmd.ExecuteNonQuery()

                    Dprod.CloseConnection()
                End If
            End Using

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class