Option Compare Text
Imports System.Text
Imports System.Text.RegularExpressions
Public Class ValidacaoPFisica
    Dim Objeto As New F_ObjetoCli
    Dim Navegacao As New Navegar
    Dim strRegex As String = _
"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + "\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + ".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
    Dim re As New Regex(strRegex)
    Public Sub Validacao()


        With PesquisaTS
            If .txtNome.Text.Trim = "" Then
                MessageBox.Show("Informe o nome do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNome.Focus()
                Exit Sub
            ElseIf .cboEstCivil.SelectedIndex = 0 Then
                MessageBox.Show("Informe o estado Civil", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboEstCivil.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCpf.MaskCompleted Then
                MessageBox.Show("CPF Invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtCpf.Focus()
                Exit Sub

            ElseIf Not IsDate(.MaskTxtNascimento.Text) Then
                MessageBox.Show("Data de Nascimento Inválida", "Cadastrar", _
                                MessageBoxButtons.OK)
                PesquisaTS.MaskTxtNascimento.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtDataExp.Text) Then
                MessageBox.Show("Data de Expedição Inválida", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtDataExp.Focus()
                Exit Sub
            ElseIf Not .MaskedTextBox1.MaskCompleted Then
                MessageBox.Show("RG invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf .txtTempoHab.Text.Trim = "" Then
                MessageBox.Show("Informe o Tempo de Habilitação do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtTempoHab.Focus()
                Exit Sub

            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Informe o Endereço do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Informe Numero da casa", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Informe a cidade", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Informe o Bairro", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .MaskTxtResidencial.MaskCompleted Then
                MessageBox.Show("Informe o Telefone residencial", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtResidencial.Focus()
                Exit Sub
            ElseIf Not .MaskedTextBox1.MaskCompleted Then
                MessageBox.Show("RG invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf Not (re.IsMatch(.txtEmail.Text)) And .txtEmail.Text.Trim = "" Then
                MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Cadastrar", _
          MessageBoxButtons.OK)
                .txtEmail.Focus()
                Exit Sub
                '= CBO'S ===========================================
            ElseIf .cboSexo.SelectedIndex = 0 Then
                MessageBox.Show("Informe o sexo do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .txtOrgExp.SelectedIndex = 0 Then
                MessageBox.Show("Informe o orgão expeditor", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboTempoHab.SelectedIndex = 0 Then
                MessageBox.Show("Informe o tempo de halibitação do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboTempoHab.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Informe Status do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Informe o UF", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub

            Else
                PesquisaTS.Cadastrar()
                MessageBox.Show("Foi Cadastrado", "Sola Fide", _
                                MessageBoxButtons.OK)

                Objeto.DesbloqueiaNavegacao()
                Objeto.TudoBloqueado()

            End If
        End With

    End Sub

    Public Sub ValidacaoAlterar()

        With PesquisaTS
            If .txtNome.Text.Trim = "" Then
                MessageBox.Show("Informe o nome do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNome.Focus()
                Exit Sub
            ElseIf .cboEstCivil.SelectedIndex = 0 Then
                MessageBox.Show("Informe o estado Civil", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboEstCivil.Focus()
                Exit Sub
            ElseIf Not .MaskTxtCpf.MaskCompleted Then
                MessageBox.Show("CPF Invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtCpf.Focus()
                Exit Sub

            ElseIf Not IsDate(.MaskTxtNascimento.Text) Then
                MessageBox.Show("Data de Nascimento Inválida", "Cadastrar", _
                                MessageBoxButtons.OK)
                PesquisaTS.MaskTxtNascimento.Focus()
                Exit Sub
            ElseIf Not IsDate(.MaskTxtDataExp.Text) Then
                MessageBox.Show("Data de Expedição Inválida", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtDataExp.Focus()
                Exit Sub
            ElseIf Not .MaskedTextBox1.MaskCompleted Then
                MessageBox.Show("RG invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf .txtTempoHab.Text.Trim = "" Then
                MessageBox.Show("Informe o Tempo de Habilitação do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtTempoHab.Focus()
                Exit Sub

            ElseIf .txtEndereco.Text.Trim = "" Then
                MessageBox.Show("Informe o Endereço do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtEndereco.Focus()
                Exit Sub
            ElseIf .txtNumCasa.Text.Trim = "" Then
                MessageBox.Show("Informe Numero da casa", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtNumCasa.Focus()
                Exit Sub
            ElseIf .txtCidade.Text.Trim = "" Then
                MessageBox.Show("Informe a cidade", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtCidade.Focus()
                Exit Sub
            ElseIf .txtBairro.Text.Trim = "" Then
                MessageBox.Show("Informe o Bairro", "Cadastrar", _
                                MessageBoxButtons.OK)
                .txtBairro.Focus()
                Exit Sub
            ElseIf Not .MaskTxtResidencial.MaskCompleted Then
                MessageBox.Show("Informe o Telefone residencial", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskTxtResidencial.Focus()
                Exit Sub
            ElseIf Not .MaskedTextBox1.MaskCompleted Then
                MessageBox.Show("RG invalido", "Cadastrar", _
                                MessageBoxButtons.OK)
                .MaskedTextBox1.Focus()
                Exit Sub
            ElseIf Not (re.IsMatch(.txtEmail.Text)) And .txtEmail.Text.Trim = "" Then
                MessageBox.Show("Por favor, digite um endereço de E-mail valido", "Cadastrar", _
          MessageBoxButtons.OK)
                .txtEmail.Focus()
                Exit Sub
                '= CBO'S ===========================================
            ElseIf .cboSexo.SelectedIndex = 0 Then
                MessageBox.Show("Informe o sexo do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .txtOrgExp.SelectedIndex = 0 Then
                MessageBox.Show("Informe o orgão expeditor", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboSexo.Focus()
                Exit Sub
            ElseIf .cboTempoHab.SelectedIndex = 0 Then
                MessageBox.Show("Informe o tempo de halibitação do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboTempoHab.Focus()
                Exit Sub
            ElseIf .cboStatus.SelectedIndex = 0 Then
                MessageBox.Show("Informe Status do cliente", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboStatus.Focus()
                Exit Sub
            ElseIf .cboUf.SelectedIndex = 0 Then
                MessageBox.Show("Informe o UF", "Cadastrar", _
                                MessageBoxButtons.OK)
                .cboUf.Focus()
                Exit Sub
            Else

                Dim result As Integer = MessageBox.Show("Quer realmente atualizar esse cliente?", "Sola Fide", MessageBoxButtons.YesNo)
                If result = DialogResult.Cancel Then

                ElseIf result = DialogResult.No Then

                ElseIf result = DialogResult.Yes Then

                    PesquisaTS.Atualizar()

                    Objeto.TudoBloqueado()

                End If

            End If
        End With
    End Sub
End Class
