Imports NUnit.Framework

Public Class Tests
    <Test>
    Public Sub MovingAverageFilter()
        Dim x = CreateInputSignal()
        Dim y = MovingAverageFilterImpl(x)
        Assert.That(y.Length,[Is].EqualTo(5000))
        PlotSignals(x, y, "moving_average_filter")
    End Sub
End Class
