<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class splashForm
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
        Me.lblPgVer = New System.Windows.Forms.Label()
        Me.tmrSplash = New System.Timers.Timer()
        CType(Me.tmrSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPgVer
        '
        Me.lblPgVer.BackColor = System.Drawing.Color.Transparent
        Me.lblPgVer.Location = New System.Drawing.Point(800, 217)
        Me.lblPgVer.Name = "lblPgVer"
        Me.lblPgVer.Size = New System.Drawing.Size(91, 20)
        Me.lblPgVer.TabIndex = 0
        Me.lblPgVer.Text = "v1.0.3.2"
        Me.lblPgVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tmrSplash
        '
        Me.tmrSplash.Interval = 1000.0R
        Me.tmrSplash.SynchronizingObject = Me
        '
        'splashForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.TUIMPK.My.Resources.Resources.splashFormNewBg
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(900, 238)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblPgVer)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "splashForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TCP / UDP Multi Port Knocker"
        CType(Me.tmrSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblPgVer As Label
    Friend WithEvents tmrSplash As Timers.Timer
End Class
