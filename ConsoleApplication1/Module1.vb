Module Module1

    Sub Main()
        Dim name() = {"Taha", "Hiba", "Alishba", "Tahreem", "Sara", "Ehsaan", "Areesha", "Saira", "Asmaar", "Rayyan", "Anaya", "Sidra", "Samreena", "Daniyal"}
        Dim count, flag, x As Integer
        Dim temp As String
        Do 'Repeat
            count = 0
            flag = 0
            Do 'Repeat
                If name(count) > name(count + 1) Then
                    temp = name(count)
                    name(count) = name(count + 1)
                    name(count + 1) = temp
                    flag = 1
                End If
                count = count + 1
            Loop Until count = 13
        Loop Until flag = 0
        For x = 0 To 13
            Console.WriteLine(name(x))
        Next

        Console.ReadKey()
    End Sub

End Module
