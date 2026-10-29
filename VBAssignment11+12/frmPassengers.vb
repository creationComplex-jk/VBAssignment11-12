Imports System.Data.SQLite

Public Class frmPassengers
    Private Sub frmPassengers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPassengers.Items.Clear()
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "SELECT TPassengers.strFirstName, TPassengers.strLastName
                 FROM TPassengers"
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFirstName As String = reader.GetString(0)
                        Dim strLastName As String = reader.GetString(1)
                        lstPassengers.Items.Add(strFirstName & " " & strLastName)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class