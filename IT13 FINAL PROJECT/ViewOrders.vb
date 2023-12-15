Public Class ViewOrders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_Orders()
        Get_UsedItems()
    End Sub
End Class