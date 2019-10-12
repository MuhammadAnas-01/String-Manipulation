Module Module1

    Sub Main()
        Dim str1, str2, str3 As String
        Dim spacepos, spacepos2 As Integer

        spacepos2 = 0
        spacepos = 0
        str1 = ""
        str2 = ""
        str3 = ""

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine

        spacepos = InStr(str1, " ")

        str2 = Right(str1, Len(str1) - spacepos)

        spacepos2 = InStr(str2, " ")

        str3 = Left(str2, spacepos2)

        Console.WriteLine("Middle word is: " & str3)
        Console.ReadKey()



    End Sub

End Module
