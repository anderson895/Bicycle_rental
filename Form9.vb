Imports System.Data.SQLite

Public Class ReturnForm
    Private connString As String = "Data Source=bicycle_rental.db;Version=3;Busy Timeout=5000;"
    Private baseRatePerHour As Decimal = 20 ' Rental rate per hour

    ' Search for the rental record based on customer name
    Private Sub btnCustomerSearch_Click(sender As Object, e As EventArgs) Handles btnCustomerSearch.Click
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT bicycle_id, rental_start_time, rental_end_time FROM rentals WHERE customer_name = @customer_name AND is_completed = 0", conn)
            cmd.Parameters.AddWithValue("@customer_name", txtCustomerName.Text)

            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtBicycleID.Text = reader("bicycle_id").ToString()
                    Dim rentalStartTime As DateTime = Convert.ToDateTime(reader("rental_start_time"))
                    Dim rentalEndTime As DateTime = Convert.ToDateTime(reader("rental_end_time"))

                    ' Automatically set the return time to now
                    dtpReturnTime.Value = DateTime.Now

                    ' Calculate total fees including any late fees and display
                    Dim totalFees As Decimal = CalculateTotalFees(rentalStartTime, rentalEndTime, dtpReturnTime.Value)
                    lblTotalFeesValue.Text = $"{totalFees:C2}" ' Display total fees
                Else
                    MessageBox.Show("Rental record not found.")
                    txtBicycleID.Clear()
                    lblTotalFeesValue.Text = "0.00"
                End If
            End Using
        End Using
    End Sub

    ' Calculate the total fees including late fee
    Private Function CalculateTotalFees(rentalStartTime As DateTime, rentalEndTime As DateTime, actualReturnTime As DateTime) As Decimal
        Dim rentalDuration As TimeSpan = rentalEndTime - rentalStartTime
        Dim expectedFee As Decimal = CDec(rentalDuration.TotalHours) * baseRatePerHour

        Dim lateFee As Decimal = CalculateLateFee(rentalEndTime, actualReturnTime)

        Return expectedFee + lateFee
    End Function

    ' Preview receipt in the FinalReceipt form
    Private Sub btnPreviewReceipt_Click(sender As Object, e As EventArgs) Handles btnPreviewReceipt.Click
        Try
            If String.IsNullOrEmpty(txtCustomerName.Text) Or String.IsNullOrEmpty(txtBicycleID.Text) Then
                MessageBox.Show("Please search for a rental record before previewing the receipt.")
                Return
            End If

            ' Retrieve rental start time and end time from the database
            Dim rentalStartTime As DateTime
            Dim rentalEndTime As DateTime

            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim cmd As New SQLiteCommand("SELECT rental_start_time, rental_end_time FROM rentals WHERE customer_name = @customer_name AND bicycle_id = @bicycle_id", conn)
                cmd.Parameters.AddWithValue("@customer_name", txtCustomerName.Text)
                cmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        rentalStartTime = Convert.ToDateTime(reader("rental_start_time"))
                        rentalEndTime = Convert.ToDateTime(reader("rental_end_time"))
                    End If
                End Using
            End Using

            ' Calculate total fees including late fee based on current return time
            Dim actualReturnTime As DateTime = dtpReturnTime.Value
            Dim totalFees As Decimal = CalculateTotalFees(rentalStartTime, rentalEndTime, actualReturnTime)

            ' Format and display the receipt details
            Dim receiptDetails As String = $"Customer Name: {txtCustomerName.Text}" & Environment.NewLine &
                                           $"Bicycle ID: {txtBicycleID.Text}" & Environment.NewLine &
                                           $"Rental Start Time: {rentalStartTime}" & Environment.NewLine &
                                           $"Scheduled Return Time: {rentalEndTime}" & Environment.NewLine &
                                           $"Actual Return Time: {actualReturnTime}" & Environment.NewLine &
                                           $"Total Fees: {totalFees:C2}"

            ' Show FinalReceipt form with the updated receipt details
            Dim receiptForm As New FinalReceipt(receiptDetails, True) ' Assuming this constructor exists
            receiptForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    ' Confirm return and update the database
    Private Sub btnConfirmReturn_Click(sender As Object, e As EventArgs) Handles btnConfirmReturn.Click
        If String.IsNullOrEmpty(txtCustomerName.Text) Or String.IsNullOrEmpty(txtBicycleID.Text) Then
            MessageBox.Show("Please search for a rental record before confirming the return.")
            Return
        End If

        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Using transaction As SQLiteTransaction = conn.BeginTransaction()
                Try
                    ' Update the rental record to mark it as completed
                    Dim cmd As New SQLiteCommand("UPDATE rentals SET is_completed = 1 WHERE customer_name = @customer_name AND bicycle_id = @bicycle_id", conn)
                    cmd.Parameters.AddWithValue("@customer_name", txtCustomerName.Text)
                    cmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)
                    cmd.ExecuteNonQuery()

                    ' Update the bicycle status to 'Available'
                    Dim updateCmd As New SQLiteCommand("UPDATE bicycles SET status = 'Available' WHERE bicycle_id = @bicycle_id", conn)
                    updateCmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)
                    updateCmd.ExecuteNonQuery()

                    transaction.Commit()
                    MessageBox.Show("Bicycle returned successfully!")
                    Me.Close() ' Close the return form
                Catch ex As Exception
                    transaction.Rollback()
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Method to calculate late fee based on return time
    Private Function CalculateLateFee(rentalEndTime As DateTime, actualReturnTime As DateTime) As Decimal
        If actualReturnTime > rentalEndTime Then
            Dim lateHours As Integer = CInt((actualReturnTime - rentalEndTime).TotalHours)
            Return lateHours * baseRatePerHour
        End If
        Return 0
    End Function

    Private Sub ReturnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Optionally load initial data if needed
    End Sub

    Private Sub dtpReturnTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnTime.ValueChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rentalForm As New Form4()
        rentalForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim maintenanceForm As New txtDescription()
        maintenanceForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim historyForm As New Form5()
        historyForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim bikeForm As New Form3()
        bikeForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        Me.Close()
        returnForm.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
        Me.Close()

    End Sub
End Class
