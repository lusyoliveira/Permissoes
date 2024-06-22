Public Class frmUsuarios
    Dim tbaux As ADODB.Recordset
    Dim x As Integer
    Dim sql As String
    Private Sub cboPermissao_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboPermissao.GotFocus
        With cboPermissao
            .Items.Clear()
            tbaux = abrir("Select distinct permissao from tbpermissoes order by permissao")
            If tbaux.RecordCount <> 0 Then
                tbaux.MoveFirst()
                While tbaux.EOF = False
                    .Items.Add(tbaux.Fields("permissao").Value.ToString)
                    tbaux.MoveNext()
                End While
            End If

        End With
    End Sub

    Private Sub cboPermissao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPermissao.SelectedIndexChanged

    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "Select * from tbusuarios where nome = '" & txtUsuario.Text & "'"
        tbaux = abrir(sql)
        If tbaux.RecordCount <> 0 Then
            MsgBox("O usuário já existe !", MsgBoxStyle.Information)
            Exit Sub
        End If
        sql = "insert into tbusuarios (nome,senha,permissao) values ('" & txtUsuario.Text & "','" & txtSenha.Text & "','" & cboPermissao.Text & "')"
        tbaux = abrir(sql)
        limpar()
    End Sub
    Private Sub limpar()
        txtSenha.Text = ""
        txtUsuario.Text = ""
        cboPermissao.Text = ""
        txtUsuario.Focus()
    End Sub
End Class