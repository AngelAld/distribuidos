Imports System.Data
Imports capaDatos

Public Class clsMarca
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Function generarIDMarca() As Integer
        strSQL = "select isnull(max(idmarca),0)+1 from marca"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Marca")
        End Try
    End Function

    Public Sub registrarMarcas(id As Integer, des As String, est As Boolean)
        strSQL = "insert into marca values (" & id & ",'" & des & "'," & IIf(est, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva marca!")
        End Try
    End Sub

    Public Sub modificarMarcas(id As Integer, des As String, est As Boolean)
        strSQL = "update marca set descripcion='" & des & "', estado=" & IIf(est, 1, 0) & " where idmarca=" & id

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar una marca!")
        End Try
    End Sub

    Public Function listarMarcas() As DataTable
        strSQL = "select * from marca"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar las Marcas")
        End Try
    End Function

    Public Function buscarMarcas(id As Integer) As DataTable
        strSQL = "select * from marca where idmarca=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una Marca")
        End Try
    End Function

    Public Sub eliminarMarcas(id As Integer)
        strSQL = "delete from marca where idmarca=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar una Marca!")
        End Try
    End Sub

    Public Sub darBajaMarcas(id As Integer)
        strSQL = "update marca set estado='INACTIVO' where idmarca=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a una Marca!")
        End Try
    End Sub



End Class
