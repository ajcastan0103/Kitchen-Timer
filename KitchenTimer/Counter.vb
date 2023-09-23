Public Class Counter
    Inherits Label

    Public max As Integer
    Public value As Integer

    Public Sub New()
        InitializeComponent()
        Me.value = 0
    End Sub
    Public Sub SetValue(value As Integer)
        If value > Me.max Then
            Me.value = Me.max
        Else
            Me.value = value
        End If
        Me.Text = Me.value.ToString("00")
    End Sub

    Public Sub SetToMax()
        Me.value = Me.max
        Me.Text = Me.value.ToString("00")
    End Sub

    Public Function IsZero() As Boolean
        Return Me.value = 0
    End Function

    Public Function IsMax() As Boolean
        Return Me.value = Me.max
    End Function

    Public Sub Clear()
        Me.value = 0
        Me.Text = "00"
    End Sub

End Class


