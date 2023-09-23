Public Class MinutesCounter : Inherits Counter
    Dim secs As SecondsCounter

    Public Sub New()
        Me.max = 99
    End Sub
    Public Sub Decrement()
        If Not Me.value = 0 Then
            MyBase.SetValue(Me.value - 1)
        End If
    End Sub

    Public Sub IncreaseBy(increment As Integer)
        If Not isMax() Then
            MyBase.SetValue(Me.value + increment)
        End If
        Me.SetValue(increment)
    End Sub

End Class