Imports capaNegocio

Public Class frmGestionarMarca

    Dim objMarca As New clsMarca
    Dim id As Object

    Private Sub frmGestionarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarMarca()
    End Sub

    Private Sub listarMarca()
        Dim dt As New DataTable
        Try
            dt = objMarca.listarMarcas
            If dt.Rows.Count > 0 Then
                tblMarca.Items.Clear()
                For Each fila In dt.Rows
                    tblMarca.Items.Add(fila.Item(0))
                    tblMarca.Items(tblMarca.Items.Count - 1).SubItems.Add(fila.item(1))
                    tblMarca.Items(tblMarca.Items.Count - 1).SubItems.Add(fila.item(2))

                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If btnGuardar.Text = "NUEVO" Then
                btnGuardar.Text = "GUARDAR"
                limpiarControles()
                txtID.Text = objMarca.generarIDMarca
                habilitarBotones(False)

            Else
                btnGuardar.Text = "NUEVO"
                objMarca.registrarMarcas(CInt(txtID.Text), txtDescripcion.Text, chkEstado.Checked)
                MessageBox.Show("Marca registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarMarca()
                habilitarBotones(True)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiarControles()
        txtDescripcion.Clear()
        chkEstado.Checked = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objMarca.eliminarMarcas(CInt(tblMarca.SelectedItems(0).Text))
            limpiarControles()
            listarMarca()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objMarca.darBajaMarcas(CInt(tblMarca.SelectedItems(0).Text))
            limpiarControles()
            listarMarca()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tblMarcas_Click(sender As Object, e As EventArgs) Handles tblMarca.Click
        Dim dt As New DataTable

        Try
            dt = objMarca.buscarMarcas(CInt(tblMarca.SelectedItems(0).Text))
            If dt.Rows.Count > 0 Then
                txtID.Text = dt.Rows(0).Item(0)
                txtDescripcion.Text = dt.Rows(0).Item(1)
                chkEstado.Checked = IIf(dt.Rows(0).Item(2).Equals("True"), 1, 0)

            Else
                MessageBox.Show("ID de Marca no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            objMarca.modificarMarcas(CInt(txtID.Text), txtDescripcion.Text, chkEstado.Checked)
            MessageBox.Show("Marca registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarMarca()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub

End Class