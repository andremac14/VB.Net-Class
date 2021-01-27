<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sandovala_SemesterAverages
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
        Me.btn_Quit = New System.Windows.Forms.Button()
        Me.btn_Reset = New System.Windows.Forms.Button()
        Me.btn_DisplayAverage = New System.Windows.Forms.Button()
        Me.lst_Display = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_Quit
        '
        Me.btn_Quit.Location = New System.Drawing.Point(12, 655)
        Me.btn_Quit.Name = "btn_Quit"
        Me.btn_Quit.Size = New System.Drawing.Size(119, 49)
        Me.btn_Quit.TabIndex = 0
        Me.btn_Quit.Text = "Quit"
        Me.btn_Quit.UseVisualStyleBackColor = True
        '
        'btn_Reset
        '
        Me.btn_Reset.Location = New System.Drawing.Point(762, 654)
        Me.btn_Reset.Name = "btn_Reset"
        Me.btn_Reset.Size = New System.Drawing.Size(110, 50)
        Me.btn_Reset.TabIndex = 1
        Me.btn_Reset.Text = "Reset"
        Me.btn_Reset.UseVisualStyleBackColor = True
        '
        'btn_DisplayAverage
        '
        Me.btn_DisplayAverage.Location = New System.Drawing.Point(221, 92)
        Me.btn_DisplayAverage.Name = "btn_DisplayAverage"
        Me.btn_DisplayAverage.Size = New System.Drawing.Size(449, 108)
        Me.btn_DisplayAverage.TabIndex = 2
        Me.btn_DisplayAverage.Text = "Display Semester Averages"
        Me.btn_DisplayAverage.UseVisualStyleBackColor = True
        '
        'lst_Display
        '
        Me.lst_Display.FormattingEnabled = True
        Me.lst_Display.ItemHeight = 24
        Me.lst_Display.Location = New System.Drawing.Point(221, 301)
        Me.lst_Display.Name = "lst_Display"
        Me.lst_Display.Size = New System.Drawing.Size(449, 244)
        Me.lst_Display.TabIndex = 3
        '
        'Sandovala_SemesterAverages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 716)
        Me.Controls.Add(Me.lst_Display)
        Me.Controls.Add(Me.btn_DisplayAverage)
        Me.Controls.Add(Me.btn_Reset)
        Me.Controls.Add(Me.btn_Quit)
        Me.Name = "Sandovala_SemesterAverages"
        Me.Text = "Sandovala_SemesterAverages"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Quit As Button
    Friend WithEvents btn_Reset As Button
    Friend WithEvents btn_DisplayAverage As Button
    Friend WithEvents lst_Display As ListBox
End Class
