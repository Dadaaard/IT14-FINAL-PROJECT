Public Class Sales
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Inventory.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSales()
        Load_MonthlySales()
        Load_WeeklySales()
        Load_AnnuallySales()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Login.Show()
        Me.Close()

    End Sub
End Class