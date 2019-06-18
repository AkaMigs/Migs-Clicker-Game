Public Class Form1
    Dim RNG As New Random
    Dim fileName As String = CurDir() & "\highscore.txt"
    Dim highscore As Integer
    Dim playername As String
    Dim lives(50) As PictureBox
    Dim livesCounter As Integer
    Dim alienBeenHit As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(fileName) Then
            Dim fileReader As New System.IO.StreamReader(fileName)
            highscore = fileReader.ReadLine
            playername = fileReader.ReadLine
            lblHighScore.Text = highscore
            lblPlayerName.Text = playername
            livesCounter = -1
            makeLivesCounter()
            pbNormalTarget.Height = 200
            pbNormalTarget.Width = 200
            pbSpecialTarget.Hide()
            normalTargetTimer.Stop()
            alienBeenHit = True
            pbSpecialTarget.Left = RNG.Next(pbPlayingField.Left, pbPlayingField.Right - pbSpecialTarget.Width)
            pbSpecialTarget.Top = RNG.Next(pbPlayingField.Top, pbPlayingField.Bottom - pbSpecialTarget.Height)
        End If

    End Sub



    Private Sub pbNormalTarget_Click(sender As Object, e As EventArgs) Handles pbNormalTarget.Click

        pbNormalTarget.Left = RNG.Next(pbPlayingField.Left, pbPlayingField.Right - pbNormalTarget.Width)
        pbNormalTarget.Top = RNG.Next(pbPlayingField.Top, pbPlayingField.Bottom - pbNormalTarget.Height)
        lblStartInfo.Hide()
        lblPoints.Text += 1
        normalTargetTimer.Start()
        If pbNormalTarget.Height >= 0 Then
            pbNormalTarget.Height -= 3%
            pbNormalTarget.Width -= 3%
        End If
        If pbNormalTarget.Height >= 175 Then
            normalTargetTimer.Interval = 200
            If pbNormalTarget.Height >= 100 And pbNormalTarget.Height <= 175 Then
                normalTargetTimer.Interval = 150
            Else
                normalTargetTimer.Interval = 100
            End If

            If lblLives.Text <= 0 Then
                If lblPoints.Text > highscore Then
                    highscore = lblPoints.Text
                    playername = InputBox("Enter your Name")
                    Me.Text = playername
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(highscore)
                    fileWriter.WriteLine(playername)
                    fileWriter.Close()
                    MsgBox("Game Over")
                    Me.Dispose()
                Else
                    MsgBox("Game Over")
                    Me.Dispose()
                End If
            End If
        End If

    End Sub

    Sub makeLivesCounter()

        For i = 0 To 2
            livesCounter += 1
            Me.Text = livesCounter
            lives(i) = New PictureBox
            With lives(i)
                .Top = 4
                .Left = 602 + i * 60
                .Width = 50
                .Height = 50
                .Image = pbHearts.Image
                .BackColor = Color.Transparent
                .SizeMode = PictureBoxSizeMode.Zoom
                .BringToFront()
            End With
            Me.Controls.Add(lives(i))
        Next

    End Sub

    Private Sub normalTargetTimer_Tick(sender As Object, e As EventArgs) Handles normalTargetTimer.Tick

        pgbNormalTarget.Value += 1
        If pgbNormalTarget.Value >= pgbNormalTarget.Maximum - RNG.Next(10%, 16%) And alienBeenHit Then
            pbSpecialTarget.Show()
        Else
            pbSpecialTarget.Hide()
        End If
        If pgbNormalTarget.Value >= pgbNormalTarget.Maximum - 1 Then
            pgbNormalTarget.Value = 0
            normalTargetTimer.Stop()
            MsgBox("Click UFO to use next life")
            lblLives.Text -= 1
            lives(livesCounter).Hide()
            livesCounter -= 1
            If lblLives.Text <= 0 Then
                If lblPoints.Text > highscore Then
                    highscore = lblPoints.Text
                    playername = InputBox("Enter your Name(max. 9 Characters)")
                    Me.Text = playername
                    Dim fileWriter As New System.IO.StreamWriter(fileName)
                    fileWriter.WriteLine(highscore)
                    fileWriter.WriteLine(playername)
                    fileWriter.Close()
                    MsgBox("Game Over")
                    Me.Dispose()
                Else
                    MsgBox("Game Over")
                    Me.Dispose()
                End If
            End If
        End If

    End Sub

    Private Sub pbPlayingField_Click_1(sender As Object, e As EventArgs) Handles pbPlayingField.Click

        normalTargetTimer.Stop()
        MsgBox("Click UFO to use next life")
        pgbNormalTarget.Value = 0
        lblLives.Text -= 1
        lives(livesCounter).Hide()
        livesCounter -= 1
        If lblLives.Text <= 0 Then
            If lblPoints.Text > highscore Then
                highscore = lblPoints.Text
                playername = InputBox("Enter your Name")
                Me.Text = playername
                Dim fileWriter As New System.IO.StreamWriter(fileName)
                fileWriter.WriteLine(highscore)
                fileWriter.WriteLine(playername)
                fileWriter.Close()
                MsgBox("Game Over")
                Me.Dispose()
            Else
                MsgBox("Game Over")
                Me.Dispose()
            End If
        End If

    End Sub

    Private Sub pbSpecialTarget_Click(sender As Object, e As EventArgs) Handles pbSpecialTarget.Click

        pbNormalTarget.Left = RNG.Next(pbPlayingField.Left, pbPlayingField.Right - pbNormalTarget.Width)
        pbNormalTarget.Top = RNG.Next(pbPlayingField.Top, pbPlayingField.Bottom - pbNormalTarget.Height)
        alienBeenHit = False
        pbSpecialTarget.Hide()
        lblPoints.Text += 6

    End Sub
End Class
