
namespace Projeto_11_ano
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_entradas = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Saida = new System.Windows.Forms.DataGridView();
            this.ver = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_mover = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saida)).BeginInit();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Turma";
            this.Column3.HeaderText = "Turma";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nome";
            this.Column2.HeaderText = "Nome";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NProcesso";
            this.Column1.HeaderText = "NProcesso";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // dgv_entradas
            // 
            this.dgv_entradas.AllowDrop = true;
            this.dgv_entradas.AllowUserToAddRows = false;
            this.dgv_entradas.AllowUserToDeleteRows = false;
            this.dgv_entradas.AllowUserToOrderColumns = true;
            this.dgv_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Ano,
            this.Column3});
            this.dgv_entradas.Location = new System.Drawing.Point(12, 22);
            this.dgv_entradas.MultiSelect = false;
            this.dgv_entradas.Name = "dgv_entradas";
            this.dgv_entradas.ReadOnly = true;
            this.dgv_entradas.RowHeadersVisible = false;
            this.dgv_entradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_entradas.Size = new System.Drawing.Size(342, 220);
            this.dgv_entradas.TabIndex = 0;
            this.dgv_entradas.Tag = "dgv_Principal";
            this.dgv_entradas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_entradas_CellContentClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Turma";
            this.Column6.HeaderText = "Turma";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // AN
            // 
            this.AN.DataPropertyName = "Ano";
            this.AN.HeaderText = "Ano";
            this.AN.Name = "AN";
            this.AN.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Nome";
            this.Column5.HeaderText = "Nome";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // column4
            // 
            this.column4.DataPropertyName = "NProcesso";
            this.column4.HeaderText = "NºProcesso";
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            // 
            // dgv_Saida
            // 
            this.dgv_Saida.AllowDrop = true;
            this.dgv_Saida.AllowUserToAddRows = false;
            this.dgv_Saida.AllowUserToDeleteRows = false;
            this.dgv_Saida.AllowUserToOrderColumns = true;
            this.dgv_Saida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Saida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column4,
            this.Column5,
            this.AN,
            this.Column6});
            this.dgv_Saida.Location = new System.Drawing.Point(378, 22);
            this.dgv_Saida.Name = "dgv_Saida";
            this.dgv_Saida.ReadOnly = true;
            this.dgv_Saida.RowHeadersVisible = false;
            this.dgv_Saida.Size = new System.Drawing.Size(348, 220);
            this.dgv_Saida.TabIndex = 1;
            // 
            // ver
            // 
            this.ver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ver.Location = new System.Drawing.Point(22, 331);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(104, 39);
            this.ver.TabIndex = 2;
            this.ver.Tag = "btn_ver/Editar";
            this.ver.Text = "Ver/Editar";
            this.ver.UseVisualStyleBackColor = false;
            this.ver.Click += new System.EventHandler(this.ver_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Location = new System.Drawing.Point(188, 331);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(104, 39);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Tag = "";
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_sair.Location = new System.Drawing.Point(500, 331);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(100, 39);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Tag = "";
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_mover
            // 
            this.btn_mover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mover.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_mover.Location = new System.Drawing.Point(332, 331);
            this.btn_mover.Name = "btn_mover";
            this.btn_mover.Size = new System.Drawing.Size(114, 39);
            this.btn_mover.TabIndex = 5;
            this.btn_mover.Tag = "";
            this.btn_mover.Text = "Mover";
            this.btn_mover.UseVisualStyleBackColor = true;
            this.btn_mover.Click += new System.EventHandler(this.btn_mover_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Entrada";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(378, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Saida";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_11_ano.Properties.Resources.ESENnoite;
            this.ClientSize = new System.Drawing.Size(736, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_mover);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.ver);
            this.Controls.Add(this.dgv_Saida);
            this.Controls.Add(this.dgv_entradas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Porteiro Escolar";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_entradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Saida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgv_entradas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn AN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridView dgv_Saida;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_mover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

