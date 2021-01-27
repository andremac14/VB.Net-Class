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
        Me.lbl_InputPassword = New System.Windows.Forms.Label()
        Me.lbl_ThePasswordIs = New System.Windows.Forms.Label()
        Me.txt_InputPassword = New System.Windows.Forms.TextBox()
        Me.txt_thePasswordIs = New System.Windows.Forms.TextBox()
        Me.btn_Set = New System.Windows.Forms.Button()
        Me.btn_Guess = New System.Windows.Forms.Button()
        Me.btn_Quit = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_InputPassword
        '
        Me.lbl_InputPassword.AutoSize = True
        Me.lbl_InputPassword.Location = New System.Drawing.Point(212, 56)
        Me.lbl_InputPassword.Name = "lbl_InputPassword"
        Me.lbl_InputPassword.Size = New System.Drawing.Size(83, 13)
        Me.lbl_InputPassword.TabIndex = 0
        Me.lbl_InputPassword.Text = "Input Password:"
        '
        'lbl_ThePasswordIs
        '
        Me.lbl_ThePasswordIs.AutoSize = True
        Me.lbl_ThePasswordIs.Location = New System.Drawing.Point(207, 228)
        Me.lbl_ThePasswordIs.Name = "lbl_ThePasswordIs"
        Me.lbl_ThePasswordIs.Size = New System.Drawing.Size(88, 13)
        Me.lbl_ThePasswordIs.TabIndex = 1
        Me.lbl_ThePasswordIs.Text = "The Password is:"
        '
        'txt_InputPassword
        '
        Me.txt_InputPassword.Location = New System.Drawing.Point(301, 53)
        Me.txt_InputPassword.Name = "txt_InputPassword"
        Me.txt_InputPassword.Size = New System.Drawing.Size(100, 20)
        Me.txt_InputPassword.TabIndex = 2
        '
        'txt_thePasswordIs
        '
        Me.txt_thePasswordIs.Location = New System.Drawing.Point(301, 225)
        Me.txt_thePasswordIs.Name = "txt_thePasswordIs"
        Me.txt_thePasswordIs.Size = New System.Drawing.Size(100, 20)
        Me.txt_thePasswordIs.TabIndex = 3
        '
        'btn_Set
        '
        Me.btn_Set.Location = New System.Drawing.Point(301, 109)
        Me.btn_Set.Name = "btn_Set"
        Me.btn_Set.Size = New System.Drawing.Size(100, 23)
        Me.btn_Set.TabIndex = 4
        Me.btn_Set.Text = "Set Password"
        Me.btn_Set.UseVisualStyleBackColor = True
        '
        'btn_Guess
        '
        Me.btn_Guess.Location = New System.Drawing.Point(301, 176)
        Me.btn_Guess.Name = "btn_Guess"
        Me.btn_Guess.Size = New System.Drawing.Size(100, 23)
        Me.btn_Guess.TabIndex = 5
        Me.btn_Guess.Text = "Guess Password"
        Me.btn_Guess.UseVisualStyleBackColor = True
        '
        'btn_Quit
        '
        Me.btn_Quit.Location = New System.Drawing.Point(326, 317)
        Me.btn_Quit.Name = "btn_Quit"
        Me.btn_Quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Quit.TabIndex = 6
        Me.btn_Quit.Text = "Quit"
        Me.btn_Quit.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(210, 317)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_Reset.TabIndex = 7
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Quit)
        Me.Controls.Add(Me.btn_Guess)
        Me.Controls.Add(Me.btn_Set)
        Me.Controls.Add(Me.txt_thePasswordIs)
        Me.Controls.Add(Me.txt_InputPassword)
        Me.Controls.Add(Me.lbl_ThePasswordIs)
        Me.Controls.Add(Me.lbl_InputPassword)
        Me.Name = "Form1"
        Me.Text = "Lab 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_InputPassword As Label
    Friend WithEvents lbl_ThePasswordIs As Label
    Friend WithEvents txt_InputPassword As TextBox
    Friend WithEvents txt_thePasswordIs As TextBox
    Friend WithEvents btn_Set As Button
    Friend WithEvents btn_Guess As Button
    Friend WithEvents btn_Quit As Button
    Friend WithEvents btn_Reset As Button
End Class
