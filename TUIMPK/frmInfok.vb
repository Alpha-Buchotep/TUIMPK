Public Class frmInfok
    Dim frmX As Integer = Nothing
    Dim frmY As Integer = Nothing
    Public newPoint As New System.Drawing.Point()
    Public a As Integer
    Public b As Integer

    Private Sub frmInfok_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundImage = My.Resources.frmBg
        Me.BackgroundImageLayout = ImageLayout.Stretch
        Me.Icon = My.Resources.AppIcon
        pbFejlec.BackgroundImage = My.Resources.splashFormNewBg
        pbFejlec.BackgroundImageLayout = ImageLayout.Zoom
        lblPgVer.Text = "App version: " & Application.ProductVersion
        contactLbl.Text = "Contact: c2h5cl@proton.me"
        panelInfo.Focus()
    End Sub

    Private Sub frmInfok_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        panelInfo.VerticalScroll.Value = 0
        If (e.CloseReason = CloseReason.UserClosing) Then
            e.Cancel = True
            Call infoBezar()
        End If
    End Sub

    Private Sub BtnBezar_Click(sender As Object, e As EventArgs) Handles btnBezar.Click
        Call infoBezar()
    End Sub

    Private Sub infoBezar()
        Me.Hide()
        frmPortKnocker.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInformaciok.Click
        panelInfo.Focus()
    End Sub

    Private Sub ContactLbl_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles contactLbl.LinkClicked
        System.Diagnostics.Process.Start("mailto:c2h5cl@proton.me")
    End Sub

    Private Sub ContactLbl_MouseUp(sender As Object, e As MouseEventArgs) Handles contactLbl.MouseUp
        panelInfo.Focus()
    End Sub

    Private Sub pbFejlec_MouseDown(sender As Object, e As MouseEventArgs) Handles pbFejlec.MouseDown
        a = Control.MousePosition.X - Me.Location.X
        b = Control.MousePosition.Y - Me.Location.Y
        Me.Opacity = 0.7
    End Sub

    Private Sub pbFejlec_MouseMove(sender As Object, e As MouseEventArgs) Handles pbFejlec.MouseMove

        If e.Button = MouseButtons.Left Then
            newPoint = Control.MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Me.Location = newPoint
        End If

    End Sub

    Private Sub pbFejlec_MouseUp(sender As Object, e As MouseEventArgs) Handles pbFejlec.MouseUp
        Me.Opacity = 1
        panelInfo.Focus()
    End Sub

End Class