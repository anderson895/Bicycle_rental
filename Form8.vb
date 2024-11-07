Imports System.Drawing.Printing

Public Class FinalReceipt
    Private receiptDetails As String
    Private isRentalReceipt As Boolean
    Private printDoc As New PrintDocument()

    Public Sub New(details As String, isRentalReceipt As Boolean)
        InitializeComponent()
        Me.receiptDetails = details
        Me.isRentalReceipt = isRentalReceipt

        ' Initialize the PrintDocument event handler
        AddHandler printDoc.PrintPage, AddressOf Me.PrintDocument_PrintPage
    End Sub

    Private Sub FinalReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblReceiptDetails.Text = receiptDetails
    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click
        ' Open the PrintDialog to let the user select a printer and print options
        Using printDialog As New PrintDialog()
            printDialog.Document = printDoc

            If printDialog.ShowDialog() = DialogResult.OK Then
                printDoc.Print() ' Start the printing process
            End If
        End Using
    End Sub

    Private Sub PrintDocument_PrintPage(sender As Object, e As PrintPageEventArgs)
        ' Set up the font and layout for printing
        Dim printFont As New Font("Arial", 12)
        Dim layoutRectangle As New RectangleF(50, 50, e.MarginBounds.Width, e.MarginBounds.Height)

        ' Print the receipt details
        e.Graphics.DrawString(receiptDetails, printFont, Brushes.Black, layoutRectangle)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim returnForm As New ReturnForm()
        Me.Hide()
        returnForm.ShowDialog()
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub
End Class
