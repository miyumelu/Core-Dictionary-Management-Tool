Imports neXt_Motion_Engine

Public Class Motions
    Public Async Function Peak() As Task
        Dim player As New XME
        Await player.MotionPeak(60, 60, 60, 60, 800)
    End Function
End Class
