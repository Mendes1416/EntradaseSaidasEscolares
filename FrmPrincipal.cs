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
    

    public partial class FrmPrincipal : Form
    {
        
        private BindingList<GestDados> AlunosSaida = new BindingList<GestDados>();
       

        public FrmPrincipal()
        {
            InitializeComponent();
           
        }
        
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            dgv_entradas.DataSource = Escola.Alunos==true ;
            dgv_entradas.Columns[dgv_entradas.Columns.Count - 1].Visible = false;
            dgv_entradas.Columns[dgv_entradas.Columns.Count - 2].Visible = false;
            dgv_entradas.Columns[dgv_entradas.Columns.Count - 3].Visible = false;
            dgv_Saida.DataSource = Escola.Alunos== false;
            dgv_Saida.Columns[dgv_entradas.Columns.Count - 1].Visible = false;
            dgv_Saida.Columns[dgv_entradas.Columns.Count - 2].Visible = false;
            dgv_Saida.Columns[dgv_entradas.Columns.Count - 3].Visible = false;

        }


        

        private void ver_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            GestDados itemSelecionado = (GestDados)dgv_entradas.CurrentRow.DataBoundItem;
            ADDALUNOS frm = new ADDALUNOS(itemSelecionado);
            frm.ShowDialog();
            Escola.Alunos[Escola.Alunos.IndexOf(itemSelecionado)] = frm.aluno;
        }

        private void btn_mover_Click(object sender, EventArgs e)
        {
            GestDados itemSelecionado = (GestDados)dgv_entradas.CurrentRow.DataBoundItem;
            if (itemSelecionado.Autorizacao || itemSelecionado.idade >= 18)
            {
                if (itemSelecionado.Autorizacao)
                {
                    MessageBox.Show("Este aluno tem Autorização.");
                } else
                {
                    MessageBox.Show("Este aluno tem mais de 18 anos..");
                }
                Escola.Alunos.Remove(itemSelecionado);
                AlunosSaida.Add(itemSelecionado);
            }
            else
            {
                MessageBox.Show("Este aluno não tem Autorização.");
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            ADDALUNOS frm = new ADDALUNOS(null);
            frm.ShowDialog();
            Escola.Alunos.Add(frm.aluno);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgv_entradas_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgv_entradas.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in dgv_entradas.Rows)
            {
                GestDados gestDados = (GestDados)row.DataBoundItem;
                if (gestDados.NaEscola == true) // Verifique aqui o critério necessário
                {
                    gestDados.NaEscola = false;
                    // Atualize outros dados relevantes do objeto GestDados, se necessário
                }
                row.Visible = gestDados.NaEscola;
            }
            currencyManager1.ResumeBinding();
        }

        private void dgv_Saida_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgv_entradas.DataSource];
            currencyManager1.SuspendBinding();
            foreach (DataGridViewRow row in dgv_Saida.Rows)
            {
                GestDados gestDados = (GestDados)row.DataBoundItem;
                if (gestDados.NaEscola == true) // Verifique aqui o critério necessário
                {
                    gestDados.NaEscola = false;
                    // Atualize outros dados relevantes do objeto GestDados, se necessário
                }
                row.Visible = !gestDados.NaEscola;
            }
            currencyManager1.ResumeBinding();
        }


        //ficheiro binario
        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string nomeFicheiro = "dados.bin";
            Escola.GuardarDados(nomeFicheiro);
        }

        private void dgv_entradas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


