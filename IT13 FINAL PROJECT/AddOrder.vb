Public Class AddOrder

    Dim Quantity As Integer
    Dim CustomerName, OrderType, Description, OrderDate, CustomerNumber As String
    Dim selectedItem As String
    Dim setQuantity As Integer
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim preselectedItem As String = ComboBox1.SelectedItem
        Dim preetQuantity As Integer = NumericUpDown1.Value
        DataGridView1.Rows.Add(preselectedItem, preetQuantity)
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.SelectedItem IsNot Nothing Then
            NumericUpDown1.Visible = True
            Button2.Visible = True
        End If


    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()

        ' Loop through the rows of the DataGridView
        For Each row As DataGridViewRow In Inventory.dgvStocks.Rows
            ' Check if the row is not a header and is not null
            If Not row.IsNewRow Then
                ' Get the value from the specified column (e.g., column 1)
                Dim cellValue As String = row.Cells(1).Value.ToString()

                ' Add the value to the ComboBox
                ComboBox1.Items.Add(cellValue)

            ElseIf ComboBox1.SelectedValue = True Then
                NumericUpDown1.Visible = True

            End If
        Next
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim rows As Integer = DataGridView1.RowCount


        CustomerName = txtCustomerName.Text
        CustomerNumber = txtCustomerNumber.Text
        OrderDate = datetime.Text
        OrderType = txtOrderType.Text
        Quantity = txtQuantity.Text
        Description = RichTextBox1.Text

        For Each row As DataGridViewRow In DataGridView1.Rows
            selectedItem = CStr(row.Cells(0).FormattedValue)
            setQuantity = CStr(row.Cells(1).FormattedValue)
        Next row

        If Description = "" Then
            Description = "..."
            Add_Orders(CustomerName, CustomerNumber, OrderDate, OrderType, Quantity, Description, selectedItem, setQuantity)
        Else
            Add_Orders(CustomerName, CustomerNumber, OrderDate, OrderType, Quantity, Description, selectedItem, setQuantity)

        End If

    End Sub
End Class