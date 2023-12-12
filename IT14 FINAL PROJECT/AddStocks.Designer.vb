<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePickerStocks
        '
        Me.DateTimePickerStocks.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerStocks.Location = New System.Drawing.Point(204, 355)
        Me.DateTimePickerStocks.MaxDate = New Date(9998, 11, 26, 0, 0, 0, 0)
        Me.DateTimePickerStocks.Name = "DateTimePickerStocks"
        Me.DateTimePickerStocks.Size = New System.Drawing.Size(269, 26)
        Me.DateTimePickerStocks.TabIndex = 20
        Me.DateTimePickerStocks.Value = New Date(2023, 11, 26, 0, 0, 0, 0)
        '
        'btnAddStocks
        '
        Me.btnAddStocks.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStocks.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStocks.Location = New System.Drawing.Point(259, 399)
        Me.btnAddStocks.Name = "btnAddStocks"
        Me.btnAddStocks.Size = New System.Drawing.Size(187, 41)
        Me.btnAddStocks.TabIndex = 19
        Me.btnAddStocks.Text = "Add to Stocks"
        Me.btnAddStocks.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 355)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 26)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Date Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 26)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Price Purchased"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(90, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 26)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 26)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Item Name"
        '
        'txtPriceStocks
        '
        Me.txtPriceStocks.Location = New System.Drawing.Point(204, 268)
        Me.txtPriceStocks.Name = "txtPriceStocks"
        Me.txtPriceStocks.Size = New System.Drawing.Size(269, 26)
        Me.txtPriceStocks.TabIndex = 14
        '
        'txtQuantityStocks
        '
        Me.txtQuantityStocks.Location = New System.Drawing.Point(204, 220)
        Me.txtQuantityStocks.Name = "txtQuantityStocks"
        Me.txtQuantityStocks.Size = New System.Drawing.Size(269, 26)
        Me.txtQuantityStocks.TabIndex = 13
        '
        'txtItemNameStocks
        '
        Me.txtItemNameStocks.Location = New System.Drawing.Point(204, 176)
        Me.txtItemNameStocks.Name = "txtItemNameStocks"
        Me.txtItemNameStocks.Size = New System.Drawing.Size(269, 26)
        Me.txtItemNameStocks.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(54, 399)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 41)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(497, 122)
        Me.Panel1.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tw Cen MT", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label6.Location = New System.Drawing.Point(14, 64)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(234, 58)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Add Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 311)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 26)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Price per item"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(264, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 26)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Price"
        '
        'AddStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(496, 472)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePickerStocks)
        Me.Controls.Add(Me.btnAddStocks)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPriceStocks)
        Me.Controls.Add(Me.txtQuantityStocks)
        Me.Controls.Add(Me.txtItemNameStocks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AddStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
End Class
