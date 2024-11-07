Imports System.Data.SQLite

Public Class txtDescription
    ' Connection string for SQLite database
    Dim connString As String = "Data Source=" & System.IO.Path.Combine(Application.StartupPath, "bicycle_rental.db") & ";Version=3;"

    ' Method to load data into the DataGrid
    Private Sub LoadDataGrid(Optional searchText As String = "")
        Dim query As String
        If String.IsNullOrEmpty(searchText) Then
            ' If no search term is provided, load all records
            query = "SELECT * FROM maintenance"
        Else
            ' If search term is provided, filter the data by bicycle_id
            query = "SELECT * FROM maintenance WHERE bicycle_id LIKE @searchText"
        End If

        ' Using block for the connection and command
        Using con As New SQLiteConnection(connString)
            Using cmd As New SQLiteCommand(query, con)
                ' If searching, add the parameter for the search text
                If Not String.IsNullOrEmpty(searchText) Then
                    cmd.Parameters.AddWithValue("@searchText", "%" & searchText & "%")
                End If

                ' Data adapter to fill the DataGrid
                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    ' Bind the result to the DataGridView (table_record)
                    table_record.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    ' Event handler for the Search button or TextChanged event of txtSearchID
    Private Sub txtSearchID_TextChanged(sender As Object, e As EventArgs) Handles txtSearchID.TextChanged
        ' Call LoadDataGrid method to filter based on the search text
        LoadDataGrid(txtSearchID.Text)
    End Sub

    ' Event handler for the Save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate required fields before saving
        If String.IsNullOrEmpty(txtBicycleID.Text) OrElse comboStatus.SelectedItem Is Nothing OrElse String.IsNullOrEmpty(txtDescript.Text) OrElse String.IsNullOrEmpty(txtTechName.Text) Then
            MessageBox.Show("Please fill in all required fields.")
            Return
        End If

        ' Insert query to add a new maintenance record
        Dim query As String = "INSERT INTO maintenance (bicycle_id, maintenance_date, expected_completion_date, status, description, technician_name) " &
                              "VALUES (@bicycle_id, @maintenance_date, @expected_completion_date, @status, @description, @technician_name)"

        ' Using block for the connection and command
        Using con As New SQLiteConnection(connString)
            Using cmd As New SQLiteCommand(query, con)
                ' Assign parameter values from the form controls
                cmd.Parameters.AddWithValue("@bicycle_id", txtBicycleID.Text)
                cmd.Parameters.AddWithValue("@maintenance_date", maintinanceDate.Value)
                cmd.Parameters.AddWithValue("@expected_completion_date", completionDatepicker.Value)
                cmd.Parameters.AddWithValue("@status", comboStatus.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@description", txtDescript.Text)
                cmd.Parameters.AddWithValue("@technician_name", txtTechName.Text)

                Try
                    ' Open connection, execute the command, and show success message
                    con.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Maintenance record saved successfully.")

                    ' Reload the DataGrid after saving
                    LoadDataGrid(txtSearchID.Text) ' Pass the current search text to reload the filtered data

                Catch ex As Exception
                    ' Display more detailed error information
                    MessageBox.Show("Error saving record: " & ex.Message & vbCrLf & "Details: " & ex.StackTrace)
                End Try
            End Using
        End Using
    End Sub

    ' Form load event to initially load data in the DataGrid
    Private Sub txtDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initially load all records into the DataGrid
        LoadDataGrid()
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form2 As New Form2()
        Me.Hide()
        form2.Show()
    End Sub
End Class
