Module Module1

    Sub Main()
        Dim mystring As String
        Dim mystring2 As String
        Dim count As Integer
        Dim count2 As Integer
        Dim Sum1 As Integer
        Dim Sum2 As Integer
        Dim NextCharacter As Char
        Dim NextCharacter2 As Char
        Dim ASCII1 As Integer
        Dim ASCII2 As Integer


        mystring = " "
        mystring2 = " "
        count = 0
        count2 = 0
        Sum1 = 0
        Sum2 = 0
        NextCharacter = " "
        NextCharacter2 = " "
        ASCII1 = 0
        ASCII2 = 0


        Console.WriteLine(" ENTER YOUR STRING 1")
        mystring = Console.ReadLine

        Console.WriteLine("ENTER YOUR STRING 2")
        mystring2 = Console.ReadLine

        For count = 1 To Len(mystring)
            NextCharacter = Mid(mystring, count, 1)
            ASCII1 = Asc(NextCharacter)
            Sum1 = Sum1 + ASCII1
        Next

        For count2 = 1 To Len(mystring2)
            NextCharacter2 = Mid(mystring2, count2, 1)
            ASCII2 = Asc(NextCharacter2)
            Sum2 = Sum2 + ASCII2

        Next
        If Sum1 = Sum2 Then
            Console.WriteLine("THIS IS AN ANAGRAM")
        Else
            Console.WriteLine(" THIS NOT AN ANAGRAM")

        End If
        Console.WriteLine(" ASCII OF STRING 1 IS:" & Sum1)
        Console.WriteLine(" ASCII OF STRING 2 IS:" & Sum2)
        Console.ReadKey()


    End Sub

End Module
