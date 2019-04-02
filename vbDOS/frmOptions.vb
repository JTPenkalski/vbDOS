Public Class frmOptions

    Private Sub btnContinue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContinue.Click

        'Continues to next form.
        Me.Hide()
        frmOS.Show()

    End Sub
   
    Private Sub radTraditional_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTraditional.Click

        'Changes Color of DOS.
        intColorScheme = 0

    End Sub


    Private Sub radHacker_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radHacker.Click

        'Changes Color of DOS.
        intColorScheme = 1

    End Sub

    Private Sub radTerminal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radTerminal.Click

        'Changes Color of DOS.
        intColorScheme = 2

    End Sub


End Class