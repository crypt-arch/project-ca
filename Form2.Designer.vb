<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.FocusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'StatusTextBox
        '
        Me.StatusTextBox.BackColor = System.Drawing.Color.Black
        Me.StatusTextBox.ForeColor = System.Drawing.Color.White
        Me.StatusTextBox.Location = New System.Drawing.Point(12, 442)
        Me.StatusTextBox.Multiline = True
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(1089, 234)
        Me.StatusTextBox.TabIndex = 0
        '
        'FocusLabel
        '
        Me.FocusLabel.AutoSize = True
        Me.FocusLabel.Location = New System.Drawing.Point(1019, 9)
        Me.FocusLabel.Name = "FocusLabel"
        Me.FocusLabel.Size = New System.Drawing.Size(82, 20)
        Me.FocusLabel.TabIndex = 1
        Me.FocusLabel.Text = "FocusLabel"
        Me.FocusLabel.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1113, 688)
        Me.Controls.Add(Me.FocusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CryptArch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents FocusLabel As Label
End Class
