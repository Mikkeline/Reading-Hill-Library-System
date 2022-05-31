Public Class frmhomeC
    Private Sub btnbooksearch_Click(sender As Object, e As EventArgs) Handles btnbooksearch.Click
        frmsearch.ShowDialog()
    End Sub

    Private Sub btnfinecheck_Click(sender As Object, e As EventArgs) Handles btnfinecheck.Click
        frmfinecheck.ShowDialog()
    End Sub

    Private Sub btnissuerecord_Click(sender As Object, e As EventArgs) Handles btnissuerecord.Click
        frmissuerecord.ShowDialog()
    End Sub

    Private Sub btngeneratereports_Click(sender As Object, e As EventArgs) Handles btngeneratereports.Click
        frmreport1.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        frmstart.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub


End Class