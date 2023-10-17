<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInfok
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInfok))
        Me.pbFejlec = New System.Windows.Forms.PictureBox()
        Me.lblPgVer = New System.Windows.Forms.Label()
        Me.contactLbl = New System.Windows.Forms.LinkLabel()
        Me.btnBezar = New System.Windows.Forms.Button()
        Me.panelInfo = New System.Windows.Forms.Panel()
        Me.lblInformaciok = New System.Windows.Forms.Label()
        CType(Me.pbFejlec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbFejlec
        '
        Me.pbFejlec.BackgroundImage = Global.TUIMPK.My.Resources.Resources.splashFormNewBg
        Me.pbFejlec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbFejlec.Location = New System.Drawing.Point(0, 0)
        Me.pbFejlec.Name = "pbFejlec"
        Me.pbFejlec.Size = New System.Drawing.Size(797, 215)
        Me.pbFejlec.TabIndex = 0
        Me.pbFejlec.TabStop = False
        '
        'lblPgVer
        '
        Me.lblPgVer.BackColor = System.Drawing.Color.Transparent
        Me.lblPgVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.lblPgVer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblPgVer.Location = New System.Drawing.Point(568, 528)
        Me.lblPgVer.Name = "lblPgVer"
        Me.lblPgVer.Size = New System.Drawing.Size(217, 30)
        Me.lblPgVer.TabIndex = 3
        Me.lblPgVer.Text = "App version: v1.0.3.3"
        Me.lblPgVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'contactLbl
        '
        Me.contactLbl.ActiveLinkColor = System.Drawing.Color.OliveDrab
        Me.contactLbl.BackColor = System.Drawing.Color.Transparent
        Me.contactLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.contactLbl.DisabledLinkColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.contactLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.contactLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.contactLbl.LinkArea = New System.Windows.Forms.LinkArea(9, 25)
        Me.contactLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.contactLbl.LinkColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.contactLbl.Location = New System.Drawing.Point(12, 528)
        Me.contactLbl.Name = "contactLbl"
        Me.contactLbl.Size = New System.Drawing.Size(300, 30)
        Me.contactLbl.TabIndex = 2
        Me.contactLbl.TabStop = True
        Me.contactLbl.Text = "Contact: c2h5cl@proton.me"
        Me.contactLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.contactLbl.UseCompatibleTextRendering = True
        Me.contactLbl.VisitedLinkColor = System.Drawing.Color.DimGray
        '
        'btnBezar
        '
        Me.btnBezar.BackColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.btnBezar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBezar.FlatAppearance.BorderSize = 0
        Me.btnBezar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOliveGreen
        Me.btnBezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnBezar.ForeColor = System.Drawing.Color.White
        Me.btnBezar.Location = New System.Drawing.Point(772, 2)
        Me.btnBezar.Name = "btnBezar"
        Me.btnBezar.Size = New System.Drawing.Size(25, 25)
        Me.btnBezar.TabIndex = 4
        Me.btnBezar.TabStop = False
        Me.btnBezar.Text = "X"
        Me.btnBezar.UseVisualStyleBackColor = False
        '
        'panelInfo
        '
        Me.panelInfo.AutoScroll = True
        Me.panelInfo.BackColor = System.Drawing.Color.Transparent
        Me.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panelInfo.Controls.Add(Me.lblInformaciok)
        Me.panelInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.panelInfo.Location = New System.Drawing.Point(12, 224)
        Me.panelInfo.MaximumSize = New System.Drawing.Size(776, 300)
        Me.panelInfo.Name = "panelInfo"
        Me.panelInfo.Size = New System.Drawing.Size(776, 300)
        Me.panelInfo.TabIndex = 5
        '
        'lblInformaciok
        '
        Me.lblInformaciok.AutoSize = True
        Me.lblInformaciok.BackColor = System.Drawing.Color.Transparent
        Me.lblInformaciok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblInformaciok.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblInformaciok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblInformaciok.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblInformaciok.ForeColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.lblInformaciok.Location = New System.Drawing.Point(0, 0)
        Me.lblInformaciok.Name = "lblInformaciok"
        Me.lblInformaciok.Size = New System.Drawing.Size(746, 1900)
        Me.lblInformaciok.TabIndex = 1
        Me.lblInformaciok.Text = resources.GetString("lblInformaciok.Text")
        '
        'frmInfok
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.BackgroundImage = Global.TUIMPK.My.Resources.Resources.frmBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.panelInfo)
        Me.Controls.Add(Me.btnBezar)
        Me.Controls.Add(Me.contactLbl)
        Me.Controls.Add(Me.lblPgVer)
        Me.Controls.Add(Me.pbFejlec)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInfok"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Information"
        CType(Me.pbFejlec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelInfo.ResumeLayout(False)
        Me.panelInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbFejlec As PictureBox
    Friend WithEvents lblPgVer As Label
    Friend WithEvents contactLbl As LinkLabel
    Friend WithEvents btnBezar As Button
    Friend WithEvents panelInfo As Panel
    Friend WithEvents lblInformaciok As Label
End Class
