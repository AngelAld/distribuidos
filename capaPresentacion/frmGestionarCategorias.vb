Imports capaNegocio
Public Class frmGestionarCategorias
    Dim objCategoria As New clsCategoria

    Private Sub frmGestionarCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarCategorias()
    End Sub

    Private Sub listarCategorias()
        Dim dt As New DataTable
        Try
            dt = objCategoria.listarCategorias
            If dt.Rows.Count > 0 Then
                lsvCategorias.Items.Clear()
                For Each fila In dt.Rows
                    lsvCategorias.Items.Add(fila.Item(0))
                    lsvCategorias.Items(lsvCategorias.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvCategorias.Items(lsvCategorias.Items.Count - 1).SubItems.Add(fila.item(2))
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
                txtId.Text = objCategoria.generarIDCatgeoria
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objCategoria.registrarCategoria(CInt(txtId.Text), txtDescripcion.Text, chkEstado.Checked)
                MessageBox.Show("Categoría registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarCategorias()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiarControles()
        txtId.Clear()
        txtDescripcion.Clear()
        chkEstado.Checked = False
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objCategoria.buscarCategoria(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtDescripcion.Text = dt.Rows(0).Item(1)
                    chkEstado.Checked = dt.Rows(0).Item(2)
                    habilitarBotones(True)
                Else
                    MessageBox.Show("ID de categoría no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objCategoria.eliminarCategoria(CInt(txtId.Text))
                limpiarControles()
                listarCategorias()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de categoría a eliminar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtId.TextLength > 0 Then
                objCategoria.darBajaCategoria(CInt(txtId.Text))
                limpiarControles()
                listarCategorias()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de categoría a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objCategoria.modificarCategoria(CInt(txtId.Text), txtDescripcion.Text, chkEstado.Checked)
            MessageBox.Show("Categoría modificada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarCategorias()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsvCategorias_Click(sender As Object, e As EventArgs) Handles lsvCategorias.Click
        txtId.Text = lsvCategorias.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarCategorias()
        habilitarBotones(False)

    End Sub


End Class