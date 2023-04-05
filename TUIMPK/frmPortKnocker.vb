'----------------------------------------------
'                                              |
'      TCP / UDP / ICMP Multi Port Knocker     |
'                                              |
' Created by Aethyl-chloride - C2H5Cl, Hungary |
'                                              |
'                  1983 - 2023                 |
'----------------------------------------------

Imports System.Text
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.IO
Imports System.Net
Imports System.Net.NetworkInformation

Public Class frmPortKnocker

    Public startVagyStop As Integer = 0
    Const klumpenStrasse As String = "VENQIC8gVURQIC8gSUNNUCBNdWx0aSBQb3J0IEtub2NrZXIgYnkgQzJINUNs="
    Const crAdefEc As String = "SmdANFs4LUhuOFZsbzYoZyliJDlnXTc2b3k5WC9WXXUwKTVlW3thaA=="
    Const crBdefEc As String = "RTR5RylqTjVsJDVCKl1rTQ=="
    Dim crAusrEc As String = ""
    Dim frmX As Integer = Nothing
    Dim frmY As Integer = Nothing
    Public newPoint As New System.Drawing.Point()
    Public a As Integer
    Public b As Integer
    Dim crA As String = ""
    Dim crB As String = ""
    Dim cntProcessed As Integer = 0
    Dim tmpVal As Integer = 0
    Dim klumpenDec As String = ""
    ' 0 = világos, 1 = sötét, 2 = barna
    Dim alapTema As Integer
    Dim bgmPlaying As Boolean
    Dim knockHibak As New ArrayList

    '------------------------------------------------------------------------------------------------------

    Private Sub frmPortKnocker_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.Hide()
        Me.Icon = My.Resources.AppIcon
        gBoxPwd.Visible = False
        bgmPlaying = False

        Try
            klumpenDec = Encoding.UTF8.GetString(Convert.FromBase64String(klumpenStrasse))
        Catch ex As Exception
            klumpenDec = "TCP / UDP / ICMP Multi Port Knocker by C2H5Cl"
        End Try

        Try
            crA = Encoding.UTF8.GetString(Convert.FromBase64String(crAdefEc))
            crB = Encoding.UTF8.GetString(Convert.FromBase64String(crBdefEc))
        Catch ex As Exception
            MessageBox.Show("Error decoding internal password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '            End
            Me.Close()
        End Try

        Me.Text = klumpenDec
        lblTitle.Text = klumpenDec

        cbProtoA.SelectedIndex = 0
        cbProtoB.SelectedIndex = 0
        cbProtoC.SelectedIndex = 0
        cbProtoD.SelectedIndex = 0

        ttStatus.Text = "Standby"

        '------------------------------------------------------------------------------------------------------

        If My.Settings.posX <> Nothing Then
            If IsNumeric(My.Settings.posX) Then
                frmX = CInt(Math.Round(My.Settings.posX))
            Else
                frmX = Nothing
            End If
        End If


        If My.Settings.posY <> Nothing Then
            If IsNumeric(My.Settings.posY) Then
                frmY = CInt(Math.Round(My.Settings.posY))
            Else
                frmY = Nothing
            End If
        End If


        If frmX <> Nothing And frmY <> Nothing Then
            Me.Location = New Point(frmX, frmY)
        Else
            Dim working_area As Rectangle = SystemInformation.WorkingArea
            Dim x As Integer = working_area.Left + working_area.Width - Me.Width
            Dim y As Integer = working_area.Top + working_area.Height - Me.Height
            Me.Location = New Point(x, y)
        End If

        '------------------------------------------------------------------------------------------------------

        If My.Settings.theme <> Nothing Then
            If My.Settings.theme = "dark" Then
                Me.BackgroundImage = My.Resources.frmBgDark
                alapTema = 1
            ElseIf My.Settings.theme = "light" Then
                Me.BackgroundImage = My.Resources.frmBg
                alapTema = 0
            ElseIf My.Settings.theme = "brown" Then
                Me.BackgroundImage = My.Resources.frmBgBrown
                alapTema = 2
            Else
                Me.BackgroundImage = My.Resources.frmBgDark
                alapTema = 1
            End If
        Else
            My.Settings.theme = "dark"
            Me.BackgroundImage = My.Resources.frmBgDark
            alapTema = 1
            My.Settings.Save()
        End If

        '------------------------------------------------------------------------------------------------------

        If My.Computer.Network.IsAvailable = False Then
            ttStatus.Text = "No active network connection"
        End If

        If My.Settings.cfgPwd <> Nothing Then
            Dim tA As String = Encoding.UTF8.GetString(Convert.FromBase64String(crAdefEc))
            Dim tB As String = Encoding.UTF8.GetString(Convert.FromBase64String(crBdefEc))
            Try
                crAusrEc = Nizorale(My.Settings.cfgPwd, tA, tB)
                tbPwd.Text = crAusrEc
            Catch ex As Exception
                'hiba
                crAusrEc = ""
                ttStatus.Text = "Cannot load saved password!"
            End Try

        End If

        '------------------------------------------------------------------------------------------------------

        If My.Settings.delay <> Nothing Then

            Dim dly As String = My.Settings.delay

            If dly = "0" Then
                cBoxDelay.SelectedIndex = 0
                tmrKnockAll.Interval = 500
            ElseIf dly = "1" Then
                cBoxDelay.SelectedIndex = 1
                tmrKnockAll.Interval = 1000
            ElseIf dly = "2" Then
                cBoxDelay.SelectedIndex = 2
                tmrKnockAll.Interval = 1500
            ElseIf dly = "3" Then
                cBoxDelay.SelectedIndex = 3
                tmrKnockAll.Interval = 2000
            ElseIf dly = "4" Then
                cBoxDelay.SelectedIndex = 4
                tmrKnockAll.Interval = 2500
            ElseIf dly = "5" Then
                cBoxDelay.SelectedIndex = 5
                tmrKnockAll.Interval = 3000
            ElseIf dly = "6" Then
                cBoxDelay.SelectedIndex = 6
                tmrKnockAll.Interval = 3500
            ElseIf dly = "7" Then
                cBoxDelay.SelectedIndex = 7
                tmrKnockAll.Interval = 4000
            ElseIf dly = "8" Then
                cBoxDelay.SelectedIndex = 8
                tmrKnockAll.Interval = 4500
            ElseIf dly = "9" Then
                cBoxDelay.SelectedIndex = 9
                tmrKnockAll.Interval = 5000
            Else
                cBoxDelay.SelectedIndex = 2
                tmrKnockAll.Interval = 1500
            End If
        Else
            cBoxDelay.SelectedIndex = 2
            tmrKnockAll.Interval = 1500
        End If

        statusNotify.Visible = False
        splashForm.Hide()
        splashForm.Close()


        Me.Show()
        Me.Focus()

    End Sub

    '------------------------------------------------------------------------------------------------------
    Private Sub frmPortKnocker_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            Call bezaras()
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------
    Private Sub BtnXit_Click(sender As Object, e As EventArgs) Handles btnXit.Click
        Call bezaras()
    End Sub

    '------------------------------------------------------------------------------------------------------
    Private Sub bezaras()

        startVagyStop = 1
        statusNotify.Visible = False

        Call vezerlokOff()

        My.Computer.Audio.Stop()
        My.Settings.posX = Me.Location.X
        My.Settings.posY = Me.Location.Y
        My.Settings.Save()

        Me.Hide()

        splashForm.splCnt = 0
        splashForm.tmrSplash.Enabled = True
        splashForm.Show()

    End Sub

    '------------------------------------------------------------------------------------------------------

    Private Sub KnockKnock(ByVal eset As Integer, ByVal singOrAll As Integer)

        If My.Computer.Network.IsAvailable = False Then
            ttStatus.Text = "No active network connection"
            Exit Sub
        End If

        If tbHostIp.Text = "" Then
            ttStatus.Text = "Nothing to knock"
            Exit Sub
        End If

        Dim chstIp As String = tbHostIp.Text
        Dim cProto As String = ""
        Dim cPort As String = ""
        Dim cFluxus As String = ""

        statusNotify.Visible = False

        If chkBoxDNS.CheckState = CheckState.Checked Then
            Dim ipEntry As IPHostEntry
            Dim IpAddr As IPAddress()

            Try
                If singOrAll = 1 Then
                    tmrKnockAll.Stop()
                End If
                ipEntry = Dns.GetHostEntry(chstIp)
                IpAddr = ipEntry.AddressList
                chstIp = IpAddr(0).ToString
            Catch ex As Exception
                'chstIp = ""
            Finally
                If singOrAll = 1 Then
                    tmrKnockAll.Start()
                End If
            End Try
        End If

        '-------------------------------------------------------------------------------

        Select Case eset

            Case 1

                If cbProtoA.SelectedIndex = 0 Then
                    cProto = "UDP"
                ElseIf cbProtoA.SelectedIndex = 1 Then
                    cProto = "TCP"
                ElseIf cbProtoA.SelectedIndex = 2 Then
                    cProto = "ICMP"
                End If

                If Len(tbPortA.Text) > 0 Then
                    cPort = tbPortA.Text
                Else
                    cPort = ""
                End If

                If Len(tbFluxusA.Text) > 0 Then
                    cFluxus = tbFluxusA.Text
                Else
                    cFluxus = ""
                End If

                '-----------------------------------------------------------------------------------

            Case 2

                If cbProtoB.SelectedIndex = 0 Then
                    cProto = "UDP"
                ElseIf cbProtoB.SelectedIndex = 1 Then
                    cProto = "TCP"
                ElseIf cbProtoB.SelectedIndex = 2 Then
                    cProto = "ICMP"
                End If

                If Len(tbPortB.Text) > 0 Then
                    cPort = tbPortB.Text
                Else
                    cPort = ""
                End If

                If Len(tbFluxusB.Text) > 0 Then
                    cFluxus = tbFluxusB.Text
                Else
                    cFluxus = ""
                End If

                '-----------------------------------------------------------------------------------

            Case 3

                If cbProtoC.SelectedIndex = 0 Then
                    cProto = "UDP"
                ElseIf cbProtoC.SelectedIndex = 1 Then
                    cProto = "TCP"
                ElseIf cbProtoC.SelectedIndex = 2 Then
                    cProto = "ICMP"
                End If

                If Len(tbPortC.Text) > 0 Then
                    cPort = tbPortC.Text
                Else
                    cPort = ""
                End If

                If Len(tbFluxusC.Text) > 0 Then
                    cFluxus = tbFluxusC.Text
                Else
                    cFluxus = ""
                End If

                '-----------------------------------------------------------------------------------

            Case 4

                If cbProtoD.SelectedIndex = 0 Then
                    cProto = "UDP"
                ElseIf cbProtoD.SelectedIndex = 1 Then
                    cProto = "TCP"
                ElseIf cbProtoD.SelectedIndex = 2 Then
                    cProto = "ICMP"
                End If

                If Len(tbPortD.Text) > 0 Then
                    cPort = tbPortD.Text
                Else
                    cPort = ""
                End If

                If Len(tbFluxusD.Text) > 0 Then
                    cFluxus = tbFluxusD.Text
                Else
                    cFluxus = ""
                End If

                '-----------------------------------------------------------------------------------

        End Select

        '---------------------------------------------------------------------

        'UDP kapcsolat
        If cProto = "UDP" Then

            Dim kliens As New UdpClient
            kliens.Client.SendTimeout = 5000
            kliens.Client.ReceiveTimeout = 5000
            ttStatus.Text = "Sending..."

            If chstIp <> "" And cPort <> "" And cFluxus = "" Then

                If singOrAll = 1 Then
                    tmrKnockAll.Stop()
                End If

                Try
                    kliens.Connect(chstIp, CInt(cPort))
                    Dim sendbytes() As Byte = Encoding.UTF8.GetBytes(" ")
                    kliens.Send(sendbytes, sendbytes.Length)
                    ttStatus.Text = "Connect UDP #" & eset.ToString & " Ok"
                Catch ex As Exception
                    ttStatus.Text = "Connecting error UDP #" & eset.ToString
                    knockHibak.Add("Connecting error UDP #" & eset.ToString)
                Finally
                    kliens.Close()
                End Try

                If singOrAll = 1 Then
                    tmrKnockAll.Start()
                End If

            ElseIf chstIp <> "" And cPort <> "" And cFluxus <> "" Then

                If singOrAll = 1 Then
                    tmrKnockAll.Stop()
                End If

                Try
                    kliens.Connect(chstIp, CInt(cPort))
                    Dim sendbytes() As Byte = Encoding.UTF8.GetBytes(cFluxus)
                    kliens.Send(sendbytes, sendbytes.Length)
                    ttStatus.Text = "Package UDP #" & eset.ToString & " sent"
                Catch ex As Exception
                    ttStatus.Text = "Error sending packet UDP #" & eset.ToString
                    knockHibak.Add("Error sending packet UDP #" & eset.ToString)
                Finally
                    kliens.Close()
                End Try

                If singOrAll = 1 Then
                    tmrKnockAll.Start()
                End If

            Else
                ttStatus.Text = "Nothing to knock"
            End If
            'UDP kapcsolat vége

            '---------------------------------------------------------------------

            'TCP kapcsolat
        ElseIf cProto = "TCP" Then

            Dim TcpKnocker As New TcpClient
            TcpKnocker.Client.SendTimeout = 5000
            TcpKnocker.Client.ReceiveTimeout = 5000

            If chstIp <> "" And cPort <> "" Then

                If singOrAll = 1 Then
                    tmrKnockAll.Stop()
                End If

                Try
                    TcpKnocker.ConnectAsync(chstIp, CInt(cPort))
                    'TcpKnocker.Connect(chstIp, CInt(cPort))
                    ttStatus.Text = "Package TCP #" & eset.ToString & " sent"
                Catch ex As Exception
                    ttStatus.Text = "Error sending packet TCP #" & eset.ToString
                    knockHibak.Add("Error sending packet TCP #" & eset.ToString)
                Finally
                    TcpKnocker.Close()
                End Try

                If singOrAll = 1 Then
                    tmrKnockAll.Start()
                End If

            Else
                ttStatus.Text = "Nothing to knock"
            End If

            '---------------------------------------------------------------------

            'ICMP kapcsolat (ping)
        ElseIf cProto = "ICMP" Then

            If chstIp <> "" Then

                If singOrAll = 1 Then
                    tmrKnockAll.Stop()
                End If

                Try
                    If My.Computer.Network.Ping(chstIp, 1500) Then
                        ttStatus.Text = "Package ICMP #" & eset.ToString & " sent"
                    Else
                        ttStatus.Text = "Error sending packet ICMP #" & eset.ToString
                        knockHibak.Add("Error sending packet ICMP #" & eset.ToString)
                    End If
                Catch ex As Exception
                    ttStatus.Text = "Error sending packet ICMP #" & eset.ToString
                    knockHibak.Add("Error sending packet ICMP #" & eset.ToString)
                End Try

                If singOrAll = 1 Then
                    tmrKnockAll.Start()
                End If

            Else
                ttStatus.Text = "Nothing to knock"
            End If


        End If

    End Sub

    '-------------------------------------------------------------------------------------------------
    Private Sub btnKoppA_Click(sender As Object, e As EventArgs) Handles btnKoppA.Click
        Call KnockKnock(1, 0)
    End Sub

    Private Sub btnKoppB_Click(sender As Object, e As EventArgs) Handles btnKoppB.Click
        Call KnockKnock(2, 0)
    End Sub

    Private Sub btnKoppC_Click(sender As Object, e As EventArgs) Handles btnKoppC.Click
        Call KnockKnock(3, 0)
    End Sub

    Private Sub btnKoppD_Click(sender As Object, e As EventArgs) Handles btnKoppD.Click
        Call KnockKnock(4, 0)
    End Sub

    '------------------------------------------------------------------------------------------------------

    Private Sub tbUrl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbHostIp.MouseDoubleClick
        If tbHostIp.PasswordChar = "*" Then
            tbHostIp.PasswordChar = Nothing
        ElseIf tbHostIp.PasswordChar = Nothing Then
            tbHostIp.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbPortA_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbPortA.MouseDoubleClick
        If tbPortA.PasswordChar = "*" Then
            tbPortA.PasswordChar = Nothing
        ElseIf tbPortA.PasswordChar = Nothing Then
            tbPortA.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbPortB_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbPortB.MouseDoubleClick
        If tbPortB.PasswordChar = "*" Then
            tbPortB.PasswordChar = Nothing
        ElseIf tbPortB.PasswordChar = Nothing Then
            tbPortB.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbPortC_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbPortC.MouseDoubleClick
        If tbPortC.PasswordChar = "*" Then
            tbPortC.PasswordChar = Nothing
        ElseIf tbPortC.PasswordChar = Nothing Then
            tbPortC.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbPortD_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbPortD.MouseDoubleClick
        If tbPortD.PasswordChar = "*" Then
            tbPortD.PasswordChar = Nothing
        ElseIf tbPortD.PasswordChar = Nothing Then
            tbPortD.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbFluxusA_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbFluxusA.MouseDoubleClick
        If tbFluxusA.PasswordChar = "*" Then
            tbFluxusA.PasswordChar = Nothing
        ElseIf tbFluxusA.PasswordChar = Nothing Then
            tbFluxusA.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbFluxusB_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbFluxusB.MouseDoubleClick
        If tbFluxusB.PasswordChar = "*" Then
            tbFluxusB.PasswordChar = Nothing
        ElseIf tbFluxusB.PasswordChar = Nothing Then
            tbFluxusB.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbFluxusC_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbFluxusC.MouseDoubleClick
        If tbFluxusC.PasswordChar = "*" Then
            tbFluxusC.PasswordChar = Nothing
        ElseIf tbFluxusC.PasswordChar = Nothing Then
            tbFluxusC.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbFluxusD_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbFluxusD.MouseDoubleClick
        If tbFluxusD.PasswordChar = "*" Then
            tbFluxusD.PasswordChar = Nothing
        ElseIf tbFluxusD.PasswordChar = Nothing Then
            tbFluxusD.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub tbPwd_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles tbPwd.MouseDoubleClick
        If tbPwd.PasswordChar = "*" Then
            tbPwd.PasswordChar = Nothing
        ElseIf tbPwd.PasswordChar = Nothing Then
            tbPwd.PasswordChar = "*".Chars(0)
        End If
    End Sub
    '----------------------------------------------------------------------
    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmInfok.Show()
        frmInfok.panelInfo.Focus()
        frmInfok.panelInfo.VerticalScroll.Value = 0
        Me.Hide()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If tbHostIp.Text <> "" Then
            If crAusrEc = "" Or Len(crAusrEc) < 8 Then
                MessageBox.Show("You are attempting to save configuration file with default encryption keys", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                crA = crAusrEc
            End If
        End If

        cfgSaveDialog.Title = "Save configuration file"
        cfgSaveDialog.FileName = "config"
        cfgSaveDialog.Filter = "Config files|*.cmpk"
        cfgSaveDialog.FilterIndex = 1
        cfgSaveDialog.DefaultExt = "cmpk"
        cfgSaveDialog.AddExtension = True

        If tbHostIp.Text = "" Then
            ttStatus.Text = "Nothing to save"
        Else

            If cfgSaveDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

                Try
                    Dim myFile As String = cfgSaveDialog.FileName
                    Dim myWriter = New StreamWriter(File.Create(myFile), System.Text.Encoding.UTF8)

                    myWriter.WriteLine(Zorale(tbHostIp.Text, crA, crB))

                    '--------------------------------------------
                    If cbProtoA.SelectedIndex = 0 Then
                        myWriter.WriteLine(Zorale("udp", crA, crB))
                    ElseIf cbProtoA.SelectedIndex = 1 Then
                        myWriter.WriteLine(Zorale("tcp", crA, crB))
                    ElseIf cbProtoA.SelectedIndex = 2 Then
                        myWriter.WriteLine(Zorale("icmp", crA, crB))
                    End If

                    If tbPortA.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbPortA.Text, crA, crB))
                    ElseIf tbPortA.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    If tbFluxusA.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbFluxusA.Text, crA, crB))
                    ElseIf tbFluxusA.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    '--------------------------------------------

                    If cbProtoB.SelectedIndex = 0 Then
                        myWriter.WriteLine(Zorale("udp", crA, crB))
                    ElseIf cbProtoB.SelectedIndex = 1 Then
                        myWriter.WriteLine(Zorale("tcp", crA, crB))
                    ElseIf cbProtoB.SelectedIndex = 2 Then
                        myWriter.WriteLine(Zorale("icmp", crA, crB))
                    End If

                    If tbPortB.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbPortB.Text, crA, crB))
                    ElseIf tbPortB.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    If tbFluxusB.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbFluxusB.Text, crA, crB))
                    ElseIf tbFluxusB.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    '--------------------------------------------

                    If cbProtoC.SelectedIndex = 0 Then
                        myWriter.WriteLine(Zorale("udp", crA, crB))
                    ElseIf cbProtoC.SelectedIndex = 1 Then
                        myWriter.WriteLine(Zorale("tcp", crA, crB))
                    ElseIf cbProtoC.SelectedIndex = 2 Then
                        myWriter.WriteLine(Zorale("icmp", crA, crB))
                    End If

                    If tbPortC.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbPortC.Text, crA, crB))
                    ElseIf tbPortC.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    If tbFluxusC.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbFluxusC.Text, crA, crB))
                    ElseIf tbFluxusC.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    '--------------------------------------------

                    If cbProtoD.SelectedIndex = 0 Then
                        myWriter.WriteLine(Zorale("udp", crA, crB))
                    ElseIf cbProtoD.SelectedIndex = 1 Then
                        myWriter.WriteLine(Zorale("tcp", crA, crB))
                    ElseIf cbProtoD.SelectedIndex = 2 Then
                        myWriter.WriteLine(Zorale("icmp", crA, crB))
                    End If

                    If tbPortD.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbPortD.Text, crA, crB))
                    ElseIf tbPortD.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    If tbFluxusD.Text <> "" Then
                        myWriter.WriteLine(Zorale(tbFluxusD.Text, crA, crB))
                    ElseIf tbFluxusD.Text = "" Then
                        myWriter.WriteLine(Zorale("-", crA, crB))
                    End If

                    '--------------------------------------------

                    If chkBoxDNS.CheckState = CheckState.Checked Then
                        myWriter.WriteLine(Zorale("useDnsResolve", crA, crB))
                    ElseIf chkBoxDNS.CheckState = CheckState.Unchecked Then
                        myWriter.WriteLine(Zorale("doNotUseDnsResolve", crA, crB))
                    End If

                    '--------------------------------------------

                    myWriter.Close()

                    If Len(cfgSaveDialog.FileName) > 90 Then
                        Dim pthLen As Integer = Len(cfgSaveDialog.FileName)
                        Dim startChar As Integer = pthLen - 90
                        Dim cfgPth As String = "..." & cfgSaveDialog.FileName.Substring(startChar, 90)
                        cfgFullPathTooltip.ToolTipTitle = "Saved config file"
                        cfgFullPathTooltip.SetToolTip(sStrip, cfgSaveDialog.FileName)
                        ttStatus.Text = "Config file saved: " & cfgPth
                        cfgFullPathTooltip.Active = True
                    Else
                        cfgFullPathTooltip.ToolTipTitle = "Saved config file"
                        cfgFullPathTooltip.SetToolTip(sStrip, cfgSaveDialog.FileName)
                        ttStatus.Text = "Config file saved: " & cfgSaveDialog.FileName
                        cfgFullPathTooltip.Active = True
                    End If

                Catch ex As Exception

                    ttStatus.Text = "Can't create config file"

                End Try

            Else

                MessageBox.Show("Save aborted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        End If


    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        If crAusrEc = "" Then
            MessageBox.Show("You are attempting to load configuration file with default encryption keys", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            crA = crAusrEc
        End If

        cfgLoadDialog.Title = "Load configuration file"
        cfgLoadDialog.Filter = "Config files|*.cmpk"
        cfgLoadDialog.FilterIndex = 1
        cfgLoadDialog.DefaultExt = "cmpk"
        cfgLoadDialog.AddExtension = True
        cfgLoadDialog.InitialDirectory = Application.StartupPath
        cfgLoadDialog.RestoreDirectory = True
        cfgLoadDialog.ShowDialog()

    End Sub

    Private Sub cfgLoadDialog_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cfgLoadDialog.FileOk

        Dim hiba = 0

        If New FileInfo(cfgLoadDialog.FileName).Length.Equals(0) Then
            ttStatus.Text = "Config file is empty or corrupted"
        Else

            Using sr As New StreamReader(cfgLoadDialog.FileName)

                Try
                    tbHostIp.Text = Nizorale(sr.ReadLine(), crA, crB)
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                '---------------------------------------------------

                Try
                    Dim tmpProto As String = ""
                    tmpProto = Nizorale(sr.ReadLine(), crA, crB)
                    If tmpProto = "udp" Then
                        cbProtoA.SelectedIndex = 0
                    ElseIf tmpProto = "tcp" Then
                        cbProtoA.SelectedIndex = 1
                    ElseIf tmpProto = "icmp" Then
                        cbProtoA.SelectedIndex = 2
                    End If
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbPortA.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbPortA.Text = "-" Then tbPortA.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbFluxusA.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbFluxusA.Text = "-" Then tbFluxusA.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                '---------------------------------------------------

                Try
                    Dim tmpProto As String = ""
                    tmpProto = Nizorale(sr.ReadLine(), crA, crB)
                    If tmpProto = "udp" Then
                        cbProtoB.SelectedIndex = 0
                    ElseIf tmpProto = "tcp" Then
                        cbProtoB.SelectedIndex = 1
                    ElseIf tmpProto = "icmp" Then
                        cbProtoB.SelectedIndex = 2
                    End If
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbPortB.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbPortB.Text = "-" Then tbPortB.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbFluxusB.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbFluxusB.Text = "-" Then tbFluxusB.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                '---------------------------------------------------

                Try
                    Dim tmpProto As String = ""
                    tmpProto = Nizorale(sr.ReadLine(), crA, crB)
                    If tmpProto = "udp" Then
                        cbProtoC.SelectedIndex = 0
                    ElseIf tmpProto = "tcp" Then
                        cbProtoC.SelectedIndex = 1
                    ElseIf tmpProto = "icmp" Then
                        cbProtoC.SelectedIndex = 2
                    End If
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbPortC.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbPortC.Text = "-" Then tbPortC.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbFluxusC.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbFluxusC.Text = "-" Then tbFluxusC.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                '---------------------------------------------------

                Try
                    Dim tmpProto As String = ""
                    tmpProto = Nizorale(sr.ReadLine(), crA, crB)
                    If tmpProto = "udp" Then
                        cbProtoD.SelectedIndex = 0
                    ElseIf tmpProto = "tcp" Then
                        cbProtoD.SelectedIndex = 1
                    ElseIf tmpProto = "icmp" Then
                        cbProtoD.SelectedIndex = 2
                    End If
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbPortD.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbPortD.Text = "-" Then tbPortD.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                Try
                    tbFluxusD.Text = Nizorale(sr.ReadLine(), crA, crB)
                    If tbFluxusD.Text = "-" Then tbFluxusD.Text = ""
                    ttStatus.Text = "Config file load ok"
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

                '---------------------------------------------------

                Try
                    Dim tempVal As String
                    tempVal = Nizorale(sr.ReadLine(), crA, crB)
                    If tempVal = "useDnsResolve" Then
                        chkBoxDNS.CheckState = CheckState.Checked
                    ElseIf tempVal = "doNotUseDnsResolve" Then
                        chkBoxDNS.CheckState = CheckState.Unchecked
                    End If
                Catch ex As Exception
                    ttStatus.Text = "Error reading config file"
                    hiba += 1
                End Try

            End Using

            '---------------------------------------------------

            If hiba > 0 Then
                ttStatus.Text = "" & hiba & " error(s) occured while reading config file (Wrong password / corrupted file)"
            Else

                If Len(cfgLoadDialog.FileName) > 90 Then
                    Dim pthLen As Integer = Len(cfgLoadDialog.FileName)
                    Dim startChar As Integer = pthLen - 90
                    Dim cfgPth As String = "..." & cfgLoadDialog.FileName.Substring(startChar, 90)
                    ttStatus.Text = "Config file load ok: " & cfgPth
                    cfgFullPathTooltip.ToolTipTitle = "Loaded config file"
                    cfgFullPathTooltip.SetToolTip(sStrip, cfgLoadDialog.FileName.ToString)
                    cfgFullPathTooltip.Active = True
                Else
                    ttStatus.Text = "Config file load ok: " & cfgLoadDialog.FileName
                    cfgFullPathTooltip.ToolTipTitle = "Loaded config file"
                    cfgFullPathTooltip.SetToolTip(sStrip, cfgLoadDialog.FileName)
                    cfgFullPathTooltip.Active = True
                End If

            End If

        End If

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        chkBoxDNS.CheckState = CheckState.Unchecked
        tbHostIp.Clear()
        tbPortA.Clear()
        tbPortB.Clear()
        tbPortC.Clear()
        tbPortD.Clear()
        tbFluxusA.Clear()
        tbFluxusB.Clear()
        tbFluxusC.Clear()
        tbFluxusD.Clear()
        cbProtoA.SelectedIndex = 0
        cbProtoB.SelectedIndex = 0
        cbProtoC.SelectedIndex = 0
        cbProtoD.SelectedIndex = 0
        cfgFullPathTooltip.Active = False
        crAusrEc = ""
        tbPwd.Text = ""

        Try
            crA = Encoding.UTF8.GetString(Convert.FromBase64String(crAdefEc))
            crB = Encoding.UTF8.GetString(Convert.FromBase64String(crBdefEc))
        Catch ex As Exception
            crA = "Jg@4[8-Hn8Vlo6(g)b$9g]76oy9X/V]u0)5e[{ah"
            crB = "E4yG)jN5l$5B*]kM"
        End Try

        ttStatus.Text = "Standby - Reseted to defaults"

    End Sub

    '------------------------------------------------------------------------------------------------------------------
    Private Sub btnKnockAll_Click(sender As Object, e As EventArgs) Handles btnKnockAll.Click

        If My.Computer.Network.IsAvailable = False Then
            ttStatus.Text = "No active network connection"
            Exit Sub
        End If

        If tbHostIp.Text = "" Then
            ttStatus.Text = "Nothing to knock"
            Exit Sub
        End If

        ttStatus.Text = "Knock all started"
        knockHibak.Clear()

        Call vezerlokOff()

        tmrKnockAll.Enabled = True
        tmrKnockAll.Start()

    End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private Sub TmrKnockAll_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles tmrKnockAll.Elapsed

        cntProcessed += 1

        '-------------------------------------------------------------------------------------------------------------

        If cntProcessed = 1 Then

            If cbProtoA.SelectedIndex = 0 Or cbProtoA.SelectedIndex = 1 Then
                If tbHostIp.Text <> "" And tbPortA.Text <> "" Then
                    Call KnockKnock(1, 1)
                    tmpVal += 1
                End If
            ElseIf cbProtoA.SelectedIndex = 2 Then
                If tbHostIp.Text <> "" Then
                    Call KnockKnock(1, 1)
                    tmpVal += 1
                End If
            End If

        End If

        '-------------------------------------------------------------------------------------------------------------

        If cntProcessed = 2 Then

            If cbProtoB.SelectedIndex = 0 Or cbProtoB.SelectedIndex = 1 Then
                If tbHostIp.Text <> "" And tbPortB.Text <> "" Then
                    Call KnockKnock(2, 1)
                    tmpVal += 1
                End If
            ElseIf cbProtoB.SelectedIndex = 2 Then
                If tbHostIp.Text <> "" Then
                    Call KnockKnock(2, 1)
                    tmpVal += 1
                End If
            End If

        End If

        '-------------------------------------------------------------------------------------------------------------

        If cntProcessed = 3 Then

            If cbProtoC.SelectedIndex = 0 Or cbProtoC.SelectedIndex = 1 Then
                If tbHostIp.Text <> "" And tbPortC.Text <> "" Then
                    Call KnockKnock(3, 1)
                    tmpVal += 1
                End If
            ElseIf cbProtoC.SelectedIndex = 2 Then
                If tbHostIp.Text <> "" Then
                    Call KnockKnock(3, 1)
                    tmpVal += 1
                End If
            End If

        End If

        '-------------------------------------------------------------------------------------------------------------

        If cntProcessed = 4 Then

            If cbProtoD.SelectedIndex = 0 Or cbProtoD.SelectedIndex = 1 Then
                If tbHostIp.Text <> "" And tbPortD.Text <> "" Then
                    Call KnockKnock(4, 1)
                    tmpVal += 1
                End If
            ElseIf cbProtoD.SelectedIndex = 2 Then
                If tbHostIp.Text <> "" Then
                    Call KnockKnock(4, 1)
                    tmpVal += 1
                End If
            End If

            ttStatus.Text = "Knock all finished. " & tmpVal.ToString & " port knocked."
            cntProcessed = 0
            tmpVal = 0
            tmrKnockAll.Stop()
            tmrKnockAll.Enabled = False

            If knockHibak.Count > 0 Then

                Dim hibakTxt As String = ""

                For i = 0 To knockHibak.Count - 1
                    hibakTxt += knockHibak(i).ToString & vbCrLf
                Next

                statusNotify.BalloonTipIcon = ToolTipIcon.Error
                statusNotify.BalloonTipTitle = "Knock Errors(s)"
                statusNotify.BalloonTipText = hibakTxt
                statusNotify.Visible = True
                statusNotify.ShowBalloonTip(6000)
            Else
                statusNotify.BalloonTipIcon = ToolTipIcon.Info
                statusNotify.BalloonTipTitle = "Knock All Results"
                statusNotify.BalloonTipText = "Knock All Finished"
                statusNotify.Visible = True
                statusNotify.ShowBalloonTip(6000)
            End If

            Call vezerlokOn()

        End If

        '-------------------------------------------------------------------------------------------------------------

    End Sub

    Private Sub vezerlokOff()

        btnKoppA.Enabled = False : btnKoppB.Enabled = False : btnKoppC.Enabled = False : btnKoppD.Enabled = False
        chkBoxDNS.Enabled = False
        btnKnockAll.Enabled = False : btnKnockAll.BackColor = Color.DarkGray
        btnReset.Enabled = False : btnReset.BackColor = Color.DarkGray
        btnLoad.Enabled = False : btnLoad.BackColor = Color.DarkGray
        btnSave.Enabled = False : btnSave.BackColor = Color.DarkGray
        btnXit.Enabled = False : btnHelp.Enabled = False
        cbNIC.Enabled = False
        cbProtoA.Enabled = False : cbProtoB.Enabled = False : cbProtoC.Enabled = False : cbProtoD.Enabled = False
        tbHostIp.Enabled = False : tbPortA.Enabled = False : tbPortB.Enabled = False : tbPortC.Enabled = False : tbPortD.Enabled = False
        tbFluxusA.Enabled = False : tbFluxusB.Enabled = False : tbFluxusC.Enabled = False : tbFluxusD.Enabled = False

    End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private Sub vezerlokOn()

        btnKoppA.Enabled = True : btnKoppB.Enabled = True : btnKoppC.Enabled = True : btnKoppD.Enabled = True
        chkBoxDNS.Enabled = True
        btnKnockAll.Enabled = True : btnKnockAll.BackColor = Color.FromArgb(20, 20, 20)
        btnReset.Enabled = True : btnReset.BackColor = Color.FromArgb(20, 20, 20)
        btnLoad.Enabled = True : btnLoad.BackColor = Color.FromArgb(20, 20, 20)
        btnSave.Enabled = True : btnSave.BackColor = Color.FromArgb(20, 20, 20)
        btnXit.Enabled = True : btnHelp.Enabled = True
        cbNIC.Enabled = True
        cbProtoA.Enabled = True : cbProtoB.Enabled = True
        cbProtoC.Enabled = True : cbProtoD.Enabled = True
        tbHostIp.Enabled = True : tbPortA.Enabled = True : tbPortB.Enabled = True : tbPortC.Enabled = True : tbPortD.Enabled = True

        If cbProtoA.SelectedIndex = 0 Then
            tbFluxusA.Enabled = True
        End If

        If cbProtoB.SelectedIndex = 0 Then
            tbFluxusB.Enabled = True
        End If

        If cbProtoC.SelectedIndex = 0 Then
            tbFluxusC.Enabled = True
        End If

        If cbProtoD.SelectedIndex = 0 Then
            tbFluxusD.Enabled = True
        End If

    End Sub

    '----------------------------------------------------------------------
    Private Sub BtnBGM_Click(sender As Object, e As EventArgs) Handles btnBGM.Click

        If bgmPlaying = False Then

            Try
                My.Computer.Audio.Play(My.Resources.BGMusic, AudioPlayMode.BackgroundLoop)
                btnBGM.Image = My.Resources.btnStop
                bgmPlaying = True
            Catch ex As Exception
                'Hiba
                ttStatus.Text = "Cannot play BG music..."
            End Try

        ElseIf bgmPlaying = True Then

            Try
                My.Computer.Audio.Stop()
                btnBGM.Image = My.Resources.btnPlay
                bgmPlaying = False
            Catch ex As Exception
                ttStatus.Text = "Cannot stop BG music..."
            End Try

        End If

    End Sub

    '------------------------------------------------------------------------------------------------------------------
    Public Function Zorale(ByVal plainText As String, ByVal pwdA As String, ByVal pwdB As String) As String

        Dim passPhrase As String = pwdA
        Dim saltValue As String = "+-*/K@k6á9t4s0c7h3o2v5i1t*s+c_h_B&é@l{a}b[á]-c*s+i(9)+#[E@tTh!$]"
        Dim hashAlgorithm As String = "SHA256"
        Dim passwordIterations As Integer = 2
        Dim initVector As String = pwdB
        Dim keySize As Integer = 256
        Dim initVectorBytes As Byte() = Encoding.UTF8.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.UTF8.GetBytes(saltValue)
        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(plainText)

        Dim password As New Rfc2898DeriveBytes(passPhrase, saltValueBytes, passwordIterations)
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.BlockSize = 128
        'symmetricKey.BlockSize = 256
        symmetricKey.Mode = CipherMode.CBC

        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)
        Dim memoryStream As New MemoryStream()
        Dim cryptoStream As New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)

        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()

        Dim cipherTextBytes As Byte() = memoryStream.ToArray()

        memoryStream.Close()
        cryptoStream.Close()

        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText

    End Function

    '------------------------------------------------------------------------------------------------------------------
    '
    '------------------------------------------------------------------------------------------------------------------
    Public Function Nizorale(ByVal cipherText As String, ByVal pwdA As String, ByVal pwdB As String) As String

        Dim passPhrase As String = pwdA
        Dim saltValue As String = "+-*/K@k6á9t4s0c7h3o2v5i1t*s+c_h_B&é@l{a}b[á]-c*s+i(9)+#[E@tTh!$]"
        Dim hashAlgorithm As String = "SHA256"
        Dim passwordIterations As Integer = 2
        Dim initVector As String = pwdB
        Dim keySize As Integer = 256
        Dim initVectorBytes As Byte() = Encoding.UTF8.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.UTF8.GetBytes(saltValue)
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)

        Dim password As New Rfc2898DeriveBytes(passPhrase, saltValueBytes, passwordIterations)
        Dim keyBytes As Byte() = password.GetBytes(keySize \ 8)
        Dim symmetricKey As New RijndaelManaged()

        symmetricKey.BlockSize = 128
        'symmetricKey.BlockSize = 256
        symmetricKey.Mode = CipherMode.CBC

        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
        Dim memoryStream As New MemoryStream(cipherTextBytes)
        Dim cryptoStream As New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)

        memoryStream.Close()
        cryptoStream.Close()

        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
        Return plainText

    End Function

    '------------------------------------------------------------------------------------------------------------------
    Private Sub CbProtoA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtoA.SelectedIndexChanged
        If cbProtoA.SelectedIndex = 1 Then
            tbFluxusA.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusA.Enabled = False
            tbPortA.BackColor = Color.FromArgb(51, 51, 51)
            tbPortA.Enabled = True
        ElseIf cbProtoA.SelectedIndex = 0 Then
            tbFluxusA.BackColor = Color.FromArgb(51, 51, 51)
            tbFluxusA.Enabled = True
            tbPortA.BackColor = Color.FromArgb(51, 51, 51)
            tbPortA.Enabled = True
        ElseIf cbProtoA.SelectedIndex = 2 Then
            tbFluxusA.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusA.Enabled = False
            tbPortA.BackColor = Color.FromArgb(36, 36, 36)
            tbPortA.Enabled = False
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private Sub CbProtoB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtoB.SelectedIndexChanged
        If cbProtoB.SelectedIndex = 1 Then
            tbFluxusB.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusB.Enabled = False
            tbPortB.BackColor = Color.FromArgb(51, 51, 51)
            tbPortB.Enabled = True
        ElseIf cbProtoB.SelectedIndex = 0 Then
            tbFluxusB.BackColor = Color.FromArgb(51, 51, 51)
            tbFluxusB.Enabled = True
            tbPortB.BackColor = Color.FromArgb(51, 51, 51)
            tbPortB.Enabled = True
        ElseIf cbProtoB.SelectedIndex = 2 Then
            tbFluxusB.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusB.Enabled = False
            tbPortB.BackColor = Color.FromArgb(36, 36, 36)
            tbPortB.Enabled = False
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private Sub CbProtoC_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtoC.SelectedIndexChanged
        If cbProtoC.SelectedIndex = 1 Then
            tbFluxusC.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusC.Enabled = False
            tbPortC.BackColor = Color.FromArgb(51, 51, 51)
            tbPortC.Enabled = True
        ElseIf cbProtoC.SelectedIndex = 0 Then
            tbFluxusC.BackColor = Color.FromArgb(51, 51, 51)
            tbFluxusC.Enabled = True
            tbPortC.BackColor = Color.FromArgb(51, 51, 51)
            tbPortC.Enabled = True
        ElseIf cbProtoC.SelectedIndex = 2 Then
            tbFluxusC.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusC.Enabled = False
            tbPortC.BackColor = Color.FromArgb(36, 36, 36)
            tbPortC.Enabled = False
        End If
    End Sub
    '------------------------------------------------------------------------------------------------------------------
    Private Sub CbProtoD_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProtoD.SelectedIndexChanged
        If cbProtoD.SelectedIndex = 1 Then
            tbFluxusD.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusD.Enabled = False
            tbPortD.BackColor = Color.FromArgb(51, 51, 51)
            tbPortD.Enabled = True
        ElseIf cbProtoD.SelectedIndex = 0 Then
            tbFluxusD.BackColor = Color.FromArgb(51, 51, 51)
            tbFluxusD.Enabled = True
            tbPortD.BackColor = Color.FromArgb(51, 51, 51)
            tbPortD.Enabled = True
        ElseIf cbProtoD.SelectedIndex = 2 Then
            tbFluxusD.BackColor = Color.FromArgb(36, 36, 36)
            tbFluxusD.Enabled = False
            tbPortD.BackColor = Color.FromArgb(36, 36, 36)
            tbPortD.Enabled = False
        End If
    End Sub

    Private Sub ChkBoxDNS_CheckedChanged(sender As Object, e As EventArgs) Handles chkBoxDNS.CheckedChanged
        If chkBoxDNS.CheckState = CheckState.Checked Then
            chkBoxDNS.ForeColor = Color.Lime
        ElseIf chkBoxDNS.CheckState = CheckState.Unchecked Then
            chkBoxDNS.ForeColor = Color.Tomato
        End If
    End Sub

    '------------------------------------------------------------------------------------------------------------------

    '---------------------------------------------------------------------------------------
    ' Egér események - MouseDown + Move
    '---------------------------------------------------------------------------------------

    Private Sub frmPortKnocker_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.7
    End Sub

    Private Sub frmPortKnocker_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If

    End Sub

    Private Sub frmPortKnocker_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        Me.Opacity = 1
    End Sub

    '----------------------------------------------------------------------
    Private Sub lblIkon_MouseDown(sender As Object, e As MouseEventArgs) Handles lblIkon.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.7
    End Sub

    Private Sub lblIkon_MouseMove(sender As Object, e As MouseEventArgs) Handles lblIkon.MouseMove

        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If

    End Sub

    Private Sub lblIkon_MouseUp(sender As Object, e As MouseEventArgs) Handles lblIkon.MouseUp
        Me.Opacity = 1
    End Sub
    '----------------------------------------------------------------------
    Private Sub lblTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.7
    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseMove

        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If

    End Sub
    Private Sub lblTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseUp
        Me.Opacity = 1
    End Sub
    '----------------------------------------------------------------------
    Private Sub StatusStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles sStrip.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.7
    End Sub
    Private Sub StatusStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles sStrip.MouseMove
        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If
    End Sub
    Private Sub StatusStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles sStrip.MouseUp
        Me.Opacity = 1
    End Sub

    Private Sub LblIkon_DoubleClick(sender As Object, e As EventArgs) Handles lblIkon.DoubleClick
        If alapTema = 0 Then
            Me.BackgroundImage = My.Resources.frmBgDark
            My.Settings.theme = "dark"
            My.Settings.Save()
            alapTema = 1
        ElseIf alapTema = 1 Then
            Me.BackgroundImage = My.Resources.frmBgBrown
            My.Settings.theme = "brown"
            My.Settings.Save()
            alapTema = 2
        ElseIf alapTema = 2 Then
            Me.BackgroundImage = My.Resources.frmBg
            My.Settings.theme = "light"
            My.Settings.Save()
            alapTema = 0
        End If
    End Sub

    Private Sub BtnPwdOkay_Click(sender As Object, e As EventArgs) Handles btnPwdOkay.Click

        If tbPwd.Text = "" And chkBoxPwdSave.CheckState = CheckState.Unchecked Then

            If My.Settings.cfgPwd <> "" Then
                My.Settings.cfgPwd = ""
                My.Settings.Save()
                MessageBox.Show("Password cleared.", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

        End If

        If Len(tbPwd.Text) < 8 Then
            MessageBox.Show("Minimum password length: 8 character!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf Len(tbPwd.Text) >= 8 Then
            crAusrEc = tbPwd.Text
            ttStatus.Text = "Config file password set"
            MessageBox.Show("Config file password set - Ok", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

            If chkBoxPwdSave.CheckState = CheckState.Checked Then
                Dim tA As String = Encoding.UTF8.GetString(Convert.FromBase64String(crAdefEc))
                Dim tB As String = Encoding.UTF8.GetString(Convert.FromBase64String(crBdefEc))
                My.Settings.cfgPwd = Zorale(tbPwd.Text, tA, tB)
                My.Settings.Save()
                MessageBox.Show("Config file password encrypted and saved in app settings", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If

    End Sub

    Private Sub BtnSettClose_Click(sender As Object, e As EventArgs) Handles btnSettClose.Click
        'MessageBox.Show("Nothing changed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        My.Settings.Save()
        gBoxPwd.Visible = False
    End Sub

    Private Sub CBoxDelay_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxDelay.SelectedIndexChanged

        Select Case cBoxDelay.SelectedIndex
            Case 0
                tmrKnockAll.Interval = 500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 1
                tmrKnockAll.Interval = 1000
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 2
                tmrKnockAll.Interval = 1500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 3
                tmrKnockAll.Interval = 2000
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 4
                tmrKnockAll.Interval = 2500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 5
                tmrKnockAll.Interval = 3000
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 6
                tmrKnockAll.Interval = 3500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 7
                tmrKnockAll.Interval = 4000
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 8
                tmrKnockAll.Interval = 4500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case 9
                tmrKnockAll.Interval = 5000
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
            Case Else
                tmrKnockAll.Interval = 1500
                My.Settings.delay = cBoxDelay.SelectedIndex.ToString
        End Select

    End Sub

    Private Sub BtnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        gBoxPwd.Visible = True
        tbPwd.Focus()
    End Sub

    '----------------------------------------------------------------------

End Class
