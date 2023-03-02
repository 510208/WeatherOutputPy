Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            If My.Computer.Network.IsAvailable = True Then
                Dim myPath As String
                myPath = Application.StartupPath
                Dim userNameTxt
                userNameTxt = System.Environment.GetEnvironmentVariable("USERNAME")
                Dim p As New Process
                Dim p2 As New Diagnostics.ProcessStartInfo("main.exe")
                p2.WorkingDirectory = myPath
                p2.Arguments = "/c " & TextBox1.Text & " " & "C:\Users\" & userNameTxt & "\Downloads"
                'p.StartInfo.FileName = myPath & "\main.exe /c " & TextBox1.Text & "C:\Users\" & userNameTxt & "\Downloads"
                p.StartInfo = p2
                p.Start()
                p.WaitForExit()
                MsgBox("寫入完成！", MsgBoxStyle.Information)
            Else
                MsgBox("您尚未連線網際網路！", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("請輸入要查詢的城市名稱", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
