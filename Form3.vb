Imports System.Data.SQLite
Imports System.IO

Public Class Form3
    ' Declare an event to notify when a new bicycle is added
    Public Event BicycleAdded(ByVal bicycleID As Integer)

    Private connString As String =  "Data Source=bicycle_rental.db;Version=3;"
    Private imagePath As String ' To store the image path
    Private Const ImageFolderPath As String = "Image\" ' Image folder path

    ' Load bicycles into DataGridView
    Private Sub LoadBicycles()
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("SELECT * FROM bicycles", conn)
            Dim adapter As New SQLiteDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Clear existing columns
            dgvBicycles.Columns.Clear()

            ' Add DataGridViewImageColumn for displaying pictures
            Dim imageColumn As New DataGridViewImageColumn()
            imageColumn.Name = "picture"
            imageColumn.HeaderText = "Picture"
            imageColumn.Width = 100
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch
            dgvBicycles.Columns.Add(imageColumn)

            ' Add other columns dynamically
            dgvBicycles.Columns.Add("bicycle_id", "Bicycle ID")
            dgvBicycles.Columns.Add("type", "Type")
            dgvBicycles.Columns.Add("status", "Status")

            ' Fill the DataGridView with data
            For Each row As DataRow In table.Rows
                Dim fileName As String = row("picture").ToString() ' Get the file name from the database
                Dim fullPath As String = Path.Combine(ImageFolderPath, fileName) ' Construct full path

                If File.Exists(fullPath) Then ' Check if the file exists
                    Dim img As Image = Image.FromFile(fullPath) ' Load the image
                    ' Add a new row with the picture and other details
                    dgvBicycles.Rows.Add(img, row("bicycle_id"), row("type"), row("status"))
                Else
                    ' Handle missing file (optional)
                    dgvBicycles.Rows.Add(Nothing, row("bicycle_id"), row("type"), row("status")) ' Add a placeholder for missing image
                End If
            Next

            ' Allow editing of DataGridView cells
            dgvBicycles.ReadOnly = False
        End Using
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBicycles()
        cmbStatus.Items.Add("Available")
        cmbStatus.Items.Add("Not Available")
    End Sub

    Private Sub btnAddBike_Click(sender As Object, e As EventArgs) Handles btnAddBike.Click
        If String.IsNullOrEmpty(txtType.Text) OrElse String.IsNullOrEmpty(imagePath) OrElse cmbStatus.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields and upload a picture.")
            Return
        End If

        ' Extract just the file name from the imagePath
        Dim fileName As String = Path.GetFileName(imagePath)

        ' Copy the file to the Image folder (if needed)
        File.Copy(imagePath, Path.Combine(ImageFolderPath, fileName), True)

        Dim newBicycleId As Integer
        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("INSERT INTO bicycles (type, picture, status) VALUES (@type, @picture, @status); SELECT last_insert_rowid();", conn)
            cmd.Parameters.AddWithValue("@type", txtType.Text)
            cmd.Parameters.AddWithValue("@picture", fileName) ' Save the file name only
            cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString())
            newBicycleId = Convert.ToInt32(cmd.ExecuteScalar()) ' Retrieve the ID of the newly added bicycle
            MessageBox.Show("Bicycle added successfully!")
            LoadBicycles()
        End Using

        ' Raise the event after the bicycle is added
        RaiseEvent BicycleAdded(newBicycleId)
    End Sub

    Private Sub btnUploadPicture_Click(sender As Object, e As EventArgs) Handles btnUploadPicture.Click
        Using openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                imagePath = openFileDialog.FileName
                pbBikePicture.Image = Image.FromFile(imagePath) ' Display the image in the PictureBox
                pbBikePicture.SizeMode = PictureBoxSizeMode.StretchImage ' Adjust the image display
            End If
        End Using
    End Sub

    ' Delete selected bicycle
    Private Sub btnDeleteBike_Click(sender As Object, e As EventArgs) Handles btnDeleteBike.Click
        If dgvBicycles.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to delete.")
            Return
        End If

        Dim bicycleID As Integer = Convert.ToInt32(dgvBicycles.SelectedRows(0).Cells("bicycle_id").Value)

        Using conn As New SQLiteConnection(connString)
            conn.Open()
            Dim cmd As New SQLiteCommand("DELETE FROM bicycles WHERE bicycle_id = @bicycle_id", conn)
            cmd.Parameters.AddWithValue("@bicycle_id", bicycleID)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Bicycle deleted successfully!")
        LoadBicycles()
    End Sub

    ' Save edited changes
    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click
        For Each row As DataGridViewRow In dgvBicycles.Rows
            If row.IsNewRow Then Continue For

            Dim bicycleID As Integer = Convert.ToInt32(row.Cells("bicycle_id").Value)
            Dim type As String = row.Cells("type").Value.ToString()
            Dim status As String = row.Cells("status").Value.ToString()

            Using conn As New SQLiteConnection(connString)
                conn.Open()
                Dim cmd As New SQLiteCommand("UPDATE bicycles SET type = @type, status = @status WHERE bicycle_id = @bicycle_id", conn)
                cmd.Parameters.AddWithValue("@type", type)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@bicycle_id", bicycleID)
                cmd.ExecuteNonQuery()
            End Using
        Next

        MessageBox.Show("Changes saved successfully!")
        LoadBicycles()
    End Sub

    Private Sub btnOpenForm2_Click(sender As Object, e As EventArgs) Handles btnOpenForm2.Click
        Dim form2 As New Form2()
        Me.Hide()
        form2.Show()
    End Sub

    Private Sub dgvBicycles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBicycles.CellContentClick

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblType_Click(sender As Object, e As EventArgs) Handles lblType.Click

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Dim returnForm As New ReturnForm()
        returnForm.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Form1.txtUsername.Clear()
        Form1.txtPassword.Clear()
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnHandleRentals_Click(sender As Object, e As EventArgs) Handles btnHandleRentals.Click
        Dim rentalForm As New Form4()
        rentalForm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

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
End Class
