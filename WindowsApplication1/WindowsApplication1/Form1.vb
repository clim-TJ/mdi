Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim frm2 As New child1
        frm2.MdiParent = Me
        frm2.Show()

    End Sub
End Class
