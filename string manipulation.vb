Module Module1

    Sub Main()
        Dim str As String
        Dim reverse As String
        Dim char As Char
        Dim count As Integer


        str = ""
        reverse = ""
        char = ""
        count = 1


        Console.WriteLine("Enter value you want to revese:")
        str = Console.ReadLine()

        For count = Len(str) To 1 Step -1
            char = Mid(str, 1)
            reverse = reverse & char

        Next
        Console.WriteLine(reverse)
        Console.ReadKey()

    End Sub

End Module
