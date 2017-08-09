Public Class Verzögerung
    Private Sub CarbonFiberControlButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberControlButton1.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Verzögerung_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarbonFiberTextBox1.Text = My.Settings.verzögerung1
        CarbonFiberTextBox2.Text = My.Settings.verzögerung2
        CarbonFiberTextBox3.Text = My.Settings.verzögerung3
        CarbonFiberTextBox4.Text = My.Settings.verzögerung4
        CarbonFiberTextBox5.Text = My.Settings.verzögerung5
        CarbonFiberTextBox6.Text = My.Settings.verzögerung6
        CarbonFiberTextBox7.Text = My.Settings.verzögerung7
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        My.Settings.Save()
    End Sub
End Class