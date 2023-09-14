

Public Class Vproductos
    Dim _id_productos As Integer
    Dim _cantidad As Integer
    Dim _precio As Integer
    Dim _stock_actual As Integer
    Dim _nombre, _description, _fechaCreacion As String
    Dim _imagen As Byte
    Public Property id_productos As Integer
        Get
            Return _id_productos
        End Get
        Set(value As Integer)
            _id_productos = value
        End Set
    End Property
    Public Property cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
    Public Property precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property description As String
        Get
            Return _description
        End Get
        Set(value As String)
            _description = value
        End Set
    End Property

    Public Property FechaCreacion As String
        Get
            Return _fechaCreacion
        End Get
        Set(value As String)
            _fechaCreacion = value
        End Set
    End Property
    Property Stock_Actual As Integer
        Get
            Return _stock_actual
        End Get
        Set(value As Integer)
            _stock_actual = value
        End Set
    End Property
    Property imagen As Object
        Get
            Return _imagen
        End Get
        Set(value As Object)
            _imagen = CByte(value)
        End Set
    End Property
    Public Sub New()
        id_productos = _id_productos
        cantidad = _cantidad
        precio = _precio
        nombre = _nombre
        description = _description
        FechaCreacion = _fechaCreacion
        Stock_Actual = _stock_actual
    End Sub

End Class
