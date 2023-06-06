Imports capaNegocio

Public Class frmProveedor
    Dim objPro As New clsProveedor


    Private Sub limpiarControles()
        txtId.Clear()
        txtNombre.Clear()
        txtRuc.Clear()
        txtTelefono.Clear()
        chkVigencia.Checked = False
    End Sub

    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub

    Private Sub listarproveedor()
        Dim dt As New DataTable
        Try
            dt = objPro.listarproveedor
            If dt.Rows.Count > 0 Then
                lsvProveedor.Items.Clear()
                For Each fila In dt.Rows
                    lsvProveedor.Items.Add(fila.Item(0))
                    lsvProveedor.Items(lsvProveedor.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvProveedor.Items(lsvProveedor.Items.Count - 1).SubItems.Add(fila.item(2))
                    lsvProveedor.Items(lsvProveedor.Items.Count - 1).SubItems.Add(fila.item(3))
                    lsvProveedor.Items(lsvProveedor.Items.Count - 1).SubItems.Add(fila.item(4))

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
                txtId.Text = objPro.generarIDproveedor
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objPro.registrarproveedor(CInt(txtId.Text), txtNombre.Text, txtRuc.Text, txtTelefono.Text, chkVigencia.Checked)
                MessageBox.Show("Usuario registrada exitosamente!", "SISTEMA USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarproveedor()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objPro.modificarproveedor(CInt(txtId.Text), txtNombre.Text, txtRuc.Text, txtTelefono.Text, chkVigencia.Checked)
            MessageBox.Show("proveedor modificado exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarproveedor()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtId.TextLength > 0 Then
                objPro.eliminarproveedor(CInt(txtId.Text))
                limpiarControles()
                listarproveedor()
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
                objPro.darBajaproveedor(CInt(txtId.Text))
                limpiarControles()
                listarproveedor()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de usurio a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub lsvProveedor_Click(sender As Object, e As EventArgs) Handles lsvProveedor.Click
        txtId.Text = lsvProveedor.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarproveedor()
        habilitarBotones(False)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtId.TextLength > 0 Then
                dt = objPro.buscarproveedor(CInt(txtId.Text))
                If dt.Rows.Count > 0 Then
                    txtNombre.Text = dt.Rows(0).Item(1)
                    txtRuc.Text = dt.Rows(0).Item(2)
                    txtTelefono.Text = dt.Rows(0).Item(3)
                    chkVigencia.Checked = dt.Rows(0).Item(4)
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

    Private Sub frmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarproveedor()
    End Sub
End Class