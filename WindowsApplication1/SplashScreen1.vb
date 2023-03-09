Public NotInheritable Class SplashScreen1

    'TODO: 您可以在專案設計工具的 [應用程式] 索引標籤中 (位於 [專案] 功能表下的 [屬性])，輕易地將這個表單設定成
    '  應用程式的啟動顯示畫面。


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Enabled = True
        '在執行階段中，根據應用程式的組件資訊，設定對話方塊文字。  

        'TODO: 在專案屬性對話方塊 (位於 [專案] 功能表下) 的 [應用程式] 窗格中
        '  自訂應用程式的組件資訊。

        '應用程式標題
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            '如果應用程式標題遺失，請使用不含副檔名的應用程式名稱
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        '利用設計階段在 Version 控制中設定的文字做為格式字串，來格式化版本資訊。
        '  這種方式可以讓您視需要提供有效的當地語系化設定。
        '  您可以使用下列程式碼，並將 Version 控制的設計階段文字改成
        '  "Version {0}.{1:00}.{2}.{3}" 或其他類似字串，以包括組建和修訂資訊。如需
        '  詳細資訊，請參閱 [說明] 中的 String.Format()。
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        '著作權資訊
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub MainLayoutPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MainLayoutPanel.Paint
        PictureBox1.BackgroundImage = AboutBox1.LogoPictureBox.BackgroundImage
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        MainForm.Show()
        Me.Hide()
        Timer1.Enabled = False
    End Sub
End Class
