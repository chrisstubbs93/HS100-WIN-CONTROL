<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.comboOnOff = New System.Windows.Forms.ComboBox()
        Me.comboEvent = New System.Windows.Forms.ComboBox()
        Me.comboDeviceSettingList = New System.Windows.Forms.ComboBox()
        Me.turn = New System.Windows.Forms.Label()
        Me.lblQueueturn = New System.Windows.Forms.Label()
        Me.listviewSettings = New System.Windows.Forms.ListView()
        Me.NameC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EventC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ActionC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnRemoveSetting = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(323, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.comboOnOff)
        Me.Panel1.Controls.Add(Me.comboEvent)
        Me.Panel1.Controls.Add(Me.comboDeviceSettingList)
        Me.Panel1.Controls.Add(Me.turn)
        Me.Panel1.Controls.Add(Me.lblQueueturn)
        Me.Panel1.Location = New System.Drawing.Point(15, 345)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(423, 38)
        Me.Panel1.TabIndex = 22
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(356, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'comboOnOff
        '
        Me.comboOnOff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboOnOff.FormattingEnabled = True
        Me.comboOnOff.Items.AddRange(New Object() {"Off", "On"})
        Me.comboOnOff.Location = New System.Drawing.Point(288, 8)
        Me.comboOnOff.Name = "comboOnOff"
        Me.comboOnOff.Size = New System.Drawing.Size(52, 21)
        Me.comboOnOff.TabIndex = 22
        '
        'comboEvent
        '
        Me.comboEvent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEvent.FormattingEnabled = True
        Me.comboEvent.Items.AddRange(New Object() {"Startup", "Shutdown"})
        Me.comboEvent.Location = New System.Drawing.Point(30, 8)
        Me.comboEvent.Name = "comboEvent"
        Me.comboEvent.Size = New System.Drawing.Size(71, 21)
        Me.comboEvent.TabIndex = 22
        '
        'comboDeviceSettingList
        '
        Me.comboDeviceSettingList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDeviceSettingList.FormattingEnabled = True
        Me.comboDeviceSettingList.Location = New System.Drawing.Point(142, 8)
        Me.comboDeviceSettingList.Name = "comboDeviceSettingList"
        Me.comboDeviceSettingList.Size = New System.Drawing.Size(134, 21)
        Me.comboDeviceSettingList.TabIndex = 21
        '
        'turn
        '
        Me.turn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.turn.AutoSize = True
        Me.turn.Location = New System.Drawing.Point(107, 11)
        Me.turn.Name = "turn"
        Me.turn.Size = New System.Drawing.Size(25, 13)
        Me.turn.TabIndex = 20
        Me.turn.Text = "turn"
        '
        'lblQueueturn
        '
        Me.lblQueueturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueueturn.AutoSize = True
        Me.lblQueueturn.Location = New System.Drawing.Point(3, 11)
        Me.lblQueueturn.Name = "lblQueueturn"
        Me.lblQueueturn.Size = New System.Drawing.Size(21, 13)
        Me.lblQueueturn.TabIndex = 20
        Me.lblQueueturn.Text = "On"
        '
        'listviewSettings
        '
        Me.listviewSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listviewSettings.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameC, Me.IDC, Me.EventC, Me.ActionC})
        Me.listviewSettings.FullRowSelect = True
        Me.listviewSettings.GridLines = True
        Me.listviewSettings.Location = New System.Drawing.Point(15, 18)
        Me.listviewSettings.Name = "listviewSettings"
        Me.listviewSettings.Size = New System.Drawing.Size(423, 310)
        Me.listviewSettings.TabIndex = 23
        Me.listviewSettings.UseCompatibleStateImageBehavior = False
        Me.listviewSettings.View = System.Windows.Forms.View.Details
        '
        'NameC
        '
        Me.NameC.Text = "Name"
        Me.NameC.Width = 147
        '
        'IDC
        '
        Me.IDC.Text = "ID"
        Me.IDC.Width = 136
        '
        'EventC
        '
        Me.EventC.Text = "Event"
        '
        'ActionC
        '
        Me.ActionC.Text = "Action"
        '
        'btnRemoveSetting
        '
        Me.btnRemoveSetting.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveSetting.Location = New System.Drawing.Point(323, 406)
        Me.btnRemoveSetting.Name = "btnRemoveSetting"
        Me.btnRemoveSetting.Size = New System.Drawing.Size(115, 23)
        Me.btnRemoveSetting.TabIndex = 3
        Me.btnRemoveSetting.Text = "Remove Selected"
        Me.btnRemoveSetting.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 488)
        Me.Controls.Add(Me.listviewSettings)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnRemoveSetting)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form2"
        Me.Text = "Automatic Startup/Shutdown Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents comboEvent As System.Windows.Forms.ComboBox
    Friend WithEvents comboDeviceSettingList As System.Windows.Forms.ComboBox
    Friend WithEvents turn As System.Windows.Forms.Label
    Friend WithEvents lblQueueturn As System.Windows.Forms.Label
    Friend WithEvents comboOnOff As System.Windows.Forms.ComboBox
    Friend WithEvents listviewSettings As System.Windows.Forms.ListView
    Friend WithEvents NameC As System.Windows.Forms.ColumnHeader
    Friend WithEvents IDC As System.Windows.Forms.ColumnHeader
    Friend WithEvents EventC As System.Windows.Forms.ColumnHeader
    Friend WithEvents ActionC As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnRemoveSetting As System.Windows.Forms.Button
End Class
