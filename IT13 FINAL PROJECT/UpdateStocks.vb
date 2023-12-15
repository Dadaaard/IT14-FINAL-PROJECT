Public Class UpdateStocks

    Dim itemnameStocks, datepurchasedStocks As String

    Dim idStocks, quantityStocks, priceStocks, amountStocks As Integer
    Dim realtimeQuantity, realtimeprice As Integer
    Private Sub txtUpdatePrice_TextChanged(sender As Object, e As EventArgs) Handles txtUpdatePrice.TextChanged
        realtimeprice = txtUpdatePrice.Text
        updatemultiplication(realtimeprice, realtimeQuantity)
    End Sub



    Private Sub txtUpdateQuantityStocks_TextChanged(sender As Object, e As EventArgs) Handles txtUpdateQuantityStocks.TextChanged
        realtimeQuantity = txtUpdateQuantityStocks.Text
        updatemultiplication(realtimeprice, realtimeQuantity)
    End Sub

    Public Sub updatemultiplication(ByVal realtimePrice As Integer, ByVal realtimeQuantity As Integer)
        Dim multiplication As Integer = realtimePrice * realtimeQuantity
        lblAmount.Text = multiplication
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Inventory.dgvStocks.ClearSelection()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click



        idStocks = lblID.Text
        itemnameStocks = txtUpdateItemNameStocks.Text
        datepurchasedStocks = dtpUpdateStocks.Value
        quantityStocks = txtUpdateQuantityStocks.Text
        priceStocks = txtUpdatePrice.Text
        amountStocks = lblAmount.Text
        Update_Stocks(itemnameStocks, datepurchasedStocks, quantityStocks, priceStocks, amountStocks, idStocks)

    End Sub

End Class