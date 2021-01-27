<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sandovala_Lab1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnRed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(208, 105)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(208, 157)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'btnRed
        '
        Me.btnRed.Location = New System.Drawing.Point(199, 198)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(118, 23)
        Me.btnRed.TabIndex = 2
        Me.btnRed.Text = "Change Color to Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'Sandovala_Lab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRed)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.txtFirst)
        Me.Name = "Sandovala_Lab1"
        Me.Text = "Sandovala_Lab1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirst As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnRed As Button
End Class
