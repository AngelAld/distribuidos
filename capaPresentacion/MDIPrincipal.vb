Imports System.Windows.Forms

Public Class MDIPrincipal


    Private m_ChildFormNumber As Integer

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip.ItemClicked

    End Sub


    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim objProductos As New frmGestionarProducto
        objProductos.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim objMarcas As New frmGestionarMarca
        objMarcas.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim objlabs As New frmGestionarLaboratorio
        objlabs.ShowDialog()
    End Sub


    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click

    End Sub


    Private Sub RolesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub IniciarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IniciarSesionToolStripMenuItem.Click

    End Sub

    Private Sub RolesToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem.Click
        Dim objRol As New Frmrol
        objRol.ShowDialog()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        Dim objUsu As New Usuario
        objUsu.ShowDialog()
    End Sub

    Private Sub UnidadDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadDeMedidaToolStripMenuItem.Click
        Dim objUn As New frmGestionarUnidadMedida
        objUn.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim objCat As New frmGestionarCategorias
        objCat.ShowDialog()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim objCli As New Frmcliente
        objCli.ShowDialog()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaToolStripMenuItem.Click
        Dim objVenta = New frmGestionarVenta
        objVenta.ShowDialog()
    End Sub

    Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoToolStripMenuItem.Click
        Dim objPago As New frmPago
        objPago.ShowDialog()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        IniciarSesionToolStripMenuItem.Enabled = True
        Dim objLogin As New frmLogin
        objLogin.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Dim objProv As New frmProveedor
        objProv.ShowDialog()
    End Sub

    Private Sub ComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComprasToolStripMenuItem.Click
        Dim objCompra As New frmcompra
        objCompra.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Hide()
        Dim objLogin As New frmLogin
        objLogin.Show()
    End Sub
End Class
