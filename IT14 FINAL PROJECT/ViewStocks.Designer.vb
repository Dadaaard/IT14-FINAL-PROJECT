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
        Me.SuspendLayout()
        '
        'lblItemNameStocks
        '
        Me.lblItemNameStocks.AutoSize = True
        Me.lblItemNameStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemNameStocks.Location = New System.Drawing.Point(154, 41)
        Me.lblItemNameStocks.Name = "lblItemNameStocks"
        Me.lblItemNameStocks.Size = New System.Drawing.Size(182, 37)
        Me.lblItemNameStocks.TabIndex = 36
        Me.lblItemNameStocks.Text = "Item Name"
        '
        'lblDatePurchasedStocks
        '
        Me.lblDatePurchasedStocks.AutoSize = True
        Me.lblDatePurchasedStocks.Location = New System.Drawing.Point(251, 200)
        Me.lblDatePurchasedStocks.Name = "lblDatePurchasedStocks"
        Me.lblDatePurchasedStocks.Size = New System.Drawing.Size(124, 20)
        Me.lblDatePurchasedStocks.TabIndex = 35
        Me.lblDatePurchasedStocks.Text = "Date Purchased"
        '
        'lblPriceStocks
        '
        Me.lblPriceStocks.AutoSize = True
        Me.lblPriceStocks.Location = New System.Drawing.Point(251, 161)
        Me.lblPriceStocks.Name = "lblPriceStocks"
        Me.lblPriceStocks.Size = New System.Drawing.Size(44, 20)
        Me.lblPriceStocks.TabIndex = 34
        Me.lblPriceStocks.Text = "Price"
        '
        'lblQuantityStocks
        '
        Me.lblQuantityStocks.AutoSize = True
        Me.lblQuantityStocks.Location = New System.Drawing.Point(251, 118)
        Me.lblQuantityStocks.Name = "lblQuantityStocks"
        Me.lblQuantityStocks.Size = New System.Drawing.Size(68, 20)
        Me.lblQuantityStocks.TabIndex = 33
        Me.lblQuantityStocks.Text = "Quantity"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(182, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 39)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Date Purchased"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Price Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(64, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 20)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Quantity"
        '
        'ViewStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 344)
        Me.Controls.Add(Me.lblItemNameStocks)
        Me.Controls.Add(Me.lblDatePurchasedStocks)
        Me.Controls.Add(Me.lblPriceStocks)
        Me.Controls.Add(Me.lblQuantityStocks)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "ViewStocks"
        Me.Text = "ViewStocks"
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
End Class
