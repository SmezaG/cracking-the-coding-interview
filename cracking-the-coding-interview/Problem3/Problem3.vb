Imports System.Text

Module Problem3
    Public Sub Solution1()

        Dim charlist As New List(Of Char)
        Dim input As String
        Dim inputArray As Char()
        Dim result As String = ""

        Console.WriteLine("Introduce una cadena:")
        input = Console.ReadLine()
        input.Trim()
        inputArray = input.ToCharArray()
        Dim FinalString As New StringBuilder()

        For Each row In inputArray
            If row = " " Then
                FinalString.Append("%20")
            Else
                FinalString.Append(row)
            End If

        Next

        Console.WriteLine(FinalString.ToString())

    End Sub

End Module
