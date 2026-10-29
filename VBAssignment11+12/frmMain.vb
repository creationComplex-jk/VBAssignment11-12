Public Class frmMain
    Private Sub btnPassengers_Click(sender As Object, e As EventArgs) Handles btnPassengers.Click
        frmPassengers.Show()
    End Sub

    Private Sub btnPilotFlights_Click(sender As Object, e As EventArgs) Handles btnPilotFlights.Click
        frmPilotFlights.Show()
    End Sub

    Private Sub btnAttendantFlights_Click(sender As Object, e As EventArgs) Handles btnAttendantFlights.Click
        frmAttendantFlights.Show()
    End Sub
End Class
