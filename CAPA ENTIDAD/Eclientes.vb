Public Class Eclientes

    Public Sub New(dr As DataRow)
        _drcliente = dr
    End Sub
    Public Sub New()

    End Sub
    Private _drcliente As DataRow
    Property Drcliente As DataRow
        Get
            _drcliente("ID_Cliente") = Idcliente

            Return _drcliente

        End Get
        Set(value As DataRow)
            Idcliente = CInt(value("ID_Cliente"))
        End Set
    End Property

    Property Idcliente As Integer

    Property Nombre As String

    Property Email As String

    Property Telefono As String

    Property Direccion As String

    Property FechaRegistro As String

    Property Estado As String




End Class