Imports capaNegocio

Public Class Frmcliente

    Dim objcliente As New Clscliente

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarClientesLV()
    End Sub


    Private Sub limpiarControles()
        txtId.Clear()
        txtNombre.Clear()
        txtDNI.Clear()
        chkVigencia.Checked = False
    End Sub

    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub
    Private Sub listarClientesLV()
        Dim dt As New DataTable
        Try
            dt = objcliente.listarcliente
            If dt.Rows.Count > 0 Then
                lsvClientes.Items.Clear()
                For Each fila In dt.Rows
                    lsvClientes.Items.Add(fila.Item(0))
                    lsvClientes.Items(lsvClientes.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvClientes.Items(lsvClientes.Items.Count - 1).SubItems.Add(fila.item(2))
                    lsvClientes.Items(lsvClientes.Items.Count - 1).SubItems.Add(fila.item(3))
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
                txtId.Text = objcliente.generarIDCatgeoria
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objcliente.registrarcliente(CInt(txtId.Text), txtDNI.Text, txtNombre.Text, chkVigencia.Checked)
                MessageBox.Show("Cliente registrada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarClientesLV()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objcliente.modificarcliente(CInt(txtId.Text), txtNombre.Text, txtDNI.Text, chkVigencia.Checked)
            MessageBox.Show("Cliente modificada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarClientesLV()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objcliente.eliminarcliente(CInt(txtId.Text))
                limpiarControles()
                listarClientesLV()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de Cliente a eliminar!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            If txtId.TextLength > 0 Then
                objcliente.darBajacliente(CInt(txtId.Text))
                limpiarControles()
                listarClientesLV()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de Cliente a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarClientesLV()
        habilitarBotones(False)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objcliente.buscarcliente(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtNombre.Text = dt.Rows(0).Item(1)
                    txtDNI.Text = dt.Rows(0).Item(2)
                    chkVigencia.Checked = dt.Rows(0).Item(3)
                    habilitarBotones(True)
                Else
                    MessageBox.Show("ID de Cliente no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
    Private Sub lsvclientes_Click(sender As Object, e As EventArgs) Handles lsvClientes.Click
        txtId.Text = lsvClientes.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub
End Class