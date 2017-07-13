Imports System.ComponentModel

Public Class frmDBSettings
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        My.Settings.DB_Server = tbServer.Text
        My.Settings.DB_Database = tbDatabase.Text
        My.Settings.DB_User = tbUser.Text
        My.Settings.DB_Password = tbPassword.Text
    End Sub
    Private Sub frmDBSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbServer.Text = My.Settings.DB_Server
        tbDatabase.Text = My.Settings.DB_Database
        tbUser.Text = My.Settings.DB_User
        tbPassword.Text = My.Settings.DB_Password
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click

    End Sub

    Private Sub frmDBSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sender.Activecontrol.Name = "btnTest" Then
            e.Cancel = True
        End If
    End Sub
End Class