<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarVenta
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmGestionarVenta))
        Panel1 = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        dtpFechaVenta = New DateTimePicker()
        Label6 = New Label()
        txtCodigoComprobante = New TextBox()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        cmbDniCliente = New ComboBox()
        cmbTipoComprobante = New ComboBox()
        Label13 = New Label()
        txtIDUsuario = New TextBox()
        txtIDVenta = New TextBox()
        btnBuscarCliente = New Button()
        Label7 = New Label()
        txtNombreCliente = New TextBox()
        Label9 = New Label()
        Panel6 = New Panel()
        Label10 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        dgvProductos = New DataGridView()
        cmbCategoria = New ComboBox()
        Label8 = New Label()
        GroupBox1 = New GroupBox()
        ListView1 = New ListView()
        Panel5 = New Panel()
        btnRegistrar = New Button()
        Label14 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(392, 150)
        Panel1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(154, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(211, 20)
        Label3.TabIndex = 3
        Label3.Text = "Av. Balta 1122 - Chiclayo -Perú"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(238, 20)
        Label2.TabIndex = 2
        Label2.Text = "Le ofrecemos atencion profesional"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(154, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(224, 23)
        Label1.TabIndex = 1
        Label1.Text = "Farmacia Salud y Bienestar"
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Location = New Point(17, 15)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(117, 106)
        Panel2.TabIndex = 0
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(dtpFechaVenta)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(txtCodigoComprobante)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Location = New Point(410, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(273, 150)
        Panel3.TabIndex = 3
        ' 
        ' dtpFechaVenta
        ' 
        dtpFechaVenta.Location = New Point(96, 50)
        dtpFechaVenta.Name = "dtpFechaVenta"
        dtpFechaVenta.Size = New Size(163, 27)
        dtpFechaVenta.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(17, 19)
        Label6.Name = "Label6"
        Label6.Size = New Size(75, 20)
        Label6.TabIndex = 6
        Label6.Text = "N° Tickets"
        ' 
        ' txtCodigoComprobante
        ' 
        txtCodigoComprobante.Enabled = False
        txtCodigoComprobante.Location = New Point(96, 16)
        txtCodigoComprobante.Name = "txtCodigoComprobante"
        txtCodigoComprobante.Size = New Size(163, 27)
        txtCodigoComprobante.TabIndex = 5
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(96, 85)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(163, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 85)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 1
        Label5.Text = "Hora:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(17, 52)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 0
        Label4.Text = "Fecha:"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(cmbDniCliente)
        Panel4.Controls.Add(cmbTipoComprobante)
        Panel4.Controls.Add(Label13)
        Panel4.Controls.Add(txtIDUsuario)
        Panel4.Controls.Add(txtIDVenta)
        Panel4.Controls.Add(btnBuscarCliente)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(txtNombreCliente)
        Panel4.Controls.Add(Label9)
        Panel4.Location = New Point(12, 168)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(671, 150)
        Panel4.TabIndex = 8
        ' 
        ' cmbDniCliente
        ' 
        cmbDniCliente.FormattingEnabled = True
        cmbDniCliente.Location = New Point(98, 14)
        cmbDniCliente.Name = "cmbDniCliente"
        cmbDniCliente.Size = New Size(151, 28)
        cmbDniCliente.TabIndex = 12
        ' 
        ' cmbTipoComprobante
        ' 
        cmbTipoComprobante.FormattingEnabled = True
        cmbTipoComprobante.Location = New Point(182, 99)
        cmbTipoComprobante.Name = "cmbTipoComprobante"
        cmbTipoComprobante.Size = New Size(166, 28)
        cmbTipoComprobante.TabIndex = 11
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(17, 102)
        Label13.Name = "Label13"
        Label13.Size = New Size(159, 20)
        Label13.TabIndex = 10
        Label13.Text = "Tipo de Comprobante:"
        ' 
        ' txtIDUsuario
        ' 
        txtIDUsuario.Location = New Point(436, 82)
        txtIDUsuario.Name = "txtIDUsuario"
        txtIDUsuario.Size = New Size(125, 27)
        txtIDUsuario.TabIndex = 9
        ' 
        ' txtIDVenta
        ' 
        txtIDVenta.Location = New Point(436, 19)
        txtIDVenta.Name = "txtIDVenta"
        txtIDVenta.Size = New Size(125, 27)
        txtIDVenta.TabIndex = 8
        ' 
        ' btnBuscarCliente
        ' 
        btnBuscarCliente.Location = New Point(254, 14)
        btnBuscarCliente.Name = "btnBuscarCliente"
        btnBuscarCliente.Size = New Size(94, 29)
        btnBuscarCliente.TabIndex = 7
        btnBuscarCliente.Text = "BUSCAR"
        btnBuscarCliente.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(17, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 20)
        Label7.TabIndex = 6
        Label7.Text = "DNI: "
        ' 
        ' txtNombreCliente
        ' 
        txtNombreCliente.Enabled = False
        txtNombreCliente.Location = New Point(98, 49)
        txtNombreCliente.Name = "txtNombreCliente"
        txtNombreCliente.Size = New Size(250, 27)
        txtNombreCliente.TabIndex = 4
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(17, 52)
        Label9.Name = "Label9"
        Label9.Size = New Size(71, 20)
        Label9.TabIndex = 0
        Label9.Text = "Nombre: "
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Label10)
        Panel6.Controls.Add(TextBox6)
        Panel6.Controls.Add(TextBox7)
        Panel6.Controls.Add(TextBox8)
        Panel6.Controls.Add(Label11)
        Panel6.Controls.Add(Label12)
        Panel6.Location = New Point(708, 512)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(464, 128)
        Panel6.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(17, 19)
        Label10.Name = "Label10"
        Label10.Size = New Size(70, 20)
        Label10.TabIndex = 6
        Label10.Text = "SubTotal:"
        ' 
        ' TextBox6
        ' 
        TextBox6.Enabled = False
        TextBox6.Location = New Point(98, 16)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(125, 27)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox7
        ' 
        TextBox7.Enabled = False
        TextBox7.Location = New Point(98, 49)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(125, 27)
        TextBox7.TabIndex = 4
        ' 
        ' TextBox8
        ' 
        TextBox8.Enabled = False
        TextBox8.Location = New Point(98, 82)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(125, 27)
        TextBox8.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(17, 85)
        Label11.Name = "Label11"
        Label11.Size = New Size(45, 20)
        Label11.TabIndex = 1
        Label11.Text = "Total:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(17, 52)
        Label12.Name = "Label12"
        Label12.Size = New Size(68, 20)
        Label12.TabIndex = 0
        Label12.Text = "IGV  18%"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(dgvProductos)
        GroupBox2.Controls.Add(cmbCategoria)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Location = New Point(12, 334)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(665, 306)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "BUSCAR PRODUCTO"
        ' 
        ' dgvProductos
        ' 
        dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProductos.Location = New Point(16, 101)
        dgvProductos.Name = "dgvProductos"
        dgvProductos.RowHeadersWidth = 51
        dgvProductos.RowTemplate.Height = 29
        dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvProductos.Size = New Size(626, 188)
        dgvProductos.TabIndex = 2
        ' 
        ' cmbCategoria
        ' 
        cmbCategoria.FormattingEnabled = True
        cmbCategoria.Location = New Point(145, 47)
        cmbCategoria.Name = "cmbCategoria"
        cmbCategoria.Size = New Size(247, 28)
        cmbCategoria.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(39, 50)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 20)
        Label8.TabIndex = 0
        Label8.Text = "Categoria:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label14)
        GroupBox1.Controls.Add(ListView1)
        GroupBox1.Location = New Point(708, 267)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(464, 229)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Detalle de Facturación"
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(9, 91)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(445, 117)
        ListView1.TabIndex = 0
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel5
        ' 
        Panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel5.BackgroundImage = CType(resources.GetObject("Panel5.BackgroundImage"), Image)
        Panel5.BackgroundImageLayout = ImageLayout.Stretch
        Panel5.CausesValidation = False
        Panel5.Location = New Point(707, 12)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(465, 249)
        Panel5.TabIndex = 13
        ' 
        ' btnRegistrar
        ' 
        btnRegistrar.AccessibleRole = AccessibleRole.ProgressBar
        btnRegistrar.BackColor = Color.Blue
        btnRegistrar.FlatAppearance.BorderSize = 0
        btnRegistrar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRegistrar.ForeColor = SystemColors.HighlightText
        btnRegistrar.Location = New Point(84, 659)
        btnRegistrar.Name = "btnRegistrar"
        btnRegistrar.Size = New Size(157, 45)
        btnRegistrar.TabIndex = 14
        btnRegistrar.Text = "REGISTRAR"
        btnRegistrar.UseVisualStyleBackColor = False
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(20, 31)
        Label14.Name = "Label14"
        Label14.Size = New Size(72, 20)
        Label14.TabIndex = 13
        Label14.Text = "Cantidad:"
        ' 
        ' frmGestionarVenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1184, 716)
        Controls.Add(btnRegistrar)
        Controls.Add(Panel5)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(Panel6)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmGestionarVenta"
        Text = ".:Gestionar Venta:."
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(dgvProductos, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodigoComprobante As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtIDUsuario As TextBox
    Friend WithEvents txtIDVenta As TextBox
    Friend WithEvents cmbTipoComprobante As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaVenta As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel5 As Panel
    Friend WithEvents cmbDniCliente As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Label14 As Label
End Class
