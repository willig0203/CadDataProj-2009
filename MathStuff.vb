Imports System.Math

Module MathStuff
    ' Return the greatest common divisor (GCD) of a and b.
    Public Function GCD(ByVal a As Long, ByVal b As Long) As Long
        Dim tmp As Long
        Dim remainder As Long

        ' Make a >= b.
        a = Abs(a)
        b = Abs(b)
        If a < b Then
            tmp = a
            a = b
            b = tmp
        End If

        ' Pull out remainders.
        Do
            remainder = a Mod b
            If remainder = 0 Then Return b
            a = b
            b = remainder
        Loop
    End Function

    ' Return the least common multiple of a and b.
    Public Function LCM(ByVal a As Long, ByVal b As Long) As Long
        Dim gcd_ab As Long

        gcd_ab = GCD(a, b)
        LCM = ((a \ gcd_ab) * (b \ gcd_ab)) * gcd_ab
    End Function
End Module
