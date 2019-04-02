<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.lblText = New System.Windows.Forms.Label()
        Me.radTraditional = New System.Windows.Forms.RadioButton()
        Me.radHacker = New System.Windows.Forms.RadioButton()
        Me.radTerminal = New System.Windows.Forms.RadioButton()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblText.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(12, 9)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(212, 74)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Choose a Color Scheme for the DOS."
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'radTraditional
        '
        Me.radTraditional.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radTraditional.Checked = True
        Me.radTraditional.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTraditional.Location = New System.Drawing.Point(12, 129)
        Me.radTraditional.Name = "radTraditional"
        Me.radTraditional.Size = New System.Drawing.Size(212, 46)
        Me.radTraditional.TabIndex = 1
        Me.radTraditional.TabStop = True
        Me.radTraditional.Text = "Traditional " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Black/White)"
        Me.radTraditional.UseVisualStyleBackColor = False
        '
        'radHacker
        '
        Me.radHacker.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radHacker.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radHacker.Location = New System.Drawing.Point(12, 181)
        Me.radHacker.Name = "radHacker"
        Me.radHacker.Size = New System.Drawing.Size(212, 46)
        Me.radHacker.TabIndex = 2
        Me.radHacker.Text = "Hacker " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Black/Green)"
        Me.radHacker.UseVisualStyleBackColor = False
        '
        'radTerminal
        '
        Me.radTerminal.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.radTerminal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTerminal.Location = New System.Drawing.Point(12, 232)
        Me.radTerminal.Name = "radTerminal"
        Me.radTerminal.Size = New System.Drawing.Size(212, 46)
        Me.radTerminal.TabIndex = 3
        Me.radTerminal.Text = "Terminal" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Blue/Yellow)"
        Me.radTerminal.UseVisualStyleBackColor = False
        '
        'lblText2
        '
        Me.lblText2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblText2.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.ForeColor = System.Drawing.Color.White
        Me.lblText2.Location = New System.Drawing.Point(12, 90)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(212, 32)
        Me.lblText2.TabIndex = 4
        Me.lblText2.Text = "(This can be changed later)"
        Me.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinue
        '
        Me.btnContinue.BackColor = System.Drawing.Color.Gray
        Me.btnContinue.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnContinue.Location = New System.Drawing.Point(28, 289)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(177, 36)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = False
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(236, 335)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.radTerminal)
        Me.Controls.Add(Me.radHacker)
        Me.Controls.Add(Me.radTraditional)
        Me.Controls.Add(Me.lblText)
        Me.Name = "frmOptions"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Scheme"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents radTraditional As System.Windows.Forms.RadioButton
    Friend WithEvents radHacker As System.Windows.Forms.RadioButton
    Friend WithEvents radTerminal As System.Windows.Forms.RadioButton
    Friend WithEvents lblText2 As System.Windows.Forms.Label
    Friend WithEvents btnContinue As System.Windows.Forms.Button
End Class
