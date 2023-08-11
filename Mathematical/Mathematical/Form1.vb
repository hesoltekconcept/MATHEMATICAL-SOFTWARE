Public Class Form1
    Dim base, ht, area_tr As Double
    Dim a, b, c, det, root1, root2 As Double
    Dim radius, area_cr As Double
    Const pi = 3.142

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.MinimizeBox = True
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        det = (b ^ 2) - (4 * a * c)
        root1 = Val(-b + Math.Sqrt(det)) / (2 * a)
        root2 = Val(-b - Math.Sqrt(det)) / (2 * a)

        TextBox4.Text = root1
        TextBox5.Text = root2



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        base = Val(TextBox6.Text)
        ht = Val(TextBox7.Text)
        area_tr = Val((1 / 2) * (base * ht))
        TextBox8.Text = area_tr

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Panel2.Show()
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel3.Show()
        Panel2.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        radius = Val(TextBox9.Text)
        area_cr = Val(pi * radius ^ 2)
        TextBox10.Text = area_cr

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel4.Show()
        Panel3.Hide()
        Panel2.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
End Class
