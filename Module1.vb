Module Module1

    Sub Main()

        Dim star As Integer = 1

        While star < 6

            For n As Integer = 1 To star

                Console.Write("XX")

            Next

            star = star + 1

            Console.WriteLine()

        End While

        Console.Read()

    End Sub

End Module
