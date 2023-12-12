Public Class Login


    Public username, password As String

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        CreateAccount.Show()
        Me.Close()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = txtUsername.Text
        password = txtPassword.Text

        If username = "" Then
            MsgBox("Please input username")
        ElseIf password = "" Then
            MsgBox("Please input password")
        Else
            Login_Account(username, password)
            Me.Close()
        End If


    End Sub
End Class