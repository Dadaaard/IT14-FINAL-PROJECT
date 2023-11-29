Imports System.Data.SQLite

Module SalesModule
    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public DBConnectionString As String = "Data Source=C:\Users\User\Dropbox\PC\Desktop\DigimarkDB.db"


    Public Sub loadSales()
        Try

            Dim con As New SQLiteConnection(DBConnectionString)
            con.Open()

            ds = New DataSet

            da = New SQLiteDataAdapter("SELECT Sales_Id AS 'Id', Sales_ItemName AS 'Item Name',Sales_OrderDate AS 'Order Date' ,Sales_Quantity AS 'Quantity' , Sales_SetPrice AS 'Set Price' , Sales_TotalPrice AS 'Total Price' FROM Sales", con)

            da.Fill(ds, "Sales")

            Sales.dgvSales.DataSource = ds.Tables(0)

        Catch ex As SQLiteException

            MessageBox.Show("Error: " & ex.Message)

        Finally

            con.Close()

        End Try
    End Sub




    'SELECT SUM(Sales_TotalPrice) FROM Sales WHERE Sales_OrderDate BETWEEN '21/11/2023' AND '21/13/2023'









End Module
