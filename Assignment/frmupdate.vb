Public Class frmupdate
    'this OleDbDataAdapter serves as bridge to our connection and SQL statements
    Dim da As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String
    Dim pro As String
    Dim conn As String
    Dim ds As New DataSet
    Dim myconnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub frmupdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Book' table. You can move, or remove it, as needed.
        Me.BookTableAdapter.Fill(Me.LMSDataSet.Book)

    End Sub

    Private Sub btnseach_Click(sender As Object, e As EventArgs) Handles btnseach.Click
        sql = "Select * from Book where BookID='" & txtbookid.Text & "'" & " OR author= '" & txtauthor.Text & "' OR BookName='" & txtbookname.Text & "'OR subject= '" & txtsubject.Text & "'"
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

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Library.accdb"
            con.ConnectionString = connString
            cmd.Connection = con
            con.Open()
            da = New OleDb.OleDbDataAdapter("insert into book(BookName,BookID,subject,author,Quantity,cost)values('" & txtbookname.Text & "','" & txtbookid.Text & "','" & txtsubject.Text & "','" & txtauthor.Text & "','" & txtquantity.Text & "','" & txtcost.Text & "')", con)
            da.Fill(ds)
            MessageBox.Show("Insert Successfully!", "Information")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        'clear out the datasource for the Grid view
        Me.DataGridView1.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.BookTableAdapter.Fill(Me.LMSDataSet.Book)
        'should redraw with the New data
        Me.DataGridView1.Refresh()
        'reset the datasource from the binding source
        Me.DataGridView1.DataSource = Me.BookBindingSource

    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtbookid.Text = ""
        txtbookname.Text = ""
        txtauthor.Text = ""
        txtsubject.Text = ""
        txtquantity.Text = ""
        txtcost.Text = ""
    End Sub
End Class