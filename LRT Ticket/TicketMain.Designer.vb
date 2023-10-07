<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TicketMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FromLoc = New System.Windows.Forms.ComboBox()
        Me.ToLoc = New System.Windows.Forms.ComboBox()
        Me.NumOfPerson = New System.Windows.Forms.TextBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Discount = New System.Windows.Forms.ComboBox()
        Me.Output = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Buy = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6)
        Me.MenuStrip1.Size = New System.Drawing.Size(558, 32)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HomeToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.HomeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HomeToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeToolStripMenuItem.Image = CType(resources.GetObject("HomeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        '
        'FromLoc
        '
        Me.FromLoc.DropDownHeight = 130
        Me.FromLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FromLoc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromLoc.FormattingEnabled = True
        Me.FromLoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FromLoc.IntegralHeight = False
        Me.FromLoc.Items.AddRange(New Object() {"Baclaran", "United Nations", "Rizal Park", "Quiapo", "Luneta", "Roxas Boulevard", "Taft Avenue", "Ayala Triangle", "Legarda", "Magallanes", "Makati Central Business District", "Ayala Alabang", "Alabang", "Zapote", "San Miguel", "Dr. A. Santos", "Central Terminal", "Monumento", "EDSA", "Roosevelt"})
        Me.FromLoc.Location = New System.Drawing.Point(17, 82)
        Me.FromLoc.MaxDropDownItems = 5
        Me.FromLoc.Name = "FromLoc"
        Me.FromLoc.Size = New System.Drawing.Size(246, 26)
        Me.FromLoc.TabIndex = 1
        '
        'ToLoc
        '
        Me.ToLoc.DropDownHeight = 130
        Me.ToLoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ToLoc.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToLoc.FormattingEnabled = True
        Me.ToLoc.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToLoc.IntegralHeight = False
        Me.ToLoc.Items.AddRange(New Object() {"Baclaran", "United Nations", "Rizal Park", "Quiapo", "Luneta", "Roxas Boulevard", "Taft Avenue", "Ayala Triangle", "Legarda", "Magallanes", "Makati Central Business District", "Ayala Alabang", "Alabang", "Zapote", "San Miguel", "Dr. A. Santos", "Central Terminal", "Monumento", "EDSA", "Roosevelt"})
        Me.ToLoc.Location = New System.Drawing.Point(17, 154)
        Me.ToLoc.MaxDropDownItems = 5
        Me.ToLoc.Name = "ToLoc"
        Me.ToLoc.Size = New System.Drawing.Size(246, 26)
        Me.ToLoc.TabIndex = 2
        '
        'NumOfPerson
        '
        Me.NumOfPerson.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOfPerson.Location = New System.Drawing.Point(295, 154)
        Me.NumOfPerson.Name = "NumOfPerson"
        Me.NumOfPerson.Size = New System.Drawing.Size(246, 27)
        Me.NumOfPerson.TabIndex = 4
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(17, 226)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(110, 27)
        Me.Clear.TabIndex = 6
        Me.Clear.Text = "Reset"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Discount
        '
        Me.Discount.DropDownHeight = 130
        Me.Discount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Discount.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Discount.FormattingEnabled = True
        Me.Discount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Discount.IntegralHeight = False
        Me.Discount.Items.AddRange(New Object() {"No Discount", "Government Employee(10%)", "Student(15%)", "Senior Citizen(20%)", "Children(50%)"})
        Me.Discount.Location = New System.Drawing.Point(295, 82)
        Me.Discount.MaxDropDownItems = 5
        Me.Discount.Name = "Discount"
        Me.Discount.Size = New System.Drawing.Size(246, 26)
        Me.Discount.TabIndex = 3
        '
        'Output
        '
        Me.Output.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.Location = New System.Drawing.Point(295, 226)
        Me.Output.Name = "Output"
        Me.Output.ReadOnly = True
        Me.Output.Size = New System.Drawing.Size(246, 27)
        Me.Output.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "From: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "To: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(290, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 25)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Discount:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(290, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "No. Of People:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(290, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Net Fare:"
        '
        'Buy
        '
        Me.Buy.BackColor = System.Drawing.Color.PaleGreen
        Me.Buy.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Buy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
        Me.Buy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buy.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buy.Location = New System.Drawing.Point(153, 226)
        Me.Buy.Name = "Buy"
        Me.Buy.Size = New System.Drawing.Size(110, 27)
        Me.Buy.TabIndex = 15
        Me.Buy.Text = "Buy"
        Me.Buy.UseVisualStyleBackColor = False
        '
        'TicketMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(558, 279)
        Me.Controls.Add(Me.Buy)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.Discount)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.NumOfPerson)
        Me.Controls.Add(Me.ToLoc)
        Me.Controls.Add(Me.FromLoc)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TicketMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LRT Ticket"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumOfPerson As TextBox
    Friend WithEvents Clear As Button
    Friend WithEvents Output As TextBox
    Friend WithEvents FromLoc As ComboBox
    Friend WithEvents ToLoc As ComboBox
    Friend WithEvents Discount As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Buy As Button
End Class
