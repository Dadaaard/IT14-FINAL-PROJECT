Public Class UpdateStocks

    Dim itemnameStocks, datepurchasedStocks As String

    Dim idStocks, quantityStocks, priceStocks As Integer

    Private Sub UpdateStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click



        idStocks = lblID.Text
        itemnameStocks = txtUpdateItemNameStocks.Text
        datepurchasedStocks = dtpUpdateStocks.Value
        quantityStocks = txtUpdateQuantityStocks.Text
        priceStocks = txtUpdatePrice.Text

        Update_Stocks(itemnameStocks, datepurchasedStocks, quantityStocks, priceStocks, idStocks)

    End Sub

End Class