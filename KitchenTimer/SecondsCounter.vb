Public Class SecondsCounter : Inherits Counter
    Dim mins As MinutesCounter

    Public Sub New()
        Me.max = 59
    End Sub

    Public Sub Decrement()
        If Me.value > 0 Then
            MyBase.setValue(Me.value - 1)
            Return
        End If
        If Not Me.mins.IsZero() Then
            SetValue(Me.max)
        End If
    End Sub

    Public Sub IncreaseBy(increment As Integer)
        If Me.value + increment <= Me.max Then
            MyBase.setValue(Me.value + increment)
            Return
        End If
        If Me.value >= Me.max Then
            MyBase.SetValue(Me.value - Me.max)
            Return
        End If
    End Sub

End Class