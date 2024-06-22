<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfig
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnSalvar = New System.Windows.Forms.Button
        Me.chkEsconde = New System.Windows.Forms.CheckBox
        Me.txtCliente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpConfig = New System.Windows.Forms.GroupBox
        Me.grpConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(32, 208)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(157, 44)
        Me.btnAlterar.TabIndex = 0
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(255, 208)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(157, 44)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'chkEsconde
        '
        Me.chkEsconde.AutoSize = True
        Me.chkEsconde.Location = New System.Drawing.Point(24, 84)
        Me.chkEsconde.Name = "chkEsconde"
        Me.chkEsconde.Size = New System.Drawing.Size(148, 17)
        Me.chkEsconde.TabIndex = 2
        Me.chkEsconde.Text = "Esconder opções inativas"
        Me.chkEsconde.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(24, 42)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(281, 20)
        Me.txtCliente.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cliente"
        '
        'grpConfig
        '
        Me.grpConfig.Controls.Add(Me.Label1)
        Me.grpConfig.Controls.Add(Me.txtCliente)
        Me.grpConfig.Controls.Add(Me.chkEsconde)
        Me.grpConfig.Location = New System.Drawing.Point(8, 12)
        Me.grpConfig.Name = "grpConfig"
        Me.grpConfig.Size = New System.Drawing.Size(676, 162)
        Me.grpConfig.TabIndex = 5
        Me.grpConfig.TabStop = False
        '
        'frmConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 264)
        Me.Controls.Add(Me.grpConfig)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnAlterar)
        Me.Name = "frmConfig"
        Me.Text = "frmConfig"
        Me.grpConfig.ResumeLayout(False)
        Me.grpConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents chkEsconde As System.Windows.Forms.CheckBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpConfig As System.Windows.Forms.GroupBox
End Class
