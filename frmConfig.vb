Public Class frmConfig
    Dim tbaux As ADODB.Recordset
    Dim sql As String
    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MdiParent = Form1
        carregadados()
    End Sub
    Private Sub carregadados()
        tbaux = abrir("Select * from tbconfig")
        chkEsconde.Checked = IIf(tbaux.Fields("esconder").Value.ToString = "True", True, False)
        txtCliente.Text = tbaux.Fields("cliente").Value.ToString
        btnAlterar.Enabled = True
        btnSalvar.Enabled = True
        grpConfig.Enabled = False
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        grpConfig.Enabled = True
    End Sub

    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvar.Click
        sql = "update tbconfig set cliente = '" & txtCliente.Text & "', esconder = " & IIf(chkEsconde.Checked = True, True, False)
        tbaux = abrir(sql)
        btnAlterar.Enabled = True
        btnSalvar.Enabled = False
        grpConfig.Enabled = False
    End Sub
End Class