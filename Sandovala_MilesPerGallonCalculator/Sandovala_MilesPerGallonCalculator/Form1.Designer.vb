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
        Me.txt_TankCapacity = New System.Windows.Forms.TextBox()
        Me.txt_MilesDriven = New System.Windows.Forms.TextBox()
        Me.txt_MilesPerGallon = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Calculate = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_TankCapacity
        '
        Me.txt_TankCapacity.Location = New System.Drawing.Point(381, 89)
        Me.txt_TankCapacity.Name = "txt_TankCapacity"
        Me.txt_TankCapacity.Size = New System.Drawing.Size(100, 20)
        Me.txt_TankCapacity.TabIndex = 0
        '
        'txt_MilesDriven
        '
        Me.txt_MilesDriven.Location = New System.Drawing.Point(381, 166)
        Me.txt_MilesDriven.Name = "txt_MilesDriven"
        Me.txt_MilesDriven.Size = New System.Drawing.Size(100, 20)
        Me.txt_MilesDriven.TabIndex = 1
        '
        'txt_MilesPerGallon
        '
        Me.txt_MilesPerGallon.Location = New System.Drawing.Point(381, 242)
        Me.txt_MilesPerGallon.Name = "txt_MilesPerGallon"
        Me.txt_MilesPerGallon.Size = New System.Drawing.Size(100, 20)
        Me.txt_MilesPerGallon.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(218, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gallons of gas the car can hold:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Number of miles it can be driven on a full tank:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Miles per gallon:"
        '
        'btn_Calculate
        '
        Me.btn_Calculate.Location = New System.Drawing.Point(153, 363)
        Me.btn_Calculate.Name = "btn_Calculate"
        Me.btn_Calculate.Size = New System.Drawing.Size(94, 23)
        Me.btn_Calculate.TabIndex = 6
        Me.btn_Calculate.Text = "Calculate MPG"
        Me.btn_Calculate.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(331, 362)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 7
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Exit
        '
        Me.btn_Exit.Location = New System.Drawing.Point(496, 363)
        Me.btn_Exit.Name = "btn_Exit"
        Me.btn_Exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_Exit.TabIndex = 8
        Me.btn_Exit.Text = "Exit"
        Me.btn_Exit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_Exit)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Calculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_MilesPerGallon)
        Me.Controls.Add(Me.txt_MilesDriven)
        Me.Controls.Add(Me.txt_TankCapacity)
        Me.Name = "Form1"
        Me.Text = "Miles Per Gallon Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_TankCapacity As TextBox
    Friend WithEvents txt_MilesDriven As TextBox
    Friend WithEvents txt_MilesPerGallon As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_Calculate As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents btn_Exit As Button
End Class
