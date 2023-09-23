<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
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
        Me.SingleTimer1 = New kitchenTimer.singleTimer()
        Me.SingleTimer2 = New kitchenTimer.singleTimer()
        Me.OneSec = New System.Windows.Forms.Button()
        Me.ThreeSecs = New System.Windows.Forms.Button()
        Me.TenSecs = New System.Windows.Forms.Button()
        Me.OneMin = New System.Windows.Forms.Button()
        Me.TenMins = New System.Windows.Forms.Button()
        Me.ThreeMins = New System.Windows.Forms.Button()
        Me.SingleTimer3 = New kitchenTimer.singleTimer()
        Me.SingleTimer4 = New kitchenTimer.singleTimer()
        Me.SuspendLayout()
        '
        'SingleTimer1
        '
        Me.SingleTimer1.BackColor = System.Drawing.Color.AliceBlue
        Me.SingleTimer1.Location = New System.Drawing.Point(-2, 2)
        Me.SingleTimer1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(529, 390)
        Me.SingleTimer1.TabIndex = 0
        Me.SingleTimer1.Title = "Top Left"
        '
        'SingleTimer2
        '
        Me.SingleTimer2.BackColor = System.Drawing.Color.AliceBlue
        Me.SingleTimer2.Location = New System.Drawing.Point(480, 2)
        Me.SingleTimer2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(671, 390)
        Me.SingleTimer2.TabIndex = 1
        Me.SingleTimer2.Title = "Top Right"
        '
        'OneSec
        '
        Me.OneSec.Location = New System.Drawing.Point(-2, 686)
        Me.OneSec.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OneSec.Name = "OneSec"
        Me.OneSec.Size = New System.Drawing.Size(308, 128)
        Me.OneSec.TabIndex = 2
        Me.OneSec.Tag = "1"
        Me.OneSec.Text = "1 Second"
        Me.OneSec.UseVisualStyleBackColor = True
        '
        'ThreeSecs
        '
        Me.ThreeSecs.Location = New System.Drawing.Point(301, 686)
        Me.ThreeSecs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ThreeSecs.Name = "ThreeSecs"
        Me.ThreeSecs.Size = New System.Drawing.Size(377, 128)
        Me.ThreeSecs.TabIndex = 3
        Me.ThreeSecs.Tag = "3"
        Me.ThreeSecs.Text = "3 Seconds"
        Me.ThreeSecs.UseVisualStyleBackColor = True
        '
        'TenSecs
        '
        Me.TenSecs.Location = New System.Drawing.Point(672, 686)
        Me.TenSecs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TenSecs.Name = "TenSecs"
        Me.TenSecs.Size = New System.Drawing.Size(280, 128)
        Me.TenSecs.TabIndex = 4
        Me.TenSecs.Tag = "10"
        Me.TenSecs.Text = "10 Seconds"
        Me.TenSecs.UseVisualStyleBackColor = True
        '
        'OneMin
        '
        Me.OneMin.Location = New System.Drawing.Point(-2, 812)
        Me.OneMin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OneMin.Name = "OneMin"
        Me.OneMin.Size = New System.Drawing.Size(308, 126)
        Me.OneMin.TabIndex = 5
        Me.OneMin.Tag = "1"
        Me.OneMin.Text = "1 Minute"
        Me.OneMin.UseVisualStyleBackColor = True
        '
        'TenMins
        '
        Me.TenMins.Location = New System.Drawing.Point(672, 812)
        Me.TenMins.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TenMins.Name = "TenMins"
        Me.TenMins.Size = New System.Drawing.Size(280, 126)
        Me.TenMins.TabIndex = 7
        Me.TenMins.Tag = "10"
        Me.TenMins.Text = "10 Minutes"
        Me.TenMins.UseVisualStyleBackColor = True
        '
        'ThreeMins
        '
        Me.ThreeMins.Location = New System.Drawing.Point(301, 812)
        Me.ThreeMins.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ThreeMins.Name = "ThreeMins"
        Me.ThreeMins.Size = New System.Drawing.Size(377, 126)
        Me.ThreeMins.TabIndex = 8
        Me.ThreeMins.Tag = "3"
        Me.ThreeMins.Text = "3 Minutes"
        Me.ThreeMins.UseVisualStyleBackColor = True
        '
        'SingleTimer3
        '
        Me.SingleTimer3.BackColor = System.Drawing.Color.AliceBlue
        Me.SingleTimer3.Location = New System.Drawing.Point(-2, 349)
        Me.SingleTimer3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(486, 338)
        Me.SingleTimer3.TabIndex = 9
        Me.SingleTimer3.Title = "Bottom Left"
        '
        'SingleTimer4
        '
        Me.SingleTimer4.BackColor = System.Drawing.Color.AliceBlue
        Me.SingleTimer4.Location = New System.Drawing.Point(480, 349)
        Me.SingleTimer4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(494, 338)
        Me.SingleTimer4.TabIndex = 10
        Me.SingleTimer4.Title = "Bottom Right"
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 938)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.ThreeMins)
        Me.Controls.Add(Me.TenMins)
        Me.Controls.Add(Me.OneMin)
        Me.Controls.Add(Me.TenSecs)
        Me.Controls.Add(Me.ThreeSecs)
        Me.Controls.Add(Me.OneSec)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Center"
        Me.Text = "Alexander Castaneda"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents OneSec As Button
    Friend WithEvents ThreeSecs As Button
    Friend WithEvents TenSecs As Button
    Friend WithEvents OneMin As Button
    Friend WithEvents TenMins As Button
    Friend WithEvents ThreeMins As Button
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer

End Class
