Public Class CreateAccount
    Dim email, username, password, confirmpassword As String

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        email = txtEMail.Text
        username = txtUsername.Text
        password = txtPassword.Text
        confirmpassword = txtConfirmPassword.Text


        If password <> confirmpassword Then
            MsgBox("Password Mismatch!")
            txtPassword.Clear()
            txtConfirmPassword.Clear()

        ElseIf email = "" Then
            MsgBox("Please input email.")
        ElseIf username = "" Then
            MsgBox("Please input username")

        ElseIf password = "" And confirmpassword = "" Then
            MsgBox("Please input valid password.")
        Else
            Create_Account(username, email, confirmpassword)
            Login.Show()
            Me.Close()

        End If

    End Sub
End Class