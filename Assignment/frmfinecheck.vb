Public Class frmfinecheck
    Dim da As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub btnseach_Click(sender As Object, e As EventArgs) Handles btnseach.Click
        sql = "SELECT Issue.*, Student.StudentID AS StudentID, Student.ContactNumber, Student.email FROM     
               (Issue INNER JOIN Student ON Issue.StudentID = Student.StudentID)where Issue.StudentID='" & txtstuid.Text & "'AND Issue.fine IS NOT NULL"
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            DataGridView1.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        DataGridView1.DataSource = Nothing
        DataGridView1.Refresh()
        txtstuid.Text = ""

    End Sub
End Class