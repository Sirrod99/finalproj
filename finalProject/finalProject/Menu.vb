Public Class Menu

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Parent = PictureBox1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
