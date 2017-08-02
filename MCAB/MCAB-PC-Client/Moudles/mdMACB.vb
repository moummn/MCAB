Module mdMACB

    Public Const MAX_SQL_RETRY As Long = 100 'SQL操作失败时尝试重复次数


    Private Const SLEEP_INTERVAL As Long = 50 'Sleep每次刷新时间间隔，单位ms
    Public Sub sbSleepEx(Optional ByVal ms As Long = SLEEP_INTERVAL)
        For L As Long = ms To 0 Step -SLEEP_INTERVAL
            Threading.Thread.Sleep(SLEEP_INTERVAL)
            Application.DoEvents()
        Next
    End Sub
    Public Function fnGetTimeString() As String
        fnGetTimeString = Strings.Right(Hex(Now.ToBinary) & Strings.Right("0000" & Hex(65535 * Rnd(Now.Millisecond)), 4), 20)
    End Function
End Module
