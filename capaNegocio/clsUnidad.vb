Imports System.Data
Imports capaDatos

Public Class clsUnidad
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Function listarUnidades() As DataTable
        strSQL = "select * from unidadmedida"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Unidades de medida")
        End Try
    End Function


    Public Function generarIDUniMedida() As Integer
        strSQL = "select isnull(max(idUniMedida),0)+1 from UNIMEDIDA"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Unidad Medida")
        End Try
    End Function

    Public Sub registrarUniMedida(id As Integer, des As String, vig As Boolean)
        strSQL = "insert into unimedida values(" & id & ",'" & des & "')"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva unidad!")
        End Try
    End Sub
    'DUDAAAAAAA
    Public Sub modificarUniMedida(id As Integer, des As String)
        strSQL = "update unimedida set descripcion='" & des & "'  where idunimedida=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar unidad de medida!")
        End Try
    End Sub

    Public Function listarUniMedida() As DataTable
        strSQL = "select * from uniMedida"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar unidad de medida")
        End Try
    End Function

    Public Function buscarUniMedida(id As Integer) As DataTable
        strSQL = "select * from uniMedida where idunimedida=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una unidad de medida")
        End Try
    End Function

    Public Sub eliminarUniMedida(id As Integer)
        strSQL = "delete from uniMedida where iduniMedida=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar unidad de medida!")
        End Try
    End Sub

    Public Sub darBajaUniMedida(id As Integer)
        strSQL = "update uniMedida  where idcategoria=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al ar de baja a unidad de medida!")
        End Try
    End Sub


End Class
