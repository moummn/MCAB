<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMonitor
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.tbMCABIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMCABPort = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStopService = New System.Windows.Forms.Button()
        Me.btnStartService = New System.Windows.Forms.Button()
        Me.btnUninstallService = New System.Windows.Forms.Button()
        Me.btnInstallService = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'tbMCABIP
        '
        Me.tbMCABIP.Location = New System.Drawing.Point(89, 23)
        Me.tbMCABIP.Name = "tbMCABIP"
        Me.tbMCABIP.Size = New System.Drawing.Size(100, 21)
        Me.tbMCABIP.TabIndex = 5
        Me.tbMCABIP.Text = "127.0.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MCAB服务器IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(233, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "端口"
        '
        'tbMCABPort
        '
        Me.tbMCABPort.Location = New System.Drawing.Point(268, 23)
        Me.tbMCABPort.Name = "tbMCABPort"
        Me.tbMCABPort.Size = New System.Drawing.Size(40, 21)
        Me.tbMCABPort.TabIndex = 7
        Me.tbMCABPort.Text = "2155"
        '
        'btnConnect
        '
        Me.btnConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConnect.Location = New System.Drawing.Point(344, 18)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(94, 28)
        Me.btnConnect.TabIndex = 9
        Me.btnConnect.Text = "连接(&C)"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnStopService)
        Me.GroupBox1.Controls.Add(Me.btnStartService)
        Me.GroupBox1.Controls.Add(Me.btnUninstallService)
        Me.GroupBox1.Controls.Add(Me.btnInstallService)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "本机MCAB服务状态"
        '
        'btnStopService
        '
        Me.btnStopService.Enabled = False
        Me.btnStopService.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStopService.Location = New System.Drawing.Point(344, 54)
        Me.btnStopService.Name = "btnStopService"
        Me.btnStopService.Size = New System.Drawing.Size(94, 28)
        Me.btnStopService.TabIndex = 9
        Me.btnStopService.Text = "停止服务(&T)"
        Me.btnStopService.UseVisualStyleBackColor = True
        '
        'btnStartService
        '
        Me.btnStartService.Enabled = False
        Me.btnStartService.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnStartService.Location = New System.Drawing.Point(244, 54)
        Me.btnStartService.Name = "btnStartService"
        Me.btnStartService.Size = New System.Drawing.Size(94, 28)
        Me.btnStartService.TabIndex = 8
        Me.btnStartService.Text = "启动服务(&S)"
        Me.btnStartService.UseVisualStyleBackColor = True
        '
        'btnUninstallService
        '
        Me.btnUninstallService.Enabled = False
        Me.btnUninstallService.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUninstallService.Location = New System.Drawing.Point(344, 20)
        Me.btnUninstallService.Name = "btnUninstallService"
        Me.btnUninstallService.Size = New System.Drawing.Size(94, 28)
        Me.btnUninstallService.TabIndex = 7
        Me.btnUninstallService.Text = "卸载服务(&U)"
        Me.btnUninstallService.UseVisualStyleBackColor = True
        '
        'btnInstallService
        '
        Me.btnInstallService.Enabled = False
        Me.btnInstallService.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnInstallService.Location = New System.Drawing.Point(244, 20)
        Me.btnInstallService.Name = "btnInstallService"
        Me.btnInstallService.Size = New System.Drawing.Size(94, 28)
        Me.btnInstallService.TabIndex = 6
        Me.btnInstallService.Text = "安装服务(&I)"
        Me.btnInstallService.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 12)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "正在获取服务状态..."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbMCABIP)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.tbMCABPort)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 58)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MCAB服务连接配置"
        '
        'frmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnConnect
        Me.ClientSize = New System.Drawing.Size(471, 189)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMonitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MCAB服务监控与调试"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents tbMCABIP As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMCABPort As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStopService As Button
    Friend WithEvents btnStartService As Button
    Friend WithEvents btnUninstallService As Button
    Friend WithEvents btnInstallService As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
