<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.normalTargetTimer = New System.Windows.Forms.Timer(Me.components)
        Me.pgbNormalTarget = New System.Windows.Forms.ProgressBar()
        Me.pbNormalTarget = New System.Windows.Forms.PictureBox()
        Me.pbPlayingField = New System.Windows.Forms.PictureBox()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.lblYourPoints = New System.Windows.Forms.Label()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.lblHighScoreName = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.pbHearts = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLives = New System.Windows.Forms.Label()
        Me.lblLivesX = New System.Windows.Forms.Label()
        Me.lblPlayerName = New System.Windows.Forms.Label()
        Me.lblTopScorer = New System.Windows.Forms.Label()
        Me.lblStartInfo = New System.Windows.Forms.Label()
        Me.pbSpecialTarget = New System.Windows.Forms.PictureBox()
        CType(Me.pbNormalTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayingField, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbHearts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSpecialTarget, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'normalTargetTimer
        '
        Me.normalTargetTimer.Enabled = True
        '
        'pgbNormalTarget
        '
        Me.pgbNormalTarget.ForeColor = System.Drawing.Color.Lime
        Me.pgbNormalTarget.Location = New System.Drawing.Point(5, 12)
        Me.pgbNormalTarget.Name = "pgbNormalTarget"
        Me.pgbNormalTarget.Size = New System.Drawing.Size(500, 25)
        Me.pgbNormalTarget.TabIndex = 3
        '
        'pbNormalTarget
        '
        Me.pbNormalTarget.BackColor = System.Drawing.Color.Transparent
        Me.pbNormalTarget.Image = Global.WindowsApplication6.My.Resources.Resources._1029113_preview
        Me.pbNormalTarget.Location = New System.Drawing.Point(687, 305)
        Me.pbNormalTarget.Name = "pbNormalTarget"
        Me.pbNormalTarget.Size = New System.Drawing.Size(200, 200)
        Me.pbNormalTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNormalTarget.TabIndex = 0
        Me.pbNormalTarget.TabStop = False
        '
        'pbPlayingField
        '
        Me.pbPlayingField.Image = Global.WindowsApplication6.My.Resources.Resources.Space
        Me.pbPlayingField.Location = New System.Drawing.Point(5, 57)
        Me.pbPlayingField.Name = "pbPlayingField"
        Me.pbPlayingField.Size = New System.Drawing.Size(1575, 800)
        Me.pbPlayingField.TabIndex = 4
        Me.pbPlayingField.TabStop = False
        '
        'lblYourPoints
        '
        Me.lblYourPoints.AutoSize = True
        Me.lblYourPoints.BackColor = System.Drawing.Color.Transparent
        Me.lblYourPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYourPoints.ForeColor = System.Drawing.Color.Snow
        Me.lblYourPoints.Location = New System.Drawing.Point(1177, 12)
        Me.lblYourPoints.Name = "lblYourPoints"
        Me.lblYourPoints.Size = New System.Drawing.Size(142, 25)
        Me.lblYourPoints.TabIndex = 6
        Me.lblYourPoints.Text = "Your Points:"
        '
        'lblPoints
        '
        Me.lblPoints.BackColor = System.Drawing.Color.Transparent
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.ForeColor = System.Drawing.Color.Lime
        Me.lblPoints.Location = New System.Drawing.Point(1325, 6)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(60, 40)
        Me.lblPoints.TabIndex = 7
        Me.lblPoints.Text = "0"
        '
        'lblHighScoreName
        '
        Me.lblHighScoreName.AutoSize = True
        Me.lblHighScoreName.BackColor = System.Drawing.Color.Transparent
        Me.lblHighScoreName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScoreName.ForeColor = System.Drawing.Color.Snow
        Me.lblHighScoreName.Location = New System.Drawing.Point(1386, 32)
        Me.lblHighScoreName.Name = "lblHighScoreName"
        Me.lblHighScoreName.Size = New System.Drawing.Size(89, 16)
        Me.lblHighScoreName.TabIndex = 8
        Me.lblHighScoreName.Text = "High Score:"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.BackColor = System.Drawing.Color.Transparent
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.ForeColor = System.Drawing.Color.Gold
        Me.lblHighScore.Location = New System.Drawing.Point(1481, 33)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(88, 16)
        Me.lblHighScore.TabIndex = 9
        Me.lblHighScore.Text = "0123456789"
        '
        'pbHearts
        '
        Me.pbHearts.BackColor = System.Drawing.Color.Transparent
        Me.pbHearts.Image = Global.WindowsApplication6.My.Resources.Resources.heart
        Me.pbHearts.Location = New System.Drawing.Point(602, 4)
        Me.pbHearts.Name = "pbHearts"
        Me.pbHearts.Size = New System.Drawing.Size(50, 50)
        Me.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbHearts.TabIndex = 10
        Me.pbHearts.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(506, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Lives:"
        '
        'lblLives
        '
        Me.lblLives.AutoSize = True
        Me.lblLives.BackColor = System.Drawing.Color.Transparent
        Me.lblLives.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLives.ForeColor = System.Drawing.Color.LightCoral
        Me.lblLives.Location = New System.Drawing.Point(563, 3)
        Me.lblLives.Name = "lblLives"
        Me.lblLives.Size = New System.Drawing.Size(37, 39)
        Me.lblLives.TabIndex = 12
        Me.lblLives.Text = "3"
        '
        'lblLivesX
        '
        Me.lblLivesX.AutoSize = True
        Me.lblLivesX.BackColor = System.Drawing.Color.Transparent
        Me.lblLivesX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLivesX.ForeColor = System.Drawing.Color.LightCoral
        Me.lblLivesX.Location = New System.Drawing.Point(546, 15)
        Me.lblLivesX.Name = "lblLivesX"
        Me.lblLivesX.Size = New System.Drawing.Size(24, 25)
        Me.lblLivesX.TabIndex = 13
        Me.lblLivesX.Text = "x"
        '
        'lblPlayerName
        '
        Me.lblPlayerName.AutoSize = True
        Me.lblPlayerName.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayerName.ForeColor = System.Drawing.Color.Gold
        Me.lblPlayerName.Location = New System.Drawing.Point(1481, 10)
        Me.lblPlayerName.Name = "lblPlayerName"
        Me.lblPlayerName.Size = New System.Drawing.Size(98, 16)
        Me.lblPlayerName.TabIndex = 14
        Me.lblPlayerName.Text = "ABCDEFGHJ"
        '
        'lblTopScorer
        '
        Me.lblTopScorer.AutoSize = True
        Me.lblTopScorer.BackColor = System.Drawing.Color.Transparent
        Me.lblTopScorer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopScorer.ForeColor = System.Drawing.Color.Snow
        Me.lblTopScorer.Location = New System.Drawing.Point(1385, 9)
        Me.lblTopScorer.Name = "lblTopScorer"
        Me.lblTopScorer.Size = New System.Drawing.Size(90, 16)
        Me.lblTopScorer.TabIndex = 15
        Me.lblTopScorer.Text = "Top Scorer:"
        '
        'lblStartInfo
        '
        Me.lblStartInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblStartInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartInfo.ForeColor = System.Drawing.Color.Snow
        Me.lblStartInfo.Location = New System.Drawing.Point(533, 263)
        Me.lblStartInfo.Name = "lblStartInfo"
        Me.lblStartInfo.Size = New System.Drawing.Size(500, 40)
        Me.lblStartInfo.TabIndex = 16
        Me.lblStartInfo.Text = "Click UFO to start timer"
        Me.lblStartInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbSpecialTarget
        '
        Me.pbSpecialTarget.BackColor = System.Drawing.Color.Transparent
        Me.pbSpecialTarget.BackgroundImage = Global.WindowsApplication6.My.Resources.Resources._1029113_preview
        Me.pbSpecialTarget.Image = Global.WindowsApplication6.My.Resources.Resources._8e6740516ca74065b7304c6a501b358b
        Me.pbSpecialTarget.Location = New System.Drawing.Point(762, 210)
        Me.pbSpecialTarget.Name = "pbSpecialTarget"
        Me.pbSpecialTarget.Size = New System.Drawing.Size(50, 50)
        Me.pbSpecialTarget.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSpecialTarget.TabIndex = 17
        Me.pbSpecialTarget.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication6.My.Resources.Resources.Space
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.pbSpecialTarget)
        Me.Controls.Add(Me.lblStartInfo)
        Me.Controls.Add(Me.lblTopScorer)
        Me.Controls.Add(Me.lblPlayerName)
        Me.Controls.Add(Me.pbNormalTarget)
        Me.Controls.Add(Me.pbPlayingField)
        Me.Controls.Add(Me.lblLives)
        Me.Controls.Add(Me.lblLivesX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pbHearts)
        Me.Controls.Add(Me.pgbNormalTarget)
        Me.Controls.Add(Me.lblHighScore)
        Me.Controls.Add(Me.lblHighScoreName)
        Me.Controls.Add(Me.lblPoints)
        Me.Controls.Add(Me.lblYourPoints)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pbNormalTarget, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayingField, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbHearts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSpecialTarget, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbNormalTarget As System.Windows.Forms.PictureBox
    Friend WithEvents normalTargetTimer As System.Windows.Forms.Timer
    Friend WithEvents pgbNormalTarget As System.Windows.Forms.ProgressBar
    Friend WithEvents pbPlayingField As System.Windows.Forms.PictureBox
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents lblYourPoints As System.Windows.Forms.Label
    Friend WithEvents lblPoints As System.Windows.Forms.Label
    Friend WithEvents lblHighScoreName As System.Windows.Forms.Label
    Friend WithEvents lblHighScore As System.Windows.Forms.Label
    Friend WithEvents pbHearts As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblLives As System.Windows.Forms.Label
    Friend WithEvents lblLivesX As System.Windows.Forms.Label
    Friend WithEvents lblPlayerName As System.Windows.Forms.Label
    Friend WithEvents lblTopScorer As System.Windows.Forms.Label
    Friend WithEvents lblStartInfo As System.Windows.Forms.Label
    Friend WithEvents pbSpecialTarget As System.Windows.Forms.PictureBox

End Class
