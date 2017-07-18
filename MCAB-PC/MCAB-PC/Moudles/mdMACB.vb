Module mdMACB
    Private Const SLEEP_INTERVAL As Long = 50 'Sleep每次刷新时间间隔，单位ms
    Public Sub sbSleepEx(ByVal ms As Long)
        For L As Long = ms To 0 Step -SLEEP_INTERVAL
            Threading.Thread.Sleep(SLEEP_INTERVAL)
            Application.DoEvents()
        Next
    End Sub
End Module
