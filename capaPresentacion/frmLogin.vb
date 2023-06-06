Imports System.ComponentModel
Imports capaNegocio
Public Class frmLogin
    Dim objUsuario As New clsUsuario
    Public usu As String = ""
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If txtUsuario.TextLength > 0 And txtContraseña.TextLength > 0 Then
                If objUsuario.validarVigencia(txtUsuario.Text) Then
                    usu = objUsuario.validarUsuario(txtUsuario.Text, txtContraseña.Text)
                    If usu = "" Then
                        MessageBox.Show("Datos incorrectos, intente nuevamente!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiarControles()
                        txtUsuario.Focus()
                    Else
                        MessageBox.Show("Bienvenido(a) " & usu & " al Sistema FARMACIA!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()
                        Dim objPrincipal As New MDIPrincipal
                        objPrincipal.Show()
                        limpiarControles()
                    End If
                Else
                    MessageBox.Show("Usuario no está o no existe!", "SISTEMA FARMACIA", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub limpiarControles()
        txtUsuario.Clear()
        txtContraseña.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        End
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmLogin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtUsuario.Focus()
    End Sub


End Class