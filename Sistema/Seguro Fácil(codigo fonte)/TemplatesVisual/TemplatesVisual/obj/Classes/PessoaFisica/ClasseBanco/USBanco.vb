Imports MySql.Data.MySqlClient

Public Class USBanco
    'AQUI É A FUNÇÃO DO BANCO
    ' Public idPessoaFisica As String
    Dim Conexao As New ConexaoSolafide

    Public Function UsandoDadosClientes(Clientes As BancoCliente) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_pessoa_fisica(Nome_Completo, Cpf, rg, dt_expedicao, orgao_exped, CNH, tempo_habilitacao,especif_temp_hap, dt_nascimento, profissao,comentarios,status)" & _
                "values('" & Clientes.Nome & "','" & Clientes.CPF & "','" & Clientes.RG & "','" & Clientes.Data_Expedicao & "', '" & Clientes.Orgao_Expeditor & "','" & Clientes.CNH & "','" & Clientes.Tempo_Habilitacao & "','" & Clientes.Especificacao & "','" & Clientes.Data_Nasc & "','" & Clientes.Profissao & "','" & Clientes.Comentario & "','" & Clientes.Status & "');"

        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try

            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados de Pessoas fisicas - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosEndereco(Endereco As BancoEndereco) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_endereco(Endereco, Numero, cep, bairro, cidade, uf, bloco, Complemento, tb_Pessoa_Fisica_id_Pessoa_Fisica)" & _
                                         "values('" & Endereco.Rua_Av & "', '" & Endereco.numero & "', '" & Endereco.CEP & "', '" & Endereco.Bairro & "', '" & Endereco.Cidade & "', '" & Endereco.UF & "','" & Endereco.Bloco & "', '" & Endereco.complemento & "','" & Endereco.IdPessoaFisica & "');"
       Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela Endereco - " & ex.Message)
        Finally

            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosBancoSexo(Sexo As BancoSexo) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO tb_sexo(Sexo,tb_Pessoa_Fisica_id_Pessoa_Fisica) values('" & Sexo.Descricao & "', '" & Sexo.IdPessoaFisica & "');"
       Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela Sexo - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosEstadoCivil(EstadoCivil As BancoEstadoCivil) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO tb_estado_civil(Estado_Civil,tb_Pessoa_Fisica_id_Pessoa_Fisica) values('" & EstadoCivil.EstadoCivil & "','" & EstadoCivil.IdPessoaFisica & "');"
        Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela EstadoCivil - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
    Public Function UsandoDadosContato(Contato As BancoContato) As String
        Conexao.conectar()
        Dim Sql As String = " INSERT INTO tb_contato_pessoal(tel_residencial,tel_recado,cel_pessoal,nextel,email,tb_Pessoa_Fisica_id_Pessoa_Fisica)" & _
                                         "values('" & Contato.TelResidencial & "', '" & Contato.TelComercial & "', '" & Contato.Celular & "', '" & Contato.Nextel & "', '" & Contato.Email & "','" & Contato.IdPessoaFisica & "');"
       Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela Contato - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString

    End Function
    Public Function UsandoDadosItem(Item As BancoItem) As String
        Conexao.conectar()
        Dim Sql As String = "INSERT INTO tb_item(item,tb_Pessoa_Fisica_id_Pessoa_Fisica) VALUES ('" & Item.ItemPessoa & "', '" & Item.IdPessoaFisica & "');"
                                         
       Dim CMD As MySqlCommand = New MySqlCommand(Sql, Conexao.cn)
        Try
            CMD.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao inserir dados na tabela Item - " & ex.Message)
        Finally
            CMD.Connection.Close()

        End Try
        Return Sql.ToString
    End Function
End Class
