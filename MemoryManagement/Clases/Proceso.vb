Public Class Proceso

#Region " Constructors "

    Public Sub New()
    End Sub

    Public Sub New(nombre As String, tamaño As Integer, estado As EstadoProceso)
        Me.Nombre = nombre
        Me.Tamaño = tamaño
        Me.Estado = estado
    End Sub

#End Region
#Region " Properties "

    Private _Nombre As String
    Private _Tamaño As Integer
    Private _Estado As EstadoProceso

    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Tamaño() As Integer
        Get
            Return _Tamaño
        End Get
        Set(ByVal value As Integer)
            _Tamaño = value
        End Set
    End Property

    Public Property Estado() As EstadoProceso
        Get
            Return _Estado
        End Get
        Set(ByVal value As EstadoProceso)
            _Estado = value
        End Set
    End Property

#End Region

End Class
