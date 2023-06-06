Imports System.Data
Imports capaDatos
Public Class clsProveedor
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable
    Public Function generarIDproveedor() As Integer
        strSQL = "select isnull(max(idproveedor),0)+1 from proveedor"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de proveedor")
        End Try
    End Function

    Public Sub registrarproveedor(id As Integer, nom As String, ruc As String, telefono As String, vig As Boolean)
        strSQL = "insert into proveedor (idproveedor, nombre, ruc, telefono, estado) values (" & id & ", '" & nom & "', '" & ruc & "', '" & telefono & "', " & IIf(vig, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nuevo proveedor")
        End Try
    End Sub

    Public Sub modificarproveedor(id As Integer, nom As String, ruc As String, telefono As String, vig As Boolean)
        strSQL = "update proveedor Set nombre='" & nom & "', ruc='" & ruc & "', telefono='" & telefono & "', estado=" & IIf(vig, 1, 0) & " where idproveedor=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar proveedor!")
        End Try
    End Sub

    Public Function listarproveedor() As DataTable
        strSQL = "select * from proveedor"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar proveedor")
        End Try
    End Function

    Public Function buscarproveedor(idproveedor As Integer) As DataTable
        strSQL = "select * from proveedor where idproveedor=" & idproveedor
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar proveedor")
        End Try
    End Function

    Public Sub eliminarproveedor(idproveedor As Integer)
        strSQL = "delete from proveedor where idproveedor=" & idproveedor
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar proveedor!")
        End Try
    End Sub

    Public Sub darBajaproveedor(id As Integer)
        strSQL = "update proveedor set estado=0 where idproveedor=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a proveedor!")
        End Try
    End Sub
End Class
