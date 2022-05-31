Public Class frmdelete

    Dim da As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String

    Private Sub frmdelete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LMSDataSet.Book)

    End Sub

    Sub LoadBiodata()
        con.Open() ' open connections

        sql = ("Select * from Book")

        'bind the SQL and the connection through OleDBDataAdaoter and stored to da
        da = New OleDb.OleDbDataAdapter(sql, con)
        'and whatever the value of da will be fill into dt our imaginary data table
        da.Fill(dt)
        'get the datasource of datagridview from our data table
        DataGridView1.DataSource = dt
        con.Close() ' close connection
        da.Dispose()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        con.Open()
        com = New OleDb.OleDbCommand("delete * from Book where BookID='" & txtboookid.Text & "'" & "OR BookName='" & txtbookname.Text & "'", con)
        com.ExecuteNonQuery()
        MsgBox("Record Successfully Deleted!")
        con.Close()
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
            DataGridView1.DataSource = dt

        Catch ex As Exception
            'will throw an error if something went wrong.
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        'close connection
        con.Close()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'clear out the datasource for the Grid view
        Me.DataGridView1.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.BookTableAdapter.Fill(Me.LMSDataSet.Book)
        'reset the datasource from the binding source
        Me.DataGridView1.DataSource = Me.BookBindingSource
        'should redraw with the new data
        Me.DataGridView1.Refresh()
        txtboookid.Text = ""
        txtbookname.Text = ""
        txtauthor.Text = ""
    End Sub
End Class