Public Class frmProgress
    Public frmParent As Form
    ''' <summary>
    ''' 显示进度条
    ''' </summary>
    ''' <param name="Value">当前进度值</param>
    ''' <param name="MaxValue">最大进度值</param>
    ''' <param name="Title">进度标题</param>
    Private Sub sbProg(ByVal Value As Long, Optional ByRef MaxValue As Long = -1,
                       Optional ByRef Title As String = "")
        Static Dim strTitle As String
        If Title <> "" AndAlso Title <> strTitle Then
            strTitle = Title
        End If
        If MaxValue > 0 Then ProgressBar1.Maximum = MaxValue
        Dim strS As String = strTitle & CStr(Value) & "/" & CStr(ProgressBar1.Maximum)

        Me.Show()
        If Label1.Text <> strS Then Label1.Text = strS
        ProgressBar1.Value = Value

        Application.DoEvents()
    End Sub
    ''' <summary>
    ''' 创建数据库
    ''' </summary>
    ''' <param name="ServerName">服务器实例名</param>
    ''' <param name="DBName">数据库名</param>
    ''' <param name="UserName">登录用户名</param>
    ''' <param name="Password">登录密码</param>
    Public Sub sbCreateDB(ByVal ServerName As String,
                                ByVal DBName As String,
                                ByVal UserName As String,
                                ByVal Password As String)
        Dim strConnect As String = "data source=" & ServerName & ";initial catalog=" &
                                   ";user id=" & UserName & ";password=" &
                                   Password & ";”
        Dim sql As String = "CREATE DATABASE [" & DBName & "]"
        Dim sqlConnection1 As SqlClient.SqlConnection =
            New System.Data.SqlClient.SqlConnection(strConnect)
        Try
            sbProg(1, 1, "正在创建数据库...")
            sqlConnection1.Open()
            Dim sqlCmd As SqlClient.SqlCommand =
                New SqlClient.SqlCommand(sql, sqlConnection1)
            sqlCmd.ExecuteNonQuery()
            'Catch ex As System.Data.SqlClient.SqlException
            '    MsgBox(ex.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            sqlConnection1.Close()

        Finally
        End Try

        sbSleepEx(2000)
        Me.Close()
    End Sub

    Private Sub frmProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = frmParent.Left + frmParent.Width / 2 - Me.Width / 2
        Me.Top = frmParent.Top + frmParent.Height / 2 - Me.Height / 2
    End Sub
End Class