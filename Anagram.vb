Module Module1

    Sub Main()
        Dim str1, str2, nextchar As String
        Dim count As Integer
        Dim isanagram As Boolean

        str1 = ""
        str2 = ""
        nextchar = ""
        count = 0
        isanagram = True


        Console.Write("Enter the string: ")
        str1 = Console.ReadLine
        Console.Write("Enter the anagram: ")
        str2 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            If InStr(str2, nextchar) = 0 Then
                isanagram = False
            End If
        Next
        If isanagram = False Then
            Console.WriteLine("this in not anagram")
            Console.ReadKey()

        Else
            Console.WriteLine("this is anagram")
            Console.ReadKey()
        End If

    End Sub

End Module
