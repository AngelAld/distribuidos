<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        lsvProveedor = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Panel2 = New Panel()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        Panel1 = New Panel()
        txtTelefono = New TextBox()
        Label5 = New Label()
        txtRuc = New TextBox()
        Label3 = New Label()
        btnBuscar = New Button()
        chkVigencia = New CheckBox()
        Label4 = New Label()
        txtNombre = New TextBox()
        Label2 = New Label()
        txtId = New TextBox()
        Label1 = New Label()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lsvProveedor
        ' 
        lsvProveedor.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        lsvProveedor.FullRowSelect = True
        lsvProveedor.GridLines = True
        lsvProveedor.Location = New Point(13, 241)
        lsvProveedor.Name = "lsvProveedor"
        lsvProveedor.Size = New Size(519, 258)
        lsvProveedor.TabIndex = 15
        lsvProveedor.UseCompatibleStateImageBehavior = False
        lsvProveedor.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 30
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nombre"
        ColumnHeader2.Width = 190
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Ruc"
        ColumnHeader3.Width = 180
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Telefono"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Estado"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(btnDarBaja)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(382, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(150, 223)
        Panel2.TabIndex = 12
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.BackColor = Color.WhiteSmoke
        btnDarBaja.Enabled = False
        btnDarBaja.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDarBaja.Location = New Point(17, 169)
        btnDarBaja.Name = "btnDarBaja"
        btnDarBaja.Size = New Size(116, 40)
        btnDarBaja.TabIndex = 2
        btnDarBaja.Text = "Dar Baja"
        btnDarBaja.TextImageRelation = TextImageRelation.ImageBeforeText
        btnDarBaja.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.WhiteSmoke
        btnEliminar.Enabled = False
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnEliminar.Location = New Point(17, 120)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(116, 40)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "Eliminar"
        btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.WhiteSmoke
        btnModificar.Enabled = False
        btnModificar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnModificar.Location = New Point(17, 61)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(116, 40)
        btnModificar.TabIndex = 2
        btnModificar.Text = "Modificar"
        btnModificar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnNuevo
        ' 
        btnNuevo.BackColor = Color.WhiteSmoke
        btnNuevo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnNuevo.Location = New Point(17, 14)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(116, 40)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "Nuevo"
        btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.WhiteSmoke
        btnLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpiar.Location = New Point(294, 527)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(116, 40)
        btnLimpiar.TabIndex = 13
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.WhiteSmoke
        btnSalir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSalir.Location = New Point(416, 527)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(116, 40)
        btnSalir.TabIndex = 14
        btnSalir.Text = "Salir"
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FloralWhite
        Panel1.Controls.Add(txtTelefono)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(txtRuc)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(chkVigencia)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(13, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 223)
        Panel1.TabIndex = 11
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(147, 137)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(161, 23)
        txtTelefono.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(70, 139)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 21)
        Label5.TabIndex = 7
        Label5.Text = "Telefono:"
        ' 
        ' txtRuc
        ' 
        txtRuc.Location = New Point(147, 102)
        txtRuc.Name = "txtRuc"
        txtRuc.Size = New Size(161, 23)
        txtRuc.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(97, 104)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 21)
        Label3.TabIndex = 4
        Label3.Text = "RUC:"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.WhiteSmoke
        btnBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBuscar.Location = New Point(253, 33)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(55, 23)
        btnBuscar.TabIndex = 3
        btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' chkVigencia
        ' 
        chkVigencia.AutoSize = True
        chkVigencia.Location = New Point(147, 173)
        chkVigencia.Name = "chkVigencia"
        chkVigencia.Size = New Size(74, 19)
        chkVigencia.TabIndex = 2
        chkVigencia.Text = "(Vigente)"
        chkVigencia.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(69, 169)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 0
        Label4.Text = "Vigencia:"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(147, 68)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(161, 23)
        txtNombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(70, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 21)
        Label2.TabIndex = 0
        Label2.Text = "Nombre:"
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(147, 33)
        txtId.Name = "txtId"
        txtId.Size = New Size(100, 23)
        txtId.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(115, 33)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 21)
        Label1.TabIndex = 0
        Label1.Text = "Id:"
        ' 
        ' frmProveedor
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(552, 579)
        Controls.Add(lsvProveedor)
        Controls.Add(Panel2)
        Controls.Add(btnLimpiar)
        Controls.Add(btnSalir)
        Controls.Add(Panel1)
        Name = "frmProveedor"
        Text = "Proveedor"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lsvProveedor As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents chkVigencia As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRuc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
End Class
