Imports System.Data.SQLite

Public Class frmPilotFlights
    Private Sub frmPilotFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "
                SELECT TPilots.strLastName
                FROM TPilots
                "
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strLastName As String = reader.GetString(0)
                        cboPilots.Items.Add(strLastName)
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub cboPilots_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPilots.SelectedIndexChanged
        lstFlights.Items.Clear()
        lstFlights.Items.Add("Flight Number, Flight Date, Departure Time, Arrival Time")
        Dim connectionString As String = "Data Source=flyme2themoon.db;Version=3;"
        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Dim strQuery As String =
                "
                SELECT TFlights.strFlightNumber, TFlights.dtmFlightDate, TFlights.dtmTimeOfDeparture, TFlights.dtmTimeOfLanding
                FROM TPilots JOIN TPilotFlights JOIN TFlights
                ON TPilots.intPilotID = TPilotFlights.intPilotID AND TPilotFlights.intFlightID = TFlights.intFlightID
                WHERE strLastName = '" & cboPilots.SelectedItem & "'"
            Using command As New SQLiteCommand(strQuery, conn)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim strFlightNumber As String = reader.GetString(0)
                        Dim dtmFlightDate As String = reader.GetString(1)
                        Dim dtmTimeOfDeparture As String = reader.GetString(2)
                        Dim dtmTimeOfLanding As String = reader.GetString(3)
                        lstFlights.Items.Add(strFlightNumber & ", " & dtmFlightDate & ", " & dtmTimeOfDeparture & ", " & dtmTimeOfLanding)
                    End While
                End Using
            End Using
        End Using
    End Sub
End Class