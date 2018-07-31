<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta_Mensa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta_Mensa))
        Me.GBSelecionar = New System.Windows.Forms.GroupBox()
        Me.RdBtodos = New System.Windows.Forms.RadioButton()
        Me.RdBAberto = New System.Windows.Forms.RadioButton()
        Me.RdBPagos = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DtGdados = New System.Windows.Forms.DataGridView()
        Me.GBSelecionar.SuspendLayout()
        CType(Me.DtGdados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBSelecionar
        '
        Me.GBSelecionar.Controls.Add(Me.RdBtodos)
        Me.GBSelecionar.Controls.Add(Me.RdBAberto)
        Me.GBSelecionar.Controls.Add(Me.RdBPagos)
        Me.GBSelecionar.Location = New System.Drawing.Point(12, 21)
        Me.GBSelecionar.Name = "GBSelecionar"
        Me.GBSelecionar.Size = New System.Drawing.Size(317, 54)
        Me.GBSelecionar.TabIndex = 1
        Me.GBSelecionar.TabStop = False
        Me.GBSelecionar.Text = "Selecionar"
        '
        'RdBtodos
        '
        Me.RdBtodos.AutoSize = True
        Me.RdBtodos.Location = New System.Drawing.Point(238, 19)
        Me.RdBtodos.Name = "RdBtodos"
        Me.RdBtodos.Size = New System.Drawing.Size(55, 17)
        Me.RdBtodos.TabIndex = 3
        Me.RdBtodos.TabStop = True
        Me.RdBtodos.Text = "Todos"
        Me.RdBtodos.UseVisualStyleBackColor = True
        '
        'RdBAberto
        '
        Me.RdBAberto.AutoSize = True
        Me.RdBAberto.Location = New System.Drawing.Point(109, 19)
        Me.RdBAberto.Name = "RdBAberto"
        Me.RdBAberto.Size = New System.Drawing.Size(73, 17)
        Me.RdBAberto.TabIndex = 2
        Me.RdBAberto.TabStop = True
        Me.RdBAberto.Text = "Em aberto"
        Me.RdBAberto.UseVisualStyleBackColor = True
        '
        'RdBPagos
        '
        Me.RdBPagos.AutoSize = True
        Me.RdBPagos.Location = New System.Drawing.Point(6, 19)
        Me.RdBPagos.Name = "RdBPagos"
        Me.RdBPagos.Size = New System.Drawing.Size(55, 17)
        Me.RdBPagos.TabIndex = 1
        Me.RdBPagos.TabStop = True
        Me.RdBPagos.Text = "Pagos"
        Me.RdBPagos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Pesquisar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DtGdados
        '
        Me.DtGdados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGdados.Location = New System.Drawing.Point(12, 81)
        Me.DtGdados.Name = "DtGdados"
        Me.DtGdados.Size = New System.Drawing.Size(692, 431)
        Me.DtGdados.TabIndex = 3
        '
        'Consulta_Mensa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 526)
        Me.Controls.Add(Me.DtGdados)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GBSelecionar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consulta_Mensa"
        Me.Text = "Consulta Mensalistas HK-Park"
        Me.GBSelecionar.ResumeLayout(False)
        Me.GBSelecionar.PerformLayout()
        CType(Me.DtGdados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GBSelecionar As System.Windows.Forms.GroupBox
    Friend WithEvents RdBtodos As System.Windows.Forms.RadioButton
    Friend WithEvents RdBAberto As System.Windows.Forms.RadioButton
    Friend WithEvents RdBPagos As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DtGdados As System.Windows.Forms.DataGridView
End Class
