Public Class 화면3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        화면4.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub 시작3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        HCl.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        H2O.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        N2.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        N2H4.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        NH3.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        SiO4.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        NO2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        O2.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) 
        주기율표.Show()
    End Sub
End Class