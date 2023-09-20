Public Class Nproductos
    Private pro As New Fproductos()

    Public Function Buscar_productos(nombre As String) As DataTable
        Return pro.Buscar_productos(nombre)
    End Function
End Class
