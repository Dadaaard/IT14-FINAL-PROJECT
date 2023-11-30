Public Class Login


    Public username, password As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
        Me.Close()

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = txtUsername.Text
        password = txtPassword.Text

        Login_Account(username, password)

        If username = "" Then
            MsgBox("Please input username")
        ElseIf password = "" Then
            MsgBox("Please input password")


        End If


    End Sub
End Class