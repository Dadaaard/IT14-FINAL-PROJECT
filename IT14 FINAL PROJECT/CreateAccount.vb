Public Class CreateAccount
    Dim firstname, lastname, email, username, password, confirmpassword As String
    Dim contactnumber As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        firstname = txtFirstName.Text
        lastname = txtLastName.Text
        email = txtEMail.Text
        username = txtUsername.Text
        password = txtPassword.Text
        confirmpassword = txtConfirmPassword.Text
        contactnumber = txtContactNumber.Text


        If password <> confirmpassword Then
            MsgBox("Password Mismatch!")
            txtPassword.Clear()
            txtConfirmPassword.Clear()

        Else
            Create_Account(firstname, lastname, username, email, confirmpassword, contactnumber)
            Login.Show()
            Me.Close()

        End If

    End Sub
End Class