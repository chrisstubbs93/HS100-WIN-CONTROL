<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblStep0 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnUpdatelist = New System.Windows.Forms.Button()
        Me.lblDevlist = New System.Windows.Forms.Label()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.DeviceName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceStaus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DeviceURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.listviewDevices = New System.Windows.Forms.ListView()
        Me.DeviceState = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RightClickCopy = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dbgMode = New System.Windows.Forms.CheckBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.lblStep3 = New System.Windows.Forms.Label()
        Me.btnCreateSettings = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StartInTray = New System.Windows.Forms.CheckBox()
        Me.RightClickCopy.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStep0
        '
        Me.lblStep0.AutoSize = True
        Me.lblStep0.Location = New System.Drawing.Point(9, 9)
        Me.lblStep0.Name = "lblStep0"
        Me.lblStep0.Size = New System.Drawing.Size(250, 26)
        Me.lblStep0.TabIndex = 16
        Me.lblStep0.Text = "Step 0) Log in to Kasa app with cloud account and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "add a device to your account"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(12, 82)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(225, 20)
        Me.txtEmail.TabIndex = 0
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(10, 66)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(32, 13)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "Email"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(252, 66)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'btnUpdatelist
        '
        Me.btnUpdatelist.Location = New System.Drawing.Point(12, 109)
        Me.btnUpdatelist.Name = "btnUpdatelist"
        Me.btnUpdatelist.Size = New System.Drawing.Size(425, 23)
        Me.btnUpdatelist.TabIndex = 5
        Me.btnUpdatelist.Text = "Update devices list"
        Me.btnUpdatelist.UseVisualStyleBackColor = True
        '
        'lblDevlist
        '
        Me.lblDevlist.AutoSize = True
        Me.lblDevlist.Location = New System.Drawing.Point(13, 162)
        Me.lblDevlist.Name = "lblDevlist"
        Me.lblDevlist.Size = New System.Drawing.Size(61, 13)
        Me.lblDevlist.TabIndex = 6
        Me.lblDevlist.Text = "Devices list"
        '
        'btnOn
        '
        Me.btnOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOn.Location = New System.Drawing.Point(13, 394)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(75, 23)
        Me.btnOn.TabIndex = 7
        Me.btnOn.Text = "Turn on"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOff.Location = New System.Drawing.Point(97, 394)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 8
        Me.btnOff.Text = "Turn off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'DeviceName
        '
        Me.DeviceName.Text = "Name"
        Me.DeviceName.Width = 94
        '
        'DeviceStaus
        '
        Me.DeviceStaus.Text = "Status"
        Me.DeviceStaus.Width = 49
        '
        'DeviceID
        '
        Me.DeviceID.Text = "ID"
        Me.DeviceID.Width = 143
        '
        'DeviceURL
        '
        Me.DeviceURL.Text = "URL"
        '
        'listviewDevices
        '
        Me.listviewDevices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listviewDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DeviceName, Me.DeviceStaus, Me.DeviceID, Me.DeviceURL, Me.DeviceState})
        Me.listviewDevices.ContextMenuStrip = Me.RightClickCopy
        Me.listviewDevices.FullRowSelect = True
        Me.listviewDevices.GridLines = True
        Me.listviewDevices.HideSelection = False
        Me.listviewDevices.Location = New System.Drawing.Point(13, 178)
        Me.listviewDevices.Name = "listviewDevices"
        Me.listviewDevices.Size = New System.Drawing.Size(429, 184)
        Me.listviewDevices.TabIndex = 12
        Me.listviewDevices.UseCompatibleStateImageBehavior = False
        Me.listviewDevices.View = System.Windows.Forms.View.Details
        '
        'DeviceState
        '
        Me.DeviceState.Text = "On/Off"
        '
        'RightClickCopy
        '
        Me.RightClickCopy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.RightClickCopy.Name = "RightClickCopy"
        Me.RightClickCopy.Size = New System.Drawing.Size(184, 26)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(183, 22)
        Me.ToolStripMenuItem1.Text = "Copy ID to clipboard"
        '
        'dbgMode
        '
        Me.dbgMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dbgMode.AutoSize = True
        Me.dbgMode.Location = New System.Drawing.Point(12, 435)
        Me.dbgMode.Name = "dbgMode"
        Me.dbgMode.Size = New System.Drawing.Size(87, 17)
        Me.dbgMode.TabIndex = 13
        Me.dbgMode.Text = "Debug mode"
        Me.dbgMode.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(255, 82)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(182, 20)
        Me.txtPassword.TabIndex = 14
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Location = New System.Drawing.Point(9, 48)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(123, 13)
        Me.lblStep1.TabIndex = 15
        Me.lblStep1.Text = "Step 1) Enter credentials"
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Location = New System.Drawing.Point(12, 149)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(118, 13)
        Me.lblStep2.TabIndex = 15
        Me.lblStep2.Text = "Step 2) Select a device"
        '
        'lblStep3
        '
        Me.lblStep3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblStep3.AutoSize = True
        Me.lblStep3.Location = New System.Drawing.Point(14, 378)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(135, 13)
        Me.lblStep3.TabIndex = 15
        Me.lblStep3.Text = "Step 3) Send it a command"
        '
        'btnCreateSettings
        '
        Me.btnCreateSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateSettings.Location = New System.Drawing.Point(179, 394)
        Me.btnCreateSettings.Name = "btnCreateSettings"
        Me.btnCreateSettings.Size = New System.Drawing.Size(204, 23)
        Me.btnCreateSettings.TabIndex = 17
        Me.btnCreateSettings.Text = "Create settings for device"
        Me.btnCreateSettings.UseVisualStyleBackColor = True
        Me.btnCreateSettings.Visible = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "WiFi Switch"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(104, 48)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.Location = New System.Drawing.Point(358, 463)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(84, 23)
        Me.btnQuit.TabIndex = 18
        Me.btnQuit.Text = "Quit Program"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'StartInTray
        '
        Me.StartInTray.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartInTray.AutoSize = True
        Me.StartInTray.Location = New System.Drawing.Point(12, 468)
        Me.StartInTray.Name = "StartInTray"
        Me.StartInTray.Size = New System.Drawing.Size(114, 17)
        Me.StartInTray.TabIndex = 19
        Me.StartInTray.Text = "Start in system tray"
        Me.StartInTray.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 498)
        Me.Controls.Add(Me.StartInTray)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnCreateSettings)
        Me.Controls.Add(Me.lblStep0)
        Me.Controls.Add(Me.lblStep3)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.dbgMode)
        Me.Controls.Add(Me.listviewDevices)
        Me.Controls.Add(Me.btnOff)
        Me.Controls.Add(Me.btnOn)
        Me.Controls.Add(Me.lblDevlist)
        Me.Controls.Add(Me.btnUpdatelist)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtEmail)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "TP-Link HS100 WiFi Socket Controller"
        Me.RightClickCopy.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblStep0 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnUpdatelist As System.Windows.Forms.Button
    Friend WithEvents lblDevlist As System.Windows.Forms.Label
    Friend WithEvents btnOn As System.Windows.Forms.Button
    Friend WithEvents btnOff As System.Windows.Forms.Button
    Friend WithEvents DeviceName As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceStaus As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceID As System.Windows.Forms.ColumnHeader
    Friend WithEvents DeviceURL As System.Windows.Forms.ColumnHeader
    Friend WithEvents listviewDevices As System.Windows.Forms.ListView
    Friend WithEvents dbgMode As System.Windows.Forms.CheckBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents lblStep3 As System.Windows.Forms.Label
    Friend WithEvents btnCreateSettings As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeviceState As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StartInTray As System.Windows.Forms.CheckBox
    Friend WithEvents RightClickCopy As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem

End Class
