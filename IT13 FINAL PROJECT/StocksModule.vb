Imports System.Data.SQLite

Module StocksModule
    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public DBConnectionString As String = "Data Source=C:\Users\User\Dropbox\PC\Desktop\DigimarkDB.db"

    'Add

    Public Sub Add_Stocks(ByVal itemname As String, ByVal quantity As Integer, ByVal datepurchased As String, ByVal price As Integer, ByVal TotalAmount As Integer)
        Try
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Stocks (Stocks_ItemName,Stocks_Quantity,Stocks_Price,Stocks_DatePurchased,Stocks_TotalAmount) VALUES (@ItemName, @Quantity,@Price,@DatePurchased,@TotalAmount)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ItemName", itemname)
                    cmd.Parameters.AddWithValue("@Quantity", quantity)
                    cmd.Parameters.AddWithValue("@Price", price)
                    cmd.Parameters.AddWithValue("@DatePurchased", datepurchased)
                    cmd.Parameters.AddWithValue("@TotalAmount", TotalAmount)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Order Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        connection.Close()
                        loadStocks()
                        Inventory.dgvStocks.ClearSelection()
                        AddStocks.Close()

                    Else
                        MessageBox.Show("Failed to add Order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    'Read


    Public Sub loadStocks()
        Try

            Dim con As New SQLiteConnection(DBConnectionString)
            con.Open()

            ds = New DataSet

            da = New SQLiteDataAdapter("SELECT Stocks_Id AS 'Id', Stocks_ItemName AS 'Item Name', Stocks_Quantity AS 'Quantity' FROM Stocks", con)

            da.Fill(ds, "Stocks")

            Inventory.dgvStocks.DataSource = ds.Tables(0)
            Inventory.dgvStocks.ClearSelection()
            con.Close()

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            con.Close()

        End Try
    End Sub

    'Update


    Public Sub Update_Stocks(ByVal itemnameStocks As String, ByVal datepurchasedStocks As String, ByVal quantityStocks As String, ByVal priceStocks As String, ByVal amountStocks As Integer, ByVal idStocks As String)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "UPDATE Stocks SET Stocks_ItemName = @ItemName, Stocks_Quantity = @Quantity, Stocks_Price = @Price, Stocks_DatePurchased = @DatePurchased, Stocks_TotalAmount = @TotalAmount WHERE Stocks_Id = '" & idStocks & "' "
            Using cmd As New SQLiteCommand(query, connection)

                With cmd
                    .Parameters.AddWithValue("@ItemName", itemnameStocks)
                    .Parameters.AddWithValue("@Quantity", quantityStocks)
                    .Parameters.AddWithValue("@Price", priceStocks)
                    .Parameters.AddWithValue("@DatePurchased", datepurchasedStocks)
                    .Parameters.AddWithValue("@TotalAmount", amountStocks)
                    .ExecuteNonQuery()
                    UpdateStocks.Close()


                End With
                MsgBox("Stocks Successfully Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connection.Close()
                loadStocks()

                UpdateOrder.Close()

            End Using
        End Using
    End Sub

    'Update Quantity Stocks

    Public Sub Update_QuantityStocks(ByVal quantityval As Integer, ByVal idStocks As Integer)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "UPDATE Stocks SET  Stocks_Quantity = @Quantity WHERE Stocks_Id =  '" & idStocks & "' "
            Using cmd As New SQLiteCommand(query, connection)

                With cmd
                    .Parameters.AddWithValue("@Quantity", quantityval)
                    .ExecuteNonQuery()
                    UpdateStocks.Close()


                End With
                MsgBox("Quantity Successfully Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Inventory.numeric1.Visible = False
                Inventory.btnUpdateQuantity.Visible = False
                connection.Close()
                loadStocks()

                UpdateOrder.Close()

            End Using
        End Using
    End Sub

    'DELETE

    Public Sub Delete_Stocks(ByVal idStocks As Integer)

        Dim result As DialogResult = MessageBox.Show("Are you sure you want To delete this Stock?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim query As String = "DELETE from Stocks WHERE Stocks_Id =  '" & idStocks & "' "
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.ExecuteNonQuery()
                    connection.Close()
                    MessageBox.Show("Successfully Deleted!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    connection.Close()
                    loadStocks()

                End Using
            End Using
        Else
            Inventory.dgvStocks.ClearSelection()
        End If
    End Sub

    Public Sub View_Stocks()
        Dim idStocks As Integer = Inventory.dgvStocks.CurrentRow.Cells(0).Value
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT Stocks_ItemName, Stocks_Quantity, Stocks_Price, Stocks_DatePurchased, Stocks_TotalAmount FROM Stocks WHERE Stocks_Id = '" & idStocks & "'  "
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dim converted As Decimal = Convert.ToDecimal(dr(2).ToString)
                    Dim valPesoFormatted As String = converted.ToString("C")
                    ViewStocks.lblItemNameStocks.Text = dr(0).ToString()
                    ViewStocks.lblQuantityStocks.Text = dr(1).ToString()
                    ViewStocks.lblPriceStocks.Text = valPesoFormatted
                    ViewStocks.lblDatePurchasedStocks.Text = dr(3).ToString()

                    Dim convertPhp As Decimal = Convert.ToDecimal(dr(4).ToString)
                    Dim valPesoFormattedAmount As String = convertPhp.ToString("C")
                    ViewStocks.lblTotalAmount.Text = valPesoFormattedAmount

                    dr.Close()
                    connection.Close()

                Else
                    MessageBox.Show("No Data Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
End Module
