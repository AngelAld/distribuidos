Imports System.Data
Imports capaDatos

Public Class clsCategoria
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable


    Public Function generarIDCatgeoria() As Integer
        strSQL = "select isnull(max(idcategoria),0)+1 from categoria"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Categoría")
        End Try
    End Function

    Public Sub registrarCategoria(id As Integer, des As String, est As Boolean)
        strSQL = "insert into categoria values(" & id & ",'" & des & "'," & IIf(est, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva categoría!")
        End Try
    End Sub
    'DUDAAAAAAA
    Public Sub modificarCategoria(id As Integer, des As String, est As Boolean)
        strSQL = "update categoria set descripcion='" & des & "', estado=" & IIf(est, 1, 0) & " where idcategoria=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar categoría!")
        End Try
    End Sub

    Public Function listarCategorias() As DataTable
        strSQL = "select idcategoria, descripcion, estado from categoria"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Categorias")
        End Try
    End Function


    Public Function buscarCategoria(id As Integer) As DataTable
        strSQL = "select * from categoria where idcategoria=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una Categoría")
        End Try
    End Function

    Public Sub eliminarCategoria(id As Integer)
        strSQL = "delete from categoria where idcategoria=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar categoría!")
        End Try
    End Sub

    Public Sub darBajaCategoria(id As Integer)
        strSQL = "update categoria set estado=0 where idcategoria=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a categoría!")
        End Try
    End Sub


End Class
