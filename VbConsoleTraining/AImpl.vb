Public Class AImpl : Implements IA

    Public Function Aa() As Integer Implements IA.Aa
        Throw New NotImplementedException()
    End Function

    Public Function Ab() As Integer Implements IA.Ab
        Throw New NotImplementedException()
    End Function

    Public Sub SayHello()
        Console.WriteLine("Hello, I'm AImple.")
    End Sub
End Class
