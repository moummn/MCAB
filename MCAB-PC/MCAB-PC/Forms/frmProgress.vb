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
        sbSleepEx()
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
        Dim L As Long = 1
        Dim strConnect As String
        Dim sqlConnection1 As New SqlClient.SqlConnection
        'Dim sqlConnection1 As SqlClient.SqlConnection = New System.Data.SqlClient.SqlConnection(strConnect)
        Dim sqlCmd As New SqlClient.SqlCommand
        'Dim sqlCmd As SqlClient.SqlCommand = New SqlClient.SqlCommand(sql, sqlConnection1)

        Try
            '创建数据库
            sbProg(1, 5, "正在创建数据库...")
            strConnect = "data source=" & ServerName & ";initial catalog=" &
                         ";user id=" & UserName & ";password=" & Password & ";”
            sqlConnection1.ConnectionString = strConnect
            sqlConnection1.Open()
            sqlCmd.Connection = sqlConnection1
            sqlCmd.CommandText = "CREATE DATABASE [" & DBName & "]"
            sqlCmd.ExecuteNonQuery()
            sqlConnection1.Close()

            sbProg(2)
            strConnect = "data source=" & ServerName & ";initial catalog=" & DBName &
                         ";user id=" & UserName & ";password=" & Password & ";”
            sqlConnection1.ConnectionString = strConnect
            Do
                L = 0
                Try
                    sqlConnection1.Open()
                    L = MAX_SQL_RETRY + 1
                Catch ex As SqlClient.SqlException
                    If ex.Number = 4060 Then
                        L = L + 1
                    Else
                        MsgBox(ex.ToString)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            Loop Until l >= MAX_SQL_RETRY
            sqlCmd.Connection = sqlConnection1

            '创建系统表 - 基本信息库
            sbProg(3)
            sqlCmd.CommandText = "CREATE TABLE BasicInfo (
                                  id INTEGER CONSTRAINT PK_BasicInfo PRIMARY KEY,
                                  Name NVARCHAR(50),
                                  Value NVARCHAR(MAX))"
            sqlCmd.ExecuteNonQuery()
            sqlCmd.CommandText = "INSERT INTO BasicInfo VALUES ( '1','Title','档案管理系统')"
            sqlCmd.ExecuteNonQuery()
            sqlCmd.CommandText = "INSERT INTO BasicInfo VALUES ( '2','Version','1.0')"
            sqlCmd.ExecuteNonQuery()

            '创建系统表 - 目录索引
            sbProg(4)
            sqlCmd.CommandText = "CREATE TABLE DirectoryIndex (
                                  id INTEGER CONSTRAINT PK_DirectoryIndex PRIMARY KEY,
                                  hierarchy INTEGER,
                                  DirName CHAR(255))"
            sqlCmd.ExecuteNonQuery()
            sqlCmd.CommandText = "INSERT INTO DirectoryIndex VALUES ( '1','0','档案目录1')"
            sqlCmd.ExecuteNonQuery()
            sqlCmd.CommandText = "INSERT INTO DirectoryIndex VALUES ( '2','0','档案目录2')"
            sqlCmd.ExecuteNonQuery()
            sbProg(5)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Try
            sqlConnection1.Close()

        Finally
        End Try

        'sbSleepEx(2000)
        Me.Close()
    End Sub

    Private Sub frmProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left = frmParent.Left + frmParent.Width / 2 - Me.Width / 2
        Me.Top = frmParent.Top + frmParent.Height / 2 - Me.Height / 2
    End Sub
End Class