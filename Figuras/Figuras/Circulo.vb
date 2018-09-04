Public Class Circulo
    Inherits Figura

    Private _radio As UShort

    Public Sub New(Nombre As String, Radio As UShort)
        MyBase.New(Nombre)
        Me.Radio = Radio
    End Sub

    Public Property Radio As UShort
        Get
            Return _radio
        End Get
        Set(value As UShort)
            _radio = value
        End Set
    End Property

    Public Overrides Function calcularArea() As Single
        Return Math.PI * Radio * Radio
    End Function

End Class
