Public Class Startreihenfolge
    Private Sub CarbonFiberControlButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberControlButton1.Click
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Startreihenfolge_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarbonFiberTextBox1.Text = My.Settings.start1
        CarbonFiberTextBox2.Text = My.Settings.start2
        CarbonFiberTextBox3.Text = My.Settings.start3
        CarbonFiberTextBox4.Text = My.Settings.start4
        CarbonFiberTextBox5.Text = My.Settings.start5
        CarbonFiberTextBox6.Text = My.Settings.start6
        CarbonFiberTextBox7.Text = My.Settings.start7
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        My.Settings.Save()
    End Sub
End Class