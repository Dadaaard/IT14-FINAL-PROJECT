﻿Public Class AccountDetails

    Dim currentPassword, confirmpassword, username As String

    Private Sub btnSaveDetails_Click(sender As Object, e As EventArgs) Handles btnSaveDetails.Click

        currentPassword = txtCurrentPassword.Text
        confirmpassword = txtConfirmPassword.Text

        If txtNewPassword.Text = txtConfirmPassword.Text Then
            Update_Password(currentPassword, confirmpassword, username)
        Else
            MsgBox("Password not match!")
        End If
    End Sub
End Class