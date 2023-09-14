Public Class vdetalle_de_ventas
	Private _id_ventas, _id_producto, _cantidad_ventas, _precio_unitario, _subtotal As Integer
	Property id_ventas As Integer
		Get
			Return _id_ventas
		End Get
		Set(value As Integer)
			_id_ventas = value
		End Set
	End Property
	Property id_producto As Integer
		Get
			Return _id_producto
		End Get
		Set(value As Integer)
			_id_producto = value
		End Set
	End Property
	Property cantidad_ventas As Integer
		Get
			Return _cantidad_ventas
		End Get
		Set(value As Integer)
			_cantidad_ventas = value
		End Set
	End Property
	Property precio_unitario As Integer
		Get
			Return _precio_unitario
		End Get
		Set(value As Integer)
			_precio_unitario = value
		End Set
	End Property
	Property subtotal As Integer
		Get
			Return _subtotal
		End Get
		Set(value As Integer)
			_subtotal = value
		End Set
	End Property
	Sub New()
		id_ventas = _id_ventas
		id_producto = _id_producto
		cantidad_ventas = _cantidad_ventas
		precio_unitario = _precio_unitario
		subtotal = _subtotal
	End Sub
End Class
