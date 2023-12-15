Public Class UpdateOrder

    Dim updateCustomerNumber, updateQuantity, mainID, indexer As Integer
    Dim updateOrderType, updateDescription As String



    Private Sub UpdateOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        indexer = Inventory.dgOrderList.CurrentRow.Index
        lblName.Text = Inventory.dgOrderList.Rows(indexer).Cells(1).Value.ToString
        lblDate.Text = Inventory.dgOrderList.Rows(indexer).Cells(4).Value.ToString


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnUpdateOrder_Click(sender As Object, e As EventArgs) Handles btnUpdateOrder.Click
        updateCustomerNumber = txtUpdateCustomerNumber.Text
        updateOrderType = txtUpdateOrderType.Text
        updateQuantity = txtUpdateQuantity.Text
        updateDescription = txtUpdateDescription.Text
        mainID = Inventory.idOrders
        Update_Orders(updateCustomerNumber, updateOrderType, updateQuantity, updateDescription, mainID)


    End Sub
End Class