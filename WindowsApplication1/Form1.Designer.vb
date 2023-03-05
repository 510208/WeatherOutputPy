<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenPGBW = New System.Windows.Forms.OpenFileDialog
        Me.Button2 = New System.Windows.Forms.Button
        Me.pgbwPathShow = New System.Windows.Forms.Label
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.weatherInfoLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.weatherInfoSel = New System.Windows.Forms.ListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Button3 = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar
        Me.SavePGBW = New System.Windows.Forms.SaveFileDialog
        Me.pnlTitleBar = New System.Windows.Forms.Panel
        Me.pbxCloseBtn = New System.Windows.Forms.Button
        Me.pbxMinBtn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Name = "Label1"
        '
        'TextBox1
        '
        resources.ApplyResources(Me.TextBox1, "TextBox1")
        Me.TextBox1.Name = "TextBox1"
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenPGBW
        '
        resources.ApplyResources(Me.OpenPGBW, "OpenPGBW")
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pgbwPathShow
        '
        resources.ApplyResources(Me.pgbwPathShow, "pgbwPathShow")
        Me.pgbwPathShow.Name = "pgbwPathShow"
        '
        'LinkLabel1
        '
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.weatherInfoLbl)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.weatherInfoSel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.pgbwPathShow)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.LawnGreen
        resources.ApplyResources(Me.ProgressBar1, "ProgressBar1")
        Me.ProgressBar1.Maximum = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        '
        'weatherInfoLbl
        '
        resources.ApplyResources(Me.weatherInfoLbl, "weatherInfoLbl")
        Me.weatherInfoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weatherInfoLbl.Name = "weatherInfoLbl"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'weatherInfoSel
        '
        resources.ApplyResources(Me.weatherInfoSel, "weatherInfoSel")
        Me.weatherInfoSel.FormattingEnabled = True
        Me.weatherInfoSel.Items.AddRange(New Object() {resources.GetString("weatherInfoSel.Items"), resources.GetString("weatherInfoSel.Items1"), resources.GetString("weatherInfoSel.Items2"), resources.GetString("weatherInfoSel.Items3"), resources.GetString("weatherInfoSel.Items4"), resources.GetString("weatherInfoSel.Items5"), resources.GetString("weatherInfoSel.Items6"), resources.GetString("weatherInfoSel.Items7"), resources.GetString("weatherInfoSel.Items8"), resources.GetString("weatherInfoSel.Items9")})
        Me.weatherInfoSel.Name = "weatherInfoSel"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'NotifyIcon1
        '
        resources.ApplyResources(Me.NotifyIcon1, "NotifyIcon1")
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        resources.ApplyResources(Me.ToolStripStatusLabel1, "ToolStripStatusLabel1")
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Maximum = 10
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        '
        'SavePGBW
        '
        resources.ApplyResources(Me.SavePGBW, "SavePGBW")
        '
        'pnlTitleBar
        '
        resources.ApplyResources(Me.pnlTitleBar, "pnlTitleBar")
        Me.pnlTitleBar.Controls.Add(Me.pbxMinBtn)
        Me.pnlTitleBar.Controls.Add(Me.pbxCloseBtn)
        Me.pnlTitleBar.Name = "pnlTitleBar"
        '
        'pbxCloseBtn
        '
        Me.pbxCloseBtn.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.pbxCloseBtn, "pbxCloseBtn")
        Me.pbxCloseBtn.Name = "pbxCloseBtn"
        Me.pbxCloseBtn.UseVisualStyleBackColor = True
        '
        'pbxMinBtn
        '
        resources.ApplyResources(Me.pbxMinBtn, "pbxMinBtn")
        Me.pbxMinBtn.Name = "pbxMinBtn"
        Me.pbxMinBtn.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlTitleBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlTitleBar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenPGBW As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents pgbwPathShow As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents weatherInfoLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents weatherInfoSel As System.Windows.Forms.ListBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents SavePGBW As System.Windows.Forms.SaveFileDialog
    Friend WithEvents pnlTitleBar As System.Windows.Forms.Panel
    Friend WithEvents pbxMinBtn As System.Windows.Forms.Button
    Friend WithEvents pbxCloseBtn As System.Windows.Forms.Button

End Class
