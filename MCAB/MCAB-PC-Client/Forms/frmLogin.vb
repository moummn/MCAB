Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            pbLogo.Image = Image.FromFile(".\Resources\Logo.PNG")
        Catch ex As Exception

        End Try

        tbUserName.Text = My.Settings.Login_UserName
        cbRemember.Checked = My.Settings.Login_Remember
        If My.Settings.Login_Remember = True Then
            tbPassword.Text = My.Settings.Login_Password
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        My.Settings.Login_UserName = tbUserName.Text
        My.Settings.Login_Remember = cbRemember.Checked
        If My.Settings.Login_Remember = True Then
            My.Settings.Login_Password = tbPassword.Text
        Else
            My.Settings.Login_Password = ""
        End If
    End Sub

    Private Sub btnMore_Click(sender As Object, e As EventArgs) Handles btnMore.Click
        frmDBSettings.ShowDialog(Me)
    End Sub
End Class
