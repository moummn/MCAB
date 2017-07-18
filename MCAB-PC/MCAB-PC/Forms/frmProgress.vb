Public Class frmProgress
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Maximum = 100
        ProgressBar1.Minimum = 0
        For L As Long = 0 To 100
            Threading.Thread.Sleep(50)
            Application.DoEvents()
            ProgressBar1.Value = L
        Next
    End Sub
End Class