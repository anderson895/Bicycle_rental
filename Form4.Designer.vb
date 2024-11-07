<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        lblCustomerName = New Label()
        lblBicycleID = New Label()
        lblRentalStart = New Label()
        lblRentalEnd = New Label()
        lblTotalFees = New Label()
        txtCustomerName = New TextBox()
        cmbBicycleID = New ComboBox()
        dtpStartTime = New DateTimePicker()
        dtpEndTime = New DateTimePicker()
        txtTotalFees = New TextBox()
        btnRent = New Button()
        btnOpenForm2 = New Button()
        btnOpenForm3 = New Button()
        Panel1 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnReturn = New Button()
        btnLogout = New Button()
        btnManageBikes = New Button()
        btnViewHistory = New Button()
        btnManageMaintenance = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnHandleRentals = New Button()
        Label1 = New Label()
        wantedhoursfuser = New ComboBox()
        Panel2 = New Panel()
        PictureBox6 = New PictureBox()
        PictureBox8 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCustomerName
        ' 
        lblCustomerName.AutoSize = True
        lblCustomerName.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerName.Location = New Point(258, 270)
        lblCustomerName.Name = "lblCustomerName"
        lblCustomerName.Size = New Size(137, 21)
        lblCustomerName.TabIndex = 0
        lblCustomerName.Text = "Customer Name:"
        ' 
        ' lblBicycleID
        ' 
        lblBicycleID.AutoSize = True
        lblBicycleID.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBicycleID.Location = New Point(568, 270)
        lblBicycleID.Name = "lblBicycleID"
        lblBicycleID.Size = New Size(89, 21)
        lblBicycleID.TabIndex = 1
        lblBicycleID.Text = "Bicycle ID:"
        ' 
        ' lblRentalStart
        ' 
        lblRentalStart.AutoSize = True
        lblRentalStart.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalStart.Location = New Point(258, 299)
        lblRentalStart.Name = "lblRentalStart"
        lblRentalStart.Size = New Size(145, 21)
        lblRentalStart.TabIndex = 2
        lblRentalStart.Text = "Rental Start Time:"
        ' 
        ' lblRentalEnd
        ' 
        lblRentalEnd.AutoSize = True
        lblRentalEnd.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRentalEnd.Location = New Point(258, 328)
        lblRentalEnd.Name = "lblRentalEnd"
        lblRentalEnd.Size = New Size(138, 21)
        lblRentalEnd.TabIndex = 3
        lblRentalEnd.Text = "Rental End Time:"
        ' 
        ' lblTotalFees
        ' 
        lblTotalFees.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFees.Location = New Point(256, 363)
        lblTotalFees.Name = "lblTotalFees"
        lblTotalFees.Size = New Size(52, 28)
        lblTotalFees.TabIndex = 4
        lblTotalFees.Text = "Total Fees"
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(401, 268)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(141, 23)
        txtCustomerName.TabIndex = 5
        ' 
        ' cmbBicycleID
        ' 
        cmbBicycleID.FormattingEnabled = True
        cmbBicycleID.Location = New Point(663, 272)
        cmbBicycleID.Name = "cmbBicycleID"
        cmbBicycleID.Size = New Size(141, 23)
        cmbBicycleID.TabIndex = 6
        ' 
        ' dtpStartTime
        ' 
        dtpStartTime.Format = DateTimePickerFormat.Time
        dtpStartTime.Location = New Point(401, 297)
        dtpStartTime.Name = "dtpStartTime"
        dtpStartTime.ShowUpDown = True
        dtpStartTime.Size = New Size(141, 23)
        dtpStartTime.TabIndex = 7
        ' 
        ' dtpEndTime
        ' 
        dtpEndTime.Format = DateTimePickerFormat.Time
        dtpEndTime.Location = New Point(401, 326)
        dtpEndTime.Name = "dtpEndTime"
        dtpEndTime.ShowUpDown = True
        dtpEndTime.Size = New Size(141, 23)
        dtpEndTime.TabIndex = 8
        ' 
        ' txtTotalFees
        ' 
        txtTotalFees.Location = New Point(314, 365)
        txtTotalFees.Name = "txtTotalFees"
        txtTotalFees.Size = New Size(141, 23)
        txtTotalFees.TabIndex = 9
        ' 
        ' btnRent
        ' 
        btnRent.FlatStyle = FlatStyle.Popup
        btnRent.Location = New Point(598, 337)
        btnRent.Name = "btnRent"
        btnRent.Size = New Size(90, 25)
        btnRent.TabIndex = 10
        btnRent.Text = "Rent Bicycle"
        btnRent.UseVisualStyleBackColor = True
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(813, 365)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(47, 39)
        btnOpenForm2.TabIndex = 16
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' btnOpenForm3
        ' 
        btnOpenForm3.FlatStyle = FlatStyle.Popup
        btnOpenForm3.Location = New Point(599, 372)
        btnOpenForm3.Name = "btnOpenForm3"
        btnOpenForm3.Size = New Size(90, 25)
        btnOpenForm3.TabIndex = 17
        btnOpenForm3.Text = "Bike Inventory"
        btnOpenForm3.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnReturn)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnManageBikes)
        Panel1.Controls.Add(btnViewHistory)
        Panel1.Controls.Add(btnManageMaintenance)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnHandleRentals)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 415)
        Panel1.TabIndex = 18
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.BackColor = Color.Transparent
        PictureBox7.Image = My.Resources.Resources.logo_2
        PictureBox7.Location = New Point(0, 0)
        PictureBox7.Margin = New Padding(0)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(236, 131)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 39
        PictureBox7.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 326)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(66, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 33
        PictureBox1.TabStop = False
        ' 
        ' btnReturn
        ' 
        btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImageLayout = ImageLayout.None
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(66, 326)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(170, 42)
        btnReturn.TabIndex = 32
        btnReturn.Text = "Return the Bike"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = My.Resources.Resources.power_off
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(3, 376)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(40, 36)
        btnLogout.TabIndex = 31
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnManageBikes
        ' 
        btnManageBikes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnManageBikes.BackColor = Color.Transparent
        btnManageBikes.BackgroundImageLayout = ImageLayout.None
        btnManageBikes.FlatStyle = FlatStyle.Flat
        btnManageBikes.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageBikes.Location = New Point(66, 278)
        btnManageBikes.Name = "btnManageBikes"
        btnManageBikes.Size = New Size(170, 42)
        btnManageBikes.TabIndex = 22
        btnManageBikes.Text = "Bicycle Inventory"
        btnManageBikes.TextAlign = ContentAlignment.MiddleLeft
        btnManageBikes.UseVisualStyleBackColor = False
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewHistory.BackColor = Color.Transparent
        btnViewHistory.BackgroundImageLayout = ImageLayout.None
        btnViewHistory.FlatStyle = FlatStyle.Flat
        btnViewHistory.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewHistory.Location = New Point(66, 230)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(170, 42)
        btnViewHistory.TabIndex = 24
        btnViewHistory.Text = "Rental History"
        btnViewHistory.TextAlign = ContentAlignment.MiddleLeft
        btnViewHistory.UseVisualStyleBackColor = False
        ' 
        ' btnManageMaintenance
        ' 
        btnManageMaintenance.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnManageMaintenance.BackColor = Color.Transparent
        btnManageMaintenance.BackgroundImageLayout = ImageLayout.None
        btnManageMaintenance.FlatStyle = FlatStyle.Flat
        btnManageMaintenance.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageMaintenance.Location = New Point(66, 182)
        btnManageMaintenance.Name = "btnManageMaintenance"
        btnManageMaintenance.Size = New Size(170, 42)
        btnManageMaintenance.TabIndex = 25
        btnManageMaintenance.Text = "Maintenance"
        btnManageMaintenance.TextAlign = ContentAlignment.MiddleLeft
        btnManageMaintenance.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.bicycle__1_
        PictureBox5.Location = New Point(2, 278)
        PictureBox5.Margin = New Padding(0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 42)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 29
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.history
        PictureBox4.Location = New Point(2, 230)
        PictureBox4.Margin = New Padding(0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 28
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.preferences__1_
        PictureBox3.Location = New Point(2, 182)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 27
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.bicycle
        PictureBox2.Location = New Point(2, 134)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 26
        PictureBox2.TabStop = False
        ' 
        ' btnHandleRentals
        ' 
        btnHandleRentals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHandleRentals.BackColor = Color.Transparent
        btnHandleRentals.BackgroundImageLayout = ImageLayout.None
        btnHandleRentals.FlatStyle = FlatStyle.Flat
        btnHandleRentals.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHandleRentals.Location = New Point(66, 134)
        btnHandleRentals.Name = "btnHandleRentals"
        btnHandleRentals.Size = New Size(170, 42)
        btnHandleRentals.TabIndex = 23
        btnHandleRentals.Text = "Handle Rentals"
        btnHandleRentals.TextAlign = ContentAlignment.MiddleLeft
        btnHandleRentals.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(568, 299)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 21)
        Label1.TabIndex = 19
        Label1.Text = "Wanted hours:"
        ' 
        ' wantedhoursfuser
        ' 
        wantedhoursfuser.FormattingEnabled = True
        wantedhoursfuser.Location = New Point(694, 301)
        wantedhoursfuser.Name = "wantedhoursfuser"
        wantedhoursfuser.Size = New Size(110, 23)
        wantedhoursfuser.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Location = New Point(235, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 415)
        Panel2.TabIndex = 21
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.pngkey_com_mountain_vector_png_461815
        PictureBox6.Location = New Point(242, 0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(629, 252)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 22
        PictureBox6.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Anchor = AnchorStyles.None
        PictureBox8.BackColor = Color.Transparent
        PictureBox8.Image = My.Resources.Resources.logo_2
        PictureBox8.Location = New Point(248, 85)
        PictureBox8.Margin = New Padding(0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(190, 67)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 40
        PictureBox8.TabStop = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(872, 416)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox6)
        Controls.Add(Panel2)
        Controls.Add(wantedhoursfuser)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(btnOpenForm3)
        Controls.Add(btnOpenForm2)
        Controls.Add(btnRent)
        Controls.Add(txtTotalFees)
        Controls.Add(dtpEndTime)
        Controls.Add(dtpStartTime)
        Controls.Add(cmbBicycleID)
        Controls.Add(txtCustomerName)
        Controls.Add(lblTotalFees)
        Controls.Add(lblRentalEnd)
        Controls.Add(lblRentalStart)
        Controls.Add(lblBicycleID)
        Controls.Add(lblCustomerName)
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerName As Label
    Friend WithEvents lblBicycleID As Label
    Friend WithEvents lblRentalStart As Label
    Friend WithEvents lblRentalEnd As Label
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cmbBicycleID As ComboBox
    Friend WithEvents dtpStartTime As DateTimePicker
    Friend WithEvents dtpEndTime As DateTimePicker
    Friend WithEvents txtTotalFees As TextBox
    Friend WithEvents btnRent As Button
    Friend WithEvents btnOpenForm2 As Button
    Friend WithEvents btnOpenForm3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnManageBikes As Button
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnManageMaintenance As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnHandleRentals As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents wantedhoursfuser As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
