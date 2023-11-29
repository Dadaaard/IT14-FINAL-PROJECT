<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStocks
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
        Me.DateTimePickerStocks = New System.Windows.Forms.DateTimePicker()
        Me.btnAddStocks = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPriceStocks = New System.Windows.Forms.TextBox()
        Me.txtQuantityStocks = New System.Windows.Forms.TextBox()
        Me.txtItemNameStocks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DateTimePickerStocks
        '
        Me.DateTimePickerStocks.Location = New System.Drawing.Point(204, 257)
        Me.DateTimePickerStocks.MaxDate = New Date(2023, 11, 26, 0, 0, 0, 0)
        Me.DateTimePickerStocks.Name = "DateTimePickerStocks"
        Me.DateTimePickerStocks.Size = New System.Drawing.Size(152, 26)
        Me.DateTimePickerStocks.TabIndex = 20
        Me.DateTimePickerStocks.Value = New Date(2023, 11, 26, 0, 0, 0, 0)
        '
        'btnAddStocks
        '
        Me.btnAddStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStocks.Location = New System.Drawing.Point(102, 303)
        Me.btnAddStocks.Name = "btnAddStocks"
        Me.btnAddStocks.Size = New System.Drawing.Size(174, 49)
        Me.btnAddStocks.TabIndex = 19
        Me.btnAddStocks.Text = "Add to Stocks"
        Me.btnAddStocks.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Date Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Item Name"
        '
        'txtPriceStocks
        '
        Me.txtPriceStocks.Location = New System.Drawing.Point(204, 190)
        Me.txtPriceStocks.Name = "txtPriceStocks"
        Me.txtPriceStocks.Size = New System.Drawing.Size(152, 26)
        Me.txtPriceStocks.TabIndex = 14
        '
        'txtQuantityStocks
        '
        Me.txtQuantityStocks.Location = New System.Drawing.Point(204, 134)
        Me.txtQuantityStocks.Name = "txtQuantityStocks"
        Me.txtQuantityStocks.Size = New System.Drawing.Size(152, 26)
        Me.txtQuantityStocks.TabIndex = 13
        '
        'txtItemNameStocks
        '
        Me.txtItemNameStocks.Location = New System.Drawing.Point(204, 84)
        Me.txtItemNameStocks.Name = "txtItemNameStocks"
        Me.txtItemNameStocks.Size = New System.Drawing.Size(152, 26)
        Me.txtItemNameStocks.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 37)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Add Stocks"
        '
        'AddStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 372)
        Me.Controls.Add(Me.DateTimePickerStocks)
        Me.Controls.Add(Me.btnAddStocks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPriceStocks)
        Me.Controls.Add(Me.txtQuantityStocks)
        Me.Controls.Add(Me.txtItemNameStocks)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddStocks"
        Me.Text = "AddStocks"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePickerStocks As DateTimePicker
    Friend WithEvents btnAddStocks As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPriceStocks As TextBox
    Friend WithEvents txtQuantityStocks As TextBox
    Friend WithEvents txtItemNameStocks As TextBox
    Friend WithEvents Label1 As Label
End Class
