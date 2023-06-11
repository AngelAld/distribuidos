Imports capaNegocio

Public Class frmGestionarLaboratorio

    Dim objLaboratorio As New clsLaboratorio
    Dim id As Object

    Private Sub frmGestionarLaboratorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarLaboratorios()
    End Sub

    Private Sub listarLaboratorios()
        Dim dt As New DataTable
        Try
            dt = objLaboratorio.listarLaboratorios
            If dt.Rows.Count > 0 Then
                tblLaboratorio.Items.Clear()
                For Each fila In dt.Rows
                    tblLaboratorio.Items.Add(fila.Item(0))
                    tblLaboratorio.Items(tblLaboratorio.Items.Count - 1).SubItems.Add(fila.item(1))
                    tblLaboratorio.Items(tblLaboratorio.Items.Count - 1).SubItems.Add(fila.item(2))

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
                txtID.Text = objLaboratorio.generarIDLaboratorio
                habilitarBotones(False)
            Else
                btnGuardar.Text = "NUEVO"
                objLaboratorio.registrarLaboratorio(CInt(txtID.Text), txtDescripcion.Text, chkEstado.Checked)
                MessageBox.Show("Laboratorio registrado exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarLaboratorios()
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
            objLaboratorio.eliminarLaboratorio(CInt(tblLaboratorio.SelectedItems(0).Text))
            limpiarControles()
            listarLaboratorios()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objLaboratorio.darBajaLaboratorio(CInt(tblLaboratorio.SelectedItems(0).Text))
            limpiarControles()
            listarLaboratorios()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub tblLaboratorio_Click(sender As Object, e As EventArgs) Handles tblLaboratorio.Click
        Dim dt As New DataTable

        Try
            dt = objLaboratorio.buscarLaboratorio(CInt(tblLaboratorio.SelectedItems(0).Text))
            If dt.Rows.Count > 0 Then
                txtID.Text = dt.Rows(0).Item(0)
                txtDescripcion.Text = dt.Rows(0).Item(1)
                chkEstado.Checked = IIf(dt.Rows(0).Item(2).Equals("True"), 1, 0)

            Else
                MessageBox.Show("ID de Laboratorio no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            objLaboratorio.modificarLaboratorio(CInt(txtID.Text), txtDescripcion.Text, chkEstado.Checked)
            MessageBox.Show("Laboratorio Modificado exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarLaboratorios()

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