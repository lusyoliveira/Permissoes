Public Class frmLogin
    Dim tbaux, tbconfig As ADODB.Recordset
    Dim sql As String
    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tbconfig = abrir("Select * from tbconfig")


        If muncripto(tbconfig.Fields("ctrl").Value.ToString).ToString.ToUpper <> "OK" Then
            If tbconfig.Fields("ctrl").Value.ToString = "" Then
                sql = "update tbconfig set ctrl = '" & mcripto(Date.Now.Date.ToString.Replace("/", "").Substring(0, 8)) & "'"
                tbaux = abrir(sql)
                sql = "Select * from tbconfig"
                tbconfig = abrir(sql)
            End If
            If CDate(tratadata2(muncripto(tbconfig("ctrl").Value.ToString))).AddDays(30) < Date.Now.Date Then
                MsgBox("Sua versão de testes venceu! Por favor, entre em contato com desenvolvedor !", MsgBoxStyle.Critical)
                End
            End If
        End If
        tbaux = abrir("Select * from tbusuarios order by nome")
        If tbaux.RecordCount <> 0 Then
            tbaux.MoveFirst()
            While tbaux.EOF = False
                txtUsuario.AutoCompleteCustomSource.Add(tbaux.Fields("nome").Value.ToString)
                tbaux.MoveNext()
            End While
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub btnEntrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrar.Click
        Dim esconde As Boolean
        If tbconfig.Fields("esconder").Value.ToString = "True" Then
            esconde = True
        Else
            esconde = False
        End If
        sql = "Select * from tbusuarios where nome = '" & txtUsuario.Text & "'"
        tbaux = abrir(sql)
        If tbaux.RecordCount = 0 Then
            MsgBox("Usuário não existe !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If txtSenha.Text.ToUpper = tbaux.Fields("senha").Value.ToString.ToUpper Then

            CtrlMenu(tbaux.Fields("permissao").Value.ToString, esconde)
            Form1.Show()
            Me.Close()
        Else
            MsgBox("Senha inválida !")
        End If
    End Sub
End Class