Public Class Youwill

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Obnox_video.ShowDialog()
        Form1.Close()
        Invisibleagent.Close()
        Me.Close()
    End Sub

    Private Sub Youwill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.YOUWILL, AudioPlayMode.Background)
    End Sub
End Class