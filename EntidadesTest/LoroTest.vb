Imports Entidades
Module LoroTest

    Sub Main()
        Dim loro1 As New Loro()
        loro1.Nombre = "Juan"
        loro1.FechaNacimiento = #12-05-2005#

        Console.WriteLine("El Nombre del Loro es: " & loro1.ToString)
        Console.WriteLine("La Fecha de Nacimiento: " & loro1.FechaNacimiento)
        Console.WriteLine("Su Edad es: " & loro1.Edad)
        loro1.Escuchar("papita")
        loro1.Escuchar(" pa el")
        loro1.Escuchar(" loro ")
        loro1.Escuchar(loro1.ToString)
        Console.WriteLine("El loro dice: ")
        Console.WriteLine(loro1.Hablar)
        Console.WriteLine(loro1.Hablar)
        Console.WriteLine(loro1.Hablar)
        Console.WriteLine(loro1.Hablar)
        Console.WriteLine()

        Console.ReadKey()
    End Sub

End Module
