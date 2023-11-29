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

    Public Sub Load_MonthlySales()
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT strftime('%m', Sales_OrderDate) as valMonth, 
           SUM(Sales_TotalPrice) as valTotalDay 
    FROM Sales
    WHERE strftime('%m', Sales_OrderDate) = strftime('%m', CURRENT_DATE)
    GROUP BY valMonth;"
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dim valTotalDay As String = dr("valTotalDay").ToString()
                    Dim valTotalDayWithPHP As String = valTotalDay & " PHP"

                    Sales.lblMonthlySales.Text = valTotalDayWithPHP
                    Dashboard.lblMonthly.Text = valTotalDayWithPHP

                    dr.Close()
                    connection.Close()
                End If
            End Using
        End Using
    End Sub



    Public Sub Load_WeeklySales()
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT SUM(Sales_TotalPrice) as valTotalWeek 
FROM Sales WHERE Sales_OrderDate >= DATE('now', 'weekday 0', '-6 days')
  AND Sales_OrderDate < DATE('now', 'weekday 0', '+1 day');"
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dim valTotalWeek As String = dr("valTotalWeek").ToString()
                    Dim valTotalWeekWithPHP As String = valTotalWeek & " PHP"

                    Sales.lblWeeklySales.Text = valTotalWeekWithPHP
                    Dashboard.lblWeekly.Text = valTotalWeekWithPHP

                    dr.Close()
                    connection.Close()
                End If
            End Using
        End Using
    End Sub




    Public Sub Load_AnnuallySales()
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()

            Dim query As String = "SELECT strftime('%Y', Sales_OrderDate) as valYear,
           SUM(Sales_TotalPrice) as valTotalYear 
    FROM Sales
    WHERE strftime('%Y', Sales_OrderDate) = strftime('%Y', 'now')
    GROUP BY valYear;"
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dim valTotalYear As String = dr("valTotalYear").ToString()
                    Dim valTotalYearWithPHP As String = valTotalYear & " PHP"

                    Sales.lblAnnuallySales.Text = valTotalYearWithPHP
                    Dashboard.lblAnnually.Text = valTotalYearWithPHP

                    dr.Close()
                    connection.Close()
                End If
            End Using
        End Using
    End Sub
    'SELECT SUM(Sales_TotalPrice) FROM Sales WHERE Sales_OrderDate BETWEEN '21/11/2023' AND '21/13/2023'









End Module
