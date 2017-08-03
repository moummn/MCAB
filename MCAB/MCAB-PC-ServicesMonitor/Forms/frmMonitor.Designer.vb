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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnStopService = New System.Windows.Forms.Button()
        Me.btnStartService = New System.Windows.Forms.Button()
        Me.btnUninstallService = New System.Windows.Forms.Button()
        Me.btnInstallService = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbCmd = New System.Windows.Forms.TextBox()
        Me.tbDebug = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(89, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 5
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
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(268, 23)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(40, 21)
        Me.TextBox2.TabIndex = 7
        '
        'btnConnect
        '
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
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.btnConnect)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 58)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MCAB服务连接配置"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSend)
        Me.GroupBox3.Controls.Add(Me.tbCmd)
        Me.GroupBox3.Controls.Add(Me.tbDebug)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 182)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(444, 217)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "调试工具"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(387, 190)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(51, 21)
        Me.btnSend.TabIndex = 10
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbCmd
        '
        Me.tbCmd.Location = New System.Drawing.Point(7, 190)
        Me.tbCmd.Name = "tbCmd"
        Me.tbCmd.Size = New System.Drawing.Size(380, 21)
        Me.tbCmd.TabIndex = 1
        '
        'tbDebug
        '
        Me.tbDebug.Location = New System.Drawing.Point(7, 20)
        Me.tbDebug.Multiline = True
        Me.tbDebug.Name = "tbDebug"
        Me.tbDebug.ReadOnly = True
        Me.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbDebug.Size = New System.Drawing.Size(430, 168)
        Me.tbDebug.TabIndex = 0
        '
        'frmMonitor
        '
        Me.AcceptButton = Me.btnSend
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 411)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ServiceController1 As ServiceProcess.ServiceController
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnConnect As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnStopService As Button
    Friend WithEvents btnStartService As Button
    Friend WithEvents btnUninstallService As Button
    Friend WithEvents btnInstallService As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tbDebug As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents tbCmd As TextBox
End Class
