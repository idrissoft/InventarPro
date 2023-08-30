Public Class Ventas
    Dim func_venta As New Fventas
    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToParent()
        DataGridView1.DataSource = func_venta.mostrar_ventas
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
End Class