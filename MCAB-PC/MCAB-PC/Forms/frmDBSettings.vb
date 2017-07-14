Imports System.ComponentModel

Public Class frmDBSettings

    ''' <summary>
    ''' <para>作为对话窗体时，每次点击按钮都会关闭当前对话窗体，为了避免这个现象，
    ''' 设置一个CloseCancel变量来解决这个问题</para> 
    ''' <para>True - 避免本次关闭；
    ''' False - 正常关闭</para>
    ''' </summary>
    Dim CloseCancel As Boolean = False
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
        sender.Enabled = False

        Dim sqlConnection1 As SqlClient.SqlConnection
        Dim strConnect As String = ”data source=" & tbServer.Text & ";initial catalog=" &
            tbDatabase.Text & ";user id=" & tbUser.Text & ";password=" & tbPassword.Text & ";”
        sqlConnection1 = New System.Data.SqlClient.SqlConnection(strConnect)
        Try
            sqlConnection1.Open()              '打开数据库
            sqlConnection1.Close()              '关闭连接，释放资源
            MsgBox("测试通过!")
        Catch ex As Exception

            MsgBox(ex.Message)


        End Try

        sender.Enabled = True
        sender.Focus()
        CloseCancel = True

    End Sub

    Private Sub frmDBSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If CloseCancel = True Then
            e.Cancel = True
            CloseCancel = False
        End If
    End Sub
End Class