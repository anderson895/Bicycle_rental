Imports System.Data.SQLite

Public Class Form5
    Private connString As String = "Data Source=bicycle_rental.db;Version=3;"

    Private Sub LoadRentalHistory()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            ' Load all rentals, including completed ones
            Dim cmd As New SQLiteCommand("SELECT rentals.*, bicycles.status FROM rentals INNER JOIN bicycles ON rentals.bicycle_id = bicycles.bicycle_id", conn)
            Dim adapter As New SQLiteDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvRentalHistory.DataSource = table
        End Using
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRentalHistory()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim filter As String = txtSearch.Text
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            ' Modified query to include status when searching by customer name
            Dim cmd As New SQLiteCommand("SELECT rentals.*, bicycles.status FROM rentals INNER JOIN bicycles ON rentals.bicycle_id = bicycles.bicycle_id WHERE customer_name LIKE @filter", conn)
            cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
            Dim adapter As New SQLiteDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvRentalHistory.DataSource = table
        End Using
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form2 As New Form2()
        form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        returnForm.ShowDialog()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnManageMaintenance_Click(sender As Object, e As EventArgs) Handles btnManageMaintenance.Click
        Dim maintenanceForm As New txtDescription()
        maintenanceForm.Show()
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

    Private Sub btnManageBikes_Click(sender As Object, e As EventArgs) Handles btnManageBikes.Click
        Dim bikeForm As New Form3()
        bikeForm.Show()
        Me.Hide()
    End Sub
End Class
