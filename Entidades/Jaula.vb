Public Class Jaula

    'Campos
    Private _Nombre As String
    Private _Loro As Loro 'Asociación Simple
    Private _Cotorras As List(Of Cotorra) 'Asociación Multiple

    'Constructor
    Sub New()
        _Nombre = ""
        _Loro = New Loro
        _Cotorras = New List(Of Cotorra)
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

    Public Property Loro As Loro
        Get
            Return _Loro
        End Get
        Set(value As Loro)
            _Loro = value
        End Set
    End Property

    'Metodos
    Public Sub addCotorra(value As Cotorra)
        If _Cotorras.Count < 3 Then _Cotorras.Add(value)
    End Sub

    'Sobrescribir ToString
    Public Overrides Function ToString() As String
        Return "Esta es la jaula: " & Nombre
    End Function

    Public Function getAllCotorras() As List(Of Cotorra)
        Return _Cotorras
    End Function
End Class
