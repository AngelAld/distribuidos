Imports capaNegocio

Public Class Usuario
    Dim objrol As New clsrol
    Dim objusuario As New clsUsuario
    Private Sub listarRol()
        cmbrol.DataSource = objrol.listarrol
        cmbrol.DisplayMember = "Nombre"
        cmbrol.ValueMember = "idrol"
    End Sub
    Private Sub usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarRol()
        cmbrol.SelectedValue = 0
        listarusuario()

    End Sub


    Private Sub listarusuario()
        Dim dt As New DataTable
        Try
            dt = objusuario.listarusuario
            If dt.Rows.Count > 0 Then
                lvlusuario.Items.Clear()
                For Each fila In dt.Rows
                    lvlusuario.Items.Add(fila.Item(0))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(1))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(2))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(3))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(4))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(5))
                    lvlusuario.Items(lvlusuario.Items.Count - 1).SubItems.Add(fila.item(6))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub limpiarControles()
        txtid.Clear()
        cmbrol.SelectedValue = 0
        txtnombre.Clear()
        txtusuario.Clear()
        txtclave.Clear()
        txtcorreo.Clear()
        chkVigencia.Checked = False
    End Sub
    Private Sub habilitarBotones(est As Boolean)
        btnModificar.Enabled = est
        btnEliminar.Enabled = est
        btnDarBaja.Enabled = est
    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            If btnNuevo.Text = "Nuevo" Then
                btnNuevo.Text = "Guardar"
                limpiarControles()
                txtid.Text = objusuario.generarIDusuario
                habilitarBotones(False)
            Else
                btnNuevo.Text = "Nuevo"
                objusuario.registrarusuario(CInt(txtid.Text), cmbrol.SelectedValue, txtnombre.Text, txtusuario.Text, txtclave.Text, txtcorreo.Text, chkVigencia.Checked)
                MessageBox.Show("Usuario registrada exitosamente!", "SISTEMA USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarusuario()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA USUARIO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objusuario.modificarusuario(CInt(txtid.Text), cmbrol.SelectedValue, txtnombre.Text, txtusuario.Text, txtclave.Text, txtcorreo.Text, chkVigencia.Checked)
            MessageBox.Show("USUARIO modificada exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarusuario()
            habilitarBotones(False)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If txtid.TextLength > 0 Then
                objusuario.eliminarusuario(CInt(txtid.Text))
                limpiarControles()
                listarusuario()
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
            If txtid.TextLength > 0 Then
                objusuario.darBajausuario(CInt(txtid.Text))
                limpiarControles()
                listarusuario()
                habilitarBotones(False)
            Else
                MessageBox.Show("Ingrese ID de usurio a dar de Baja!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarControles()
        listarusuario()
        habilitarBotones(False)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim dt As New DataTable
        Try
            If txtid.TextLength > 0 Then
                dt = objusuario.buscarusuario(CInt(txtid.Text))
                If dt.Rows.Count > 0 Then
                    cmbrol.SelectedValue = dt.Rows(0).Item(6)
                    txtnombre.Text = dt.Rows(0).Item(1)
                    txtusuario.Text = dt.Rows(0).Item(2)
                    txtclave.Text = dt.Rows(0).Item(3)
                    txtcorreo.Text = dt.Rows(0).Item(4)
                    chkVigencia.Checked = dt.Rows(0).Item(5)
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

    Private Sub lvlusuario_Click(sender As Object, e As EventArgs) Handles lvlusuario.Click
        txtid.Text = lvlusuario.SelectedItems(0).Text
        btnBuscar_Click(sender, e)
    End Sub



End Class