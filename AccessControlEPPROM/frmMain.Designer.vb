<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.cobSerialPorts = New System.Windows.Forms.ComboBox()
        Me.spEPPROM = New System.IO.Ports.SerialPort(Me.components)
        Me.lblComPort = New System.Windows.Forms.Label()
        Me.butConnect = New System.Windows.Forms.Button()
        Me.txtDebug = New System.Windows.Forms.TextBox()
        Me.dgvEPPROM = New System.Windows.Forms.DataGridView()
        Me.MemNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RFIDTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Changed = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.butReadEPPROM = New System.Windows.Forms.Button()
        Me.stsMain = New System.Windows.Forms.StatusStrip()
        Me.pbrMain = New System.Windows.Forms.ToolStripProgressBar()
        Me.butWipe = New System.Windows.Forms.Button()
        Me.butWriteEEPROM = New System.Windows.Forms.Button()
        Me.nudFrom = New System.Windows.Forms.NumericUpDown()
        Me.nudTo = New System.Windows.Forms.NumericUpDown()
        Me.lblFromTag = New System.Windows.Forms.Label()
        Me.lblToTag = New System.Windows.Forms.Label()
        Me.gbxReadEEPROM = New System.Windows.Forms.GroupBox()
        Me.gbxConnect = New System.Windows.Forms.GroupBox()
        Me.butComRefresh = New System.Windows.Forms.Button()
        Me.butDisconnect = New System.Windows.Forms.Button()
        Me.butLoadTags = New System.Windows.Forms.Button()
        Me.ofdRFIDTags = New System.Windows.Forms.OpenFileDialog()
        Me.tssSpace = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssStatues = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvEPPROM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stsMain.SuspendLayout()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxReadEEPROM.SuspendLayout()
        Me.gbxConnect.SuspendLayout()
        Me.SuspendLayout()
        '
        'cobSerialPorts
        '
        Me.cobSerialPorts.FormattingEnabled = True
        Me.cobSerialPorts.Location = New System.Drawing.Point(63, 23)
        Me.cobSerialPorts.Name = "cobSerialPorts"
        Me.cobSerialPorts.Size = New System.Drawing.Size(97, 21)
        Me.cobSerialPorts.TabIndex = 0
        '
        'spEPPROM
        '
        '
        'lblComPort
        '
        Me.lblComPort.AutoSize = True
        Me.lblComPort.Location = New System.Drawing.Point(6, 26)
        Me.lblComPort.Name = "lblComPort"
        Me.lblComPort.Size = New System.Drawing.Size(51, 13)
        Me.lblComPort.TabIndex = 1
        Me.lblComPort.Text = "Com Port"
        '
        'butConnect
        '
        Me.butConnect.Location = New System.Drawing.Point(206, 15)
        Me.butConnect.Name = "butConnect"
        Me.butConnect.Size = New System.Drawing.Size(82, 36)
        Me.butConnect.TabIndex = 2
        Me.butConnect.Text = "C&onnect"
        Me.butConnect.UseVisualStyleBackColor = True
        '
        'txtDebug
        '
        Me.txtDebug.BackColor = System.Drawing.SystemColors.Window
        Me.txtDebug.Location = New System.Drawing.Point(400, 217)
        Me.txtDebug.Multiline = True
        Me.txtDebug.Name = "txtDebug"
        Me.txtDebug.ReadOnly = True
        Me.txtDebug.Size = New System.Drawing.Size(298, 121)
        Me.txtDebug.TabIndex = 3
        Me.txtDebug.Visible = False
        '
        'dgvEPPROM
        '
        Me.dgvEPPROM.AllowUserToAddRows = False
        Me.dgvEPPROM.AllowUserToDeleteRows = False
        Me.dgvEPPROM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEPPROM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MemNum, Me.RFIDTag, Me.Changed})
        Me.dgvEPPROM.Location = New System.Drawing.Point(12, 12)
        Me.dgvEPPROM.MultiSelect = False
        Me.dgvEPPROM.Name = "dgvEPPROM"
        Me.dgvEPPROM.Size = New System.Drawing.Size(365, 326)
        Me.dgvEPPROM.TabIndex = 4
        '
        'MemNum
        '
        Me.MemNum.Frozen = True
        Me.MemNum.HeaderText = "Memory Number"
        Me.MemNum.Name = "MemNum"
        Me.MemNum.ReadOnly = True
        Me.MemNum.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'RFIDTag
        '
        Me.RFIDTag.HeaderText = "RFID Tag"
        Me.RFIDTag.MaxInputLength = 10
        Me.RFIDTag.Name = "RFIDTag"
        Me.RFIDTag.Width = 200
        '
        'Changed
        '
        Me.Changed.FalseValue = "0"
        Me.Changed.HeaderText = "Changed"
        Me.Changed.IndeterminateValue = "0"
        Me.Changed.Name = "Changed"
        Me.Changed.ReadOnly = True
        Me.Changed.TrueValue = "1"
        Me.Changed.Visible = False
        '
        'butReadEPPROM
        '
        Me.butReadEPPROM.Location = New System.Drawing.Point(206, 24)
        Me.butReadEPPROM.Name = "butReadEPPROM"
        Me.butReadEPPROM.Size = New System.Drawing.Size(82, 46)
        Me.butReadEPPROM.TabIndex = 5
        Me.butReadEPPROM.Text = "&Read"
        Me.butReadEPPROM.UseVisualStyleBackColor = True
        '
        'stsMain
        '
        Me.stsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.pbrMain, Me.tssSpace, Me.tssStatues})
        Me.stsMain.Location = New System.Drawing.Point(0, 350)
        Me.stsMain.Name = "stsMain"
        Me.stsMain.Size = New System.Drawing.Size(713, 22)
        Me.stsMain.TabIndex = 7
        Me.stsMain.Text = "StatusStrip1"
        '
        'pbrMain
        '
        Me.pbrMain.Name = "pbrMain"
        Me.pbrMain.Size = New System.Drawing.Size(100, 16)
        '
        'butWipe
        '
        Me.butWipe.Enabled = False
        Me.butWipe.Location = New System.Drawing.Point(400, 171)
        Me.butWipe.Name = "butWipe"
        Me.butWipe.Size = New System.Drawing.Size(85, 27)
        Me.butWipe.TabIndex = 8
        Me.butWipe.Text = "Wi&pe"
        Me.butWipe.UseVisualStyleBackColor = True
        '
        'butWriteEEPROM
        '
        Me.butWriteEEPROM.Enabled = False
        Me.butWriteEEPROM.Location = New System.Drawing.Point(616, 170)
        Me.butWriteEEPROM.Name = "butWriteEEPROM"
        Me.butWriteEEPROM.Size = New System.Drawing.Size(82, 28)
        Me.butWriteEEPROM.TabIndex = 9
        Me.butWriteEEPROM.Text = "&Write"
        Me.butWriteEEPROM.UseVisualStyleBackColor = True
        '
        'nudFrom
        '
        Me.nudFrom.Location = New System.Drawing.Point(63, 22)
        Me.nudFrom.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudFrom.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudFrom.Name = "nudFrom"
        Me.nudFrom.Size = New System.Drawing.Size(80, 20)
        Me.nudFrom.TabIndex = 10
        Me.nudFrom.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudTo
        '
        Me.nudTo.Location = New System.Drawing.Point(63, 48)
        Me.nudTo.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudTo.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudTo.Name = "nudTo"
        Me.nudTo.Size = New System.Drawing.Size(80, 20)
        Me.nudTo.TabIndex = 11
        Me.nudTo.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblFromTag
        '
        Me.lblFromTag.AutoSize = True
        Me.lblFromTag.Location = New System.Drawing.Point(26, 24)
        Me.lblFromTag.Name = "lblFromTag"
        Me.lblFromTag.Size = New System.Drawing.Size(31, 13)
        Me.lblFromTag.TabIndex = 12
        Me.lblFromTag.Text = "From"
        '
        'lblToTag
        '
        Me.lblToTag.AutoSize = True
        Me.lblToTag.Location = New System.Drawing.Point(38, 50)
        Me.lblToTag.Name = "lblToTag"
        Me.lblToTag.Size = New System.Drawing.Size(19, 13)
        Me.lblToTag.TabIndex = 13
        Me.lblToTag.Text = "To"
        '
        'gbxReadEEPROM
        '
        Me.gbxReadEEPROM.Controls.Add(Me.butReadEPPROM)
        Me.gbxReadEEPROM.Controls.Add(Me.lblToTag)
        Me.gbxReadEEPROM.Controls.Add(Me.nudFrom)
        Me.gbxReadEEPROM.Controls.Add(Me.lblFromTag)
        Me.gbxReadEEPROM.Controls.Add(Me.nudTo)
        Me.gbxReadEEPROM.Enabled = False
        Me.gbxReadEEPROM.Location = New System.Drawing.Point(400, 74)
        Me.gbxReadEEPROM.Name = "gbxReadEEPROM"
        Me.gbxReadEEPROM.Size = New System.Drawing.Size(298, 83)
        Me.gbxReadEEPROM.TabIndex = 14
        Me.gbxReadEEPROM.TabStop = False
        Me.gbxReadEEPROM.Text = "Read"
        '
        'gbxConnect
        '
        Me.gbxConnect.Controls.Add(Me.butComRefresh)
        Me.gbxConnect.Controls.Add(Me.cobSerialPorts)
        Me.gbxConnect.Controls.Add(Me.lblComPort)
        Me.gbxConnect.Controls.Add(Me.butConnect)
        Me.gbxConnect.Controls.Add(Me.butDisconnect)
        Me.gbxConnect.Location = New System.Drawing.Point(400, 12)
        Me.gbxConnect.Name = "gbxConnect"
        Me.gbxConnect.Size = New System.Drawing.Size(298, 57)
        Me.gbxConnect.TabIndex = 15
        Me.gbxConnect.TabStop = False
        Me.gbxConnect.Text = "Connect"
        '
        'butComRefresh
        '
        Me.butComRefresh.AutoEllipsis = True
        Me.butComRefresh.BackgroundImage = Global.AccessControlEPPROM.My.Resources.Resources.arrow_refresh
        Me.butComRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.butComRefresh.Location = New System.Drawing.Point(165, 15)
        Me.butComRefresh.Name = "butComRefresh"
        Me.butComRefresh.Size = New System.Drawing.Size(35, 36)
        Me.butComRefresh.TabIndex = 4
        Me.butComRefresh.UseVisualStyleBackColor = True
        '
        'butDisconnect
        '
        Me.butDisconnect.Location = New System.Drawing.Point(206, 15)
        Me.butDisconnect.Name = "butDisconnect"
        Me.butDisconnect.Size = New System.Drawing.Size(82, 36)
        Me.butDisconnect.TabIndex = 3
        Me.butDisconnect.Text = "&Disconnect"
        Me.butDisconnect.UseVisualStyleBackColor = True
        Me.butDisconnect.Visible = False
        '
        'butLoadTags
        '
        Me.butLoadTags.Enabled = False
        Me.butLoadTags.Location = New System.Drawing.Point(508, 170)
        Me.butLoadTags.Name = "butLoadTags"
        Me.butLoadTags.Size = New System.Drawing.Size(85, 28)
        Me.butLoadTags.TabIndex = 16
        Me.butLoadTags.Text = "Load"
        Me.butLoadTags.UseVisualStyleBackColor = True
        '
        'ofdRFIDTags
        '
        Me.ofdRFIDTags.DefaultExt = "txt"
        Me.ofdRFIDTags.Filter = "TXT File|*.txt"
        Me.ofdRFIDTags.Title = "Load RFID Tag text file"
        '
        'tssSpace
        '
        Me.tssSpace.Name = "tssSpace"
        Me.tssSpace.Size = New System.Drawing.Size(526, 17)
        Me.tssSpace.Spring = True
        '
        'tssStatues
        '
        Me.tssStatues.Name = "tssStatues"
        Me.tssStatues.Size = New System.Drawing.Size(39, 17)
        Me.tssStatues.Text = "Ready"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 372)
        Me.Controls.Add(Me.butLoadTags)
        Me.Controls.Add(Me.butWriteEEPROM)
        Me.Controls.Add(Me.butWipe)
        Me.Controls.Add(Me.gbxConnect)
        Me.Controls.Add(Me.gbxReadEEPROM)
        Me.Controls.Add(Me.txtDebug)
        Me.Controls.Add(Me.stsMain)
        Me.Controls.Add(Me.dgvEPPROM)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Text = "Access Control EPPROM"
        CType(Me.dgvEPPROM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stsMain.ResumeLayout(False)
        Me.stsMain.PerformLayout()
        CType(Me.nudFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxReadEEPROM.ResumeLayout(False)
        Me.gbxReadEEPROM.PerformLayout()
        Me.gbxConnect.ResumeLayout(False)
        Me.gbxConnect.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cobSerialPorts As System.Windows.Forms.ComboBox
    Friend WithEvents spEPPROM As System.IO.Ports.SerialPort
    Friend WithEvents lblComPort As System.Windows.Forms.Label
    Friend WithEvents butConnect As System.Windows.Forms.Button
    Friend WithEvents txtDebug As System.Windows.Forms.TextBox
    Friend WithEvents dgvEPPROM As System.Windows.Forms.DataGridView
    Friend WithEvents butReadEPPROM As System.Windows.Forms.Button
    Friend WithEvents stsMain As System.Windows.Forms.StatusStrip
    Friend WithEvents pbrMain As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents butWipe As System.Windows.Forms.Button
    Friend WithEvents butWriteEEPROM As System.Windows.Forms.Button
    Friend WithEvents MemNum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RFIDTag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Changed As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents nudFrom As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudTo As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblFromTag As System.Windows.Forms.Label
    Friend WithEvents lblToTag As System.Windows.Forms.Label
    Friend WithEvents gbxReadEEPROM As System.Windows.Forms.GroupBox
    Friend WithEvents gbxConnect As System.Windows.Forms.GroupBox
    Friend WithEvents butDisconnect As System.Windows.Forms.Button
    Friend WithEvents butLoadTags As System.Windows.Forms.Button
    Friend WithEvents ofdRFIDTags As System.Windows.Forms.OpenFileDialog
    Friend WithEvents butComRefresh As System.Windows.Forms.Button
    Friend WithEvents tssSpace As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tssStatues As System.Windows.Forms.ToolStripStatusLabel

End Class
