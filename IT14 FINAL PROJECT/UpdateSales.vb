Public Class UpdateSales

    Dim itemname, orderdate As String
    Dim idsales, quantity, setprice, totalprice As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        idsales = lblId.Text
        itemname = txtItemName.Text
        orderdate = DateTimePicker1.Value
        quantity = txtQuantity.Text
        setprice = txtSetPrice.Text
        totalprice = txtTotalPrice.Text


    End Sub
End Class