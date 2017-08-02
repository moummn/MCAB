Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Public Class SrvMCAB

    Private StopFlag As Boolean = False '退出标志

    Private Sub CreateListen()
        Dim TcpL As New TcpListener(IPAddress.Any, My.Settings.TCP_LOCAL_PORT)
        TcpL.Start()
        Do Until StopFlag '循环直到StopFlag=True  
            '===开始监听===  
            Dim TCPClt As TcpClient = TcpL.AcceptTcpClient ''定义用于答复的TcpClient  
            Dim Thr As New Thread(AddressOf NewConn) '为新TcpClient创建线程  
            Thr.Start(TCPClt) '启动线程  
        Loop
    End Sub
    Private Sub NewConn(Client As TcpClient)
        ''''''''TODO
        SendData(Client, Text.Encoding.UTF8.GetBytes("Welcome!")) '发送欢迎信息  
        Dim Buffer As Byte() = New Byte(4095) {} '定义接收缓冲  
        Dim RecLength As Integer '定义接收长度  
        Try
            Do Until StopFlag
                RecLength = Client.Client.Receive(Buffer)
                Select Case RecLength
                    Case 0
                        Exit Try '对端断开，跳出流程  
                    Case Else
                        '正常处理逻辑  
                        Dim Packet As Byte() = New Byte(RecLength - 1) {}
                        Array.Copy(Buffer, 0, Packet, 0, Packet.Length) '获取实际数据  
                        '......  
                        '对实际数据进行处理  
                        '按接收原样答复  
                        SendData(Client, Packet) '逻辑自己调整  
                End Select
            Loop
        Catch ex As SocketException
            Select Case ex.NativeErrorCode
                Case 10053, 10054
                    '远端断开  
                Case Else
                    '其他错误  
            End Select
        End Try
        '会话结束  
        ' Client.Client.Dispose()
    End Sub
    Private Sub SendData(Client As TcpClient, Buffer As Byte())
        Client.Client.Send(Buffer) '发送数据    
    End Sub
    Protected Overrides Sub OnStart(ByVal args() As String)
        ' 请在此处添加代码以启动您的服务。此方法应完成设置工作，
        ' 以使您的服务开始工作。

    End Sub

    Protected Overrides Sub OnStop()
        ' 在此处添加代码以执行任何必要的拆解操作，从而停止您的服务。
    End Sub

End Class
