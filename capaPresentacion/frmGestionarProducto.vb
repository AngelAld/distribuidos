Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports capaNegocio

Public Class frmGestionarProducto
    Dim objProducto As New clsProducto
    Dim objLaboratorio As New clsLaboratorio
    Dim objCategoria As New clsCategoria
    Dim objMarca As New clsMarca
    Dim objUnidad As New clsUnidad
    Dim id As Object
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProductos()
        listarLaboratorios()
        listarCategorias()
        listarMarcas()
        listarUnidades()
    End Sub

    Private Sub listarLaboratorios()
        cmbLaboratorio.DataSource = objLaboratorio.listarLaboratorios
        cmbLaboratorio.DisplayMember = "descripcion"
        cmbLaboratorio.ValueMember = "idlaboratorio"
    End Sub

    Private Sub listarCategorias()
        cmbCategoria.DataSource = objCategoria.listarCategorias
        cmbCategoria.DisplayMember = "descripcion"
        cmbCategoria.ValueMember = "idcategoria"
    End Sub

    Private Sub listarMarcas()
        cmbMarca.DataSource = objMarca.listarMarcas
        cmbMarca.DisplayMember = "descripcion"
        cmbMarca.ValueMember = "idmarca"
    End Sub

    Private Sub listarUnidades()
        cmbUnidad.DataSource = objUnidad.listarUnidades
        cmbUnidad.DisplayMember = "descripcion"
        cmbUnidad.ValueMember = "idunidadmedida"
    End Sub

    Private Sub listarProductos()
        Dim dt As New DataTable
        Try
            dt = objProducto.listarProducto
            If dt.Rows.Count > 0 Then
                lsvProductos.Items.Clear()
                For Each fila In dt.Rows
                    lsvProductos.Items.Add(fila.Item(0))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(1))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(2))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(3))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(4))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(5))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(6))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(7))
                    lsvProductos.Items(lsvProductos.Items.Count - 1).SubItems.Add(fila.item(8))

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
                txtID.Text = objProducto.generarIDProducto
            Else
                btnGuardar.Text = "NUEVO"

                objProducto.registrarProducto(CInt(txtID.Text), cmbLaboratorio.SelectedValue, cmbCategoria.SelectedValue, cmbMarca.SelectedValue, cmbUnidad.SelectedValue, txtProducto.Text, nudStockMin.Value, nudStockMax.Value, nudStock.Value, txtPrecioVen.Text, chkEstado.Checked)
                MessageBox.Show("Producto registrado exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarProductos()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub limpiarControles()
        txtProducto.Clear()
        nudStockMax.ResetText()
        nudStockMin.ResetText()
        nudStock.ResetText()
        txtPrecioVen.Clear()
        chkEstado.Checked = False
    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objProducto.eliminarProducto(CInt(lsvProductos.SelectedItems(0).Text))
            limpiarControles()
            listarProductos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDarBaja_Click(sender As Object, e As EventArgs) Handles btnDarBaja.Click
        Try
            objProducto.darBajaProducto(CInt(lsvProductos.SelectedItems(0).Text))
            limpiarControles()
            listarProductos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA HOTELERO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub lsvProductos_Click(sender As Object, e As EventArgs) Handles lsvProductos.Click
        Dim dt As New DataTable

        Try
            dt = objProducto.buscarProducto(CInt(lsvProductos.SelectedItems(0).Text))
            If dt.Rows.Count > 0 Then

                txtID.Text = dt.Rows(0).Item(0)
                cmbLaboratorio.SelectedValue = dt.Rows(0).Item(1)
                cmbCategoria.SelectedValue = dt.Rows(0).Item(2)
                cmbMarca.SelectedValue = dt.Rows(0).Item(3)
                cmbUnidad.SelectedValue = dt.Rows(0).Item(4)
                txtProducto.Text = dt.Rows(0).Item(5)
                nudStockMax.Value = dt.Rows(0).Item(6)
                nudStockMin.Value = dt.Rows(0).Item(7)
                nudStock.Value = dt.Rows(0).Item(8)
                txtPrecioVen.Text = dt.Rows(0).Item(9)
                chkEstado.Checked = dt.Rows(0).Item(10)

            Else
                MessageBox.Show("ID de producto no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                limpiarControles()
                listarProductos()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            objProducto.modificarProducto(CInt(txtID.Text), cmbLaboratorio.SelectedValue,
                                          cmbCategoria.SelectedValue, cmbMarca.SelectedValue,
                                          cmbUnidad.SelectedValue, txtProducto.Text, nudStockMax.Value,
                                          nudStockMin.Value, nudStock.Value,
                                          txtPrecioVen.Text, chkEstado.Checked)
            MessageBox.Show("Producto modificado exitosamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiarControles()
            listarProductos()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
