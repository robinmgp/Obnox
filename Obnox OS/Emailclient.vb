Public Class Emailclient
    

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        reformat.Show()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        illegal.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Emailclient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Email_powerformat.ShowDialog()
    End Sub
End Class