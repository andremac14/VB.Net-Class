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
        Me.components = New System.ComponentModel.Container()
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim Date_JoinedLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.KarateDataSet = New Sandovala_Member_List.karateDataSet()
        Me.MembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MembersTableAdapter = New Sandovala_Member_List.karateDataSetTableAdapters.MembersTableAdapter()
        Me.TableAdapterManager = New Sandovala_Member_List.karateDataSetTableAdapters.TableAdapterManager()
        Me.PhoneLabel1 = New System.Windows.Forms.Label()
        Me.Date_JoinedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.First_NameLabel1 = New System.Windows.Forms.Label()
        Me.Last_NameLabel1 = New System.Windows.Forms.Label()
        Me.IDLabel1 = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        Date_JoinedLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.MembersBindingSource
        Me.ListBox1.DisplayMember = "Last_Name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 13)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(358, 420)
        Me.ListBox1.TabIndex = 0
        '
        'KarateDataSet
        '
        Me.KarateDataSet.DataSetName = "karateDataSet"
        Me.KarateDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembersBindingSource
        '
        Me.MembersBindingSource.DataMember = "Members"
        Me.MembersBindingSource.DataSource = Me.KarateDataSet
        '
        'MembersTableAdapter
        '
        Me.MembersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MembersTableAdapter = Me.MembersTableAdapter
        Me.TableAdapterManager.UpdateOrder = Sandovala_Member_List.karateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        PhoneLabel.Location = New System.Drawing.Point(440, 81)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(43, 15)
        PhoneLabel.TabIndex = 1
        PhoneLabel.Text = "Phone:"
        '
        'PhoneLabel1
        '
        Me.PhoneLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PhoneLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Phone", True))
        Me.PhoneLabel1.Location = New System.Drawing.Point(487, 81)
        Me.PhoneLabel1.Name = "PhoneLabel1"
        Me.PhoneLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PhoneLabel1.TabIndex = 2
        Me.PhoneLabel1.Text = "Label1"
        '
        'Date_JoinedLabel
        '
        Date_JoinedLabel.AutoSize = True
        Date_JoinedLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Date_JoinedLabel.Location = New System.Drawing.Point(437, 221)
        Date_JoinedLabel.Name = "Date_JoinedLabel"
        Date_JoinedLabel.Size = New System.Drawing.Size(69, 15)
        Date_JoinedLabel.TabIndex = 3
        Date_JoinedLabel.Text = "Date Joined:"
        '
        'Date_JoinedDateTimePicker
        '
        Me.Date_JoinedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MembersBindingSource, "Date_Joined", True))
        Me.Date_JoinedDateTimePicker.Location = New System.Drawing.Point(512, 221)
        Me.Date_JoinedDateTimePicker.Name = "Date_JoinedDateTimePicker"
        Me.Date_JoinedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Date_JoinedDateTimePicker.TabIndex = 4
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        First_NameLabel.Location = New System.Drawing.Point(437, 126)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(62, 15)
        First_NameLabel.TabIndex = 5
        First_NameLabel.Text = "First Name:"
        '
        'First_NameLabel1
        '
        Me.First_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.First_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "First_Name", True))
        Me.First_NameLabel1.Location = New System.Drawing.Point(503, 126)
        Me.First_NameLabel1.Name = "First_NameLabel1"
        Me.First_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.First_NameLabel1.TabIndex = 6
        Me.First_NameLabel1.Text = "Label1"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Last_NameLabel.Location = New System.Drawing.Point(437, 171)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(63, 15)
        Last_NameLabel.TabIndex = 7
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameLabel1
        '
        Me.Last_NameLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Last_NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "Last_Name", True))
        Me.Last_NameLabel1.Location = New System.Drawing.Point(504, 171)
        Me.Last_NameLabel1.Name = "Last_NameLabel1"
        Me.Last_NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.Last_NameLabel1.TabIndex = 8
        Me.Last_NameLabel1.Text = "Label1"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(442, 29)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 9
        IDLabel.Text = "ID:"
        '
        'IDLabel1
        '
        Me.IDLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MembersBindingSource, "ID", True))
        Me.IDLabel1.Location = New System.Drawing.Point(469, 29)
        Me.IDLabel1.Name = "IDLabel1"
        Me.IDLabel1.Size = New System.Drawing.Size(100, 23)
        Me.IDLabel1.TabIndex = 10
        Me.IDLabel1.Text = "Label1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 453)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDLabel1)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameLabel1)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameLabel1)
        Me.Controls.Add(Date_JoinedLabel)
        Me.Controls.Add(Me.Date_JoinedDateTimePicker)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneLabel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Sandovala_Member List"
        CType(Me.KarateDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents KarateDataSet As karateDataSet
    Friend WithEvents MembersBindingSource As BindingSource
    Friend WithEvents MembersTableAdapter As karateDataSetTableAdapters.MembersTableAdapter
    Friend WithEvents TableAdapterManager As karateDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhoneLabel1 As Label
    Friend WithEvents Date_JoinedDateTimePicker As DateTimePicker
    Friend WithEvents First_NameLabel1 As Label
    Friend WithEvents Last_NameLabel1 As Label
    Friend WithEvents IDLabel1 As Label
End Class
