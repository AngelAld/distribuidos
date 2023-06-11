<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Panel1 = New Panel()
        txtContraseña = New TextBox()
        Label2 = New Label()
        txtUsuario = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        btnCancelar = New Button()
        btnAceptar = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FloralWhite
        Panel1.Controls.Add(txtContraseña)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(txtUsuario)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(13, 151)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(268, 86)
        Panel1.TabIndex = 0
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(114, 45)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(124, 23)
        txtContraseña.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(16, 43)
        Label2.Name = "Label2"
        Label2.Size = New Size(92, 21)
        Label2.TabIndex = 0
        Label2.Text = "Contraseña:"
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(114, 11)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(124, 23)
        txtUsuario.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(41, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 21)
        Label1.TabIndex = 0
        Label1.Text = "Usuario:"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(btnCancelar)
        Panel2.Controls.Add(btnAceptar)
        Panel2.Controls.Add(Button1)
        Panel2.Location = New Point(13, 243)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(268, 64)
        Panel2.TabIndex = 0
        ' 
        ' btnCancelar
        ' 
        btnCancelar.BackColor = Color.WhiteSmoke
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), Image)
        btnCancelar.Location = New Point(138, 12)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(116, 40)
        btnCancelar.TabIndex = 4
        btnCancelar.Text = "Cancelar"
        btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnCancelar.UseVisualStyleBackColor = False
        ' 
        ' btnAceptar
        ' 
        btnAceptar.BackColor = Color.WhiteSmoke
        btnAceptar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), Image)
        btnAceptar.Location = New Point(16, 12)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(116, 40)
        btnAceptar.TabIndex = 3
        btnAceptar.Text = "Aceptar"
        btnAceptar.TextImageRelation = TextImageRelation.ImageBeforeText
        btnAceptar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(41, 222)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(75, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(132, 133)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' frmLogin
        ' 
        AcceptButton = btnAceptar
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancelar
        ClientSize = New Size(293, 321)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmLogin"
        StartPosition = FormStartPosition.CenterParent
        Text = ".: INICIO DE SESIÓN :."
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
