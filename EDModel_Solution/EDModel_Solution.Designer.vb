<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EDModel_Solution
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
        Me.lstFaculty = New System.Windows.Forms.ListBox()
        Me.btnShowFaculty = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFaculty
        '
        Me.lstFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFaculty.FormattingEnabled = True
        Me.lstFaculty.ItemHeight = 16
        Me.lstFaculty.Location = New System.Drawing.Point(13, 13)
        Me.lstFaculty.Name = "lstFaculty"
        Me.lstFaculty.Size = New System.Drawing.Size(259, 164)
        Me.lstFaculty.TabIndex = 0
        '
        'btnShowFaculty
        '
        Me.btnShowFaculty.Location = New System.Drawing.Point(13, 193)
        Me.btnShowFaculty.Name = "btnShowFaculty"
        Me.btnShowFaculty.Size = New System.Drawing.Size(259, 56)
        Me.btnShowFaculty.TabIndex = 1
        Me.btnShowFaculty.Text = "Show Faculty"
        Me.btnShowFaculty.UseVisualStyleBackColor = True
        '
        'EDModel_Solution
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnShowFaculty)
        Me.Controls.Add(Me.lstFaculty)
        Me.Name = "EDModel_Solution"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EDM Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFaculty As ListBox
    Friend WithEvents btnShowFaculty As Button
End Class
