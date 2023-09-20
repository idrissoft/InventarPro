Public Class Ncliente
    Dim Dclient As New Dclientes
    Public Function ObtenerInfoClientePorNombre(nombre As String) As Eclientes
        Return Dclient.ObtenerInfoClientePorNombre(nombre)
    End Function
End Class
