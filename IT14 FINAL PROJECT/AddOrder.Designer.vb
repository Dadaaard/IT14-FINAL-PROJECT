<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddOrder
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
        Me.datetime = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtOrderType = New System.Windows.Forms.TextBox()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datetime
        '
        Me.datetime.CustomFormat = "yyyy-MM-dd"
        Me.datetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.datetime.Location = New System.Drawing.Point(201, 179)
        Me.datetime.Name = "datetime"
        Me.datetime.Size = New System.Drawing.Size(262, 30)
        Me.datetime.TabIndex = 30
        Me.datetime.Value = New Date(2023, 11, 29, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(111, 591)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 25)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(95, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 25)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Order Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 25)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Order Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 25)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Customer Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 25)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Customer Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(77, 723)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(202, 50)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(339, 723)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(210, 50)
        Me.btnAddOrder.TabIndex = 22
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(199, 275)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(264, 30)
        Me.txtQuantity.TabIndex = 20
        '
        'txtOrderType
        '
        Me.txtOrderType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderType.Location = New System.Drawing.Point(199, 228)
        Me.txtOrderType.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtOrderType.Name = "txtOrderType"
        Me.txtOrderType.Size = New System.Drawing.Size(264, 30)
        Me.txtOrderType.TabIndex = 19
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNumber.Location = New System.Drawing.Point(199, 128)
        Me.txtCustomerNumber.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(264, 30)
        Me.txtCustomerNumber.TabIndex = 18
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(199, 85)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(264, 30)
        Me.txtCustomerName.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(130, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 32)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Add Customer Order"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(242, 592)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(264, 107)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(163, 32)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Items Used:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(201, 337)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(145, 28)
        Me.ComboBox1.TabIndex = 35
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(366, 338)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 26)
        Me.NumericUpDown1.TabIndex = 36
        Me.NumericUpDown1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(510, 333)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 34)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(136, 402)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(390, 150)
        Me.DataGridView1.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.MinimumWidth = 8
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.MinimumWidth = 8
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'AddOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 903)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.datetime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtOrderType)
        Me.Controls.Add(Me.txtCustomerNumber)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddOrder"
        Me.ShowIcon = False
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datetime As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtOrderType As TextBox
    Friend WithEvents txtCustomerNumber As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
