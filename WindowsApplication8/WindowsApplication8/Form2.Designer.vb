<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblAtmReciept = New System.Windows.Forms.Label()
        Me.btnCloseAtm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAtmReciept
        '
        Me.lblAtmReciept.BackColor = System.Drawing.Color.Black
        Me.lblAtmReciept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAtmReciept.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAtmReciept.ForeColor = System.Drawing.Color.Red
        Me.lblAtmReciept.Location = New System.Drawing.Point(12, 9)
        Me.lblAtmReciept.Name = "lblAtmReciept"
        Me.lblAtmReciept.Size = New System.Drawing.Size(260, 297)
        Me.lblAtmReciept.TabIndex = 1
        Me.lblAtmReciept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCloseAtm
        '
        Me.btnCloseAtm.BackColor = System.Drawing.Color.Maroon
        Me.btnCloseAtm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseAtm.ForeColor = System.Drawing.Color.Red
        Me.btnCloseAtm.Location = New System.Drawing.Point(172, 314)
        Me.btnCloseAtm.Name = "btnCloseAtm"
        Me.btnCloseAtm.Size = New System.Drawing.Size(100, 35)
        Me.btnCloseAtm.TabIndex = 2
        Me.btnCloseAtm.Text = "Close ATM"
        Me.btnCloseAtm.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(284, 361)
        Me.Controls.Add(Me.btnCloseAtm)
        Me.Controls.Add(Me.lblAtmReciept)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblAtmReciept As System.Windows.Forms.Label
    Friend WithEvents btnCloseAtm As System.Windows.Forms.Button
End Class
