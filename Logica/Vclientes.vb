

Public Class Vclientes
    Dim idcliente, Telefono As Integer
    Dim Nombre, Email, Direccion, FechaRegistro, Estado As String

    Property gidcliente As Integer
        Get
            Return idcliente
        End Get
        Set(value As Integer)
            idcliente = value
        End Set
    End Property
    Property gNombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Property gEmail As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
    Property gTelefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Property gDireccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
    Property gFechaRegistro As String
        Get
            Return FechaRegistro
        End Get
        Set(value As String)
            FechaRegistro = value
        End Set
    End Property
    Property gestado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property
    Public Sub New()
        gidcliente = idcliente
        gNombre = Nombre
        gEmail = Email
        gTelefono = Telefono
        gDireccion = Direccion
        gFechaRegistro = FechaRegistro
        gestado = Estado
    End Sub
    Public Sub New(dataGridView As Object)
        Dim DataGridView_clientes As Object
        DataGridView_clientes = dataGridView
    End Sub

End Class
