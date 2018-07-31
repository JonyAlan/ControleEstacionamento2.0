<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtBcadMensV3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(txtBcadMensV3))
        Me.mskBcadMenPla1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCadMenNo = New System.Windows.Forms.TextBox()
        Me.mskBcadMenCpf = New System.Windows.Forms.MaskedTextBox()
        Me.mskBcadMenTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtBcadMenModelC = New System.Windows.Forms.TextBox()
        Me.gpBVeiculo = New System.Windows.Forms.GroupBox()
        Me.btnFinalizarMens = New System.Windows.Forms.Button()
        Me.btnInser = New System.Windows.Forms.Button()
        Me.txtBcadMenDiaV = New System.Windows.Forms.TextBox()
        Me.btnGravarMens = New System.Windows.Forms.Button()
        Me.btnLimparMens = New System.Windows.Forms.Button()
        Me.MskBcadMensV = New System.Windows.Forms.MaskedTextBox()
        Me.gpBVeiculo.SuspendLayout()
        Me.SuspendLayout()
        '
        'mskBcadMenPla1
        '
        Me.mskBcadMenPla1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mskBcadMenPla1.Location = New System.Drawing.Point(451, 25)
        Me.mskBcadMenPla1.Mask = "AAA-0000"
        Me.mskBcadMenPla1.Name = "mskBcadMenPla1"
        Me.mskBcadMenPla1.Size = New System.Drawing.Size(100, 29)
        Me.mskBcadMenPla1.TabIndex = 2
        Me.mskBcadMenPla1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(376, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Placa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Valor R$:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Dia de vencimento:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(6, 32)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(169, 19)
        Me.lbl.TabIndex = 18
        Me.lbl.Text = "Modelo veículo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 19)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Telefone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(271, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Cpf:"
        '
        'txtCadMenNo
        '
        Me.txtCadMenNo.Location = New System.Drawing.Point(101, 49)
        Me.txtCadMenNo.Name = "txtCadMenNo"
        Me.txtCadMenNo.Size = New System.Drawing.Size(335, 20)
        Me.txtCadMenNo.TabIndex = 1
        '
        'mskBcadMenCpf
        '
        Me.mskBcadMenCpf.Location = New System.Drawing.Point(324, 81)
        Me.mskBcadMenCpf.Mask = "999.999.999-99"
        Me.mskBcadMenCpf.Name = "mskBcadMenCpf"
        Me.mskBcadMenCpf.Size = New System.Drawing.Size(112, 20)
        Me.mskBcadMenCpf.TabIndex = 3
        Me.mskBcadMenCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'mskBcadMenTel
        '
        Me.mskBcadMenTel.Location = New System.Drawing.Point(130, 79)
        Me.mskBcadMenTel.Mask = "(99) 00000-0000"
        Me.mskBcadMenTel.Name = "mskBcadMenTel"
        Me.mskBcadMenTel.Size = New System.Drawing.Size(112, 20)
        Me.mskBcadMenTel.TabIndex = 2
        Me.mskBcadMenTel.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtBcadMenModelC
        '
        Me.txtBcadMenModelC.Location = New System.Drawing.Point(187, 33)
        Me.txtBcadMenModelC.Name = "txtBcadMenModelC"
        Me.txtBcadMenModelC.Size = New System.Drawing.Size(166, 20)
        Me.txtBcadMenModelC.TabIndex = 1
        '
        'gpBVeiculo
        '
        Me.gpBVeiculo.Controls.Add(Me.btnFinalizarMens)
        Me.gpBVeiculo.Controls.Add(Me.btnInser)
        Me.gpBVeiculo.Controls.Add(Me.lbl)
        Me.gpBVeiculo.Controls.Add(Me.txtBcadMenModelC)
        Me.gpBVeiculo.Controls.Add(Me.mskBcadMenPla1)
        Me.gpBVeiculo.Controls.Add(Me.Label1)
        Me.gpBVeiculo.Enabled = False
        Me.gpBVeiculo.Location = New System.Drawing.Point(30, 264)
        Me.gpBVeiculo.Name = "gpBVeiculo"
        Me.gpBVeiculo.Size = New System.Drawing.Size(614, 166)
        Me.gpBVeiculo.TabIndex = 25
        Me.gpBVeiculo.TabStop = False
        Me.gpBVeiculo.Text = "Veículo"
        '
        'btnFinalizarMens
        '
        Me.btnFinalizarMens.BackColor = System.Drawing.Color.Blue
        Me.btnFinalizarMens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizarMens.Location = New System.Drawing.Point(305, 108)
        Me.btnFinalizarMens.Name = "btnFinalizarMens"
        Me.btnFinalizarMens.Size = New System.Drawing.Size(101, 36)
        Me.btnFinalizarMens.TabIndex = 4
        Me.btnFinalizarMens.Text = "Finalizar"
        Me.btnFinalizarMens.UseVisualStyleBackColor = False
        '
        'btnInser
        '
        Me.btnInser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInser.Location = New System.Drawing.Point(171, 108)
        Me.btnInser.Name = "btnInser"
        Me.btnInser.Size = New System.Drawing.Size(103, 36)
        Me.btnInser.TabIndex = 3
        Me.btnInser.Text = "Inserir"
        Me.btnInser.UseVisualStyleBackColor = True
        '
        'txtBcadMenDiaV
        '
        Me.txtBcadMenDiaV.Location = New System.Drawing.Point(231, 123)
        Me.txtBcadMenDiaV.Name = "txtBcadMenDiaV"
        Me.txtBcadMenDiaV.Size = New System.Drawing.Size(39, 20)
        Me.txtBcadMenDiaV.TabIndex = 4
        '
        'btnGravarMens
        '
        Me.btnGravarMens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravarMens.Location = New System.Drawing.Point(201, 199)
        Me.btnGravarMens.Name = "btnGravarMens"
        Me.btnGravarMens.Size = New System.Drawing.Size(103, 36)
        Me.btnGravarMens.TabIndex = 7
        Me.btnGravarMens.Text = "Gravar"
        Me.btnGravarMens.UseVisualStyleBackColor = True
        '
        'btnLimparMens
        '
        Me.btnLimparMens.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimparMens.Location = New System.Drawing.Point(335, 199)
        Me.btnLimparMens.Name = "btnLimparMens"
        Me.btnLimparMens.Size = New System.Drawing.Size(101, 36)
        Me.btnLimparMens.TabIndex = 8
        Me.btnLimparMens.Text = "limpar"
        Me.btnLimparMens.UseVisualStyleBackColor = True
        '
        'MskBcadMensV
        '
        Me.MskBcadMensV.Location = New System.Drawing.Point(141, 156)
        Me.MskBcadMensV.Mask = "000.00"
        Me.MskBcadMensV.Name = "MskBcadMensV"
        Me.MskBcadMensV.Size = New System.Drawing.Size(64, 20)
        Me.MskBcadMensV.TabIndex = 6
        Me.MskBcadMensV.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'txtBcadMensV3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 465)
        Me.Controls.Add(Me.MskBcadMensV)
        Me.Controls.Add(Me.btnLimparMens)
        Me.Controls.Add(Me.btnGravarMens)
        Me.Controls.Add(Me.txtBcadMenDiaV)
        Me.Controls.Add(Me.gpBVeiculo)
        Me.Controls.Add(Me.mskBcadMenTel)
        Me.Controls.Add(Me.mskBcadMenCpf)
        Me.Controls.Add(Me.txtCadMenNo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "txtBcadMensV3"
        Me.Text = "Cadastro de Mensalistas HK-Park"
        Me.gpBVeiculo.ResumeLayout(False)
        Me.gpBVeiculo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mskBcadMenPla1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCadMenNo As System.Windows.Forms.TextBox
    Friend WithEvents mskBcadMenCpf As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mskBcadMenTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtBcadMenModelC As System.Windows.Forms.TextBox
    Friend WithEvents gpBVeiculo As System.Windows.Forms.GroupBox
    Friend WithEvents txtBcadMenDiaV As System.Windows.Forms.TextBox
    Friend WithEvents btnGravarMens As System.Windows.Forms.Button
    Friend WithEvents btnLimparMens As System.Windows.Forms.Button
    Friend WithEvents MskBcadMensV As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnFinalizarMens As System.Windows.Forms.Button
    Friend WithEvents btnInser As System.Windows.Forms.Button
End Class
