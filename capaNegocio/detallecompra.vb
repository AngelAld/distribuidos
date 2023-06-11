Public Class detallecompra
    Private _idProducto As Integer
    Private _idCompra As Integer
    Private _precioCompra As Decimal
    Private _importe As Decimal
    Private _cantidad As Integer

    Public Property idProducto() As Integer
        Get
            Return _idProducto
        End Get
        Set(ByVal value As Integer)
            _idProducto = value
        End Set
    End Property

    Public Property idCompra() As Integer
        Get
            Return _idCompra
        End Get
        Set(ByVal value As Integer)
            _idCompra = value
        End Set
    End Property

    Public Property precioCompra() As Decimal
        Get
            Return _precioCompra
        End Get
        Set(ByVal value As Decimal)
            _precioCompra = value
        End Set
    End Property

    Public Property importe() As Decimal
        Get
            Return _precioCompra
        End Get
        Set(ByVal value As Decimal)
            _precioCompra = value
        End Set
    End Property

    Public Property cantidad() As Integer
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Integer)
            _cantidad = value
        End Set
    End Property
End Class
