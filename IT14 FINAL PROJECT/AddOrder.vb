﻿Public Class AddOrder

    Dim CustomerNumber, Quantity As Integer
    Dim CustomerName, OrderType, Description, OrderDate As String

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click

        CustomerName = txtCustomerName.Text
        CustomerNumber = txtCustomerNumber.Text
        OrderDate = datetime.Value.Date
        OrderType = txtOrderType.Text
        Quantity = txtQuantity.Text
        Description = RichTextBox1.Text

        Add_Orders(CustomerName, CustomerNumber, OrderDate, OrderType, Quantity, Description)
    End Sub
End Class