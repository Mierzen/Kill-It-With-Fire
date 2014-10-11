Public Class form_done

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click
        form_results.Show()
    End Sub

    Private Sub form_done_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Beep()
        label_done.Text = vbNewLine & killed & " processes killed!"

        center(btn_details, Me)
        center(btn_exit, Me)
    End Sub
End Class