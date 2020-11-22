Public Class menu5
    Dim a As New Process

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a.StartInfo.FileName = "Outlook.exe"
        a.Start()
    End Sub
End Class