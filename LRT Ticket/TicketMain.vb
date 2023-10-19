Public Class TicketMain
    'Programmer: Roque, Raniel Christian B
    'BSIT-2A
    'Date Finished: October 8 2023
    'Values for Discount Equivalent using array indexing + NumPerson for saving Number of person when invalid input
    'Form Load for Initial Load so Error Detection does not start
    Dim DiscountNum() As Double = {0, 0.1, 0.15, 0.2, 0.5}
    Dim NumPerson As Integer = 1
    Dim FormLoad = False
    Private Sub TicketMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial Values
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
    'Main Function for Net Fare
    Private Function CalculateCost(numOfPerson As Double, fromLoc As Integer, toLoc As Integer, discount As Integer) As Double
        Return Math.Abs((fromLoc - toLoc) * 20 * numOfPerson) - (DiscountNum(discount) * Math.Abs((fromLoc - toLoc) * 20 * numOfPerson))
    End Function
    'Error Detection + Automatic Calculation Function
    Public Sub CalculateAndDisplayCost()
        Dim number As Decimal
        If FormLoad = False Then
            Return
        End If

        'Invalidates Decimal, < 0, and Letters
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
    'Clear
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
    'Buy Ticket
    Private Sub Buy_Click(sender As Object, e As EventArgs) Handles Buy.Click
        'Checks if From and To are the same
        If ToLoc.SelectedItem.Equals(FromLoc.SelectedItem) Then
            MessageBox.Show("You have chosen the same origin and destination", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Checks if Num Person has no input
        If NumOfPerson.Text = Nothing Then
            MessageBox.Show("Enter a valid number of people for the ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Saves the Data in DataModule
        DataModule.FromPlace = FromLoc.Text
        DataModule.ToPlace = ToLoc.Text
        DataModule.NumPerFinal = NumPerson
        DataModule.DiscountRate = Discount.Text
        DataModule.GrossFare = CustomFormat(NumPerson * (Math.Abs((FromLoc.SelectedIndex * 20) - (ToLoc.SelectedIndex * 20))))
        DataModule.DiscountedFare = CustomFormat(DiscountNum(Discount.SelectedIndex) * (NumOfPerson.Text * (Math.Abs((FromLoc.SelectedIndex * 20) - (ToLoc.SelectedIndex * 20)))))
        DataModule.NetFare = CustomFormat(CalculateCost(NumPerson, FromLoc.SelectedIndex, ToLoc.SelectedIndex, Discount.SelectedIndex))

        'Loads next form
        If Ticket_Out_Form Is Nothing Then
            Ticket_Out_Form = New TicketOutput
        End If
        Ticket_Out_Form.Show()
        Me.Close()
    End Sub
End Class
