Public Class Form1

    Private Sub NovoUsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoUsuárioToolStripMenuItem.Click
        frmUsuarios.Show()
    End Sub

    Private Sub PermissõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermissõesToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub ConfirguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirguraçõesToolStripMenuItem.Click
        frmConfig.Show()
    End Sub
End Class
