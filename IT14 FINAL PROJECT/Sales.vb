Imports System.Drawing.Drawing2D

Public Class Sales

    Dim itemname, orderdate As String
    Dim quantity, setprice, totalprice, idSales As Integer

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Inventory.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub Sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim GBrush As New LinearGradientBrush(Me.DisplayRectangle, Color.DarkSlateGray, Color.DarkCyan, LinearGradientMode.Vertical)

        Me.BackgroundImage = New Bitmap(Me.Width, Me.Height)

        Dim g As Graphics = Graphics.FromImage(Me.BackgroundImage)

        g.FillRectangle(GBrush, Me.DisplayRectangle)

        loadSales()
        Load_MonthlySales()
        Load_WeeklySales()
        Load_AnnuallySales()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Logout_Account()

    End Sub



    Private Sub dgvSales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSales.CellContentClick
        idSales = dgvSales.CurrentRow.Cells(0).Value

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            UpdateSales.Show()
            UpdateSales.lblId.Text = idSales
        Else
            UpdateStocks.Close()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Logout_Account()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        AccountDetails.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateSales.Show()

    End Sub
End Class