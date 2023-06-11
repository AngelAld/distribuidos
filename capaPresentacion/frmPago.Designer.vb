<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPago
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
        tblRealizarPago = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        btnRealizarPago = New Button()
        SuspendLayout()
        ' 
        ' tblRealizarPago
        ' 
        tblRealizarPago.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader4, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        tblRealizarPago.FullRowSelect = True
        tblRealizarPago.GridLines = True
        tblRealizarPago.Location = New Point(12, 35)
        tblRealizarPago.Margin = New Padding(3, 2, 3, 2)
        tblRealizarPago.Name = "tblRealizarPago"
        tblRealizarPago.Size = New Size(705, 172)
        tblRealizarPago.TabIndex = 17
        tblRealizarPago.UseCompatibleStateImageBehavior = False
        tblRealizarPago.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "CLIENTE"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "USUARIO"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "TIPO_COMPROBANTE"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "FECHA"
        ColumnHeader7.Width = 100
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.Text = "CODIGO_COMPROBANTE"
        ColumnHeader8.Width = 100
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.Text = "ESTADO"
        ColumnHeader9.Width = 100
        ' 
        ' btnRealizarPago
        ' 
        btnRealizarPago.AccessibleRole = AccessibleRole.ProgressBar
        btnRealizarPago.BackColor = Color.Blue
        btnRealizarPago.FlatAppearance.BorderSize = 0
        btnRealizarPago.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnRealizarPago.ForeColor = SystemColors.HighlightText
        btnRealizarPago.Location = New Point(12, 237)
        btnRealizarPago.Margin = New Padding(3, 2, 3, 2)
        btnRealizarPago.Name = "btnRealizarPago"
        btnRealizarPago.Size = New Size(203, 34)
        btnRealizarPago.TabIndex = 42
        btnRealizarPago.Text = "REALIZAR PAGO"
        btnRealizarPago.UseVisualStyleBackColor = False
        ' 
        ' frmPago
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 282)
        Controls.Add(btnRealizarPago)
        Controls.Add(tblRealizarPago)
        Name = "frmPago"
        Text = "frmPago"
        ResumeLayout(False)
    End Sub

    Friend WithEvents tblRealizarPago As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents btnRealizarPago As Button
End Class
