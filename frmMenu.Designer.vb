<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits leonida.frmTemplate

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button13
        '
        Me.Button13.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Button13.Image = Global.leonida.My.Resources.Resources.operation
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.Location = New System.Drawing.Point(222, 293)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(177, 60)
        Me.Button13.TabIndex = 15
        Me.Button13.Text = "Λειτουργία"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 730)
        Me.Controls.Add(Me.Button13)
        Me.Name = "frmMenu"
        Me.Controls.SetChildIndex(Me.Button13, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button13 As System.Windows.Forms.Button

End Class
