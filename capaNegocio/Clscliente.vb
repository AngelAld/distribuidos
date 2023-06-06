Imports capaDatos
Imports System.Data

Public Class Clscliente
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable
    Public Function generarIDCatgeoria() As Integer
        strSQL = "select isnull(max(idcliente),0)+1 from Cliente"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de Cliente")
        End Try
    End Function

    Public Sub registrarcliente(id As Integer, nom As String, DNI As String, vig As Boolean)
        strSQL = "insert into cliente (idcliente,dni,nombre,estado) values(" & id & ",'" & DNI & "','" & nom & "'," & IIf(vig, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva Cliente!")
        End Try
    End Sub

    Public Sub modificarcliente(id As Integer, nom As String, DNI As String, vig As Boolean)
        strSQL = "update cliente set dni='" & DNI & "',nombre='" & nom & "', estado=" & IIf(vig, 1, 0) & " where idcliente=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar Cliente!")
        End Try
    End Sub

    Public Function listarcliente() As DataTable
        strSQL = "select idcliente,dni,nombre,estado from cliente"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Clientes")
        End Try
    End Function

    Public Function buscarcliente(id As Integer) As DataTable
        strSQL = "select idcliente,dni,nombre,estado from cliente where idcliente=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una Cliente")
        End Try
    End Function

    Public Sub eliminarcliente(id As Integer)
        strSQL = "delete from cliente where idcliente=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar Cliente!")
        End Try
    End Sub

    Public Sub darBajacliente(id As Integer)
        strSQL = "update cliente set estado=0 where idcliente=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al ar de baja a Cliente!")
        End Try
    End Sub
End Class
