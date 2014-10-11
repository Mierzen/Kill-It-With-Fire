Public Class Prompt

    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        If chk_all.Checked = True Then
            promptResult = "YesAll"
        Else
            promptResult = "Yes"
        End If

        Me.Close()
    End Sub

    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        If chk_all.Checked = True Then
            promptResult = "NoAll"
        Else
            promptResult = "No"
        End If

        Me.Close()
    End Sub

    Private Sub Prompt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        center(panel_buttons, Me)
    End Sub
End Class