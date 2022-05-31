Imports System.Data.OleDb

Public Class frmuser
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet1.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.LMSDataSet1.Student)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try

            Dim cmd As New OleDb.OleDbCommand
            Dim connString As String
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Library.accdb"
            con.ConnectionString = connString
            cmd.Connection = con
            con.Open()
            da = New OleDb.OleDbDataAdapter("insert into Student ([StudentID],[Password],[full_name],[ContactNumber],[email],[gender],[address],[ICno]) values ('" & txtStudentID.Text & "','" & txtPassword.Text & "','" & txtFullname.Text & "','" & txtContactnumber.Text & "','" & txtemail.Text & "','" & cbxgender.Text & "','" & txtaddress.Text & "','" & txtic.Text & "')", con)
            da.Fill(ds)
            MessageBox.Show("Records insert Successfully", "Information")
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()

    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.Open()
        com = New OleDb.OleDbCommand("delete * from Student where  [StudentID]='" & txtStudentID.Text & "'", con)
        com.ExecuteNonQuery()
        MsgBox("Record Successfully Deleted!")
        con.Close()
    End Sub



    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'clear out the datasource for the Grid view
        Me.StudentDataGridView.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.StudentTableAdapter.Fill(LMSDataSet1.Student)
        'reset the datasource from the binding source
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        'should redraw with the new data
        Me.StudentDataGridView.Refresh()
        txtStudentID.Text = ""
        txtPassword.Text = ""
        txtFullname.Text = ""
        txtContactnumber.Text = ""
        txtaddress.Text = ""
        txtemail.Text = ""
        txtic.Text = ""
        cbxgender.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear out the datasource for the Grid view
        Me.StudentDataGridView.DataSource = Nothing
        'refill the table adapter from the dataset table 
        Me.StudentTableAdapter.Fill(LMSDataSet1.Student)
        'reset the datasource from the binding source
        Me.StudentDataGridView.DataSource = Me.StudentBindingSource
        'should redraw with the new data
        Me.StudentDataGridView.Refresh()
        txtStudentID.Text = ""
        txtPassword.Text = ""
        txtFullname.Text = ""
        txtContactnumber.Text = ""
        txtaddress.Text = ""
        txtemail.Text = ""
        txtic.Text = ""
        cbxgender.Text = ""

    End Sub
End Class
