﻿Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim _cliente As New Fclientes
        DataGridView_clientes.DataSource = _cliente.Mostrar_clientes()
        CenterToParent()
    End Sub
End Class