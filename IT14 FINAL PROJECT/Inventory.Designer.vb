<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgOrderList = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnDeleteOrders = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnAddOrder = New System.Windows.Forms.Button()
        Me.dgvStocks = New System.Windows.Forms.DataGridView()
        Me.btnViewStocks = New System.Windows.Forms.Button()
        Me.btnDeleteStocks = New System.Windows.Forms.Button()
        Me.btnAddStocks = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numeric1 = New System.Windows.Forms.NumericUpDown()
        Me.btnUpdateQuantity = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.btnAccounts)
        Me.Panel1.Controls.Add(Me.Panel11)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 207)
        Me.Panel1.TabIndex = 14
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel11.Location = New System.Drawing.Point(632, 104)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(2, 76)
        Me.Panel11.TabIndex = 14
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel12.Location = New System.Drawing.Point(950, 104)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(2, 86)
        Me.Panel12.TabIndex = 13
        '
        'Button8
        '
        Me.Button8.BackgroundImage = CType(resources.GetObject("Button8.BackgroundImage"), System.Drawing.Image)
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(1776, 119)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(81, 72)
        Me.Button8.TabIndex = 12
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(1011, 132)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(214, 58)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "SALES"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(694, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(233, 48)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "INVENTORY"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(410, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 58)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgOrderList
        '
        Me.dgOrderList.AllowUserToAddRows = False
        Me.dgOrderList.AllowUserToDeleteRows = False
        Me.dgOrderList.AllowUserToResizeColumns = False
        Me.dgOrderList.AllowUserToResizeRows = False
        Me.dgOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderList.EnableHeadersVisualStyles = False
        Me.dgOrderList.Location = New System.Drawing.Point(33, 379)
        Me.dgOrderList.Name = "dgOrderList"
        Me.dgOrderList.ReadOnly = True
        Me.dgOrderList.RowHeadersVisible = False
        Me.dgOrderList.RowHeadersWidth = 62
        Me.dgOrderList.RowTemplate.Height = 28
        Me.dgOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgOrderList.Size = New System.Drawing.Size(729, 424)
        Me.dgOrderList.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 260)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 46)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Orders"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(918, 721)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 42)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Complete Order"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnDeleteOrders
        '
        Me.btnDeleteOrders.Location = New System.Drawing.Point(918, 666)
        Me.btnDeleteOrders.Name = "btnDeleteOrders"
        Me.btnDeleteOrders.Size = New System.Drawing.Size(136, 34)
        Me.btnDeleteOrders.TabIndex = 20
        Me.btnDeleteOrders.Text = "Delete Order"
        Me.btnDeleteOrders.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(918, 607)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 34)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "View Order"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(918, 543)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 40)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Update Order"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnAddOrder
        '
        Me.btnAddOrder.Location = New System.Drawing.Point(918, 491)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(136, 34)
        Me.btnAddOrder.TabIndex = 17
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = True
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.AllowUserToResizeColumns = False
        Me.dgvStocks.AllowUserToResizeRows = False
        Me.dgvStocks.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Location = New System.Drawing.Point(1060, 379)
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.RowHeadersVisible = False
        Me.dgvStocks.RowHeadersWidth = 62
        Me.dgvStocks.RowTemplate.Height = 28
        Me.dgvStocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStocks.Size = New System.Drawing.Size(452, 441)
        Me.dgvStocks.TabIndex = 23
        '
        'btnViewStocks
        '
        Me.btnViewStocks.Location = New System.Drawing.Point(1731, 648)
        Me.btnViewStocks.Name = "btnViewStocks"
        Me.btnViewStocks.Size = New System.Drawing.Size(155, 42)
        Me.btnViewStocks.TabIndex = 26
        Me.btnViewStocks.Text = "View Item"
        Me.btnViewStocks.UseVisualStyleBackColor = True
        '
        'btnDeleteStocks
        '
        Me.btnDeleteStocks.Location = New System.Drawing.Point(1731, 570)
        Me.btnDeleteStocks.Name = "btnDeleteStocks"
        Me.btnDeleteStocks.Size = New System.Drawing.Size(155, 42)
        Me.btnDeleteStocks.TabIndex = 25
        Me.btnDeleteStocks.Text = "Delete Stocks"
        Me.btnDeleteStocks.UseVisualStyleBackColor = True
        '
        'btnAddStocks
        '
        Me.btnAddStocks.Location = New System.Drawing.Point(1731, 491)
        Me.btnAddStocks.Name = "btnAddStocks"
        Me.btnAddStocks.Size = New System.Drawing.Size(155, 34)
        Me.btnAddStocks.TabIndex = 24
        Me.btnAddStocks.Text = "Add Stocks"
        Me.btnAddStocks.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1073, 297)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 46)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Stocks"
        '
        'numeric1
        '
        Me.numeric1.Location = New System.Drawing.Point(1571, 328)
        Me.numeric1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numeric1.Name = "numeric1"
        Me.numeric1.Size = New System.Drawing.Size(120, 26)
        Me.numeric1.TabIndex = 29
        Me.numeric1.Visible = False
        '
        'btnUpdateQuantity
        '
        Me.btnUpdateQuantity.Location = New System.Drawing.Point(1731, 328)
        Me.btnUpdateQuantity.Name = "btnUpdateQuantity"
        Me.btnUpdateQuantity.Size = New System.Drawing.Size(125, 37)
        Me.btnUpdateQuantity.TabIndex = 30
        Me.btnUpdateQuantity.Text = "Update"
        Me.btnUpdateQuantity.UseVisualStyleBackColor = True
        Me.btnUpdateQuantity.Visible = False
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(1545, 129)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(175, 61)
        Me.btnAccounts.TabIndex = 15
        Me.btnAccounts.Text = "ACCOUNT"
        Me.btnAccounts.UseVisualStyleBackColor = True
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.btnUpdateQuantity)
        Me.Controls.Add(Me.numeric1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewStocks)
        Me.Controls.Add(Me.btnDeleteStocks)
        Me.Controls.Add(Me.btnAddStocks)
        Me.Controls.Add(Me.dgvStocks)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnDeleteOrders)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnAddOrder)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgOrderList)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Inventory"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dgOrderList As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents btnDeleteOrders As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents dgvStocks As DataGridView
    Friend WithEvents btnViewStocks As Button
    Friend WithEvents btnDeleteStocks As Button
    Friend WithEvents btnAddStocks As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents numeric1 As NumericUpDown
    Friend WithEvents btnUpdateQuantity As Button
    Friend WithEvents btnAccounts As Button
End Class
