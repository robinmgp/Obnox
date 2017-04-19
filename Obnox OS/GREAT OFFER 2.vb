Public Class GREAT_OFFER_2

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Obnox_video.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        My.Computer.Audio.Play(My.Resources.letsplacethenextone, AudioPlayMode.Background)
    End Sub

    Private Sub GREAT_OFFER_2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.nextwarning, AudioPlayMode.Background)
    End Sub
End Class