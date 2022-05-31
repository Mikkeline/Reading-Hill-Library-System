Public Class frmissuebook
    Dim da As New OleDb.OleDbDataAdapter
    'this is a temporary or imaginary tables in the memory of computer same with the datasets
    Dim dt As New DataTable
    Dim sql As String
    Dim ds As New DataSet
    Dim pro As String
    Dim conn As String
    Dim myconnection As OleDb.OleDbConnection = New OleDb.OleDbConnection
    Private addingBoolean As Boolean = False
    Private editingBoolean As Boolean = False

    Private Sub IssueBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.IssueBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LMSDataSet)
    End Sub

    Private Sub frmissuebook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LMSDataSet.Issue' table. You can move, or remove it, as needed.
        Me.IssueTableAdapter.Fill(Me.LMSDataSet.Issue)
        Me.IssueDataGridView.DataSource = Nothing
    End Sub

    Private Sub btnissue_Click(sender As Object, e As EventArgs) Handles btnissue.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Library.accdb"
            con.ConnectionString = connString
            cmd.Connection = con
            con.Open()
            da = New OleDb.OleDbDataAdapter("insert into Issue(BookID,StudentID,issue_date,due_date,status)values('" & txtbookid.Text & "','" & txtstudentid.Text & "','" & DateTimePickerissue.Text & "','" & DateTimePickerdue.Text & "','" & cbxstatus.Text & "')", con)
            da.Fill(ds)
            MessageBox.Show("Insert Successfully", "Information")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnrefresh_Click(sender As Object, e As EventArgs) Handles btnrefresh.Click
        Me.IssueDataGridView.DataSource = Nothing
        Me.IssueTableAdapter.Fill(Me.LMSDataSet.Issue)
        Me.IssueDataGridView.DataSource = Me.IssueBindingSource
        Me.IssueDataGridView.Refresh()
        txtbookid.Text = ""
        txtstudentid.Text = ""

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Library.accdb"
        conn = pro
        myconnection.ConnectionString = conn
        myconnection.Open()
        Dim sql As String
        'Run Else statements  if called from Edit operation
        sql = "Update Issue set [status]='" & cbxstatus.Text & "', [fine] ='" & txtfine.Text & "' Where [BookID]='" & txtbookid.Text & "'"
        Dim cmd As New OleDb.OleDbCommand(sql, myconnection)
        MessageBox.Show("Record updated", "Update Record")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class