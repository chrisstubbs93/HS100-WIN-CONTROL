Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each item In Form1.listviewDevices.Items
            comboDeviceSettingList.Items.Add(item.SubItems(0).Text)
        Next

        If Form1.listviewDevices.SelectedIndices.Count = 1 Then
            comboDeviceSettingList.SelectedIndex = Form1.listviewDevices.FocusedItem.Index
        Else
            comboDeviceSettingList.SelectedIndex = 0
        End If
        comboEvent.SelectedIndex = 0
        comboOnOff.SelectedIndex = 0


        'load settings
        If Settings2.Default.StartOff <> "" Then
            For Each setting In Settings2.Default.StartOff.Split(";").Take(Settings2.Default.StartOff.Split(";").Count - 1)
                Dim tempitem As System.Windows.Forms.ListViewItem = New ListViewItem(namefromid(setting))
                tempitem.SubItems.Add(setting)
                tempitem.SubItems.Add("Startup")
                tempitem.SubItems.Add("Off")
                listviewSettings.Items.Add(tempitem)
            Next
        End If
        If Settings2.Default.StartOn <> "" Then
            For Each setting In Settings2.Default.StartOn.Split(";").Take(Settings2.Default.StartOn.Split(";").Count - 1)
                Dim tempitem As System.Windows.Forms.ListViewItem = New ListViewItem(namefromid(setting))
                tempitem.SubItems.Add(setting)
                tempitem.SubItems.Add("Startup")
                tempitem.SubItems.Add("On")
                listviewSettings.Items.Add(tempitem)
            Next
        End If
        If Settings2.Default.QuitOff <> "" Then
            For Each setting In Settings2.Default.QuitOff.Split(";").Take(Settings2.Default.QuitOff.Split(";").Count - 1)
                Dim tempitem As System.Windows.Forms.ListViewItem = New ListViewItem(namefromid(setting))
                tempitem.SubItems.Add(setting)
                tempitem.SubItems.Add("Shutdown")
                tempitem.SubItems.Add("Off")
                listviewSettings.Items.Add(tempitem)
            Next
        End If
        If Settings2.Default.QuitOn <> "" Then
            For Each setting In Settings2.Default.QuitOn.Split(";").Take(Settings2.Default.QuitOn.Split(";").Count - 1)
                Dim tempitem As System.Windows.Forms.ListViewItem = New ListViewItem(namefromid(setting))
                tempitem.SubItems.Add(setting)
                tempitem.SubItems.Add("Shutdown")
                tempitem.SubItems.Add("On")
                listviewSettings.Items.Add(tempitem)
            Next
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Settings2.Default.Reset()

        For Each item In listviewSettings.Items
            If item.SubItems(2).Text = "Startup" And item.SubItems(3).Text = "Off" Then
                Settings2.Default.StartOff = Settings2.Default.StartOff + item.SubItems(1).Text + ";"
            End If
            If item.SubItems(2).Text = "Startup" And item.SubItems(3).Text = "On" Then
                Settings2.Default.StartOn = Settings2.Default.StartOn + item.SubItems(1).Text + ";"
            End If
            If item.SubItems(2).Text = "Shutdown" And item.SubItems(3).Text = "Off" Then
                Settings2.Default.QuitOff = Settings2.Default.QuitOff + item.SubItems(1).Text + ";"
            End If
            If item.SubItems(2).Text = "Shutdown" And item.SubItems(3).Text = "On" Then
                Settings2.Default.QuitOn = Settings2.Default.QuitOn + item.SubItems(1).Text + ";"
            End If
        Next

        Settings2.Default.Save()

        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tempitem As System.Windows.Forms.ListViewItem = New ListViewItem(comboDeviceSettingList.Text)
        tempitem.SubItems.Add(Form1.listviewDevices.Items(comboDeviceSettingList.SelectedIndex).SubItems(2).Text)
        tempitem.SubItems.Add(comboEvent.Text)
        tempitem.SubItems.Add(comboOnOff.Text)
        listviewSettings.Items.Add(tempitem)
    End Sub

    Private Sub btnRemoveSetting_Click(sender As Object, e As EventArgs) Handles btnRemoveSetting.Click
        If listviewSettings.SelectedIndices.Count = 1 Then
            listviewSettings.Items(listviewSettings.SelectedIndices(0)).Remove()
        Else
            MsgBox("You must select one setting")
        End If
    End Sub

    Function namefromid(id As String) As String
        For Each item In Form1.listviewDevices.Items
            If item.SubItems(2).Text = id Then
                Return item.SubItems(0).Text
            End If
        Next
        Return "Unknown"
    End Function
End Class