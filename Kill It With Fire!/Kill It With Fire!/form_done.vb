Public Class form_done

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        form_results.Show()
    End Sub

    Private Sub form_done_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Beep()
        label_done.Text = killed & " processes killed!"
        label_done.Location = New Point((Me.Width - label_done.Width) / 2, label_done.Location.Y)
    End Sub
End Class