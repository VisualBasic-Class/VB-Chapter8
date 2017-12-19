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
        Me.listFriends = New System.Windows.Forms.ListBox()
        Me.btnNames = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listFriends
        '
        Me.listFriends.FormattingEnabled = True
        Me.listFriends.Items.AddRange(New Object() {"Bob", "Jerry", "Kyle", "Bailey", "Christine"})
        Me.listFriends.Location = New System.Drawing.Point(102, 81)
        Me.listFriends.Name = "listFriends"
        Me.listFriends.Size = New System.Drawing.Size(167, 134)
        Me.listFriends.TabIndex = 0
        '
        'btnNames
        '
        Me.btnNames.Location = New System.Drawing.Point(62, 289)
        Me.btnNames.Name = "btnNames"
        Me.btnNames.Size = New System.Drawing.Size(75, 45)
        Me.btnNames.TabIndex = 1
        Me.btnNames.Text = "Enter Names"
        Me.btnNames.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(245, 289)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 45)
        Me.btnExit.TabIndex = 2
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 379)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnNames)
        Me.Controls.Add(Me.listFriends)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listFriends As System.Windows.Forms.ListBox
    Friend WithEvents btnNames As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
