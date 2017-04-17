Public Class Form1
    Dim usercolor As Color
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        usercolor = Color.Teal
        Me.BackColor = Color.Black
        Me.WindowState = FormWindowState.Maximized
        My.Computer.Audio.Play(My.Resources.Welcome, AudioPlayMode.Background)
        Me.Show()
        PictureBox1.Show()
        PictureBox1.Image = (My.Resources.OBNOX)
        Me.Refresh()
        Threading.Thread.Sleep(9500)
        PictureBox1.Image = (My.Resources.intro)
        Me.Refresh()
        Timer1.Interval = 6150
        Timer1.Enabled = True




    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Hide()
        Timer1.Enabled = False
        Me.BackColor = usercolor
        PictureBox2.Show()
        Junkicon.Show()
        PictureBox3.Show()
        Form3.ShowDialog()
        GREAT_OFFER_1.ShowDialog()
        My.Computer.Audio.Play(My.Resources.firsticon, AudioPlayMode.Background)
        Firsticonplace.Enabled = True
    End Sub

    Private Sub Junkicon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Junkicon.Click
        Junk.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Firsticonplace.Tick
        firsticonthere.Show()
        Firsticonplace.Enabled = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Active_Web_Browser.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        ColorDialog1.ShowDialog()
        usercolor = ColorDialog1.Color
        Me.BackColor = usercolor
        PictureBox1.BackColor = usercolor
        PictureBox2.BackColor = usercolor
        Junkicon.BackColor = usercolor
        PictureBox3.BackColor = usercolor
        firsticonthere.BackColor = usercolor
    End Sub

    Private Sub firsticonthere_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firsticonthere.Click
        Obnox_video.Show()
    End Sub
End Class
