Public Class Form1

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUser.Text
        Dim pass As String = txtPassword.Text

        If user = "SAM" AndAlso pass = "123" Then
            ' Hide Login form and show MenuPrincipal
            Me.Hide()
            Dim menuForm As New MenuPrincipal()
            menuForm.Show()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class
