Imports System.Windows.Forms.DataVisualization.Charting ' Import the necessary namespace

Public Class Form2

    Private Sub btnManageBikes_Click(sender As Object, e As EventArgs) Handles btnManageBikes.Click
        Dim bikeForm As New Form3()
        bikeForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnHandleRentals_Click(sender As Object, e As EventArgs) Handles btnHandleRentals.Click
        Dim rentalForm As New Form4()
        rentalForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnViewHistory_Click(sender As Object, e As EventArgs) Handles btnViewHistory.Click
        Dim historyForm As New Form5()
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageMaintenance_Click(sender As Object, e As EventArgs) Handles btnManageMaintenance.Click
        Dim maintenanceForm As New txtDescription()
        maintenanceForm.Show()
        Me.Hide()
    End Sub



    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Logic for logout
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        ' Logic for PictureBox1 click
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        ' Logic for PictureBox2 click
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Logic for Panel1 paint
    End Sub

    Private Sub btnLogout_Click_1(sender As Object, e As EventArgs) Handles btnLogout.Click
        ' Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        ' Logic for Panel3 paint
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        returnForm.ShowDialog()
    End Sub
End Class
