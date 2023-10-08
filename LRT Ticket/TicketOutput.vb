Public Class TicketOutput
    'Programmer: Roque, Raniel Christian B
    'BSIT-2A
    'Date Finished: October 8 2023
    Dim Ticket_Load_Form As LoadTicket
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Goes to Loading
        If Ticket_Load_Form Is Nothing Then
            Ticket_Load_Form = New LoadTicket
        End If
        Ticket_Load_Form.Show()
        Me.Close()
    End Sub

    Dim Ticket_Main_Form As TicketMain
    Private Sub NewFare_Click(sender As Object, e As EventArgs) Handles NewFare.Click
        ' Goes to main menu 
        If Ticket_Main_Form Is Nothing Then
            Ticket_Main_Form = New TicketMain
        End If
        Ticket_Main_Form.Show()
        Me.Close()
    End Sub

    Private Sub TicketOutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Values
        FromBox.Text = DataModule.FromPlace
        ToBox.Text = DataModule.ToPlace
        DiscBox.Text = DataModule.DiscountRate
        PeopleBox.Text = DataModule.NumPerFinal
        GrossBox.Text = DataModule.GrossFare
        DiscFareBox.Text = DataModule.DiscountedFare
        NetBox.Text = DataModule.NetFare
        Valid.Text = DateTime.Now.AddDays(1).ToString("MMM/dd/yyyy - hh:mm tt")
    End Sub
End Class