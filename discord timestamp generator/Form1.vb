Imports Microsoft.SqlServer.Server

Public Class Form1
    Dim format As Char = "t"
    Dim unixTimestamp As Int64 = Math.Round((DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds) - unixOffset
    Dim unixOffset As Int64 = (DateTime.Now - DateTime.UtcNow).TotalSeconds
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        unixOffset = (DateTime.Now - DateTime.UtcNow).TotalSeconds
        DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        DateTimePicker1.Value = DateTime.Now
        unixTimestamp = Math.Round((DateTimePicker1.Value - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds) - unixOffset
        createTimestamp()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        unixTimestamp = Math.Round((DateTimePicker1.Value - New DateTime(1970, 1, 1, 0, 0, 0)).TotalSeconds) - unixOffset
        createTimestamp()
    End Sub

    Private Sub shorttimeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles shorttimeBtn.CheckedChanged
        format = "t"
        createTimestamp()
    End Sub

    Private Sub fulltimeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles fulltimeBtn.CheckedChanged
        format = "T"
        createTimestamp()
    End Sub

    Private Sub shortdateBtn_CheckedChanged(sender As Object, e As EventArgs) Handles shortdateBtn.CheckedChanged
        format = "d"
        createTimestamp()
    End Sub

    Private Sub fulldateBtn_CheckedChanged(sender As Object, e As EventArgs) Handles fulldateBtn.CheckedChanged
        format = "D"
        createTimestamp()
    End Sub

    Private Sub dateandtimeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles dateandtimeBtn.CheckedChanged
        format = "f"
        createTimestamp()
    End Sub

    Private Sub daydateandtimeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles daydateandtimeBtn.CheckedChanged
        format = "F"
        createTimestamp()
    End Sub

    Private Sub relativeBtn_CheckedChanged(sender As Object, e As EventArgs) Handles relativeBtn.CheckedChanged
        format = "R"
        createTimestamp()
    End Sub
    Private Sub createTimestamp()
        TextBox1.Text = "<t:" & unixTimestamp & ":" & format & ">"
        My.Computer.Clipboard.SetText("<t:" & unixTimestamp & ":" & format & ">")
    End Sub
End Class
