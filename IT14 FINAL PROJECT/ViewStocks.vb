Public Class ViewStocks
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Inventory.dgvStocks.ClearSelection()
    End Sub

    Private Sub ViewStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_Stocks()
    End Sub
End Class