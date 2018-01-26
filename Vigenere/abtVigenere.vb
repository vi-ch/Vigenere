Public Class abtVigenere

    Private Sub abtVigenere_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub abtVigenere_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If (e.KeyChar = Chr(27)) Then
            Me.Close()
        End If
    End Sub
End Class