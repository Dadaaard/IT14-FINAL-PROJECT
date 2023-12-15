<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateStocks
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
        Me.dtpUpdateStocks = New System.Windows.Forms.DateTimePicker()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUpdatePrice = New System.Windows.Forms.TextBox()
        Me.txtUpdateQuantityStocks = New System.Windows.Forms.TextBox()
        Me.lblSt = New System.Windows.Forms.Label()
        Me.txtUpdateItemNameStocks = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpUpdateStocks
        '
        Me.dtpUpdateStocks.Location = New System.Drawing.Point(173, 350)
        Me.dtpUpdateStocks.Name = "dtpUpdateStocks"
        Me.dtpUpdateStocks.Size = New System.Drawing.Size(266, 26)
        Me.dtpUpdateStocks.TabIndex = 22
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(254, 425)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(146, 37)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(170, 160)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 23)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Price Purchased"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(75, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Item Name"
        '
        'txtUpdatePrice
        '
        Me.txtUpdatePrice.Location = New System.Drawing.Point(173, 268)
        Me.txtUpdatePrice.Name = "txtUpdatePrice"
        Me.txtUpdatePrice.Size = New System.Drawing.Size(266, 26)
        Me.txtUpdatePrice.TabIndex = 15
        '
        'txtUpdateQuantityStocks
        '
        Me.txtUpdateQuantityStocks.Location = New System.Drawing.Point(173, 229)
        Me.txtUpdateQuantityStocks.Name = "txtUpdateQuantityStocks"
        Me.txtUpdateQuantityStocks.Size = New System.Drawing.Size(266, 26)
        Me.txtUpdateQuantityStocks.TabIndex = 14
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSt.Location = New System.Drawing.Point(133, 157)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(26, 23)
        Me.lblSt.TabIndex = 13
        Me.lblSt.Text = "Id"
        '
        'txtUpdateItemNameStocks
        '
        Me.txtUpdateItemNameStocks.Location = New System.Drawing.Point(173, 192)
        Me.txtUpdateItemNameStocks.Name = "txtUpdateItemNameStocks"
        Me.txtUpdateItemNameStocks.Size = New System.Drawing.Size(266, 26)
        Me.txtUpdateItemNameStocks.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(61, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 37)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Total Amount"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(170, 311)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(18, 20)
        Me.lblAmount.TabIndex = 26
        Me.lblAmount.Text = "0"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(469, 122)
        Me.Panel1.TabIndex = 41
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
        Me.Label6.Size = New System.Drawing.Size(277, 58)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Update Item"
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(468, 494)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpUpdateStocks)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUpdatePrice)
        Me.Controls.Add(Me.txtUpdateQuantityStocks)
        Me.Controls.Add(Me.lblSt)
        Me.Controls.Add(Me.txtUpdateItemNameStocks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UpdateStocks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpUpdateStocks As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUpdatePrice As TextBox
    Friend WithEvents txtUpdateQuantityStocks As TextBox
    Friend WithEvents lblSt As Label
    Friend WithEvents txtUpdateItemNameStocks As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
End Class
