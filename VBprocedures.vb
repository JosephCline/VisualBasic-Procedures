Module Module1
    Dim iNumber1 As Integer
    Dim iNumber2 As Integer
    Dim iResult As Integer
    Sub Main()
        Call Get_Data()
        Call Process_Data()
        Call Display_Result()
        Console.ReadKey()
    End Sub
    Sub Get_Data()
        Console.Write("Enter the first number: ")
        iNumber1 = Console.ReadLine

        Console.Write("Enter the second number: ")
        iNumber2 = Console.ReadLine
    End Sub
    Sub Process_Data()

        iResult = iNumber1 + iNumber2

    End Sub
    Sub Display_Result()
        Console.Write(iResult)
    End Sub

End Module
