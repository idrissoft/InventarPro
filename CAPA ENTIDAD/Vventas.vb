Public Class Vventas
    Public _id_ventas, _id_cliente, _total As Integer
    Dim _fecha_venta As DateTime
    Property id_ventas As Integer
        Get
            Return _id_ventas
        End Get
        Set(value As Integer)
            _id_ventas = value
        End Set
    End Property
    Property ID_cliente As Integer
        Get
            Return _id_cliente
        End Get
        Set(value As Integer)
            _id_cliente = value
        End Set
    End Property
    Property Total As Integer
        Get
            Return _total
        End Get
        Set(value As Integer)
            _total = value
        End Set
    End Property
    Property Fecha_venta As DateTime
        Get
            Return _fecha_venta
        End Get
        Set(value As DateTime)
            _fecha_venta = value
        End Set
    End Property
    Sub New()
        id_ventas = _id_ventas
        ID_cliente = _id_cliente
        Total = _total
        Fecha_venta = _fecha_venta
    End Sub
End Class
