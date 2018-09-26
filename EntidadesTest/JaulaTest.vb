Imports Entidades
Module JaulaTest
    Sub Main()

        Dim jaula1 As New Jaula()
        jaula1.Nombre = "Jaula de los Parlantes"

        Dim loro1 As New Loro()
        loro1.Nombre = "Pepe"
        loro1.FechaNacimiento = #10/02/2017#

        Dim cotorra1 As New Cotorra()
        cotorra1.Nombre = "lola"
        cotorra1.FechaNacimiento = #01/05/2009#

        Dim cotorra2 As New Cotorra()
        cotorra2.Nombre = "Pepita"
        cotorra2.FechaNacimiento = #07/25/2010#

        Dim cotorra3 As New Cotorra()
        cotorra3.Nombre = "Mili"
        cotorra3.FechaNacimiento = #12/31/2007#

        Dim cotorra4 As New Cotorra()
        cotorra4.Nombre = "Lulu"
        cotorra4.FechaNacimiento = #06/03/2014#
        jaula1.Loro = loro1
        jaula1.addCotorra(cotorra1)
        jaula1.addCotorra(cotorra2)
        jaula1.addCotorra(cotorra3)
        jaula1.addCotorra(cotorra4)

        Mostrar(jaula1)

        Console.ReadKey()
    End Sub

    Sub Mostrar(jaula As Jaula)
        Console.WriteLine(jaula.ToString())
        Console.WriteLine()

        Console.WriteLine("Nombre del Loro: " & jaula.Loro.ToString())
        Console.WriteLine("Fecha de nacimiento del Loro: " & jaula.Loro.FechaNacimiento)
        Console.WriteLine("Edad del Loro: " & jaula.Loro.Edad)
        Console.WriteLine()

        For Each Cotorra As Cotorra In jaula.getAllCotorras()
            Console.WriteLine("Nombre de la Cotorra: " & Cotorra.ToString())
            Console.WriteLine("Fecha de nacimiento de la Cotorra: " & Cotorra.FechaNacimiento)
            Console.WriteLine("Edad de la Cotorra: " & Cotorra.EdadHumana)
            Console.WriteLine()
        Next
    End Sub

End Module
