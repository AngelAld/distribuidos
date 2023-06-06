Imports capaNegocio
Public Class Frmrol
    Dim objrol As New clsrol


    Private Sub frmrol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarrolLV()
    End Sub



    Private Sub listarrolLV()
        Dim dt As New DataTable
        Try
            dt = objrol.listarrol
            If dt.Rows.Count > 0 Then
                lsvRol.Items.Clear()
                For Each fila In dt.Rows
                    lsvRol.Items.Add(fila.Item(0))
                    lsvRol.Items(lsvRol.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvRol.Items(lsvRol.Items.Count - 1).SubItems.Add(fila.item(2))
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
                txtId.Text = objrol.generarIDRol
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objrol.registrarRol(CInt(txtId.Text), txtNombre.Text, chkVigencia.Checked)
                MessageBox.Show("ROL registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarrolLV()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub limpiarControles()
        txtId.Clear()
        txtNombre.Clear()
        chkVigencia.Checked = False
    End Sub
    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objrol.eliminarrol(CInt(txtId.Text))
                limpiarControles()
                listarrolLV()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de ROL a eliminar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtId.TextLength > 0 Then
                objrol.darBajarol(CInt(txtId.Text))
                limpiarControles()
                listarrolLV()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de ROL a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objrol.modificarrol(CInt(txtId.Text), txtNombre.Text, chkVigencia.Checked)
            MessageBox.Show("ROL modificada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarrolLV()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lsvrol_Click(sender As Object, e As EventArgs) Handles lsvRol.Click
        txtId.Text = lsvRol.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarrolLV()
        habilitarBotones(False)

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objrol.buscarrol(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtNombre.Text = dt.Rows(0).Item(1)
                    chkVigencia.Checked = dt.Rows(0).Item(2)
                    habilitarBotones(True)
                Else
                    MessageBox.Show("ID de ROL no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub lsvRol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvRol.SelectedIndexChanged

    End Sub


End Class