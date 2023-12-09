Imports System.Data.SQLite
Imports System.Security.Cryptography.X509Certificates

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
       COALESCE(SUM(Sales_TotalPrice), 0) as valTotalDay 
FROM Sales
WHERE strftime('%m', Sales_OrderDate) = strftime('%m', CURRENT_DATE)
GROUP BY valMonth;  
"
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    Dim valTotalDay As Decimal = Convert.ToDecimal(dr("valTotalDay"))
                    Dim valTotalDayFormatted As String = valTotalDay.ToString("C")

                    Sales.lblMonthlySales.Text = valTotalDayFormatted
                    Dashboard.lblMonthly.Text = valTotalDayFormatted

                    dr.Close()
                    connection.Close()
                Else
                    ' if no value for the current month


                End If
            End Using
        End Using
    End Sub




    Public Sub Load_WeeklySales()
        Dim valTotalWeek As Decimal
        Dim valTotalWeekFormatted As String
        Using connection As New SQLiteConnection(DBConnectionString)
            connection.Open()
            Dim query As String = "SELECT COALESCE(SUM(Sales_TotalPrice), 0) as valTotalWeek FROM Sales 
WHERE Sales_OrderDate >= DATE('now', 'weekday 0', '-6 days')
  AND Sales_OrderDate < DATE('now', 'weekday 0', '+1 day');"



            '            Select Case SUM(Sales_TotalPrice) As valTotalWeek 
            'From Sales Where Sales_OrderDate >= Date('now', 'weekday 0', '-6 days')
            '  And Sales_OrderDate < Date('now', 'weekday 0', '+1 day')
            Using cmd As New SQLiteCommand(query, connection)
                Dim dr As SQLiteDataReader
                dr = cmd.ExecuteReader
                If dr.Read Then
                    valTotalWeek = Convert.ToDecimal(dr("valTotalWeek"))
                    valTotalWeekFormatted = valTotalWeek.ToString("C")

                    Sales.lblWeeklySales.Text = valTotalWeekFormatted
                    Dashboard.lblWeekly.Text = valTotalWeekFormatted

                    dr.Close()
                    connection.Close()

                Else

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
                    Dim valTotalYear As Decimal = Convert.ToDecimal(dr("valTotalYear"))
                    Dim valTotalYearFormatted As String = valTotalYear.ToString("C")

                    Sales.lblAnnuallySales.Text = valTotalYearFormatted
                    Dashboard.lblAnnually.Text = valTotalYearFormatted

                    dr.Close()
                    connection.Close()

                Else
                    ' if no value for the current Annually
                    Sales.lblAnnuallySales.Text = "0"
                    Dashboard.lblAnnually.Text = "0"
                End If
            End Using
        End Using
    End Sub











End Module
