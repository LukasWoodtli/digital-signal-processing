Imports System.IO
Imports NUnit.Framework

Public Module Plotting
    Private Function CallerFileName(<System.Runtime.CompilerServices.CallerFilePath> Optional sourcefilePath As String = Nothing)
        Dim p = Path.GetDirectoryName(sourcefilePath)
        p = Path.Combine(p, "plots")
        Directory.CreateDirectory(p)
        Return p
    End Function

    Public Sub PlotSignals(x As Object, y As Object, name As String)
        Dim plt = New ScottPlot.Plot()
        plt.Add.Signal(x)
        plt.Add.Signal(y)

        Dim filePath = Path.Combine(CallerFileName(), name & ".png")
        TestContext.WriteLine("Plot saved to: " & filePath)
        plt.SavePng(filePath, 600, 400)
    End Sub
End Module