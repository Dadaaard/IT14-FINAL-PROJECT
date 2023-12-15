<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblItemNameStocks = New System.Windows.Forms.Label()
        Me.lblDatePurchasedStocks = New System.Windows.Forms.Label()
        Me.lblPriceStocks = New System.Windows.Forms.Label()
        Me.lblQuantityStocks = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblItemNameStocks
        '
        Me.lblItemNameStocks.AutoSize = True
        Me.lblItemNameStocks.Font = New System.Drawing.Font("Tw Cen MT", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblItemNameStocks.Location = New System.Drawing.Point(19, 157)
        Me.lblItemNameStocks.Name = "lblItemNameStocks"
        Me.lblItemNameStocks.Size = New System.Drawing.Size(182, 42)
        Me.lblItemNameStocks.TabIndex = 36
        Me.lblItemNameStocks.Text = "Item Name"
        '
        'lblDatePurchasedStocks
        '
        Me.lblDatePurchasedStocks.AutoSize = True
        Me.lblDatePurchasedStocks.Font = New System.Drawing.Font("Tw Cen MT", 9.0!)
        Me.lblDatePurchasedStocks.Location = New System.Drawing.Point(211, 304)
        Me.lblDatePurchasedStocks.Name = "lblDatePurchasedStocks"
        Me.lblDatePurchasedStocks.Size = New System.Drawing.Size(122, 20)
        Me.lblDatePurchasedStocks.TabIndex = 35
        Me.lblDatePurchasedStocks.Text = "Date Purchased"
        '
        'lblPriceStocks
        '
        Me.lblPriceStocks.AutoSize = True
        Me.lblPriceStocks.Font = New System.Drawing.Font("Tw Cen MT", 9.0!)
        Me.lblPriceStocks.Location = New System.Drawing.Point(211, 261)
        Me.lblPriceStocks.Name = "lblPriceStocks"
        Me.lblPriceStocks.Size = New System.Drawing.Size(44, 20)
        Me.lblPriceStocks.TabIndex = 34
        Me.lblPriceStocks.Text = "Price"
        '
        'lblQuantityStocks
        '
        Me.lblQuantityStocks.AutoSize = True
        Me.lblQuantityStocks.Font = New System.Drawing.Font("Tw Cen MT", 9.0!)
        Me.lblQuantityStocks.Location = New System.Drawing.Point(211, 222)
        Me.lblQuantityStocks.Name = "lblQuantityStocks"
        Me.lblQuantityStocks.Size = New System.Drawing.Size(72, 20)
        Me.lblQuantityStocks.TabIndex = 33
        Me.lblQuantityStocks.Text = "Quantity"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(172, 383)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 39)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(39, 301)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 23)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Date Purchased"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(39, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Price Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(97, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 23)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Quantity"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(487, 135)
        Me.Panel2.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Tw Cen MT", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(14, 64)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(288, 58)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Stock Details"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 20)
        Me.Label9.TabIndex = 44
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Tw Cen MT", 9.0!)
        Me.lblTotalAmount.Location = New System.Drawing.Point(211, 351)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(62, 20)
        Me.lblTotalAmount.TabIndex = 46
        Me.lblTotalAmount.Text = "Amount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(39, 348)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 23)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Total Amount"
        '
        'ViewStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(483, 455)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblItemNameStocks)
        Me.Controls.Add(Me.lblDatePurchasedStocks)
        Me.Controls.Add(Me.lblPriceStocks)
        Me.Controls.Add(Me.lblQuantityStocks)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ViewStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblItemNameStocks As Label
    Friend WithEvents lblDatePurchasedStocks As Label
    Friend WithEvents lblPriceStocks As Label
    Friend WithEvents lblQuantityStocks As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label2 As Label
End Class
