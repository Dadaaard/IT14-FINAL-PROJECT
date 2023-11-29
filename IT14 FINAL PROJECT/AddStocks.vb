Public Class AddStocks

    Dim itemname, datepurchased As String
    Dim quantity, price As Integer

    Private Sub AddStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddStocks_Click(sender As Object, e As EventArgs) Handles btnAddStocks.Click

        itemname = txtItemNameStocks.Text
        quantity = txtQuantityStocks.Text
        datepurchased = DateTimePickerStocks.Text
        price = txtPriceStocks.Text


        Add_Stocks(itemname, quantity, datepurchased, price)


    End Sub
End Class