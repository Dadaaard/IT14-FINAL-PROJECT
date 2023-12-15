Public Class AddStocks

    Dim itemname, datepurchased, StockOut As String
    Dim quantity, price, realtimePrice, realtimeQuantity, TotalAmount As Integer

    Private Sub txtPriceStocks_TextChanged(sender As Object, e As EventArgs) Handles txtPriceStocks.TextChanged
        realtimePrice = txtPriceStocks.Text

        multiplication(realtimePrice, realtimeQuantity)
    End Sub

    Private Sub txtQuantityStocks_TextChanged(sender As Object, e As EventArgs) Handles txtQuantityStocks.TextChanged
        realtimeQuantity = txtQuantityStocks.Text
        multiplication(realtimePrice, realtimeQuantity)
    End Sub

    Public Sub multiplication(ByVal realtimePrice As Integer, ByVal realtimeQuantity As Integer)
        Dim multiplication As Integer = realtimePrice * realtimeQuantity
        lblAmount.Text = multiplication

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddStocks_Click(sender As Object, e As EventArgs) Handles btnAddStocks.Click

        TotalAmount = lblAmount.Text
        itemname = txtItemNameStocks.Text
        quantity = txtQuantityStocks.Text
        datepurchased = DateTimePickerStocks.Text
        price = txtPriceStocks.Text
        Add_Stocks(itemname, quantity, datepurchased, price, TotalAmount)


    End Sub
End Class