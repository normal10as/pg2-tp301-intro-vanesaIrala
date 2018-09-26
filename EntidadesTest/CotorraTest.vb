Imports Entidades
Module CotorraTest
    Sub Main()
        Dim cotorra1 As New Cotorra()
        cotorra1.Nombre = "Pepy"
        cotorra1.FechaNacimiento = #08-31-2012#

        Console.WriteLine("El Nombre de la Cotorra es: " & cotorra1.ToString)
        Console.WriteLine("La Fecha de Nacimiento: " & cotorra1.FechaNacimiento)
        Console.WriteLine("Su EdadHumana es: " & cotorra1.EdadHumana)
        cotorra1.Escuchar("papita")
        cotorra1.Escuchar(" pa")
        cotorra1.Escuchar(" la")
        cotorra1.Escuchar(" cotorra")
        cotorra1.Escuchar(" " & cotorra1.ToString)
        Console.WriteLine("La cotorra dice: ")
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine(cotorra1.Hablar)
        Console.WriteLine()


        Console.ReadKey()
    End Sub

End Module
