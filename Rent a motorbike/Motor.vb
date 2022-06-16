Public Class Motor

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()


    End Sub

    Private Sub Motor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GotoRentPage()
        RENT.Show()
        Me.Hide()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RENT.LabelMotor.Text = LabelText1.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox1.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RENT.LabelMotor.Text = LabelText2.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox2.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RENT.LabelMotor.Text = LabelText3.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox3.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RENT.LabelMotor.Text = LabelText4.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox4.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        RENT.LabelMotor.Text = LabelText5.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox5.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RENT.LabelMotor.Text = LabelText6.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox6.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        RENT.LabelMotor.Text = LabelText7.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox7.BackgroundImage
        GotoRentPage()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        RENT.LabelMotor.Text = LabelText8.Text
        RENT.PictureBoxMotor.BackgroundImage = PictureBox8.BackgroundImage
        GotoRentPage()
    End Sub
End Class