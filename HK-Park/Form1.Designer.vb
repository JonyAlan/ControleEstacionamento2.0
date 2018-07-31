<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dtgrPatio = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RotativoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MensalistasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastrarUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirUsuárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MktxtPlaent = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.MskdBSai = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RdBHot = New System.Windows.Forms.RadioButton()
        Me.RdBPern = New System.Windows.Forms.RadioButton()
        Me.RdBMot = New System.Windows.Forms.RadioButton()
        Me.RdBCarG = New System.Windows.Forms.RadioButton()
        Me.RdBCarP = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimerSis = New System.Windows.Forms.Timer(Me.components)
        Me.lblhora = New System.Windows.Forms.Label()
        Me.lbldta = New System.Windows.Forms.Label()
        Me.BtnScart = New System.Windows.Forms.Button()
        Me.btnSdin = New System.Windows.Forms.Button()
        CType(Me.dtgrPatio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgrPatio
        '
        Me.dtgrPatio.AllowUserToAddRows = False
        Me.dtgrPatio.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgrPatio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgrPatio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgrPatio.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtgrPatio.Location = New System.Drawing.Point(422, 69)
        Me.dtgrPatio.Name = "dtgrPatio"
        Me.dtgrPatio.ReadOnly = True
        Me.dtgrPatio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgrPatio.Size = New System.Drawing.Size(353, 386)
        Me.dtgrPatio.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RotativoToolStripMenuItem, Me.MensalistasToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(809, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RotativoToolStripMenuItem
        '
        Me.RotativoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioToolStripMenuItem1})
        Me.RotativoToolStripMenuItem.Name = "RotativoToolStripMenuItem"
        Me.RotativoToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.RotativoToolStripMenuItem.Text = "Rotativo"
        '
        'RelatórioToolStripMenuItem1
        '
        Me.RelatórioToolStripMenuItem1.Name = "RelatórioToolStripMenuItem1"
        Me.RelatórioToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.RelatórioToolStripMenuItem1.Text = "Relatório"
        '
        'MensalistasToolStripMenuItem
        '
        Me.MensalistasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.RelatórioToolStripMenuItem, Me.PaToolStripMenuItem})
        Me.MensalistasToolStripMenuItem.Name = "MensalistasToolStripMenuItem"
        Me.MensalistasToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.MensalistasToolStripMenuItem.Text = "Mensalistas"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'RelatórioToolStripMenuItem
        '
        Me.RelatórioToolStripMenuItem.Name = "RelatórioToolStripMenuItem"
        Me.RelatórioToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.RelatórioToolStripMenuItem.Text = "Relatório"
        '
        'PaToolStripMenuItem
        '
        Me.PaToolStripMenuItem.Name = "PaToolStripMenuItem"
        Me.PaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.PaToolStripMenuItem.Text = "Movimentação"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarUsuárioToolStripMenuItem, Me.ExcluirUsuárioToolStripMenuItem})
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.UsuáriosToolStripMenuItem.Text = "Configuração"
        '
        'CadastrarUsuárioToolStripMenuItem
        '
        Me.CadastrarUsuárioToolStripMenuItem.Name = "CadastrarUsuárioToolStripMenuItem"
        Me.CadastrarUsuárioToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.CadastrarUsuárioToolStripMenuItem.Text = "Cadastrar usuário"
        '
        'ExcluirUsuárioToolStripMenuItem
        '
        Me.ExcluirUsuárioToolStripMenuItem.Name = "ExcluirUsuárioToolStripMenuItem"
        Me.ExcluirUsuárioToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExcluirUsuárioToolStripMenuItem.Text = "Excluir usuário"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(173, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Inserir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MktxtPlaent)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(404, 117)
        Me.Panel1.TabIndex = 5
        '
        'MktxtPlaent
        '
        Me.MktxtPlaent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MktxtPlaent.Location = New System.Drawing.Point(38, 58)
        Me.MktxtPlaent.Mask = "AAA-0000"
        Me.MktxtPlaent.Name = "MktxtPlaent"
        Me.MktxtPlaent.Size = New System.Drawing.Size(100, 29)
        Me.MktxtPlaent.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Controle de Entrada"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Lbltotal)
        Me.Panel2.Controls.Add(Me.MskdBSai)
        Me.Panel2.Controls.Add(Me.BtnScart)
        Me.Panel2.Controls.Add(Me.btnSdin)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.RdBHot)
        Me.Panel2.Controls.Add(Me.RdBPern)
        Me.Panel2.Controls.Add(Me.RdBMot)
        Me.Panel2.Controls.Add(Me.RdBCarG)
        Me.Panel2.Controls.Add(Me.RdBCarP)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Location = New System.Drawing.Point(12, 166)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(404, 289)
        Me.Panel2.TabIndex = 6
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotal.ForeColor = System.Drawing.Color.Red
        Me.Lbltotal.Location = New System.Drawing.Point(132, 156)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(54, 22)
        Me.Lbltotal.TabIndex = 21
        Me.Lbltotal.Text = "0,00"
        '
        'MskdBSai
        '
        Me.MskdBSai.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MskdBSai.Location = New System.Drawing.Point(38, 75)
        Me.MskdBSai.Mask = "AAA-0000"
        Me.MskdBSai.Name = "MskdBSai"
        Me.MskdBSai.Size = New System.Drawing.Size(100, 29)
        Me.MskdBSai.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monospac821 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 22)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total R$"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Controle de Saída"
        '
        'RdBHot
        '
        Me.RdBHot.AutoSize = True
        Me.RdBHot.Location = New System.Drawing.Point(281, 110)
        Me.RdBHot.Name = "RdBHot"
        Me.RdBHot.Size = New System.Drawing.Size(50, 17)
        Me.RdBHot.TabIndex = 9
        Me.RdBHot.TabStop = True
        Me.RdBHot.Text = "Hotel"
        Me.RdBHot.UseVisualStyleBackColor = True
        '
        'RdBPern
        '
        Me.RdBPern.AutoSize = True
        Me.RdBPern.Location = New System.Drawing.Point(281, 87)
        Me.RdBPern.Name = "RdBPern"
        Me.RdBPern.Size = New System.Drawing.Size(64, 17)
        Me.RdBPern.TabIndex = 7
        Me.RdBPern.TabStop = True
        Me.RdBPern.Text = "Pernoite"
        Me.RdBPern.UseVisualStyleBackColor = True
        '
        'RdBMot
        '
        Me.RdBMot.AutoSize = True
        Me.RdBMot.Location = New System.Drawing.Point(281, 64)
        Me.RdBMot.Name = "RdBMot"
        Me.RdBMot.Size = New System.Drawing.Size(49, 17)
        Me.RdBMot.TabIndex = 6
        Me.RdBMot.TabStop = True
        Me.RdBMot.Text = "Moto"
        Me.RdBMot.UseVisualStyleBackColor = True
        '
        'RdBCarG
        '
        Me.RdBCarG.AutoSize = True
        Me.RdBCarG.Location = New System.Drawing.Point(281, 41)
        Me.RdBCarG.Name = "RdBCarG"
        Me.RdBCarG.Size = New System.Drawing.Size(88, 17)
        Me.RdBCarG.TabIndex = 5
        Me.RdBCarG.TabStop = True
        Me.RdBCarG.Text = "Carro Grande"
        Me.RdBCarG.UseVisualStyleBackColor = True
        '
        'RdBCarP
        '
        Me.RdBCarP.AutoSize = True
        Me.RdBCarP.Location = New System.Drawing.Point(281, 18)
        Me.RdBCarP.Name = "RdBCarP"
        Me.RdBCarP.Size = New System.Drawing.Size(96, 17)
        Me.RdBCarP.TabIndex = 4
        Me.RdBCarP.TabStop = True
        Me.RdBCarP.Text = "Carro Pequeno"
        Me.RdBCarP.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(173, 82)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Calcular"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monospac821 BT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(423, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Veiculos no patio"
        '
        'TimerSis
        '
        Me.TimerSis.Enabled = True
        Me.TimerSis.Interval = 1000
        '
        'lblhora
        '
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(661, 459)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(40, 16)
        Me.lblhora.TabIndex = 12
        Me.lblhora.Text = "Hora"
        '
        'lbldta
        '
        Me.lbldta.AutoSize = True
        Me.lbldta.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldta.Location = New System.Drawing.Point(651, 479)
        Me.lbldta.Name = "lbldta"
        Me.lbldta.Size = New System.Drawing.Size(40, 16)
        Me.lbldta.TabIndex = 13
        Me.lbldta.Text = "Data"
        '
        'BtnScart
        '
        Me.BtnScart.BackgroundImage = Global.HK_Park.My.Resources.Resources.constr_transfer_money_icon_icons_com_66402
        Me.BtnScart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnScart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnScart.Location = New System.Drawing.Point(202, 209)
        Me.BtnScart.Name = "BtnScart"
        Me.BtnScart.Size = New System.Drawing.Size(87, 52)
        Me.BtnScart.TabIndex = 16
        Me.BtnScart.UseVisualStyleBackColor = True
        '
        'btnSdin
        '
        Me.btnSdin.BackgroundImage = Global.HK_Park.My.Resources.Resources.cash_icon_icons_com_51090
        Me.btnSdin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSdin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSdin.Location = New System.Drawing.Point(73, 209)
        Me.btnSdin.Name = "btnSdin"
        Me.btnSdin.Size = New System.Drawing.Size(97, 52)
        Me.btnSdin.TabIndex = 13
        Me.btnSdin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 504)
        Me.Controls.Add(Me.lbldta)
        Me.Controls.Add(Me.lblhora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dtgrPatio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Controle HK Park"
        CType(Me.dtgrPatio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgrPatio As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents RotativoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MensalistasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RelatórioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastrarUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcluirUsuárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RdBHot As System.Windows.Forms.RadioButton
    Friend WithEvents RdBPern As System.Windows.Forms.RadioButton
    Friend WithEvents RdBMot As System.Windows.Forms.RadioButton
    Friend WithEvents RdBCarG As System.Windows.Forms.RadioButton
    Friend WithEvents RdBCarP As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSdin As System.Windows.Forms.Button
    Friend WithEvents MktxtPlaent As System.Windows.Forms.MaskedTextBox
    Friend WithEvents BtnScart As System.Windows.Forms.Button
    Friend WithEvents TimerSis As System.Windows.Forms.Timer
    Friend WithEvents lblhora As System.Windows.Forms.Label
    Friend WithEvents lbldta As System.Windows.Forms.Label
    Friend WithEvents PaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MskdBSai As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Lbltotal As System.Windows.Forms.Label

End Class
