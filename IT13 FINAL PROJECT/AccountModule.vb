Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles

Module AccountModule


    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public DBConnectionString As String = "Data Source=C:\Users\User\Dropbox\PC\Desktop\DigimarkDB.db"

    Public Sub Login_Account(ByVal username As String, ByVal password As String)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim cmd As New SQLiteCommand("SELECT * FROM Accounts WHERE Accounts_Username ='" & username & "' And Accounts_Password = '" & password & "'", connection)
            Dim myread As SQLiteDataReader = cmd.ExecuteReader
            AccountDetails.lblUsername.Text = username
            If myread.Read Then
                MessageBox.Show("Account Logged In!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.Show()
                myread.Close()
                Login.Close()
            Else
                MessageBox.Show("The username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Login.txtUsername.Clear()
                Login.txtPassword.Clear()
            End If
            connection.Close()
        End Using
    End Sub

    Public Sub Create_Account(ByVal username As String, ByVal email As String, ByVal confirmpassword As String)
        Try
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Accounts (Accounts_Username,Accounts_Email,Accounts_Password) VALUES (@username,@email,@password)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@email", email)
                    cmd.Parameters.AddWithValue("@password", confirmpassword)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Account Created Successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        connection.Close()
                    Else
                        MessageBox.Show("Failed to create!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)

        End Try
    End Sub

    Public Sub Update_Password(ByVal currentPassword As String, ByVal confirmpassword As String, ByVal username As String)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "UPDATE Accounts SET Accounts_Password = @password WHERE Accounts_Username = '" & username & "'"
            Using cmd As New SQLiteCommand(query, connection)

                With cmd
                    .Parameters.AddWithValue("@password", confirmpassword)
                    .Parameters.AddWithValue("@oldpassword", currentPassword)
                    .ExecuteNonQuery()
                    MessageBox.Show("Saved!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    MessageBox.Show("Account Logged Out!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Login.Show()
                    AccountDetails.Close()
                    Inventory.Close()
                    Sales.Close()
                    Dashboard.Close()
                End With
                connection.Close()
            End Using
        End Using
    End Sub

    Public Sub Logout_Account()
        MessageBox.Show("Account Logged Out!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Login.Show()
        Sales.Close()
        Inventory.Close()
        Dashboard.Close()
    End Sub
End Module
