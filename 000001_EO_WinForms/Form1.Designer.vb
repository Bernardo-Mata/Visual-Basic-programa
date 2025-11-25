<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 200)
        Text = "Login"
        StartPosition = FormStartPosition.CenterScreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False

        ' Labels
        lblUser = New Label()
        lblUser.Text = "Usuario:"
        lblUser.Location = New Point(50, 40)
        lblUser.Size = New Size(70, 20)
        Me.Controls.Add(lblUser)

        lblPassword = New Label()
        lblPassword.Text = "Contraseña:"
        lblPassword.Location = New Point(50, 80)
        lblPassword.Size = New Size(80, 20)
        Me.Controls.Add(lblPassword)

        ' TextBoxes
        txtUser = New TextBox()
        txtUser.Location = New Point(140, 37)
        txtUser.Size = New Size(180, 25)
        Me.Controls.Add(txtUser)

        txtPassword = New TextBox()
        txtPassword.Location = New Point(140, 77)
        txtPassword.Size = New Size(180, 25)
        txtPassword.PasswordChar = "*"c
        Me.Controls.Add(txtPassword)

        ' Login Button
        btnLogin = New Button()
        btnLogin.Text = "Ingresar"
        btnLogin.Location = New Point(140, 120)
        btnLogin.Size = New Size(100, 30)
        Me.Controls.Add(btnLogin)
    End Sub

    ' Control declarations
    Private WithEvents lblUser As Label
    Private WithEvents lblPassword As Label
    Private WithEvents txtUser As TextBox
    Private WithEvents txtPassword As TextBox
    Private WithEvents btnLogin As Button

End Class
