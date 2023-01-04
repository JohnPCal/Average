Imports System

Module calculator
    Sub main()
        Dim number1, number2, number3, sum, average As Decimal
        Console.Write(“enter first number ”)
        number1 = Console.ReadLine()
        Console.Write(“enter second number “)
        number2 = Console.ReadLine()
        Console.Write(“enter third number “)
        number3 = Console.ReadLine()
        sum = number1 + number2 + number3
        average = sum / 3
        Console.WriteLine(“their sum is “ & sum)
        Console.WriteLine(“their average is “ & average)
        Console.ReadLine()
    End Sub
End Module
