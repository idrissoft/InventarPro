Public Class Edetalle_de_ventas
	Private _id_ventas, _id_producto, _cantidad_ventas, _precio_unitario, _subtotal As Integer
	Property Id_ventas As Integer
		Get
			Return _id_ventas
		End Get
		Set(value As Integer)
			_id_ventas = value
		End Set
	End Property
	Property Id_producto As Integer
		Get
			Return _id_producto
		End Get
		Set(value As Integer)
			_id_producto = value
		End Set
	End Property
	Property Cantidad_ventas As Integer
		Get
			Return _cantidad_ventas
		End Get
		Set(value As Integer)
			_cantidad_ventas = value
		End Set
	End Property
	Property Precio_unitario As Integer
		Get
			Return _precio_unitario
		End Get
		Set(value As Integer)
			_precio_unitario = value
		End Set
	End Property
	Property Subtotal As Integer
		Get
			Return _subtotal
		End Get
		Set(value As Integer)
			_subtotal = value
		End Set
	End Property
	Sub New()
		Id_ventas = _id_ventas
		Id_producto = _id_producto
		Cantidad_ventas = _cantidad_ventas
		Precio_unitario = _precio_unitario
		Subtotal = _subtotal
	End Sub
End Class
