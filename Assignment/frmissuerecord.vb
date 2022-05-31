Public Class frmissuerecord
    Dim da As New OleDb.OleDbDataAdapter
    Dim da1 As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim sql As String
    Dim sql1 As String

    Private Sub frmissuerecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.LMSDataSet.Student)


        'TODO: This line of code loads data into the 'LMSDataSet.Issue' table. You can move, or remove it, as needed.
        Me.IssueTableAdapter.Fill(Me.LMSDataSet.Issue)

    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        sql = "SELECT * FROM Issue where  BookID='" & txtbookid.Text & "'"
        sql1 = "SELECT * FROM Student where StudentID='" & txtstudentid.Text & "'"
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            da1 = New OleDb.OleDbDataAdapter(sql1, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            da1.Fill(dt1)
            'get the datasource of datagridview from our data table
            DataGridView1.DataSource = dt
            DataGridView2.DataSource = dt1
        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        DataGridView1.DataSource = Nothing
        DataGridView2.DataSource = Nothing
        DataGridView1.Refresh()
        DataGridView2.Refresh()
        txtbookid.Text = ""
        txtstudentid.Text = ""
    End Sub
End Class