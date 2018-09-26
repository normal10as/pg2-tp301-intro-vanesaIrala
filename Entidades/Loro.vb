Public Class Loro
    'Campos
    Private _Memoria As Queue(Of String)
    Private _Edad As Short
    Private _FechaNacimiento As Date
    Private _Nombre As String


    'Variables
    Private Palabras As String = ""

    'Constructor
    Sub New()
        _Memoria = New Queue(Of String)
        FechaNacimiento = Nothing
        Nombre = ""
    End Sub

    'Propiedades
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property FechaNacimiento As Date
        Get
            Return _FechaNacimiento
        End Get
        Set(value As Date)
            _FechaNacimiento = value
            _Edad = CalcularEdad(value) 'invoca a la funcion
        End Set
    End Property

    Public ReadOnly Property Edad As Short
        Get
            Return _Edad
        End Get
    End Property

    'Metodos
    Private Function CalcularEdad(ByVal FechaNacimiento As Date)
        Return DateDiff(DateInterval.Year, FechaNacimiento, Today)
    End Function

    Public Overridable Sub Escuchar(Frase As String)
        _Memoria.Enqueue(Frase)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Function Hablar() As String
        If _Memoria.Count Then
            Palabras &= _Memoria.Dequeue
        End If
        Return Palabras
    End Function
End Class
