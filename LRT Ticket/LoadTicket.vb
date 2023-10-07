Public Class LoadTicket
    Private Sub LoadTimer_Tick(sender As Object, e As EventArgs) Handles LoadTimer.Tick
        ' Fake Loading Screen
        If PB.Value <= PB.Maximum - 1 Then
            PB.Value += 5
        ElseIf PB.Value = PB.Maximum Then
            PB.Dispose()
            Enter.Visible = True
        End If
    End Sub

    Dim Ticket_Main_Form As TicketMain
    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        ' Goes to main menu 
        If Ticket_Main_Form Is Nothing Then
            Ticket_Main_Form = New TicketMain
        End If
        Ticket_Main_Form.Show()
        Me.Close()
    End Sub
End Class