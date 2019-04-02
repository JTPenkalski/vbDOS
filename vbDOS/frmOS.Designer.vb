<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOS
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

    Private Sub InitializeComponent()
        Me.txtCommand = New System.Windows.Forms.TextBox()
        Me.txtDOS = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCommand
        '
        Me.txtCommand.BackColor = System.Drawing.Color.DimGray
        Me.txtCommand.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCommand.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommand.ForeColor = System.Drawing.Color.White
        Me.txtCommand.Location = New System.Drawing.Point(5, 379)
        Me.txtCommand.Name = "txtCommand"
        Me.txtCommand.Size = New System.Drawing.Size(774, 29)
        Me.txtCommand.TabIndex = 3
        '
        'txtDOS
        '
        Me.txtDOS.BackColor = System.Drawing.Color.Black
        Me.txtDOS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDOS.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOS.ForeColor = System.Drawing.Color.White
        Me.txtDOS.Location = New System.Drawing.Point(5, 3)
        Me.txtDOS.Multiline = True
        Me.txtDOS.Name = "txtDOS"
        Me.txtDOS.ReadOnly = True
        Me.txtDOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDOS.Size = New System.Drawing.Size(776, 370)
        Me.txtDOS.TabIndex = 4
        Me.txtDOS.Text = "© 2016 Justin Penkalski. All Rights Reserved." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">>C://User/system32/DOS/terminal.e" & _
            "xe" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ">>Enter 'help' for command list."
        '
        'frmOS
        '
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(784, 412)
        Me.Controls.Add(Me.txtCommand)
        Me.Controls.Add(Me.txtDOS)
        Me.Name = "frmOS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visual Basic DOS ©"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDOS As System.Windows.Forms.TextBox
    Friend WithEvents txtCommand As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    '////////////////////////////////////////////////////MY CODE STARTS HERE////////////////////////////////////////////////
    'Justin Penkalski 2016
    'vbDOS - A simulated command prompt with various system commands.

    'Public Variables.
    Public strUsername As String
    Public strCustomDOSName As String
    Public strBackColor As String
    Public strForeColor As String
    Public strFont As String
    Public strCursor As String
    Public strMeMessage As String
    Public strReadStyle As String
    Public strRandomGuess As String

    Public intGuessCount As Integer
    Public intMathList As Integer
    Public intMathListStep As Integer
    Public intRandomGuess As Integer
    Public intRandomNum As Integer

    Public decOpacity As Decimal

    Public bProfileLoggedOn As Boolean

    Private Sub txtCommand_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCommand.Click

        'Clears text.
            txtCommand.Text = String.Empty

    End Sub

    Private Sub txtCommand_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCommand.KeyDown

        'Class Variables.
        Dim strCommand As String

        strCommand = txtCommand.Text.ToLower.Trim

        'Register Command.
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtDOS.Text = txtDOS.Text & vbNewLine & ">>" & strCommand
            txtCommand.Clear()

            'Commands.
            Select Case strCommand
                Case "help"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "Valid list of DOS protocol: " & vbNewLine & _
                    "backcolor : changes backcolor of DOS Window" & vbNewLine & _
                    "bits : displays system bits" & vbNewLine & _
                    "clear : clears the DOS log" & vbNewLine & _
                    "cursor : changes the cursor" & vbNewLine & _
                    "exit : exits the DOS" & vbNewLine & _
                    "forecolor : changes forecolor of DOS Window" & vbNewLine & _
                    "guessgame : guess a random number and see if you win" & vbNewLine & _
                    "math_list : displays the first 10 multiples of the entered number" & vbNewLine & _
                    "me : adds a 'me message' to the preset username" & vbNewLine & _
                    "minimize : minimizes the DOS Window" & vbNewLine & _
                    "opacity : changes DOS Window opacity" & vbNewLine & _
                    "profile_log_on : log on to a profile with a preset username" & vbNewLine & _
                    "rename : add a custom title to the DOS system" & vbNewLine & _
                    "system : displays system information" & vbNewLine & _
                    "username : set a username to the system"
                Case "username"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "Enter a new username: "
                    strUsername = InputBox("Please enter a new username.")
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & "Username " & strUsername & " stored in system."
                Case "profile_log_on"
                    If strUsername = "" Then
                        txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "No username profile set."
                    ElseIf strUsername <> "" Then
                        txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "User " & strUsername & " has logged on to the DOS system."
                    End If
                Case "exit"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text
                    Me.Close()
                Case "math_list"
                    intMathListStep = 0
                    intMathList = InputBox("Please enter a number to display multiples")
                    For Me.intMathListStep = 1 To 10 Step 0.5
                        txtDOS.Text = txtDOS.Text & vbNewLine & (intMathList * intMathListStep)
                        intMathListStep = intMathListStep + 1
                    Next
                Case "clear"
                    txtDOS.Text = "© 2016 Justin Penkalski. All Rights Reserved." & vbNewLine & ">>C://User/system32/DOS/terminal.exe" & vbNewLine & "Log successfully cleared!"
                Case "bits"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "System registered with 32-bits."
                Case "system"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "System Log:" & vbNewLine & _
                    "OS: Windows 7 Professional" & vbNewLine & _
                    "Command System: vbDOS" & vbNewLine & _
                    "Command Version: vbDOS 1.0" & vbNewLine & _
                    "Default Internet: Internet Explorer 11" & vbNewLine & _
                    "IP - Public: 75.9.81.146" & vbNewLine & _
                    "IPv4: 192.168.1.1" & vbNewLine & _
                    "Monitor: HP Compaq LE19f - 19'' - 60Hz Refresh"
                Case "rename"
                    strCustomDOSName = InputBox("Please enter a custom title for the DOS system.")
                    Me.Text = "Visual Basic DOS © - " & strCustomDOSName
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "Custom title successfully added!"
                Case "opacity"
                    decOpacity = InputBox("Please enter a new opacity for the DOS system. (Use Decimal Format)")
                    Me.Opacity = decOpacity
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "DOS opacity successfully changed!"
                Case "backcolor"
                    strBackColor = InputBox("Please enter a new back color for the DOS Window.")
                    If LCase(strBackColor) = "red" Then
                        txtDOS.BackColor = Color.Red
                        Me.BackColor = Color.Red
                    ElseIf LCase(strBackColor) = "orange" Then
                        txtDOS.BackColor = Color.Orange
                        Me.BackColor = Color.Orange
                    ElseIf LCase(strBackColor) = "yellow" Then
                        txtDOS.BackColor = Color.Yellow
                        Me.BackColor = Color.Yellow
                    ElseIf LCase(strBackColor) = "green" Then
                        txtDOS.BackColor = Color.Green
                        Me.BackColor = Color.Green
                    ElseIf LCase(strBackColor) = "lime_green" Then
                        txtDOS.BackColor = Color.Lime
                        Me.BackColor = Color.Lime
                    ElseIf LCase(strBackColor) = "blue" Then
                        txtDOS.BackColor = Color.Blue
                        Me.BackColor = Color.Blue
                    ElseIf LCase(strBackColor) = "purple" Then
                        txtDOS.BackColor = Color.Purple
                        Me.BackColor = Color.Purple
                    ElseIf LCase(strBackColor) = "pink" Then
                        txtDOS.BackColor = Color.Pink
                        Me.BackColor = Color.Pink
                    ElseIf LCase(strBackColor) = "white" Then
                        txtDOS.BackColor = Color.White
                        Me.BackColor = Color.White
                    ElseIf LCase(strBackColor) = "gray" Then
                        txtDOS.BackColor = Color.Gray
                        Me.BackColor = Color.Gray
                    ElseIf LCase(strBackColor) = "black" Then
                        txtDOS.BackColor = Color.Black
                        Me.BackColor = Color.Black
                    End If
                Case "forecolor"
                    strForeColor = InputBox("Please enter a new fore color for the DOS Window.")
                    If LCase(strForeColor) = "red" Then
                        txtDOS.ForeColor = Color.Red
                        Me.ForeColor = Color.Red
                    ElseIf LCase(strForeColor) = "orange" Then
                        txtDOS.ForeColor = Color.Orange
                        Me.ForeColor = Color.Orange
                    ElseIf LCase(strForeColor) = "yellow" Then
                        txtDOS.ForeColor = Color.Yellow
                        Me.ForeColor = Color.Yellow
                    ElseIf LCase(strForeColor) = "green" Then
                        txtDOS.ForeColor = Color.Green
                        Me.ForeColor = Color.Green
                    ElseIf LCase(strForeColor) = "lime_green" Then
                        txtDOS.ForeColor = Color.Lime
                        Me.ForeColor = Color.Lime
                    ElseIf LCase(strForeColor) = "blue" Then
                        txtDOS.ForeColor = Color.Blue
                        Me.ForeColor = Color.Blue
                    ElseIf LCase(strForeColor) = "purple" Then
                        txtDOS.ForeColor = Color.Purple
                        Me.ForeColor = Color.Purple
                    ElseIf LCase(strForeColor) = "pink" Then
                        txtDOS.ForeColor = Color.Pink
                        Me.ForeColor = Color.Pink
                    ElseIf LCase(strForeColor) = "white" Then
                        txtDOS.ForeColor = Color.White
                        Me.ForeColor = Color.White
                    ElseIf LCase(strForeColor) = "gray" Then
                        txtDOS.ForeColor = Color.Gray
                        Me.ForeColor = Color.Gray
                    ElseIf LCase(strForeColor) = "black" Then
                        txtDOS.ForeColor = Color.Black
                        Me.ForeColor = Color.Black
                    End If
                Case "minimize"
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "DOS Window State set to Minimized."
                    Me.WindowState = FormWindowState.Minimized
                Case "cursor"
                    strCursor = InputBox("Please enter a new cursor for the DOS Window.")
                    If LCase(strCursor) = "cross" Then
                        Me.Cursor = Cursors.Cross
                    ElseIf LCase(strCursor) = "default" Then
                        Me.Cursor = Cursors.Default
                    ElseIf LCase(strCursor) = "hand" Then
                        Me.Cursor = Cursors.Hand
                    ElseIf LCase(strCursor) = "ibeam" Then
                        Me.Cursor = Cursors.IBeam
                    ElseIf LCase(strCursor) = "no" Then
                        Me.Cursor = Cursors.No
                    ElseIf LCase(strCursor) = "resize" Then
                        Me.Cursor = Cursors.SizeAll
                    ElseIf LCase(strCursor) = "split" Then
                        Me.Cursor = Cursors.VSplit
                    ElseIf LCase(strCursor) = "wait" Then
                        Me.Cursor = Cursors.WaitCursor
                    End If
                    txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "DOS Window Cursor successfully changed!"
                Case "me"
                    If strUsername = "" Then
                        txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & txtCommand.Text & "No username profile set."
                    ElseIf strUsername <> "" Then
                        strMeMessage = InputBox("Please enter a 'me message', following the username prompt.")
                        txtDOS.Text = txtDOS.Text & vbNewLine & vbNewLine & strUsername & " " & strMeMessage & "."
                    End If
                Case "guessgame" 'Creates a random number, then asks for user input. Compares the answers at the end.
                    intRandomNum = Int((10) * Rnd()) + 1

                    strRandomGuess = InputBox("Guess a Number Between 1-10", "Guess:")
                    Integer.TryParse(strRandomGuess, intRandomGuess)

                    txtDOS.Text = txtDOS.Text & vbNewLine & "Your Guess: " & intRandomGuess

                    If intRandomGuess = intRandomNum Then
                        txtDOS.Text = txtDOS.Text & vbNewLine & "You Win! The number was: " & intRandomNum
                        txtCommand.Text = "You Win!"
                    Else
                        txtDOS.Text = txtDOS.Text & vbNewLine & "You Lose! The number was actually: " & intRandomNum
                        txtCommand.Text = "You Lose!"
                    End If

                    Do While intGuessCount <= 7
                        If txtCommand.BackColor = Color.DimGray Then
                            txtCommand.BackColor = Color.Silver
                        Else
                            txtCommand.BackColor = Color.DimGray
                        End If

                        Me.Refresh()
                        System.Threading.Thread.Sleep(400)

                        intGuessCount = intGuessCount + 1
                    Loop
                Case Else
                    txtDOS.Text = txtDOS.Text & vbNewLine & ">>'" & strCommand & "' is not a valid command. Type 'help' for more information."
            End Select
        End If
    End Sub

    Private Sub txtCommand_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCommand.KeyPress

        'Only allows characters.
        If (e.KeyChar >= "0" And e.KeyChar <= "9") And e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

    Private Sub frmOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Changes Color Scheme.
        If intColorScheme = 0 Then
            Me.BackColor = Color.Black
            txtDOS.BackColor = Color.Black
            txtDOS.ForeColor = Color.White
        ElseIf intColorScheme = 1 Then
            Me.BackColor = Color.Black
            txtDOS.BackColor = Color.Black
            txtDOS.ForeColor = Color.Lime
        ElseIf intColorScheme = 2 Then
            Me.BackColor = Color.Blue
            txtDOS.BackColor = Color.Blue
            txtDOS.ForeColor = Color.Yellow
        End If

    End Sub
End Class