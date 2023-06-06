
Imports System.Data
Imports capaDatos

Public Class clsVentaDetalle
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Sub registrarDetalleVenta(idventa As Integer, idproduc As Integer, preVen As Decimal, importe As Decimal, cant As Integer)
        strSQL = "insert into detalleventa values (" & idventa & "," & idproduc & "," & preVen & "," & importe & "," & cant & ")"

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar detalle de venta!")
        End Try
    End Sub

    Public Sub modificarDetalleVenta(idventa As Integer, idproduc As Integer, preVen As Decimal, importe As Decimal, cant As Integer)

        strSQL = "update detalleventa set idproducto=" & idproduc & ",precioventa=" & preVen & ",importe=" & importe & ",cantidad=" & cant & " where idventa=" & idventa

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar detalle de venta!")
        End Try
    End Sub

    Public Function listarDetalleVenta() As DataTable
        strSQL = "select * from detalleventa"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar detalle de venta")
        End Try
    End Function

    Public Function buscarPorVenta(id As Integer) As DataTable
        strSQL = "select * from detalleventa where idventa=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar un una venta")
        End Try
    End Function

    Public Sub eliminarVentaDetalle(id As Integer)
        strSQL = "delete from detalleventa where idventa=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar detalle de venta!")
        End Try
    End Sub






End Class
