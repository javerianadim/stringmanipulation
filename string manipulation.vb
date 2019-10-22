Module Module1

    Sub Main()
        Dim reverse  As String
        Dim str As String
        Dim character As Char
        Dim count As Integer


        reverse  = ""
        str = ""
        character = ""
        count = 0


        Console.WriteLine("Enter value you want to revese:")
        str = Console.ReadLine()

        For count = Len(str) To 1 Step -1
        character = Mid(str, count , 1)
            reverse = reverse & character

        Next
        Console.WriteLine(reverse)
        Console.ReadKey()

    End Sub

End Module
