Public Class form_main

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        kill.kill()
    End Sub

    Private Sub form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kill.kill()

        Application.Exit()
    End Sub
End Class
