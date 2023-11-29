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
        Me.SuspendLayout()
        '
        'dtpUpdateStocks
        '
        Me.dtpUpdateStocks.Location = New System.Drawing.Point(217, 250)
        Me.dtpUpdateStocks.Name = "dtpUpdateStocks"
        Me.dtpUpdateStocks.Size = New System.Drawing.Size(153, 26)
        Me.dtpUpdateStocks.TabIndex = 22
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(232, 297)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(119, 37)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(283, 38)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(26, 20)
        Me.lblID.TabIndex = 20
        Me.lblID.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Date Purchased"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Item Name"
        '
        'txtUpdatePrice
        '
        Me.txtUpdatePrice.Location = New System.Drawing.Point(217, 191)
        Me.txtUpdatePrice.Name = "txtUpdatePrice"
        Me.txtUpdatePrice.Size = New System.Drawing.Size(153, 26)
        Me.txtUpdatePrice.TabIndex = 15
        '
        'txtUpdateQuantityStocks
        '
        Me.txtUpdateQuantityStocks.Location = New System.Drawing.Point(217, 144)
        Me.txtUpdateQuantityStocks.Name = "txtUpdateQuantityStocks"
        Me.txtUpdateQuantityStocks.Size = New System.Drawing.Size(153, 26)
        Me.txtUpdateQuantityStocks.TabIndex = 14
        '
        'lblSt
        '
        Me.lblSt.AutoSize = True
        Me.lblSt.Location = New System.Drawing.Point(109, 38)
        Me.lblSt.Name = "lblSt"
        Me.lblSt.Size = New System.Drawing.Size(23, 20)
        Me.lblSt.TabIndex = 13
        Me.lblSt.Text = "Id"
        '
        'txtUpdateItemNameStocks
        '
        Me.txtUpdateItemNameStocks.Location = New System.Drawing.Point(217, 96)
        Me.txtUpdateItemNameStocks.Name = "txtUpdateItemNameStocks"
        Me.txtUpdateItemNameStocks.Size = New System.Drawing.Size(153, 26)
        Me.txtUpdateItemNameStocks.TabIndex = 12
        '
        'UpdateStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 373)
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
        Me.Name = "UpdateStocks"
        Me.Text = "UpdateStocks"
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
End Class
