Imports System.Data
Imports capaDatos

Public Class clsVenta
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable
    Dim comandos As New List(Of String)
    Public Function listarPedidoSinPagar() As DataTable
        strSQL = "select v.idventa, c.nombre as cliente , u.nombres as usuario, t.descripcion as tipocomprobante, v.fecha, v.codigocomprobante, v.estado from venta v
                    inner join cliente c on v.idcliente = c.idcliente
                    inner join tipocomprobante t on v.idtipocomprobante = t.idtipocomprobante
                    inner join usuarios u on v.idusuario= u.idusuario"

        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Ventas")
        End Try
    End Function

    Public Sub pagarProducto(id As Integer)
        strSQL = "update venta set estado='True' where idventa=" & id
        comandos.Add(strSQL)
        Try
            objMantenimiento.ejecutarTransaccion(comandos)
        Catch ex As Exception
            Throw New Exception("Error al pagar los productos!")
        End Try
    End Sub

End Class
