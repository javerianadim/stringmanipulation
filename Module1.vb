Module Module1

    Sub Main()
        Dim Space As Integer
        Dim FirstName As String
        Dim SecondName As String
        Dim COUNT As Integer
        Dim Length As Integer
        Dim string1 As String
        Dim string2 As String

        FirstName = " "
        SecondName = " "
        COUNT = 0
        Space = 0
        Length = 0
        string1 = " "
        string2 = " "

        Console.Write(" Enter First String : ")
        string1 = Console.ReadLine

        Console.Write(" Enter Second String: ")
        string2 = Console.ReadLine

        Space = InStr(string1, " ")
        FirstName = Left(string1, Space - 1)
        Console.WriteLine(" Your First Name is :" & FirstName)

        Space = InStr(string2, " ")
        Length = Len(string2)
        SecondName = Right(string2, Length - Space)

        Console.WriteLine(" Your Second Name is:" & SecondName)
        Console.WriteLine(" Your Final String is:" & FirstName & " " & SecondName)

        Console.ReadKey()

    End Sub

End Module
