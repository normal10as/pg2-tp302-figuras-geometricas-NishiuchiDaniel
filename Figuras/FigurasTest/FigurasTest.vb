Imports Figuras
Module FigurasTest

    Sub Main()

        Dim Triangulo As New Triangulo("Triangulo", 10, 10)
        Dim Rectangulo As New Rectangulo("Rectangulo", 10, 15)
        Dim Cuadrado As New Cuadrado("Cuadrado", 10)
        Dim Circulo As New Circulo("Circulo", 10)


        Console.WriteLine("Area del Triangulo: " & Triangulo.calcularArea)
        Console.WriteLine("Area del Rectangulo: " & Rectangulo.calcularArea)
        Console.WriteLine("Area del Cuadrado: " & Cuadrado.calcularArea)
        Console.WriteLine("Area del Circulo: " & Circulo.calcularArea)


    End Sub

End Module
