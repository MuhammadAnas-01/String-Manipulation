Module Module1


    Sub Main()
        Dim binarystring, nextchar As String
        Dim count, count2, product, number, result As Integer
        Dim validBinaryString As Boolean

        binarystring = ""
        nextchar = ""
        count = 0
        count2 = 1
        product = 0
        number = 0
        result = 0

        validBinaryString = True

        Console.Write("enter the binary number: ")
        binarystring = Console.ReadLine

        If Len(binarystring) < 1 Or Len(binarystring) > 8 Then
            validBinaryString = False
        Else
            For count = 1 To Len(binarystring)
                nextchar = Mid(binarystring, count, 1)
                If nextchar <> "1" And nextchar <> "0" Then
                    validBinaryString = False
                    Exit For
                End If
            Next
        End If

        If validBinaryString = False Then Console.Write("its not a valid binary number")
        Console.ReadKey()
        If validBinaryString = True Then Console.Write("its a valid binary number")
        Console.ReadKey()

            If validBinaryString = True Then
                For count = Len(binarystring) To 1 Step -1
                    nextchar = Mid(binarystring, count, 1)
                    number = Val(nextchar)
                    product = number * count2
                    count2 = count2 * 2
                    result = result + product
                Next
                Console.Write("your converted binary number to denary number= " & result)
                Console.ReadKey()

            End If

    End Sub

End Module
