<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.JsonResultTextBox = New System.Windows.Forms.TextBox()
        Me.SelectFileButton = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'JsonResultTextBox
        '
        Me.JsonResultTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.JsonResultTextBox.Location = New System.Drawing.Point(24, 22)
        Me.JsonResultTextBox.Multiline = true
        Me.JsonResultTextBox.Name = "JsonResultTextBox"
        Me.JsonResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.JsonResultTextBox.Size = New System.Drawing.Size(1256, 735)
        Me.JsonResultTextBox.TabIndex = 0
        '
        'SelectFileButton
        '
        Me.SelectFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.SelectFileButton.Location = New System.Drawing.Point(1092, 774)
        Me.SelectFileButton.Name = "SelectFileButton"
        Me.SelectFileButton.Size = New System.Drawing.Size(188, 43)
        Me.SelectFileButton.TabIndex = 1
        Me.SelectFileButton.Text = "Select file..."
        Me.SelectFileButton.UseVisualStyleBackColor = true
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12!, 25!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 829)
        Me.Controls.Add(Me.SelectFileButton)
        Me.Controls.Add(Me.JsonResultTextBox)
        Me.Name = "MainForm"
        Me.Text = "Demo"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents JsonResultTextBox As TextBox
    Friend WithEvents SelectFileButton As Button
End Class
