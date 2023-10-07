<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TicketOutput
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TicketOutput))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FromBox = New System.Windows.Forms.TextBox()
        Me.ToBox = New System.Windows.Forms.TextBox()
        Me.DiscBox = New System.Windows.Forms.TextBox()
        Me.PeopleBox = New System.Windows.Forms.TextBox()
        Me.NetBox = New System.Windows.Forms.TextBox()
        Me.DiscFareBox = New System.Windows.Forms.TextBox()
        Me.GrossBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NewFare = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Valid = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(499, 32)
        Me.MenuStrip1.TabIndex = 4
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 176)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LRT_Ticket.My.Resources.Resources.Left_Ticket
        Me.PictureBox1.Location = New System.Drawing.Point(0, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 235)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(308, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Net Fare:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(87, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "No. Of People:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(87, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Discount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(87, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Destination:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(87, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Origin:"
        '
        'FromBox
        '
        Me.FromBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromBox.Location = New System.Drawing.Point(91, 60)
        Me.FromBox.Name = "FromBox"
        Me.FromBox.ReadOnly = True
        Me.FromBox.Size = New System.Drawing.Size(196, 27)
        Me.FromBox.TabIndex = 20
        '
        'ToBox
        '
        Me.ToBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToBox.Location = New System.Drawing.Point(91, 121)
        Me.ToBox.Name = "ToBox"
        Me.ToBox.ReadOnly = True
        Me.ToBox.Size = New System.Drawing.Size(196, 27)
        Me.ToBox.TabIndex = 21
        '
        'DiscBox
        '
        Me.DiscBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscBox.Location = New System.Drawing.Point(91, 178)
        Me.DiscBox.Name = "DiscBox"
        Me.DiscBox.ReadOnly = True
        Me.DiscBox.Size = New System.Drawing.Size(196, 27)
        Me.DiscBox.TabIndex = 22
        '
        'PeopleBox
        '
        Me.PeopleBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeopleBox.Location = New System.Drawing.Point(91, 238)
        Me.PeopleBox.Name = "PeopleBox"
        Me.PeopleBox.ReadOnly = True
        Me.PeopleBox.Size = New System.Drawing.Size(196, 27)
        Me.PeopleBox.TabIndex = 23
        '
        'NetBox
        '
        Me.NetBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NetBox.Location = New System.Drawing.Point(312, 178)
        Me.NetBox.Name = "NetBox"
        Me.NetBox.ReadOnly = True
        Me.NetBox.Size = New System.Drawing.Size(166, 27)
        Me.NetBox.TabIndex = 26
        '
        'DiscFareBox
        '
        Me.DiscFareBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscFareBox.Location = New System.Drawing.Point(312, 121)
        Me.DiscFareBox.Name = "DiscFareBox"
        Me.DiscFareBox.ReadOnly = True
        Me.DiscFareBox.Size = New System.Drawing.Size(166, 27)
        Me.DiscFareBox.TabIndex = 25
        '
        'GrossBox
        '
        Me.GrossBox.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrossBox.Location = New System.Drawing.Point(312, 60)
        Me.GrossBox.Name = "GrossBox"
        Me.GrossBox.ReadOnly = True
        Me.GrossBox.Size = New System.Drawing.Size(166, 27)
        Me.GrossBox.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(308, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Discounted Fare:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(308, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Gross Fare:"
        '
        'NewFare
        '
        Me.NewFare.BackColor = System.Drawing.Color.CadetBlue
        Me.NewFare.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.NewFare.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue
        Me.NewFare.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.NewFare.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NewFare.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewFare.Location = New System.Drawing.Point(312, 238)
        Me.NewFare.Name = "NewFare"
        Me.NewFare.Size = New System.Drawing.Size(166, 27)
        Me.NewFare.TabIndex = 30
        Me.NewFare.Text = "New Fare"
        Me.NewFare.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(309, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "*Valid until: "
        '
        'Valid
        '
        Me.Valid.AutoSize = True
        Me.Valid.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Valid.ForeColor = System.Drawing.Color.White
        Me.Valid.Location = New System.Drawing.Point(309, 222)
        Me.Valid.Name = "Valid"
        Me.Valid.Size = New System.Drawing.Size(47, 13)
        Me.Valid.TabIndex = 32
        Me.Valid.Text = "00000"
        '
        'TicketOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(499, 282)
        Me.Controls.Add(Me.Valid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NewFare)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NetBox)
        Me.Controls.Add(Me.DiscFareBox)
        Me.Controls.Add(Me.GrossBox)
        Me.Controls.Add(Me.PeopleBox)
        Me.Controls.Add(Me.DiscBox)
        Me.Controls.Add(Me.ToBox)
        Me.Controls.Add(Me.FromBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TicketOutput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LRT Ticket"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FromBox As TextBox
    Friend WithEvents ToBox As TextBox
    Friend WithEvents DiscBox As TextBox
    Friend WithEvents PeopleBox As TextBox
    Friend WithEvents NetBox As TextBox
    Friend WithEvents DiscFareBox As TextBox
    Friend WithEvents GrossBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NewFare As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Valid As Label
End Class
