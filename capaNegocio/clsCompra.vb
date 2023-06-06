Imports capaDatos
Imports System.Data

Public Class clsCompras
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim strSQL2 As String = ""
    Dim dt As New DataTable
    Dim comandos As New List(Of String)

    Public Function generarIDCompra() As Integer
        strSQL = "select isnull(max(idcompra),0)+1 from compra"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de compra")
        End Try
    End Function

    Public Sub registrarCompra(idcompra As Integer, idproveedor As Integer, descripcion As String, estado As Boolean, fecha As Date, listacompra As List(Of detallecompra))
        strSQL = "insert into compra values(" & idcompra & "," & idproveedor & ", '" & descripcion & "', '" & IIf(estado, 1, 0) & "', '" & fecha & "')"
        comandos.Add(strSQL)

        For Each detalle As detallecompra In listacompra
            strSQL2 = "insert into detallecompra values(" & detalle.idProducto & "," & idcompra & ", " & detalle.precioCompra & "," & detalle.importe & "," & detalle.cantidad & ")"
            comandos.Add(strSQL2)
        Next

        Try
            objMantenimiento.ejecutarTransaccion(comandos)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva compra")
        End Try
    End Sub

    Public Sub modificarcompra(idcompra As Integer, idproveedor As Integer, descripcion As String, estado As Boolean, fecha As Date, listacompra As List(Of detallecompra))
        strSQL = "update compra set idproveedor = " & idproveedor & ", descripcion = '" & descripcion & "', estado = " & IIf(estado, 1, 0) & ", fecha = '" & fecha & "' where idcompra = " & idcompra & ")"
        comandos.Add(strSQL)
        strSQL = "delete from detallecompra where idcompra = " & idcompra
        comandos.Add(strSQL)
        For Each detalle As detallecompra In listacompra
            strSQL2 = "insert into detallecompra values(" & detalle.idProducto & "," & idcompra & ", " & detalle.precioCompra & "," & detalle.importe & "," & detalle.cantidad & ")"
            comandos.Add(strSQL2)
        Next

        Try
            objMantenimiento.ejecutarTransaccion(comandos)
        Catch ex As Exception
            Throw New Exception("Error al modificar compra!")
        End Try
    End Sub

    Public Function listarcompra() As DataTable
        strSQL = "select * from compra"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar compra")
        End Try
    End Function

    Public Function listarDetalleCompra() As DataTable
        strSQL = "select * from detallecompra"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar detalle compra")
        End Try
    End Function

    Public Function buscarcompra(idcompra As Integer) As DataTable
        strSQL = "select * from compra where idcompra=" & idcompra
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una compra")
        End Try
    End Function

    Public Sub eliminarcompra(idcompra As Integer)
        strSQL = "delete from detallecompra where idcompra = " & idcompra
        comandos.Add(strSQL)
        strSQL = "delete from compra where idcompra=" & idcompra
        comandos.Add(strSQL)
        Try
            objMantenimiento.ejecutarTransaccion(comandos)
        Catch ex As Exception
            Throw New Exception("Error al eliminar compra!")
        End Try
    End Sub

    Public Sub darBajacompra(id As Integer)
        strSQL = "update compra set estado=0 where idcompra=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a compra!")
        End Try
    End Sub

End Class
