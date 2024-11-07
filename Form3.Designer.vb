<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        lblBicycleID = New Label()
        txtBicycleID = New TextBox()
        lblType = New Label()
        txtType = New TextBox()
        lblPicture = New Label()
        lblStatus = New Label()
        cmbStatus = New ComboBox()
        btnAddBike = New Button()
        btnSaveChanges = New Button()
        btnDeleteBike = New Button()
        dgvBicycles = New DataGridView()
        picture = New DataGridViewImageColumn()
        pbBikePicture = New PictureBox()
        btnUploadPicture = New Button()
        btnOpenForm2 = New Button()
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
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        Panel2 = New Panel()
        PictureBox8 = New PictureBox()
        CType(dgvBicycles, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbBikePicture, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBicycleID
        ' 
        lblBicycleID.AutoSize = True
        lblBicycleID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBicycleID.Location = New Point(252, 278)
        lblBicycleID.Name = "lblBicycleID"
        lblBicycleID.Size = New Size(89, 21)
        lblBicycleID.TabIndex = 0
        lblBicycleID.Text = "Bicycle ID:"
        ' 
        ' txtBicycleID
        ' 
        txtBicycleID.Location = New Point(347, 276)
        txtBicycleID.Name = "txtBicycleID"
        txtBicycleID.Size = New Size(100, 23)
        txtBicycleID.TabIndex = 1
        ' 
        ' lblType
        ' 
        lblType.AutoSize = True
        lblType.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblType.Location = New Point(453, 278)
        lblType.Name = "lblType"
        lblType.Size = New Size(50, 21)
        lblType.TabIndex = 2
        lblType.Text = "Type:"
        ' 
        ' txtType
        ' 
        txtType.Location = New Point(509, 276)
        txtType.Name = "txtType"
        txtType.Size = New Size(100, 23)
        txtType.TabIndex = 3
        ' 
        ' lblPicture
        ' 
        lblPicture.AutoSize = True
        lblPicture.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPicture.Location = New Point(3, 85)
        lblPicture.Name = "lblPicture"
        lblPicture.Size = New Size(68, 21)
        lblPicture.TabIndex = 4
        lblPicture.Text = "Picture:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(615, 278)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(61, 21)
        lblStatus.TabIndex = 6
        lblStatus.Text = "Status:"
        ' 
        ' cmbStatus
        ' 
        cmbStatus.FormattingEnabled = True
        cmbStatus.Location = New Point(682, 276)
        cmbStatus.Name = "cmbStatus"
        cmbStatus.Size = New Size(102, 23)
        cmbStatus.TabIndex = 7
        ' 
        ' btnAddBike
        ' 
        btnAddBike.FlatStyle = FlatStyle.Popup
        btnAddBike.Location = New Point(264, 66)
        btnAddBike.Name = "btnAddBike"
        btnAddBike.Size = New Size(90, 23)
        btnAddBike.TabIndex = 8
        btnAddBike.Text = "Add Bicycle"
        btnAddBike.UseVisualStyleBackColor = True
        ' 
        ' btnSaveChanges
        ' 
        btnSaveChanges.FlatStyle = FlatStyle.Popup
        btnSaveChanges.Location = New Point(360, 66)
        btnSaveChanges.Name = "btnSaveChanges"
        btnSaveChanges.Size = New Size(90, 24)
        btnSaveChanges.TabIndex = 9
        btnSaveChanges.Text = "Save"
        btnSaveChanges.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteBike
        ' 
        btnDeleteBike.FlatStyle = FlatStyle.Popup
        btnDeleteBike.Location = New Point(456, 66)
        btnDeleteBike.Name = "btnDeleteBike"
        btnDeleteBike.Size = New Size(90, 24)
        btnDeleteBike.TabIndex = 10
        btnDeleteBike.Text = "Delete Bicycle"
        btnDeleteBike.UseVisualStyleBackColor = True
        ' 
        ' dgvBicycles
        ' 
        dgvBicycles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvBicycles.Columns.AddRange(New DataGridViewColumn() {picture})
        dgvBicycles.Location = New Point(251, 3)
        dgvBicycles.Name = "dgvBicycles"
        dgvBicycles.RowHeadersWidth = 25
        dgvBicycles.Size = New Size(621, 242)
        dgvBicycles.TabIndex = 12
        ' 
        ' picture
        ' 
        picture.HeaderText = "Bike Picture"
        picture.ImageLayout = DataGridViewImageCellLayout.Stretch
        picture.Name = "picture"
        ' 
        ' pbBikePicture
        ' 
        pbBikePicture.BackColor = Color.White
        pbBikePicture.BackgroundImage = My.Resources.Resources.bicycle__2_
        pbBikePicture.BackgroundImageLayout = ImageLayout.Center
        pbBikePicture.Location = New Point(67, 54)
        pbBikePicture.Name = "pbBikePicture"
        pbBikePicture.Size = New Size(110, 108)
        pbBikePicture.TabIndex = 13
        pbBikePicture.TabStop = False
        ' 
        ' btnUploadPicture
        ' 
        btnUploadPicture.FlatStyle = FlatStyle.Popup
        btnUploadPicture.Location = New Point(183, 66)
        btnUploadPicture.Name = "btnUploadPicture"
        btnUploadPicture.Size = New Size(75, 23)
        btnUploadPicture.TabIndex = 14
        btnUploadPicture.Text = "Upload"
        btnUploadPicture.UseVisualStyleBackColor = True
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(824, 371)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(48, 33)
        btnOpenForm2.TabIndex = 15
        btnOpenForm2.UseVisualStyleBackColor = True
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
        Panel1.Location = New Point(-1, 1)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 415)
        Panel1.TabIndex = 16
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
        PictureBox7.TabIndex = 38
        PictureBox7.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, 324)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 37
        PictureBox1.TabStop = False
        ' 
        ' btnReturn
        ' 
        btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImageLayout = ImageLayout.None
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(65, 324)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(171, 42)
        btnReturn.TabIndex = 36
        btnReturn.Text = "Return the Bike"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = My.Resources.Resources.power_off
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(3, 379)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(40, 36)
        btnLogout.TabIndex = 21
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnManageBikes
        ' 
        btnManageBikes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnManageBikes.BackColor = Color.Transparent
        btnManageBikes.BackgroundImageLayout = ImageLayout.None
        btnManageBikes.FlatStyle = FlatStyle.Flat
        btnManageBikes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageBikes.Location = New Point(65, 278)
        btnManageBikes.Name = "btnManageBikes"
        btnManageBikes.Size = New Size(171, 42)
        btnManageBikes.TabIndex = 11
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
        btnViewHistory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewHistory.Location = New Point(65, 230)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(171, 42)
        btnViewHistory.TabIndex = 13
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
        btnManageMaintenance.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageMaintenance.Location = New Point(65, 182)
        btnManageMaintenance.Name = "btnManageMaintenance"
        btnManageMaintenance.Size = New Size(171, 42)
        btnManageMaintenance.TabIndex = 14
        btnManageMaintenance.Text = "Maintenance"
        btnManageMaintenance.TextAlign = ContentAlignment.MiddleLeft
        btnManageMaintenance.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.bicycle__1_
        PictureBox5.Location = New Point(1, 278)
        PictureBox5.Margin = New Padding(0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 42)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 19
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.history
        PictureBox4.Location = New Point(0, 230)
        PictureBox4.Margin = New Padding(0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(65, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.preferences__1_
        PictureBox3.Location = New Point(1, 182)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.bicycle
        PictureBox2.Location = New Point(1, 134)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 15
        PictureBox2.TabStop = False
        ' 
        ' btnHandleRentals
        ' 
        btnHandleRentals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHandleRentals.BackColor = Color.Transparent
        btnHandleRentals.BackgroundImageLayout = ImageLayout.None
        btnHandleRentals.FlatStyle = FlatStyle.Flat
        btnHandleRentals.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHandleRentals.Location = New Point(65, 134)
        btnHandleRentals.Name = "btnHandleRentals"
        btnHandleRentals.Size = New Size(171, 42)
        btnHandleRentals.TabIndex = 12
        btnHandleRentals.Text = "Handle Rentals"
        btnHandleRentals.TextAlign = ContentAlignment.MiddleLeft
        btnHandleRentals.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.ControlDarkDark
        FlowLayoutPanel1.Location = New Point(235, 1)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(10, 415)
        FlowLayoutPanel1.TabIndex = 21
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.Controls.Add(btnUploadPicture)
        Panel2.Controls.Add(btnAddBike)
        Panel2.Controls.Add(pbBikePicture)
        Panel2.Controls.Add(btnSaveChanges)
        Panel2.Controls.Add(btnDeleteBike)
        Panel2.Controls.Add(lblPicture)
        Panel2.Controls.Add(PictureBox8)
        Panel2.Location = New Point(252, 251)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(566, 165)
        Panel2.TabIndex = 22
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackgroundImage = My.Resources.Resources.Screenshot_2024_11_03_124802_modified
        PictureBox8.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox8.Location = New Point(180, 74)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(386, 91)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(884, 416)
        Controls.Add(btnOpenForm2)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(dgvBicycles)
        Controls.Add(cmbStatus)
        Controls.Add(lblStatus)
        Controls.Add(txtType)
        Controls.Add(lblType)
        Controls.Add(txtBicycleID)
        Controls.Add(lblBicycleID)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Form3"
        Text = " "
        CType(dgvBicycles, ComponentModel.ISupportInitialize).EndInit()
        CType(pbBikePicture, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBicycleID As Label
    Friend WithEvents txtBicycleID As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents lblPicture As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents btnAddBike As Button
    Friend WithEvents btnSaveChanges As Button
    Friend WithEvents btnDeleteBike As Button
    Friend WithEvents dgvBicycles As DataGridView
    Friend WithEvents pbBikePicture As PictureBox
    Friend WithEvents btnUploadPicture As Button
    Friend WithEvents btnOpenForm2 As Button
    Friend WithEvents picture As DataGridViewImageColumn
    Private WithEvents Panel1 As Panel
    Friend WithEvents btnManageBikes As Button
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnManageMaintenance As Button
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnHandleRentals As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
