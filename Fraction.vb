

Public Class Fraction
    Private m_Numerator As Long
    Private m_Denominator As Long

    ' Initialize the fraction from a string A/B.
    Public Sub New(ByVal txt As String)
        Dim pieces() As String

        pieces = System.Text.RegularExpressions.Regex.split(txt, "/")
        m_Numerator = CLng(pieces(0))
        m_Denominator = CLng(pieces(1))
        Simplify()
    End Sub

    ' Initialize the fraction from numerator and denominator.
    Public Sub New(ByVal numer As Long, ByVal denom As Long)
        m_Numerator = numer
        m_Denominator = denom
        Simplify()
    End Sub

    ' Property procedures.
    Public Property Numerator() As Long
        Get
            Return m_Numerator
        End Get
        Set(ByVal Value As Long)
            m_Numerator = Value
        End Set
    End Property
    Public Property Denominator() As Long
        Get
            Return m_Denominator
        End Get
        Set(ByVal Value As Long)
            m_Denominator = Value
        End Set
    End Property

    ' Return Me * frac.
    Public Function Times(ByVal frac As Fraction) As Fraction
        ' Swap numerators and denominators to simplify.
        Dim result1 As New Fraction(Me.Numerator, frac.Denominator)
        Dim result2 As New Fraction(frac.Numerator, Me.Denominator)

        Return New Fraction( _
            result1.Numerator * result2.Numerator, _
            result1.Denominator * result2.Denominator)
    End Function

    ' Return -Me.
    Public Function Negate() As Fraction
        Return New Fraction(-Me.Numerator, Me.Denominator)
    End Function

    ' Return 1/Me.
    Public Function Invert() As Fraction
        Return New Fraction(Me.Denominator, Me.Numerator)
    End Function

    ' Return Me + frac.
    Public Function Plus(ByVal frac As Fraction) As Fraction
        Dim gcd_ab As Long

        ' Get the denominators' greatest common divisor.
        gcd_ab = GCD(Me.Denominator, frac.Denominator)

        Dim numer As Long = _
            Me.Numerator * (frac.Denominator \ gcd_ab) + _
            frac.Numerator * (Me.Denominator \ gcd_ab)
        Dim denom As Long = _
            Me.Denominator * (frac.Denominator \ gcd_ab)
        Return New Fraction(numer, denom)
    End Function

    ' Return This - frac.
    Public Function Minus(ByVal frac As Fraction) As Fraction
        Return Me.Plus(frac.Negate())
    End Function

    ' Return This / frac.
    Public Function DivideBy(ByVal frac As Fraction) As Fraction
        Return Me.Times(frac.Invert())
    End Function

    ' Simplify the fraction.
    Private Sub Simplify()
        Dim gcd_ab As Long

        ' Simplify the sign.
        If m_Denominator < 0 Then
            m_Numerator = -m_Numerator
            m_Denominator = -m_Denominator
        End If

        ' Factor out the greatest common divisor of the
        ' numerator and the denominator.
        gcd_ab = GCD(m_Numerator, m_Denominator)
        m_Numerator = m_Numerator \ gcd_ab
        m_Denominator = m_Denominator \ gcd_ab
    End Sub

    ' Return a Double representation of the fraction.
    Public Function ToDouble() As Double
        ToDouble = m_Numerator / m_Denominator
    End Function

    ' Return the fraction's value as a string.
    Public Overrides Function ToString() As String
        ToString = Numerator.ToString() & "/" & Denominator.ToString()
    End Function
End Class
