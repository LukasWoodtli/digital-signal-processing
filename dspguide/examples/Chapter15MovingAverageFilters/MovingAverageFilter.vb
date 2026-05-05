
Public Module MovingAverageFilter
    Public Function MovingAverageFilterImpl(x() as Integer)
        
        'MOVING AVERAGE FILTER
        'This program filters 5000 samples with a 101 point moving
        'average filter, resulting in 4900 samples of filtered data.

        Dim y(4999) As Integer 'Y[ ] holds the output signal

        For i = 50 To 4949 'Loop for each point in the output signal
            y(i) = 0 'Zero, so it can be used as an accumulator
            For j = -50 To 50 'Calculate the summation
                y(i) = y(i) + x(i + j)
            Next j
            y(i) = y(i)/101 'Complete the average by dividing
        Next i
        
        Return y
    End Function
End Module
