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
        Me.txt_SliceCount = New System.Windows.Forms.TextBox()
        Me.txt_FryCount = New System.Windows.Forms.TextBox()
        Me.txt_SoftDrink = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Compute = New System.Windows.Forms.Button()
        Me.lst_Box = New System.Windows.Forms.ListBox()
        Me.btn_Quit = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_SliceCount
        '
        Me.txt_SliceCount.Location = New System.Drawing.Point(497, 48)
        Me.txt_SliceCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_SliceCount.Name = "txt_SliceCount"
        Me.txt_SliceCount.Size = New System.Drawing.Size(105, 29)
        Me.txt_SliceCount.TabIndex = 0
        '
        'txt_FryCount
        '
        Me.txt_FryCount.Location = New System.Drawing.Point(497, 151)
        Me.txt_FryCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_FryCount.Name = "txt_FryCount"
        Me.txt_FryCount.Size = New System.Drawing.Size(105, 29)
        Me.txt_FryCount.TabIndex = 1
        '
        'txt_SoftDrink
        '
        Me.txt_SoftDrink.Location = New System.Drawing.Point(497, 247)
        Me.txt_SoftDrink.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txt_SoftDrink.Name = "txt_SoftDrink"
        Me.txt_SoftDrink.Size = New System.Drawing.Size(105, 29)
        Me.txt_SoftDrink.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "How many pizza slices?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(330, 157)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "How many fries?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 253)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "How many soft drinks?"
        '
        'btn_Compute
        '
        Me.btn_Compute.Location = New System.Drawing.Point(765, 244)
        Me.btn_Compute.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Compute.Name = "btn_Compute"
        Me.btn_Compute.Size = New System.Drawing.Size(207, 42)
        Me.btn_Compute.TabIndex = 6
        Me.btn_Compute.Text = "Compute Total Cost"
        Me.btn_Compute.UseVisualStyleBackColor = True
        '
        'lst_Box
        '
        Me.lst_Box.FormattingEnabled = True
        Me.lst_Box.ItemHeight = 24
        Me.lst_Box.Location = New System.Drawing.Point(282, 382)
        Me.lst_Box.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lst_Box.Name = "lst_Box"
        Me.lst_Box.Size = New System.Drawing.Size(686, 364)
        Me.lst_Box.TabIndex = 7
        '
        'btn_Quit
        '
        Me.btn_Quit.Location = New System.Drawing.Point(1263, 382)
        Me.btn_Quit.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Quit.Name = "btn_Quit"
        Me.btn_Quit.Size = New System.Drawing.Size(138, 42)
        Me.btn_Quit.TabIndex = 8
        Me.btn_Quit.Text = "Quit"
        Me.btn_Quit.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(1049, 382)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(138, 42)
        Me.btn_Clear.TabIndex = 9
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1467, 831)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Quit)
        Me.Controls.Add(Me.lst_Box)
        Me.Controls.Add(Me.btn_Compute)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_SoftDrink)
        Me.Controls.Add(Me.txt_FryCount)
        Me.Controls.Add(Me.txt_SliceCount)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "Restaurant Bill"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_SliceCount As TextBox
    Friend WithEvents txt_FryCount As TextBox
    Friend WithEvents txt_SoftDrink As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Compute As Button
    Friend WithEvents lst_Box As ListBox
    Friend WithEvents btn_Quit As Button
    Friend WithEvents btn_Clear As Button
End Class
