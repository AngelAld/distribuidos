Imports System.Data
Imports capaDatos

Public Class clsProducto
    Dim objMantenimiento As New clsMantenimiento
    Dim strSQL As String = ""
    Dim dt As New DataTable

    Public Function generarIDProducto() As Integer
        strSQL = "select isnull(max(idproducto),0)+1 from producto"
        Try
            dt = objMantenimiento.listarComando(strSQL)
            Return dt.Rows(0).Item(0)
        Catch ex As Exception
            Throw New Exception("Error al generar ID de producto")
        End Try
    End Function

    Public Sub registrarProducto(id As Integer, idlab As Integer, idcat As Integer, idmarca As Integer, idunidad As Integer, des As String, stockmax As Integer, stockmin As Integer, stock As Integer, preven As Decimal, est As Boolean)
        strSQL = "insert into producto values (" & id & "," & idlab & "," & idcat & "," & idmarca & "," & idunidad & ",'" & des & "'," & stockmax & "," & stockmin & "," & stock & "," & preven & "," & IIf(est, 1, 0) & ")"

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al registrar nuevo producto!")
        End Try
    End Sub

    Public Sub modificarProducto(id As Integer, idlab As Integer, idcat As Integer, idmarca As Integer, idunidad As Integer, des As String, stockmax As Integer, stockmin As Integer, stock As Integer, preven As Decimal, est As Boolean)

        strSQL = "update producto set idlaboratorio=" & idlab & ",idcategoria=" & idcat & ",idmarca=" & idmarca & ",idunidadmedida=" & idunidad & ",descripcion='" & des & "',stockmaximo=" & stockmax & ",stockminimo=" & stockmin & ",stock=" & stock & ",precio=" & preven & ",estado=" & IIf(est, 1, 0) & " where idproducto=" & id

        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al modificar producto!")
        End Try
    End Sub

    Public Function listarProducto() As DataTable
        strSQL = "select p.idproducto,c.descripcion as categoria,l.descripcion as laboratorio, p.descripcion, m.descripcion as marca, u.descripcion as und_medida, p.stock,p.precio,p.estado
                    from producto p
                    inner join laboratorio l on (p.idlaboratorio=l.idlaboratorio)
                    inner join categoria c on (p.idcategoria=c.idcategoria)
                    inner join marca m on (p.idmarca=m.idmarca)
                    inner join unidadmedida u on (p.idunidadmedida=u.idunidadmedida)"
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Productos")
        End Try
    End Function

    Public Function listarProductoPorCategoria(id As Integer) As DataTable
        strSQL = "select p.idproducto,c.descripcion as categoria,l.descripcion as laboratorio, p.descripcion, m.descripcion as marca, u.descripcion as und_medida, p.stock,p.precio,p.estado
                    from producto p
                    inner join laboratorio l on (p.idlaboratorio=l.idlaboratorio)
                    inner join categoria c on (p.idcategoria=c.idcategoria)
                    inner join marca m on (p.idmarca=m.idmarca)
                    inner join unidadmedida u on (p.idunidadmedida=u.idunidadmedida) where p.idcategoria = " & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al listar Productos")
        End Try
    End Function
    Public Function buscarProducto(id As Integer) As DataTable
        strSQL = "select * from producto where idproducto=" & id
        Try
            Return objMantenimiento.listarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al buscar un Producto")
        End Try
    End Function

    Public Sub eliminarProducto(id As Integer)
        strSQL = "delete from producto where idproducto=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al eliminar producto!")
        End Try
    End Sub

    Public Sub darBajaProducto(id As Integer)
        strSQL = "update producto set estado=0 where idproducto=" & id
        Try
            objMantenimiento.ejecutarComando(strSQL)
        Catch ex As Exception
            Throw New Exception("Error al dar de baja a producto!")
        End Try
    End Sub

End Class
