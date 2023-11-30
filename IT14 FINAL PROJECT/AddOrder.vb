Public Class AddOrder

    Dim Quantity As Integer
    Dim CustomerName, OrderType, Description, OrderDate, CustomerNumber As String


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

        CustomerName = txtCustomerName.Text
        CustomerNumber = txtCustomerNumber.Text
        OrderDate = datetime.Text
        OrderType = txtOrderType.Text
        Quantity = txtQuantity.Text
        Description = RichTextBox1.Text
        Add_Orders(CustomerName, CustomerNumber, OrderDate, OrderType, Quantity, Description)

    End Sub
End Class