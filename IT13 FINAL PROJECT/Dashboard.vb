Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Dashboard
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inventory.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sales.Show()
        Me.Close()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim GBrush As New LinearGradientBrush(Me.DisplayRectangle, Color.DarkSlateGray, Color.DarkCyan, LinearGradientMode.Vertical)

        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)

        Dim g As Graphics = Graphics.FromImage(Me.BackgroundImage)

        g.FillRectangle(GBrush, Me.DisplayRectangle)

        View_Dashboard()
        Load_MonthlySales()
        Load_WeeklySales()
        Load_AnnuallySales()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        AccountDetails.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Logout_Account()
    End Sub
End Class