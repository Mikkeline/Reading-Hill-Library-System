Public Class frmreport

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        Dim cmd As New OleDb.OleDbCommand
        Dim ds As New DataSet
        con.Open()
        If (txtchoice.Text = "All") Then

            Try

                Dim da As New OleDb.OleDbDataAdapter("select * from issue", con)
                Dim dt As New DataTable
                'fill data to datatable
                da.Fill(dt)

                'offer data in data table into datagridview
                Me.DataGridView1.DataSource = dt

            Catch ex As Exception

                MsgBox(ex.ToString())

            Finally

                con.Close()

            End Try
        End If
        If (txtchoice.Text = "Returned") Then
            Try

                Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM Issue WHERE status Like '%" & txtchoice.Text & "%'", con)
                Dim dt As New DataTable
                'fill data to datatable
                da.Fill(dt)

                'offer data in data table into datagridview
                Me.DataGridView1.DataSource = dt

            Catch ex As Exception

                MsgBox(ex.ToString())

            Finally

            End Try
        End If
        If (txtchoice.Text = "Missing") Then
            '%missing%'. '" & Missing & "'
            Try
                Dim da As New OleDb.OleDbDataAdapter("select * from issue where status Like '%" & txtchoice.Text & "%'", con)
                Dim dt As New DataTable
                'fill data to datatable
                da.Fill(dt)

                'offer data in data table into datagridview
                Me.DataGridView1.DataSource = dt

            Catch ex As Exception

                MsgBox(ex.ToString())

            Finally

                con.Close()

            End Try
        End If

        con.Close()

    End Sub
End Class