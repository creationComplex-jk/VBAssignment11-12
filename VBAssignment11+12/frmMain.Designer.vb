<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnPassengers = New System.Windows.Forms.Button()
        Me.btnPilotFlights = New System.Windows.Forms.Button()
        Me.btnAttendantFlights = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnPassengers
        '
        Me.btnPassengers.Location = New System.Drawing.Point(78, 64)
        Me.btnPassengers.Name = "btnPassengers"
        Me.btnPassengers.Size = New System.Drawing.Size(213, 58)
        Me.btnPassengers.TabIndex = 0
        Me.btnPassengers.Text = "Show Passengers"
        Me.btnPassengers.UseVisualStyleBackColor = True
        '
        'btnPilotFlights
        '
        Me.btnPilotFlights.Location = New System.Drawing.Point(78, 175)
        Me.btnPilotFlights.Name = "btnPilotFlights"
        Me.btnPilotFlights.Size = New System.Drawing.Size(241, 58)
        Me.btnPilotFlights.TabIndex = 1
        Me.btnPilotFlights.Text = "Show Pilots && Flights"
        Me.btnPilotFlights.UseVisualStyleBackColor = True
        '
        'btnAttendantFlights
        '
        Me.btnAttendantFlights.Location = New System.Drawing.Point(78, 287)
        Me.btnAttendantFlights.Name = "btnAttendantFlights"
        Me.btnAttendantFlights.Size = New System.Drawing.Size(329, 58)
        Me.btnAttendantFlights.TabIndex = 2
        Me.btnAttendantFlights.Text = "Show Attendants && Flights"
        Me.btnAttendantFlights.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 445)
        Me.Controls.Add(Me.btnAttendantFlights)
        Me.Controls.Add(Me.btnPilotFlights)
        Me.Controls.Add(Me.btnPassengers)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 13.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPassengers As Button
    Friend WithEvents btnPilotFlights As Button
    Friend WithEvents btnAttendantFlights As Button
End Class
