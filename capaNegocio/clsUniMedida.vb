Imports System.Data
Imports capaDatos

Public Class classUniMedida
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable
    Public Function generarIDUniMedida() As Integer
        strSQL = "select isnull(max(idunidadmedida),0)+1 from unidadmedida"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Unidad Medida")
        End Try
    End Function

    Public Sub registrarUniMedida(id As Integer, des As String)
        strSQL = "insert into unidadmedida values(" & id & ",'" & des & "')"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva unidad!")
        End Try
    End Sub

    Public Sub modificarUniMedida(id As Integer, des As String)
        strSQL = "update unidadmedida set descripcion='" & des & "'  where idunidadmedida=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar unidad de medida!")
        End Try
    End Sub

    Public Function listarUniMedida() As DataTable
        strSQL = "select * from unidadmedida"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar unidad de medida")
        End Try
    End Function

    Public Function buscarUniMedida(id As Integer) As DataTable
        strSQL = "select * from unidadmedida where idunidadmedida=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una unidad de medida")
        End Try
    End Function

    Public Sub eliminarUniMedida(id As Integer)
        strSQL = "delete from unidadmedida where idunidadmedida=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar unidad de medida!")
        End Try
    End Sub

End Class