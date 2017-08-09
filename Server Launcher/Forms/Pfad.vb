Public Class path
    Public Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        OpenFileDialog1.ShowDialog()
        CarbonFiberTextBox1.Text = OpenFileDialog1.FileName
        My.Settings.Pfad1 = OpenFileDialog1.FileName
    End Sub

    Public Sub CarbonFiberButton2_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton2.Click
        OpenFileDialog2.ShowDialog()
        CarbonFiberTextBox2.Text = OpenFileDialog2.FileName
        My.Settings.Pfad2 = OpenFileDialog2.FileName
    End Sub

    Public Sub CarbonFiberButton3_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton3.Click
        OpenFileDialog3.ShowDialog()
        CarbonFiberTextBox3.Text = OpenFileDialog3.FileName
        My.Settings.Pfad3 = OpenFileDialog3.FileName
    End Sub

    Public Sub CarbonFiberButton4_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton4.Click
        OpenFileDialog4.ShowDialog()
        CarbonFiberTextBox4.Text = OpenFileDialog4.FileName
        My.Settings.Pfad4 = OpenFileDialog4.FileName
    End Sub

    Public Sub CarbonFiberButton5_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton5.Click
        OpenFileDialog5.ShowDialog()
        CarbonFiberTextBox5.Text = OpenFileDialog5.FileName
        My.Settings.Pfad5 = OpenFileDialog5.FileName
    End Sub

    Public Sub CarbonFiberButton6_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton6.Click
        OpenFileDialog6.ShowDialog()
        CarbonFiberTextBox6.Text = OpenFileDialog6.FileName
        My.Settings.Pfad6 = OpenFileDialog6.FileName
    End Sub

    Public Sub CarbonFiberButton7_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton7.Click
        OpenFileDialog7.ShowDialog()
        CarbonFiberTextBox7.Text = OpenFileDialog7.FileName
        My.Settings.Pfad7 = OpenFileDialog7.FileName
    End Sub

    Private Sub CarbonFiberControlButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberControlButton1.Click
        My.Settings.Save()
        Me.Hide()
        Settings.Show()
    End Sub

    Private Sub Pfad_Load(sender As Object, e As EventArgs) Handles Me.Load
        CarbonFiberTextBox1.Text = My.Settings.Pfad1
        CarbonFiberTextBox2.Text = My.Settings.Pfad2
        CarbonFiberTextBox3.Text = My.Settings.Pfad3
        CarbonFiberTextBox4.Text = My.Settings.Pfad4
        CarbonFiberTextBox5.Text = My.Settings.Pfad5
        CarbonFiberTextBox6.Text = My.Settings.Pfad6
        CarbonFiberTextBox7.Text = My.Settings.Pfad7
    End Sub
End Class