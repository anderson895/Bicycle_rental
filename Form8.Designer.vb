<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinalReceipt
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
        lblReceiptDetails = New Label()
        btnPrintReceipt = New Button()
        btnBack = New Button()
        btnOpenForm2 = New Button()
        SuspendLayout()
        ' 
        ' lblReceiptDetails
        ' 
        lblReceiptDetails.AutoSize = True
        lblReceiptDetails.Location = New Point(66, 39)
        lblReceiptDetails.Name = "lblReceiptDetails"
        lblReceiptDetails.Size = New Size(41, 15)
        lblReceiptDetails.TabIndex = 0
        lblReceiptDetails.Text = "Label1"
        ' 
        ' btnPrintReceipt
        ' 
        btnPrintReceipt.Location = New Point(66, 196)
        btnPrintReceipt.Name = "btnPrintReceipt"
        btnPrintReceipt.Size = New Size(75, 23)
        btnPrintReceipt.TabIndex = 1
        btnPrintReceipt.Text = "Print"
        btnPrintReceipt.UseVisualStyleBackColor = True
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(210, 196)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 23)
        btnBack.TabIndex = 2
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(330, 402)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(51, 36)
        btnOpenForm2.TabIndex = 17
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' FinalReceipt
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(393, 450)
        Controls.Add(btnOpenForm2)
        Controls.Add(btnBack)
        Controls.Add(btnPrintReceipt)
        Controls.Add(lblReceiptDetails)
        Name = "FinalReceipt"
        Text = "Form8"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblReceiptDetails As Label
    Friend WithEvents btnPrintReceipt As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnOpenForm2 As Button
End Class
