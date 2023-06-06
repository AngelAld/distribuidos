<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarUnidadMedida
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
        btnBuscar = New Button()
        txtDescripcion = New TextBox()
        txtId = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        lsvUniMedida = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        btnLimpiar = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtDescripcion)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(29, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(377, 123)
        Panel1.TabIndex = 0
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(252, 27)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(94, 29)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(133, 69)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(213, 27)
        txtDescripcion.TabIndex = 5
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(133, 27)
        txtId.Name = "txtId"
        txtId.Size = New Size(104, 27)
        txtId.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 20)
        Label2.TabIndex = 3
        Label2.Text = "Descripción: "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 20)
        Label1.TabIndex = 2
        Label1.Text = "ID Categoria: "
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(426, 24)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(192, 123)
        Panel2.TabIndex = 1
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(13, 88)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(165, 29)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(13, 51)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(165, 29)
        btnModificar.TabIndex = 1
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(13, 13)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(165, 29)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "NUEVO"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lsvUniMedida
        ' 
        lsvUniMedida.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2})
        lsvUniMedida.FullRowSelect = True
        lsvUniMedida.GridLines = True
        lsvUniMedida.Location = New Point(29, 153)
        lsvUniMedida.Name = "lsvUniMedida"
        lsvUniMedida.Size = New Size(589, 252)
        lsvUniMedida.TabIndex = 2
        lsvUniMedida.UseCompatibleStateImageBehavior = False
        lsvUniMedida.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID Categoria"
        ColumnHeader1.Width = 290
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Descripcion"
        ColumnHeader2.Width = 300
        ' 
        ' btnLimpiar
        ' 
        btnLimpiar.Location = New Point(510, 428)
        btnLimpiar.Name = "btnLimpiar"
        btnLimpiar.Size = New Size(94, 29)
        btnLimpiar.TabIndex = 3
        btnLimpiar.Text = "LIMPIAR"
        btnLimpiar.UseVisualStyleBackColor = True
        ' 
        ' frmGestionarUnidadMedida
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(636, 472)
        Controls.Add(btnLimpiar)
        Controls.Add(lsvUniMedida)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmGestionarUnidadMedida"
        Text = "Gestionar Unidad Medida"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents lsvUniMedida As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnLimpiar As Button
End Class
