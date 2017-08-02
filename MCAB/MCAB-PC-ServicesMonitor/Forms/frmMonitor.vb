Public Class frmMonitor
    ''' ''' TODO 添加按钮的UAC
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ServiceController1.ServiceName = "MCAB-PC-Services"
        Try
            ServiceController1.Refresh()
            If ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Running Then
                Label1.Text = "服务状态：正在运行"
                btnInstallService.Enabled = False
                btnUninstallService.Enabled = True
                btnStartService.Enabled = False
                btnStopService.Enabled = True
            ElseIf ServiceController1.Status = ServiceProcess.ServiceControllerStatus.Stopped Then
                Label1.Text = "服务状态：已停止"
                btnInstallService.Enabled = False
                btnUninstallService.Enabled = True
                btnStartService.Enabled = True
                btnStopService.Enabled = False
            Else
                Label1.Text = "服务状态：" & ServiceController1.Status.ToString
                btnInstallService.Enabled = False
                btnUninstallService.Enabled = False
                btnStartService.Enabled = False
                btnStopService.Enabled = False
            End If

        Catch ex As System.InvalidOperationException
            Label1.Text = "服务状态：未安装"
            btnInstallService.Enabled = True
            btnUninstallService.Enabled = False
            btnStartService.Enabled = False
            btnStopService.Enabled = False

        End Try

    End Sub

    Private Sub frmMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
