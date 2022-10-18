Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("C:\Program Files (x86)\Steam\steamapps\common\GarrysMod\hl2.exe")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("C:\Program Files (x86)\Steam\steamapps\common\Geometry Dash\GeometryDash.exe")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("C:\Program Files (x86)\Steam\steamapps\common\Half-Life\hl.exe")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("C:\Program Files (x86)\Steam\steamapps\common\Ultimate Custom Night\Ultimate Custom Night.exe")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        PictureBox1.Image = Image.FromFile("C:\Users\borys\OneDrive\Pulpit\stim\resources\icon-stim-disabled.ico")
    End Sub
End Class