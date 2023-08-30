Public Class inicio
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim cliente As New Clientes()
        cliente.Show()

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim producto As New productos()
        producto.Show()

    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        Dim venta As New Ventas
        venta.Show()
    End Sub

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
    End Sub
End Class