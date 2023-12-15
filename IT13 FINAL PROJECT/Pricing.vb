Public Class Pricing

    Dim price As Integer? = Nothing
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        price = txtPrice.Text
        Load_Sales(price)


    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub
End Class