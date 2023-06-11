Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports capaNegocio

Public Class frmGestionarVenta

    Dim objProducto As New clsProducto
    Dim objCategoria As New clsCategoria
    Dim objMarca As New clsMarca
    Dim objUnidad As New clsUnidad
    Dim objVenta As New clsVenta
    Dim objDetalleVenta As New clsVentaDetalle

    Private Sub frmGestionarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarDniCliente()
        listarTipoComprobante()
        listarCategorias()
    End Sub

    Private Sub listarDniCliente()
        cmbDniCliente.DataSource = objVenta.listarDniCliente
        cmbDniCliente.DisplayMember = "dni"
        cmbDniCliente.ValueMember = "idcliente"
    End Sub

    Private Sub listarTipoComprobante()
        cmbTipoComprobante.DataSource = objVenta.listarTipoComprobante
        cmbTipoComprobante.DisplayMember = "descripcion"
        cmbTipoComprobante.ValueMember = "idtipocomprobante"
    End Sub

    Private Sub listarCategorias()
        cmbCategoria.DataSource = objCategoria.listarCategorias
        cmbCategoria.DisplayMember = "descripcion"
        cmbCategoria.ValueMember = "idcategoria"
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        Dim dt As New DataTable
        Try

            dgvProductos.DataSource = objProducto.listarProductoPorCategoria(cmbCategoria.SelectedValue)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            txtNombreCliente.Text = objVenta.buscarPorNombre(cmbDniCliente.SelectedValue).Rows(0).Item(0)



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            If btnRegistrar.Text = "REGISTRAR" Then
                btnRegistrar.Text = "GUARDAR"

                txtIDVenta.Text = objVenta.generarIDVenta
            Else
                btnRegistrar.Text = "REGISTRAR"

                'objVenta.registrarVenta(CInt(txtIDVenta.Text), cmbDniCliente.SelectedValue, 1, cmbTipoComprobante.SelectedValue, , txtTratamiento.Text, txtResultado.Text, txtNCita.Text)


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SISTEMA VETERINARIO", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class