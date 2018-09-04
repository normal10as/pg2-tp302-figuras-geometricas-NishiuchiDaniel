Public Class Figura
    Private _nombre As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Sub New(Nombre)
        Me.Nombre = Nombre
    End Sub

    Public Overridable Function calcularArea() As Single
        Return 0
    End Function

End Class
