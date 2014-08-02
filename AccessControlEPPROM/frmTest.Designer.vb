<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.txtTagNumber = New System.Windows.Forms.TextBox()
        Me.txtHexByte0 = New System.Windows.Forms.TextBox()
        Me.txtHexByte1 = New System.Windows.Forms.TextBox()
        Me.txtHexByte2 = New System.Windows.Forms.TextBox()
        Me.txtHexByte3 = New System.Windows.Forms.TextBox()
        Me.btnToHex = New System.Windows.Forms.Button()
        Me.btnToTag = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTagNumber
        '
        Me.txtTagNumber.Location = New System.Drawing.Point(57, 56)
        Me.txtTagNumber.Name = "txtTagNumber"
        Me.txtTagNumber.Size = New System.Drawing.Size(195, 20)
        Me.txtTagNumber.TabIndex = 0
        '
        'txtHexByte0
        '
        Me.txtHexByte0.Location = New System.Drawing.Point(57, 98)
        Me.txtHexByte0.Name = "txtHexByte0"
        Me.txtHexByte0.Size = New System.Drawing.Size(100, 20)
        Me.txtHexByte0.TabIndex = 1
        '
        'txtHexByte1
        '
        Me.txtHexByte1.Location = New System.Drawing.Point(163, 98)
        Me.txtHexByte1.Name = "txtHexByte1"
        Me.txtHexByte1.Size = New System.Drawing.Size(100, 20)
        Me.txtHexByte1.TabIndex = 2
        '
        'txtHexByte2
        '
        Me.txtHexByte2.Location = New System.Drawing.Point(269, 98)
        Me.txtHexByte2.Name = "txtHexByte2"
        Me.txtHexByte2.Size = New System.Drawing.Size(100, 20)
        Me.txtHexByte2.TabIndex = 3
        '
        'txtHexByte3
        '
        Me.txtHexByte3.Location = New System.Drawing.Point(375, 98)
        Me.txtHexByte3.Name = "txtHexByte3"
        Me.txtHexByte3.Size = New System.Drawing.Size(100, 20)
        Me.txtHexByte3.TabIndex = 4
        '
        'btnToHex
        '
        Me.btnToHex.Location = New System.Drawing.Point(258, 56)
        Me.btnToHex.Name = "btnToHex"
        Me.btnToHex.Size = New System.Drawing.Size(75, 23)
        Me.btnToHex.TabIndex = 5
        Me.btnToHex.Text = "To Hex"
        Me.btnToHex.UseVisualStyleBackColor = True
        '
        'btnToTag
        '
        Me.btnToTag.Location = New System.Drawing.Point(494, 98)
        Me.btnToTag.Name = "btnToTag"
        Me.btnToTag.Size = New System.Drawing.Size(75, 23)
        Me.btnToTag.TabIndex = 6
        Me.btnToTag.Text = "To Tag"
        Me.btnToTag.UseVisualStyleBackColor = True
        '
        'frmTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 453)
        Me.Controls.Add(Me.btnToTag)
        Me.Controls.Add(Me.btnToHex)
        Me.Controls.Add(Me.txtHexByte3)
        Me.Controls.Add(Me.txtHexByte2)
        Me.Controls.Add(Me.txtHexByte1)
        Me.Controls.Add(Me.txtHexByte0)
        Me.Controls.Add(Me.txtTagNumber)
        Me.Name = "frmTest"
        Me.Text = "frmTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTagNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtHexByte0 As System.Windows.Forms.TextBox
    Friend WithEvents txtHexByte1 As System.Windows.Forms.TextBox
    Friend WithEvents txtHexByte2 As System.Windows.Forms.TextBox
    Friend WithEvents txtHexByte3 As System.Windows.Forms.TextBox
    Friend WithEvents btnToHex As System.Windows.Forms.Button
    Friend WithEvents btnToTag As System.Windows.Forms.Button
End Class
