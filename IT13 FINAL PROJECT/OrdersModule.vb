
Imports System.Data.SQLite
Imports System.Windows.Forms.VisualStyles

Module OrdersModule
    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public DBConnectionString As String = "Data Source=C:\Users\User\Dropbox\PC\Desktop\DigimarkDB.db"

    'Public Sub openCon()
    '    Try
    '        con = New SQLiteConnection

    '        If con.State = ConnectionState.Open Then con.Close()

    '        con.ConnectionString = DBConnectionString
    '        con.Open()

    '        'MsgBox("Connection Success!")'

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message & "openCon", "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub


    Public Sub loadOrders()
        Try


            Dim con As New SQLiteConnection(DBConnectionString)
            con.Open()
            ds = New DataSet

            da = New SQLiteDataAdapter("SELECT Orders_Id AS 'Id', Orders_CustomerName AS 'Customer Name', Orders_OrderType AS 'Type Of Order', Orders_Quantity AS 'Quantity', Orders_OrderDate AS 'Order Date' FROM Orders", con)

            da.Fill(ds, "Orders")

            Inventory.dgOrderList.DataSource = ds.Tables(0)
            Inventory.dgOrderList.ClearSelection()

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            con.Close()

        End Try
    End Sub

    Public Sub Add_Orders(ByVal CustomerName As String, ByVal CustomerNumber As String, ByVal OrderDate As String, ByVal OrderType As String, ByVal Quantity As Integer, ByVal Description As String, ByVal selectedItem As String, ByVal setQuantity As Integer)
        Try
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim insertOrderQuery As String = "INSERT INTO Orders (Orders_CustomerName, Orders_CustomerNumber, Orders_OrderDate, Orders_OrderType, Orders_Quantity, Orders_Description) VALUES (@CustomerName, @CustomerNumber, @OrderDate, @OrderType, @Quantity, @Description)"
                Using cmd As New SQLiteCommand(insertOrderQuery, connection)
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName)
                    cmd.Parameters.AddWithValue("@CustomerNumber", CustomerNumber)
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate)
                    cmd.Parameters.AddWithValue("@OrderType", OrderType)
                    cmd.Parameters.AddWithValue("@Quantity", Quantity)
                    cmd.Parameters.AddWithValue("@Description", Description)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Order Added Successfully!", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        loadOrders()

                        ' Retrieve the last inserted Orders_Id
                        Dim getLastInsertedIdQuery As String = "SELECT last_insert_rowid()"
                        Using getLastIdCmd As New SQLiteCommand(getLastInsertedIdQuery, connection)
                            Dim ordersId As Integer = Convert.ToInt32(getLastIdCmd.ExecuteScalar())

                            ' Insert into Items_Used table
                            Dim insertItemsUsedQuery As String = "INSERT INTO Items_Used (Name, Quantity, Orders_Id) VALUES (@Name, @Quantity, @OrdersId)"
                            Using insertItemsUsedCmd As New SQLiteCommand(insertItemsUsedQuery, connection)
                                insertItemsUsedCmd.Parameters.AddWithValue("@Name", selectedItem)
                                insertItemsUsedCmd.Parameters.AddWithValue("@Quantity", setQuantity)
                                insertItemsUsedCmd.Parameters.AddWithValue("@OrdersId", ordersId)
                                insertItemsUsedCmd.ExecuteNonQuery()
                            End Using
                            connection.Close()

                            AddOrder.Close()
                        End Using
                    Else
                        MessageBox.Show("Failed to add Order!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub Update_Orders(ByVal updateCustomerNumber As Integer, ByVal updateOrderType As String, ByVal updateQuantity As Integer, ByVal updateDescription As String, ByVal mainID As Integer)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "UPDATE Orders SET Orders_CustomerNumber = @CustomerNumber, Orders_OrderType = @OrderType, Orders_Quantity = @Quantity, Orders_Description = @Description WHERE Orders_Id = @id;"
            Using cmd As New SQLiteCommand(query, connection)

                With cmd
                    .Parameters.AddWithValue("@CustomerNumber", updateCustomerNumber)
                    .Parameters.AddWithValue("@OrderType", updateOrderType)
                    .Parameters.AddWithValue("@Quantity", updateQuantity)
                    .Parameters.AddWithValue("@Description", updateDescription)
                    .Parameters.AddWithValue("@id", mainID)
                    .ExecuteNonQuery()

                End With
                MsgBox("Order Successfully Updated!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                loadOrders()
                connection.Close()
                UpdateOrder.Close()

            End Using
        End Using
    End Sub
    Public Sub Delete_Orders(ByVal idOrders As Integer)

        'Using connection As New SQLiteConnection(DBConnectionString)
        '    connection.Open()

        '    Dim query As String = "DELETE from Orders WHERE Orders_Id =  '" & idOrders & "' "
        '    Using cmd As New SQLiteCommand(query, connection)
        '        cmd.ExecuteNonQuery()
        '        connection.Close()
        '        loadOrders()
        '    End Using
        'End Using

        'Dim result As DialogResult = MessageBox.Show("Are you sure you want To delete this Order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        'If result = DialogResult.Yes Then
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "DELETE from Orders WHERE Orders_Id =  '" & idOrders & "' "
            Using cmd As New SQLiteCommand(query, connection)
                cmd.ExecuteNonQuery()
                connection.Close()
                loadOrders()
            End Using
        End Using
        'Else
        '    Inventory.dgOrderList.ClearSelection()
        'End If


    End Sub

    Public Sub View_Orders()

        Dim idOrders As Integer = Inventory.dgOrderList.CurrentRow.Cells(0).Value

        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT Orders_CustomerName, Orders_CustomerNumber,Orders_OrderDate, Orders_OrderType, Orders_Quantity, Orders_Description FROM Orders WHERE Orders_Id = '" & idOrders & "'  "
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    ViewOrders.lblCustomerName.Text = dr(0).ToString
                    ViewOrders.lblCustomerNumber.Text = dr(1).ToString
                    ViewOrders.lblOrderDate.Text = dr(2).ToString
                    ViewOrders.lblOrderType.Text = dr(3).ToString
                    ViewOrders.lblQuantity.Text = dr(4).ToString
                    ViewOrders.lblDescription.Text = dr(5).ToString
                    dr.Close()

                    connection.Close()
                Else
                    MsgBox("No Data Found!!")
                End If

            End Using
        End Using
    End Sub

    Public Sub Get_UsedItems()
        Try
            If Inventory.dgOrderList.CurrentRow IsNot Nothing Then
                Dim idOrders As Integer = Convert.ToInt32(Inventory.dgOrderList.CurrentRow.Cells(0).Value)

                Using connection As New SQLiteConnection(DBConnectionString)
                    connection.Open()

                    Dim query As String = "SELECT Name, Quantity FROM Items_Used WHERE Orders_Id = '" & idOrders & "'"
                    Using cmd As New SQLiteCommand(query, connection)
                        Dim dr As SQLiteDataReader = cmd.ExecuteReader()

                        If dr.Read() Then
                            ' Check for null before accessing values
                            Dim name As String = dr(0).ToString()
                            Dim quantity As Integer = dr(1).ToString()
                            ViewOrders.DataGridView1.Rows.Add(name, quantity)
                        Else
                            MessageBox.Show("No items Used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If

                        dr.Close()
                    End Using
                End Using
            Else
                MessageBox.Show("No selected row in the DataGridView!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub


    Public Sub Load_Sales(ByVal price As Integer)

        Dim indexCount As Integer = Inventory.dgOrderList.CurrentRow.Index

        Dim id As Integer = Inventory.dgOrderList.Rows(indexCount).Cells(0).Value
        Dim itemname As String = Inventory.dgOrderList.Rows(indexCount).Cells(2).Value
        Dim orderdate As String = Inventory.dgOrderList.Rows(indexCount).Cells(4).Value
        Dim quantity As Integer = Inventory.dgOrderList.Rows(indexCount).Cells(3).Value
        Dim setprice As Integer = price
        Dim totalprice As Integer = setprice * quantity

        Dim idStocks As Integer = Inventory.dgOrderList.CurrentRow.Cells(0).Value
        Try
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Sales (Sales_ItemName,Sales_OrderDate,Sales_Quantity,Sales_SetPrice, Sales_TotalPrice,Items_Id,Orders_Id) VALUES ('" & itemname & "','" & orderdate & "','" & quantity & "', '" & setprice & "','" & totalprice & "',(SELECT Items_Id FROM Items_Used WHERE Orders_Id = '" & id & "' ),'" & id & "')"
                Using cmd As New SQLiteCommand(query, connection)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        loadOrders()
                        MessageBox.Show("Price is Set!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Pricing.Close()
                        Delete_Orders(idStocks)

                        Dim getLastInsertedIdQuery As String = "SELECT last_insert_rowid()"
                        Using getLastIdCmd As New SQLiteCommand(getLastInsertedIdQuery, connection)
                            Dim SalesId As Integer = Convert.ToInt32(getLastIdCmd.ExecuteScalar())

                            ' Insert into Items_Used table
                            Dim insertItemsUsedQuery As String = "UPDATE Items_Used SET Sales_Id = '" & SalesId & "' WHERE Orders_Id = '" & id & "'"
                            Using insertItemsUsedCmd As New SQLiteCommand(insertItemsUsedQuery, connection)
                                insertItemsUsedCmd.ExecuteNonQuery()
                            End Using
                            Stock_Out(SalesId)
                            connection.Close()
                            AddOrder.Close()
                        End Using

                    Else
                        MessageBox.Show("Error!.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message & "openCon", "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub Stock_Out(ByVal SalesId As Integer)
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()
            Dim query As String = "UPDATE Stocks SET Stocks_Quantity = Stocks_Quantity - (SELECT SUM(Quantity) FROM Items_Used WHERE Items_Used.Sales_Id = '" & SalesId & "' )"
            Using cmd As New SQLiteCommand(query, connection)
                cmd.ExecuteReader()
                loadStocks()
                connection.Close()
            End Using
        End Using
    End Sub

End Module
