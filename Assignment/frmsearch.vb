Public Class frmsearch

    'this OleDbDataAdapter serves as bridge to our connection and SQL statements
    Dim da As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub BookBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.BookBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDataSet)

    End Sub

    Private Sub frmsearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LMSDataSet.Book)
        txtquicksearch.Visible = False
    End Sub

    Private Sub btnseach_Click(sender As Object, e As EventArgs) Handles btnseach.Click
        sql = "Select * from Book where BookID='" & txtboookid.Text & "'" & " OR author= '" & txtauthor.Text & "' OR BookName='" & txtbookname.Text & "'"
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            BookDataGridView.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnquicksearch_Click(sender As Object, e As EventArgs) Handles btnquicksearch.Click
        txtquicksearch.Visible = True
        btnquicksearch.Enabled = False
        txtboookid.Enabled = False
        txtauthor.Enabled = False
        txtauthor.Enabled = False
        txtbookname.Enabled = False
    End Sub

    Private Sub txtquicksearch_TextChanged(sender As Object, e As EventArgs) Handles txtquicksearch.TextChanged
        sql = "Select * from Book where BookName like '%" & txtquicksearch.Text & "%' or author LIKE '%" & txtquicksearch.Text & "%'"

        dt = New DataTable
        Try
            'open the connection
            con.Open()
            'bind the SQL and the connection through OleDBDataAdaoter and stored to da
            da = New OleDb.OleDbDataAdapter(sql, con)
            'and whatever the value of da will be fill into dt our imaginary data table
            da.Fill(dt)
            'get the datasource of datagridview from our data table
            BookDataGridView.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtboookid.Text = ""
        txtauthor.Text = ""
        txtauthor.Text = ""
        txtbookname.Text = ""
        txtquicksearch.Text = ""
        btnquicksearch.Enabled = True
    End Sub
End Class