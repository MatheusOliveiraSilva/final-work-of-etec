Imports MySql.Data.MySqlClient
Public Class PesquisarCPF_Consu
    Public Sub Consultar()
        Try

            Dim cx As New ConexaoSolafide
            Dim sql As String = ""
            cx.conectar()
            sql = "SELECT * FROM tb_pessoa_fisica" & _
            " INNER JOIN tb_contato_pessoal ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_contato_pessoal.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_endereco On tb_pessoa_fisica.id_Pessoa_Fisica=tb_endereco.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_sexo ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_sexo.tb_Pessoa_Fisica_id_Pessoa_Fisica" & _
            " INNER JOIN tb_estado_civil ON tb_pessoa_fisica.id_Pessoa_Fisica = tb_estado_civil.tb_Pessoa_Fisica_id_Pessoa_Fisica where tb_Pessoa_Fisica.CPF='" & PesquisaTS.PesquisarCPF.Text & "';"
            Dim cmd As New MySqlCommand
            cmd.CommandText = sql
            cmd.Connection = cx.cn

            Dim dr As MySqlDataReader = cmd.ExecuteReader

            If dr.Read Then
                With PesquisaTS




                    .TxtId.Text = dr("Id_pessoa_fisica").ToString
                    .txtNome.Text = dr("Nome_Completo").ToString
                    .MaskTxtCpf.Text = dr("Cpf").ToString
                    .MaskedTextBox1.Text = dr("rg").ToString
                    .MaskTxtDataExp.Text = dr("dt_expedicao").ToString
                    .txtOrgExp.Text = dr("orgao_exped").ToString
                    .MaskTxtNascimento.Text = dr("dt_nascimento").ToString
                    .txtTempoHab.Text = dr("tempo_habilitacao").ToString
                    .txtProfissao.Text = dr("profissao").ToString
                    .txtComentario.Text = dr("comentarios").ToString

                    .MaskTxtCelular.Text = dr("cel_pessoal").ToString
                    .MaskTxtComercial.Text = dr("cel_recado").ToString
                    .MaskTxtResidencial.Text = dr("tel_residencial").ToString
                    .txtNextel.Text = dr("nextel").ToString
                    .txtEmail.Text = dr("email").ToString

                    .txtEndereco.Text = dr("Endereco").ToString
                    .txtNumCasa.Text = dr("Numero").ToString
                    .cboUf.Text = dr("uf").ToString
                    .MaskTxtCep.Text = dr("cep").ToString
                    .txtCidade.Text = dr("cidade").ToString
                    .txtComplemento.Text = dr("Complemento").ToString
                    .txtBairro.Text = dr("bairro").ToString
                    .txtBloco.Text = dr("bloco").ToString

                    .cboSexo.Text = dr("Sexo").ToString
                    .cboEstCivil.Text = dr("Estado_Civil").ToString
                    .txtCNH.Text = dr("cnh").ToString
                End With
            End If
            cx.desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erro ao consultar o CEP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
