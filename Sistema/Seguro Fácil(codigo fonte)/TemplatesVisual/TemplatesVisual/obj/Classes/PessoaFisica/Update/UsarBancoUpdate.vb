Imports MySql.Data.MySqlClient
Public Class UsarBancoUpdate
    Public Function UpdateCliente(UPClientes As UpdateCliente) As String

        Dim CMD As New MySqlCommand("UPDATE tb_Pessoa_Fisica SET `Nome_Completo`='" & UPClientes.Nome & "', `Cpf`='" & UPClientes.CPF & "', `rg`='" & UPClientes.RG & "', `dt_expedicao`='" & UPClientes.Data_Expedicao & "', `orgao_exped`='" & UPClientes.Orgao_Expeditor & "', `cnh`='" & UPClientes.CNH & "',`tempo_habilitacao`='" & UPClientes.Tempo_Habilitacao & "', `dt_nascimento`='" & UPClientes.Data_Nasc & "', `profissao`='" & UPClientes.Profissao & "', `comentarios`='" & UPClientes.comentarios & "', `status`='" & UPClientes.Status & "' WHERE `id_Pessoa_Fisica` ='" & UPClientes.ID & "'")

        Try

            CMD.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD.Connection.Open()
            CMD.ExecuteNonQuery()

            MsgBox("Foi Atualizado!")
        Catch ex As Exception
            MsgBox("Erro ao Alterar Pessoa Fisica-" + ex.Message)
        Finally
            CMD.Connection.Close()
        End Try
    End Function
    Public Function UpdateEndereco(UP_Endereco As UpdateEndereco) As String

        Dim CMD1 As New MySqlCommand("UPDATE tb_endereco SET `Endereco`='" & UP_Endereco.Rua_Av & "', `Numero`='" & UP_Endereco.numero & "', `cep`='" & UP_Endereco.CEP & "', `bairro`='" & UP_Endereco.Bairro & "', `cidade`='" & UP_Endereco.Cidade & "', `uf`='" & UP_Endereco.UF & "', `bloco`='" & UP_Endereco.Bloco & "', `Complemento`='" & UP_Endereco.complemento & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & UP_Endereco.IdPessoaFisica & "'")

        Try

            CMD1.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD1.Connection.Open()
            CMD1.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Alterar Endereço de Pessoa Fisica-" & ex.Message)
        Finally
            CMD1.Connection.Close()
        End Try
    End Function
    Public Function UpdateSexo(Sexo As UpdateSexo) As String

        Dim CMD2 As New MySqlCommand(" UPDATE tb_sexo SET `Sexo`='" & Sexo.Descricao & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & Sexo.IdPessoaFisica & "'")
        Try

            CMD2.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD2.Connection.Open()
            CMD2.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Alterar o Sexo de Pessoa Fisica-" & ex.Message)
        Finally
            CMD2.Connection.Close()
        End Try
    End Function
    Public Function UpdateEstadoCivil(Up_EstadoCivil As Update_EstadoCivil) As String

        Dim CMD3 As New MySqlCommand(" UPDATE tb_estado_civil SET `Estado_Civil`='" & Up_EstadoCivil.EstadoCivil & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & Up_EstadoCivil.IdPessoaFisica & "'")

        Try

            CMD3.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD3.Connection.Open()
            CMD3.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Alterar o Estado Civil-" & ex.Message)
        Finally
            CMD3.Connection.Close()
        End Try
    End Function
    Public Function UpdateContato(Up_Contato As UpdateContato) As String

        Dim CMD4 As New MySqlCommand(" UPDATE tb_contato_pessoal SET `tel_residencial`='" & Up_Contato.TelResidencial & "',`tel_Recado`='" & Up_Contato.TelComercial & "',`cel_pessoal`='" & Up_Contato.Celular & "',`nextel`='" & Up_Contato.Nextel & "',`email`='" & Up_Contato.Email & "' WHERE `tb_Pessoa_Fisica_id_Pessoa_Fisica`='" & Up_Contato.IdPessoaFisica & "'")

        Try

            CMD4.Connection = New MySqlConnection("server=localhost; Database=solafide_v6; Uid=root; Pwd=eagle;")
            CMD4.Connection.Open()
            CMD4.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Erro ao Alterar Contato de Pessoa Fisica-" & ex.Message)
        Finally
            CMD4.Connection.Close()
        End Try
    End Function
End Class
