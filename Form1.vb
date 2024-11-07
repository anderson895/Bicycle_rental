Imports System.Data.SQLite

Public Class Form1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connString As String = "Data Source=bicycle_rental.db;Version=3;"
        Using con As New SQLiteConnection(connString)
            Dim cmd As New SQLiteCommand("SELECT * FROM staff WHERE username=@username AND password=@password", con)
            cmd.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd.Parameters.AddWithValue("@password", txtPassword.Text)

            con.Open()
            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Me.Hide()
                    Form2.Show() ' Main form
                Else
                    MessageBox.Show("Invalid username or password.")
                End If
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub
End Class
