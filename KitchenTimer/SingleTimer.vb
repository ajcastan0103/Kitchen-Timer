Public Class singleTimer
    Public TitleName As String
    Public Shared ActiveTimer As singleTimer
    Dim Active As Boolean = False
    Public SecondsCounter As New SecondsCounter
    Public MinutesCounter As New MinutesCounter
    Public Property Title As String
        Get
            Return TitleName
        End Get
        Set
            TitleName = Value
        End Set
    End Property

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub BuildTimer()
        Me.TimerTitle.Text = Title
        Me.TimerTitle.Checked = Active
        Me.Clear.Enabled = Active
        Me.Stop1.Enabled = Active
        Me.Start.Enabled = Active
    End Sub
    Public Sub SelectTimer()
        If Not Information.IsNothing(singleTimer.ActiveTimer) Then
            singleTimer.ActiveTimer.DeselectTimer()
        End If
        Active = True
        singleTimer.ActiveTimer = Me
        Me.BuildTimer()
        Me.BackColor = Color.Green
    End Sub

    Public Sub DeselectTimer()
        Active = False
        If singleTimer.ActiveTimer Is Me Then
            Me.BuildTimer()
            Me.BackColor = Color.White
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Not Seconds.IsZero() Then
            If Seconds.value <= Seconds.max Then
                Seconds.Decrement()
            End If
        ElseIf Seconds.IsZero() And Minutes.IsZero() Then
            Console.Beep(1000, 1000)
            Timer.Stop()
            Dim Message = Me.TitleName + " Timer is done."
            MsgBox(Message)
        Else
            Seconds.SetToMax()
            Minutes.Decrement()
        End If
    End Sub

    Private Sub CurrentTimer(sender As Object, e As EventArgs) Handles TimerTitle.Click, Me.Click
        If Me.TimerTitle.Checked Then
            SelectTimer()
        Else
            DeselectTimer()
        End If
    End Sub

    Public Shared Sub AddSeconds(seconds As Integer)
        singleTimer.ActiveTimer.Seconds.IncreaseBy(seconds)
    End Sub

    Public Shared Sub AddMinutes(minutes As Integer)
        singleTimer.ActiveTimer.Minutes.IncreaseBy(singleTimer.ActiveTimer.Minutes.value + minutes)
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If Seconds.IsZero() And Minutes.IsZero() Then
            Return
        Else
            Timer.Start()
        End If
    End Sub

    Private Sub Stop_Click(sender As Object, e As EventArgs) Handles Stop1.Click
        Timer.Stop()
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Timer.Stop()
        Me.Seconds.Clear()
        Me.Minutes.Clear()
    End Sub

End Class
