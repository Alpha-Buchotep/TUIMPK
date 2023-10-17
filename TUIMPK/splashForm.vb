Public Class splashForm

    Public splCnt As Integer = 0
    Private Sub splashForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.AppIcon
        Me.BackgroundImage = My.Resources.splashFormNewBg
        lblPgVer.Text = "v" & Application.ProductVersion
        tmrSplash.Interval = 1000
        tmrSplash.Enabled = True
    End Sub

    Private Sub TmrSplash_Elapsed(sender As Object, e As Timers.ElapsedEventArgs) Handles tmrSplash.Elapsed
        splCnt += 1

        If splCnt >= 2 Then

            If frmPortKnocker.startVagyStop = 0 Then
                tmrSplash.Enabled = False
                frmPortKnocker.Show()
            End If

            If frmPortKnocker.startVagyStop = 1 Then
                tmrSplash.Enabled = False

                Try
                    frmInfok.Close()
                Catch ex As Exception
                    'hiba / nincs nyitva
                End Try

                Try
                    frmPortKnocker.Close()
                Catch ex As Exception
                    'hiba / nincs nyitva
                    End
                Finally
                    End
                End Try

            End If

        End If

    End Sub

End Class