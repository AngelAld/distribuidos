Imports System.Data
Imports capaDatos


Public Class clsLaboratorio
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Function listarLaboratorios() As DataTable
        strSQL = "select * from laboratorio"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Laboratorios")
        End Try
    End Function

    Public Function generarIDLaboratorio() As Integer
        strSQL = "select isnull(max(idlaboratorio),0)+1 from laboratorio"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Laboratorio")
        End Try
    End Function

    Public Sub registrarLaboratorio(id As Integer, des As String, est As Boolean)
        strSQL = "insert into laboratorio values (" & id & ",'" & des & "'," & IIf(est, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nuevo Laboratorio!")
        End Try
    End Sub

    Public Sub modificarLaboratorio(id As Integer, des As String, est As Boolean)
        strSQL = "update laboratorio set descripcion='" & des & "', estado=" & IIf(est, 1, 0) & " where idlaboratorio=" & id

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar un Laboratorio!")
        End Try
    End Sub

    Public Function buscarLaboratorio(id As Integer) As DataTable
        strSQL = "select * from laboratorio where idlaboratorio=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar un Laboratorio")
        End Try
    End Function

    Public Sub eliminarLaboratorio(id As Integer)
        strSQL = "delete from laboratorio where idlaboratorio=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar un Laboratorio!")
        End Try
    End Sub

    Public Sub darBajaLaboratorio(id As Integer)
        strSQL = "update laboratorio set estado='False' where idlaboratorio=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a un Laboratorio!")
        End Try
    End Sub



End Class
