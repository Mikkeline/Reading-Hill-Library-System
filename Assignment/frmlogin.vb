Imports System.Data.OleDb

Public Class frmlogin

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = Nothing Or txtpassword.Text = Nothing Then
            MessageBox.Show("Please enter credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'write commands to check  user available or not

        'check connection status before the execution

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using command As New OleDb.OleDbCommand("SELECT COUNT(*) FROM Account WHERE [uname] = @uname AND [pass] = @pass", con)
            command.Parameters.AddWithValue("@uname", OleDb.OleDbType.VarChar).Value = txtusername.Text.Trim
            command.Parameters.AddWithValue("@pass", OleDb.OleDbType.VarChar).Value = txtpassword.Text.Trim

            Dim count = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                Me.Hide()
                frmhomeA.Show()
            Else
                MessageBox.Show("Oops!, Invalid Username or Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End Using
        con.Close()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        MessageBox.Show("Thank You For Using library Management System", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Application.Exit()
    End Sub
End Class
