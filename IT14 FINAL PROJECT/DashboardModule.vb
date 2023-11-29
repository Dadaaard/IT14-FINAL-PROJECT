Imports System.Data.SQLite

Module DashboardModule
    Public con As New SQLiteConnection
    Public cmd As New SQLiteCommand
    Public dr As SQLiteDataReader
    Public da As SQLiteDataAdapter
    Public dt As New DataTable
    Public ds As DataSet
    Public query As String

    Public DBConnectionString As String = "Data Source=C:\Users\User\Dropbox\PC\Desktop\DigimarkDB.db"
    Public Sub View_Dashboard()
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT
    (SELECT COUNT(*) FROM Stocks) AS stock_count,
    (SELECT COUNT(*) FROM Orders) AS order_count,
    (SELECT COUNT(*) FROM Sales) AS sales_count "
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dashboard.lblPendingOrders.Text = dr("order_count")
                    Dashboard.lblCompletedOrders.Text = dr("sales_count")
                    Dashboard.lblOverallStocks.Text = dr("stock_count")
                    dr.Close()
                    connection.Close()


                End If
            End Using
        End Using
    End Sub

    Public Sub Load_EverySales()
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = ""
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dashboard.lblWeekly.Text = dr("order_count")
                    Dashboard.lblMonthly.Text = dr("sales_count")
                    Dashboard.lblAnnually.Text = dr("stock_count")
                    dr.Close()
                    connection.Close()


                End If
            End Using
        End Using

    End Sub
End Module




'SELECT
'    strftime('%m', 'now') AS month,
'    SUM(Sales_TotalPrice) AS total_sales
'FROM
'Sales
'ORDER BY
'month;







'"SELECT sum(amount) FROM demo WHERE current_date  BETWEEN '" + start_date + "' AND '" + end_date + "'