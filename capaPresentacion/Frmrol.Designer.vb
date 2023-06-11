<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmrol
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
        lsvRol = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        Panel2 = New Panel()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        btnLimpiar = New Button()
        btnSalir = New Button()
        Panel1 = New Panel()
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
        ' lsvRol
        ' 
        lsvRol.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lsvRol.FullRowSelect = True
        lsvRol.GridLines = True
        lsvRol.Location = New Point(11, 239)
        lsvRol.Name = "lsvRol"
        lsvRol.Size = New Size(519, 258)
        lsvRol.TabIndex = 10
        lsvRol.UseCompatibleStateImageBehavior = False
        lsvRol.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "IDRol"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Nombre"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Estado"
        ColumnHeader3.Width = 180
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(btnDarBaja)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(381, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(150, 201)
        Panel2.TabIndex = 6
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.BackColor = Color.WhiteSmoke
        btnDarBaja.Enabled = False
        btnDarBaja.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDarBaja.Location = New Point(17, 150)
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
        btnEliminar.Location = New Point(17, 104)
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
        btnModificar.Location = New Point(17, 58)
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
        btnNuevo.Location = New Point(17, 12)
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
        btnLimpiar.Location = New Point(293, 503)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(116, 40)
        btnLimpiar.TabIndex = 7
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.WhiteSmoke
        btnSalir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSalir.Location = New Point(415, 504)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(116, 40)
        btnSalir.TabIndex = 8
        btnSalir.Text = "Salir"
        btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FloralWhite
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(chkVigencia)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(txtNombre)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(363, 201)
        Panel1.TabIndex = 5
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.WhiteSmoke
        btnBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBuscar.Location = New Point(253, 22)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(55, 40)
        btnBuscar.TabIndex = 3
        btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' chkVigencia
        ' 
        chkVigencia.AutoSize = True
        chkVigencia.Location = New Point(148, 108)
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
        Label4.Location = New Point(70, 104)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 21)
        Label4.TabIndex = 0
        Label4.Text = "VIgencia:"
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
        Label1.Location = New Point(115, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(26, 21)
        Label1.TabIndex = 0
        Label1.Text = "id:"
        ' 
        ' Frmrol
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 555)
        Controls.Add(lsvRol)
        Controls.Add(Panel2)
        Controls.Add(btnLimpiar)
        Controls.Add(btnSalir)
        Controls.Add(Panel1)
        Name = "Frmrol"
        Text = "Frmrol"
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lsvRol As ListView
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
End Class
