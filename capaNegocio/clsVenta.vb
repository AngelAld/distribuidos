Imports System.Data
Imports capaDatos
Public Class clsVenta
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Function generarIDVenta() As Integer
        strSQL = "select isnull(max(idventa),0)+1 from venta"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de venta")
        End Try
    End Function

    Public Sub registrarVenta(id As Integer, idcli As Integer, idusu As Integer, idtipoCom As Integer, fecha As Date, codComp As String, est As Boolean)
        strSQL = "insert into venta values (" & id & "," & idcli & "," & idusu & "," & idtipoCom & ",'" & fecha & "','" & codComp & "'," & IIf(est, 1, 0) & ")"

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva venta!")
        End Try
    End Sub

    Public Sub modificarVenta(id As Integer, idcli As Integer, idusu As Integer, idtipoCom As Integer, fecha As Date, codComp As String, est As Boolean)

        strSQL = "update venta set idcliente=" & idcli & ",idusuario=" & idusu & ",idtipocomprobante=" & idtipoCom & ",fecha='" & fecha & "',codigocomprobante='" & codComp & "',estado=" & IIf(est, 1, 0) & " where idventa=" & id

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar venta!")
        End Try
    End Sub

    Public Function listarVentas() As DataTable
        strSQL = "select v.idventa, c.nombre as Cliente,u.nombres as Usuario, v.codigocomprobante,v.estado from venta v
                    inner join cliente c on (v.idcliente=c.idcliente)
                    inner join usuarios u on (v.idusuario=u.idusuario)
                    inner join tipocomprobante tc on (v.idtipocomprobante=tc.idtipocomprobante)"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Ventas")
        End Try
    End Function

    Public Function buscarPorNombre(id As Integer) As DataTable
        strSQL = "select nombre from cliente where idcliente =" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar nombre")
        End Try
    End Function

    Public Function listarDniCliente() As DataTable
        strSQL = "select * from cliente"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar nombre")
        End Try
    End Function



    Public Function listarTipoComprobante() As DataTable
        strSQL = "select * from tipocomprobante"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error allistar tipo de comprobante")
        End Try
    End Function


    Public Function buscarVenta(id As Integer) As DataTable
        strSQL = "select * from venta where idventa=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una venta")
        End Try
    End Function


    Public Sub eliminarVenta(id As Integer)
        strSQL = "delete from venta where idventa=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar venta!")
        End Try
    End Sub

    Public Sub darBajaVenta(id As Integer)
        strSQL = "update venta set estado=0 where idventa=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja una venta!")
        End Try
    End Sub


End Class
