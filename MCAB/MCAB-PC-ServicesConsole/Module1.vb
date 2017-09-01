Module Module1
    Private Const SLEEP_INTERVAL As Long = 50 'Sleep每次刷新时间间隔，单位ms
    Private RemoteIP As String = ""   '连接远程服务器的IP
    Private RemotePort As String = "" '连接远程服务器的端口
    Private RemoteUserName As String = "" '连接远程服务器的用户名
    Private RemotePassword As String = "" '连接远程服务器的密码
    Public Sub sbSleepEx(Optional ByVal ms As Long = SLEEP_INTERVAL)
        For L As Long = ms To 0 Step -SLEEP_INTERVAL
            Threading.Thread.Sleep(SLEEP_INTERVAL)
        Next
    End Sub
    Sub Main()
        '检查参数是否可靠
        Dim CmdParaCount As Integer = My.Application.CommandLineArgs.Count - 1
        If CmdParaCount <= 0 Then
            Console.WriteLine("无效参数 - 没有指定IP或端口")
            sbSleepEx(5000)
            Exit Sub
        End If
        Dim CmdPara(CmdParaCount) As String
        For I As Integer = 0 To CmdParaCount
            CmdPara(I) = My.Application.CommandLineArgs.Item(I)
        Next

        RemoteIP = CmdPara(0)
        RemotePort = CmdPara(1)

        Console.WriteLine("IP  :" & RemoteIP)
        Console.WriteLine("端口:" & RemotePort)
        Console.Write("用户:")
        RemoteUserName = Console.ReadLine()
        Console.Write("密码:")
        RemotePassword = ""
        Dim CK As ConsoleKeyInfo

        Do

            CK = Console.ReadKey(True)
            If CK.Key = ConsoleKey.Enter Then
                Console.Write(vbCrLf)
                Exit Do
            ElseIf CK.Key = ConsoleKey.Backspace Then
                If Len(RemotePassword) > 0 Then
                    Console.CursorLeft = Console.CursorLeft - 1
                    Console.Write(" ")
                    Console.CursorLeft = Console.CursorLeft - 1
                    RemotePassword = Left(RemotePassword, Len(RemotePassword) - 1)
                End If
            Else
                Console.Write("*")
                RemotePassword &= CK.KeyChar
            End If
        Loop

        'Console.WriteLine("PW(" & Len(RemotePassword) & "):" & RemotePassword)
        Console.Write(vbCrLf & vbCrLf & "按任意键退出")
        Console.ReadKey(True)
    End Sub

End Module
