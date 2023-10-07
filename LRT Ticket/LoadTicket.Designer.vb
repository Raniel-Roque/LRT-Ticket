<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoadTicket
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoadTicket))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.Enter = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LRT_Ticket.My.Resources.Resources.Ticket
        Me.PictureBox1.Location = New System.Drawing.Point(12, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(446, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(64, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 77)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LRT Ticket"
        '
        'LoadTimer
        '
        Me.LoadTimer.Enabled = True
        '
        'PB
        '
        Me.PB.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.PB.Location = New System.Drawing.Point(28, 128)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(412, 31)
        Me.PB.TabIndex = 2
        Me.PB.UseWaitCursor = True
        '
        'Enter
        '
        Me.Enter.BackColor = System.Drawing.Color.PaleGreen
        Me.Enter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Enter.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Enter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen
        Me.Enter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Enter.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enter.Location = New System.Drawing.Point(28, 128)
        Me.Enter.Name = "Enter"
        Me.Enter.Size = New System.Drawing.Size(412, 31)
        Me.Enter.TabIndex = 16
        Me.Enter.Text = "Enter"
        Me.Enter.UseVisualStyleBackColor = False
        Me.Enter.Visible = False
        '
        'LoadTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(470, 179)
        Me.Controls.Add(Me.Enter)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoadTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LRT Ticket"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoadTimer As Timer
    Friend WithEvents PB As ProgressBar
    Friend WithEvents Enter As Button
End Class
