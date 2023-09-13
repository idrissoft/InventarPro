

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
    Public Property Gcantidad As Integer
        Get
            Return Cantidad
        End Get
        Set(value As Integer)
            Cantidad = value
        End Set
    End Property
    Public Property Gprecio As Integer
        Get
            Return Precio
        End Get
        Set(value As Integer)
            Precio = value
        End Set
    End Property

    Public Property Gnombre As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property
    Public Property Gdescription As String
        Get
            Return description
        End Get
        Set(value As String)
            description = value
        End Set
    End Property

    Public Property GFechaCreacion As String
        Get
            Return FechaCreacion
        End Get
        Set(value As String)
            FechaCreacion = value
        End Set
    End Property
    Property GStock_Actual As Integer
        Get
            Return Stock_Actual
        End Get
        Set(value As Integer)
            Stock_Actual = value
        End Set
    End Property
    Property Gimagen As Object
        Get
            Return imagen
        End Get
        Set(value As Object)
            imagen = CByte(value)
        End Set
    End Property
    Public Sub New()
        Gid_productos = id_productos
        Gcantidad = Cantidad
        Gprecio = Precio
        Gnombre = nombre
        Gdescription = description
        GFechaCreacion = FechaCreacion
        GStock_Actual = Stock_Actual
    End Sub

End Class
