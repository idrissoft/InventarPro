Public Class Nventas

    Private ReadOnly Dventas As New Dventas()

    Public Function ObtenerNombresClientes() As List(Of String)
            Return Dventas.ObtenerNombresClientes()
        End Function
    Public Function ObtenerNombresProductos() As List(Of String)
        Return Dventas.ObtenerNombresProductos()
    End Function
End Class
