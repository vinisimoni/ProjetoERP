namespace ProjetoERP.Telas
{
    partial class frmCadastroFornecedor
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cboSitucao = new ComboBox();
            label15 = new Label();
            txtCpfCnpj = new MaskedTextBox();
            label9 = new Label();
            rbJuridica = new RadioButton();
            rbFisica = new RadioButton();
            txtCEP = new MaskedTextBox();
            label8 = new Label();
            label7 = new Label();
            txtUF = new TextBox();
            label6 = new Label();
            txtCidade = new TextBox();
            label5 = new Label();
            txtBairro = new TextBox();
            label4 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            txtNomeFantasia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtRazaoSocial = new TextBox();
            txtCodigo = new TextBox();
            grdFornecedores = new DataGridView();
            btnExcluir = new Button();
            btnIncluir = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdFornecedores).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Enabled = false;
            tabControl1.Location = new Point(12, 168);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(669, 189);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cboSitucao);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(txtCpfCnpj);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(rbJuridica);
            tabPage1.Controls.Add(rbFisica);
            tabPage1.Controls.Add(txtCEP);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtUF);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtCidade);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtBairro);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(txtEndereco);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtNomeFantasia);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtRazaoSocial);
            tabPage1.Controls.Add(txtCodigo);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(661, 161);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // cboSitucao
            // 
            cboSitucao.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSitucao.FormattingEnabled = true;
            cboSitucao.Items.AddRange(new object[] { "Ativo", "Inativo" });
            cboSitucao.Location = new Point(566, 9);
            cboSitucao.Name = "cboSitucao";
            cboSitucao.Size = new Size(85, 23);
            cboSitucao.TabIndex = 24;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(508, 15);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 23;
            label15.Text = "Situação:";
            // 
            // txtCpfCnpj
            // 
            txtCpfCnpj.Location = new Point(377, 8);
            txtCpfCnpj.Name = "txtCpfCnpj";
            txtCpfCnpj.Size = new Size(122, 23);
            txtCpfCnpj.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(311, 15);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 19;
            label9.Text = "CPF/CNPJ:";
            // 
            // rbJuridica
            // 
            rbJuridica.AutoSize = true;
            rbJuridica.Location = new Point(240, 14);
            rbJuridica.Name = "rbJuridica";
            rbJuridica.Size = new Size(65, 19);
            rbJuridica.TabIndex = 22;
            rbJuridica.TabStop = true;
            rbJuridica.Text = "Jurídica";
            rbJuridica.UseVisualStyleBackColor = true;
            rbJuridica.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // rbFisica
            // 
            rbFisica.AutoSize = true;
            rbFisica.Location = new Point(180, 14);
            rbFisica.Name = "rbFisica";
            rbFisica.Size = new Size(54, 19);
            rbFisica.TabIndex = 21;
            rbFisica.TabStop = true;
            rbFisica.Text = "Fisíca";
            rbFisica.UseVisualStyleBackColor = true;
            rbFisica.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // txtCEP
            // 
            txtCEP.Location = new Point(591, 125);
            txtCEP.Mask = "00000-000";
            txtCEP.Name = "txtCEP";
            txtCEP.Size = new Size(60, 23);
            txtCEP.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(557, 131);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 15;
            label8.Text = "CEP:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 131);
            label7.Name = "label7";
            label7.Size = new Size(24, 15);
            label7.TabIndex = 13;
            label7.Text = "UF:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(502, 125);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(40, 23);
            txtUF.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(267, 131);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 11;
            label6.Text = "Cidade:";
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(317, 125);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(145, 23);
            txtCidade.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 131);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 9;
            label5.Text = "Bairro:";
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(107, 125);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(145, 23);
            txtBairro.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 102);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 7;
            label4.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(107, 96);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(544, 23);
            txtEndereco.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 73);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Nome Fantasia:";
            // 
            // txtNomeFantasia
            // 
            txtNomeFantasia.Location = new Point(107, 67);
            txtNomeFantasia.Name = "txtNomeFantasia";
            txtNomeFantasia.Size = new Size(544, 23);
            txtNomeFantasia.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 44);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 3;
            label2.Text = "Razão Social:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 15);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 2;
            label1.Text = "Código:";
            // 
            // txtRazaoSocial
            // 
            txtRazaoSocial.Location = new Point(107, 38);
            txtRazaoSocial.Name = "txtRazaoSocial";
            txtRazaoSocial.Size = new Size(544, 23);
            txtRazaoSocial.TabIndex = 2;
            // 
            // txtCodigo
            // 
            txtCodigo.Enabled = false;
            txtCodigo.Location = new Point(107, 8);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(58, 23);
            txtCodigo.TabIndex = 0;
            txtCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // grdFornecedores
            // 
            grdFornecedores.AllowUserToAddRows = false;
            grdFornecedores.AllowUserToDeleteRows = false;
            grdFornecedores.AllowUserToResizeColumns = false;
            grdFornecedores.AllowUserToResizeRows = false;
            grdFornecedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdFornecedores.Location = new Point(12, 12);
            grdFornecedores.MultiSelect = false;
            grdFornecedores.Name = "grdFornecedores";
            grdFornecedores.ReadOnly = true;
            grdFornecedores.RowHeadersVisible = false;
            grdFornecedores.ScrollBars = ScrollBars.Vertical;
            grdFornecedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdFornecedores.Size = new Size(665, 150);
            grdFornecedores.TabIndex = 2;
            grdFornecedores.CellDoubleClick += grdFornecedores_CellDoubleClick;
            grdFornecedores.CellFormatting += grdFornecedores_CellFormatting;
            grdFornecedores.SelectionChanged += grdFornecedores_SelectionChanged;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(602, 363);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 5;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(521, 363);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 4;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // frmCadastroFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 395);
            Controls.Add(btnExcluir);
            Controls.Add(btnIncluir);
            Controls.Add(tabControl1);
            Controls.Add(grdFornecedores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCadastroFornecedor";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Fornecedor";
            Load += frmCadastroFornecedor_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdFornecedores).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ComboBox cboSitucao;
        private Label label15;
        private MaskedTextBox txtCpfCnpj;
        private Label label9;
        private RadioButton rbJuridica;
        private RadioButton rbFisica;
        private MaskedTextBox txtCEP;
        private Label label8;
        private Label label7;
        private TextBox txtUF;
        private Label label6;
        private TextBox txtCidade;
        private Label label5;
        private TextBox txtBairro;
        private Label label4;
        private TextBox txtEndereco;
        private Label label3;
        private TextBox txtNomeFantasia;
        private Label label2;
        private Label label1;
        private TextBox txtRazaoSocial;
        private TextBox txtCodigo;
        private DataGridView grdFornecedores;
        private Button btnExcluir;
        private Button btnIncluir;
    }
}