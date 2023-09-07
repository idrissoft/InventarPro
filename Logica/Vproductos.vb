

Public Class Vproductos
    Dim id_productos As Integer
    Dim Cantidad As Integer
    Dim Precio As Integer
    Dim Stock_Actual As Integer
    Dim nombre, description, FechaCreacion As String
    Dim imagen As Byte
    Public Property Gid_productos As Integer
        Get
            Return id_productos
        End Get
        Set(value As Integer)
            id_productos = value
        End Set
    End Property
    Public Property Gcantidad
        Get
            Return Cantidad
        End Get
        Set(value)
            Cantidad = value
        End Set
    End Property
    Public Property Gprecio
        Get
            Return Precio
        End Get
        Set(value)
            Precio = value
        End Set
    End Property

    Public Property Gnombre
        Get
            Return nombre
        End Get
        Set(value)
            nombre = value
        End Set
    End Property
    Public Property Gdescription
        Get
            Return description
        End Get
        Set(value)
            description = value
        End Set
    End Property

    Public Property GFechaCreacion
        Get
            Return FechaCreacion
        End Get
        Set(value)
            FechaCreacion = value
        End Set
    End Property
    Property GStock_Actual
        Get
            Return Stock_Actual
        End Get
        Set(value)
            Stock_Actual = value
        End Set
    End Property
    Property Gimagen
        Get
            Return imagen
        End Get
        Set(value)
            imagen = value
        End Set
    End Property
    Public Sub New()
        gid_productos = id_productos
        gcantidad = Cantidad
        gprecio = Precio
        Gnombre = nombre
        Gdescription = description
        GFechaCreacion = FechaCreacion
        GStock_Actual = Stock_Actual
    End Sub

End Class
