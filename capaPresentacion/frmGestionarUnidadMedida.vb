Imports capaNegocio

Public Class frmGestionarUnidadMedida
    Dim objUniMedida As New classUniMedida

    Private Sub frmUnidadMedida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUnMedida()
    End Sub

    Private Sub listarUnMedida()
        Dim dt As New DataTable
        Try
            dt = objUniMedida.listarUniMedida
            If dt.Rows.Count > 0 Then
                lsvUniMedida.Items.Clear()
                For Each fila In dt.Rows
                    lsvUniMedida.Items.Add(fila.Item(0))
                    lsvUniMedida.Items(lsvUniMedida.Items.Count - 1).SubItems.Add(fila.item(1))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text = "Nuevo" Then
                btnNuevo.Text = "Guardar"
                limpiarControles()
                txtId.Text = objUniMedida.generarIDUniMedida
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objUniMedida.registrarUniMedida(CInt(txtId.Text), txtDescripcion.Text)
                MessageBox.Show("Unidad de medida registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarUnMedida()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId.Clear()
        txtDescripcion.Clear()
    End Sub

    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objUniMedida.buscarUniMedida(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtDescripcion.Text = dt.Rows(0).Item(1)
                    habilitarBotones(True)
                Else
                    MessageBox.Show("ID de unidad de medida no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiarControles()
                    habilitarBotones(False)
                End If
            Else
                MessageBox.Show("Ingrese ID a buscar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarControles()
                habilitarBotones(False)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objUniMedida.eliminarUniMedida(CInt(txtId.Text))
                limpiarControles()
                listarUnMedida()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de unidad de medida a eliminar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objUniMedida.modificarUniMedida(CInt(txtId.Text), txtDescripcion.Text)
            MessageBox.Show("Unidad de medida modificada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarUnMedida()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsvCategorias_Click(sender As Object, e As EventArgs) Handles lsvUniMedida.Click
        txtId.Text = lsvUniMedida.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarUnMedida()
        habilitarBotones(False)
    End Sub

End Class