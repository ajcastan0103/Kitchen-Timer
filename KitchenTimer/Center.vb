Public Class Center
    Public Sub New()
        InitializeComponent()
        SingleTimer1.BuildTimer()
        SingleTimer1.SelectTimer()
        SingleTimer2.BuildTimer()
        SingleTimer3.BuildTimer()
        SingleTimer4.BuildTimer()
    End Sub

    Private Sub addSeconds(sender As Object, e As EventArgs) Handles OneSec.Click, ThreeSecs.Click, TenSecs.Click
        singleTimer.AddSeconds(sender.tag)
    End Sub

    Private Sub addMinutes(sender As Object, e As EventArgs) Handles OneMin.Click, ThreeMins.Click, TenMins.Click
        singleTimer.AddMinutes(sender.tag)
    End Sub

End Class
