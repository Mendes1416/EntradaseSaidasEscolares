using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Projeto_11_ano
{
    public partial class ADDALUNOS : Form
    {
        public  GestDados aluno { get;  set; }
         
        public ADDALUNOS(GestDados aluno)
        {
            this.aluno = aluno;



            InitializeComponent();
            // se clicar na tecla ENTER ou no botão OK assumido a ação OK (aceitar os dados do formulário)
            AcceptButton = btnOk;
            // Se clicar na tyecla ESC ou no botão Cancelar, assume a ação Cancel (Ignorar os dados)
            CancelButton = btnCancel;
            // se clicar na tecla ENTER ou no botão OK assumido a ação OK (aceitar os dados do formulário)
            AcceptButton = btnOk;
            // Se clicar na tyecla ESC ou no botão Cancelar, assume a ação Cancel (Ignorar os dados)
            CancelButton = btnCancel;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (aluno == null) { 
                 aluno = new GestDados(txtNprocesso.Text, textNome.Text,  textAnoEscolar.Text, textturma.Text, dtpDataNasc.Value, textEE.Text, txtTelefoneEE.Text, Autorizacao.Checked);
            } else
            {
                aluno.NProcesso = txtNprocesso.Text;
                aluno.Nome = textNome.Text;
                aluno.Turma =  textturma.Text;
                aluno.Ano =  textAnoEscolar.Text;
                aluno.DataNasc = dtpDataNasc.Value;
                aluno.NomeEE = textEE.Text;
                aluno.TelefoneEE= txtTelefoneEE.Text;
                aluno.Autorizacao = Autorizacao.Checked;
            }
            this.DialogResult = DialogResult.OK;
        }

        private void txtTelefoneEE_Validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidTelefoneEE(txtTelefoneEE.Text))
            {
                e.Cancel = true;
                txtTelefoneEE.SelectAll();
                errorProvider1.SetError(txtTelefoneEE, "Contacto telefónico inválido...");
            }
            else
            {
                e.Cancel = false;
                // Limpar a mensagem de erro
                errorProvider1.SetError(txtTelefoneEE, string.Empty);
            }
        }

        private void textEE_Validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidtextEE(textEE.Text))
            {
                e.Cancel = true;
                textEE.SelectAll();
                errorProviderEE.SetError(textEE, "o Nome do EE deve ter pelos menos entre 7 a 150 caracteres");
            }
            else
            {
                e.Cancel = false;
                errorProviderEE.SetError(textEE, string.Empty);
            }
        }

        private void txt_Processo_validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidtxt_Processo(txtNprocesso.Text))
            {
                e.Cancel = true;
                txtNprocesso.SelectAll();
                errorProviderProcesso.SetError(txtNprocesso, "O Nº dp processo esta invalido...");
            }
            else
            {
                e.Cancel = false;
                errorProviderProcesso.SetError(txtNprocesso, string.Empty);
            }
        }

        private void textNome_validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidtextNome(textNome.Text))
            {
                e.Cancel = true;
                textNome.SelectAll();
                errorProviderNaluno.SetError(textNome, "o Nome do EE deve ter pelos menos entre 7 a 150 caracteres");
            }
            else
            {
                e.Cancel = false;
                errorProviderNaluno.SetError(textNome, string.Empty);
            }
        }
        private void textAnoEscolar_Validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidAnoEscolar(textAnoEscolar.Text))
            {
                e.Cancel = true;
                textAnoEscolar.SelectAll();
                errorProviderAno.SetError(textAnoEscolar, "Ano escolar inválido ");
            }
            else
            {
                e.Cancel = false;
                // Limpar a mensagem de erro
                errorProviderAno.SetError(textAnoEscolar, string.Empty);
            }
        }

        private void textturma_validating(object sender, CancelEventArgs e)
        {
            if (!GestDados.IsValidturma(textturma.Text))
            {
                e.Cancel = true;
                textturma.Select();
                errorProviderTurma.SetError(textturma, " turma inválida");
            }
            else
            {
                e.Cancel = false;
                errorProviderTurma.SetError(textturma, string.Empty);
            }
        }


    }
}
