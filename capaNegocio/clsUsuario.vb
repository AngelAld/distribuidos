Imports System.Data
Imports capaDatos

Public Class clsUsuario
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    'CRUD
    Public Function generarIDusuario() As Integer
        strSQL = "select isnull(max(idusuario),0)+1 from usuarios"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de usuario")
        End Try
    End Function

    'insert into usuario values(1,1,'IVAN','IVANGC','123','ALGO@HOLMATIL.COM',1)
    Public Sub registrarusuario(id As Integer, idrol As Integer, nom As String, usu As String, clave As String, coreo As String, vig As Boolean)
        strSQL = "insert into usuarios (idusuario, idrol, nombres,usuario,clave,correo,estado) values(" & id & "," & idrol & ",'" & nom & "','" & usu & "','" & clave & "','" & coreo & "'," & IIf(vig, 1, 0) & ")"
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nueva usuario!")
        End Try
    End Sub

    Public Sub modificarusuario(id As Integer, idrol As Integer, nom As String, usu As String, clave As String, coreo As String, vig As Boolean)
        'idusuario   idrol	nombres	usuario	clave	correo	estado
        strSQL = "update usuarios set idrol=" & idrol & ",nombres='" & nom & "',usuario='" & usu & "',clave='" & clave & "',correo='" & coreo & "',estado=" & IIf(vig, 1, 0) & " where idusuario=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar usuario!")
        End Try
    End Sub

    Public Function listarusuario() As DataTable
        strSQL = "select U.idusuario,R.nombre,U.nombres,U.usuario,U.clave,U.correo,U.estado from usuarios U inner join rol R on U.idrol=R.idrol"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar usuario")
        End Try
    End Function

    Public Function buscarusuario(idusuario As Integer) As DataTable
        strSQL = "select * from usuarios where idusuario=" & idusuario
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar una usuario")
        End Try
    End Function

    Public Sub eliminarusuario(idusuario As Integer)
        strSQL = "delete from usuarios where idusuario=" & idusuario
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar idusuario!")
        End Try
    End Sub

    Public Sub darBajausuario(id As Integer)
        strSQL = "update usuarios set estado=0 where idusuario=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al ar de baja a usuario!")
        End Try
    End Sub

    '----FIN CRUD-------------


    Public Function validarUsuario(nom As String, con As String) As String
        strSQL = "select nombres from usuarios where usuario='" & nom & "' and clave='" & con & "'"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return ""
            End If
        Catch ex As Exception
            Throw New Exception("Error al validad datos de ususario!")
        End Try
    End Function

    Public Function validarVigencia(nom As String) As Boolean
        strSQL = "select estado from usuarios where usuario='" & nom & "'"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0)
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception("Error al validad datos de ususario!")
        End Try
    End Function
End Class
