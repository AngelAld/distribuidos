﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionarLaboratorio
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
        btnModificar = New Button()
        btnDarBaja = New Button()
        btnEliminar = New Button()
        btnGuardar = New Button()
        Panel1 = New Panel()
        chkEstado = New CheckBox()
        Label9 = New Label()
        txtDescripcion = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtID = New TextBox()
        tblLaboratorio = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnModificar
        ' 
        btnModificar.AccessibleRole = AccessibleRole.ProgressBar
        btnModificar.BackColor = Color.SeaGreen
        btnModificar.FlatAppearance.BorderSize = 0
        btnModificar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnModificar.ForeColor = SystemColors.HighlightText
        btnModificar.Location = New Point(620, 74)
        btnModificar.Margin = New Padding(3, 2, 3, 2)
        btnModificar.Name = "btnModificar"
        btnModificar.Size = New Size(137, 34)
        btnModificar.TabIndex = 14
        btnModificar.Text = "MODIFICAR"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnDarBaja
        ' 
        btnDarBaja.AccessibleRole = AccessibleRole.ProgressBar
        btnDarBaja.BackColor = Color.RosyBrown
        btnDarBaja.FlatAppearance.BorderSize = 0
        btnDarBaja.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDarBaja.ForeColor = SystemColors.HighlightText
        btnDarBaja.Location = New Point(620, 197)
        btnDarBaja.Margin = New Padding(3, 2, 3, 2)
        btnDarBaja.Name = "btnDarBaja"
        btnDarBaja.Size = New Size(137, 34)
        btnDarBaja.TabIndex = 13
        btnDarBaja.Text = "DAR BAJA"
        btnDarBaja.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.AccessibleRole = AccessibleRole.ProgressBar
        btnEliminar.BackColor = Color.Red
        btnEliminar.FlatAppearance.BorderSize = 0
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnEliminar.ForeColor = SystemColors.HighlightText
        btnEliminar.Location = New Point(620, 139)
        btnEliminar.Margin = New Padding(3, 2, 3, 2)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(137, 34)
        btnEliminar.TabIndex = 12
        btnEliminar.Text = "ELIMINAR"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.AccessibleRole = AccessibleRole.ProgressBar
        btnGuardar.BackColor = Color.Blue
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnGuardar.ForeColor = SystemColors.HighlightText
        btnGuardar.Location = New Point(620, 11)
        btnGuardar.Margin = New Padding(3, 2, 3, 2)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(137, 34)
        btnGuardar.TabIndex = 11
        btnGuardar.Text = "NUEVO"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(txtID)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(txtDescripcion)
        Panel1.Controls.Add(chkEstado)
        Panel1.Controls.Add(Label9)
        Panel1.Location = New Point(12, 11)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(544, 220)
        Panel1.TabIndex = 15
        ' 
        ' chkEstado
        ' 
        chkEstado.AutoSize = True
        chkEstado.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        chkEstado.Location = New Point(164, 139)
        chkEstado.Margin = New Padding(3, 2, 3, 2)
        chkEstado.Name = "chkEstado"
        chkEstado.Size = New Size(72, 25)
        chkEstado.TabIndex = 37
        chkEstado.Text = "Activo"
        chkEstado.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(57, 142)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 20)
        Label9.TabIndex = 32
        Label9.Text = "ESTADO"
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.BorderStyle = BorderStyle.FixedSingle
        txtDescripcion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtDescripcion.Location = New Point(164, 88)
        txtDescripcion.Margin = New Padding(3, 2, 3, 2)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(294, 29)
        txtDescripcion.TabIndex = 38
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(57, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 20)
        Label1.TabIndex = 39
        Label1.Text = "NOMBRE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(57, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(24, 20)
        Label2.TabIndex = 40
        Label2.Text = "ID"
        ' 
        ' txtID
        ' 
        txtID.BorderStyle = BorderStyle.FixedSingle
        txtID.Enabled = False
        txtID.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        txtID.Location = New Point(164, 38)
        txtID.Margin = New Padding(3, 2, 3, 2)
        txtID.Name = "txtID"
        txtID.Size = New Size(86, 29)
        txtID.TabIndex = 41
        ' 
        ' tblLaboratorio
        ' 
        tblLaboratorio.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        tblLaboratorio.FullRowSelect = True
        tblLaboratorio.GridLines = True
        tblLaboratorio.Location = New Point(12, 256)
        tblLaboratorio.Margin = New Padding(3, 2, 3, 2)
        tblLaboratorio.Name = "tblLaboratorio"
        tblLaboratorio.Size = New Size(755, 172)
        tblLaboratorio.TabIndex = 16
        tblLaboratorio.UseCompatibleStateImageBehavior = False
        tblLaboratorio.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 250
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "NOMBRE"
        ColumnHeader2.Width = 250
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "ESTADO"
        ColumnHeader3.Width = 250
        ' 
        ' frmGestionarLaboratorio
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tblLaboratorio)
        Controls.Add(Panel1)
        Controls.Add(btnModificar)
        Controls.Add(btnDarBaja)
        Controls.Add(btnEliminar)
        Controls.Add(btnGuardar)
        Name = "frmGestionarLaboratorio"
        Text = "frmGestionarLaboratorio"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnModificar As Button
    Friend WithEvents btnDarBaja As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkEstado As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents tblLaboratorio As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
End Class
