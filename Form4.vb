Imports System.Data.SQLite

Public Class Form4
    Private connString As String = "Data Source=bicycle_rental.db;Version=3
;Busy Timeout=5000;" ' 5 seconds

    ' Handle form load
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBicycles()
        PopulateHoursComboBox() ' Call to populate hours
    End Sub
    Private Sub PopulateHoursComboBox()
        wantedhoursfuser.Items.Clear() ' Clear any existing items
        For i As Integer = 1 To 8
            wantedhoursfuser.Items.Add(i)
        Next
    End Sub
    ' Load available bicycles into the combo box
    Private Sub LoadBicycles()
        cmbBicycleID.Items.Clear() ' Clear the current items in the combo box
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT bicycle_id FROM bicycles WHERE status = 'Available'", conn)
            Dim reader As SQLiteDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbBicycleID.Items.Add(reader("bicycle_id"))
            End While
        End Using
    End Sub

    ' Method to open Form3 and handle bicycle addition
    Private Sub btnOpenForm3_Click(sender As Object, e As EventArgs) Handles btnOpenForm3.Click
        Dim form3 As New Form3()
        AddHandler form3.BicycleAdded, AddressOf OnBicycleAdded
        Me.Hide()
        form3.ShowDialog()
        RemoveHandler form3.BicycleAdded, AddressOf OnBicycleAdded
    End Sub

    ' Event handler to update the combo box when a bicycle is added
    Private Sub OnBicycleAdded(bicycleID As Integer)
        cmbBicycleID.Items.Add(bicycleID)
    End Sub

    ' Method to calculate total fees
    Private Sub CalculateTotalFees()
        Dim rentalDuration As TimeSpan = dtpEndTime.Value - dtpStartTime.Value
        Dim totalHours As Double = rentalDuration.TotalHours
        Dim rentalRate As Double = 20.0 ' 20 PHP per hour
        Dim totalFees As Double = Math.Max(totalHours * rentalRate, 0) ' Prevent negative fees

        txtTotalFees.Text = totalFees.ToString("F2") ' Display total fees
    End Sub

    ' Automatically calculate fees when the start or end time changes
    Private Sub dtpStartTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpStartTime.ValueChanged
        CalculateTotalFees()
    End Sub

    Private Sub dtpEndTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpEndTime.ValueChanged
        CalculateTotalFees()
    End Sub

    ' Handle rentals
    Private Sub btnRent_Click(sender As Object, e As EventArgs) Handles btnRent.Click
        ' Validation: Ensure required fields are filled in
        If cmbBicycleID.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a bicycle ID.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbBicycleID.Focus()
            Return
        ElseIf String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Please enter the customer's name.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtCustomerName.Focus()
            Return
        ElseIf dtpStartTime.Value >= dtpEndTime.Value Then
            MessageBox.Show("The rental end time must be later than the start time.", "Invalid Time", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndTime.Focus()
            Return
        End If

        Dim confirmResult As DialogResult = MessageBox.Show("Confirm rental?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmResult = DialogResult.No Then Return ' Exit if the user cancels

        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Using transaction As SQLiteTransaction = conn.BeginTransaction()
                Try
                    Dim rentalDuration As TimeSpan = dtpEndTime.Value - dtpStartTime.Value
                    Dim totalHours As Double = rentalDuration.TotalHours
                    Dim rentalRate As Double = 20.0 ' 20 PHP per hour
                    Dim totalFees As Double = Math.Max(totalHours * rentalRate, 0) ' Prevent negative fees

                    ' Insert rental and get the generated Rental ID
                    Dim cmd As New SQLiteCommand("INSERT INTO rentals (bicycle_id, customer_name, rental_start_time, rental_end_time, total_fees) VALUES (@bicycle_id, @customer_name, @rental_start_time, @rental_end_time, @total_fees); SELECT last_insert_rowid();", conn)
                    cmd.Parameters.AddWithValue("@bicycle_id", cmbBicycleID.SelectedItem)
                    cmd.Parameters.AddWithValue("@customer_name", txtCustomerName.Text)
                    cmd.Parameters.AddWithValue("@rental_start_time", dtpStartTime.Value)
                    cmd.Parameters.AddWithValue("@rental_end_time", dtpEndTime.Value)
                    cmd.Parameters.AddWithValue("@total_fees", totalFees)
                    Dim rentalID As Integer = Convert.ToInt32(cmd.ExecuteScalar()) ' Retrieve the Rental ID

                    ' Update bicycle status to 'Rented'
                    Dim updateCmd As New SQLiteCommand("UPDATE bicycles SET status = 'Rented' WHERE bicycle_id = @bicycle_id", conn)
                    updateCmd.Parameters.AddWithValue("@bicycle_id", cmbBicycleID.SelectedItem)
                    updateCmd.ExecuteNonQuery()

                    transaction.Commit()

                    ' Show FinalReceipt form with rental details
                    Dim rentalDetails As String = $"Rental ID: {rentalID}" & Environment.NewLine &
                                                  $"Customer Name: {txtCustomerName.Text}" & Environment.NewLine &
                                                  $"Bicycle ID: {cmbBicycleID.SelectedItem}" & Environment.NewLine &
                                                  $"Start Time: {dtpStartTime.Value}" & Environment.NewLine &
                                                  $"End Time: {dtpEndTime.Value}" & Environment.NewLine &
                                                  $"Total Fees: PHP {totalFees:F2}"

                    Dim receiptForm As New FinalReceipt(rentalDetails, True) ' True indicates it's a rental receipt
                    receiptForm.ShowDialog()

                    ' Refresh available bicycles and clear input fields
                    LoadBicycles()
                    cmbBicycleID.SelectedIndex = -1
                    txtCustomerName.Clear()
                    txtTotalFees.Clear()
                    MessageBox.Show("Rental successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form2 As New Form2()
        Me.Hide()
        form2.Show()
    End Sub

    Private Sub lblCustomerName_Click(sender As Object, e As EventArgs) Handles lblCustomerName.Click

    End Sub

    Private Sub wantedhoursfuser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wantedhoursfuser.SelectedIndexChanged
        If wantedhoursfuser.SelectedItem IsNot Nothing Then
            Dim selectedHours As Integer = CInt(wantedhoursfuser.SelectedItem)
            Dim startTime As DateTime = dtpStartTime.Value
            Dim newEndTime As DateTime = startTime.AddHours(selectedHours)
            dtpEndTime.Value = newEndTime ' Update end time
            CalculateTotalFees() ' Recalculate fees based on new end time
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnReturn_Click_1(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        returnForm.ShowDialog()
    End Sub

    Private Sub btnHandleRentals_Click(sender As Object, e As EventArgs) Handles btnHandleRentals.Click
        Dim rentalForm As New Form4()
        rentalForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnManageMaintenance_Click(sender As Object, e As EventArgs) Handles btnManageMaintenance.Click
        Dim maintenanceForm As New txtDescription()
        maintenanceForm.Show()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
        Me.Close()

    End Sub
End Class
