Module mdlFuncoes
    Public Function pegamenus(ByVal listbox1 As CheckedListBox, ByVal menustrip1 As MenuStrip)
        Dim x, y, z As Integer
        Dim v As System.Windows.Forms.ToolStripMenuItem
        Dim submenu As System.Windows.Forms.ToolStripMenuItem
        listbox1.Items.Clear()
        For x = 0 To menustrip1.Items.Count - 1
            v = menustrip1.Items(x)
            If v.Text <> "" Then
                listbox1.Items.Add(v.Text)

                For y = 0 To v.DropDown.Items.Count - 1
                    If v.DropDown.Items(y).Text <> "" Then
                        listbox1.Items.Add(v.DropDown.Items(y).Text)
                        If v.DropDown.Items(y).Text <> "" Then
                            submenu = v.DropDown.Items(y)
                            If submenu.DropDownItems.Count <> 0 Then
                                For z = 0 To submenu.DropDownItems.Count - 1
                                    If submenu.DropDownItems.Item(z).Text <> "" Then
                                        listbox1.Items.Add(submenu.DropDown.Items(z).Text)
                                    End If
                                Next
                            End If
                        End If
                    End If
                Next
            End If
        Next
        pegamenus = ""
    End Function
    Public Function CtrlMenu(ByVal permissao As String, Optional ByVal esconder As Boolean = False)
        Dim tbpermissao As ADODB.Recordset
        Dim sql As String
        Dim menu As String
        Dim x As Integer
        Dim submenu As System.Windows.Forms.ToolStripMenuItem
        For x = 0 To Form1.MenuStrip1.Items.Count - 1
            menu = Form1.MenuStrip1.Items(x).Text
            If menu.ToString <> "" Then
                sql = "Select * from tbpermissoes where permissao = '" & permissao & "' and menu = '" & menu & "'"
                tbpermissao = abrir(sql)
                If tbpermissao.RecordCount <> 0 Then
                    If tbpermissao.Fields("ativo").Value = True Then
                        If esconder = False Then
                            Form1.MenuStrip1.Items(x).Enabled = True
                        Else
                            Form1.MenuStrip1.Items(x).Visible = True
                        End If
                    Else
                        If esconder = False Then
                            Form1.MenuStrip1.Items(x).Enabled = False
                        Else
                            Form1.MenuStrip1.Items(x).Visible = False
                        End If


                    End If
                Else
                    If esconder = False Then
                        Form1.MenuStrip1.Items(x).Enabled = True
                    Else
                        Form1.MenuStrip1.Items(x).Visible = True
                    End If

                End If
                submenu = Form1.MenuStrip1.Items(x)
                ctrlmenusubmenu(submenu, permissao, esconder)
            End If
        Next


        Return True
    End Function
    Public Function ctrlmenusubmenu(ByVal menu As System.Windows.Forms.ToolStripMenuItem, ByVal permissao As String, Optional ByVal esconder As Boolean = False)
        Dim tbpermissao As ADODB.Recordset
        Dim sql As String
        Dim z As Integer
        For z = 0 To menu.DropDownItems.Count - 1
            If menu.DropDownItems.Item(z).Text <> "" Then
                sql = "Select * from tbpermissoes where permissao = '" & permissao & "' and menu = '" & menu.DropDownItems.Item(z).Text & "'"
                tbpermissao = abrir(sql)
                If tbpermissao.RecordCount <> 0 Then
                    If tbpermissao.Fields("ativo").Value = True Then
                        If esconder = False Then
                            menu.DropDownItems.Item(z).Enabled = True
                        Else
                            menu.DropDownItems.Item(z).Visible = True
                        End If
                    Else
                        If esconder = False Then
                            menu.DropDownItems.Item(z).Enabled = False
                        Else
                            menu.DropDownItems.Item(z).Visible = False
                        End If
                    End If
                Else
                    If esconder = False Then
                        menu.DropDownItems.Item(z).Enabled = True
                    Else
                        menu.DropDownItems.Item(z).Visible = True
                    End If

                End If
                ctrlmenusubmenu(menu.DropDownItems.Item(z), permissao, esconder)
            End If
        Next
        Return True
    End Function
    Public Function mcripto(ByVal wvTEXTO As String)
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        wvTEXTO = UCase(wvTEXTO)
        wvRETORNA = ""
        wvTEXTO1 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO2 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        mcripto = wvRETORNA

    End Function
    Public Function muncripto(ByVal wvTEXTO As String)
        Dim X, Y, INDICE As Integer
        Dim CARACTER As String
        Dim wvTEXTO1, wvTEXTO2, wvRETORNA As String
        wvRETORNA = ""
        wvTEXTO = UCase(wvTEXTO)
        wvTEXTO2 = "ABCDEFGHIJKLMNOPQRSTUVXYZ1234567890 WÇÃÕ"
        wvTEXTO1 = "!@#$%^&*()_+|=\-][{}?/><,.~`®¬½¼¡«»¨©ÇÕÃ"
        For X = 1 To Len(wvTEXTO)
            CARACTER = Right(Left(wvTEXTO, X), 1)
            For Y = 1 To Len(wvTEXTO1)

                If CARACTER = Right(Left(wvTEXTO1, Y), 1) Then
                    INDICE = Y

                End If
            Next
            wvRETORNA = wvRETORNA + Right(Left(wvTEXTO2, INDICE), 1)

        Next

        muncripto = wvRETORNA

    End Function
    Public Function tratadata2(ByVal data As String) As Date
        Dim novadata As String
        novadata = data.Substring(0, 2) & "/" & data.Substring(2, 2) & "/" & data.Substring(4, 4)
        If IsDate(novadata) = True Then
            Return Format(CDate(novadata), "dd/MM/yyyy")
        Else
            Return Format(CDate("01/01/1900"), "dd/MM/yyyy")
        End If
    End Function
End Module
