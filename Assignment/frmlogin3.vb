Imports System.Data.OleDb


Public Class frmlogin3

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

        Using command As New OleDbCommand("SELECT COUNT(*) FROM Student WHERE [StudentID] = @sid AND [Password] = @pass", con)
            command.Parameters.AddWithValue("@sid", OleDbType.VarChar).Value = txtusername.Text.Trim
            command.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = txtpassword.Text.Trim

            Dim count = Convert.ToInt32(command.ExecuteScalar())

            If count > 0 Then
                Me.Hide()
                frmhomeC.Show()
            Else
                MessageBox.Show("Oops!,Invalid Username or Password!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

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