<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        MenuStrip = New MenuStrip()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        IniciarSesionToolStripMenuItem = New ToolStripMenuItem()
        CerrarSesionToolStripMenuItem = New ToolStripMenuItem()
        FileMenu = New ToolStripMenuItem()
        ProveedoresToolStripMenuItem = New ToolStripMenuItem()
        UnidadDeMedidaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        CategoriasToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        EditMenu = New ToolStripMenuItem()
        VentaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator7 = New ToolStripSeparator()
        PagoToolStripMenuItem = New ToolStripMenuItem()
        CompraToolStripMenuItem = New ToolStripMenuItem()
        ComprasToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem2 = New ToolStripMenuItem()
        RolesToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem1 = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        ToolStrip = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        StatusStrip = New StatusStrip()
        ToolStripStatusLabel = New ToolStripStatusLabel()
        ToolStripStatusLabel1 = New ToolStripStatusLabel()
        ToolTip = New ToolTip(components)
        MenuStrip.SuspendLayout()
        ToolStrip.SuspendLayout()
        StatusStrip.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip
        ' 
        MenuStrip.Items.AddRange(New ToolStripItem() {UsuariosToolStripMenuItem, FileMenu, EditMenu, CompraToolStripMenuItem, UsuariosToolStripMenuItem2})
        MenuStrip.Location = New Point(0, 0)
        MenuStrip.Name = "MenuStrip"
        MenuStrip.Padding = New Padding(7, 2, 0, 2)
        MenuStrip.Size = New Size(916, 24)
        MenuStrip.TabIndex = 5
        MenuStrip.Text = "MenuStrip"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {IniciarSesionToolStripMenuItem, CerrarSesionToolStripMenuItem})
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(48, 20)
        UsuariosToolStripMenuItem.Text = "Inicio"
        ' 
        ' IniciarSesionToolStripMenuItem
        ' 
        IniciarSesionToolStripMenuItem.Enabled = False
        IniciarSesionToolStripMenuItem.Name = "IniciarSesionToolStripMenuItem"
        IniciarSesionToolStripMenuItem.Size = New Size(180, 22)
        IniciarSesionToolStripMenuItem.Text = "Iniciar sesion"
        ' 
        ' CerrarSesionToolStripMenuItem
        ' 
        CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        CerrarSesionToolStripMenuItem.Size = New Size(180, 22)
        CerrarSesionToolStripMenuItem.Text = "cerrar sesion"
        ' 
        ' FileMenu
        ' 
        FileMenu.DropDownItems.AddRange(New ToolStripItem() {ProveedoresToolStripMenuItem, UnidadDeMedidaToolStripMenuItem, ToolStripSeparator2, CategoriasToolStripMenuItem, ToolStripMenuItem2, ToolStripMenuItem1, ToolStripSeparator4, ToolStripMenuItem3})
        FileMenu.ImageTransparentColor = SystemColors.ActiveBorder
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(101, 20)
        FileMenu.Text = "&Mantenimiento"
        ' 
        ' ProveedoresToolStripMenuItem
        ' 
        ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        ProveedoresToolStripMenuItem.Size = New Size(171, 22)
        ProveedoresToolStripMenuItem.Text = "Proveedores"
        ' 
        ' UnidadDeMedidaToolStripMenuItem
        ' 
        UnidadDeMedidaToolStripMenuItem.Name = "UnidadDeMedidaToolStripMenuItem"
        UnidadDeMedidaToolStripMenuItem.Size = New Size(171, 22)
        UnidadDeMedidaToolStripMenuItem.Text = "Unidad de medida"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(168, 6)
        ' 
        ' CategoriasToolStripMenuItem
        ' 
        CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        CategoriasToolStripMenuItem.Size = New Size(171, 22)
        CategoriasToolStripMenuItem.Text = "Categorias"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.Size = New Size(171, 22)
        ToolStripMenuItem2.Text = "Marcas"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(171, 22)
        ToolStripMenuItem1.Text = "Laboratorios"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(168, 6)
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.Size = New Size(171, 22)
        ToolStripMenuItem3.Text = "Productos"
        ' 
        ' EditMenu
        ' 
        EditMenu.DropDownItems.AddRange(New ToolStripItem() {VentaToolStripMenuItem, ToolStripSeparator7, PagoToolStripMenuItem})
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(48, 20)
        EditMenu.Text = "&Venta"
        ' 
        ' VentaToolStripMenuItem
        ' 
        VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        VentaToolStripMenuItem.Size = New Size(103, 22)
        VentaToolStripMenuItem.Text = "Venta"
        ' 
        ' ToolStripSeparator7
        ' 
        ToolStripSeparator7.Name = "ToolStripSeparator7"
        ToolStripSeparator7.Size = New Size(100, 6)
        ' 
        ' PagoToolStripMenuItem
        ' 
        PagoToolStripMenuItem.Name = "PagoToolStripMenuItem"
        PagoToolStripMenuItem.Size = New Size(103, 22)
        PagoToolStripMenuItem.Text = "Pago"
        ' 
        ' CompraToolStripMenuItem
        ' 
        CompraToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ComprasToolStripMenuItem})
        CompraToolStripMenuItem.Name = "CompraToolStripMenuItem"
        CompraToolStripMenuItem.Size = New Size(62, 20)
        CompraToolStripMenuItem.Text = "Compra"
        ' 
        ' ComprasToolStripMenuItem
        ' 
        ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        ComprasToolStripMenuItem.Size = New Size(122, 22)
        ComprasToolStripMenuItem.Text = "Compras"
        ' 
        ' UsuariosToolStripMenuItem2
        ' 
        UsuariosToolStripMenuItem2.DropDownItems.AddRange(New ToolStripItem() {RolesToolStripMenuItem, UsuariosToolStripMenuItem1, ClientesToolStripMenuItem})
        UsuariosToolStripMenuItem2.Name = "UsuariosToolStripMenuItem2"
        UsuariosToolStripMenuItem2.Size = New Size(64, 20)
        UsuariosToolStripMenuItem2.Text = "Usuarios"
        ' 
        ' RolesToolStripMenuItem
        ' 
        RolesToolStripMenuItem.Name = "RolesToolStripMenuItem"
        RolesToolStripMenuItem.Size = New Size(119, 22)
        RolesToolStripMenuItem.Text = "Roles"
        ' 
        ' UsuariosToolStripMenuItem1
        ' 
        UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        UsuariosToolStripMenuItem1.Size = New Size(119, 22)
        UsuariosToolStripMenuItem1.Text = "Usuarios"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(119, 22)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' ToolStrip
        ' 
        ToolStrip.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripSeparator1})
        ToolStrip.Location = New Point(0, 24)
        ToolStrip.Name = "ToolStrip"
        ToolStrip.Size = New Size(916, 25)
        ToolStrip.TabIndex = 6
        ToolStrip.Text = "ToolStrip"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources._3994382_close_access_sign_out_exit_logout
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "ToolStripButton1"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' StatusStrip
        ' 
        StatusStrip.Items.AddRange(New ToolStripItem() {ToolStripStatusLabel, ToolStripStatusLabel1})
        StatusStrip.Location = New Point(0, 495)
        StatusStrip.Name = "StatusStrip"
        StatusStrip.Padding = New Padding(1, 0, 16, 0)
        StatusStrip.Size = New Size(916, 22)
        StatusStrip.TabIndex = 7
        StatusStrip.Text = "StatusStrip"
        ' 
        ' ToolStripStatusLabel
        ' 
        ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        ToolStripStatusLabel.Size = New Size(50, 17)
        ToolStripStatusLabel.Text = "Usuario:"
        ' 
        ' ToolStripStatusLabel1
        ' 
        ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        ToolStripStatusLabel1.Size = New Size(119, 17)
        ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        ' 
        ' MDIPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.background
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(916, 517)
        Controls.Add(ToolStrip)
        Controls.Add(MenuStrip)
        Controls.Add(StatusStrip)
        FormBorderStyle = FormBorderStyle.FixedSingle
        IsMdiContainer = True
        MainMenuStrip = MenuStrip
        Margin = New Padding(4, 3, 4, 3)
        Name = "MDIPrincipal"
        Text = "Menu principal - Sistema de farmacia"
        MenuStrip.ResumeLayout(False)
        MenuStrip.PerformLayout()
        ToolStrip.ResumeLayout(False)
        ToolStrip.PerformLayout()
        StatusStrip.ResumeLayout(False)
        StatusStrip.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IniciarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents RolesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UnidadDeMedidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CompraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As ToolStripMenuItem
End Class
