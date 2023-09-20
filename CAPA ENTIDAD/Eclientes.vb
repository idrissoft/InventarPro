

Public Class Eclientes
    Dim idcliente As Integer
    Dim Nombre, Email, Direccion, FechaRegistro, Estado, Telefono As String

    Property Gidcliente As Integer
        Get
            Return idcliente
        End Get
        Set(value As Integer)
            idcliente = value
        End Set
    End Property
    Property GNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Property GEmail As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
    Property GTelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Property GDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
    Property GFechaRegistro As String
        Get
            Return FechaRegistro
        End Get
        Set(value As String)
            FechaRegistro = value
        End Set
    End Property
    Property Gestado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property
    Public Sub New()
        Gidcliente = idcliente
        GNombre = Nombre
        GEmail = Email
        GTelefono = Telefono
        GDireccion = Direccion
        GFechaRegistro = FechaRegistro
        Gestado = Estado
    End Sub


End Class
