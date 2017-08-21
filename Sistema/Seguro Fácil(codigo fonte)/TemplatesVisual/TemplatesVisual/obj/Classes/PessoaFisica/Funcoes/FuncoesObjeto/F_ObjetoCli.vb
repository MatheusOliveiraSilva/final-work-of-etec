Public Class F_ObjetoCli

    Public Sub Novo()
        PesquisaTS.TxtId.Text = ""
        PesquisaTS.txtNome.Text = ""
        PesquisaTS.cboEstCivil.SelectedIndex = 0
        PesquisaTS.txtOrgExp.SelectedIndex = 0
        PesquisaTS.MaskTxtNascimento.Text = ""
        PesquisaTS.cboSexo.SelectedIndex = 0
        PesquisaTS.MaskedTextBox1.Text = ""
        PesquisaTS.MaskTxtCpf.Text = ""
        PesquisaTS.txtProfissao.Text = ""
        PesquisaTS.txtCNH.Text = ""
        PesquisaTS.txtTempoHab.Text = ""
        PesquisaTS.MaskTxtCelular.Text = ""
        PesquisaTS.txtNextel.Text = ""
        PesquisaTS.txtEmail.Text = ""
        PesquisaTS.MaskTxtResidencial.Text = ""
        PesquisaTS.txtEndereco.Text = ""
        PesquisaTS.txtNumCasa.Text = ""
        PesquisaTS.cboUf.Text = ""
        PesquisaTS.MaskTxtCep.Text = ""
        PesquisaTS.txtCidade.Text = ""
        PesquisaTS.txtComplemento.Text = ""
        PesquisaTS.txtBairro.Text = ""
        PesquisaTS.txtBloco.Text = ""
        PesquisaTS.txtApto.Text = ""
        PesquisaTS.MaskTxtDataExp.Text = ""
        PesquisaTS.txtCNH.Text = ""
        PesquisaTS.cboTempoHab.Text = ""
        PesquisaTS.MaskTxtComercial.Text = ""
        PesquisaTS.txtComentario.Text = ""
        PesquisaTS.cboStatus.SelectedIndex = 0
        PesquisaTS.cboTempoHab.SelectedIndex = 0
        PesquisaTS.cboUf.SelectedIndex = 0

        PesquisaTS.txtNome.Focus()
        PesquisaTS.btnCancelar.Visible = True
        PesquisaTS.btnImprimir.Visible = False
    End Sub

    Public Sub Desbloqueado()
        PesquisaTS.txtNome.Enabled = True
        PesquisaTS.cboEstCivil.Enabled = True
        PesquisaTS.txtOrgExp.Enabled = True
        PesquisaTS.MaskTxtNascimento.Enabled = True
        PesquisaTS.cboSexo.Enabled = True
        PesquisaTS.MaskedTextBox1.Enabled = True
        PesquisaTS.MaskTxtCpf.Enabled = True
        PesquisaTS.txtProfissao.Enabled = True
        PesquisaTS.txtCNH.Enabled = True
        PesquisaTS.txtTempoHab.Enabled = True
        PesquisaTS.MaskTxtCelular.Enabled = True
        PesquisaTS.txtNextel.Enabled = True
        PesquisaTS.txtEmail.Enabled = True
        PesquisaTS.MaskTxtResidencial.Enabled = True
        PesquisaTS.txtEndereco.Enabled = True
        PesquisaTS.txtNumCasa.Enabled = True
        PesquisaTS.cboUf.Enabled = True
        PesquisaTS.MaskTxtCep.Enabled = True
        PesquisaTS.txtCidade.Enabled = True
        PesquisaTS.txtComplemento.Enabled = True
        PesquisaTS.txtBairro.Enabled = True
        PesquisaTS.txtBloco.Enabled = True
        PesquisaTS.txtApto.Enabled = True
        PesquisaTS.MaskTxtDataExp.Enabled = True
        PesquisaTS.txtCNH.Enabled = True
        PesquisaTS.txtCNH.Enabled = True
        PesquisaTS.BtnCadastrar.Enabled = True
        PesquisaTS.cboTempoHab.Enabled = True
        PesquisaTS.MaskTxtComercial.Enabled = True
        PesquisaTS.txtComentario.Enabled = True
        PesquisaTS.cboStatus.Enabled = True
    End Sub

    Public Sub TudoBloqueado()
        PesquisaTS.txtNome.Enabled = False
        PesquisaTS.cboEstCivil.Enabled = False
        PesquisaTS.txtOrgExp.Enabled = False
        PesquisaTS.MaskTxtNascimento.Enabled = False
        PesquisaTS.cboSexo.Enabled = False
        PesquisaTS.MaskedTextBox1.Enabled = False
        PesquisaTS.MaskTxtCpf.Enabled = False
        PesquisaTS.txtProfissao.Enabled = False
        PesquisaTS.txtCNH.Enabled = False
        PesquisaTS.txtTempoHab.Enabled = False
        PesquisaTS.MaskTxtCelular.Enabled = False
        PesquisaTS.txtNextel.Enabled = False
        PesquisaTS.txtEmail.Enabled = False
        PesquisaTS.MaskTxtResidencial.Enabled = False
        PesquisaTS.txtEndereco.Enabled = False
        PesquisaTS.txtNumCasa.Enabled = False
        PesquisaTS.cboUf.Enabled = False
        PesquisaTS.MaskTxtCep.Enabled = False
        PesquisaTS.txtCidade.Enabled = False
        PesquisaTS.txtComplemento.Enabled = False
        PesquisaTS.txtBairro.Enabled = False
        PesquisaTS.txtBloco.Enabled = False
        PesquisaTS.txtApto.Enabled = False
        PesquisaTS.MaskTxtDataExp.Enabled = False
        PesquisaTS.txtCNH.Enabled = False
        PesquisaTS.txtCNH.Enabled = False
        PesquisaTS.BtnCadastrar.Enabled = False
        PesquisaTS.cboTempoHab.Enabled = False
        PesquisaTS.MaskTxtComercial.Enabled = False
        PesquisaTS.txtComentario.Enabled = False
        PesquisaTS.cboStatus.Enabled = False

        DesbloqueiaNavegacao()
        PesquisaTS.btnCancelar.Visible = False
        PesquisaTS.btnPrimeiro.Enabled = False
        PesquisaTS.btnVoltar.Enabled = False
    End Sub

    Public Sub Bloqueanavegacao()
        PesquisaTS.btnPrimeiro.Enabled = False
        PesquisaTS.btnVoltar.Enabled = False
        PesquisaTS.btnIr.Enabled = False
        PesquisaTS.btnUltimo.Enabled = False
        PesquisaTS.btnAlterar.Enabled = False
        PesquisaTS.btnExcluir.Enabled = False
        PesquisaTS.PesquisarCPF.Enabled = False
    End Sub

    Public Sub DesbloqueiaNavegacao()
        PesquisaTS.btnPrimeiro.Enabled = True
        PesquisaTS.btnVoltar.Enabled = True
        PesquisaTS.btnIr.Enabled = True
        PesquisaTS.btnUltimo.Enabled = True
        PesquisaTS.btnAlterar.Enabled = True
        PesquisaTS.btnExcluir.Enabled = True
        PesquisaTS.BtLimpar.Enabled = True
        PesquisaTS.btnCancelar.Enabled = True
        PesquisaTS.PesquisarCPF.Enabled = True
        PesquisaTS.btnImprimir.Visible = True
    End Sub
End Class
