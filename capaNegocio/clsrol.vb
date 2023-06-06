Imports System.Data
Imports capaDatos
Public Class clsrol
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable
    Public Function generarIDRol() As Integer
        strSQL = "select isnull(max(idrol),0)+1 from rol"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de rol")
        End Try
    End Function

    Public Sub registrarRol(id As Integer, nom As String, vig As Boolean)
        strSQL = "insert into rol values(" & id & ",'" & nom & "'," & IIf(vig, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva ROL! cls falla")
        End Try
    End Sub

    Public Sub modificarrol(id As Integer, nom As String, vig As Boolean)
        strSQL = "update rol set nombre='" & nom & "', estado=" & IIf(vig, 1, 0) & " where idrol=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar rol!")
        End Try
    End Sub

    Public Function listarrol() As DataTable
        strSQL = "select * from rol"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar rol")
        End Try
    End Function

    Public Function buscarrol(idrol As Integer) As DataTable
        strSQL = "select * from rol where idrol=" & idrol
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una rol")
        End Try
    End Function

    Public Sub eliminarrol(idrol As Integer)
        strSQL = "delete from rol where idrol=" & idrol
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar idrol!")
        End Try
    End Sub

    Public Sub darBajarol(id As Integer)
        strSQL = "update rol set estado=0 where idrol=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al ar de baja a rol!")
        End Try
    End Sub

    Public Function listarusuarioporrol(nom As String) As DataTable
        strSQL = "select U.* from usuario U inner join rol R on U.idrol=R.idrol where R.nombre='" & nom & "'"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Usuario por nombre rol")
        End Try
    End Function
End Class
