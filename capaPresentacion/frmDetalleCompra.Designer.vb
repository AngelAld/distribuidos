<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleCompra
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
        lblProducto = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        lblProductoAgregdo = New ListView()
        ColumnHeader11 = New ColumnHeader()
        ColumnHeader12 = New ColumnHeader()
        ColumnHeader13 = New ColumnHeader()
        ColumnHeader14 = New ColumnHeader()
        ColumnHeader15 = New ColumnHeader()
        ColumnHeader16 = New ColumnHeader()
        ColumnHeader17 = New ColumnHeader()
        ColumnHeader18 = New ColumnHeader()
        ColumnHeader19 = New ColumnHeader()
        ColumnHeader20 = New ColumnHeader()
        txtBuscar = New TextBox()
        btnNuevo = New Button()
        btnQuitar = New Button()
        btnSalir = New Button()
        btnGuardar = New Button()
        SuspendLayout()
        ' 
        ' lblProducto
        ' 
        lblProducto.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader4, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9, ColumnHeader3, ColumnHeader5, ColumnHeader10})
        lblProducto.FullRowSelect = True
        lblProducto.GridLines = True
        lblProducto.Location = New Point(5, 53)
        lblProducto.Margin = New Padding(3, 2, 3, 2)
        lblProducto.Name = "lblProducto"
        lblProducto.Size = New Size(919, 172)
        lblProducto.TabIndex = 18
        lblProducto.UseCompatibleStateImageBehavior = False
        lblProducto.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 50
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "PRODUCTO"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "LABORATORIO"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "CATEGORIA"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "MARCA"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "UNIDADMEDIDA"
        ColumnHeader8.Width = 100
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "DESCRIPCION"
        ColumnHeader9.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "STOCKMAXIMO"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "STOCKMINIMO"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "STOCK"
        ' 
        ' lblProductoAgregdo
        ' 
        lblProductoAgregdo.Columns.AddRange(New ColumnHeader() {ColumnHeader11, ColumnHeader12, ColumnHeader13, ColumnHeader14, ColumnHeader15, ColumnHeader16, ColumnHeader17, ColumnHeader18, ColumnHeader19, ColumnHeader20})
        lblProductoAgregdo.FullRowSelect = True
        lblProductoAgregdo.GridLines = True
        lblProductoAgregdo.Location = New Point(5, 305)
        lblProductoAgregdo.Margin = New Padding(3, 2, 3, 2)
        lblProductoAgregdo.Name = "lblProductoAgregdo"
        lblProductoAgregdo.Size = New Size(919, 172)
        lblProductoAgregdo.TabIndex = 19
        lblProductoAgregdo.UseCompatibleStateImageBehavior = False
        lblProductoAgregdo.View = View.Details
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "ID"
        ColumnHeader11.Width = 50
        ' 
        ' ColumnHeader12
        ' 
        ColumnHeader12.Text = "PRODUCTO"
        ColumnHeader12.Width = 100
        ' 
        ' ColumnHeader13
        ' 
        ColumnHeader13.Text = "LABORATORIO"
        ColumnHeader13.Width = 100
        ' 
        ' ColumnHeader14
        ' 
        ColumnHeader14.Text = "CATEGORIA"
        ColumnHeader14.Width = 100
        ' 
        ' ColumnHeader15
        ' 
        ColumnHeader15.Text = "MARCA"
        ColumnHeader15.Width = 100
        ' 
        ' ColumnHeader16
        ' 
        ColumnHeader16.Text = "UNIDADMEDIDA"
        ColumnHeader16.Width = 100
        ' 
        ' ColumnHeader17
        ' 
        ColumnHeader17.Text = "DESCRIPCION"
        ColumnHeader17.Width = 100
        ' 
        ' ColumnHeader18
        ' 
        ColumnHeader18.Text = "STOCKMAXIMO"
        ColumnHeader18.Width = 100
        ' 
        ' ColumnHeader19
        ' 
        ColumnHeader19.Text = "STOCKMINIMO"
        ColumnHeader19.Width = 100
        ' 
        ' ColumnHeader20
        ' 
        ColumnHeader20.Text = "STOCK"
        ' 
        ' txtBuscar
        ' 
        txtBuscar.Location = New Point(227, 12)
        txtBuscar.Name = "txtBuscar"
        txtBuscar.Size = New Size(484, 23)
        txtBuscar.TabIndex = 20
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = SystemColors.HotTrack
        btnNuevo.Location = New Point(747, 5)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(113, 34)
        btnNuevo.TabIndex = 21
        btnNuevo.Text = "AGREGAR"
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnQuitar
        ' 
        btnQuitar.BackColor = SystemColors.HotTrack
        btnQuitar.Location = New Point(747, 248)
        btnQuitar.Name = "btnQuitar"
        btnQuitar.Size = New Size(113, 34)
        btnQuitar.TabIndex = 22
        btnQuitar.Text = "QUITAR"
        btnQuitar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = SystemColors.HotTrack
        btnSalir.Location = New Point(747, 482)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(113, 34)
        btnSalir.TabIndex = 23
        btnSalir.Text = "SALIR"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = SystemColors.HotTrack
        btnGuardar.Location = New Point(598, 480)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(113, 34)
        btnGuardar.TabIndex = 24
        btnGuardar.Text = "GUARDAR"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' frmDetalleCompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(936, 526)
        Controls.Add(btnGuardar)
        Controls.Add(btnSalir)
        Controls.Add(btnQuitar)
        Controls.Add(btnNuevo)
        Controls.Add(txtBuscar)
        Controls.Add(lblProductoAgregdo)
        Controls.Add(lblProducto)
        Name = "frmDetalleCompra"
        Text = "frmDetalleCompra"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblProducto As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents lblProductoAgregdo As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader18 As ColumnHeader
    Friend WithEvents ColumnHeader19 As ColumnHeader
    Friend WithEvents ColumnHeader20 As ColumnHeader
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnGuardar As Button
End Class
