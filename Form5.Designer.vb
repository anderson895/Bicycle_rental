<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        lblSearch = New Label()
        txtSearch = New TextBox()
        dgvRentalHistory = New DataGridView()
        btnOpenForm2 = New Button()
        Panel1 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox1 = New PictureBox()
        btnLogout = New Button()
        btnReturn = New Button()
        btnManageBikes = New Button()
        btnViewHistory = New Button()
        btnManageMaintenance = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnHandleRentals = New Button()
        Panel2 = New Panel()
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSearch.Location = New Point(364, 342)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(211, 21)
        lblSearch.TabIndex = 0
        lblSearch.Text = "Search by Customer Name"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(581, 344)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(100, 23)
        txtSearch.TabIndex = 1
        ' 
        ' dgvRentalHistory
        ' 
        dgvRentalHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRentalHistory.GridColor = SystemColors.InactiveCaption
        dgvRentalHistory.Location = New Point(263, 12)
        dgvRentalHistory.Name = "dgvRentalHistory"
        dgvRentalHistory.Size = New Size(538, 296)
        dgvRentalHistory.TabIndex = 2
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(750, 369)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(51, 36)
        btnOpenForm2.TabIndex = 16
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(PictureBox7)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(btnReturn)
        Panel1.Controls.Add(btnManageBikes)
        Panel1.Controls.Add(btnViewHistory)
        Panel1.Controls.Add(btnManageMaintenance)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnHandleRentals)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(236, 415)
        Panel1.TabIndex = 17
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
        PictureBox7.TabIndex = 40
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
        PictureBox1.Size = New Size(64, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = My.Resources.Resources.power_off
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(3, 376)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(40, 36)
        btnLogout.TabIndex = 41
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' btnReturn
        ' 
        btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImageLayout = ImageLayout.None
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(64, 326)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(172, 42)
        btnReturn.TabIndex = 38
        btnReturn.Text = "Return the Bike"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnManageBikes
        ' 
        btnManageBikes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnManageBikes.BackColor = Color.Transparent
        btnManageBikes.BackgroundImageLayout = ImageLayout.None
        btnManageBikes.FlatStyle = FlatStyle.Flat
        btnManageBikes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageBikes.Location = New Point(64, 278)
        btnManageBikes.Name = "btnManageBikes"
        btnManageBikes.Size = New Size(172, 42)
        btnManageBikes.TabIndex = 32
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
        btnViewHistory.Location = New Point(64, 230)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(172, 42)
        btnViewHistory.TabIndex = 34
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
        btnManageMaintenance.Location = New Point(64, 182)
        btnManageMaintenance.Name = "btnManageMaintenance"
        btnManageMaintenance.Size = New Size(172, 42)
        btnManageMaintenance.TabIndex = 35
        btnManageMaintenance.Text = "Maintenance"
        btnManageMaintenance.TextAlign = ContentAlignment.MiddleLeft
        btnManageMaintenance.UseVisualStyleBackColor = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.bicycle__1_
        PictureBox5.Location = New Point(0, 278)
        PictureBox5.Margin = New Padding(0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 42)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 39
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
        PictureBox4.Size = New Size(64, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 38
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.preferences__1_
        PictureBox3.Location = New Point(0, 182)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 37
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.bicycle
        PictureBox2.Location = New Point(0, 134)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 36
        PictureBox2.TabStop = False
        ' 
        ' btnHandleRentals
        ' 
        btnHandleRentals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHandleRentals.BackColor = Color.Transparent
        btnHandleRentals.BackgroundImageLayout = ImageLayout.None
        btnHandleRentals.FlatStyle = FlatStyle.Flat
        btnHandleRentals.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHandleRentals.Location = New Point(64, 134)
        btnHandleRentals.Name = "btnHandleRentals"
        btnHandleRentals.Size = New Size(172, 42)
        btnHandleRentals.TabIndex = 33
        btnHandleRentals.Text = "Handle Rentals"
        btnHandleRentals.TextAlign = ContentAlignment.MiddleLeft
        btnHandleRentals.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.Location = New Point(236, 1)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 415)
        Panel2.TabIndex = 18
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(813, 417)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(btnOpenForm2)
        Controls.Add(dgvRentalHistory)
        Controls.Add(txtSearch)
        Controls.Add(lblSearch)
        Name = "Form5"
        Text = "Form5"
        CType(dgvRentalHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents dgvRentalHistory As DataGridView
    Friend WithEvents btnOpenForm2 As Button
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox7 As PictureBox
End Class
