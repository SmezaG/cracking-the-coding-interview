Module Problem2

    Public Sub Solution1()

        Dim charlist1 As New List(Of Char)
        Dim charlist2 As New List(Of Char)
        Dim input1 As String
        Dim inputArray1 As Char()
        Dim input2 As String
        Dim inputArray2 As Char()
        Dim result As String = "That Strings are a Permutation"

        Console.WriteLine("Introduce la primera cadena:")
        input1 = Console.ReadLine()
        input1 = input1.ToUpper() ' Para que nos sea indiferente mayusculas y minusculas
        inputArray1 = input1.ToCharArray()

        Console.WriteLine("Introduce la segunda cadena:")
        input2 = Console.ReadLine()
        input2 = input2.ToUpper() ' Para que nos sea indiferente mayusculas y minusculas
        inputArray2 = input2.ToCharArray()


        For Each row In inputArray1
            charlist1.Add(row)
        Next

        For Each row In inputArray2
            charlist2.Add(row)
        Next

        charlist1.Sort()
        charlist2.Sort()

        For i As Integer = 0 To charlist1.Count - 1
            If charlist2.Count - 1 < i Then
                result = "That Strings are not a permutation"
                Exit For
            End If

            If charlist1(i) <> charlist2(i) Then
                result = "That Strings are not a permutation"
                Exit For
            End If

        Next

        Console.WriteLine(result)


    End Sub

End Module
