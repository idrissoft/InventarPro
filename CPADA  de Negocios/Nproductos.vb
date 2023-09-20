Public Class Nproductos
    Private Dpro As New Dproductos()

    Public Function Buscar_productos(vpro As Eproductos) As DataTable
        Return Dpro.Buscar_productos(vpro)
    End Function
End Class
