Public Class ParticionFijaCfg

    ' Tamaño de la Memoria Ram en Kb 
    Private TamañoMemoria As Integer = 0

    ' Lista de los tamaños de particiones en Kb
    Private ListaParticiones As List(Of Particion) = Nothing


    Private Sub ParticionFijaCfg_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Inicializando objeto List(Of Particion)
        ListaParticiones = New List(Of Particion)

        ' Inicializando tamaño de memoria de prueba
        TamañoMemoria = 100

        ' Inicializando particiones de memoria de prueba
        ListaParticiones.Add(New Particion(1, 0, 50, EstadoParticion.Libre))  ' P1 ~ 50kb
        ListaParticiones.Add(New Particion(2, 50, 25, EstadoParticion.Libre)) ' P2 ~ 20kb
        ListaParticiones.Add(New Particion(3, 75, 10, EstadoParticion.Libre)) ' P3 ~ 10kb
        ListaParticiones.Add(New Particion(4, 85, 15, EstadoParticion.Libre)) ' P4 ~ 15kb

        ' Actualizando controles 
        ActualizarNupTamaño()
        ActualizarDgvParticiones()
    End Sub

    Private Sub ActualizarNupTamaño()
        nupTamaño.Value = TamañoMemoria
    End Sub

    Private Sub ActualizarDgvParticiones()

        ' Limpiando Datagridview
        dgvParticiones.Rows.Clear()

        ' Agragando filas al control Datagridview
        For Each p As Particion In ListaParticiones
            dgvParticiones.Rows.Add(New String() {p.Numero, p.Tamaño})
        Next

    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click

        ' Declaración e Inicialización de objeto ParticionFija
        Dim frmParticionFija As ParticionFija = New ParticionFija()

        ' Inicialización de parametros y mostrando formulario
        frmParticionFija.Inicializar(TamañoMemoria, ListaParticiones)
        frmParticionFija.ShowDialog()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()
    End Sub

    Private Sub btnAgregarParticion_Click(sender As Object, e As EventArgs) Handles btnAgregarParticion.Click
        ' TODO
    End Sub

    Private Sub btnEliminarParticion_Click(sender As Object, e As EventArgs) Handles btnEliminarParticion.Click
        ' TODO
    End Sub
End Class