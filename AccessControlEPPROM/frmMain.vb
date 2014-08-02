Public Class frmMain
    Dim RecvData As String
    Dim DataUpdateMonitor As Boolean
    'Coversation sample
    'int i = 33;
    'string binary = Convert.ToString(i, 2);
    'string hex = Convert.ToString(i, 16);
    'int binaryToInt = Convert.ToInt32(binary, 2);
    'int hexToInt = Convert.ToInt32(hex, 16);

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            GetSerialPortNames()
        Catch
            MsgBox("No ports seem to be connected.")
        End Try
    End Sub

    Private Sub GetSerialPortNames()
        If cobSerialPorts.Items.Count > 0 Then
            cobSerialPorts.Items.Clear()
        End If
        For Each sp In My.Computer.Ports.SerialPortNames
            cobSerialPorts.Items.Add(sp)
        Next
    End Sub

    Private Sub spEPPROM_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles spEPPROM.DataReceived
        RecvData = ""
        RecvData = spEPPROM.ReadLine()
        'If txtDebug.InvokeRequired Then
        '    txtDebug.BeginInvoke(New Action(Of String)(AddressOf txtDebug.AppendText), RecvData + Chr(10))
        'Else
        '    txtDebug.AppendText(RecvData + Chr(10))
        'End If
    End Sub

    Private Sub butConnect_Click(sender As Object, e As EventArgs) Handles butConnect.Click
        If spEPPROM.IsOpen Then
            txtDebug.AppendText("Already Connected" + Chr(10))
            Exit Sub
        End If
        If IsNothing(cobSerialPorts.SelectedItem) Then
            MsgBox("No COM port selected")
            txtDebug.AppendText("No COM port selected" + Chr(10))
            Exit Sub
        End If
        spEPPROM.PortName = cobSerialPorts.SelectedItem.ToString()
        spEPPROM.BaudRate = "9600"
        Try
            spEPPROM.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        If spEPPROM.IsOpen Then
            gbxReadEEPROM.Enabled = True
            butComRefresh.Enabled = False
            butWipe.Enabled = True
            butLoadTags.Enabled = True
            butConnect.Visible = False
            butDisconnect.Visible = True
            cobSerialPorts.Enabled = False
            txtDebug.AppendText("Connected" + Chr(10))
        Else
            txtDebug.AppendText("Not Connected" + Chr(10))
        End If
    End Sub

    Private Sub butDisconnect_Click(sender As Object, e As EventArgs) Handles butDisconnect.Click
        spEPPROM.Close()
        
        gbxReadEEPROM.Enabled = False
        butComRefresh.Enabled = True
        butWipe.Enabled = False
        butLoadTags.Enabled = False
        butConnect.Visible = True
        butDisconnect.Visible = False
        cobSerialPorts.Enabled = True
    End Sub

    Private Sub butComRefresh_Click(sender As Object, e As EventArgs) Handles butComRefresh.Click
        Try
            GetSerialPortNames()
        Catch
            MsgBox("No ports seem to be connected.")
        End Try
    End Sub

    Private Sub butReadEPPROM_Click(sender As Object, e As EventArgs) Handles butReadEPPROM.Click
        Dim TagNum As Int32, ProgressPrecent As Int32, TotalTags As Int32
        Dim TagNumStr As String

        gbxReadEEPROM.Enabled = False
        DataUpdateMonitor = False 'Stop monitor data change while filling from EEPROM

        dgvEPPROM.Rows.Clear()

        TotalTags = nudTo.Value - nudFrom.Value + 1
        For Tags As Int32 = nudFrom.Value To nudTo.Value
            TagNum = ReadTagFromEEPROM(Tags)
            If TagNum = -1 Then TagNum = 0
            TagNumStr = Strings.Left("0000000000", 10 - Strings.Len(TagNum.ToString())) + TagNum.ToString()
            dgvEPPROM.Rows.Add(Tags, TagNumStr, vbFalse)
            ProgressPrecent = ProgressPrecent + 1
            'pbrMain.Value = (ProgressPrecent / TotalTags) * 100
        Next
        'System.Threading.Thread.Sleep(70)
        gbxReadEEPROM.Enabled = True
        DataUpdateMonitor = True 'resume monitor data change
    End Sub

    Private Sub butWriteEEPROM_Click(sender As Object, e As EventArgs) Handles butWriteEEPROM.Click
        
        butWriteEEPROM.Enabled = False
        pbrMain.Maximum = dgvEPPROM.Rows.Count.ToString
        pbrMain.Value = 0
        For Each alfRow As DataGridViewRow In dgvEPPROM.Rows
            If alfRow.Cells("Changed").Value = True Then
                If WriteTagInEEPROM(Convert.ToInt32(alfRow.Cells("MemNum").Value), alfRow.Cells("RFIDTag").Value) = False Then
                    MsgBox("Write error aborting")
                    Exit Sub
                End If
            End If
            pbrMain.Value = alfRow.Index
        Next
    End Sub

    Private Sub butWipe_Click(sender As Object, e As EventArgs) Handles butWipe.Click
        Me.Enabled = False
        WipeEEPROM()
        Me.Enabled = True
    End Sub

    Private Sub butLoadTags_Click(sender As Object, e As EventArgs) Handles butLoadTags.Click
        ofdRFIDTags.ShowDialog()
        If ofdRFIDTags.FileName = "" Then
            MsgBox("No file selected")
            Exit Sub
        End If

        For Each line As String In System.IO.File.ReadAllLines(ofdRFIDTags.FileName)
            If IsNumeric(line) = False Then
                MsgBox("Invalid file please check values and try agian")
                Exit Sub
            End If
        Next

        Dim linenumber As Int32
        For Each line As String In System.IO.File.ReadAllLines(ofdRFIDTags.FileName)
            linenumber = linenumber + 1
            dgvEPPROM.Rows.Add(linenumber, line.Trim(Chr(10)), vbTrue)
        Next
        butWriteEEPROM.Enabled = True
    End Sub

    Private Sub dgvEPPROM_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEPPROM.CellValueChanged
        If DataUpdateMonitor = False Then Exit Sub
        dgvEPPROM.Rows(e.RowIndex).Cells("Changed").Value = vbTrue
        If butWriteEEPROM.Enabled = False Then butWriteEEPROM.Enabled = True
    End Sub

    Private Sub nudFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudFrom.ValueChanged
        If nudFrom.Value > nudTo.Value Then
            nudTo.Value = nudFrom.Value
        End If
    End Sub

    Private Sub nudTo_ValueChanged(sender As Object, e As EventArgs) Handles nudTo.ValueChanged
        If nudTo.Value < nudFrom.Value Then
            nudFrom.Value = nudTo.Value
        End If
    End Sub

    Private Function WriteTagInEEPROM(TagNum As Int32, TagData As String) As Boolean

        Dim firstByte As Int32, lastByte As Int32, TagDataInt As Int32, spWriteData(3) As Int32, spWriteDataCount As Int32
        Dim spCMD As String, TagDataHex As String, TagDataHexID(3) As String
        Dim TaxDataHex0 As Int32 'To avoid Mid function error at TagHexDataID0 when Strings.Len(TagDataHex) - 3 < 0

        TagDataInt = Convert.ToInt32(TagData)
        TagDataHex = Convert.ToString(TagDataInt, 16)

        TagDataHexID(1) = Strings.Right(TagDataHex, 2)

        TaxDataHex0 = Strings.Len(TagDataHex) - 3
        If TaxDataHex0 < 0 Then TaxDataHex0 = 1
        TagDataHexID(0) = Strings.Mid(TagDataHex, TaxDataHex0, 2)
        If (TagDataHex.Length - 4) = 2 Then
            TagDataHexID(2) = Strings.Left(TagDataHex, 2)
            TagDataHexID(3) = "00"
        ElseIf (TagDataHex.Length - 4) = 3 Then
            TagDataHexID(2) = Strings.Mid(TagDataHex, 2, 2)
            TagDataHexID(3) = Strings.Left(TagDataHex, 1)
        ElseIf (TagDataHex.Length - 4) = 4 Then
            TagDataHexID(2) = Strings.Mid(TagDataHex, 3, 2)
            TagDataHexID(3) = Strings.Left(TagDataHex, 2)
        Else
            TagDataHexID(2) = "00"
            TagDataHexID(3) = "00"
        End If

        For Dum As Integer = 0 To 3
            spWriteData(Dum) = Convert.ToInt32(TagDataHexID(Dum), 16)
        Next

        firstByte = (TagNum - 1) * 4
        lastByte = firstByte + 3

        spWriteDataCount = 0

        For WriteByte As Int32 = firstByte To lastByte
            spCMD = "write " + WriteByte.ToString() + " " + spWriteData(spWriteDataCount).ToString() + Chr(10)
            spEPPROM.WriteLine(spCMD)
            System.Threading.Thread.Sleep(70) 'Wait so result appear in serial
            System.Windows.Forms.Application.DoEvents()
            spWriteDataCount = spWriteDataCount + 1
            If RecvData.CompareTo("Done") = True Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Function ReadTagFromEEPROM(TagNum As Int32) As Int32

        Dim firstByte As Int32, lastByte As Int32, spResultCount As Int32
        Dim spCMD As String, spResult As String, spResultCol(3) As Int32, spResultFix(3) As String

        firstByte = (TagNum - 1) * 4
        lastByte = firstByte + 3
        spResultCount = 0

        For ReadByte As Int32 = firstByte To lastByte
            spCMD = "read " + ReadByte.ToString + Chr(10)
            spEPPROM.WriteLine(spCMD)
            System.Threading.Thread.Sleep(70) 'Wait so result appear in serial
            System.Windows.Forms.Application.DoEvents()
            spResultCol(spResultCount) = Convert.ToInt32(RecvData)
            spResultCount = spResultCount + 1
        Next

        For Dum As Int32 = 0 To 3
            spResultFix(Dum) = Convert.ToString(spResultCol(Dum), 16)
            If spResultFix(Dum).Length < 2 Then spResultFix(Dum) = "0" & spResultFix(Dum)
        Next

        spResult = spResultFix(3) & spResultFix(2) & spResultFix(0) & spResultFix(1)

        'txtDebug.AppendText(spResult + Chr(10))
        Return Convert.ToInt32(spResult, 16)
    End Function

    Private Function WipeEEPROM()
        Dim spCMD As String
        spCMD = "wipe"
        spEPPROM.WriteLine(spCMD)
Wait_For_Wipe:
        System.Threading.Thread.Sleep(70) 'Wait so result appear in serial
        System.Windows.Forms.Application.DoEvents()
        If RecvData = "wiped!" & vbCr & "" Then
            MsgBox("Done EEPROM is now clear", MsgBoxStyle.Information)
        Else
            GoTo Wait_For_Wipe
        End If

    End Function

End Class
