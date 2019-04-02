<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoading
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
        Me.lblBar = New System.Windows.Forms.Label()
        Me.tmrMovement = New System.Windows.Forms.Timer(Me.components)
        Me.lblText = New System.Windows.Forms.Label()
        Me.lblLeft = New System.Windows.Forms.Label()
        Me.lblRight = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBar
        '
        Me.lblBar.BackColor = System.Drawing.Color.White
        Me.lblBar.Location = New System.Drawing.Point(17, 81)
        Me.lblBar.Name = "lblBar"
        Me.lblBar.Size = New System.Drawing.Size(50, 50)
        Me.lblBar.TabIndex = 0
        '
        'tmrMovement
        '
        Me.tmrMovement.Interval = 10
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.Transparent
        Me.lblText.Font = New System.Drawing.Font("Biondi", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText.ForeColor = System.Drawing.Color.White
        Me.lblText.Location = New System.Drawing.Point(0, 1)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(355, 73)
        Me.lblText.TabIndex = 1
        Me.lblText.Text = "Loading. . ."
        '
        'lblLeft
        '
        Me.lblLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblLeft.Location = New System.Drawing.Point(7, 74)
        Me.lblLeft.Name = "lblLeft"
        Me.lblLeft.Size = New System.Drawing.Size(10, 67)
        Me.lblLeft.TabIndex = 2
        '
        'lblRight
        '
        Me.lblRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lblRight.Location = New System.Drawing.Point(350, 74)
        Me.lblRight.Name = "lblRight"
        Me.lblRight.Size = New System.Drawing.Size(10, 67)
        Me.lblRight.TabIndex = 3
        '
        'frmLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(367, 153)
        Me.Controls.Add(Me.lblRight)
        Me.Controls.Add(Me.lblLeft)
        Me.Controls.Add(Me.lblBar)
        Me.Controls.Add(Me.lblText)
        Me.Name = "frmLoading"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DOS Loading. . ."
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblBar As System.Windows.Forms.Label
    Friend WithEvents tmrMovement As System.Windows.Forms.Timer
    Friend WithEvents lblText As System.Windows.Forms.Label
    Friend WithEvents lblLeft As System.Windows.Forms.Label
    Friend WithEvents lblRight As System.Windows.Forms.Label
End Class
