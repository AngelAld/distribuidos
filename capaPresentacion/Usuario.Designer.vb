<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuario
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Usuario))
        btnLimpiar = New Button()
        btnSalir = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        txtid = New TextBox()
        txtclave = New TextBox()
        txtusuario = New TextBox()
        txtcorreo = New TextBox()
        txtnombre = New TextBox()
        chkVigencia = New CheckBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        cmbrol = New ComboBox()
        btnBuscar = New Button()
        Panel2 = New Panel()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        lvlusuario = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        ColumnHeader10 = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.BackColor = Color.WhiteSmoke
        btnLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), Image)
        btnLimpiar.Location = New Point(182, 510)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(116, 40)
        btnLimpiar.TabIndex = 9
        btnLimpiar.Text = "Limpiar"
        btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnLimpiar.UseVisualStyleBackColor = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.WhiteSmoke
        btnSalir.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), Image)
        btnSalir.Location = New Point(329, 509)
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
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(txtid)
        Panel1.Controls.Add(txtclave)
        Panel1.Controls.Add(txtusuario)
        Panel1.Controls.Add(txtcorreo)
        Panel1.Controls.Add(txtnombre)
        Panel1.Controls.Add(chkVigencia)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cmbrol)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Location = New Point(21, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 247)
        Panel1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 208)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 15)
        Label1.TabIndex = 18
        Label1.Text = "Estado:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(44, 48)
        Label8.Name = "Label8"
        Label8.Size = New Size(27, 15)
        Label8.TabIndex = 17
        Label8.Text = "Rol:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(48, 20)
        Label7.Name = "Label7"
        Label7.Size = New Size(21, 15)
        Label7.TabIndex = 16
        Label7.Text = "ID:"
        ' 
        ' txtid
        ' 
        txtid.Location = New Point(75, 12)
        txtid.Name = "txtid"
        txtid.Size = New Size(100, 23)
        txtid.TabIndex = 15
        ' 
        ' txtclave
        ' 
        txtclave.Location = New Point(75, 149)
        txtclave.Name = "txtclave"
        txtclave.Size = New Size(157, 23)
        txtclave.TabIndex = 14
        txtclave.UseSystemPasswordChar = True
        ' 
        ' txtusuario
        ' 
        txtusuario.Location = New Point(75, 114)
        txtusuario.Name = "txtusuario"
        txtusuario.Size = New Size(157, 23)
        txtusuario.TabIndex = 13
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Location = New Point(75, 178)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(157, 23)
        txtcorreo.TabIndex = 13
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(75, 81)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(157, 23)
        txtnombre.TabIndex = 11
        ' 
        ' chkVigencia
        ' 
        chkVigencia.AutoSize = True
        chkVigencia.Location = New Point(79, 207)
        chkVigencia.Name = "chkVigencia"
        chkVigencia.Size = New Size(74, 19)
        chkVigencia.TabIndex = 10
        chkVigencia.Text = "(Vigente)"
        chkVigencia.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 181)
        Label5.Name = "Label5"
        Label5.Size = New Size(46, 15)
        Label5.TabIndex = 8
        Label5.Text = "Correo:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 149)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 15)
        Label4.TabIndex = 7
        Label4.Text = "Clave:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 117)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 6
        Label3.Text = "Usuario:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(10, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 5
        Label2.Text = "Nombres:"
        ' 
        ' cmbrol
        ' 
        cmbrol.FormattingEnabled = True
        cmbrol.Location = New Point(75, 45)
        cmbrol.Name = "cmbrol"
        cmbrol.Size = New Size(157, 23)
        cmbrol.TabIndex = 4
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.WhiteSmoke
        btnBuscar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(181, 3)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(55, 40)
        btnBuscar.TabIndex = 3
        btnBuscar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.Controls.Add(btnDarBaja)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(287, 12)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(158, 247)
        Panel2.TabIndex = 15
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.BackColor = Color.WhiteSmoke
        btnDarBaja.Enabled = False
        btnDarBaja.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnDarBaja.Image = CType(resources.GetObject("btnDarBaja.Image"), Image)
        btnDarBaja.Location = New Point(17, 186)
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
        btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), Image)
        btnEliminar.Location = New Point(17, 124)
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
        btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), Image)
        btnModificar.Location = New Point(17, 69)
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
        btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), Image)
        btnNuevo.Location = New Point(17, 12)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(116, 40)
        btnNuevo.TabIndex = 2
        btnNuevo.Text = "Nuevo"
        btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText
        btnNuevo.UseVisualStyleBackColor = False
        ' 
        ' lvlusuario
        ' 
        lvlusuario.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader8, ColumnHeader9, ColumnHeader10})
        lvlusuario.FullRowSelect = True
        lvlusuario.GridLines = True
        lvlusuario.Location = New Point(21, 265)
        lvlusuario.Name = "lvlusuario"
        lvlusuario.Size = New Size(424, 238)
        lvlusuario.TabIndex = 16
        lvlusuario.UseCompatibleStateImageBehavior = False
        lvlusuario.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "ROL"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "NOMBRE"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "USUARIO"
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "Clave"
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "Correo"
        ' 
        ' ColumnHeader10
        ' 
        ColumnHeader10.Text = "Estado"
        ' 
        ' Usuario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(463, 562)
        Controls.Add(lvlusuario)
        Controls.Add(Panel2)
        Controls.Add(btnSalir)
        Controls.Add(Panel1)
        Controls.Add(btnLimpiar)
        Name = "Usuario"
        Text = "Usuario"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmbrol As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents chkVigencia As CheckBox
    Friend WithEvents txtclave As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lvlusuario As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
End Class
