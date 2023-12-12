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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
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
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 873)
        Me.Panel1.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gill Sans MT", 7.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label10.Location = New System.Drawing.Point(141, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 21)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "ADVERTISING"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gill Sans MT", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label9.Location = New System.Drawing.Point(140, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 27)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Digimark"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label8.Location = New System.Drawing.Point(44, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 67)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "DM"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tw Cen MT", 12.0!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(12, 707)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(277, 55)
        Me.Button4.TabIndex = 34
        Me.Button4.Text = "          LOGOUT"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tw Cen MT", 12.0!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(12, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(277, 55)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "          HOME"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tw Cen MT", 12.0!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(12, 418)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(277, 55)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "      INVENTORY"
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Tw Cen MT", 12.0!)
        Me.Button7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button7.Image = CType(resources.GetObject("Button7.Image"), System.Drawing.Image)
        Me.Button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.Location = New System.Drawing.Point(12, 492)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(277, 55)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "          SALES"
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnAccounts.FlatAppearance.BorderSize = 0
        Me.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAccounts.Font = New System.Drawing.Font("Trebuchet MS", 10.0!)
        Me.btnAccounts.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.btnAccounts.Image = CType(resources.GetObject("btnAccounts.Image"), System.Drawing.Image)
        Me.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccounts.Location = New System.Drawing.Point(1462, 82)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(228, 72)
        Me.btnAccounts.TabIndex = 15
        Me.btnAccounts.Text = "   My Account"
        Me.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAccounts.UseVisualStyleBackColor = False
        '
        'dgOrderList
        '
        Me.dgOrderList.AllowUserToAddRows = False
        Me.dgOrderList.AllowUserToDeleteRows = False
        Me.dgOrderList.AllowUserToResizeColumns = False
        Me.dgOrderList.AllowUserToResizeRows = False
        Me.dgOrderList.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOrderList.EnableHeadersVisualStyles = False
        Me.dgOrderList.Location = New System.Drawing.Point(346, 303)
        Me.dgOrderList.MultiSelect = False
        Me.dgOrderList.Name = "dgOrderList"
        Me.dgOrderList.ReadOnly = True
        Me.dgOrderList.RowHeadersVisible = False
        Me.dgOrderList.RowHeadersWidth = 62
        Me.dgOrderList.RowTemplate.Height = 28
        Me.dgOrderList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgOrderList.Size = New System.Drawing.Size(751, 345)
        Me.dgOrderList.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(309, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 44)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Pending Orders"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.PaleGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(518, 441)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(217, 69)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "  Complete Order"
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btnDeleteOrders
        '
        Me.btnDeleteOrders.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteOrders.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteOrders.Image = CType(resources.GetObject("btnDeleteOrders.Image"), System.Drawing.Image)
        Me.btnDeleteOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteOrders.Location = New System.Drawing.Point(261, 484)
        Me.btnDeleteOrders.Name = "btnDeleteOrders"
        Me.btnDeleteOrders.Size = New System.Drawing.Size(200, 48)
        Me.btnDeleteOrders.TabIndex = 20
        Me.btnDeleteOrders.Text = "Delete Order"
        Me.btnDeleteOrders.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.BurlyWood
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(261, 414)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(200, 48)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "View Order"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(20, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(200, 48)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Update Order"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnAddOrder
        '
        Me.btnAddOrder.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddOrder.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddOrder.Image = CType(resources.GetObject("btnAddOrder.Image"), System.Drawing.Image)
        Me.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddOrder.Location = New System.Drawing.Point(20, 414)
        Me.btnAddOrder.Name = "btnAddOrder"
        Me.btnAddOrder.Size = New System.Drawing.Size(200, 48)
        Me.btnAddOrder.TabIndex = 17
        Me.btnAddOrder.Text = "Add Order"
        Me.btnAddOrder.UseVisualStyleBackColor = False
        '
        'dgvStocks
        '
        Me.dgvStocks.AllowUserToAddRows = False
        Me.dgvStocks.AllowUserToDeleteRows = False
        Me.dgvStocks.AllowUserToResizeColumns = False
        Me.dgvStocks.AllowUserToResizeRows = False
        Me.dgvStocks.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvStocks.Location = New System.Drawing.Point(1169, 303)
        Me.dgvStocks.MultiSelect = False
        Me.dgvStocks.Name = "dgvStocks"
        Me.dgvStocks.ReadOnly = True
        Me.dgvStocks.RowHeadersVisible = False
        Me.dgvStocks.RowHeadersWidth = 62
        Me.dgvStocks.RowTemplate.Height = 28
        Me.dgvStocks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvStocks.Size = New System.Drawing.Size(531, 345)
        Me.dgvStocks.TabIndex = 23
        '
        'btnViewStocks
        '
        Me.btnViewStocks.BackColor = System.Drawing.Color.BurlyWood
        Me.btnViewStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewStocks.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnViewStocks.Image = CType(resources.GetObject("btnViewStocks.Image"), System.Drawing.Image)
        Me.btnViewStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewStocks.Location = New System.Drawing.Point(1419, 678)
        Me.btnViewStocks.Name = "btnViewStocks"
        Me.btnViewStocks.Size = New System.Drawing.Size(200, 48)
        Me.btnViewStocks.TabIndex = 26
        Me.btnViewStocks.Text = "View Item"
        Me.btnViewStocks.UseVisualStyleBackColor = False
        '
        'btnDeleteStocks
        '
        Me.btnDeleteStocks.BackColor = System.Drawing.Color.Salmon
        Me.btnDeleteStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteStocks.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnDeleteStocks.Image = CType(resources.GetObject("btnDeleteStocks.Image"), System.Drawing.Image)
        Me.btnDeleteStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteStocks.Location = New System.Drawing.Point(1419, 748)
        Me.btnDeleteStocks.Name = "btnDeleteStocks"
        Me.btnDeleteStocks.Size = New System.Drawing.Size(200, 48)
        Me.btnDeleteStocks.TabIndex = 25
        Me.btnDeleteStocks.Text = "Delete Stocks"
        Me.btnDeleteStocks.UseVisualStyleBackColor = False
        '
        'btnAddStocks
        '
        Me.btnAddStocks.BackColor = System.Drawing.Color.MediumTurquoise
        Me.btnAddStocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStocks.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAddStocks.Image = CType(resources.GetObject("btnAddStocks.Image"), System.Drawing.Image)
        Me.btnAddStocks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddStocks.Location = New System.Drawing.Point(1169, 678)
        Me.btnAddStocks.Name = "btnAddStocks"
        Me.btnAddStocks.Size = New System.Drawing.Size(200, 48)
        Me.btnAddStocks.TabIndex = 24
        Me.btnAddStocks.Text = "Add Stocks"
        Me.btnAddStocks.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(1135, 234)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 44)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Available Stocks"
        '
        'numeric1
        '
        Me.numeric1.Location = New System.Drawing.Point(1518, 212)
        Me.numeric1.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numeric1.Name = "numeric1"
        Me.numeric1.Size = New System.Drawing.Size(101, 26)
        Me.numeric1.TabIndex = 29
        Me.numeric1.Visible = False
        '
        'btnUpdateQuantity
        '
        Me.btnUpdateQuantity.BackColor = System.Drawing.Color.MediumSlateBlue
        Me.btnUpdateQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateQuantity.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateQuantity.Location = New System.Drawing.Point(1489, 246)
        Me.btnUpdateQuantity.Name = "btnUpdateQuantity"
        Me.btnUpdateQuantity.Size = New System.Drawing.Size(130, 37)
        Me.btnUpdateQuantity.TabIndex = 30
        Me.btnUpdateQuantity.Text = "Update"
        Me.btnUpdateQuantity.UseVisualStyleBackColor = False
        Me.btnUpdateQuantity.Visible = False
        '
        'btnHistory
        '
        Me.btnHistory.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHistory.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHistory.Location = New System.Drawing.Point(1169, 748)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(200, 48)
        Me.btnHistory.TabIndex = 31
        Me.btnHistory.Text = "History"
        Me.btnHistory.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label7.Location = New System.Drawing.Point(746, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(521, 86)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "INVENTORY"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel2.Controls.Add(Me.btnAddOrder)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btnDeleteOrders)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Location = New System.Drawing.Point(327, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 558)
        Me.Panel2.TabIndex = 33
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(300, 111)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(440, 10)
        Me.Panel3.TabIndex = 34
        '
        'Inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(1809, 871)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.btnUpdateQuantity)
        Me.Controls.Add(Me.numeric1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnViewStocks)
        Me.Controls.Add(Me.btnDeleteStocks)
        Me.Controls.Add(Me.btnAddStocks)
        Me.Controls.Add(Me.dgvStocks)
        Me.Controls.Add(Me.dgOrderList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Inventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTORY"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgOrderList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvStocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numeric1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents btnHistory As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
End Class
