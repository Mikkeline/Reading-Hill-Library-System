Public Class frmhomeA
    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        frmissuebook.ShowDialog()
    End Sub

    Private Sub btnissuerecord_Click(sender As Object, e As EventArgs) Handles btnissuerecord.Click
        frmissuerecord.ShowDialog()
    End Sub

    Private Sub btnfinecheck_Click(sender As Object, e As EventArgs) Handles btnfinecheck.Click
        frmfinecheck.ShowDialog()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        frmsearch.ShowDialog()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        frmdelete.ShowDialog()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        frmreport.ShowDialog()
    End Sub

    Private Sub btnregister_Click(sender As Object, e As EventArgs) Handles btnuser.Click
        frmuser.ShowDialog()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Me.Close()
        frmstart.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

End Class