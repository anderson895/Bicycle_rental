<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReturnForm))
        lblCustomerName = New Label()
        lblBicycleID = New Label()
        lblReturnTime = New Label()
        lblTotalFees = New Label()
        lblTotalFeesValue = New Label()
        dtpReturnTime = New DateTimePicker()
        btnCustomerSearch = New Button()
        btnConfirmReturn = New Button()
        txtCustomerName = New TextBox()
        txtBicycleID = New TextBox()
        btnPreviewReceipt = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnReturn = New Button()
        Button1 = New Button()
        Button2 = New Button()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        Button3 = New Button()
        PictureBox9 = New PictureBox()
        PictureBox10 = New PictureBox()
        Button4 = New Button()
        Button5 = New Button()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerName.Location = New Point(263, 73)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(111, 17)
        lblCustomerName.TabIndex = 0
        lblCustomerName.Text = "Customer Name:" & vbTab
        ' 
        ' lblBicycleID
        ' 
        lblBicycleID.AutoSize = True
        lblBicycleID.Location = New Point(263, 107)
        lblBicycleID.Name = "lblBicycleID"
        lblBicycleID.Size = New Size(61, 15)
        lblBicycleID.TabIndex = 1
        lblBicycleID.Text = "Bicycle ID:" & vbTab
        ' 
        ' lblReturnTime
        ' 
        lblReturnTime.AutoSize = True
        lblReturnTime.Location = New Point(263, 145)
        lblReturnTime.Name = "lblReturnTime"
        lblReturnTime.Size = New Size(111, 15)
        lblReturnTime.TabIndex = 2
        lblReturnTime.Text = "Actual Return Time:" & vbTab
        ' 
        ' lblTotalFees
        ' 
        lblTotalFees.AutoSize = True
        lblTotalFees.Location = New Point(263, 189)
        lblTotalFees.Name = "lblTotalFees"
        lblTotalFees.Size = New Size(61, 15)
        lblTotalFees.TabIndex = 3
        lblTotalFees.Text = "Total Fees:" & vbTab
        ' 
        ' lblTotalFeesValue
        ' 
        lblTotalFeesValue.AutoSize = True
        lblTotalFeesValue.Location = New Point(376, 189)
        lblTotalFeesValue.Name = "lblTotalFeesValue"
        lblTotalFeesValue.Size = New Size(28, 15)
        lblTotalFeesValue.TabIndex = 4
        lblTotalFeesValue.Text = "0.00"
        ' 
        ' dtpReturnTime
        ' 
        dtpReturnTime.Format = DateTimePickerFormat.Time
        dtpReturnTime.Location = New Point(376, 137)
        dtpReturnTime.Name = "dtpReturnTime"
        dtpReturnTime.ShowUpDown = True
        dtpReturnTime.Size = New Size(100, 23)
        dtpReturnTime.TabIndex = 5
        ' 
        ' btnCustomerSearch
        ' 
        btnCustomerSearch.FlatStyle = FlatStyle.Popup
        btnCustomerSearch.Location = New Point(482, 64)
        btnCustomerSearch.Name = "btnCustomerSearch"
        btnCustomerSearch.Size = New Size(75, 23)
        btnCustomerSearch.TabIndex = 6
        btnCustomerSearch.Text = "Search"
        btnCustomerSearch.UseVisualStyleBackColor = True
        ' 
        ' btnConfirmReturn
        ' 
        btnConfirmReturn.FlatStyle = FlatStyle.Popup
        btnConfirmReturn.Location = New Point(304, 237)
        btnConfirmReturn.Name = "btnConfirmReturn"
        btnConfirmReturn.Size = New Size(100, 23)
        btnConfirmReturn.TabIndex = 7
        btnConfirmReturn.Text = "Confirm Return"
        btnConfirmReturn.UseVisualStyleBackColor = True
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(376, 65)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(100, 23)
        txtCustomerName.TabIndex = 8
        ' 
        ' txtBicycleID
        ' 
        txtBicycleID.Location = New Point(376, 99)
        txtBicycleID.Name = "txtBicycleID"
        txtBicycleID.Size = New Size(100, 23)
        txtBicycleID.TabIndex = 9
        ' 
        ' btnPreviewReceipt
        ' 
        btnPreviewReceipt.FlatStyle = FlatStyle.Popup
        btnPreviewReceipt.Location = New Point(473, 237)
        btnPreviewReceipt.Name = "btnPreviewReceipt"
        btnPreviewReceipt.Size = New Size(84, 23)
        btnPreviewReceipt.TabIndex = 10
        btnPreviewReceipt.Text = "Print Receipt"
        btnPreviewReceipt.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnReturn)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox8)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(PictureBox9)
        Panel1.Controls.Add(PictureBox10)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button5)
        Panel1.Location = New Point(2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 415)
        Panel1.TabIndex = 52
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = My.Resources.Resources.logo_2
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(236, 131)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 44
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.BackgroundImageLayout = ImageLayout.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 323)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 43
        PictureBox2.TabStop = False
        ' 
        ' btnReturn
        ' 
        btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImageLayout = ImageLayout.None
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(67, 323)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(169, 42)
        btnReturn.TabIndex = 42
        btnReturn.Text = "Return the Bike"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = My.Resources.Resources.power_off
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Location = New Point(3, 376)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 36)
        Button1.TabIndex = 41
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button2.BackColor = Color.Transparent
        Button2.BackgroundImageLayout = ImageLayout.None
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(67, 278)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 42)
        Button2.TabIndex = 32
        Button2.Text = "Bicycle Inventory"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.bicycle__1_
        PictureBox7.Location = New Point(0, 278)
        PictureBox7.Margin = New Padding(0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(64, 42)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 39
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.None
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = My.Resources.Resources.history
        PictureBox8.Location = New Point(0, 230)
        PictureBox8.Margin = New Padding(0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(64, 42)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 38
        PictureBox8.TabStop = False
        ' 
        ' Button3
        ' 
        Button3.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button3.BackColor = Color.Transparent
        Button3.BackgroundImageLayout = ImageLayout.None
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(67, 230)
        Button3.Name = "Button3"
        Button3.Size = New Size(169, 42)
        Button3.TabIndex = 34
        Button3.Text = "Rental History"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.Anchor = AnchorStyles.None
        PictureBox9.BackColor = Color.Transparent
        PictureBox9.Image = My.Resources.Resources.preferences__1_
        PictureBox9.Location = New Point(0, 182)
        PictureBox9.Margin = New Padding(0)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(64, 42)
        PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox9.TabIndex = 37
        PictureBox9.TabStop = False
        ' 
        ' PictureBox10
        ' 
        PictureBox10.Anchor = AnchorStyles.None
        PictureBox10.BackColor = Color.Transparent
        PictureBox10.Image = My.Resources.Resources.bicycle
        PictureBox10.Location = New Point(0, 134)
        PictureBox10.Margin = New Padding(0)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(64, 42)
        PictureBox10.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox10.TabIndex = 36
        PictureBox10.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button4.BackColor = Color.Transparent
        Button4.BackgroundImageLayout = ImageLayout.None
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(67, 182)
        Button4.Name = "Button4"
        Button4.Size = New Size(169, 42)
        Button4.TabIndex = 35
        Button4.Text = "Maintenance"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImageLayout = ImageLayout.None
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(67, 134)
        Button5.Name = "Button5"
        Button5.Size = New Size(169, 42)
        Button5.TabIndex = 33
        Button5.Text = "Handle Rentals"
        Button5.TextAlign = ContentAlignment.MiddleLeft
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Location = New Point(237, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 415)
        Panel2.TabIndex = 53
        ' 
        ' ReturnForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(623, 417)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnPreviewReceipt)
        Controls.Add(txtBicycleID)
        Controls.Add(txtCustomerName)
        Controls.Add(btnConfirmReturn)
        Controls.Add(btnCustomerSearch)
        Controls.Add(dtpReturnTime)
        Controls.Add(lblTotalFeesValue)
        Controls.Add(lblTotalFees)
        Controls.Add(lblReturnTime)
        Controls.Add(lblBicycleID)
        Controls.Add(lblCustomerName)
        Name = "ReturnForm"
        Text = "Form9"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblBicycleID As Label
    Friend WithEvents lblReturnTime As Label
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents lblTotalFeesValue As Label
    Friend WithEvents dtpReturnTime As DateTimePicker
    Friend WithEvents btnCustomerSearch As Button
    Friend WithEvents btnConfirmReturn As Button
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtBicycleID As TextBox
    Friend WithEvents btnPreviewReceipt As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
