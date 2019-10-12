Module Module1

    Sub Main()
        Dim Sentence1 As String
        Dim nextchar As String
        Dim Count As Integer
        Dim AlphaSet As String
        Dim IsPangram As Boolean

        Sentence1 = " "
        nextchar = " "
        Count = 0
        AlphaSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        IsPangram = True

        Console.WriteLine("Enter your Sentence:")
        Sentence1 = Console.ReadLine
        Sentence1 = UCase(Sentence1)

        For Count = 1 To Len(AlphaSet)
            nextchar = Mid(AlphaSet, Count, 1)
            If InStr(Sentence1, nextchar) = 0 Then
                IsPangram = False
                Exit For
            End If
        Next

        If IsPangram = True Then
            Console.WriteLine(" This is a Pangram.")
        Else
            Console.WriteLine("This is a NOT Pangram.")
        End If
        Console.ReadKey()
    End Sub

End Module
