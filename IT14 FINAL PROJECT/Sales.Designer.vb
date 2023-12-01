<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvSales = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lblAnnuallySales = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblMonthlySales = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWeeklySales = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1920, 207)
        Me.Panel1.TabIndex = 15
        '
        'btnAccounts
        '
        Me.btnAccounts.Location = New System.Drawing.Point(1554, 125)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(175, 61)
        Me.btnAccounts.TabIndex = 16
        Me.btnAccounts.Text = "ACCOUNT"
        Me.btnAccounts.UseVisualStyleBackColor = True
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
        'dgvSales
        '
        Me.dgvSales.AllowUserToResizeColumns = False
        Me.dgvSales.AllowUserToResizeRows = False
        Me.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSales.Location = New System.Drawing.Point(48, 310)
        Me.dgvSales.Name = "dgvSales"
        Me.dgvSales.RowHeadersVisible = False
        Me.dgvSales.RowHeadersWidth = 62
        Me.dgvSales.RowTemplate.Height = 28
        Me.dgvSales.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvSales.Size = New System.Drawing.Size(903, 702)
        Me.dgvSales.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 239)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(514, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Total Sales of Completed Orders"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(1110, 278)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 685)
        Me.Panel2.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1132, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(212, 37)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Sales Report"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.MintCream
        Me.Panel5.Controls.Add(Me.lblAnnuallySales)
        Me.Panel5.Controls.Add(Me.Panel8)
        Me.Panel5.Location = New System.Drawing.Point(1342, 616)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(267, 247)
        Me.Panel5.TabIndex = 23
        '
        'lblAnnuallySales
        '
        Me.lblAnnuallySales.AutoSize = True
        Me.lblAnnuallySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnnuallySales.Location = New System.Drawing.Point(58, 137)
        Me.lblAnnuallySales.Name = "lblAnnuallySales"
        Me.lblAnnuallySales.Size = New System.Drawing.Size(101, 32)
        Me.lblAnnuallySales.TabIndex = 23
        Me.lblAnnuallySales.Text = "Label6"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightBlue
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Location = New System.Drawing.Point(64, 19)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(147, 35)
        Me.Panel8.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Annually"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.MintCream
        Me.Panel4.Controls.Add(Me.lblMonthlySales)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Location = New System.Drawing.Point(1517, 321)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(267, 247)
        Me.Panel4.TabIndex = 22
        '
        'lblMonthlySales
        '
        Me.lblMonthlySales.AutoSize = True
        Me.lblMonthlySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlySales.Location = New System.Drawing.Point(58, 119)
        Me.lblMonthlySales.Name = "lblMonthlySales"
        Me.lblMonthlySales.Size = New System.Drawing.Size(101, 32)
        Me.lblMonthlySales.TabIndex = 22
        Me.lblMonthlySales.Text = "Label6"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightBlue
        Me.Panel7.Controls.Add(Me.Label4)
        Me.Panel7.Location = New System.Drawing.Point(64, 15)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(147, 35)
        Me.Panel7.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Monthly"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MintCream
        Me.Panel3.Controls.Add(Me.lblWeeklySales)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Location = New System.Drawing.Point(1175, 321)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(267, 247)
        Me.Panel3.TabIndex = 21
        '
        'lblWeeklySales
        '
        Me.lblWeeklySales.AutoSize = True
        Me.lblWeeklySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeeklySales.Location = New System.Drawing.Point(56, 119)
        Me.lblWeeklySales.Name = "lblWeeklySales"
        Me.lblWeeklySales.Size = New System.Drawing.Size(101, 32)
        Me.lblWeeklySales.TabIndex = 23
        Me.lblWeeklySales.Text = "Label6"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightBlue
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(62, 15)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(147, 35)
        Me.Panel6.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Weekly"
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1898, 1024)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSales)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
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
    Friend WithEvents dgvSales As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMonthlySales As Label
    Friend WithEvents lblWeeklySales As Label
    Friend WithEvents lblAnnuallySales As Label
    Friend WithEvents btnAccounts As Button
End Class
