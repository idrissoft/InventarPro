Public Class vdetalle_de_ventas
	Public ID_Ventas, ID_Producto, Cantidad_ventas, Precio_Unitario, Subtotal As Integer
	Property Gid_ventas As Integer
		Get
			Return ID_Ventas
		End Get
		Set(value As Integer)
			ID_Ventas = value
		End Set
	End Property
	Property Gid_producto As Integer
		Get
			Return ID_Producto
		End Get
		Set(value As Integer)
			ID_Producto = value
		End Set
	End Property
	Property Gcantidad_ventas As Integer
		Get
			Return Cantidad_ventas
		End Get
		Set(value As Integer)
			Cantidad_ventas = value
		End Set
	End Property
	Property Gprecio_unitario As Integer
		Get
			Return Precio_Unitario
		End Get
		Set(value As Integer)
			Precio_Unitario = value
		End Set
	End Property
	Property Gsubtotal As Integer
		Get
			Return Subtotal
		End Get
		Set(value As Integer)
			Subtotal = value
		End Set
	End Property
	Sub New()
		Gid_ventas = ID_Ventas
		Gid_producto = ID_Producto
		Gcantidad_ventas = Cantidad_ventas
		Gprecio_unitario = Precio_Unitario
		Gsubtotal = Subtotal
	End Sub
End Class
