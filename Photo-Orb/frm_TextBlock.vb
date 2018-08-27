Public Class frm_TextBlock

    Friend m_ButtonNumPressed As Integer

    Private Sub btn_01_Click(sender As Object, e As EventArgs) Handles btn_01.Click
        m_ButtonNumPressed = 1
        Me.Hide()
    End Sub

    Private Sub btn_02_Click(sender As Object, e As EventArgs) Handles btn_02.Click
        m_ButtonNumPressed = 2
        Me.Hide()
    End Sub

End Class