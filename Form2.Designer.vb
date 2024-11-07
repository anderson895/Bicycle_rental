<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        btnManageBikes = New Button()
        btnHandleRentals = New Button()
        btnViewHistory = New Button()
        btnManageMaintenance = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        btnReturn = New Button()
        btnLogout = New Button()
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnManageBikes
        ' 
        btnManageBikes.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnManageBikes.BackColor = Color.Transparent
        btnManageBikes.BackgroundImageLayout = ImageLayout.None
        btnManageBikes.FlatStyle = FlatStyle.Flat
        btnManageBikes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnManageBikes.Location = New Point(67, 275)
        btnManageBikes.Name = "btnManageBikes"
        btnManageBikes.Size = New Size(154, 42)
        btnManageBikes.TabIndex = 0
        btnManageBikes.Text = "Bicycle Inventory"
        btnManageBikes.TextAlign = ContentAlignment.MiddleLeft
        btnManageBikes.UseVisualStyleBackColor = False
        ' 
        ' btnHandleRentals
        ' 
        btnHandleRentals.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnHandleRentals.BackColor = Color.Transparent
        btnHandleRentals.BackgroundImageLayout = ImageLayout.None
        btnHandleRentals.FlatStyle = FlatStyle.Flat
        btnHandleRentals.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHandleRentals.Location = New Point(67, 131)
        btnHandleRentals.Name = "btnHandleRentals"
        btnHandleRentals.Size = New Size(154, 42)
        btnHandleRentals.TabIndex = 1
        btnHandleRentals.Text = "Handle Rentals"
        btnHandleRentals.TextAlign = ContentAlignment.MiddleLeft
        btnHandleRentals.UseVisualStyleBackColor = False
        ' 
        ' btnViewHistory
        ' 
        btnViewHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnViewHistory.BackColor = Color.Transparent
        btnViewHistory.BackgroundImageLayout = ImageLayout.None
        btnViewHistory.FlatStyle = FlatStyle.Flat
        btnViewHistory.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewHistory.Location = New Point(67, 227)
        btnViewHistory.Name = "btnViewHistory"
        btnViewHistory.Size = New Size(154, 42)
        btnViewHistory.TabIndex = 2
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
        btnManageMaintenance.Location = New Point(67, 179)
        btnManageMaintenance.Name = "btnManageMaintenance"
        btnManageMaintenance.Size = New Size(154, 42)
        btnManageMaintenance.TabIndex = 3
        btnManageMaintenance.Text = "Maintenance"
        btnManageMaintenance.TextAlign = ContentAlignment.MiddleLeft
        btnManageMaintenance.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlDark
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(btnReturn)
        Panel1.Controls.Add(btnLogout)
        Panel1.Controls.Add(PictureBox6)
        Panel1.Controls.Add(btnManageBikes)
        Panel1.Controls.Add(btnViewHistory)
        Panel1.Controls.Add(btnManageMaintenance)
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(btnHandleRentals)
        Panel1.Location = New Point(1, 0)
        Panel1.Margin = New Padding(0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(224, 415)
        Panel1.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 320)
        PictureBox1.Margin = New Padding(0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(64, 42)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' btnReturn
        ' 
        btnReturn.AutoSizeMode = AutoSizeMode.GrowAndShrink
        btnReturn.BackColor = Color.Transparent
        btnReturn.BackgroundImageLayout = ImageLayout.None
        btnReturn.FlatStyle = FlatStyle.Flat
        btnReturn.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReturn.Location = New Point(67, 320)
        btnReturn.Name = "btnReturn"
        btnReturn.Size = New Size(154, 42)
        btnReturn.TabIndex = 38
        btnReturn.Text = "Return the Bike"
        btnReturn.TextAlign = ContentAlignment.MiddleLeft
        btnReturn.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackgroundImage = My.Resources.Resources.power_off
        btnLogout.BackgroundImageLayout = ImageLayout.Stretch
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Location = New Point(0, 379)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(40, 36)
        btnLogout.TabIndex = 1
        btnLogout.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.None
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.bicycle__1_
        PictureBox5.Location = New Point(3, 275)
        PictureBox5.Margin = New Padding(0)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(64, 42)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.history
        PictureBox4.Location = New Point(0, 227)
        PictureBox4.Margin = New Padding(0)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(64, 42)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = My.Resources.Resources.preferences__1_
        PictureBox3.Location = New Point(3, 179)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(64, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.bicycle
        PictureBox2.Location = New Point(3, 131)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(64, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(239, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 30)
        Label1.TabIndex = 6
        Label1.Text = "DashBoard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlDarkDark
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(223, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(10, 415)
        Panel2.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackgroundImageLayout = ImageLayout.Center
        Panel3.Controls.Add(PictureBox7)
        Panel3.ForeColor = SystemColors.ControlText
        Panel3.Location = New Point(228, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(655, 415)
        Panel3.TabIndex = 8
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = My.Resources.Resources.bike_silhouette_clip_art_7
        PictureBox7.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox7.Location = New Point(420, 251)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(235, 164)
        PictureBox7.TabIndex = 0
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Anchor = AnchorStyles.None
        PictureBox6.BackColor = Color.Transparent
        PictureBox6.Image = My.Resources.Resources.logo_2
        PictureBox6.Location = New Point(0, 0)
        PictureBox6.Margin = New Padding(0)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(224, 131)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 10
        PictureBox6.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gainsboro
        ClientSize = New Size(884, 416)
        Controls.Add(Label1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Panel3)
        Name = "Form2"
        Text = "Main Menu"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnManageBikes As Button
    Friend WithEvents btnHandleRentals As Button
    Friend WithEvents btnViewHistory As Button
    Friend WithEvents btnManageMaintenance As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnReturn As Button
    Friend WithEvents PictureBox6 As PictureBox
End Class
