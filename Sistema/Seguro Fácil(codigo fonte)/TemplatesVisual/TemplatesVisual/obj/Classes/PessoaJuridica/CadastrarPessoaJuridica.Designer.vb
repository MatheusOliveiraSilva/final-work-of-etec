﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastrarPessoaJuridica
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastrarPessoaJuridica))
        Me.LabelDescPag = New DevExpress.XtraEditors.LabelControl()
        Me.LabelCNPJ = New System.Windows.Forms.Label()
        Me.MaskTxtCnpj = New System.Windows.Forms.MaskedTextBox()
        Me.LabelAreaDeAtuacao = New System.Windows.Forms.Label()
        Me.txtAreaAtuacao = New System.Windows.Forms.TextBox()
        Me.LabelSite = New System.Windows.Forms.Label()
        Me.txtSite = New System.Windows.Forms.TextBox()
        Me.LabelEndereco = New System.Windows.Forms.Label()
        Me.LabelNumero = New System.Windows.Forms.Label()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.cboUf = New System.Windows.Forms.ComboBox()
        Me.MaskTxtCep = New System.Windows.Forms.MaskedTextBox()
        Me.LabelCEP = New System.Windows.Forms.Label()
        Me.LabelUF = New System.Windows.Forms.Label()
        Me.LabelBairro = New System.Windows.Forms.Label()
        Me.LabelCidade = New System.Windows.Forms.Label()
        Me.LabelTelefone1 = New System.Windows.Forms.Label()
        Me.MaskTxtTelefone1 = New System.Windows.Forms.MaskedTextBox()
        Me.LabelTelefone2 = New System.Windows.Forms.Label()
        Me.MaskTxtTelefone2 = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblRSocial = New System.Windows.Forms.Label()
        Me.txtRSocial = New System.Windows.Forms.TextBox()
        Me.LblNFantasia = New System.Windows.Forms.Label()
        Me.TxtNFantasia = New System.Windows.Forms.TextBox()
        Me.TxtComentarios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtComplemento = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnPrimeiro = New System.Windows.Forms.ToolStripButton()
        Me.btnVoltar = New System.Windows.Forms.ToolStripButton()
        Me.btnIr = New System.Windows.Forms.ToolStripButton()
        Me.btnUltimo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnExcluir = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCadastrar = New System.Windows.Forms.ToolStripButton()
        Me.BtLimpar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRepresent = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtApto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBloco = New System.Windows.Forms.TextBox()
        Me.lbBloco = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lbEmail = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPesquisa = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbxComentario = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxComentario.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelDescPag
        '
        Me.LabelDescPag.Appearance.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescPag.Location = New System.Drawing.Point(12, 12)
        Me.LabelDescPag.Name = "LabelDescPag"
        Me.LabelDescPag.Size = New System.Drawing.Size(252, 24)
        Me.LabelDescPag.TabIndex = 1
        Me.LabelDescPag.Text = "Cadastro de Pessoa Jurídica"
        '
        'LabelCNPJ
        '
        Me.LabelCNPJ.AutoSize = True
        Me.LabelCNPJ.BackColor = System.Drawing.Color.Transparent
        Me.LabelCNPJ.Location = New System.Drawing.Point(365, 81)
        Me.LabelCNPJ.Name = "LabelCNPJ"
        Me.LabelCNPJ.Size = New System.Drawing.Size(47, 13)
        Me.LabelCNPJ.TabIndex = 17
        Me.LabelCNPJ.Text = "CNPJ:*"
        '
        'MaskTxtCnpj
        '
        Me.MaskTxtCnpj.Location = New System.Drawing.Point(429, 78)
        Me.MaskTxtCnpj.Mask = "00,000,000/0000-00"
        Me.MaskTxtCnpj.Name = "MaskTxtCnpj"
        Me.MaskTxtCnpj.Size = New System.Drawing.Size(144, 20)
        Me.MaskTxtCnpj.TabIndex = 18
        '
        'LabelAreaDeAtuacao
        '
        Me.LabelAreaDeAtuacao.AutoSize = True
        Me.LabelAreaDeAtuacao.BackColor = System.Drawing.Color.Transparent
        Me.LabelAreaDeAtuacao.Location = New System.Drawing.Point(16, 51)
        Me.LabelAreaDeAtuacao.Name = "LabelAreaDeAtuacao"
        Me.LabelAreaDeAtuacao.Size = New System.Drawing.Size(101, 13)
        Me.LabelAreaDeAtuacao.TabIndex = 11
        Me.LabelAreaDeAtuacao.Text = "Área de Atuação:*"
        '
        'txtAreaAtuacao
        '
        Me.txtAreaAtuacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAreaAtuacao.Location = New System.Drawing.Point(134, 51)
        Me.txtAreaAtuacao.MaxLength = 20
        Me.txtAreaAtuacao.Name = "txtAreaAtuacao"
        Me.txtAreaAtuacao.Size = New System.Drawing.Size(175, 20)
        Me.txtAreaAtuacao.TabIndex = 12
        '
        'LabelSite
        '
        Me.LabelSite.AutoSize = True
        Me.LabelSite.BackColor = System.Drawing.Color.Transparent
        Me.LabelSite.Location = New System.Drawing.Point(79, 81)
        Me.LabelSite.Name = "LabelSite"
        Me.LabelSite.Size = New System.Drawing.Size(38, 13)
        Me.LabelSite.TabIndex = 15
        Me.LabelSite.Text = "Site:*"
        '
        'txtSite
        '
        Me.txtSite.Location = New System.Drawing.Point(134, 78)
        Me.txtSite.MaxLength = 120
        Me.txtSite.Name = "txtSite"
        Me.txtSite.Size = New System.Drawing.Size(175, 20)
        Me.txtSite.TabIndex = 16
        '
        'LabelEndereco
        '
        Me.LabelEndereco.AutoSize = True
        Me.LabelEndereco.BackColor = System.Drawing.Color.Transparent
        Me.LabelEndereco.Location = New System.Drawing.Point(26, 22)
        Me.LabelEndereco.Name = "LabelEndereco"
        Me.LabelEndereco.Size = New System.Drawing.Size(64, 13)
        Me.LabelEndereco.TabIndex = 20
        Me.LabelEndereco.Text = "Endereço:*"
        '
        'LabelNumero
        '
        Me.LabelNumero.AutoSize = True
        Me.LabelNumero.BackColor = System.Drawing.Color.Transparent
        Me.LabelNumero.Location = New System.Drawing.Point(349, 23)
        Me.LabelNumero.Name = "LabelNumero"
        Me.LabelNumero.Size = New System.Drawing.Size(29, 13)
        Me.LabelNumero.TabIndex = 22
        Me.LabelNumero.Text = "N°:*"
        '
        'txtNumero
        '
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Location = New System.Drawing.Point(391, 18)
        Me.txtNumero.MaxLength = 7
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(66, 20)
        Me.txtNumero.TabIndex = 23
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(111, 47)
        Me.txtBairro.MaxLength = 60
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(207, 20)
        Me.txtBairro.TabIndex = 27
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(556, 44)
        Me.txtCidade.MaxLength = 60
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 31
        '
        'cboUf
        '
        Me.cboUf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUf.FormattingEnabled = True
        Me.cboUf.Items.AddRange(New Object() {"Selecione", "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PR", "PB", "PA", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SE", "SP", "TO"})
        Me.cboUf.Location = New System.Drawing.Point(376, 44)
        Me.cboUf.MaxLength = 2
        Me.cboUf.Name = "cboUf"
        Me.cboUf.Size = New System.Drawing.Size(99, 21)
        Me.cboUf.TabIndex = 29
        '
        'MaskTxtCep
        '
        Me.MaskTxtCep.Location = New System.Drawing.Point(540, 15)
        Me.MaskTxtCep.Mask = "00000-000"
        Me.MaskTxtCep.Name = "MaskTxtCep"
        Me.MaskTxtCep.Size = New System.Drawing.Size(100, 20)
        Me.MaskTxtCep.TabIndex = 25
        '
        'LabelCEP
        '
        Me.LabelCEP.AutoSize = True
        Me.LabelCEP.BackColor = System.Drawing.Color.Transparent
        Me.LabelCEP.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCEP.Location = New System.Drawing.Point(412, 21)
        Me.LabelCEP.Name = "LabelCEP"
        Me.LabelCEP.Size = New System.Drawing.Size(40, 15)
        Me.LabelCEP.TabIndex = 24
        Me.LabelCEP.Text = "CEP:*"
        '
        'LabelUF
        '
        Me.LabelUF.AutoSize = True
        Me.LabelUF.BackColor = System.Drawing.Color.Transparent
        Me.LabelUF.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUF.Location = New System.Drawing.Point(283, 49)
        Me.LabelUF.Name = "LabelUF"
        Me.LabelUF.Size = New System.Drawing.Size(32, 15)
        Me.LabelUF.TabIndex = 28
        Me.LabelUF.Text = "UF:*"
        '
        'LabelBairro
        '
        Me.LabelBairro.AutoSize = True
        Me.LabelBairro.BackColor = System.Drawing.Color.Transparent
        Me.LabelBairro.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBairro.Location = New System.Drawing.Point(39, 49)
        Me.LabelBairro.Name = "LabelBairro"
        Me.LabelBairro.Size = New System.Drawing.Size(51, 15)
        Me.LabelBairro.TabIndex = 26
        Me.LabelBairro.Text = "Bairro:*"
        '
        'LabelCidade
        '
        Me.LabelCidade.AutoSize = True
        Me.LabelCidade.BackColor = System.Drawing.Color.Transparent
        Me.LabelCidade.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCidade.Location = New System.Drawing.Point(417, 49)
        Me.LabelCidade.Name = "LabelCidade"
        Me.LabelCidade.Size = New System.Drawing.Size(54, 15)
        Me.LabelCidade.TabIndex = 30
        Me.LabelCidade.Text = "Cidade:*"
        '
        'LabelTelefone1
        '
        Me.LabelTelefone1.AutoSize = True
        Me.LabelTelefone1.BackColor = System.Drawing.Color.Transparent
        Me.LabelTelefone1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefone1.Location = New System.Drawing.Point(11, 22)
        Me.LabelTelefone1.Name = "LabelTelefone1"
        Me.LabelTelefone1.Size = New System.Drawing.Size(72, 15)
        Me.LabelTelefone1.TabIndex = 43
        Me.LabelTelefone1.Text = "Telefone 1:*"
        '
        'MaskTxtTelefone1
        '
        Me.MaskTxtTelefone1.Location = New System.Drawing.Point(105, 19)
        Me.MaskTxtTelefone1.Mask = "(00)0000-0000"
        Me.MaskTxtTelefone1.Name = "MaskTxtTelefone1"
        Me.MaskTxtTelefone1.Size = New System.Drawing.Size(98, 20)
        Me.MaskTxtTelefone1.TabIndex = 44
        '
        'LabelTelefone2
        '
        Me.LabelTelefone2.AutoSize = True
        Me.LabelTelefone2.BackColor = System.Drawing.Color.Transparent
        Me.LabelTelefone2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefone2.Location = New System.Drawing.Point(189, 22)
        Me.LabelTelefone2.Name = "LabelTelefone2"
        Me.LabelTelefone2.Size = New System.Drawing.Size(52, 15)
        Me.LabelTelefone2.TabIndex = 45
        Me.LabelTelefone2.Text = "Celular:"
        '
        'MaskTxtTelefone2
        '
        Me.MaskTxtTelefone2.Location = New System.Drawing.Point(282, 19)
        Me.MaskTxtTelefone2.Mask = "(00)00000-0000"
        Me.MaskTxtTelefone2.Name = "MaskTxtTelefone2"
        Me.MaskTxtTelefone2.Size = New System.Drawing.Size(98, 20)
        Me.MaskTxtTelefone2.TabIndex = 46
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'LblRSocial
        '
        Me.LblRSocial.AutoSize = True
        Me.LblRSocial.BackColor = System.Drawing.Color.Transparent
        Me.LblRSocial.Location = New System.Drawing.Point(33, 21)
        Me.LblRSocial.Name = "LblRSocial"
        Me.LblRSocial.Size = New System.Drawing.Size(84, 13)
        Me.LblRSocial.TabIndex = 7
        Me.LblRSocial.Text = "Razão Social:*"
        '
        'txtRSocial
        '
        Me.txtRSocial.Location = New System.Drawing.Point(134, 22)
        Me.txtRSocial.MaxLength = 50
        Me.txtRSocial.Name = "txtRSocial"
        Me.txtRSocial.Size = New System.Drawing.Size(175, 20)
        Me.txtRSocial.TabIndex = 8
        '
        'LblNFantasia
        '
        Me.LblNFantasia.AutoSize = True
        Me.LblNFantasia.BackColor = System.Drawing.Color.Transparent
        Me.LblNFantasia.Location = New System.Drawing.Point(319, 23)
        Me.LblNFantasia.Name = "LblNFantasia"
        Me.LblNFantasia.Size = New System.Drawing.Size(94, 13)
        Me.LblNFantasia.TabIndex = 9
        Me.LblNFantasia.Text = "Nome Fantasia:*"
        '
        'TxtNFantasia
        '
        Me.TxtNFantasia.Location = New System.Drawing.Point(429, 21)
        Me.TxtNFantasia.MaxLength = 50
        Me.TxtNFantasia.Name = "TxtNFantasia"
        Me.TxtNFantasia.Size = New System.Drawing.Size(115, 20)
        Me.TxtNFantasia.TabIndex = 10
        '
        'TxtComentarios
        '
        Me.TxtComentarios.Location = New System.Drawing.Point(16, 21)
        Me.TxtComentarios.MaxLength = 300
        Me.TxtComentarios.Multiline = True
        Me.TxtComentarios.Name = "TxtComentarios"
        Me.TxtComentarios.Size = New System.Drawing.Size(641, 72)
        Me.TxtComentarios.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(245, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Complemento:"
        '
        'txtComplemento
        '
        Me.txtComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtComplemento.Location = New System.Drawing.Point(344, 78)
        Me.txtComplemento.MaxLength = 45
        Me.txtComplemento.Name = "txtComplemento"
        Me.txtComplemento.Size = New System.Drawing.Size(209, 20)
        Me.txtComplemento.TabIndex = 35
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btnPrimeiro, Me.btnVoltar, Me.btnIr, Me.btnUltimo, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.btnExcluir, Me.btnAlterar, Me.ToolStripSeparator4, Me.BtnCadastrar, Me.BtLimpar, Me.ToolStripSeparator5, Me.btnCancelar, Me.btnImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 500)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStrip1.Size = New System.Drawing.Size(746, 79)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
        '
        'btnPrimeiro
        '
        Me.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnPrimeiro.Image = CType(resources.GetObject("btnPrimeiro.Image"), System.Drawing.Image)
        Me.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrimeiro.Name = "btnPrimeiro"
        Me.btnPrimeiro.Size = New System.Drawing.Size(68, 76)
        Me.btnPrimeiro.Text = "Voltar ao ultimo"
        Me.btnPrimeiro.ToolTipText = "Ir para o primeiro"
        '
        'btnVoltar
        '
        Me.btnVoltar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnVoltar.Image = CType(resources.GetObject("btnVoltar.Image"), System.Drawing.Image)
        Me.btnVoltar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(68, 76)
        Me.btnVoltar.Text = "Voltar ao anterior"
        Me.btnVoltar.ToolTipText = "Voltar"
        '
        'btnIr
        '
        Me.btnIr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnIr.Image = CType(resources.GetObject("btnIr.Image"), System.Drawing.Image)
        Me.btnIr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnIr.Name = "btnIr"
        Me.btnIr.Size = New System.Drawing.Size(68, 76)
        Me.btnIr.Text = "Ir ao proximo"
        Me.btnIr.ToolTipText = "Ir para o proximo"
        '
        'btnUltimo
        '
        Me.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUltimo.Image = CType(resources.GetObject("btnUltimo.Image"), System.Drawing.Image)
        Me.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(68, 76)
        Me.btnUltimo.Text = "Ir ao ultimo"
        Me.btnUltimo.ToolTipText = "Ir para o Ultimo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 79)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'btnExcluir
        '
        Me.btnExcluir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(68, 76)
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.ToolTipText = "Excluir"
        '
        'btnAlterar
        '
        Me.btnAlterar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(68, 76)
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.ToolTipText = "Alterar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 79)
        '
        'BtnCadastrar
        '
        Me.BtnCadastrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCadastrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCadastrar.Image = Global.SeguroFacil.My.Resources.Resources.Botão
        Me.BtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCadastrar.Name = "BtnCadastrar"
        Me.BtnCadastrar.Size = New System.Drawing.Size(68, 76)
        Me.BtnCadastrar.Text = "Cadastrar"
        Me.BtnCadastrar.ToolTipText = "Cadastrar"
        '
        'BtLimpar
        '
        Me.BtLimpar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtLimpar.Image = CType(resources.GetObject("BtLimpar.Image"), System.Drawing.Image)
        Me.BtLimpar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtLimpar.Name = "BtLimpar"
        Me.BtLimpar.Size = New System.Drawing.Size(68, 76)
        Me.BtLimpar.Text = "Novo"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 79)
        '
        'btnCancelar
        '
        Me.btnCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(68, 76)
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(68, 76)
        Me.btnImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtRepresent)
        Me.GroupBox2.Controls.Add(Me.txtRSocial)
        Me.GroupBox2.Controls.Add(Me.LabelCNPJ)
        Me.GroupBox2.Controls.Add(Me.MaskTxtCnpj)
        Me.GroupBox2.Controls.Add(Me.LabelAreaDeAtuacao)
        Me.GroupBox2.Controls.Add(Me.txtAreaAtuacao)
        Me.GroupBox2.Controls.Add(Me.LabelSite)
        Me.GroupBox2.Controls.Add(Me.TxtNFantasia)
        Me.GroupBox2.Controls.Add(Me.txtSite)
        Me.GroupBox2.Controls.Add(Me.LblNFantasia)
        Me.GroupBox2.Controls.Add(Me.LblRSocial)
        Me.GroupBox2.Location = New System.Drawing.Point(99, 47)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(558, 116)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informações da empresa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(319, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Representante:*"
        '
        'txtRepresent
        '
        Me.txtRepresent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRepresent.Location = New System.Drawing.Point(429, 48)
        Me.txtRepresent.MaxLength = 75
        Me.txtRepresent.Name = "txtRepresent"
        Me.txtRepresent.Size = New System.Drawing.Size(115, 20)
        Me.txtRepresent.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApto)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtEndereco)
        Me.GroupBox1.Controls.Add(Me.txtItem)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtBloco)
        Me.GroupBox1.Controls.Add(Me.lbBloco)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.LabelUF)
        Me.GroupBox1.Controls.Add(Me.txtCidade)
        Me.GroupBox1.Controls.Add(Me.LabelBairro)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.txtBairro)
        Me.GroupBox1.Controls.Add(Me.txtComplemento)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LabelCidade)
        Me.GroupBox1.Controls.Add(Me.LabelNumero)
        Me.GroupBox1.Controls.Add(Me.cboUf)
        Me.GroupBox1.Controls.Add(Me.LabelEndereco)
        Me.GroupBox1.Controls.Add(Me.MaskTxtCep)
        Me.GroupBox1.Controls.Add(Me.LabelCEP)
        Me.GroupBox1.Location = New System.Drawing.Point(91, 169)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(569, 149)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Endereço"
        '
        'txtApto
        '
        Me.txtApto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtApto.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApto.Location = New System.Drawing.Point(96, 77)
        Me.txtApto.MaxLength = 4
        Me.txtApto.Name = "txtApto"
        Me.txtApto.Size = New System.Drawing.Size(108, 22)
        Me.txtApto.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 15)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Apto."
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(110, 19)
        Me.txtEndereco.MaxLength = 60
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(220, 20)
        Me.txtEndereco.TabIndex = 21
        '
        'txtItem
        '
        Me.txtItem.Enabled = False
        Me.txtItem.Location = New System.Drawing.Point(286, 117)
        Me.txtItem.MaxLength = 20
        Me.txtItem.Name = "txtItem"
        Me.txtItem.Size = New System.Drawing.Size(82, 20)
        Me.txtItem.TabIndex = 39
        Me.txtItem.Text = "Auto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(245, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Item:"
        '
        'txtBloco
        '
        Me.txtBloco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBloco.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBloco.Location = New System.Drawing.Point(96, 116)
        Me.txtBloco.MaxLength = 2
        Me.txtBloco.Name = "txtBloco"
        Me.txtBloco.Size = New System.Drawing.Size(108, 22)
        Me.txtBloco.TabIndex = 37
        '
        'lbBloco
        '
        Me.lbBloco.AutoSize = True
        Me.lbBloco.BackColor = System.Drawing.Color.Transparent
        Me.lbBloco.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbBloco.Location = New System.Drawing.Point(50, 119)
        Me.lbBloco.Name = "lbBloco"
        Me.lbBloco.Size = New System.Drawing.Size(40, 15)
        Me.lbBloco.TabIndex = 36
        Me.lbBloco.Text = "Bloco:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(332, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 15)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Status:*"
        '
        'cboStatus
        '
        Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Selecione", "Aguardando confirmação", "Frio", "Morno", "Quente", "Ativo"})
        Me.cboStatus.Location = New System.Drawing.Point(470, 116)
        Me.cboStatus.MaxLength = 22
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(169, 21)
        Me.cboStatus.TabIndex = 41
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtEmail)
        Me.GroupBox3.Controls.Add(Me.lbEmail)
        Me.GroupBox3.Controls.Add(Me.MaskTxtTelefone1)
        Me.GroupBox3.Controls.Add(Me.LabelTelefone1)
        Me.GroupBox3.Controls.Add(Me.LabelTelefone2)
        Me.GroupBox3.Controls.Add(Me.MaskTxtTelefone2)
        Me.GroupBox3.Location = New System.Drawing.Point(70, 324)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(602, 61)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contato"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(393, 15)
        Me.txtEmail.MaxLength = 60
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 22)
        Me.txtEmail.TabIndex = 48
        '
        'lbEmail
        '
        Me.lbEmail.AutoSize = True
        Me.lbEmail.BackColor = System.Drawing.Color.Transparent
        Me.lbEmail.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmail.Location = New System.Drawing.Point(342, 22)
        Me.lbEmail.Name = "lbEmail"
        Me.lbEmail.Size = New System.Drawing.Size(48, 15)
        Me.lbEmail.TabIndex = 47
        Me.lbEmail.Text = "Email:*"
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(656, 18)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(46, 20)
        Me.txtId.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(627, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Pesquisa:"
        '
        'txtPesquisa
        '
        Me.txtPesquisa.Location = New System.Drawing.Point(398, 16)
        Me.txtPesquisa.Mask = "00,000,000/0000-00"
        Me.txtPesquisa.Name = "txtPesquisa"
        Me.txtPesquisa.Size = New System.Drawing.Size(114, 20)
        Me.txtPesquisa.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(523, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 74
        Me.PictureBox1.TabStop = False
        '
        'gbxComentario
        '
        Me.gbxComentario.Controls.Add(Me.TxtComentarios)
        Me.gbxComentario.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxComentario.Location = New System.Drawing.Point(39, 391)
        Me.gbxComentario.Name = "gbxComentario"
        Me.gbxComentario.Size = New System.Drawing.Size(670, 100)
        Me.gbxComentario.TabIndex = 49
        Me.gbxComentario.TabStop = False
        Me.gbxComentario.Text = "Comentários"
        '
        'CadastrarPessoaJuridica
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 579)
        Me.Controls.Add(Me.txtPesquisa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.LabelDescPag)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbxComentario)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadastrarPessoaJuridica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "= Cadastrar Pessoa Juridica ="
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxComentario.ResumeLayout(False)
        Me.gbxComentario.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDescPag As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelCNPJ As System.Windows.Forms.Label
    Friend WithEvents MaskTxtCnpj As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelAreaDeAtuacao As System.Windows.Forms.Label
    Friend WithEvents txtAreaAtuacao As System.Windows.Forms.TextBox
    Friend WithEvents LabelSite As System.Windows.Forms.Label
    Friend WithEvents txtSite As System.Windows.Forms.TextBox
    Friend WithEvents LabelEndereco As System.Windows.Forms.Label
    Friend WithEvents LabelNumero As System.Windows.Forms.Label
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents cboUf As System.Windows.Forms.ComboBox
    Friend WithEvents MaskTxtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelCEP As System.Windows.Forms.Label
    Friend WithEvents LabelUF As System.Windows.Forms.Label
    Friend WithEvents LabelBairro As System.Windows.Forms.Label
    Friend WithEvents LabelCidade As System.Windows.Forms.Label
    Friend WithEvents LabelTelefone1 As System.Windows.Forms.Label
    Friend WithEvents MaskTxtTelefone1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents LabelTelefone2 As System.Windows.Forms.Label
    Friend WithEvents MaskTxtTelefone2 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LblRSocial As System.Windows.Forms.Label
    Friend WithEvents txtRSocial As System.Windows.Forms.TextBox
    Friend WithEvents LblNFantasia As System.Windows.Forms.Label
    Friend WithEvents TxtNFantasia As System.Windows.Forms.TextBox
    Friend WithEvents TxtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtComplemento As System.Windows.Forms.TextBox
    Friend WithEvents btnPrimeiro As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVoltar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnIr As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUltimo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnExcluir As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAlterar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnCadastrar As System.Windows.Forms.ToolStripButton
    Friend WithEvents BtLimpar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRepresent As System.Windows.Forms.TextBox
    Friend WithEvents txtPesquisa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents gbxComentario As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lbEmail As System.Windows.Forms.Label
    Friend WithEvents txtBloco As System.Windows.Forms.TextBox
    Friend WithEvents lbBloco As System.Windows.Forms.Label
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents txtApto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
