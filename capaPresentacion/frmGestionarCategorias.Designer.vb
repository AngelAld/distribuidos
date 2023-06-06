<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarCategorias
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
        Panel1 = New Panel()
        chkEstado = New CheckBox()
        btnBuscar = New Button()
        txtDescripcion = New TextBox()
        txtId = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        lsvCategorias = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        btnLimpiar = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(chkEstado)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtDescripcion)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(22, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(382, 200)
        Panel1.TabIndex = 0
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(129, 105)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(73, 24)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Activo"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(260, 30)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 29)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(129, 72)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(225, 27)
        txtDescripcion.TabIndex = 4
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(129, 32)
        txtId.Name = "txtId"
        txtId.Size = New Size(125, 27)
        txtId.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 103)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 20)
        Label3.TabIndex = 2
        Label3.Text = "Vigencia: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 1
        Label2.Text = "Descripción: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 0
        Label1.Text = "ID Categoria: "
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnDarBaja)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(410, 19)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 200)
        Panel2.TabIndex = 1
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.Location = New Point(21, 134)
        btnDarBaja.Name = "btnDarBaja"
        btnDarBaja.Size = New Size(212, 29)
        btnDarBaja.TabIndex = 3
        btnDarBaja.Text = "DAR BAJA"
        btnDarBaja.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(21, 99)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(212, 29)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.TextAlign = ContentAlignment.BottomCenter
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(21, 61)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(212, 29)
        btnModificar.TabIndex = 1
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(21, 26)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(212, 29)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "NUEVO"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lsvCategorias
        ' 
        lsvCategorias.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        lsvCategorias.FullRowSelect = True
        lsvCategorias.GridLines = True
        lsvCategorias.Location = New Point(22, 225)
        lsvCategorias.Name = "lsvCategorias"
        lsvCategorias.Size = New Size(638, 188)
        lsvCategorias.TabIndex = 2
        lsvCategorias.UseCompatibleStateImageBehavior = False
        lsvCategorias.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID Categoria"
        ColumnHeader1.Width = 150
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Descripción"
        ColumnHeader2.Width = 350
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Estado"
        ColumnHeader3.Width = 150
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.ImageAlign = ContentAlignment.BottomLeft
        btnLimpiar.Location = New Point(549, 438)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 3
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' frmCategoria
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 479)
        Controls.Add(btnLimpiar)
        Controls.Add(lsvCategorias)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCategoria"
        Text = "Gestionar Categoria"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents lsvCategorias As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnLimpiar As Button
End Class
