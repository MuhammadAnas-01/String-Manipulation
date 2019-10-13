Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        nextchar = ""
        str1 = ""
        str2 = ""
        count = 0

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine

        For count = Len(str1) To 1 Step -1
            nextchar = Mid(str1, count, 1)
            str2 = str2 & nextchar

        Next
        Console.WriteLine(str2)
        Console.ReadKey()

    End Sub

End Module
