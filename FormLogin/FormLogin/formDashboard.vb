Public Class formDashboard
    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        formLogin.Show()
    End Sub
End Class