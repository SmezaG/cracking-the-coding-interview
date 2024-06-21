Module Problem1

    Dim charlist As New List(Of Char)
    Dim input As String
    Dim inputArray As Char()
    Dim result As String = "That String has no repeated character"
    Public Sub Problem1Header()
        Console.WriteLine("Introduce una cadena:")
        input = Console.ReadLine()
        input = input.ToUpper() ' Para que nos sea indiferente mayusculas y minusculas
        inputArray = input.ToCharArray()
    End Sub

    Public Sub Solution1()

        Problem1Header()

        For Each inputChar In inputArray

            If inputChar = " " Then ' No valoramos los espacios
                Continue For
            End If

            If charlist.Contains(inputChar) Then
                result = $"The character {inputChar} has already been used"
                Exit For
            Else
                charlist.Add(inputChar)
            End If

        Next

        Console.WriteLine(result)

    End Sub

    Public Sub Solution2()

        Problem1Header()
        Dim repeated = False

        For i As Integer = 0 To inputArray.Count - 1

            If repeated Then
                result = $"The character {inputArray(i)} has already been used"
                Exit For
            End If

            If inputArray(i) = " " Then
                Continue For
            End If

            For j As Integer = i + 1 To inputArray.Count - 1

                If inputArray(i) = inputArray(j) Then
                    repeated = True
                    Exit For
                End If
            Next
        Next

        Console.WriteLine(result)

    End Sub

End Module
