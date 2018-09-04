Public Class Cuadrado
    Inherits Figura

    Private _lado As UShort

    Public Sub New(Nombre As String, Lado As UShort)
        MyBase.New(Nombre)
        Me.Lado = Lado
    End Sub

    Public Property Lado As UShort
        Get
            Return _lado
        End Get
        Set(value As UShort)
            _lado = value
        End Set
    End Property

    Public Overrides Function calcularArea() As Single
        Return Lado * Lado
    End Function

End Class
