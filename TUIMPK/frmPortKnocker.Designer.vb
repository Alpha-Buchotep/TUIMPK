<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPortKnocker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPortKnocker))
        Me.tbHostIp = New System.Windows.Forms.TextBox()
        Me.tbPortA = New System.Windows.Forms.TextBox()
        Me.tbFluxusA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gBox1 = New System.Windows.Forms.GroupBox()
        Me.chkBoxDNS = New System.Windows.Forms.CheckBox()
        Me.gBox2 = New System.Windows.Forms.GroupBox()
        Me.cbProtoA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnKoppA = New System.Windows.Forms.Button()
        Me.gBox3 = New System.Windows.Forms.GroupBox()
        Me.cbProtoB = New System.Windows.Forms.ComboBox()
        Me.btnKoppB = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbPortB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbFluxusB = New System.Windows.Forms.TextBox()
        Me.gBox4 = New System.Windows.Forms.GroupBox()
        Me.cbProtoC = New System.Windows.Forms.ComboBox()
        Me.btnKoppC = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPortC = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbFluxusC = New System.Windows.Forms.TextBox()
        Me.sStrip = New System.Windows.Forms.StatusStrip()
        Me.ttStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnXit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.gBox5 = New System.Windows.Forms.GroupBox()
        Me.cbProtoD = New System.Windows.Forms.ComboBox()
        Me.btnKoppD = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbPortD = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbFluxusD = New System.Windows.Forms.TextBox()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.cfgSaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.cfgLoadDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnKnockAll = New System.Windows.Forms.Button()
        Me.tmrKnockAll = New System.Timers.Timer()
        Me.cbNIC = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cfgFullPathTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.hangeroTrackbar = New System.Windows.Forms.TrackBar()
        Me.btnBGM = New System.Windows.Forms.Label()
        Me.lblIkon = New System.Windows.Forms.Label()
        Me.gBoxSettings = New System.Windows.Forms.GroupBox()
        Me.cBoxDelay = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.chkBoxPwdSave = New System.Windows.Forms.CheckBox()
        Me.btnSettClose = New System.Windows.Forms.Button()
        Me.btnPwdOkay = New System.Windows.Forms.Button()
        Me.lblPwd = New System.Windows.Forms.Label()
        Me.tbPwd = New System.Windows.Forms.TextBox()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.statusNotify = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.gBox1.SuspendLayout()
        Me.gBox2.SuspendLayout()
        Me.gBox3.SuspendLayout()
        Me.gBox4.SuspendLayout()
        Me.sStrip.SuspendLayout()
        Me.gBox5.SuspendLayout()
        CType(Me.tmrKnockAll, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hangeroTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gBoxSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbHostIp
        '
        Me.tbHostIp.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbHostIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbHostIp.ForeColor = System.Drawing.Color.Lime
        Me.tbHostIp.Location = New System.Drawing.Point(11, 26)
        Me.tbHostIp.MaxLength = 600
        Me.tbHostIp.Name = "tbHostIp"
        Me.tbHostIp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbHostIp.Size = New System.Drawing.Size(575, 20)
        Me.tbHostIp.TabIndex = 2
        '
        'tbPortA
        '
        Me.tbPortA.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbPortA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPortA.ForeColor = System.Drawing.Color.Lime
        Me.tbPortA.Location = New System.Drawing.Point(192, 33)
        Me.tbPortA.MaxLength = 5
        Me.tbPortA.Name = "tbPortA"
        Me.tbPortA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPortA.Size = New System.Drawing.Size(86, 20)
        Me.tbPortA.TabIndex = 6
        '
        'tbFluxusA
        '
        Me.tbFluxusA.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbFluxusA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFluxusA.ForeColor = System.Drawing.Color.Lime
        Me.tbFluxusA.Location = New System.Drawing.Point(356, 33)
        Me.tbFluxusA.MaxLength = 256
        Me.tbFluxusA.Name = "tbFluxusA"
        Me.tbFluxusA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbFluxusA.Size = New System.Drawing.Size(206, 20)
        Me.tbFluxusA.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.ForeColor = System.Drawing.Color.Tomato
        Me.Label2.Location = New System.Drawing.Point(142, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PORT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.ForeColor = System.Drawing.Color.Tomato
        Me.Label3.Location = New System.Drawing.Point(291, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FLUXUS"
        '
        'gBox1
        '
        Me.gBox1.BackColor = System.Drawing.Color.Transparent
        Me.gBox1.Controls.Add(Me.chkBoxDNS)
        Me.gBox1.Controls.Add(Me.tbHostIp)
        Me.gBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBox1.ForeColor = System.Drawing.Color.Tomato
        Me.gBox1.Location = New System.Drawing.Point(13, 43)
        Me.gBox1.Name = "gBox1"
        Me.gBox1.Size = New System.Drawing.Size(744, 70)
        Me.gBox1.TabIndex = 1
        Me.gBox1.TabStop = False
        Me.gBox1.Text = "  HOST NAME / IP ADDRESS  "
        '
        'chkBoxDNS
        '
        Me.chkBoxDNS.AutoSize = True
        Me.chkBoxDNS.BackColor = System.Drawing.Color.Transparent
        Me.chkBoxDNS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxDNS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBoxDNS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkBoxDNS.ForeColor = System.Drawing.Color.Tomato
        Me.chkBoxDNS.Location = New System.Drawing.Point(613, 27)
        Me.chkBoxDNS.Name = "chkBoxDNS"
        Me.chkBoxDNS.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chkBoxDNS.Size = New System.Drawing.Size(99, 17)
        Me.chkBoxDNS.TabIndex = 3
        Me.chkBoxDNS.Text = "DNS Resolve"
        Me.chkBoxDNS.UseVisualStyleBackColor = False
        '
        'gBox2
        '
        Me.gBox2.BackColor = System.Drawing.Color.Transparent
        Me.gBox2.Controls.Add(Me.cbProtoA)
        Me.gBox2.Controls.Add(Me.Label4)
        Me.gBox2.Controls.Add(Me.btnKoppA)
        Me.gBox2.Controls.Add(Me.Label2)
        Me.gBox2.Controls.Add(Me.tbPortA)
        Me.gBox2.Controls.Add(Me.Label3)
        Me.gBox2.Controls.Add(Me.tbFluxusA)
        Me.gBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBox2.ForeColor = System.Drawing.Color.Tomato
        Me.gBox2.Location = New System.Drawing.Point(13, 126)
        Me.gBox2.Name = "gBox2"
        Me.gBox2.Size = New System.Drawing.Size(745, 80)
        Me.gBox2.TabIndex = 4
        Me.gBox2.TabStop = False
        Me.gBox2.Text = "  PORT KNOCK #1  "
        '
        'cbProtoA
        '
        Me.cbProtoA.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbProtoA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProtoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtoA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProtoA.ForeColor = System.Drawing.Color.Tomato
        Me.cbProtoA.FormattingEnabled = True
        Me.cbProtoA.Items.AddRange(New Object() {"UDP", "TCP", "ICMP"})
        Me.cbProtoA.Location = New System.Drawing.Point(65, 33)
        Me.cbProtoA.MaxDropDownItems = 2
        Me.cbProtoA.Name = "cbProtoA"
        Me.cbProtoA.Size = New System.Drawing.Size(63, 21)
        Me.cbProtoA.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "PROTO"
        '
        'btnKoppA
        '
        Me.btnKoppA.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnKoppA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKoppA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKoppA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKoppA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKoppA.Location = New System.Drawing.Point(586, 27)
        Me.btnKoppA.Name = "btnKoppA"
        Me.btnKoppA.Size = New System.Drawing.Size(139, 30)
        Me.btnKoppA.TabIndex = 8
        Me.btnKoppA.Text = "K n o c k - k n o c k"
        Me.btnKoppA.UseVisualStyleBackColor = False
        '
        'gBox3
        '
        Me.gBox3.BackColor = System.Drawing.Color.Transparent
        Me.gBox3.Controls.Add(Me.cbProtoB)
        Me.gBox3.Controls.Add(Me.btnKoppB)
        Me.gBox3.Controls.Add(Me.Label8)
        Me.gBox3.Controls.Add(Me.Label1)
        Me.gBox3.Controls.Add(Me.tbPortB)
        Me.gBox3.Controls.Add(Me.Label5)
        Me.gBox3.Controls.Add(Me.tbFluxusB)
        Me.gBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBox3.ForeColor = System.Drawing.Color.Tomato
        Me.gBox3.Location = New System.Drawing.Point(13, 219)
        Me.gBox3.Name = "gBox3"
        Me.gBox3.Size = New System.Drawing.Size(745, 80)
        Me.gBox3.TabIndex = 9
        Me.gBox3.TabStop = False
        Me.gBox3.Text = "  PORT KNOCK #2  "
        '
        'cbProtoB
        '
        Me.cbProtoB.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbProtoB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProtoB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtoB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProtoB.ForeColor = System.Drawing.Color.Tomato
        Me.cbProtoB.FormattingEnabled = True
        Me.cbProtoB.Items.AddRange(New Object() {"UDP", "TCP", "ICMP"})
        Me.cbProtoB.Location = New System.Drawing.Point(65, 33)
        Me.cbProtoB.MaxDropDownItems = 2
        Me.cbProtoB.Name = "cbProtoB"
        Me.cbProtoB.Size = New System.Drawing.Size(63, 21)
        Me.cbProtoB.TabIndex = 10
        '
        'btnKoppB
        '
        Me.btnKoppB.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnKoppB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKoppB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKoppB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKoppB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKoppB.Location = New System.Drawing.Point(586, 27)
        Me.btnKoppB.Name = "btnKoppB"
        Me.btnKoppB.Size = New System.Drawing.Size(139, 30)
        Me.btnKoppB.TabIndex = 13
        Me.btnKoppB.Text = "K n o c k - k n o c k"
        Me.btnKoppB.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.Tomato
        Me.Label8.Location = New System.Drawing.Point(11, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 103
        Me.Label8.Text = "PROTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.ForeColor = System.Drawing.Color.Tomato
        Me.Label1.Location = New System.Drawing.Point(142, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "PORT"
        '
        'tbPortB
        '
        Me.tbPortB.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbPortB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPortB.ForeColor = System.Drawing.Color.Lime
        Me.tbPortB.Location = New System.Drawing.Point(192, 33)
        Me.tbPortB.MaxLength = 5
        Me.tbPortB.Name = "tbPortB"
        Me.tbPortB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPortB.Size = New System.Drawing.Size(86, 20)
        Me.tbPortB.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.ForeColor = System.Drawing.Color.Tomato
        Me.Label5.Location = New System.Drawing.Point(291, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "FLUXUS"
        '
        'tbFluxusB
        '
        Me.tbFluxusB.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbFluxusB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFluxusB.ForeColor = System.Drawing.Color.Lime
        Me.tbFluxusB.Location = New System.Drawing.Point(356, 33)
        Me.tbFluxusB.MaxLength = 256
        Me.tbFluxusB.Name = "tbFluxusB"
        Me.tbFluxusB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbFluxusB.Size = New System.Drawing.Size(206, 20)
        Me.tbFluxusB.TabIndex = 12
        '
        'gBox4
        '
        Me.gBox4.BackColor = System.Drawing.Color.Transparent
        Me.gBox4.Controls.Add(Me.cbProtoC)
        Me.gBox4.Controls.Add(Me.btnKoppC)
        Me.gBox4.Controls.Add(Me.Label9)
        Me.gBox4.Controls.Add(Me.Label6)
        Me.gBox4.Controls.Add(Me.tbPortC)
        Me.gBox4.Controls.Add(Me.Label7)
        Me.gBox4.Controls.Add(Me.tbFluxusC)
        Me.gBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBox4.ForeColor = System.Drawing.Color.Tomato
        Me.gBox4.Location = New System.Drawing.Point(13, 312)
        Me.gBox4.Name = "gBox4"
        Me.gBox4.Size = New System.Drawing.Size(745, 80)
        Me.gBox4.TabIndex = 14
        Me.gBox4.TabStop = False
        Me.gBox4.Text = "  PORT KNOCK #3  "
        '
        'cbProtoC
        '
        Me.cbProtoC.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbProtoC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProtoC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProtoC.ForeColor = System.Drawing.Color.Tomato
        Me.cbProtoC.FormattingEnabled = True
        Me.cbProtoC.Items.AddRange(New Object() {"UDP", "TCP", "ICMP"})
        Me.cbProtoC.Location = New System.Drawing.Point(65, 33)
        Me.cbProtoC.MaxDropDownItems = 2
        Me.cbProtoC.Name = "cbProtoC"
        Me.cbProtoC.Size = New System.Drawing.Size(63, 21)
        Me.cbProtoC.TabIndex = 15
        '
        'btnKoppC
        '
        Me.btnKoppC.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnKoppC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKoppC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKoppC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKoppC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKoppC.Location = New System.Drawing.Point(586, 27)
        Me.btnKoppC.Name = "btnKoppC"
        Me.btnKoppC.Size = New System.Drawing.Size(139, 30)
        Me.btnKoppC.TabIndex = 18
        Me.btnKoppC.Text = "K n o c k - k n o c k"
        Me.btnKoppC.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.Color.Tomato
        Me.Label9.Location = New System.Drawing.Point(11, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "PROTO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.ForeColor = System.Drawing.Color.Tomato
        Me.Label6.Location = New System.Drawing.Point(142, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "PORT"
        '
        'tbPortC
        '
        Me.tbPortC.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbPortC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPortC.ForeColor = System.Drawing.Color.Lime
        Me.tbPortC.Location = New System.Drawing.Point(192, 33)
        Me.tbPortC.MaxLength = 5
        Me.tbPortC.Name = "tbPortC"
        Me.tbPortC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPortC.Size = New System.Drawing.Size(86, 20)
        Me.tbPortC.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.ForeColor = System.Drawing.Color.Tomato
        Me.Label7.Location = New System.Drawing.Point(291, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FLUXUS"
        '
        'tbFluxusC
        '
        Me.tbFluxusC.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbFluxusC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFluxusC.ForeColor = System.Drawing.Color.Lime
        Me.tbFluxusC.Location = New System.Drawing.Point(356, 33)
        Me.tbFluxusC.MaxLength = 256
        Me.tbFluxusC.Name = "tbFluxusC"
        Me.tbFluxusC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbFluxusC.Size = New System.Drawing.Size(206, 20)
        Me.tbFluxusC.TabIndex = 17
        '
        'sStrip
        '
        Me.sStrip.BackColor = System.Drawing.Color.Transparent
        Me.sStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.sStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.sStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.sStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttStatus})
        Me.sStrip.Location = New System.Drawing.Point(0, 563)
        Me.sStrip.Name = "sStrip"
        Me.sStrip.Size = New System.Drawing.Size(770, 22)
        Me.sStrip.TabIndex = 13
        Me.sStrip.Text = "StatusStrip1"
        '
        'ttStatus
        '
        Me.ttStatus.BackColor = System.Drawing.Color.Transparent
        Me.ttStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ttStatus.ForeColor = System.Drawing.Color.LightSkyBlue
        Me.ttStatus.Name = "ttStatus"
        Me.ttStatus.Size = New System.Drawing.Size(55, 17)
        Me.ttStatus.Text = "Standby"
        Me.ttStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Tomato
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(34, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(736, 33)
        Me.lblTitle.TabIndex = 100
        Me.lblTitle.Text = "TCP / UDP Multi Port Knocker by C2H5Cl"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnXit
        '
        Me.btnXit.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnXit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnXit.FlatAppearance.BorderSize = 0
        Me.btnXit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnXit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnXit.ForeColor = System.Drawing.Color.Tomato
        Me.btnXit.Location = New System.Drawing.Point(736, 0)
        Me.btnXit.Name = "btnXit"
        Me.btnXit.Size = New System.Drawing.Size(33, 33)
        Me.btnXit.TabIndex = 200
        Me.btnXit.TabStop = False
        Me.btnXit.Text = "X"
        Me.btnXit.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Tomato
        Me.btnSave.Location = New System.Drawing.Point(415, 510)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 33)
        Me.btnSave.TabIndex = 26
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLoad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.Tomato
        Me.btnLoad.Location = New System.Drawing.Point(323, 510)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(80, 33)
        Me.btnLoad.TabIndex = 25
        Me.btnLoad.Text = "LOAD"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'gBox5
        '
        Me.gBox5.BackColor = System.Drawing.Color.Transparent
        Me.gBox5.Controls.Add(Me.cbProtoD)
        Me.gBox5.Controls.Add(Me.btnKoppD)
        Me.gBox5.Controls.Add(Me.Label10)
        Me.gBox5.Controls.Add(Me.Label11)
        Me.gBox5.Controls.Add(Me.tbPortD)
        Me.gBox5.Controls.Add(Me.Label12)
        Me.gBox5.Controls.Add(Me.tbFluxusD)
        Me.gBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBox5.ForeColor = System.Drawing.Color.Tomato
        Me.gBox5.Location = New System.Drawing.Point(12, 405)
        Me.gBox5.Name = "gBox5"
        Me.gBox5.Size = New System.Drawing.Size(745, 80)
        Me.gBox5.TabIndex = 19
        Me.gBox5.TabStop = False
        Me.gBox5.Text = "  PORT KNOCK #4  "
        '
        'cbProtoD
        '
        Me.cbProtoD.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbProtoD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbProtoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProtoD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbProtoD.ForeColor = System.Drawing.Color.Tomato
        Me.cbProtoD.FormattingEnabled = True
        Me.cbProtoD.Items.AddRange(New Object() {"UDP", "TCP", "ICMP"})
        Me.cbProtoD.Location = New System.Drawing.Point(65, 33)
        Me.cbProtoD.MaxDropDownItems = 2
        Me.cbProtoD.Name = "cbProtoD"
        Me.cbProtoD.Size = New System.Drawing.Size(63, 21)
        Me.cbProtoD.TabIndex = 20
        '
        'btnKoppD
        '
        Me.btnKoppD.BackColor = System.Drawing.Color.SaddleBrown
        Me.btnKoppD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKoppD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKoppD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKoppD.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKoppD.Location = New System.Drawing.Point(586, 27)
        Me.btnKoppD.Name = "btnKoppD"
        Me.btnKoppD.Size = New System.Drawing.Size(139, 30)
        Me.btnKoppD.TabIndex = 23
        Me.btnKoppD.Text = "K n o c k - k n o c k"
        Me.btnKoppD.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.ForeColor = System.Drawing.Color.Tomato
        Me.Label10.Location = New System.Drawing.Point(11, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 105
        Me.Label10.Text = "PROTO"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.Tomato
        Me.Label11.Location = New System.Drawing.Point(142, 36)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "PORT"
        '
        'tbPortD
        '
        Me.tbPortD.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbPortD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPortD.ForeColor = System.Drawing.Color.Lime
        Me.tbPortD.Location = New System.Drawing.Point(192, 33)
        Me.tbPortD.MaxLength = 5
        Me.tbPortD.Name = "tbPortD"
        Me.tbPortD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPortD.Size = New System.Drawing.Size(86, 20)
        Me.tbPortD.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.ForeColor = System.Drawing.Color.Tomato
        Me.Label12.Location = New System.Drawing.Point(291, 36)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "FLUXUS"
        '
        'tbFluxusD
        '
        Me.tbFluxusD.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.tbFluxusD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbFluxusD.ForeColor = System.Drawing.Color.Lime
        Me.tbFluxusD.Location = New System.Drawing.Point(356, 33)
        Me.tbFluxusD.MaxLength = 256
        Me.tbFluxusD.Name = "tbFluxusD"
        Me.tbFluxusD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbFluxusD.Size = New System.Drawing.Size(206, 20)
        Me.tbFluxusD.TabIndex = 22
        '
        'btnHelp
        '
        Me.btnHelp.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnHelp.ForeColor = System.Drawing.Color.Tomato
        Me.btnHelp.Location = New System.Drawing.Point(705, 0)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(33, 33)
        Me.btnHelp.TabIndex = 100
        Me.btnHelp.TabStop = False
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = False
        '
        'cfgSaveDialog
        '
        Me.cfgSaveDialog.DefaultExt = "cmpk"
        Me.cfgSaveDialog.FileName = "config"
        Me.cfgSaveDialog.RestoreDirectory = True
        Me.cfgSaveDialog.Title = "Save configuration file"
        '
        'cfgLoadDialog
        '
        Me.cfgLoadDialog.DefaultExt = "cmpk"
        Me.cfgLoadDialog.FileName = "config"
        Me.cfgLoadDialog.RestoreDirectory = True
        Me.cfgLoadDialog.Title = "Open configuration file"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Tomato
        Me.btnReset.Location = New System.Drawing.Point(507, 510)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 33)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnKnockAll
        '
        Me.btnKnockAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnKnockAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKnockAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnKnockAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKnockAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnKnockAll.ForeColor = System.Drawing.Color.Tomato
        Me.btnKnockAll.Location = New System.Drawing.Point(599, 510)
        Me.btnKnockAll.Name = "btnKnockAll"
        Me.btnKnockAll.Size = New System.Drawing.Size(139, 33)
        Me.btnKnockAll.TabIndex = 28
        Me.btnKnockAll.Text = "KNOCK ALL"
        Me.btnKnockAll.UseVisualStyleBackColor = False
        '
        'tmrKnockAll
        '
        Me.tmrKnockAll.Interval = 1500.0R
        Me.tmrKnockAll.SynchronizingObject = Me
        '
        'cbNIC
        '
        Me.cbNIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cbNIC.DropDownHeight = 130
        Me.cbNIC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNIC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbNIC.ForeColor = System.Drawing.Color.Tomato
        Me.cbNIC.FormattingEnabled = True
        Me.cbNIC.IntegralHeight = False
        Me.cbNIC.Location = New System.Drawing.Point(13, 522)
        Me.cbNIC.Name = "cbNIC"
        Me.cbNIC.Size = New System.Drawing.Size(298, 21)
        Me.cbNIC.TabIndex = 24
        Me.cbNIC.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Tomato
        Me.Label13.Location = New System.Drawing.Point(21, 500)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 106
        Me.Label13.Text = "ADAPTER"
        Me.Label13.Visible = False
        '
        'cfgFullPathTooltip
        '
        Me.cfgFullPathTooltip.AutomaticDelay = 750
        Me.cfgFullPathTooltip.AutoPopDelay = 9000
        Me.cfgFullPathTooltip.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.cfgFullPathTooltip.ForeColor = System.Drawing.Color.Lime
        Me.cfgFullPathTooltip.InitialDelay = 750
        Me.cfgFullPathTooltip.IsBalloon = True
        Me.cfgFullPathTooltip.ReshowDelay = 150
        Me.cfgFullPathTooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'hangeroTrackbar
        '
        Me.hangeroTrackbar.AutoSize = False
        Me.hangeroTrackbar.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.hangeroTrackbar.Location = New System.Drawing.Point(500, 11)
        Me.hangeroTrackbar.Maximum = 100
        Me.hangeroTrackbar.Name = "hangeroTrackbar"
        Me.hangeroTrackbar.Size = New System.Drawing.Size(65, 15)
        Me.hangeroTrackbar.TabIndex = 1000
        Me.hangeroTrackbar.TabStop = False
        Me.hangeroTrackbar.TickStyle = System.Windows.Forms.TickStyle.None
        Me.hangeroTrackbar.Value = 60
        Me.hangeroTrackbar.Visible = False
        '
        'btnBGM
        '
        Me.btnBGM.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnBGM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBGM.Image = Global.TUIMPK.My.Resources.Resources.btnPlay
        Me.btnBGM.Location = New System.Drawing.Point(682, 12)
        Me.btnBGM.Name = "btnBGM"
        Me.btnBGM.Size = New System.Drawing.Size(10, 10)
        Me.btnBGM.TabIndex = 1100
        '
        'lblIkon
        '
        Me.lblIkon.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblIkon.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.lblIkon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblIkon.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblIkon.ForeColor = System.Drawing.Color.Tomato
        Me.lblIkon.Image = Global.TUIMPK.My.Resources.Resources.PKR
        Me.lblIkon.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblIkon.Location = New System.Drawing.Point(0, 0)
        Me.lblIkon.Name = "lblIkon"
        Me.lblIkon.Size = New System.Drawing.Size(36, 33)
        Me.lblIkon.TabIndex = 99
        Me.lblIkon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gBoxSettings
        '
        Me.gBoxSettings.BackColor = System.Drawing.Color.Transparent
        Me.gBoxSettings.Controls.Add(Me.cBoxDelay)
        Me.gBoxSettings.Controls.Add(Me.Label14)
        Me.gBoxSettings.Controls.Add(Me.chkBoxPwdSave)
        Me.gBoxSettings.Controls.Add(Me.btnSettClose)
        Me.gBoxSettings.Controls.Add(Me.btnPwdOkay)
        Me.gBoxSettings.Controls.Add(Me.lblPwd)
        Me.gBoxSettings.Controls.Add(Me.tbPwd)
        Me.gBoxSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gBoxSettings.ForeColor = System.Drawing.Color.PaleGreen
        Me.gBoxSettings.Location = New System.Drawing.Point(9, 36)
        Me.gBoxSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.gBoxSettings.Name = "gBoxSettings"
        Me.gBoxSettings.Padding = New System.Windows.Forms.Padding(0)
        Me.gBoxSettings.Size = New System.Drawing.Size(752, 515)
        Me.gBoxSettings.TabIndex = 5000
        Me.gBoxSettings.TabStop = False
        Me.gBoxSettings.Text = " Settings "
        Me.gBoxSettings.Visible = False
        '
        'cBoxDelay
        '
        Me.cBoxDelay.BackColor = System.Drawing.Color.Black
        Me.cBoxDelay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cBoxDelay.DropDownHeight = 110
        Me.cBoxDelay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBoxDelay.DropDownWidth = 155
        Me.cBoxDelay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cBoxDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.cBoxDelay.ForeColor = System.Drawing.Color.Tomato
        Me.cBoxDelay.FormatString = "N1"
        Me.cBoxDelay.FormattingEnabled = True
        Me.cBoxDelay.IntegralHeight = False
        Me.cBoxDelay.Items.AddRange(New Object() {"0.5 sec", "1.0 sec", "1.5 sec", "2.0 sec", "2.5 sec", "3.0 sec", "3.5 sec", "4.0 sec", "4.5 sec", "5.0 sec"})
        Me.cBoxDelay.Location = New System.Drawing.Point(170, 280)
        Me.cBoxDelay.Name = "cBoxDelay"
        Me.cBoxDelay.Size = New System.Drawing.Size(156, 28)
        Me.cBoxDelay.Sorted = True
        Me.cBoxDelay.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.PaleGreen
        Me.Label14.Location = New System.Drawing.Point(166, 241)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 18)
        Me.Label14.TabIndex = 2001
        Me.Label14.Text = "Delay between packets"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkBoxPwdSave
        '
        Me.chkBoxPwdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkBoxPwdSave.BackColor = System.Drawing.Color.Transparent
        Me.chkBoxPwdSave.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkBoxPwdSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkBoxPwdSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Maroon
        Me.chkBoxPwdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkBoxPwdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.chkBoxPwdSave.ForeColor = System.Drawing.Color.PaleGreen
        Me.chkBoxPwdSave.Location = New System.Drawing.Point(170, 182)
        Me.chkBoxPwdSave.Name = "chkBoxPwdSave"
        Me.chkBoxPwdSave.Size = New System.Drawing.Size(421, 28)
        Me.chkBoxPwdSave.TabIndex = 2
        Me.chkBoxPwdSave.Text = "Save password ( this PC only )"
        Me.chkBoxPwdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkBoxPwdSave.UseVisualStyleBackColor = False
        '
        'btnSettClose
        '
        Me.btnSettClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSettClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSettClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettClose.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSettClose.Location = New System.Drawing.Point(386, 464)
        Me.btnSettClose.Name = "btnSettClose"
        Me.btnSettClose.Size = New System.Drawing.Size(205, 35)
        Me.btnSettClose.TabIndex = 4
        Me.btnSettClose.Text = "Close"
        Me.btnSettClose.UseVisualStyleBackColor = False
        '
        'btnPwdOkay
        '
        Me.btnPwdOkay.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnPwdOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPwdOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPwdOkay.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnPwdOkay.Location = New System.Drawing.Point(170, 134)
        Me.btnPwdOkay.Name = "btnPwdOkay"
        Me.btnPwdOkay.Size = New System.Drawing.Size(421, 35)
        Me.btnPwdOkay.TabIndex = 1
        Me.btnPwdOkay.Text = "Set config file password"
        Me.btnPwdOkay.UseVisualStyleBackColor = False
        '
        'lblPwd
        '
        Me.lblPwd.AutoSize = True
        Me.lblPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPwd.ForeColor = System.Drawing.Color.PaleGreen
        Me.lblPwd.Location = New System.Drawing.Point(166, 62)
        Me.lblPwd.Name = "lblPwd"
        Me.lblPwd.Size = New System.Drawing.Size(261, 18)
        Me.lblPwd.TabIndex = 2000
        Me.lblPwd.Text = "Config file password (max. 128 chars) "
        Me.lblPwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbPwd
        '
        Me.tbPwd.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.tbPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbPwd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.tbPwd.ForeColor = System.Drawing.Color.Lime
        Me.tbPwd.Location = New System.Drawing.Point(170, 96)
        Me.tbPwd.MaxLength = 128
        Me.tbPwd.Name = "tbPwd"
        Me.tbPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPwd.Size = New System.Drawing.Size(421, 26)
        Me.tbPwd.TabIndex = 0
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(27, Byte), Integer))
        Me.btnSettings.BackgroundImage = Global.TUIMPK.My.Resources.Resources.btnOpt16x
        Me.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatAppearance.BorderSize = 0
        Me.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnSettings.ForeColor = System.Drawing.Color.Tomato
        Me.btnSettings.Location = New System.Drawing.Point(634, 0)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(33, 33)
        Me.btnSettings.TabIndex = 5001
        Me.btnSettings.TabStop = False
        Me.btnSettings.UseVisualStyleBackColor = False
        '
        'statusNotify
        '
        Me.statusNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.statusNotify.BalloonTipTitle = "Results"
        Me.statusNotify.Icon = CType(resources.GetObject("statusNotify.Icon"), System.Drawing.Icon)
        Me.statusNotify.Text = "Info"
        '
        'frmPortKnocker
        '
        Me.AcceptButton = Me.btnKnockAll
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImage = Global.TUIMPK.My.Resources.Resources.frmBgDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnSettClose
        Me.ClientSize = New System.Drawing.Size(770, 585)
        Me.ControlBox = False
        Me.Controls.Add(Me.gBoxSettings)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.sStrip)
        Me.Controls.Add(Me.hangeroTrackbar)
        Me.Controls.Add(Me.btnBGM)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbNIC)
        Me.Controls.Add(Me.btnKnockAll)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.gBox5)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnXit)
        Me.Controls.Add(Me.lblIkon)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.gBox4)
        Me.Controls.Add(Me.gBox3)
        Me.Controls.Add(Me.gBox2)
        Me.Controls.Add(Me.gBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(770, 585)
        Me.MinimumSize = New System.Drawing.Size(770, 585)
        Me.Name = "frmPortKnocker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCP / UDP / ICMP Multi Port Knocker by C2H5Cl"
        Me.gBox1.ResumeLayout(False)
        Me.gBox1.PerformLayout()
        Me.gBox2.ResumeLayout(False)
        Me.gBox2.PerformLayout()
        Me.gBox3.ResumeLayout(False)
        Me.gBox3.PerformLayout()
        Me.gBox4.ResumeLayout(False)
        Me.gBox4.PerformLayout()
        Me.sStrip.ResumeLayout(False)
        Me.sStrip.PerformLayout()
        Me.gBox5.ResumeLayout(False)
        Me.gBox5.PerformLayout()
        CType(Me.tmrKnockAll, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hangeroTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gBoxSettings.ResumeLayout(False)
        Me.gBoxSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbHostIp As System.Windows.Forms.TextBox
    Friend WithEvents tbPortA As System.Windows.Forms.TextBox
    Friend WithEvents tbFluxusA As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbPortB As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbFluxusB As System.Windows.Forms.TextBox
    Friend WithEvents gBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbPortC As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbFluxusC As System.Windows.Forms.TextBox
    Friend WithEvents sStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ttStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnKoppA As System.Windows.Forms.Button
    Friend WithEvents btnKoppB As System.Windows.Forms.Button
    Friend WithEvents btnKoppC As System.Windows.Forms.Button
    Friend WithEvents lblIkon As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnXit As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents cbProtoA As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbProtoB As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProtoC As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents gBox5 As GroupBox
    Friend WithEvents cbProtoD As ComboBox
    Friend WithEvents btnKoppD As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbPortD As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbFluxusD As TextBox
    Friend WithEvents btnHelp As Button
    Friend WithEvents cfgSaveDialog As SaveFileDialog
    Friend WithEvents cfgLoadDialog As OpenFileDialog
    Friend WithEvents btnReset As Button
    Friend WithEvents btnKnockAll As Button
    Friend WithEvents tmrKnockAll As Timers.Timer
    Friend WithEvents cbNIC As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chkBoxDNS As CheckBox
    Friend WithEvents cfgFullPathTooltip As ToolTip
    Friend WithEvents hangeroTrackbar As TrackBar
    Friend WithEvents btnBGM As Label
    Friend WithEvents gBoxSettings As GroupBox
    Friend WithEvents btnPwdOkay As Button
    Friend WithEvents lblPwd As Label
    Friend WithEvents tbPwd As TextBox
    Friend WithEvents btnSettClose As Button
    Friend WithEvents chkBoxPwdSave As CheckBox
    Friend WithEvents cBoxDelay As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btnSettings As Button
    Friend WithEvents statusNotify As NotifyIcon
End Class
