Public Class Settings
    Private Sub CarbonFiberControlButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberControlButton1.Click
        Me.Hide()
        ManagerForm.Show()
    End Sub

    Private Sub CarbonFiberButton1_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton1.Click
        Me.Hide()
        path.Show()
    End Sub

    Private Sub CarbonFiberButton2_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton2.Click
        Me.Hide()
        Verzögerung.Show()
    End Sub

    Private Sub CarbonFiberButton3_Click(sender As Object, e As EventArgs) Handles CarbonFiberButton3.Click
        MsgBox("Wegen Fehlern Forübergehend Deaktiviert...")
        'Me.Hide()
        'Startreihenfolge.Show()
    End Sub
End Class