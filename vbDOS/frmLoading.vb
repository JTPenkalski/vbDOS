Public Class frmLoading

    Private Sub frmLoading_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        frmOS.Visible = False
        tmrMovement.Enabled = True

    End Sub

    Private Sub tmrMovement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMovement.Tick

        'Variables.
        Dim intX As Integer
        Dim intIncrease As Integer

        intX = lblBar.Left
        intIncrease = Int((10) * Rnd()) + 1

        'Horizontal Movement.
        Do Until lblBar.Left >= 300
            intX = intX + intIncrease
            lblBar.Left = intX
            System.Threading.Thread.Sleep(100)
            Me.Refresh()
        Loop

        'When Finished, Startup next Form.
        Me.Hide()
        frmOptions.Show()
        tmrMovement.Enabled = False

    End Sub

End Class