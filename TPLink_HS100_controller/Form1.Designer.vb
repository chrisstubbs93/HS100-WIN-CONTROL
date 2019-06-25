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
        Me.OnDelay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.OffDelay = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.lblQueuetitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExtend = New System.Windows.Forms.Button()
        Me.btnQueue = New System.Windows.Forms.Button()
        Me.sec = New System.Windows.Forms.NumericUpDown()
        Me.min = New System.Windows.Forms.NumericUpDown()
        Me.hrs = New System.Windows.Forms.NumericUpDown()
        Me.comboQueuestatus = New System.Windows.Forms.ComboBox()
        Me.comboDeviceQueueList = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblQueueafter = New System.Windows.Forms.Label()
        Me.lblQueueturn = New System.Windows.Forms.Label()
        Me.tick = New System.Windows.Forms.Timer(Me.components)
        Me.StartWithWin = New System.Windows.Forms.CheckBox()
        Me.RightClickCopy.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.sec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hrs, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnOn.Location = New System.Drawing.Point(13, 407)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(75, 23)
        Me.btnOn.TabIndex = 7
        Me.btnOn.Text = "Turn on"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOff.Location = New System.Drawing.Point(97, 407)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(75, 23)
        Me.btnOff.TabIndex = 8
        Me.btnOff.Text = "Turn off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'DeviceName
        '
        Me.DeviceName.Text = "Name"
        Me.DeviceName.Width = 110
        '
        'DeviceStaus
        '
        Me.DeviceStaus.Text = "Status"
        Me.DeviceStaus.Width = 45
        '
        'DeviceID
        '
        Me.DeviceID.Text = "ID"
        Me.DeviceID.Width = 180
        '
        'DeviceURL
        '
        Me.DeviceURL.Text = "URL"
        Me.DeviceURL.Width = 50
        '
        'listviewDevices
        '
        Me.listviewDevices.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listviewDevices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DeviceName, Me.DeviceStaus, Me.DeviceID, Me.DeviceURL, Me.DeviceState, Me.OnDelay, Me.OffDelay})
        Me.listviewDevices.ContextMenuStrip = Me.RightClickCopy
        Me.listviewDevices.FullRowSelect = True
        Me.listviewDevices.GridLines = True
        Me.listviewDevices.HideSelection = False
        Me.listviewDevices.Location = New System.Drawing.Point(13, 178)
        Me.listviewDevices.MultiSelect = False
        Me.listviewDevices.Name = "listviewDevices"
        Me.listviewDevices.Size = New System.Drawing.Size(607, 199)
        Me.listviewDevices.TabIndex = 12
        Me.listviewDevices.UseCompatibleStateImageBehavior = False
        Me.listviewDevices.View = System.Windows.Forms.View.Details
        '
        'DeviceState
        '
        Me.DeviceState.Text = "On/Off"
        Me.DeviceState.Width = 50
        '
        'OnDelay
        '
        Me.OnDelay.Text = "OnDelay"
        Me.OnDelay.Width = 80
        '
        'OffDelay
        '
        Me.OffDelay.Text = "OffDelay"
        Me.OffDelay.Width = 80
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
        Me.dbgMode.Location = New System.Drawing.Point(307, 528)
        Me.dbgMode.Name = "dbgMode"
        Me.dbgMode.Size = New System.Drawing.Size(87, 17)
        Me.dbgMode.TabIndex = 13
        Me.dbgMode.Text = "Debug mode"
        Me.dbgMode.UseVisualStyleBackColor = True
        Me.dbgMode.Visible = False
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
        Me.lblStep3.Location = New System.Drawing.Point(14, 391)
        Me.lblStep3.Name = "lblStep3"
        Me.lblStep3.Size = New System.Drawing.Size(135, 13)
        Me.lblStep3.TabIndex = 15
        Me.lblStep3.Text = "Step 3) Send it a command"
        '
        'btnCreateSettings
        '
        Me.btnCreateSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateSettings.Location = New System.Drawing.Point(386, 407)
        Me.btnCreateSettings.Name = "btnCreateSettings"
        Me.btnCreateSettings.Size = New System.Drawing.Size(234, 23)
        Me.btnCreateSettings.TabIndex = 17
        Me.btnCreateSettings.Text = "Edit automatic startup/shutdown settings"
        Me.btnCreateSettings.UseVisualStyleBackColor = True
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
        Me.btnQuit.Location = New System.Drawing.Point(536, 524)
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
        Me.StartInTray.Location = New System.Drawing.Point(12, 529)
        Me.StartInTray.Name = "StartInTray"
        Me.StartInTray.Size = New System.Drawing.Size(114, 17)
        Me.StartInTray.TabIndex = 19
        Me.StartInTray.Text = "Start in system tray"
        Me.StartInTray.UseVisualStyleBackColor = True
        '
        'lblQueuetitle
        '
        Me.lblQueuetitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueuetitle.AutoSize = True
        Me.lblQueuetitle.Location = New System.Drawing.Point(14, 449)
        Me.lblQueuetitle.Name = "lblQueuetitle"
        Me.lblQueuetitle.Size = New System.Drawing.Size(93, 13)
        Me.lblQueuetitle.TabIndex = 20
        Me.lblQueuetitle.Text = "Queue commands"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btnExtend)
        Me.Panel1.Controls.Add(Me.btnQueue)
        Me.Panel1.Controls.Add(Me.sec)
        Me.Panel1.Controls.Add(Me.min)
        Me.Panel1.Controls.Add(Me.hrs)
        Me.Panel1.Controls.Add(Me.comboQueuestatus)
        Me.Panel1.Controls.Add(Me.comboDeviceQueueList)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblQueueafter)
        Me.Panel1.Controls.Add(Me.lblQueueturn)
        Me.Panel1.Location = New System.Drawing.Point(12, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(608, 38)
        Me.Panel1.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(541, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExtend
        '
        Me.btnExtend.Location = New System.Drawing.Point(484, 8)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.Size = New System.Drawing.Size(51, 23)
        Me.btnExtend.TabIndex = 25
        Me.btnExtend.Text = "Extend"
        Me.btnExtend.UseVisualStyleBackColor = True
        '
        'btnQueue
        '
        Me.btnQueue.Location = New System.Drawing.Point(430, 8)
        Me.btnQueue.Name = "btnQueue"
        Me.btnQueue.Size = New System.Drawing.Size(47, 23)
        Me.btnQueue.TabIndex = 24
        Me.btnQueue.Text = "Queue"
        Me.btnQueue.UseVisualStyleBackColor = True
        '
        'sec
        '
        Me.sec.Location = New System.Drawing.Point(374, 8)
        Me.sec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(37, 20)
        Me.sec.TabIndex = 23
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(315, 8)
        Me.min.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(37, 20)
        Me.min.TabIndex = 23
        '
        'hrs
        '
        Me.hrs.Location = New System.Drawing.Point(256, 8)
        Me.hrs.Name = "hrs"
        Me.hrs.Size = New System.Drawing.Size(37, 20)
        Me.hrs.TabIndex = 23
        '
        'comboQueuestatus
        '
        Me.comboQueuestatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboQueuestatus.FormattingEnabled = True
        Me.comboQueuestatus.Items.AddRange(New Object() {"Off", "On"})
        Me.comboQueuestatus.Location = New System.Drawing.Point(164, 8)
        Me.comboQueuestatus.Name = "comboQueuestatus"
        Me.comboQueuestatus.Size = New System.Drawing.Size(52, 21)
        Me.comboQueuestatus.TabIndex = 22
        '
        'comboDeviceQueueList
        '
        Me.comboDeviceQueueList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboDeviceQueueList.FormattingEnabled = True
        Me.comboDeviceQueueList.Location = New System.Drawing.Point(37, 8)
        Me.comboDeviceQueueList.Name = "comboDeviceQueueList"
        Me.comboDeviceQueueList.Size = New System.Drawing.Size(121, 21)
        Me.comboDeviceQueueList.TabIndex = 21
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(222, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "after"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "H :"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(410, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "S"
        '
        'lblQueueafter
        '
        Me.lblQueueafter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueueafter.AutoSize = True
        Me.lblQueueafter.Location = New System.Drawing.Point(351, 12)
        Me.lblQueueafter.Name = "lblQueueafter"
        Me.lblQueueafter.Size = New System.Drawing.Size(22, 13)
        Me.lblQueueafter.TabIndex = 20
        Me.lblQueueafter.Text = "M :"
        '
        'lblQueueturn
        '
        Me.lblQueueturn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblQueueturn.AutoSize = True
        Me.lblQueueturn.Location = New System.Drawing.Point(3, 11)
        Me.lblQueueturn.Name = "lblQueueturn"
        Me.lblQueueturn.Size = New System.Drawing.Size(32, 13)
        Me.lblQueueturn.TabIndex = 20
        Me.lblQueueturn.Text = "Turn "
        '
        'tick
        '
        Me.tick.Interval = 1000
        '
        'StartWithWin
        '
        Me.StartWithWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StartWithWin.AutoSize = True
        Me.StartWithWin.Location = New System.Drawing.Point(132, 528)
        Me.StartWithWin.Name = "StartWithWin"
        Me.StartWithWin.Size = New System.Drawing.Size(114, 17)
        Me.StartWithWin.TabIndex = 22
        Me.StartWithWin.Text = "Start with windows"
        Me.StartWithWin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 559)
        Me.Controls.Add(Me.StartWithWin)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblQueuetitle)
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.sec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.min, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hrs, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents OnDelay As System.Windows.Forms.ColumnHeader
    Friend WithEvents OffDelay As System.Windows.Forms.ColumnHeader
    Friend WithEvents lblQueuetitle As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblQueueturn As System.Windows.Forms.Label
    Friend WithEvents comboQueuestatus As System.Windows.Forms.ComboBox
    Friend WithEvents comboDeviceQueueList As System.Windows.Forms.ComboBox
    Friend WithEvents lblQueueafter As System.Windows.Forms.Label
    Friend WithEvents btnQueue As System.Windows.Forms.Button
    Friend WithEvents sec As System.Windows.Forms.NumericUpDown
    Friend WithEvents min As System.Windows.Forms.NumericUpDown
    Friend WithEvents hrs As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExtend As System.Windows.Forms.Button
    Friend WithEvents tick As System.Windows.Forms.Timer
    Friend WithEvents StartWithWin As System.Windows.Forms.CheckBox

End Class
