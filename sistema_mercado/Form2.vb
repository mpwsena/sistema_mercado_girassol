Public Class TelaPrincipal

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Atualiza o horário atual quando o formulário é carregado
        Timer1.Start()
        MostrarHorarioAtual()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Atualiza o horário atual a cada segundo
        MostrarHorarioAtual()
        LbHor.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub MostrarHorarioAtual()
        ' Obtém o horário atual
        Dim horarioAtual As DateTime = DateTime.Now

        ' Exibe o horário atual no formato desejado
        LbHor.Text = horarioAtual.ToString("HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Instancia o formulário desejado
        Dim telaPrincipal As New TelaPrincipal()

        ' Exibe o formulário
        telaPrincipal.Show()
    End Sub
    Private Sub LbHor_Click(sender As Object, e As EventArgs) Handles LbHor.Click

    End Sub
End Class