Public Class Form2

    Dim fileName As String = CurDir() & "\atm.txt"
    Dim balance As Integer
    Dim pin As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(fileName) Then
            Dim fileReader As New System.IO.StreamReader(fileName)
            pin = fileReader.ReadLine
            balance = fileReader.ReadLine
            lblAtmReciept.Text = "You Balance is now: " & balance
        End If
    End Sub

    Private Sub btnCloseAtm_Click(sender As Object, e As EventArgs) Handles btnCloseAtm.Click
        Form1.Dispose()
        Me.Dispose()
    End Sub

End Class