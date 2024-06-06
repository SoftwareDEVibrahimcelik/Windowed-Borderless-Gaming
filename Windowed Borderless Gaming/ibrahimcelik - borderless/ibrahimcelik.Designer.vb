<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ibrahimcelik
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ibrahimcelik))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.softwaredevic = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.windowed = New System.Windows.Forms.Button()
        Me.tamekran = New System.Windows.Forms.Button()
        Me.refresh = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bildirim = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.Black
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 44
        Me.ListBox1.Location = New System.Drawing.Point(36, 60)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1808, 264)
        Me.ListBox1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox1.Size = New System.Drawing.Size(1856, 415)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Game Selection"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(1583, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IBRAHIM CELIK"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabel1)
        Me.GroupBox2.Controls.Add(Me.softwaredevic)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(24, 450)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(1856, 129)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Process Title"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(1614, 58)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(146, 37)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Donation"
        '
        'softwaredevic
        '
        Me.softwaredevic.AutoSize = True
        Me.softwaredevic.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.softwaredevic.Location = New System.Drawing.Point(148, 58)
        Me.softwaredevic.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.softwaredevic.Name = "softwaredevic"
        Me.softwaredevic.Size = New System.Drawing.Size(77, 25)
        Me.softwaredevic.TabIndex = 0
        Me.softwaredevic.Text = "Label1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.windowed)
        Me.GroupBox3.Controls.Add(Me.tamekran)
        Me.GroupBox3.Controls.Add(Me.refresh)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Red
        Me.GroupBox3.Location = New System.Drawing.Point(24, 590)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(1856, 212)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Windowed Borderless Gaming"
        '
        'windowed
        '
        Me.windowed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.windowed.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.windowed.Location = New System.Drawing.Point(1349, 46)
        Me.windowed.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.windowed.Name = "windowed"
        Me.windowed.Size = New System.Drawing.Size(411, 122)
        Me.windowed.TabIndex = 2
        Me.windowed.Text = "Windowed"
        Me.windowed.UseVisualStyleBackColor = True
        '
        'tamekran
        '
        Me.tamekran.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tamekran.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.tamekran.Location = New System.Drawing.Point(685, 46)
        Me.tamekran.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.tamekran.Name = "tamekran"
        Me.tamekran.Size = New System.Drawing.Size(480, 122)
        Me.tamekran.TabIndex = 1
        Me.tamekran.Text = "Full Screen"
        Me.tamekran.UseVisualStyleBackColor = True
        '
        'refresh
        '
        Me.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refresh.Font = New System.Drawing.Font("Segoe Print", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.refresh.Location = New System.Drawing.Point(96, 46)
        Me.refresh.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.refresh.Name = "refresh"
        Me.refresh.Size = New System.Drawing.Size(411, 122)
        Me.refresh.TabIndex = 0
        Me.refresh.Text = "Refresh"
        Me.refresh.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1464, 2106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(675, 1051)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 51)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IBRAHIM CELIK"
        '
        'Bildirim
        '
        Me.Bildirim.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Bildirim.Icon = CType(resources.GetObject("Bildirim.Icon"), System.Drawing.Icon)
        Me.Bildirim.Text = "NotifyIcon1"
        Me.Bildirim.Visible = True
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkColor = System.Drawing.Color.CornflowerBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(1840, 825)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(73, 25)
        Me.LinkLabel2.TabIndex = 6
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Steam"
        '
        'ibrahimcelik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1925, 859)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "ibrahimcelik"
        Me.Text = "Windowed Borderless Gaming"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents windowed As System.Windows.Forms.Button
    Friend WithEvents tamekran As System.Windows.Forms.Button
    Friend WithEvents refresh As System.Windows.Forms.Button
    Friend WithEvents softwaredevic As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Bildirim As NotifyIcon
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
