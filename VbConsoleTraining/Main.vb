Module Main

    Sub Main()

        SayYes()
        Console.ReadLine()

    End Sub

    Sub SayYes()
        Dim yesman As YesMan = New YesMan()
        Console.WriteLine(yesman.SayYes().ToString())
    End Sub

    Sub AImplTest()

        Dim aimple As IA = New AImpl()

    End Sub

End Module
