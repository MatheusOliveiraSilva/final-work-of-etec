Option Compare Text
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class PesquisaTS

    Dim Navegacao As New Navegar
    Dim Objeto As New F_ObjetoCli
    Dim IdPessoaFisica As String
    Dim CPFPessoaFisica As String

    ' INICIO EVENTO LOAD
    Private Sub CadastrarPessoaFisica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        TudoBloqueado()
        btnPrimeiro.Enabled = False
        btnVoltar.Enabled = False
        btnIr.Enabled = True
        btnUltimo.Enabled = True
    End Sub
    ' FIM EVENTO LOAD
    ' INICIO PESQUISA DE CEP
    Private Sub MaskTxtCep_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskTxtCep.MaskInputRejected
        If MaskTxtCep.TextLength = 9 Then
            Dim PesquisarCep As New ConsultarCEP
            PesquisarCep.Consultar()
        End If
    End Sub

    Private Sub PesquisarCPF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles PesquisarCPF.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True 'Para o BEEP da text
            Dim ConsultarCPF As New PesquisarCPF_Consu
            ConsultarCPF.Consultar()
        End If
    End Sub
    ' FIM PESQUISA DE CEP

    ' INICIO PESQUISA DE CPF
    Private Sub PesquisarCPF_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles PesquisarCPF.MaskInputRejected
        If PesquisarCPF.TextLength = 13 Then
            Dim ConsultarCPF As New PesquisarCPF_Consu
            ConsultarCPF.Consultar()
        End If
       
    End Sub
    ' FIM DE PESQUISA DE CPF
    '================================== INICIO EVENTOS DOS BOTÕES ==============================================

    ' INICIO DO BOTAO CADASTRAR
    Private Sub BtnCadastrar_Click(sender As Object, e As EventArgs) Handles BtnCadastrar.Click
        Try
            Validacao()
        Catch ex As Exception
            MsgBox("Erro ao cadastrar Pessoa Fisica " & ex.Message)
        End Try
    End Sub
    ' FIM DO BOTÃO CADASTRAR

    ' INICIO DO BOTAO EXCLUIR
    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim result As Integer = MessageBox.Show("Quer Realmente excluir esse cliente?", "Sola Fide", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            Deletar()
        End If
    End Sub
    ' FIM DO BOTAO EXCLUIR

    ' INICIO BOTAO ALTERAR
    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If txtNome.Enabled = False Then
            Desbloqueado()
            BtnCadastrar.Enabled = False
            BtLimpar.Enabled = False
            btnCancelar.Visible = True
            btnExcluir.Enabled = False
            PesquisarCPF.Enabled = False
        ElseIf txtNome.Enabled = True Then
            ValidacaoAlterar()

        End If
    End Sub
    ' FIM BOTAO ALTERAR

    ' INICIO BOTAO CANCELAR
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim result As Integer = MessageBox.Show("Quer realmente cancelar?", "Seguro Fácil", MessageBoxButtons.YesNo)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then

            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.AtualizarForm()
            Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
            DesbloqueiaNavegacao()
            TudoBloqueado()
        End If
    End Sub
    ' FIM BOTAO CANCELAR
    ' INICIO BOTAO IMPRIMIR
    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        RelatorioPessoaFisica.Show()

    End Sub
    ' FIM BOTAO IMPRIMIR

    ' INICIO BOTAO LIMPAR
    Private Sub BtLimpar_Click(sender As Object, e As EventArgs) Handles BtLimpar.Click
        Novo()
        Desbloqueado()
        Bloqueanavegacao()
    End Sub
    ' FIM BOTAO LIMPAR

    '=================================== FIM EVENTOS DOS BOTÕES ================================================

    '======================================INICIO DOS EVENTOS ==================================================

    ' INICIO EVENTO CADASTRAR
    Public Sub Cadastrar()
        'Declaração de variaveis
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")

        Dim UsandoBanco As USBanco = New USBanco()
        Dim PbancoSexo As BancoSexo
        Dim PbancoEndereco As BancoEndereco
        Dim PBancoEstadoCivil As BancoEstadoCivil
        Dim PBancoContato As BancoContato
        Dim Pbanco As BancoCliente
        Dim PItem As BancoItem

        'Usando a Classe BancoCliente e armazenando os dados recebidos pela form
        Pbanco = New BancoCliente(txtNome.Text, MaskTxtCpf.Text, MaskedTextBox1.Text, MaskTxtDataExp.Text, txtOrgExp.Text, txtCNH.Text, txtTempoHab.Text, cboTempoHab.Text, Convert.ToDateTime(MaskTxtNascimento.Text).ToString("yyyy/MM/dd"), txtProfissao.Text, cboStatus.Text, txtComentario.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoCliente
        UsandoBanco.UsandoDadosClientes(Pbanco)

        'Inicio Codigo para pegar o id do ultimo cadastro em Pessoa Fisica
        Try


            ' Selecciona da  tabela "MyTable" o máximo/último ID (identificador único)
            Dim SQL As String = ("SELECT Max(id_Pessoa_Fisica) FROM solafide_v6.tb_pessoa_fisica;")

            ' Cria uma nova ligação à base de dados
            Dim connection As New MySqlConnection(myConnectionString)

            ' Criação do comando indicando a instrução e a ligação
            Dim command As New MySqlCommand(SQL, connection)

            ' Abre a ligação
            connection.Open()

            ' Executa o comando e guarda em “total” o último registo
            IdPessoaFisica = command.ExecuteScalar.ToString
            ' Fecha a ligação e limpa as variáveis
            connection.Close()
            connection = Nothing
            command = Nothing
        Catch ex As Exception
            MsgBox("Erro no select Max Pessoa Fisica" & ex.Message)
        End Try


        'Fim Codigo para pegar o id do ultimo cadastro em Pessoa Fisica


        'Usando a Classe BancoSexo e armazenando os dados recebidos pela form
        PbancoSexo = New BancoSexo(cboSexo.Text, IdPessoaFisica)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoSexo
        UsandoBanco.UsandoDadosBancoSexo(PbancoSexo)

        'Usando a Classe BancoEndereco e armazenando os dados recebidos pela form
        PbancoEndereco = New BancoEndereco(txtEndereco.Text, CInt(txtNumCasa.Text), MaskTxtCep.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, txtComplemento.Text, txtBloco.Text, txtApto.Text, IdPessoaFisica)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoEndereco
        UsandoBanco.UsandoDadosEndereco(PbancoEndereco)

        'Usando a Classe BancoEstadoCivil e armazenando os dados recebidos pela form
        PBancoEstadoCivil = New BancoEstadoCivil(cboEstCivil.Text, IdPessoaFisica)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoEstadoCivil
        UsandoBanco.UsandoDadosEstadoCivil(PBancoEstadoCivil)

        'Usando a Classe BancoContato e armazenando os dados recebidos pela form
        PBancoContato = New BancoContato(MaskTxtResidencial.Text, MaskTxtComercial.Text, MaskTxtCelular.Text, txtNextel.Text, txtEmail.Text, IdPessoaFisica)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoContato
        UsandoBanco.UsandoDadosContato(PBancoContato)

        PItem = New BancoItem(txtItem.Text, IdPessoaFisica)

        UsandoBanco.UsandoDadosItem(PItem)


        TudoBloqueado()
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()
        Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)

        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()


    End Sub
    ' FIM EVENTO CADASTRAR

    ' INICIO EVENTO NOVO
    Public Sub Novo()
        Objeto.Novo()
    End Sub
    ' FIM EVENTO NOVO

    ' INICIO EVENTO DELETAR
    Private Sub Deletar()
        Try

            Dim CMD2 As New MySqlCommand("Delete From solafide_v6.tb_Pessoa_Fisica where id_Pessoa_Fisica=" & TxtId.Text)
            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()
            CMD2.Connection.Close()

            MessageBox.Show("Excluido com sucesso")
            Novo()
            Navegacao.DescarregarForm()
            Navegacao.CarregarForm()
            Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
            Navegacao.AtualizarForm()

        Catch ex As Exception
            MsgBox("Erro ao excluir-" + ex.Message)
        End Try

    End Sub
    ' FIM EVENTO DELETAR

    ' INICIO EVENTO ATUALIZAR
    Public Sub Atualizar()
        'Declaração de variaveis
        Dim myConnectionString As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")

        Dim UsandoBancoUP As UsarBancoUpdate = New UsarBancoUpdate()
        Dim UPSexo As UpdateSexo
        Dim UPDT_Endereco As UpdateEndereco
        Dim UPDT_EstCivil As Update_EstadoCivil
        Dim UPDT_Contato As UpdateContato
        Dim UpBanco As UpdateCliente


        UpBanco = New UpdateCliente(txtNome.Text, MaskTxtCpf.Text, MaskedTextBox1.Text, MaskTxtDataExp.Text, txtOrgExp.Text, txtCNH.Text, txtTempoHab.Text, cboTempoHab.Text, Convert.ToDateTime(MaskTxtNascimento.Text).ToString("yyyy/MM/dd"), txtProfissao.Text, TxtId.Text, cboStatus.Text, txtComentario.Text)

        UsandoBancoUP.UpdateCliente(UpBanco)

        'Usando a Classe BancoSexo e armazenando os dados recebidos pela form
        UPSexo = New UpdateSexo(cboSexo.Text, TxtId.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoSexo
        UsandoBancoUP.UpdateSexo(UPSexo)

        'Usando a Classe BancoEndereco e armazenando os dados recebidos pela form
        UPDT_Endereco = New UpdateEndereco(txtEndereco.Text, CInt(txtNumCasa.Text), MaskTxtCep.Text, txtBairro.Text, txtCidade.Text, cboUf.Text, txtComplemento.Text, txtBloco.Text, txtApto.Text, TxtId.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoEndereco
        UsandoBancoUP.UpdateEndereco(UPDT_Endereco)

        'Usando a Classe BancoEstadoCivil e armazenando os dados recebidos pela form
        UPDT_EstCivil = New Update_EstadoCivil(cboEstCivil.Text, TxtId.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoEstadoCivil
        UsandoBancoUP.UpdateEstadoCivil(UPDT_EstCivil)

        'Usando a Classe BancoContato e armazenando os dados recebidos pela form
        UPDT_Contato = New UpdateContato(MaskTxtResidencial.Text, MaskTxtComercial.Text, MaskTxtCelular.Text, txtNextel.Text, txtEmail.Text, TxtId.Text)

        'Cadastrando no Banco os dados os dados armazenados na classe BancoContato
        UsandoBancoUP.UpdateContato(UPDT_Contato)

        Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
        Navegacao.DescarregarForm()
        Navegacao.CarregarForm()
        Navegacao.AtualizarForm()

        Dim CDiv As New VencData
        CDiv.Aniversario()
        CDiv.VencimentoApolice()
    End Sub
    ' FIM EVENTO ATUALIZAR

    ' INICIO EVENTO TUDOBOQUEADO
    Public Sub TudoBloqueado()
        Objeto.TudoBloqueado()
    End Sub
    ' FIM EVENTO TUDOBLOQUEADO

    ' INICIO EVENTO DESBLOQUEADO
    Public Sub Desbloqueado()
        Objeto.Desbloqueado()
    End Sub
    ' FIM EVENTO DESBLOQUEADO

    ' INICIO EVENTO BLOQUEANAVEACAO
    Private Sub Bloqueanavegacao()
        Objeto.Bloqueanavegacao()
    End Sub
    ' FIM EVENTO BLOQUEANAVEGACAO

    ' INICIO EVENTO DESBLOQUEIAMAVEGACAO
    Private Sub DesbloqueiaNavegacao()
        Objeto.DesbloqueiaNavegacao()
    End Sub
    ' FIM EVENTO DESBLOQUEIANAVEGACAO

    ' INICIO EVENTO VALIDACAO
    Private Sub Validacao()
        Dim Validar As New ValidacaoPFisica
        Validar.Validacao()
    End Sub
    ' FIM EVENTO VALIDACAO

    ' INICIO EVENTO VALIDACAOALTERAR
    Private Sub ValidacaoAlterar()
        Dim Validar As New ValidacaoPFisica
        Validar.ValidacaoAlterar()
    End Sub
    ' FIM EVENTO VALIDACAOALTERAR
    '======================================== FIM DOS EVENTOS ==================================================

    '=================================== INICIO NAVEGAÇÃO DOS REGISTROS ========================================
    ' INICIO BOTAO PRIMEIRO REGISTRO
    Private Sub btnPrimeiro_Click(sender As Object, e As EventArgs) Handles btnPrimeiro.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Primeiro)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO PRIMEIRO REGISTRO

    ' INICIO BOTAO VOLTAR REGISTRO
    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Anterior)
        Navegacao.AtualizarForm()
    End Sub
    ' FIM BOTAO VOLTAR REGISTRO

    ' INICIO BOTAO PROXIMO REGISTRO
    Private Sub btnIr_Click(sender As Object, e As EventArgs) Handles btnIr.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Proximo)
        Navegacao.AtualizarForm()
    End Sub
    'FIM BOTAO PROXIMO REGISTRO

    ' INICIO BOTAO ULTIMO REGISTRO
    Private Sub btnUltimo_Click(sender As Object, e As EventArgs) Handles btnUltimo.Click
        Navegacao.MovimentarRegistros(Navegar.registros.Ultimo)
        Navegacao.AtualizarForm()
    End Sub

    Private Sub txtNumCasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumCasa.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nº da casa", "Cadastro de Pessoa Fisica", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtTempoHab_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTempoHab.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        Else
            e.Handled = True
            MessageBox.Show("Digite apenas numeros tempo de habilitação", "Cadastro de Pessoa Fisica", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub txtNextel_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNextel.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False

        ElseIf Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Digite apenas numeros em Nextel ", "Cadastro de Seguradora", _
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            e.Handled = False
        End If
    End Sub

    Private Sub txtNumCasa_TextChanged(sender As Object, e As EventArgs) Handles txtNumCasa.TextChanged

    End Sub
End Class