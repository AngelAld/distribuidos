<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmcompra
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
        dtpFecha = New DateTimePicker()
        Panel1 = New Panel()
        txtproveedor = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        chkEstado = New CheckBox()
        btnBuscar = New Button()
        txtDescripcion = New TextBox()
        txtId = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Panel2 = New Panel()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnNuevo = New Button()
        lsvcompra = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtpFecha
        ' 
        dtpFecha.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        dtpFecha.Format = DateTimePickerFormat.Short
        dtpFecha.Location = New Point(113, 130)
        dtpFecha.Margin = New Padding(3, 2, 3, 2)
        dtpFecha.Name = "dtpFecha"
        dtpFecha.Size = New Size(136, 23)
        dtpFecha.TabIndex = 37
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(txtproveedor)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(chkEstado)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtDescripcion)
        Panel1.Controls.Add(txtId)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(dtpFecha)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(12, 11)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(334, 192)
        Panel1.TabIndex = 42
        ' 
        ' txtproveedor
        ' 
        txtproveedor.Location = New Point(113, 55)
        txtproveedor.Margin = New Padding(3, 2, 3, 2)
        txtproveedor.Name = "txtproveedor"
        txtproveedor.Size = New Size(197, 23)
        txtproveedor.TabIndex = 40
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(20, 55)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 15)
        Label6.TabIndex = 39
        Label6.Text = "proveedor: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(20, 138)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 38
        Label5.Text = "Fecha:"
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Location = New Point(113, 108)
        chkEstado.Margin = New Padding(3, 2, 3, 2)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(60, 19)
        chkEstado.TabIndex = 7
        chkEstado.Text = "Activo"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(228, 22)
        btnBuscar.Margin = New Padding(3, 2, 3, 2)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(82, 22)
        btnBuscar.TabIndex = 6
        btnBuscar.Text = "BUSCAR"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(113, 83)
        txtDescripcion.Margin = New Padding(3, 2, 3, 2)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(197, 23)
        txtDescripcion.TabIndex = 4
        ' 
        ' txtId
        ' 
        txtId.Location = New Point(113, 24)
        txtId.Margin = New Padding(3, 2, 3, 2)
        txtId.Name = "txtId"
        txtId.Size = New Size(110, 23)
        txtId.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(20, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 2
        Label1.Text = "Estado: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(20, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 1
        Label2.Text = "Descripción: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(20, 26)
        Label4.Name = "Label4"
        Label4.Size = New Size(24, 15)
        Label4.TabIndex = 0
        Label4.Text = "ID: "
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(btnDarBaja)
        Panel2.Controls.Add(btnEliminar)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnNuevo)
        Panel2.Location = New Point(370, 11)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(219, 192)
        Panel2.TabIndex = 43
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.Location = New Point(18, 153)
        btnDarBaja.Margin = New Padding(3, 2, 3, 2)
        btnDarBaja.Name = "btnDarBaja"
        btnDarBaja.Size = New Size(186, 22)
        btnDarBaja.TabIndex = 3
        btnDarBaja.Text = "DAR BAJA"
        btnDarBaja.UseVisualStyleBackColor = True
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(18, 108)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(186, 22)
        btnEliminar.TabIndex = 2
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.TextAlign = ContentAlignment.BottomCenter
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnModificar
        ' 
        btnModificar.Location = New Point(18, 64)
        btnModificar.Margin = New Padding(3, 2, 3, 2)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(186, 22)
        btnModificar.TabIndex = 1
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = True
        ' 
        ' btnNuevo
        ' 
        btnNuevo.Location = New Point(18, 20)
        btnNuevo.Margin = New Padding(3, 2, 3, 2)
        btnNuevo.Name = "btnNuevo"
        btnNuevo.Size = New Size(186, 22)
        btnNuevo.TabIndex = 0
        btnNuevo.Text = "NUEVO"
        btnNuevo.UseVisualStyleBackColor = True
        ' 
        ' lsvcompra
        ' 
        lsvcompra.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5})
        lsvcompra.FullRowSelect = True
        lsvcompra.GridLines = True
        lsvcompra.Location = New Point(12, 229)
        lsvcompra.Margin = New Padding(3, 2, 3, 2)
        lsvcompra.Name = "lsvcompra"
        lsvcompra.Size = New Size(577, 249)
        lsvcompra.TabIndex = 44
        lsvcompra.UseCompatibleStateImageBehavior = False
        lsvcompra.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 50
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Proveedor"
        ColumnHeader2.Width = 150
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Descripción"
        ColumnHeader3.Width = 150
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Estado"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Fecha"
        ColumnHeader5.Width = 100
        ' 
        ' frmcompra
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(602, 489)
        Controls.Add(lsvcompra)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "frmcompra"
        Text = "frmcompra"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lsvcompra As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents txtproveedor As TextBox
End Class
