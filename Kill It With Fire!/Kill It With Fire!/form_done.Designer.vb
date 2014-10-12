<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_done
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_done))
        Me.label_done = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.btn_details = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_done
        '
        Me.label_done.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_done.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_done.Location = New System.Drawing.Point(0, 0)
        Me.label_done.Name = "label_done"
        Me.label_done.Size = New System.Drawing.Size(160, 142)
        Me.label_done.TabIndex = 0
        Me.label_done.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "x processes killed!"
        Me.label_done.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn_exit
        '
        Me.btn_exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_exit.Location = New System.Drawing.Point(24, 98)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(113, 23)
        Me.btn_exit.TabIndex = 1
        Me.btn_exit.Text = "Exit program"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'btn_details
        '
        Me.btn_details.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_details.Enabled = False
        Me.btn_details.Location = New System.Drawing.Point(24, 69)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(113, 23)
        Me.btn_details.TabIndex = 2
        Me.btn_details.Text = "View details"
        Me.btn_details.UseVisualStyleBackColor = True
        '
        'form_done
        '
        Me.AcceptButton = Me.btn_exit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(160, 142)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.label_done)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_done"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_done"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_done As System.Windows.Forms.Label
    Friend WithEvents btn_exit As System.Windows.Forms.Button
    Friend WithEvents btn_details As System.Windows.Forms.Button
End Class
