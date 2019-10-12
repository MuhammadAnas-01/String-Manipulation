Module Module1

    Sub Main()
        Dim str1, str2, concatedstring, firstword, secondword As String
        Dim space, spacepos2 As Integer

        str1 = ""
        str2 = ""
        concatedstring = ""
        firstword = ""
        secondword = ""
        space = 0
        spacepos2 = 0

        Console.Write("Enter the first string: ")
        str1 = Console.ReadLine

        Console.Write("Enter the second string: ")
        str2 = Console.ReadLine

        space = InStr(str1, " ")
        firstword = Left(str1, space - 1)

        spacepos2 = InStr(str2, " ")
        secondword = Mid(str2, spacepos2 + 1, Len(str2))

        concatedstring = firstword & " " & secondword

        Console.WriteLine("Your concated string is: " & concatedstring)
        Console.ReadKey()






    End Sub

End Module
