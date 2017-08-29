Module Module1
    Private Const SLEEP_INTERVAL As Long = 50 'Sleep每次刷新时间间隔，单位ms
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

        Dim S As String = ""
        For I = 0 To CmdParaCount
            S = S & " " & CmdPara(I)
        Next

        Console.WriteLine(S)
        Console.ReadKey()

    End Sub

End Module
