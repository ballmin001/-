Public Class Fe2O3
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.PictureBox2.Hide()
        Me.PictureBox1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.PictureBox1.Hide()
        Me.PictureBox2.Show()
    End Sub

    Private Sub Fe2O3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PictureBox2.Hide()
    End Sub
End Class