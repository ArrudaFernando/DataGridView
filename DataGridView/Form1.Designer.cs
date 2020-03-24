namespace DataGridView
{
    partial class Form1
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
            this.grpboxCadPessoa = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.mtxCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtxRG = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNecessidadeEspeciais = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNecEspeciais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picCPF = new System.Windows.Forms.PictureBox();
            this.picRG = new System.Windows.Forms.PictureBox();
            this.picNecEsp = new System.Windows.Forms.PictureBox();
            this.picSexo = new System.Windows.Forms.PictureBox();
            this.picNome = new System.Windows.Forms.PictureBox();
            this.btnFecharForm1 = new System.Windows.Forms.Button();
            this.grpboxCadPessoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecEsp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSexo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxCadPessoa
            // 
            this.grpboxCadPessoa.Controls.Add(this.btnFecharForm1);
            this.grpboxCadPessoa.Controls.Add(this.picCPF);
            this.grpboxCadPessoa.Controls.Add(this.picRG);
            this.grpboxCadPessoa.Controls.Add(this.picNecEsp);
            this.grpboxCadPessoa.Controls.Add(this.picSexo);
            this.grpboxCadPessoa.Controls.Add(this.picNome);
            this.grpboxCadPessoa.Controls.Add(this.btnExcluir);
            this.grpboxCadPessoa.Controls.Add(this.btnCadastrar);
            this.grpboxCadPessoa.Controls.Add(this.mtxCPF);
            this.grpboxCadPessoa.Controls.Add(this.mtxRG);
            this.grpboxCadPessoa.Controls.Add(this.label2);
            this.grpboxCadPessoa.Controls.Add(this.label1);
            this.grpboxCadPessoa.Controls.Add(this.rbNao);
            this.grpboxCadPessoa.Controls.Add(this.rbSim);
            this.grpboxCadPessoa.Controls.Add(this.cmbSexo);
            this.grpboxCadPessoa.Controls.Add(this.dtpDataNascimento);
            this.grpboxCadPessoa.Controls.Add(this.lblNecessidadeEspeciais);
            this.grpboxCadPessoa.Controls.Add(this.lblSexo);
            this.grpboxCadPessoa.Controls.Add(this.lblDataNascimento);
            this.grpboxCadPessoa.Controls.Add(this.txtNome);
            this.grpboxCadPessoa.Controls.Add(this.lblNome);
            this.grpboxCadPessoa.Location = new System.Drawing.Point(78, 12);
            this.grpboxCadPessoa.Name = "grpboxCadPessoa";
            this.grpboxCadPessoa.Size = new System.Drawing.Size(671, 316);
            this.grpboxCadPessoa.TabIndex = 0;
            this.grpboxCadPessoa.TabStop = false;
            this.grpboxCadPessoa.Text = "Cadastro de Pessoas";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(217, 276);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 20);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(136, 276);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 20);
            this.btnCadastrar.TabIndex = 13;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // mtxCPF
            // 
            this.mtxCPF.Location = new System.Drawing.Point(136, 236);
            this.mtxCPF.Mask = "999.999.999-99";
            this.mtxCPF.Name = "mtxCPF";
            this.mtxCPF.Size = new System.Drawing.Size(100, 20);
            this.mtxCPF.TabIndex = 12;
            this.mtxCPF.TextChanged += new System.EventHandler(this.mtxCPF_TextChanged);
            // 
            // mtxRG
            // 
            this.mtxRG.Location = new System.Drawing.Point(136, 196);
            this.mtxRG.Mask = "99.999.999.9";
            this.mtxRG.Name = "mtxRG";
            this.mtxRG.Size = new System.Drawing.Size(100, 20);
            this.mtxRG.TabIndex = 11;
            this.mtxRG.TextChanged += new System.EventHandler(this.mtxRG_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "RG:";
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(191, 157);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 8;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(143, 159);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 7;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.cmbSexo.Location = new System.Drawing.Point(136, 118);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(100, 21);
            this.cmbSexo.TabIndex = 6;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(136, 78);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dtpDataNascimento.TabIndex = 5;
            this.dtpDataNascimento.FormatChanged += new System.EventHandler(this.dtpDataNascimento_FormatChanged);
            // 
            // lblNecessidadeEspeciais
            // 
            this.lblNecessidadeEspeciais.AutoSize = true;
            this.lblNecessidadeEspeciais.Location = new System.Drawing.Point(8, 161);
            this.lblNecessidadeEspeciais.Name = "lblNecessidadeEspeciais";
            this.lblNecessidadeEspeciais.Size = new System.Drawing.Size(125, 13);
            this.lblNecessidadeEspeciais.TabIndex = 4;
            this.lblNecessidadeEspeciais.Text = "Necessidades Especiais:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(99, 126);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(26, 84);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(136, 38);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(307, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(32, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(95, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Sobrenome:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNome,
            this.colDataNascimento,
            this.colSexo,
            this.colCPF,
            this.colRG,
            this.colNecEspeciais});
            this.dgvClientes.Location = new System.Drawing.Point(78, 343);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(671, 123);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Data de Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            // 
            // colRG
            // 
            this.colRG.HeaderText = "RG";
            this.colRG.Name = "colRG";
            // 
            // colNecEspeciais
            // 
            this.colNecEspeciais.HeaderText = "Necessidades Especiais";
            this.colNecEspeciais.Name = "colNecEspeciais";
            // 
            // picCPF
            // 
            this.picCPF.Image = global::DataGridView.Properties.Resources.check1;
            this.picCPF.Location = new System.Drawing.Point(242, 234);
            this.picCPF.Name = "picCPF";
            this.picCPF.Size = new System.Drawing.Size(29, 20);
            this.picCPF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCPF.TabIndex = 25;
            this.picCPF.TabStop = false;
            // 
            // picRG
            // 
            this.picRG.Image = global::DataGridView.Properties.Resources.check1;
            this.picRG.Location = new System.Drawing.Point(242, 196);
            this.picRG.Name = "picRG";
            this.picRG.Size = new System.Drawing.Size(29, 20);
            this.picRG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRG.TabIndex = 24;
            this.picRG.TabStop = false;
            // 
            // picNecEsp
            // 
            this.picNecEsp.Image = global::DataGridView.Properties.Resources.check1;
            this.picNecEsp.Location = new System.Drawing.Point(242, 154);
            this.picNecEsp.Name = "picNecEsp";
            this.picNecEsp.Size = new System.Drawing.Size(29, 20);
            this.picNecEsp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNecEsp.TabIndex = 23;
            this.picNecEsp.TabStop = false;
            // 
            // picSexo
            // 
            this.picSexo.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picSexo.BackgroundImage = global::DataGridView.Properties.Resources.check;
            this.picSexo.Image = global::DataGridView.Properties.Resources.check1;
            this.picSexo.Location = new System.Drawing.Point(242, 119);
            this.picSexo.Name = "picSexo";
            this.picSexo.Size = new System.Drawing.Size(29, 20);
            this.picSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSexo.TabIndex = 22;
            this.picSexo.TabStop = false;
            // 
            // picNome
            // 
            this.picNome.BackColor = System.Drawing.SystemColors.Window;
            this.picNome.Image = global::DataGridView.Properties.Resources.check1;
            this.picNome.Location = new System.Drawing.Point(449, 38);
            this.picNome.Name = "picNome";
            this.picNome.Size = new System.Drawing.Size(29, 20);
            this.picNome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNome.TabIndex = 15;
            this.picNome.TabStop = false;
            // 
            // btnFecharForm1
            // 
            this.btnFecharForm1.Location = new System.Drawing.Point(581, 276);
            this.btnFecharForm1.Name = "btnFecharForm1";
            this.btnFecharForm1.Size = new System.Drawing.Size(75, 20);
            this.btnFecharForm1.TabIndex = 26;
            this.btnFecharForm1.Text = "Fechar";
            this.btnFecharForm1.UseVisualStyleBackColor = true;
            this.btnFecharForm1.Click += new System.EventHandler(this.btnFecharForm1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.grpboxCadPessoa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpboxCadPessoa.ResumeLayout(false);
            this.grpboxCadPessoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNecEsp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSexo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxCadPessoa;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.MaskedTextBox mtxCPF;
        private System.Windows.Forms.MaskedTextBox mtxRG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblNecessidadeEspeciais;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNecEspeciais;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox picNome;
        private System.Windows.Forms.PictureBox picCPF;
        private System.Windows.Forms.PictureBox picRG;
        private System.Windows.Forms.PictureBox picNecEsp;
        private System.Windows.Forms.PictureBox picSexo;
        private System.Windows.Forms.Button btnFecharForm1;
    }
}

