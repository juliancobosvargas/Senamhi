Public Class Form1
    Private servicio As New ServicioReferencia1.ServicioWebSoapClient
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvTabla.DataSource = servicio.ListarTTiempo.Tables(0)
    End Sub
End Class
