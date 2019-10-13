Module Module1

    Sub Main()
        Dim str1, str2, str3, nextchar As String
        Dim count As Integer

        nextchar = ""
        str1 = ""
        str2 = ""
        str3 = ""
        count = 0

        Console.Write("Enter your string: ")
        str1 = Console.ReadLine

        Console.Write("Enter the character you want to truncate: ")
        str2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If nextchar <> str2 Then
                str3 = str3 & nextchar
            End If
        Next
        str3 = str1
        Console.WriteLine("your final string is: " & str1)
        Console.ReadKey()


    End Sub

End Module
