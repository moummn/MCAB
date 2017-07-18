Imports System.ComponentModel


Public Class frmDBSettings
    ''' <summary>
    ''' 创建数据库
    ''' </summary>
    ''' <param name="ServerName">服务器实例名</param>
    ''' <param name="DBName">数据库名</param>
    ''' <param name="UserName">登录用户名</param>
    ''' <param name="Password">登录密码</param>
    ''' <param name="ErrString">返回的错误消息</param>
    ''' <returns>返回错误代码</returns>
    Private Function fnCreateDB(ByVal ServerName As String,
                                ByVal DBName As String,
                                ByVal UserName As String,
                                ByVal Password As String,
                                Optional ByRef ErrString As String = "") As Integer
        Dim strConnect As String = "data source=" & ServerName & ";initial catalog=" &
                                   ";user id=" & UserName & ";password=" &
                                   Password & ";”
        Dim sql As String = "CREATE DATABASE [" & tbDatabase.Text & "]"
        Dim sqlConnection1 As SqlClient.SqlConnection =
            New System.Data.SqlClient.SqlConnection(strConnect)
        Try
            sqlConnection1.Open()
            Dim sqlCmd As SqlClient.SqlCommand =
                New SqlClient.SqlCommand(sql, sqlConnection1)
            sqlCmd.ExecuteNonQuery()
            sqlConnection1.Close()
            Return 0
        Catch ex As System.Data.SqlClient.SqlException
            ErrString = ex.ToString
            Try
                sqlConnection1.Close()
            Finally
            End Try
            Return ex.Number
        Catch ex As Exception
            ErrString = ex.ToString
            Try
                sqlConnection1.Close()
            Finally
            End Try
            Return 1
        End Try

    End Function

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
        tbServer.Enabled = False
        tbDatabase.Enabled = False
        tbUser.Enabled = False
        tbPassword.Enabled = False
        Application.DoEvents()

        Dim sqlConnection1 As SqlClient.SqlConnection

        Dim strConnect As String = "data source=" & tbServer.Text & ";initial catalog=" &
             tbDatabase.Text & ";user id=" & tbUser.Text & ";password=" & tbPassword.Text & ";”
        sqlConnection1 = New System.Data.SqlClient.SqlConnection(strConnect)
        Try
            sqlConnection1.Open()              '打开数据库

            MsgBox("测试通过!")
        Catch ex As System.Data.SqlClient.SqlException
            Select Case ex.Number
                Case 53
                    MsgBox("无法连接数据库，请检查服务器否设置正确")
                Case 4060
                    If MsgBox("没有找到名为'" & tbDatabase.Text &
                              "'的数据库，是否立即创建？" & vbCrLf & vbCrLf &
                              "注意,请确认是否存在数据库，该操作也可能清空数据库！",
                               vbYesNo + vbQuestion) = MsgBoxResult.Yes Then
                        Dim ErrNumber As Integer
                        Dim ErrString As String = ""
                        ErrNumber = fnCreateDB(tbServer.Text, tbDatabase.Text,
                                               tbUser.Text, tbPassword.Text,
                                               ErrString)
                        If ErrNumber <> 0 Then
                            MsgBox(ErrString, vbCritical)
                        End If
                    End If

                Case 18456
                    MsgBox("数据库用户名或密码错误！")
                Case Else

            End Select
            'MsgBox(ex.Number)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally

        End Try
        sqlConnection1.Close()              '关闭连接，释放资源

        tbServer.Enabled = True
        tbDatabase.Enabled = True
        tbUser.Enabled = True
        tbPassword.Enabled = True
    End Sub

    Private Sub frmDBSettings_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If sender.Activecontrol.Name = "btnTest" Then
            e.Cancel = True
        End If
    End Sub
End Class