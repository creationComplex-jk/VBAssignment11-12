Imports System.Data.SQLite

Public Class frmAttendantFlights
    Private Sub frmAttendantFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "
                SELECT TAttendants.strLastName
                FROM TAttendants
                "
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLastName As String = reader.GetString(0)
                        cboAttendants.Items.Add(strLastName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboAttendants_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAttendants.SelectedIndexChanged
        lstFlights.Items.Clear()
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "
                
                "
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()


                    End While
                End Using
            End Using
        End Using
    End Sub
End Class