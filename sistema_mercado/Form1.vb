Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Instancia o formulário desejado
        Dim telaPrincipal As New TelaPrincipal()

        ' Exibe o formulário
        telaPrincipal.Show()
    End Sub
End Class