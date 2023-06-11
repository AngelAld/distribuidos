Imports capaNegocio

Public Class frmDetalleCompra
    Dim detalles As New List(Of detallecompra)
    Dim compra As New clsCompras
    Dim productos As New clsProducto

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim objDetalle As New detallecompra

    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub

    Private Sub lblProductoAgregdo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lblProductoAgregdo.SelectedIndexChanged

    End Sub


End Class