Public Class Particion

    Private _Numero As Integer
    Private _Tamaño As Integer
    Private _DireccionInicial As Integer
    Private _Proceso As Proceso
    Private _Estado As EstadoParticion

    Public Property Numero() As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
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

    Public Property Direccion() As Integer
        Get
            Return _DireccionInicial
        End Get
        Set(ByVal value As Integer)
            _DireccionInicial = value
        End Set
    End Property


    Public Property Proceso() As Proceso
        Get
            Return _Proceso
        End Get
        Set(ByVal value As Proceso)
            _Proceso = value
        End Set
    End Property

    Public Property Estado() As EstadoParticion
        Get
            Return _Estado
        End Get
        Set(ByVal value As EstadoParticion)
            _Estado = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(numero As Integer, direccion As Integer, tamaño As Integer, estado As EstadoParticion)
        Me.Numero = numero
        Me.Direccion = direccion
        Me.Tamaño = tamaño
        Me.Estado = estado
    End Sub

End Class
