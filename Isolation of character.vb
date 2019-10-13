Module Module1

    Sub Main()
        Dim str1, str2, nextchar, alphabets, numbers, specials As String
        Dim count As Integer

        str1 = ""
        str2 = ""
        specials = ""
        numbers = ""
        alphabets = ""
        nextchar = ""
        count = 0

        Console.Write("Enter the string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If UCase(nextchar) >= "A" And UCase(nextchar) <= "Z" Then
                alphabets = alphabets & nextchar
            ElseIf nextchar >= "0" And nextchar <= "9" Then
                numbers = numbers & nextchar
            Else
                specials = specials & nextchar
            End If
        Next
        Console.WriteLine("alphabets in your string are: " & alphabets)
        Console.WriteLine("numbers in your string are: " & numbers)
        Console.WriteLine("specials in your string are: " & specials)
        Console.ReadKey()
    End Sub

End Module
