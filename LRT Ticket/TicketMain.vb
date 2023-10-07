Public Class TicketMain
    Dim DiscountNum() As Double = {0, 0.1, 0.15, 0.2, 0.5}
    Dim NumPerson As Integer = 1
    Dim FormLoad = False
    Private Sub TicketMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FromLoc.SelectedIndex = 0
        ToLoc.SelectedIndex = 0
        Discount.SelectedIndex = 0
        NumPerson = 1
        NumOfPerson.Text = 1
        Output.Text = "₱0.00"
        FormLoad = True
    End Sub
    Private Function CustomFormat(value As Double) As String
        If Math.Floor(value) = 0 Then
            ' Display as 0.XX when the whole number part is less than 1
            Return Format(value, "₱0.00")
        Else
            ' Display as XX.XX for other values
            Return Format(value, "₱#,##.00")
        End If
    End Function
    Private Function CalculateCost(numOfPerson As Double, fromLoc As Integer, toLoc As Integer, discount As Integer) As Double
        Return (numOfPerson * (Math.Abs((fromLoc * 20) - (toLoc * 20)))) - (DiscountNum(discount) * (numOfPerson * (Math.Abs((fromLoc * 20) - (toLoc * 20)))))
    End Function
    Public Sub CalculateAndDisplayCost()
        Dim number As Decimal
        If FormLoad = False Then
            Return
        End If

        If Not NumOfPerson.Text = Nothing AndAlso Not Decimal.TryParse(NumOfPerson.Text, number) OrElse number < 0 OrElse number <> Math.Floor(number) Then
            MessageBox.Show("Invalid input. Please only enter whole numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumOfPerson.Text = NumPerson
            NumOfPerson.SelectionStart = NumOfPerson.Text.Length
            Return
        End If

        If NumOfPerson.Text = Nothing Then
            NumPerson = 0
        Else
            NumPerson = NumOfPerson.Text
        End If

        Output.Text = CustomFormat(CalculateCost(NumPerson, FromLoc.SelectedIndex, ToLoc.SelectedIndex, Discount.SelectedIndex))
    End Sub
    Private Sub ChangedItems(sender As Object, e As EventArgs) Handles FromLoc.SelectedIndexChanged, ToLoc.SelectedIndexChanged, Discount.SelectedIndexChanged, NumOfPerson.TextChanged
        CalculateAndDisplayCost()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        FromLoc.SelectedIndex = 0
        ToLoc.SelectedIndex = 0
        Discount.SelectedIndex = 0
        NumPerson = 1
        NumOfPerson.Text = 1
        Output.Text = "₱0.00"
    End Sub
    Dim Ticket_Load_Form As LoadTicket
    Private Sub HomeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomeToolStripMenuItem.Click
        ' Goes to Loading
        If Ticket_Load_Form Is Nothing Then
            Ticket_Load_Form = New LoadTicket
        End If
        Ticket_Load_Form.Show()
        Me.Close()
    End Sub
    Dim Ticket_Out_Form As TicketOutput
    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        If ToLoc.SelectedItem.Equals(FromLoc.SelectedItem) Then
            MessageBox.Show("You have chosen the same origin and destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If NumOfPerson.Text = Nothing Then
            MessageBox.Show("Enter a valid number of people for the ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        DataModule.FromPlace = FromLoc.Text
        DataModule.ToPlace = ToLoc.Text
        DataModule.NumPerFinal = NumPerson
        DataModule.DiscountRate = Discount.Text
        DataModule.GrossFare = CustomFormat(NumPerson * (Math.Abs((FromLoc.SelectedIndex * 20) - (ToLoc.SelectedIndex * 20))))
        DataModule.DiscountedFare = CustomFormat(DiscountNum(Discount.SelectedIndex) * (NumOfPerson.Text * (Math.Abs((FromLoc.SelectedIndex * 20) - (ToLoc.SelectedIndex * 20)))))
        DataModule.NetFare = CustomFormat(CalculateCost(NumPerson, FromLoc.SelectedIndex, ToLoc.SelectedIndex, Discount.SelectedIndex))

        If Ticket_Out_Form Is Nothing Then
            Ticket_Out_Form = New TicketOutput
        End If
        Ticket_Out_Form.Show()
        Me.Close()
    End Sub
End Class
