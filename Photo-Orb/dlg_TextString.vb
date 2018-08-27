Imports System.Windows.Forms

Public Class dlg_TextString

    Private Sub dlg_TextString_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim i As Integer
        For i = 0 To Me.Controls.Count - 1
            If Me.Controls(i).Name Is "oTextBox_Entry" Then
                '// Set the focus on this control.
                Me.ActiveControl = Me.Controls(i)
            End If
        Next

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
