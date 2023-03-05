Imports System.IO

Public Class MainForm
    Dim pgbwPath As String
    Dim weatherInfo(9)
    Dim nOldWndLeft, nOldWndTop, nClickX, nClickY

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim myPath As String
        myPath = Application.StartupPath
        Dim userNameTxt
        userNameTxt = System.Environment.GetEnvironmentVariable("USERNAME")
        If TextBox1.Text <> "" Then
            If My.Computer.Network.IsAvailable = True Then
                On Error Resume Next
                'SavePGBW.ShowDialog()
                Dim weatherFilePath As String
                'weatherFilePath = SavePGBW.FileName
                Dim p As New Process
                Dim p2 As New Diagnostics.ProcessStartInfo("main.exe")
                p2.WorkingDirectory = myPath
                'p2.Arguments = "/c " & TextBox1.Text & " " & weatherFilePath
                'MsgBox("/c " & TextBox1.Text & " " & weatherFilePath)
                p2.Arguments = "/c " & TextBox1.Text & " " & "C:\Users\" & userNameTxt & "\Downloads"
                'p.StartInfo.FileName = myPath & "\main.exe /c " & TextBox1.Text & "C:\Users\" & userNameTxt & "\Downloads"
                p.StartInfo = p2
                p.Start()
                p.WaitForExit()
                MsgBox("寫入完成！", MsgBoxStyle.Information)
            Else
                MsgBox("您尚未連線網際網路！", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox("請輸入要查詢的城市名稱", MsgBoxStyle.Critical)
            Exit Sub
        End If
        MsgBox("檔案預設儲存於使用者的下載資料夾下，可自行移動", MsgBoxStyle.Information)
        pgbwPath = "C:\Users\" & userNameTxt & "\Downloads\Output.pgbWeather"
        pgbwPathShow.Text = "路徑：" & pgbwPath
        On Error GoTo error_Proc
        Dim SW As New StreamReader(pgbwPath, System.Text.Encoding.Default)
        Dim temp As String
        Dim readProc As Long = 0
        While True
            temp = SW.ReadLine ' 一次讀取一行
            If temp Is Nothing Or temp = "" Then Exit While '讀取不到或讀出空字串就結束
            weatherInfo(readProc) = temp
            readProc = readProc + 1
            ProgressBar1.Value = readProc
            ToolStripProgressBar1.Value = readProc
        End While
        weatherInfoSel.Enabled = True
        Exit Sub
error_Proc:
        If pgbwPath = "" Then
            Exit Sub
        Else
            MsgBox("檔案讀取錯誤！" & vbNewLine & "請檢查檔案狀態與軟體狀態，確認檔案讀取狀態", vbCritical)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenPGBW.ShowDialog()
        pgbwPath = OpenPGBW.FileName
        pgbwPathShow.Text = "路徑：" & pgbwPath
        On Error GoTo error_Proc
        Dim SW As New StreamReader(pgbwPath, System.Text.Encoding.Default)
        Dim temp As String
        Dim readProc As Long = 0
        While True
            temp = SW.ReadLine ' 一次讀取一行
            If temp Is Nothing Or temp = "" Then Exit While '讀取不到或讀出空字串就結束
            weatherInfo(readProc) = temp
            readProc = readProc + 1
            ProgressBar1.Value = readProc
            ToolStripProgressBar1.Value = readProc
        End While
        weatherInfoSel.Enabled = True
        Exit Sub
error_Proc:
        If pgbwPath = "" Then
            Exit Sub
        Else
            MsgBox("檔案讀取錯誤！" & vbNewLine & "請檢查檔案狀態與軟體狀態，確認檔案讀取狀態", vbCritical)
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Shell("explorer https://github.com/510208/WeatherOutputPy")
    End Sub

    Private Sub weatherInfoSel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weatherInfoSel.SelectedIndexChanged
        Dim wtLbl As Label = weatherInfoLbl
        wtLbl.Text = weatherInfo(weatherInfoSel.SelectedIndex)
        If weatherInfoSel.SelectedIndex > 1 And weatherInfoSel.SelectedIndex < 6 Then
            wtLbl.Text = wtLbl.Text & "℃"
        End If
        If weatherInfoSel.SelectedIndex = 6 Or weatherInfoSel.SelectedIndex = 9 Then
            wtLbl.Text = wtLbl.Text & "%"
        End If
        If weatherInfoSel.SelectedIndex = 7 Then
            wtLbl.Text = wtLbl.Text & "m/s"
        End If
        If weatherInfoSel.SelectedIndex = 8 Then
            wtLbl.Text = wtLbl.Text & "°"
        End If
    End Sub

    Function cToF(ByVal C As Long)
        cToF = 9 / 5 * Val(C) + 32
    End Function

    Function cToK(ByVal C As Long)
        cToK = Val(C) + 273
    End Function

    Private Sub pnlTitleBar_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseDown
        '紀錄滑鼠點選時的視窗位置與滑鼠點選位置
        nOldWndLeft = Me.Left
        nOldWndTop = Me.Top
        nClickX = e.X
        nClickY = e.Y
    End Sub

    Private Sub pnlTitleBar_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlTitleBar.MouseMove
        If pnlTitleBar.Capture = True Then      '如果滑鼠按著拖曳
            '設定新的視窗位置
            Me.Top = e.Y + nOldWndTop - nClickY
            Me.Left = e.X + nOldWndLeft - nClickX
            '更新紀錄的視窗位置
            nOldWndLeft = Me.Left
            nOldWndTop = Me.Top
        End If
    End Sub

    Private Sub pbxMinBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxMinBtn.Click
        Me.WindowState = FormWindowState.Minimized      '標題列縮小按鈕被按下=>縮小視窗
    End Sub

    Private Sub pbxCloseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxCloseBtn.Click
        Me.Close()      '標題列關閉按鈕被按下=>關閉視窗
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        AboutBox1.Show()
    End Sub
End Class
