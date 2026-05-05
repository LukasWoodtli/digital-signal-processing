Public Module TestSignals
    Public Function CreateInputSignal()
        Dim x(4999) As Integer 'X[ ] holds the input signal
        For i = 0 To 4999 'Fill the input signal with random data
            Dim val = CInt(Rnd())
            If i > 1000 And i < 4000 Then 
                val += 10
            End If
            x(i) = val
        Next i
        
        Return x
    End Function
End Module