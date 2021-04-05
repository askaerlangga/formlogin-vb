Imports System.Data.Odbc
Public Class formLogin
    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.ForeColor = Color.Black
            txtPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.ForeColor = Color.Silver
            txtPassword.PasswordChar = ""
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        bukaKoneksi()
        Dim STR As String
        STR = "SELECT * FROM tbl_user where username_user = '" & txtUsername.Text & "' and password_user = '" & txtPassword.Text & "'"
        CMD = New OdbcCommand(STR, CONN)
        DR = CMD.ExecuteReader
        If DR.HasRows Then
            If DR("level_user").ToString = "admin" Then
                'Perintah untuk akun level admin
            Else
                'Perintah untuk akun level user
            End If
            MessageBox.Show("Login berhasil! Halo " + DR("username_user").ToString)
            Me.Hide()
            formDashboard.Show()
        Else
            MessageBox.Show("Login Gagal, Username atau Password anda Salah!")
        End If
        tutupKoneksi()
    End Sub

    Private Sub lblLupaPassword_Click(sender As Object, e As EventArgs) Handles lblLupaPassword.Click
        'Isi perintah lupa pasword
    End Sub
End Class