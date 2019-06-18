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
        Me.lblTitleCard = New System.Windows.Forms.Label()
        Me.btnInsertCard = New System.Windows.Forms.Button()
        Me.btnWithdraw = New System.Windows.Forms.Button()
        Me.btnDeposit = New System.Windows.Forms.Button()
        Me.lblAtmScreen = New System.Windows.Forms.Label()
        Me.tbAmountBox = New System.Windows.Forms.TextBox()
        Me.btnSavings = New System.Windows.Forms.Button()
        Me.btnChequing = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitleCard
        '
        Me.lblTitleCard.Font = New System.Drawing.Font("Trajan Pro", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitleCard.ForeColor = System.Drawing.Color.Red
        Me.lblTitleCard.Location = New System.Drawing.Point(229, 7)
        Me.lblTitleCard.Name = "lblTitleCard"
        Me.lblTitleCard.Size = New System.Drawing.Size(350, 25)
        Me.lblTitleCard.TabIndex = 0
        Me.lblTitleCard.Text = "The Blood Bank"
        Me.lblTitleCard.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnInsertCard
        '
        Me.btnInsertCard.BackColor = System.Drawing.Color.Maroon
        Me.btnInsertCard.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInsertCard.ForeColor = System.Drawing.Color.Red
        Me.btnInsertCard.Location = New System.Drawing.Point(572, 524)
        Me.btnInsertCard.Name = "btnInsertCard"
        Me.btnInsertCard.Size = New System.Drawing.Size(200, 30)
        Me.btnInsertCard.TabIndex = 1
        Me.btnInsertCard.Text = "Insert Card Here"
        Me.btnInsertCard.UseVisualStyleBackColor = False
        '
        'btnWithdraw
        '
        Me.btnWithdraw.BackColor = System.Drawing.Color.Maroon
        Me.btnWithdraw.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdraw.ForeColor = System.Drawing.Color.Red
        Me.btnWithdraw.Location = New System.Drawing.Point(654, 292)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Size = New System.Drawing.Size(125, 50)
        Me.btnWithdraw.TabIndex = 2
        Me.btnWithdraw.Text = "Withdraw"
        Me.btnWithdraw.UseVisualStyleBackColor = False
        '
        'btnDeposit
        '
        Me.btnDeposit.BackColor = System.Drawing.Color.Maroon
        Me.btnDeposit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDeposit.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeposit.ForeColor = System.Drawing.Color.Red
        Me.btnDeposit.Location = New System.Drawing.Point(654, 348)
        Me.btnDeposit.Name = "btnDeposit"
        Me.btnDeposit.Size = New System.Drawing.Size(125, 50)
        Me.btnDeposit.TabIndex = 3
        Me.btnDeposit.Text = "Deposit"
        Me.btnDeposit.UseVisualStyleBackColor = False
        '
        'lblAtmScreen
        '
        Me.lblAtmScreen.BackColor = System.Drawing.SystemColors.InfoText
        Me.lblAtmScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAtmScreen.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtmScreen.ForeColor = System.Drawing.Color.Red
        Me.lblAtmScreen.Location = New System.Drawing.Point(148, 48)
        Me.lblAtmScreen.Name = "lblAtmScreen"
        Me.lblAtmScreen.Size = New System.Drawing.Size(500, 350)
        Me.lblAtmScreen.TabIndex = 4
        Me.lblAtmScreen.Text = "Welcome, what would you like to do today?"
        Me.lblAtmScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbAmountBox
        '
        Me.tbAmountBox.BackColor = System.Drawing.Color.Maroon
        Me.tbAmountBox.ForeColor = System.Drawing.Color.OrangeRed
        Me.tbAmountBox.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.tbAmountBox.Location = New System.Drawing.Point(278, 401)
        Me.tbAmountBox.Name = "tbAmountBox"
        Me.tbAmountBox.Size = New System.Drawing.Size(250, 20)
        Me.tbAmountBox.TabIndex = 5
        Me.tbAmountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSavings
        '
        Me.btnSavings.BackColor = System.Drawing.Color.Maroon
        Me.btnSavings.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavings.ForeColor = System.Drawing.Color.Red
        Me.btnSavings.Location = New System.Drawing.Point(654, 180)
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Size = New System.Drawing.Size(125, 50)
        Me.btnSavings.TabIndex = 7
        Me.btnSavings.Text = "Savings"
        Me.btnSavings.UseVisualStyleBackColor = False
        '
        'btnChequing
        '
        Me.btnChequing.BackColor = System.Drawing.Color.Maroon
        Me.btnChequing.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChequing.ForeColor = System.Drawing.Color.Red
        Me.btnChequing.Location = New System.Drawing.Point(654, 236)
        Me.btnChequing.Name = "btnChequing"
        Me.btnChequing.Size = New System.Drawing.Size(125, 50)
        Me.btnChequing.TabIndex = 8
        Me.btnChequing.Text = "Chequing"
        Me.btnChequing.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.Color.IndianRed
        Me.btnNo.Location = New System.Drawing.Point(423, 427)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(75, 23)
        Me.btnNo.TabIndex = 9
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnYes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnYes.Location = New System.Drawing.Point(304, 427)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(75, 23)
        Me.btnYes.TabIndex = 10
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnChequing)
        Me.Controls.Add(Me.btnSavings)
        Me.Controls.Add(Me.tbAmountBox)
        Me.Controls.Add(Me.lblAtmScreen)
        Me.Controls.Add(Me.btnDeposit)
        Me.Controls.Add(Me.btnWithdraw)
        Me.Controls.Add(Me.btnInsertCard)
        Me.Controls.Add(Me.lblTitleCard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Gray
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitleCard As System.Windows.Forms.Label
    Friend WithEvents btnInsertCard As System.Windows.Forms.Button
    Friend WithEvents btnWithdraw As System.Windows.Forms.Button
    Friend WithEvents btnDeposit As System.Windows.Forms.Button
    Friend WithEvents lblAtmScreen As System.Windows.Forms.Label
    Public WithEvents tbAmountBox As System.Windows.Forms.TextBox
    Friend WithEvents btnSavings As System.Windows.Forms.Button
    Friend WithEvents btnChequing As System.Windows.Forms.Button
    Friend WithEvents btnNo As System.Windows.Forms.Button
    Friend WithEvents btnYes As System.Windows.Forms.Button

End Class
