
namespace Projeto_11_ano
{
    partial class ADDALUNOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.textEE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefoneEE = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNprocesso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textAnoEscolar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textturma = new System.Windows.Forms.TextBox();
            this.Autorizacao = new System.Windows.Forms.CheckBox();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEE = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderProcesso = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderNaluno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAno = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTurma = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProcesso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNaluno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTurma)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(118, 402);
            this.btnOk.Margin = new System.Windows.Forms.Padding(1);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(70, 26);
            this.btnOk.TabIndex = 29;
            this.btnOk.Tag = "btn_ok";
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(10, 402);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(1);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(70, 26);
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Tag = "btn_cancel";
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(94, 161);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(94, 20);
            this.dtpDataNasc.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Data Nascimento";
            // 
            // textEE
            // 
            this.textEE.Location = new System.Drawing.Point(94, 246);
            this.textEE.Name = "textEE";
            this.textEE.Size = new System.Drawing.Size(366, 20);
            this.textEE.TabIndex = 25;
            this.textEE.Validating += new System.ComponentModel.CancelEventHandler(this.textEE_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nome do EE";
            // 
            // txtTelefoneEE
            // 
            this.txtTelefoneEE.Location = new System.Drawing.Point(94, 314);
            this.txtTelefoneEE.Name = "txtTelefoneEE";
            this.txtTelefoneEE.Size = new System.Drawing.Size(128, 20);
            this.txtTelefoneEE.TabIndex = 23;
            this.txtTelefoneEE.Validating += new System.ComponentModel.CancelEventHandler(this.txtTelefoneEE_Validating);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(-1, 321);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(81, 13);
            this.lblTelefone.TabIndex = 22;
            this.lblTelefone.Text = "Telefone do EE";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(7, 78);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(80, 13);
            this.lblNome.TabIndex = 21;
            this.lblNome.Text = "Nome do Aluno";
            // 
            // txtNprocesso
            // 
            this.txtNprocesso.Location = new System.Drawing.Point(106, 37);
            this.txtNprocesso.Name = "txtNprocesso";
            this.txtNprocesso.Size = new System.Drawing.Size(82, 20);
            this.txtNprocesso.TabIndex = 20;
            this.txtNprocesso.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Processo_validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nº Processo";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(106, 78);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(324, 20);
            this.textNome.TabIndex = 31;
            this.textNome.Validating += new System.ComponentModel.CancelEventHandler(this.textNome_validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ano escolar";
            // 
            // textAnoEscolar
            // 
            this.textAnoEscolar.Location = new System.Drawing.Point(94, 111);
            this.textAnoEscolar.Name = "textAnoEscolar";
            this.textAnoEscolar.Size = new System.Drawing.Size(94, 20);
            this.textAnoEscolar.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Turma";
            // 
            // textturma
            // 
            this.textturma.Location = new System.Drawing.Point(313, 111);
            this.textturma.Name = "textturma";
            this.textturma.Size = new System.Drawing.Size(94, 20);
            this.textturma.TabIndex = 35;
            // 
            // Autorizacao
            // 
            this.Autorizacao.AutoSize = true;
            this.Autorizacao.Location = new System.Drawing.Point(250, 164);
            this.Autorizacao.Name = "Autorizacao";
            this.Autorizacao.Size = new System.Drawing.Size(82, 17);
            this.Autorizacao.TabIndex = 37;
            this.Autorizacao.Text = "Autorização";
            this.Autorizacao.UseVisualStyleBackColor = true;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Location = new System.Drawing.Point(519, 25);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(53, 17);
            this.chkEditar.TabIndex = 38;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProviderEE
            // 
            this.errorProviderEE.ContainerControl = this;
            // 
            // errorProviderProcesso
            // 
            this.errorProviderProcesso.ContainerControl = this;
            // 
            // errorProviderNaluno
            // 
            this.errorProviderNaluno.ContainerControl = this;
            // 
            // errorProviderAno
            // 
            this.errorProviderAno.ContainerControl = this;
            // 
            // errorProviderTurma
            // 
            this.errorProviderTurma.ContainerControl = this;
            // 
            // ADDALUNOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_11_ano.Properties.Resources._60f3b53a3fc5213185ed2ce947779476;
            this.ClientSize = new System.Drawing.Size(584, 438);
            this.Controls.Add(this.chkEditar);
            this.Controls.Add(this.Autorizacao);
            this.Controls.Add(this.textturma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAnoEscolar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textEE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefoneEE);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNprocesso);
            this.Name = "ADDALUNOS";
            this.Text = "AddAlunos";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderProcesso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNaluno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTurma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefoneEE;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNprocesso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAnoEscolar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textturma;
        //private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.CheckBox Autorizacao;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProviderEE;
        private System.Windows.Forms.ErrorProvider errorProviderProcesso;
        private System.Windows.Forms.ErrorProvider errorProviderNaluno;
        private System.Windows.Forms.ErrorProvider errorProviderAno;
        private System.Windows.Forms.ErrorProvider errorProviderTurma;
    }
}