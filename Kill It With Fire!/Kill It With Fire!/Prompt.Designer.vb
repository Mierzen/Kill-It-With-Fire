<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prompt
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
        Me.btn_yes = New System.Windows.Forms.Button()
        Me.btn_no = New System.Windows.Forms.Button()
        Me.chk_all = New System.Windows.Forms.CheckBox()
        Me.label_procCurrent = New System.Windows.Forms.Label()
        Me.label_procDetails = New System.Windows.Forms.Label()
        Me.panel_buttons = New System.Windows.Forms.Panel()
        Me.panel_buttons.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_yes
        '
        Me.btn_yes.Location = New System.Drawing.Point(3, 4)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(75, 23)
        Me.btn_yes.TabIndex = 0
        Me.btn_yes.Text = "Yes"
        Me.btn_yes.UseVisualStyleBackColor = True
        '
        'btn_no
        '
        Me.btn_no.Location = New System.Drawing.Point(120, 3)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(75, 23)
        Me.btn_no.TabIndex = 1
        Me.btn_no.Text = "No"
        Me.btn_no.UseVisualStyleBackColor = True
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.Location = New System.Drawing.Point(74, 33)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(52, 17)
        Me.chk_all.TabIndex = 2
        Me.chk_all.Text = "To all"
        Me.chk_all.UseVisualStyleBackColor = True
        '
        'label_procCurrent
        '
        Me.label_procCurrent.AutoSize = True
        Me.label_procCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_procCurrent.Location = New System.Drawing.Point(18, 15)
        Me.label_procCurrent.Name = "label_procCurrent"
        Me.label_procCurrent.Size = New System.Drawing.Size(49, 16)
        Me.label_procCurrent.TabIndex = 3
        Me.label_procCurrent.Text = "Label1"
        '
        'label_procDetails
        '
        Me.label_procDetails.AutoSize = True
        Me.label_procDetails.Location = New System.Drawing.Point(18, 40)
        Me.label_procDetails.Name = "label_procDetails"
        Me.label_procDetails.Size = New System.Drawing.Size(39, 13)
        Me.label_procDetails.TabIndex = 4
        Me.label_procDetails.Text = "Label1"
        '
        'panel_buttons
        '
        Me.panel_buttons.AutoSize = True
        Me.panel_buttons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.panel_buttons.Controls.Add(Me.btn_yes)
        Me.panel_buttons.Controls.Add(Me.btn_no)
        Me.panel_buttons.Controls.Add(Me.chk_all)
        Me.panel_buttons.Location = New System.Drawing.Point(40, 66)
        Me.panel_buttons.Name = "panel_buttons"
        Me.panel_buttons.Size = New System.Drawing.Size(198, 53)
        Me.panel_buttons.TabIndex = 5
        '
        'Prompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(280, 159)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_buttons)
        Me.Controls.Add(Me.label_procDetails)
        Me.Controls.Add(Me.label_procCurrent)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prompt"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Confirmation"
        Me.TopMost = True
        Me.panel_buttons.ResumeLayout(False)
        Me.panel_buttons.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_yes As System.Windows.Forms.Button
    Friend WithEvents btn_no As System.Windows.Forms.Button
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents label_procCurrent As System.Windows.Forms.Label
    Friend WithEvents label_procDetails As System.Windows.Forms.Label
    Friend WithEvents panel_buttons As System.Windows.Forms.Panel
End Class
