Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim func As New Fclientes
        DataGridView_clientes.DataSource = func.Mostrar_clientes()
        CenterToParent()
    End Sub
End Class