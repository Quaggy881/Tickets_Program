﻿Module Module1

    Sub Main()

        Dim ticketprice As Integer = 20
        Dim ticketnum As Integer
        Dim ticketfinalprice As Integer
        Dim disc10 As Decimal = 0.1
        Dim disc20 As Decimal = 0.2
        Dim ticketogprice As Integer

        Do

            Console.WriteLine("Input the number of tickets to be bought" & vbNewLine)
            ticketnum = Console.ReadLine()

            If ticketnum < 0 Or ticketnum > 25 Then


                Console.WriteLine(vbNewLine & "The number of tickets should be less than 26 and greater than 0" & vbNewLine)

            End If

        Loop Until ticketnum > 0 And ticketnum < 26


        Do


            ticketogprice = ticketnum * ticketprice


            If ticketnum >= 0 And ticketnum <= 25 Then

                If ticketnum > 0 And ticketnum <= 9 Then

                    ticketfinalprice = ticketogprice

                ElseIf ticketnum >= 10 And ticketnum <= 19 Then

                    ticketfinalprice = ticketogprice - (ticketogprice * disc10)

                ElseIf ticketnum > 19 And ticketnum <= 25 Then


                    ticketfinalprice = ticketogprice - (ticketogprice * disc20)

                End If


                Console.WriteLine(vbNewLine & "The total price of tickets is " & ticketfinalprice & vbNewLine)


            Else

                Console.WriteLine(vbNewLine & "Number of tickets invalid" & vbNewLine)
                Console.ReadLine()

            End If


            Console.WriteLine(vbNewLine & "Input the number of tickets to be bought" & vbNewLine & vbNewLine & "Or" & vbNewLine & vbNewLine & "input -1 to end " & vbNewLine & vbNewLine)
            ticketnum = Console.ReadLine()


        Loop While ticketnum <> -1


    End Sub

End Module
