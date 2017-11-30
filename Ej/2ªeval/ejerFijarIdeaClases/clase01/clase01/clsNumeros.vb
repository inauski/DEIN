Public Class clsNumeros
    Private _num1 As Integer
    Public Property num1() As Integer
        Get
            Return _num1
        End Get
        Set(ByVal value As Integer)
            _num1 = value
        End Set
    End Property

    Private _num2 As Integer
    Public Property num2() As Integer
        Get
            Return _num2
        End Get
        Set(ByVal value As Integer)
            _num2 = value
        End Set
    End Property


    Function calcularSuma() As Double
        Return (_num1 + _num2)
    End Function

    Function calcularResta() As Double
        Return (_num1 - _num2)
    End Function

    Function calcularMultiplicacion() As Double
        Return (_num1 * _num2)
    End Function

    Function calcularDivision() As Double
        Return (_num1 / _num2)
    End Function
End Class
