Imports capaNegocio

Public Class frmcompra
    Dim objcompra As New clsCompras
    Private Sub limpiarControles()
        txtId.Clear()
        txtDescripcion.Clear()
        chkEstado.Checked = False
    End Sub
    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub

    Private Sub listarcomprasLV()
        Dim dt As New DataTable
        Try
            dt = objcompra.listarcompra
            If dt.Rows.Count > 0 Then
                lsvcompra.Items.Clear()
                For Each fila In dt.Rows
                    lsvcompra.Items.Add(fila.Item(0))
                    lsvcompra.Items(lsvcompra.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvcompra.Items(lsvcompra.Items.Count - 1).SubItems.Add(fila.item(2))
                    lsvcompra.Items(lsvcompra.Items.Count - 1).SubItems.Add(fila.item(3))
                    lsvcompra.Items(lsvcompra.Items.Count - 1).SubItems.Add(fila.item(4))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objcompra.eliminarcompra(CInt(txtId.Text))
                limpiarControles()

            Else
                MessageBox.Show("Ingrese ID de compra a eliminar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub lsvcompras_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objcompra.buscarcompra(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtproveedor.Text = dt.Rows(0).Item(1)
                    txtDescripcion.Text = dt.Rows(0).Item(2)
                    chkEstado.Checked = dt.Rows(0).Item(3)
                    dtpFecha.Text = dt.Rows(0).Item(4)

                Else
                    MessageBox.Show("ID de compra no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarControles()

                End If
            Else
                MessageBox.Show("Ingrese ID a buscar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarControles()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtId.TextLength > 0 Then
                objcompra.darBajacompra(CInt(txtId.Text))
                limpiarControles()

            Else
                MessageBox.Show("Ingrese ID de compra a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'ABRE A IOSIV

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

    End Sub

    Private Sub frmcompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarcomprasLV()
    End Sub


    Private Sub lsvcompra_Click(sender As Object, e As EventArgs) Handles lsvcompra.Click
        txtId.Text = lsvcompra.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub
End Class