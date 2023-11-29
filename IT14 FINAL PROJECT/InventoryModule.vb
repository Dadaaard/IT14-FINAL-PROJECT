
Imports System.Data.SQLite

Module InventoryModule
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

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            con.Close()

        End Try
    End Sub

    Public Sub Add_Orders(ByVal CustomerName As String, ByVal CustomerNumber As Integer, ByVal OrderDate As String, ByVal OrderType As String, ByVal Quantity As Integer, ByVal Description As String)
        Try
            Using connection As New SQLiteConnection(DBConnectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Orders (Orders_CustomerName,Orders_CustomerNumber,Orders_OrderDate,Orders_OrderType,Orders_Quantity,Orders_Description) VALUES (@CustomerName, @CustomerNumber,@OrderDate,@OrderType,@Quantity,@Description)"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName)
                    cmd.Parameters.AddWithValue("@CustomerNumber", CustomerNumber)
                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate)
                    cmd.Parameters.AddWithValue("@OrderType", OrderType)
                    cmd.Parameters.AddWithValue("@Quantity", Quantity)
                    cmd.Parameters.AddWithValue("@Description", Description)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Order added successfully.")
                        loadOrders()
                        connection.Close()
                        AddOrder.Close()

                    Else
                        MessageBox.Show("Failed to add order.")
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

        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "DELETE from Orders WHERE Orders_Id =  '" & idOrders & "' "
            Using cmd As New SQLiteCommand(query, connection)
                cmd.ExecuteNonQuery()
                connection.Close()
                loadOrders()
            End Using
        End Using
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

                Dim query As String = "INSERT INTO Sales (Sales_Id,Sales_ItemName,Sales_OrderDate,Sales_Quantity,Sales_SetPrice,Sales_TotalPrice) VALUES ('" & id & "', '" & itemname & "','" & orderdate & "','" & quantity & "', '" & setprice & "','" & totalprice & "')"
                Using cmd As New SQLiteCommand(query, connection)
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Price is Set!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Pricing.Close()
                    Delete_Orders(idStocks)
                    connection.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message & "openCon", "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
