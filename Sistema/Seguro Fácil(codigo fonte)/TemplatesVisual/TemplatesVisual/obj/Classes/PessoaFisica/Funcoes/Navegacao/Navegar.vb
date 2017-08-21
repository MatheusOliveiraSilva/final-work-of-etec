Imports MySql.Data.MySqlClient
Public Class Navegar
    Dim adaptador As New DataTable
    Dim posicao As Integer = 0
    Public Enum registros
        Anterior
        Primeiro
        Proximo
        Ultimo
    End Enum
    Public Sub CarregarForm()

        Dim Conectando As String = ("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
        Dim Conexao As New MySqlConnection(Conectando)

        Try

            Dim adtp As New MySqlDataAdapter("SELECT * FROM tb_pessoa_fisica" & _
            " INNER JOIN tb_contato_pessoal ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_contato_pessoal.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_endereco On tb_pessoa_fisica.id_Pessoa_Fisica=tb_endereco.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_sexo ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_sexo.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_estado_civil ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_estado_civil.tb_Pessoa_Fisica_id_Pessoa_Fisica", Conexao)
            adtp.Fill(adaptador)

        Catch ex As Exception

        Finally
            Conexao.Close()
        End Try
    End Sub
    Public Sub DescarregarForm()
        Try
            adaptador.Clear()

        Catch ex As Exception

        End Try
    End Sub
    Public Sub AtualizarForm()
        Try
            PesquisaTS.TxtId.Text = adaptador.Rows(posicao)("Id_pessoa_fisica").ToString
            PesquisaTS.txtNome.Text = adaptador.Rows(posicao)("Nome_Completo").ToString
            PesquisaTS.MaskTxtCpf.Text = adaptador.Rows(posicao)("Cpf").ToString
            PesquisaTS.MaskedTextBox1.Text = adaptador.Rows(posicao)("rg").ToString
            PesquisaTS.MaskTxtDataExp.Text = adaptador.Rows(posicao)("dt_expedicao").ToString
            PesquisaTS.txtOrgExp.Text = adaptador.Rows(posicao)("orgao_exped").ToString
            PesquisaTS.MaskTxtNascimento.Text = adaptador.Rows(posicao)("dt_nascimento").ToString
            PesquisaTS.txtTempoHab.Text = adaptador.Rows(posicao)("tempo_habilitacao").ToString
            PesquisaTS.txtProfissao.Text = adaptador.Rows(posicao)("profissao").ToString
            PesquisaTS.cboStatus.Text = adaptador.Rows(posicao)("Status").ToString
            PesquisaTS.txtComentario.Text = adaptador.Rows(posicao)("comentarios").ToString
            PesquisaTS.cboTempoHab.Text = adaptador.Rows(posicao)("especif_temp_hap").ToString

            PesquisaTS.MaskTxtCelular.Text = adaptador.Rows(posicao)("cel_pessoal").ToString
            PesquisaTS.MaskTxtComercial.Text = adaptador.Rows(posicao)("tel_recado").ToString
            PesquisaTS.MaskTxtResidencial.Text = adaptador.Rows(posicao)("tel_residencial").ToString
            PesquisaTS.txtNextel.Text = adaptador.Rows(posicao)("nextel").ToString
            PesquisaTS.txtEmail.Text = adaptador.Rows(posicao)("email").ToString

            PesquisaTS.txtEndereco.Text = adaptador.Rows(posicao)("Endereco").ToString
            PesquisaTS.txtNumCasa.Text = adaptador.Rows(posicao)("Numero").ToString
            PesquisaTS.cboUf.Text = adaptador.Rows(posicao)("uf").ToString
            PesquisaTS.MaskTxtCep.Text = adaptador.Rows(posicao)("cep").ToString
            PesquisaTS.txtCidade.Text = adaptador.Rows(posicao)("cidade").ToString
            PesquisaTS.txtComplemento.Text = adaptador.Rows(posicao)("Complemento").ToString
            PesquisaTS.txtBairro.Text = adaptador.Rows(posicao)("bairro").ToString
            PesquisaTS.txtBloco.Text = adaptador.Rows(posicao)("bloco").ToString


            PesquisaTS.cboSexo.Text = adaptador.Rows(posicao)("Sexo").ToString
            PesquisaTS.cboEstCivil.Text = adaptador.Rows(posicao)("Estado_Civil").ToString
            PesquisaTS.txtCNH.Text = adaptador.Rows(posicao)("cnh").ToString
        Catch ex As Exception
            'MessageBox.Show("Você não tem clientes cadastrados", "Cadastro de Pessoa Física", _
            ' MessageBoxButtons.OK)
        End Try
    End Sub
    Public Sub MovimentarRegistros(ByVal e As registros)
        Select Case e
            Case registros.Primeiro
                posicao = 0
                PesquisaTS.btnPrimeiro.Enabled = False
                PesquisaTS.btnVoltar.Enabled = False
                PesquisaTS.btnIr.Enabled = True
                PesquisaTS.btnUltimo.Enabled = True
            Case registros.Anterior
                If posicao > 1 Then
                    posicao -= 1
                    PesquisaTS.btnPrimeiro.Enabled = True
                    PesquisaTS.btnVoltar.Enabled = True
                    PesquisaTS.btnIr.Enabled = True
                    PesquisaTS.btnUltimo.Enabled = True
                Else
                    posicao = 0
                    PesquisaTS.btnPrimeiro.Enabled = False
                    PesquisaTS.btnVoltar.Enabled = False
                    PesquisaTS.btnIr.Enabled = True
                    PesquisaTS.btnUltimo.Enabled = True
                End If

            Case registros.Proximo
                If posicao < (adaptador.Rows.Count - 2) Then
                    posicao += 1
                    PesquisaTS.btnPrimeiro.Enabled = True
                    PesquisaTS.btnVoltar.Enabled = True
                    PesquisaTS.btnIr.Enabled = True
                    PesquisaTS.btnUltimo.Enabled = True
                Else
                    posicao = adaptador.Rows.Count - 1
                    PesquisaTS.btnPrimeiro.Enabled = True
                    PesquisaTS.btnVoltar.Enabled = True
                    PesquisaTS.btnIr.Enabled = False
                    PesquisaTS.btnUltimo.Enabled = False
                End If


            Case registros.Ultimo
                posicao = adaptador.Rows.Count - 1
                PesquisaTS.btnPrimeiro.Enabled = True
                PesquisaTS.btnVoltar.Enabled = True
                PesquisaTS.btnIr.Enabled = False
                PesquisaTS.btnUltimo.Enabled = False

        End Select
    End Sub

End Class
