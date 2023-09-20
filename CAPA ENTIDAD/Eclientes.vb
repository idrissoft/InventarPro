Public Class Eclientes
    Dim _idcliente As Integer
    Dim _nombre, _email, _direccion, _fechaRegistro, _estado, _telefono As String

    Property Idcliente As Integer
        Get
            Return _idcliente
        End Get
        Set(value As Integer)
            _idcliente = value
        End Set
    End Property
    Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
    Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property
    Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property
    Property FechaRegistro As String
        Get
            Return _fechaRegistro
        End Get
        Set(value As String)
            _fechaRegistro = value
        End Set
    End Property
    Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
    Public Sub New()
        Idcliente = _idcliente
        Nombre = _nombre
        Email = _email
        Telefono = _telefono
        Direccion = _direccion
        FechaRegistro = _fechaRegistro
        Estado = _estado
    End Sub


End Class