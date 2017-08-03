#Region "添加命名空间"

Imports Microsoft.Win32.SafeHandles
Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.ComponentModel

#End Region
Public Class frmMonitor

#Region "UAC权限相关"
    ''' <summary>
    ''' The function gets the elevation information of the current process. It 
    ''' dictates whether the process is elevated or not. Token elevation is only 
    ''' available on Windows Vista and newer operating systems, thus 
    ''' IsProcessElevated throws a C++ exception if it is called on systems prior 
    ''' to Windows Vista. It is not appropriate to use this function to determine 
    ''' whether a process is run as administartor.
    ''' </summary>
    ''' <returns>
    ''' Returns True if the process is elevated. Returns False if it is not.
    ''' </returns>
    ''' <exception cref="System.ComponentModel.Win32Exception">
    ''' When any native Windows API call fails, the function throws a Win32Exception
    ''' with the last error code.
    ''' </exception>
    ''' <remarks>
    ''' TOKEN_INFORMATION_CLASS provides TokenElevationType to check the elevation 
    ''' type (TokenElevationTypeDefault / TokenElevationTypeLimited / 
    ''' TokenElevationTypeFull) of the process. It is different from TokenElevation 
    ''' in that, when UAC is turned off, elevation type always returns 
    ''' TokenElevationTypeDefault even though the process is elevated (Integrity 
    ''' Level == High). In other words, it is not safe to say if the process is 
    ''' elevated based on elevation type. Instead, we should use TokenElevation.
    ''' </remarks>
    Friend Function IsProcessElevated() As Boolean
        Dim fIsElevated As Boolean = False
        Dim hToken As SafeTokenHandle = Nothing
        Dim cbTokenElevation As Integer = 0
        Dim pTokenElevation As IntPtr = IntPtr.Zero

        Try
            ' Open the access token of the current process with TOKEN_QUERY.
            If (Not NativeMethods.OpenProcessToken(Process.GetCurrentProcess.Handle,
                NativeMethods.TOKEN_QUERY, hToken)) Then
                Throw New Win32Exception
            End If

            ' Allocate a buffer for the elevation information.
            cbTokenElevation = Marshal.SizeOf(GetType(TOKEN_ELEVATION))
            pTokenElevation = Marshal.AllocHGlobal(cbTokenElevation)
            If (pTokenElevation = IntPtr.Zero) Then
                Throw New Win32Exception
            End If

            ' Retrieve token elevation information.
            If (Not NativeMethods.GetTokenInformation(hToken,
                TOKEN_INFORMATION_CLASS.TokenElevation,
                pTokenElevation, cbTokenElevation, cbTokenElevation)) Then
                ' When the process is run on operating systems prior to 
                ' Windows Vista, GetTokenInformation returns false with the 
                ' ERROR_INVALID_PARAMETER error code because 
                ' TokenIntegrityLevel is not supported on those OS's.
                Throw New Win32Exception
            End If

            ' Marshal the TOKEN_ELEVATION struct from native to .NET
            Dim elevation As TOKEN_ELEVATION = Marshal.PtrToStructure(
            pTokenElevation, GetType(TOKEN_ELEVATION))

            ' TOKEN_ELEVATION.TokenIsElevated is a non-zero value if the 
            ' token has elevated privileges; otherwise, a zero value.
            fIsElevated = (elevation.TokenIsElevated <> 0)

        Finally
            ' Centralized cleanup for all allocated resources.
            If (Not hToken Is Nothing) Then
                hToken.Close()
                hToken = Nothing
            End If
            If (pTokenElevation <> IntPtr.Zero) Then
                Marshal.FreeHGlobal(pTokenElevation)
                pTokenElevation = IntPtr.Zero
                cbTokenElevation = 0
            End If
        End Try

        Return fIsElevated
    End Function
#End Region
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

        If (Environment.OSVersion.Version.Major >= 6) Then
            ' Running Windows Vista or later (major version >= 6). 

            Try
                ' Get and display the process elevation information.
                Dim fIsElevated As Boolean = Me.IsProcessElevated


                ' Update the Self-elevate button to show the UAC shield icon on 
                ' the UI if the process is not elevated.
                'Me.btnStartService.FlatStyle = FlatStyle.System
                NativeMethods.SendMessage(Me.btnInstallService.Handle, NativeMethods.BCM_SETSHIELD,
                                         0, IIf(fIsElevated, IntPtr.Zero, New IntPtr(1)))
                NativeMethods.SendMessage(Me.btnUninstallService.Handle, NativeMethods.BCM_SETSHIELD,
                                         0, IIf(fIsElevated, IntPtr.Zero, New IntPtr(1)))
                NativeMethods.SendMessage(Me.btnStartService.Handle, NativeMethods.BCM_SETSHIELD,
                                         0, IIf(fIsElevated, IntPtr.Zero, New IntPtr(1)))
                NativeMethods.SendMessage(Me.btnStopService.Handle, NativeMethods.BCM_SETSHIELD,
                                         0, IIf(fIsElevated, IntPtr.Zero, New IntPtr(1)))
            Catch ex As Exception

                'MessageBox.Show(ex.Message, "An error occurred in IsProcessElevated",
                '                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub TextBox12_GotFocus(sender As Object, e As EventArgs) Handles tbMCABIP.GotFocus, tbMCABPort.GotFocus
        Me.AcceptButton = btnConnect
    End Sub


    Private Sub TextBox12_LostFocus(sender As Object, e As EventArgs) Handles tbMCABIP.LostFocus, tbMCABPort.LostFocus
        Me.AcceptButton = btnSend
    End Sub


End Class
