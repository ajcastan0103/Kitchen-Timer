<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class singleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TimerTitle = New System.Windows.Forms.RadioButton()
        Me.Start = New System.Windows.Forms.Button()
        Me.Stop1 = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.a = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Minutes = New kitchenTimer.MinutesCounter()
        Me.Seconds = New kitchenTimer.SecondsCounter()
        Me.SuspendLayout()
        '
        'TimerTitle
        '
        Me.TimerTitle.AutoSize = True
        Me.TimerTitle.Location = New System.Drawing.Point(31, 56)
        Me.TimerTitle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TimerTitle.Name = "TimerTitle"
        Me.TimerTitle.Size = New System.Drawing.Size(113, 24)
        Me.TimerTitle.TabIndex = 1
        Me.TimerTitle.TabStop = True
        Me.TimerTitle.Text = "RadioButton"
        Me.TimerTitle.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(0, 249)
        Me.Start.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(152, 84)
        Me.Start.TabIndex = 2
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Stop1
        '
        Me.Stop1.Location = New System.Drawing.Point(148, 249)
        Me.Stop1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Stop1.Name = "Stop1"
        Me.Stop1.Size = New System.Drawing.Size(160, 84)
        Me.Stop1.TabIndex = 3
        Me.Stop1.Text = "Stop"
        Me.Stop1.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(305, 249)
        Me.Clear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(167, 84)
        Me.Clear.TabIndex = 4
        Me.Clear.Text = "Clear"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'a
        '
        Me.a.AutoSize = True
        Me.a.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.a.Location = New System.Drawing.Point(209, 155)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(29, 46)
        Me.a.TabIndex = 5
        Me.a.Text = ":"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Minutes
        '
        Me.Minutes.Location = New System.Drawing.Point(59, 154)
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(53, 63)
        Me.Minutes.TabIndex = 7
        Me.Minutes.Text = "00"
        Me.Minutes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Seconds
        '
        Me.Seconds.Location = New System.Drawing.Point(330, 154)
        Me.Seconds.Name = "Seconds"
        Me.Seconds.Size = New System.Drawing.Size(56, 63)
        Me.Seconds.TabIndex = 8
        Me.Seconds.Text = "00"
        Me.Seconds.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'singleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Seconds)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Stop1)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.TimerTitle)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "singleTimer"
        Me.Size = New System.Drawing.Size(472, 333)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TimerTitle As RadioButton
    Friend WithEvents Start As Button
    Friend WithEvents Stop1 As Button
    Friend WithEvents Clear As Button
    Friend WithEvents a As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Minutes As MinutesCounter
    Friend WithEvents Seconds As SecondsCounter
End Class
