Public Class Cotorra
    'Herencia
    Inherits Loro

    'Variables
    Private Activo As Boolean = True

    'Constructor
    Sub New()
        MyBase.New()
    End Sub

    'Propiedades
    Public ReadOnly Property EdadHumana As UShort
        Get
            Return Edad * 2
        End Get
    End Property

    'Metodos
    Public Overrides Sub Escuchar(Frase As String)
        If Activo Then
            MyBase.Escuchar(Frase)
            Activo = False
        Else
            Activo = True
        End If
    End Sub
End Class
