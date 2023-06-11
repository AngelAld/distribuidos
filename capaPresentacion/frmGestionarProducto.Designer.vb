<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGestionarProducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lsvProductos = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        ColumnHeader11 = New ColumnHeader()
        Label2 = New Label()
        txtProducto = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        cmbLaboratorio = New ComboBox()
        cmbCategoria = New ComboBox()
        cmbMarca = New ComboBox()
        cmbUnidad = New ComboBox()
        Label7 = New Label()
        Label9 = New Label()
        txtPrecioVen = New TextBox()
        chkEstado = New CheckBox()
        nudStockMax = New NumericUpDown()
        nudStockMin = New NumericUpDown()
        nudStock = New NumericUpDown()
        Panel1 = New Panel()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnDarBaja = New Button()
        Panel2 = New Panel()
        txtID = New TextBox()
        btnModificar = New Button()
        CType(nudStockMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStockMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudStock, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' lsvProductos
        ' 
        lsvProductos.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader8, ColumnHeader10, ColumnHeader11})
        lsvProductos.FullRowSelect = True
        lsvProductos.GridLines = True
        lsvProductos.Location = New Point(13, 459)
        lsvProductos.Name = "lsvProductos"
        lsvProductos.Size = New Size(1308, 228)
        lsvProductos.TabIndex = 5
        lsvProductos.UseCompatibleStateImageBehavior = False
        lsvProductos.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "CATEGORIA"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "LABORATORIO"
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "PRODUCTO"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "MARCA"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "UND MEDIDA"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "STOCK"
        ColumnHeader8.Width = 100
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "PRECIO"
        ColumnHeader10.Width = 100
        ' 
        ' ColumnHeader11
        ' 
        ColumnHeader11.Text = "ESTADO"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(33, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 25)
        Label2.TabIndex = 0
        Label2.Text = "LABORATORIO"
        ' 
        ' txtProducto
        ' 
        txtProducto.BorderStyle = BorderStyle.FixedSingle
        txtProducto.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtProducto.Location = New Point(169, 120)
        txtProducto.Name = "txtProducto"
        txtProducto.Size = New Size(427, 34)
        txtProducto.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(58, 81)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 25)
        Label3.TabIndex = 0
        Label3.Text = "CATEGORIA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(89, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 25)
        Label4.TabIndex = 0
        Label4.Text = "MARCA"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(10, 213)
        Label5.Name = "Label5"
        Label5.Size = New Size(153, 25)
        Label5.TabIndex = 4
        Label5.Text = "UNIDAD MEDIDA"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label12.Location = New Point(309, 267)
        Label12.Name = "Label12"
        Label12.Size = New Size(139, 25)
        Label12.TabIndex = 11
        Label12.Text = "STOCK MINIMO"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label13.Location = New Point(24, 267)
        Label13.Name = "Label13"
        Label13.Size = New Size(144, 25)
        Label13.TabIndex = 12
        Label13.Text = "STOCK MAXIMO"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label14.Location = New Point(29, 317)
        Label14.Name = "Label14"
        Label14.Size = New Size(134, 25)
        Label14.TabIndex = 13
        Label14.Text = "STOCK ACTUAL"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label15.Location = New Point(59, 125)
        Label15.Name = "Label15"
        Label15.Size = New Size(105, 25)
        Label15.TabIndex = 14
        Label15.Text = "PRODUCTO"
        ' 
        ' cmbLaboratorio
        ' 
        cmbLaboratorio.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbLaboratorio.FormattingEnabled = True
        cmbLaboratorio.Location = New Point(169, 29)
        cmbLaboratorio.Margin = New Padding(3, 4, 3, 4)
        cmbLaboratorio.Name = "cmbLaboratorio"
        cmbLaboratorio.Size = New Size(427, 36)
        cmbLaboratorio.TabIndex = 22
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(169, 75)
        cmbCategoria.Margin = New Padding(3, 4, 3, 4)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(427, 36)
        cmbCategoria.TabIndex = 23
        ' 
        ' cmbMarca
        ' 
        cmbMarca.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbMarca.FormattingEnabled = True
        cmbMarca.Location = New Point(169, 163)
        cmbMarca.Margin = New Padding(3, 4, 3, 4)
        cmbMarca.Name = "cmbMarca"
        cmbMarca.Size = New Size(427, 36)
        cmbMarca.TabIndex = 24
        ' 
        ' cmbUnidad
        ' 
        cmbUnidad.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        cmbUnidad.FormattingEnabled = True
        cmbUnidad.Location = New Point(169, 207)
        cmbUnidad.Margin = New Padding(3, 4, 3, 4)
        cmbUnidad.Name = "cmbUnidad"
        cmbUnidad.Size = New Size(427, 36)
        cmbUnidad.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(79, 373)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 25)
        Label7.TabIndex = 31
        Label7.Text = "PRECIO"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(370, 373)
        Label9.Name = "Label9"
        Label9.Size = New Size(78, 25)
        Label9.TabIndex = 32
        Label9.Text = "ESTADO"
        ' 
        ' txtPrecioVen
        ' 
        txtPrecioVen.BorderStyle = BorderStyle.FixedSingle
        txtPrecioVen.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtPrecioVen.Location = New Point(169, 368)
        txtPrecioVen.Name = "txtPrecioVen"
        txtPrecioVen.Size = New Size(130, 34)
        txtPrecioVen.TabIndex = 36
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkEstado.Location = New Point(458, 368)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(90, 32)
        chkEstado.TabIndex = 37
        chkEstado.Text = "Activo"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' nudStockMax
        ' 
        nudStockMax.BorderStyle = BorderStyle.FixedSingle
        nudStockMax.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nudStockMax.Location = New Point(169, 261)
        nudStockMax.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStockMax.Name = "nudStockMax"
        nudStockMax.Size = New Size(130, 34)
        nudStockMax.TabIndex = 38
        ' 
        ' nudStockMin
        ' 
        nudStockMin.BorderStyle = BorderStyle.FixedSingle
        nudStockMin.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nudStockMin.Location = New Point(458, 261)
        nudStockMin.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStockMin.Name = "nudStockMin"
        nudStockMin.Size = New Size(138, 34)
        nudStockMin.TabIndex = 39
        ' 
        ' nudStock
        ' 
        nudStock.BorderStyle = BorderStyle.FixedSingle
        nudStock.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        nudStock.Location = New Point(169, 312)
        nudStock.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        nudStock.Name = "nudStock"
        nudStock.Size = New Size(130, 34)
        nudStock.TabIndex = 40
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(nudStock)
        Panel1.Controls.Add(nudStockMin)
        Panel1.Controls.Add(nudStockMax)
        Panel1.Controls.Add(chkEstado)
        Panel1.Controls.Add(txtPrecioVen)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(cmbUnidad)
        Panel1.Controls.Add(cmbMarca)
        Panel1.Controls.Add(cmbCategoria)
        Panel1.Controls.Add(cmbLaboratorio)
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label12)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtProducto)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(409, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(622, 426)
        Panel1.TabIndex = 2
        ' 
        ' btnGuardar
        ' 
        btnGuardar.AccessibleRole = AccessibleRole.ProgressBar
        btnGuardar.BackColor = Color.Blue
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuardar.ForeColor = SystemColors.HighlightText
        btnGuardar.Location = New Point(1097, 37)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(157, 45)
        btnGuardar.TabIndex = 6
        btnGuardar.Text = "NUEVO"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.AccessibleRole = AccessibleRole.ProgressBar
        btnEliminar.BackColor = Color.Red
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminar.ForeColor = SystemColors.HighlightText
        btnEliminar.Location = New Point(1097, 242)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(157, 45)
        btnEliminar.TabIndex = 7
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.AccessibleRole = AccessibleRole.ProgressBar
        btnDarBaja.BackColor = Color.RosyBrown
        btnDarBaja.FlatAppearance.BorderSize = 0
        btnDarBaja.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDarBaja.ForeColor = SystemColors.HighlightText
        btnDarBaja.Location = New Point(1097, 355)
        btnDarBaja.Name = "btnDarBaja"
        btnDarBaja.Size = New Size(157, 45)
        btnDarBaja.TabIndex = 8
        btnDarBaja.Text = "DAR BAJA"
        btnDarBaja.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackgroundImage = My.Resources.Resources.cart
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.CausesValidation = False
        Panel2.Controls.Add(txtID)
        Panel2.Location = New Point(11, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(378, 426)
        Panel2.TabIndex = 9
        ' 
        ' txtID
        ' 
        txtID.Location = New Point(234, 13)
        txtID.Name = "txtID"
        txtID.Size = New Size(125, 27)
        txtID.TabIndex = 0
        ' 
        ' btnModificar
        ' 
        btnModificar.AccessibleRole = AccessibleRole.ProgressBar
        btnModificar.BackColor = Color.SeaGreen
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnModificar.ForeColor = SystemColors.HighlightText
        btnModificar.Location = New Point(1097, 137)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(157, 45)
        btnModificar.TabIndex = 10
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' frmGestionarProducto
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1333, 701)
        Controls.Add(btnModificar)
        Controls.Add(Panel2)
        Controls.Add(btnDarBaja)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Controls.Add(lsvProductos)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmGestionarProducto"
        Text = ".:Gestionar Producto:."
        CType(nudStockMax, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStockMin, ComponentModel.ISupportInitialize).EndInit()
        CType(nudStock, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents lsvProductos As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbLaboratorio As ComboBox
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents cmbMarca As ComboBox
    Friend WithEvents cmbUnidad As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPrecioVen As TextBox
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents nudStockMax As NumericUpDown
    Friend WithEvents nudStockMin As NumericUpDown
    Friend WithEvents nudStock As NumericUpDown
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtID As TextBox
    Friend WithEvents btnModificar As Button
End Class
