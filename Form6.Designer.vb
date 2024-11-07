<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class txtDescription
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblBicycleID = New Label()
        lblMaintenanceDate = New Label()
        btnOpenForm2 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtDescript = New TextBox()
        Label4 = New Label()
        txtTechName = New TextBox()
        txtBicycleID = New TextBox()
        maintinanceDate = New DateTimePicker()
        btnSave = New Button()
        txtSearchID = New TextBox()
        Label5 = New Label()
        table_record = New DataGridView()
        comboStatus = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        completionDatepicker = New DateTimePicker()
        CType(table_record, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblBicycleID
        ' 
        lblBicycleID.AutoSize = True
        lblBicycleID.Location = New Point(45, 30)
        lblBicycleID.Name = "lblBicycleID"
        lblBicycleID.Size = New Size(58, 15)
        lblBicycleID.TabIndex = 0
        lblBicycleID.Text = "Bicycle ID"
        ' 
        ' lblMaintenanceDate
        ' 
        lblMaintenanceDate.AutoSize = True
        lblMaintenanceDate.Location = New Point(12, 61)
        lblMaintenanceDate.Name = "lblMaintenanceDate"
        lblMaintenanceDate.Size = New Size(103, 15)
        lblMaintenanceDate.TabIndex = 2
        lblMaintenanceDate.Text = "Maintenance Date"
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(834, 402)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(51, 36)
        btnOpenForm2.TabIndex = 17
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 15)
        Label1.TabIndex = 0
        Label1.Text = "Expected Completion Date"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(37, 143)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 21
        Label2.Text = "Status"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 22
        Label3.Text = "Description"
        ' 
        ' txtDescript
        ' 
        txtDescript.Location = New Point(193, 186)
        txtDescript.Name = "txtDescript"
        txtDescript.Size = New Size(200, 23)
        txtDescript.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 230)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 24
        Label4.Text = "Technician Name"
        ' 
        ' txtTechName
        ' 
        txtTechName.Location = New Point(193, 223)
        txtTechName.Name = "txtTechName"
        txtTechName.Size = New Size(200, 23)
        txtTechName.TabIndex = 25
        ' 
        ' txtBicycleID
        ' 
        txtBicycleID.Location = New Point(193, 22)
        txtBicycleID.Name = "txtBicycleID"
        txtBicycleID.Size = New Size(200, 23)
        txtBicycleID.TabIndex = 26
        ' 
        ' maintinanceDate
        ' 
        maintinanceDate.Location = New Point(193, 65)
        maintinanceDate.Name = "maintinanceDate"
        maintinanceDate.Size = New Size(200, 23)
        maintinanceDate.TabIndex = 27
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(39, 269)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 28
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtSearchID
        ' 
        txtSearchID.Location = New Point(538, 30)
        txtSearchID.Name = "txtSearchID"
        txtSearchID.Size = New Size(232, 23)
        txtSearchID.TabIndex = 29
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(629, 9)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 15)
        Label5.TabIndex = 30
        Label5.Text = "Search ID"
        ' 
        ' table_record
        ' 
        table_record.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        table_record.Location = New Point(413, 75)
        table_record.Name = "table_record"
        table_record.Size = New Size(472, 283)
        table_record.TabIndex = 31
        ' 
        ' comboStatus
        ' 
        comboStatus.FormattingEnabled = True
        comboStatus.Items.AddRange(New Object() {"Pending", "Paid"})
        comboStatus.Location = New Point(194, 147)
        comboStatus.Name = "comboStatus"
        comboStatus.Size = New Size(199, 23)
        comboStatus.TabIndex = 32
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(415, 453)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 33
        ' 
        ' completionDatepicker
        ' 
        completionDatepicker.Location = New Point(193, 103)
        completionDatepicker.Name = "completionDatepicker"
        completionDatepicker.Size = New Size(200, 23)
        completionDatepicker.TabIndex = 34
        ' 
        ' txtDescription
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(897, 450)
        Controls.Add(completionDatepicker)
        Controls.Add(DateTimePicker1)
        Controls.Add(comboStatus)
        Controls.Add(table_record)
        Controls.Add(Label5)
        Controls.Add(txtSearchID)
        Controls.Add(btnSave)
        Controls.Add(maintinanceDate)
        Controls.Add(txtBicycleID)
        Controls.Add(txtTechName)
        Controls.Add(Label4)
        Controls.Add(txtDescript)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnOpenForm2)
        Controls.Add(lblMaintenanceDate)
        Controls.Add(lblBicycleID)
        Name = "txtDescription"
        Text = "Form6"
        CType(table_record, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblBicycleID As Label
    Friend WithEvents lblMaintenanceDate As Label
    Friend WithEvents btnOpenForm2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescript As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTechName As TextBox
    Friend WithEvents txtBicycleID As TextBox
    Friend WithEvents maintinanceDate As DateTimePicker
    Friend WithEvents btnSave As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents table_record As DataGridView
    Friend WithEvents comboStatus As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents completionDatepicker As DateTimePicker
End Class
