Public Class Form1

    Dim fileName As String = CurDir() & "\atm.txt"
    Dim chequing As Integer
    Dim savings As Integer
    Dim deposit As Boolean
    Dim withdraw As Boolean
    Dim balance As Integer
    Dim pin As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnDeposit.Hide()
        btnWithdraw.Hide()
        btnSavings.Hide()
        btnChequing.Hide()
        btnYes.Hide()
        btnNo.Hide()

    End Sub

    Private Sub btnInsertCard_Click(sender As Object, e As EventArgs) Handles btnInsertCard.Click

        If System.IO.File.Exists(fileName) Then
            Dim fileReader As New System.IO.StreamReader(fileName)
            pin = fileReader.ReadLine
            balance = fileReader.ReadLine
            Dim theirGuess = InputBox("Please Enter you PIN")
            Do While theirGuess <> pin
                theirGuess = InputBox("Sorry that was not what I was looking for." & vbCrLf & "Please Enter your PIN")
            Loop
            balance = fileReader.ReadLine
            fileReader.Close()
        Else
            lblAtmScreen.Text = "Hang on a sec we are experiencing some Technical Difficulties."

            Exit Sub
        End If
        lblAtmScreen.Text = "Hello there, what would you like to do today?"
        btnWithdraw.Show()
        btnDeposit.Show()
        btnInsertCard.Hide()

    End Sub

    Private Sub btnWithdraw_Click(sender As Object, e As EventArgs) Handles btnWithdraw.Click

        lblAtmScreen.Text = "How much would you like to withdraw?" & vbCrLf & "Please Enter the amount in the Text Box below and press enter."
        btnDeposit.Hide()
        btnChequing.Show()
        btnSavings.Show()
        deposit = False
        withdraw = True

    End Sub

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click

        lblAtmScreen.Text = "Which account would you like to Deposit into?"
        btnWithdraw.Hide()
        btnChequing.Show()
        btnSavings.Show()
        deposit = True
        withdraw = False

    End Sub


    Private Sub btnSavings_Click(sender As Object, e As EventArgs) Handles btnSavings.Click

        lblAtmScreen.Text = "How much would you like to deposit?" & vbCrLf & "Please Enter the amount in the Text Box below and press enter."
        btnChequing.Hide()
        btnWithdraw.Hide()
        btnDeposit.Hide()

    End Sub

    Private Sub btnChequing_Click(sender As Object, e As EventArgs) Handles btnChequing.Click

        lblAtmScreen.Text = "How much would you like to deposit?" & vbCrLf & "Please Enter the amount in the Text Box below and press enter."
        btnSavings.Hide()
        btnWithdraw.Hide()
        btnDeposit.Hide()

    End Sub

    Private Sub tbAmountBox_KeyUp(sender As Object, e As KeyEventArgs) Handles tbAmountBox.KeyUp

        Me.Text = e.KeyCode
        If e.KeyCode = 13 Then
            If deposit Then
                balance += Val(tbAmountBox.Text)
                Dim fileWriter As New System.IO.StreamWriter(fileName)
                fileWriter.WriteLine(pin)
                fileWriter.WriteLine(balance)
                fileWriter.Close()
                lblAtmScreen.Text = "You Balance is now: " & balance & vbCrLf & "Would you like to do another transactions?"
                btnYes.Show()
                btnNo.Show()
            ElseIf withdraw Then
                balance -= Val(tbAmountBox.Text)
                Dim fileWriter As New System.IO.StreamWriter(fileName)
                fileWriter.WriteLine(pin)
                fileWriter.WriteLine(balance)
                fileWriter.Close()
                lblAtmScreen.Text = "You Balance is now: " & balance & vbCrLf & "Would you like to do another transactions?"
                btnYes.Show()
                btnNo.Show()
            End If
        End If

    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        Me.Hide()
        Form2.Show()

    End Sub
End Class
