<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_Calculate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_Penny = New System.Windows.Forms.TextBox()
        Me.txt_Nickel = New System.Windows.Forms.TextBox()
        Me.txt_Dime = New System.Windows.Forms.TextBox()
        Me.txt_Quarter = New System.Windows.Forms.TextBox()
        Me.txt_HalfDollar = New System.Windows.Forms.TextBox()
        Me.btn_CalculateTotals = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_Quit = New System.Windows.Forms.Button()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of Pennies"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Nickels"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of Dimes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(117, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Number of Quarters"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(103, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of Half Dollars"
        '
        'txt_Penny
        '
        Me.txt_Penny.Location = New System.Drawing.Point(220, 27)
        Me.txt_Penny.Name = "txt_Penny"
        Me.txt_Penny.Size = New System.Drawing.Size(100, 20)
        Me.txt_Penny.TabIndex = 5
        '
        'txt_Nickel
        '
        Me.txt_Nickel.Location = New System.Drawing.Point(220, 83)
        Me.txt_Nickel.Name = "txt_Nickel"
        Me.txt_Nickel.Size = New System.Drawing.Size(100, 20)
        Me.txt_Nickel.TabIndex = 6
        '
        'txt_Dime
        '
        Me.txt_Dime.Location = New System.Drawing.Point(220, 135)
        Me.txt_Dime.Name = "txt_Dime"
        Me.txt_Dime.Size = New System.Drawing.Size(100, 20)
        Me.txt_Dime.TabIndex = 7
        '
        'txt_Quarter
        '
        Me.txt_Quarter.Location = New System.Drawing.Point(220, 191)
        Me.txt_Quarter.Name = "txt_Quarter"
        Me.txt_Quarter.Size = New System.Drawing.Size(100, 20)
        Me.txt_Quarter.TabIndex = 8
        '
        'txt_HalfDollar
        '
        Me.txt_HalfDollar.Location = New System.Drawing.Point(220, 252)
        Me.txt_HalfDollar.Name = "txt_HalfDollar"
        Me.txt_HalfDollar.Size = New System.Drawing.Size(100, 20)
        Me.txt_HalfDollar.TabIndex = 9
        '
        'btn_CalculateTotals
        '
        Me.btn_CalculateTotals.Location = New System.Drawing.Point(220, 303)
        Me.btn_CalculateTotals.Name = "btn_CalculateTotals"
        Me.btn_CalculateTotals.Size = New System.Drawing.Size(141, 23)
        Me.btn_CalculateTotals.TabIndex = 10
        Me.btn_CalculateTotals.Text = "Calculate"
        Me.btn_CalculateTotals.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(245, 372)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(75, 23)
        Me.btn_Reset.TabIndex = 11
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_Quit
        '
        Me.btn_Quit.Location = New System.Drawing.Point(429, 371)
        Me.btn_Quit.Name = "btn_Quit"
        Me.btn_Quit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Quit.TabIndex = 12
        Me.btn_Quit.Text = "Quit"
        Me.btn_Quit.UseVisualStyleBackColor = True
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(393, 305)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(158, 20)
        Me.txt_total.TabIndex = 13
        '
        'btn_Calculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.btn_Quit)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_CalculateTotals)
        Me.Controls.Add(Me.txt_HalfDollar)
        Me.Controls.Add(Me.txt_Quarter)
        Me.Controls.Add(Me.txt_Dime)
        Me.Controls.Add(Me.txt_Nickel)
        Me.Controls.Add(Me.txt_Penny)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "btn_Calculate"
        Me.Text = "Piggy Bank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_Penny As TextBox
    Friend WithEvents txt_Nickel As TextBox
    Friend WithEvents txt_Dime As TextBox
    Friend WithEvents txt_Quarter As TextBox
    Friend WithEvents txt_HalfDollar As TextBox
    Friend WithEvents btn_CalculateTotals As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_Quit As Button
    Friend WithEvents txt_total As TextBox
End Class
