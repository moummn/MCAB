<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbUserName = New System.Windows.Forms.TextBox()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnMore = New System.Windows.Forms.Button()
        Me.cbRemember = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'tbUserName
        '
        Me.tbUserName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUserName.Location = New System.Drawing.Point(21, 137)
        Me.tbUserName.Name = "tbUserName"
        Me.tbUserName.Size = New System.Drawing.Size(247, 21)
        Me.tbUserName.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPassword.Location = New System.Drawing.Point(21, 164)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPassword.Size = New System.Drawing.Size(247, 21)
        Me.tbPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.Location = New System.Drawing.Point(44, 217)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(204, 23)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "登录(&S)"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnMore
        '
        Me.btnMore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMore.Location = New System.Drawing.Point(248, 108)
        Me.btnMore.Name = "btnMore"
        Me.btnMore.Size = New System.Drawing.Size(31, 23)
        Me.btnMore.TabIndex = 5
        Me.btnMore.Text = "..."
        Me.btnMore.UseVisualStyleBackColor = True
        '
        'cbRemember
        '
        Me.cbRemember.AutoSize = True
        Me.cbRemember.Location = New System.Drawing.Point(21, 191)
        Me.cbRemember.Name = "cbRemember"
        Me.cbRemember.Size = New System.Drawing.Size(90, 16)
        Me.cbRemember.TabIndex = 6
        Me.cbRemember.Text = "记住密码(&R)"
        Me.cbRemember.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 262)
        Me.Controls.Add(Me.cbRemember)
        Me.Controls.Add(Me.btnMore)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.tbPassword)
        Me.Controls.Add(Me.tbUserName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "用户登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbUserName As TextBox
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnMore As Button
    Friend WithEvents cbRemember As CheckBox
End Class
