Public Class Vventas
    Dim id_Ventas, ID_Cliente, Total As Integer
    Dim Fecha_venta As DateTime
    Property Gid_ventas As Integer
        Get
            Return id_Ventas
        End Get
        Set(value As Integer)
            id_Ventas = value
        End Set
    End Property
    Property Gtotal As Integer
        Get
            Return Total
        End Get
        Set(value As Integer)
            Total = value
        End Set
    End Property
    Property GFecha_venta As DateTime
        Get
            Return Fecha_venta
        End Get
        Set(value As DateTime)
            Fecha_venta = value
        End Set
    End Property
    Sub New()
        Gid_ventas = id_Ventas
        Gtotal = Total
        GFecha_venta = Fecha_venta
    End Sub
End Class
