Imports capaNegocio

Public Class frmPago

    Dim objPago As New clsVenta
    Dim id As Object

    Private Sub frmGestionarLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPedidoSinPagar()
        btnRealizarPago.Enabled = False
    End Sub

    Private Sub listarPedidoSinPagar()
        Dim dt As New DataTable
        Try
            dt = objPago.listarPedidoSinPagar
            If dt.Rows.Count > 0 Then
                tblRealizarPago.Items.Clear()
                For Each fila In dt.Rows
                    tblRealizarPago.Items.Add(fila.Item(0))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(1))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(2))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(3))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(4))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(5))
                    tblRealizarPago.Items(tblRealizarPago.Items.Count - 1).SubItems.Add(fila.item(6))

                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub lsvclientes_Click(sender As Object, e As EventArgs) Handles tblRealizarPago.Click
        btnRealizarPago.Enabled = True
    End Sub

    Private Sub btnRealizarPago_Click(sender As Object, e As EventArgs) Handles btnRealizarPago.Click
        Dim dt As New DataTable
        Try
            objPago.pagarProducto(CInt(tblRealizarPago.SelectedItems(0).Text))
            listarPedidoSinPagar()
            MessageBox.Show("Pago Registrado Exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnRealizarPago.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error al Realizar Pago", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


End Class