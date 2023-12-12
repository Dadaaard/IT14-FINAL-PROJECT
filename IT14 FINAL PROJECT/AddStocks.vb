Public Class AddStocks

    Dim itemname, datepurchased, StockOut As String
    Dim quantity, price As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddStocks_Click(sender As Object, e As EventArgs) Handles btnAddStocks.Click

        itemname = txtItemNameStocks.Text
        quantity = txtQuantityStocks.Text
        datepurchased = DateTimePickerStocks.value
        price = txtPriceStocks.Text
        Dim StockIn As Date = System.DateTime.Now.ToString("MM/MM/yyyy HH:mm:ss")
        Dim StockOut As String = ""
        Add_Stocks(itemname, quantity, datepurchased, price, StockIn, StockOut)


    End Sub
End Class